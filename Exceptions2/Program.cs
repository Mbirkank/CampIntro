using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch(RecordNotFountException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {

            }
            HandleException(() =>
            {
                Find();
            });

            Console.ReadLine();
            
        }

        private static void HandleException(Action aciton)
        {
            
            try
            {
                aciton.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void Find()
        {
            List<string> students = new List<String>
            { "Birkan", "Engin", "Fatih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFountException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Mustafa", "Birkan", "Ahmet" };
                students[3] = "Ali";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                //Console.WriteLine(exception.InnerException);
            }
        }
    }
}
