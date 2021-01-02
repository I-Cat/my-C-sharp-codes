using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Integer
    {
        private int number1;
        private int number2;

        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
        
        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }

        public Integer(int num1,int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        public override string ToString()
        {
            return string.Format("{0} and {1}", number1, number2);
        }

        public static Integer operator +(Integer a,Integer b)
        {
            return new Integer(a.number1+b.number1,a.number2+b.number2);
        }

        public static Integer operator -(Integer a, Integer b)
        {
            return new Integer(a.number1 - b.number1, a.number2 - b.number2);
        }

        public static Integer operator *(Integer a, Integer b)
        {
            return new Integer(a.number1 * b.number1, a.number2 * b.number2);
        }

        public static Integer operator /(Integer a, Integer b)
        {
            return new Integer(a.number1 / b.number1, a.number2 / b.number2);
        }

    }
}
