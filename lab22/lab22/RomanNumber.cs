using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort n;

        public RomanNumber(ushort n)
        {
            if (n == 0)
            {
                throw new RomanNumberException();
            }
            this.n = n;
        }

        public static RomanNumber operator +(RomanNumber? n1, RomanNumber? n2)
        {
            return new RomanNumber((ushort)(n1.n + n2.n));
        }

        public static RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)
        {
            return new RomanNumber((ushort)(n1.n - n2.n));
        }

        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)
        {
            return new RomanNumber((ushort)(n1.n * n2.n));
        }

        public static RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)
        {
            return new RomanNumber((ushort)(n1.n / n2.n));
        }

        public override string ToString()
        //I = 1; V = 5; X = 10; L = 50; C = 100; D = 500; M = 1000
        {
            ushort n = this.n;
            ushort[] Value = new ushort[] {1000, 500, 100, 50, 10, 5, 1 } ;
            char[] Ecvivalent = new char[] { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            string Res = "";
            int p = 0;

            while (n > 0)
            {
                if (n >= Value[p])
                {
                    n -= Value[p];
                    Res += Ecvivalent[p];
                }
                else
                {
                    p++;
                }
            }
            return Res;
        }
        //Реализация интерфейса IClonable
        public object Clone()
        {
            return new RomanNumber(this.n);
        }
        //Реализация интерфейса IComparable
        public int CompareTo(object? obj)
        {
            RomanNumber  objN = (RomanNumber)obj;
            if (objN.n == this.n) return 0;
            if (objN.n > this.n) return -1;
            if (objN.n < this.n) return 1;
            return 0;
        }
        public override bool Equals(object? obj)
        {
            RomanNumber a = obj as RomanNumber;
            if (a.n == this.n) return true;
            return false;
        }
    }
}
