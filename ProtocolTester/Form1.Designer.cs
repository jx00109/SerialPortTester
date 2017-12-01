namespace ProtocolTester
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPort = new System.Windows.Forms.GroupBox();
            this.cbStopbits = new System.Windows.Forms.ComboBox();
            this.lbStopbit = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbDatabits = new System.Windows.Forms.ComboBox();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbDatabit = new System.Windows.Forms.Label();
            this.lbBaudrate = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.gbSendCommand = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.lbSendCommand = new System.Windows.Forms.Label();
            this.gbReceiveData = new System.Windows.Forms.GroupBox();
            this.tbReceivedData = new System.Windows.Forms.TextBox();
            this.gbPort.SuspendLayout();
            this.gbSendCommand.SuspendLayout();
            this.gbReceiveData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPort
            // 
            this.gbPort.Controls.Add(this.cbStopbits);
            this.gbPort.Controls.Add(this.lbStopbit);
            this.gbPort.Controls.Add(this.btnOpen);
            this.gbPort.Controls.Add(this.cbDatabits);
            this.gbPort.Controls.Add(this.cbBaudrate);
            this.gbPort.Controls.Add(this.cbPort);
            this.gbPort.Controls.Add(this.lbDatabit);
            this.gbPort.Controls.Add(this.lbBaudrate);
            this.gbPort.Controls.Add(this.lbPort);
            this.gbPort.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbPort.Location = new System.Drawing.Point(12, 12);
            this.gbPort.Name = "gbPort";
            this.gbPort.Size = new System.Drawing.Size(277, 264);
            this.gbPort.TabIndex = 0;
            this.gbPort.TabStop = false;
            this.gbPort.Text = "串口配置";
            // 
            // cbStopbits
            // 
            this.cbStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopbits.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStopbits.FormattingEnabled = true;
            this.cbStopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopbits.Location = new System.Drawing.Point(131, 171);
            this.cbStopbits.Name = "cbStopbits";
            this.cbStopbits.Size = new System.Drawing.Size(120, 29);
            this.cbStopbits.TabIndex = 8;
            // 
            // lbStopbit
            // 
            this.lbStopbit.AutoSize = true;
            this.lbStopbit.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStopbit.Location = new System.Drawing.Point(36, 174);
            this.lbStopbit.Name = "lbStopbit";
            this.lbStopbit.Size = new System.Drawing.Size(73, 21);
            this.lbStopbit.TabIndex = 7;
            this.lbStopbit.Text = "停止位";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(130, 215);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(121, 34);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbDatabits
            // 
            this.cbDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabits.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDatabits.FormattingEnabled = true;
            this.cbDatabits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cbDatabits.Location = new System.Drawing.Point(131, 126);
            this.cbDatabits.Name = "cbDatabits";
            this.cbDatabits.Size = new System.Drawing.Size(120, 29);
            this.cbDatabits.TabIndex = 5;
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudrate.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600"});
            this.cbBaudrate.Location = new System.Drawing.Point(131, 81);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(120, 29);
            this.cbBaudrate.TabIndex = 4;
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(131, 36);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(120, 29);
            this.cbPort.TabIndex = 3;
            // 
            // lbDatabit
            // 
            this.lbDatabit.AutoSize = true;
            this.lbDatabit.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDatabit.Location = new System.Drawing.Point(36, 129);
            this.lbDatabit.Name = "lbDatabit";
            this.lbDatabit.Size = new System.Drawing.Size(73, 21);
            this.lbDatabit.TabIndex = 2;
            this.lbDatabit.Text = "数据位";
            // 
            // lbBaudrate
            // 
            this.lbBaudrate.AutoSize = true;
            this.lbBaudrate.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBaudrate.Location = new System.Drawing.Point(36, 84);
            this.lbBaudrate.Name = "lbBaudrate";
            this.lbBaudrate.Size = new System.Drawing.Size(73, 21);
            this.lbBaudrate.TabIndex = 1;
            this.lbBaudrate.Text = "波特率";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPort.Location = new System.Drawing.Point(36, 39);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(74, 21);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "串  口";
            // 
            // gbSendCommand
            // 
            this.gbSendCommand.Controls.Add(this.btnClear);
            this.gbSendCommand.Controls.Add(this.btnSend);
            this.gbSendCommand.Controls.Add(this.tbCommand);
            this.gbSendCommand.Controls.Add(this.lbSendCommand);
            this.gbSendCommand.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSendCommand.Location = new System.Drawing.Point(295, 12);
            this.gbSendCommand.Name = "gbSendCommand";
            this.gbSendCommand.Size = new System.Drawing.Size(477, 264);
            this.gbSendCommand.TabIndex = 1;
            this.gbSendCommand.TabStop = false;
            this.gbSendCommand.Text = "PC -> EMS";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(78, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(266, 214);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 34);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(6, 81);
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(465, 119);
            this.tbCommand.TabIndex = 2;
            // 
            // lbSendCommand
            // 
            this.lbSendCommand.AutoSize = true;
            this.lbSendCommand.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSendCommand.Location = new System.Drawing.Point(6, 39);
            this.lbSendCommand.Name = "lbSendCommand";
            this.lbSendCommand.Size = new System.Drawing.Size(381, 21);
            this.lbSendCommand.TabIndex = 1;
            this.lbSendCommand.Text = "十六进制命令(头1地址4数据4校验2尾1)";
            // 
            // gbReceiveData
            // 
            this.gbReceiveData.Controls.Add(this.tbReceivedData);
            this.gbReceiveData.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbReceiveData.Location = new System.Drawing.Point(12, 282);
            this.gbReceiveData.Name = "gbReceiveData";
            this.gbReceiveData.Size = new System.Drawing.Size(760, 267);
            this.gbReceiveData.TabIndex = 2;
            this.gbReceiveData.TabStop = false;
            this.gbReceiveData.Text = "EMS -> PC";
            // 
            // tbReceivedData
            // 
            this.tbReceivedData.Location = new System.Drawing.Point(6, 30);
            this.tbReceivedData.Multiline = true;
            this.tbReceivedData.Name = "tbReceivedData";
            this.tbReceivedData.ReadOnly = true;
            this.tbReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReceivedData.Size = new System.Drawing.Size(748, 231);
            this.tbReceivedData.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbReceiveData);
            this.Controls.Add(this.gbSendCommand);
            this.Controls.Add(this.gbPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbPort.ResumeLayout(false);
            this.gbPort.PerformLayout();
            this.gbSendCommand.ResumeLayout(false);
            this.gbSendCommand.PerformLayout();
            this.gbReceiveData.ResumeLayout(false);
            this.gbReceiveData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPort;
        private System.Windows.Forms.Label lbDatabit;
        private System.Windows.Forms.Label lbBaudrate;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbDatabits;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbStopbits;
        private System.Windows.Forms.Label lbStopbit;
        private System.Windows.Forms.GroupBox gbSendCommand;
        private System.Windows.Forms.Label lbSendCommand;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.GroupBox gbReceiveData;
        private System.Windows.Forms.TextBox tbReceivedData;
    }
}

