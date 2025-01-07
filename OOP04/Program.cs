using OOP04.Interface_Ex01;
using OOP04.Interface_Ex02;

namespace OOP04
{
    internal class Program
    {
        static void PrintTenNumbersFromSeries(ISeries seriesByTwo)
        {
            if (seriesByTwo != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(seriesByTwo.Current);
                    seriesByTwo.GetNext();
                }
                seriesByTwo.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Interface Example01
            //IType reference;
            //Refer for reference of Type "IType"[ Containing Garbage Value]
            //Can Refer to an Object any type implementing IType interface
            //ClR will allocate 4 byte in stack
            //Clr Will allocate 0 Byte in heap 
            //reference = new TypeA();
            //reference.MyProperty = 22;
            //reference.Print();
            //reference.MyMethod();
            //TypeA type=new TypeA();
            //type.MyMethod();
            //type.MyProperty = 3;
            //type.Print(); Invalid  
            #endregion
            #region Interface Example02
            ////TypeB Has Behaviour series
            //TypeB seriesByTwo = new TypeB();
            //PrintTenNumbersFromSeries(seriesByTwo);
            //TypeC seriesByThree = new TypeC();
            //PrintTenNumbersFromSeries(seriesByThree);
            //TypeD seriesByFour = new TypeD();
            //PrintTenNumbersFromSeries(seriesByFour);
            #endregion

        }
    }
}
