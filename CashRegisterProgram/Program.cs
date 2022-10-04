using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input1, input2;
            ClassFileRegister.CashRegisterRead();
            List<string> input = ClassFileRegister.fileList;

            ClassFileRegister.writeList.Add("The first item is the purchase price(PP); the second item is the cash(CH)");
            ClassFileRegister.writeList.Add("\n");
            foreach(string lineText in input)
            {
                ClassFileRegister.writeList.Add("Input:"+lineText);
                ClassFileRegister.writeList.Add("\n");
                string[] _split = lineText.Split(';');
                
                input1 = Convert.ToDouble(_split[0]);
                input2 = Convert.ToDouble(_split[1]);

                ClassFileRegister.writeList.Add("Output:");
                if(input1< input2)
                {
                    double result = 0;
                    result = input2 - input1;
                    CalculateChange.CalculateChangePurchase(result);
                }
                else if (input1 == input2)
                {
                    ClassFileRegister.writeList.Add("ZERO");
                }
                else 
                {
                    ClassFileRegister.writeList.Add("ERROR");
                }
                ClassFileRegister.writeList.Add("\n");
                ClassFileRegister.writeList.Add("\n");
            }
            ClassFileRegister.CashRegisterWrite();
            Console.ReadLine();
        }
    }
}
