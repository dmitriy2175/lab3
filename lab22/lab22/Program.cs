using System.Diagnostics;

namespace lab22
{
    class Program
    {
        public static void Main()
        {
            RomanNumber[] NewArray = new RomanNumber[] { new RomanNumber(7), new RomanNumber(3), new RomanNumber(155) };
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.Write(NewArray[i].ToString()+" ");
            }
            Console.WriteLine();
            Array.Sort(NewArray);
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.Write(NewArray[i].ToString()+" ");
            }
            Console.WriteLine();
            //Console.WriteLine(RomanNumber.Div(new RomanNumber(10), new RomanNumber(5)).ToString());
            //Console.WriteLine(RomanNumber.Mul(new RomanNumber(10), new RomanNumber(5)).ToString());
            //Console.WriteLine(RomanNumber.Add(new RomanNumber(10), new RomanNumber(5)).ToString());
            //Console.WriteLine(RomanNumber.Sub(new RomanNumber(10), new RomanNumber(5)).ToString());

            //RomanNumber Incorect = new RomanNumber(0);
        }
    }
}