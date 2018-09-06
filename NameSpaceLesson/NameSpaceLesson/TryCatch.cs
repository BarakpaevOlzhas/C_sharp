using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceLesson
{
    class SumM
    {
        public double DivisionOfNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public void DivisionOfTwoNumbers(int firstNumber, int secondNumber)
        {
            try
            {
              DivisionOfNumbers(firstNumber, secondNumber);
                
            }
            catch (ArithmeticException argumentException)
            {
                Console.WriteLine(argumentException);
            }
        }
    }
}
