using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                Console.WriteLine("Converted to Integer " + value);
            }
            else
            {
                Console.WriteLine("Failed to Parse");
            }
            Console.ReadKey();

            try
            {
                Console.WriteLine("Enter a number");
                string input2 = Console.ReadLine();
                Convert.ToDouble(input2);
                Console.WriteLine("Converted to Double " + input2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow exception " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }


            try
            {
                Console.WriteLine("Enter a Number");
                string input3 = Console.ReadLine();
                decimal.Parse(input3);
                Console.WriteLine("Parsed Number " + input3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
                Console.ReadKey();
            }
        }
    }
}
