using System;

namespace Session06.dataaccess
{
    class Test
    {
        public static void Main(String[] args)
        {
            try
            {
                Thisinh ts = new Thisinh();
                ts.SoDB = "HUIA12345";
                ts.Namsinh = 2010;

                Console.WriteLine(ts.SoDB + "\t" + ts.Namsinh);
                
            }catch(InvalidDOBException de)
            {
                //Console.WriteLine(de.Message);
                de.log();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //cleanup
            }
            Console.ReadKey();
        }
    }
}
