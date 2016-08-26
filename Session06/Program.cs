using io=System.Console;
using System.Diagnostics;
using System;


namespace Session06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Session06_01.DemoNamespace d1 = new Session06_01.DemoNamespace();
            //DemoNamespace d1 = new DemoNamespace();
            //Session06_02.DemoNamespace d2 = new Session06_02.DemoNamespace();
            //Process p = new Process();
            //p.StartInfo = new ProcessStartInfo("C:/RSAKey.xml");
            //p.Start();
            try
            {
                int a = 5, b = 01;
                int c = a / b;
                int x = int.MaxValue;
                int d = x + 10;
                io.WriteLine(c);
                io.WriteLine(d);
                int o = (int)(new Object());
                io.WriteLine(o);
            }
            catch (DivideByZeroException de)
            {
                io.WriteLine(de.Message);
            }catch(Exception ae)
            {
                io.WriteLine(ae.Message);
                io.WriteLine(ae.StackTrace);
            }
            finally
            {
                //
            }

            io.ReadKey();
        }
    }
}
