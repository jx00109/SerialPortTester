using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtocolTester
{
    public partial class MainForm : Form
    {
        //初始化下拉串口名称列表框  
        string[] ports = SerialPort.GetPortNames();
        private SerialPort comm = new SerialPort();

        //测试用串口
        private static SerialPort tempPort = new SerialPort();

        //测试标志
        private bool flag = true;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //给ComboBox绑定数据
            Array.Sort(ports);
            cbPort.Items.AddRange(ports);

            //初始化界面上的选项
            cbPort.SelectedIndex = cbPort.Items.Count > 0 ? 0 : -1;
            cbBaudrate.SelectedIndex = 0;
            cbDatabits.SelectedIndex = 0;
            cbStopbits.SelectedIndex = 0;

            //测试用临时端口
            if (flag)
            {
                tempPort.PortName = "COM3";
                tempPort.BaudRate = 9600;
                tempPort.DataBits = 8;
                tempPort.StopBits = StopBits.One;

                tempPort.DataReceived += new SerialDataReceivedEventHandler(myReceiveHandler);
            }

            comm.DataReceived += new SerialDataReceivedEventHandler(myReceiveHandler);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cbPort.Items.Count == 0)
            {
                Utils.ShowWarning("请检查串口，当前没有可用串口！");
            }
            else
            {
                if (comm.IsOpen)
                {
                    DialogResult r = Utils.ShowOKCancel("串口"+comm.PortName+"已经打开，是否关闭该串口？");
                    if (r == DialogResult.OK)
                    {
                        comm.Close();
                        btnOpen.Text = "打开";

                        cbPort.Enabled = true;
                        cbBaudrate.Enabled = true;
                        cbDatabits.Enabled = true;
                        cbStopbits.Enabled = true;

                        if (tempPort.IsOpen)
                        {
                            tempPort.Close();
                        }
                    }

                }
                else
                {
                    comm.PortName = cbPort.Text;
                    comm.BaudRate = int.Parse(cbBaudrate.Text);
                    comm.DataBits = int.Parse(cbDatabits.Text);

                    switch (cbStopbits.Text)
                    {
                        case "1":
                            comm.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            comm.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            comm.StopBits = StopBits.Two;
                            break;
                        default:
                            comm.StopBits = StopBits.None;
                            break;
                    }                   

                    comm.Open();

                    if (comm.IsOpen)
                    {
                        Utils.ShowInfo("打开串口成功");
                        btnOpen.Text = "关闭";

                        cbPort.Enabled = false;
                        cbBaudrate.Enabled = false;
                        cbDatabits.Enabled = false;
                        cbStopbits.Enabled = false;

                        if (flag)
                        {
                            tempPort.Open();
                        }
                        
                        Console.WriteLine(comm.PortName);
                        Console.WriteLine(comm.BaudRate);
                        Console.WriteLine(comm.DataBits);
                        Console.WriteLine(comm.StopBits);
                    }
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCommand.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!comm.IsOpen)
            {
                Utils.ShowWarning("请先打开串口！");
            }
            else
            {
                //完整协议总长，一个16进制位长度为1
                int commandsLength = 24;
                String commands = tbCommand.Text.Trim();

                if (commands == "")
                {
                    Utils.ShowWarning("命令不能为空！");
                }
                else if (commands.Length % commandsLength != 0)
                {
                    Utils.ShowWarning("包含不完整命令，请检查。");
                }
                else
                {
                    int count = commands.Length / commandsLength;
                    for (int i = 0; i < count; i++)
                    {
                        String command = commands.Substring(0, commandsLength);
                        //Console.WriteLine(command);
                        //将命令写入串口
                        byte[] c = Utils.hexString2Bytes(command);
                        comm.Write(c, 0, c.Length);
                        commands = commands.Substring(commandsLength, commands.Length - commandsLength);
                    }

                }
            }
        }

        private void myReceiveHandler(object sender, SerialDataReceivedEventArgs e)
        {

            //由于tbReceiveData是在主线程上创建的，所以不能直接在其他线程中访问，需要利用委托访问相应控件
            if (this.tbReceivedData.InvokeRequired)
            {
                SerialDataReceivedEventHandler sdreh = new SerialDataReceivedEventHandler(myReceiveHandler);
                this.Invoke(sdreh, new object[] { sender, e });
            }
            else
            {
                if (flag)
                {
                    byte[] buffer = new byte[tempPort.BytesToRead];
                    tempPort.Read(buffer, 0, buffer.Length);

                    String receivedData = Utils.Bytes2String(buffer);
                    this.tbReceivedData.AppendText(receivedData + "\r\n");
                }
                else
                {                    
                    byte[] buffer = new byte[comm.BytesToRead];
                    comm.Read(buffer, 0, buffer.Length);

                    String receivedData = Utils.Bytes2String(buffer);
                    this.tbReceivedData.AppendText(receivedData + "\r\n");
                }
            }
        }

    }
}
