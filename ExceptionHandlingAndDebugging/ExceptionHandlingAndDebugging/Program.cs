// See https://aka.ms/new-console-template for more information



namespace ExceptionHandlingAndDebugging
{
    public class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
            Joc joc = new Joc("Barcelona", "RealMadrid");
            joc.simuleaza();
            Console.WriteLine();
            Console.WriteLine(joc);

            
#endif

#if DEBUG
            try
            {
                ExceptionHandler();
            }
            catch (InputException1 ex1)
            {
                Log(ex1);
                throw;
            }
            catch (InputException2 ex2)
            {
                Log(ex2);
                throw;
            }
#endif




        }
        private static void Log(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public static int InputMethod(int a, int b)
        {
            if (a % 2 == 0) throw new InputException1("Even number");

            if (b > 100) throw new InputException2("Over 100");

            return (b % a) * a;
        }
        public static void ExceptionHandler()
        {
            try
            {
                int result = InputMethod(2, 56);
                Console.WriteLine($"the result is {result}");
            }
            catch (InputException1 ex1)
            {
                Log(ex1);
                throw;
            }
            catch (InputException2 ex2)
            {
                Log(ex2);
                throw;
            }
            finally
            {
                Console.WriteLine("This code will always be seen from ExceptionHandler");
            }
        }
    }



}





