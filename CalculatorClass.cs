using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T txtBoxInput1, T txtBoxInput2);
    internal class CalculatorClass
    {
        public Formula<double> info;
        public double GetSum(double txtInputBox1, double txtBoxInput2)
        {
            return txtInputBox1 + txtBoxInput2;
        }
        public double GetDifference(double txtInputBox1, double txtBoxInput2)
        {
            return txtInputBox1 - txtBoxInput2;
        }
        public double GetProduct(double txtInputBox1, double txtBoxInput2)
        {
            return txtInputBox1 * txtBoxInput2;
        }
        public double GetQuotient(double txtInputBox1, double txtBoxInput2)
        {
            if (txtInputBox1 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
               return txtInputBox1 / txtBoxInput2;
            }
        }

        public event Formula<Double> CalculatorEvent
        {
            add {
                Console.WriteLine("Added the delegate");
                }
            remove
            {
                Console.WriteLine("Removed the Delegate");

            }
        }
    }
}
