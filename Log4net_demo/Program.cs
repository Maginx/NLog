using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4net_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] temp = new int[10];
                Logging.Debug("this is a debug log test!");
                Logging.InfoMessage("This is just a test!");
                Console.WriteLine(temp[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Logging.ErrorMessage(e);

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
