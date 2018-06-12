using System;

namespace Cours.CS.Tuto3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Une();
            }
            catch (Exception ex)
            {
                Console.WriteLine("une : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("fin de main");
            }
        }

        static void Une()
        {
            try
            {
                Deux();
            }
            catch (Exception ex)
            {
                Console.WriteLine("deux : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("fin de une");
            }
        }

        static void Deux()
        {
            try
            {
                Trois();
            }
            catch (Exception ex)
            {
                Console.WriteLine("trois : " + ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("fin de deux");
            }
        }

        static void Trois()
        {
            throw new MyException();

            Console.WriteLine("fin de trois");
        }
    }

    class MyException : Exception
    {
        public MyException()
            : base("c'est mon exception")
        {
        }
    }
}
