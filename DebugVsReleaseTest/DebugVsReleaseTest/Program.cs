using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DebugVsReleaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = DateTime.Now;

#if DEBUG
            Console.WriteLine("Corriendo en modo Debug " + inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            //FtpController.InitFTPPolling();
#else
            Console.WriteLine("Corriendo en modo Release " + inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"));
#endif
            int cant = 100000000;
            int result = 0;
            for (int i = 0; i < cant; i++)
            {
                try
                {
                    result = i * 100 + 20 - i / 3;
                }
                catch (Exception)
                {
                    result = 0;
                }
            }
            TimeSpan ts = DateTime.Now - inicio;
            Console.WriteLine("Resultado " + ts.ToString("mm':'ss':'fff"));

            inicio = DateTime.Now;


            cant = 100000000;
            result = 0;
            for (int i = 0; i < cant; i++)
            {
                try
                {
                    result = i * 100 + 20 - i / 3;
                }
                catch (Exception)
                {
                    result = 0;
                }
            }
            ts = DateTime.Now - inicio;
            Console.WriteLine("Resultado " + ts.ToString("mm':'ss':'fff"));

            Thread.Sleep(5000);


        }
    }
}
