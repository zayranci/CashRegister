using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterProgram
{
    class CalculateChange
    {
        public static void CalculateChangePurchase(double x)
        {
            var tupleList = new List<Tuple<float, string>>();
            tupleList.Add(new Tuple<float, string>(0.01f,"PENNY"));
            tupleList.Add(new Tuple<float, string>(0.05f,"NICKEL"));
            tupleList.Add(new Tuple<float, string>(0.10f,"DIME"));
            tupleList.Add(new Tuple<float, string>(0.25f,"QUARTER"));
            tupleList.Add(new Tuple<float, string>(0.50f,"HALF DOLAR"));
            tupleList.Add(new Tuple<float, string>(1,"ONE"));
            tupleList.Add(new Tuple<float, string>(2,"TWO"));
            tupleList.Add(new Tuple<float, string>(5,"FIVE"));
            tupleList.Add(new Tuple<float, string>(10,"TEN"));
            tupleList.Add(new Tuple<float, string>(20,"TWENTY"));
            tupleList.Add(new Tuple<float, string>(50,"FIFTY"));
            tupleList.Add(new Tuple<float, string>(100,"ONE HUNDRED"));

            List<string> myList = new List<string>();

            for(int i= tupleList.Count-1; i >= 0; i--)
            {
                while(x>= tupleList[i].Item1)
                {
                    x = x - tupleList[i].Item1;
                    myList.Add(tupleList[i].Item2);
                }
            }
            for (int i = 0; i<myList.Count; i++)
            {
                ClassFileRegister.writeList.Add(myList[i]);
            }
        }
    }
}
