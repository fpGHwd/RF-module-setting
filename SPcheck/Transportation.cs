using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPcheck
{
    class Transportation
    {
        public static byte[] SendAndRecvData(byte[] data, int timeout, SerialPort sp)
        {
            if (sp == null) return null;
            if (!sp.IsOpen) return null;
            
            //清空缓存区
            sp.DiscardInBuffer();
            sp.DiscardOutBuffer();

            sp.Write(data, 0,data.Length);

            //接收byte[] 
            byte[] recvbyte = new byte[0];

            //间隔时间
            int inteval = 100;
            //已花时间
            int spendtime = 0;

            while (spendtime < timeout)
            {
                spendtime += inteval;
                Thread.Sleep(inteval);
                //缓存区可读数据长度
                int readybytes = sp.BytesToRead;

                byte[] itembytes = new byte[readybytes];
                int readlength = sp.Read(itembytes, 0, readybytes);

                recvbyte = MergerArray(recvbyte, itembytes);

                Console.WriteLine("收到数据字节数-----" + readlength);

                if (readlength > 12) break;
            }

            return recvbyte;
        }



        /// <summary>
        /// 合并数组
        /// </summary>
        /// <param name="First">第一个数组</param>
        /// <param name="Second">第二个数组</param>
        /// <returns>合并后的数组(第一个数组+第二个数组，长度为两个数组的长度)</returns>
        public static byte[] MergerArray(byte[] first, byte[] second)
        {
            byte[] result = new byte[first.Length + second.Length];
            first.CopyTo(result, 0);
            second.CopyTo(result, first.Length);
            return result;
        }

    }
}
