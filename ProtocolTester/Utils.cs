using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtocolTester
{
    class Utils
    {
        public static void ShowInfo(String content)
        {
            MessageBox.Show(content, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void ShowWarning(String content)
        {
            MessageBox.Show(content, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        

        public static DialogResult ShowOKCancel(String content)
        {
            return MessageBox.Show(content, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        
        public static byte[] hexString2Bytes(String hex)
        {
            int len = hex.Length / 2;
            byte[] buffer = new byte[len];

            for (int i = 0; i < len; i++)
            {
                buffer[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return buffer;
        }

        /// <summary>
        /// 将byte数组转换成16进制数
        /// </summary>
        /// <param name="input"></param>
        /// <returns>输入数据的16进制表示</returns>
        public static string Bytes2String(byte[] input)
        {
            StringBuilder sb = new StringBuilder(input.Length * 2);
            foreach (byte b in input)
            {
                sb.Append(Byte2Hex(b));
            }

            return sb.ToString();
        }

        /// <summary>
        /// 将byte类型数据转换成16进制表示
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private static string Byte2Hex(byte b)
        {
            return b.ToString("X2");
        }

    }
}
