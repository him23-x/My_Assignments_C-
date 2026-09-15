using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }


        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            double realPart =
            (left.Real * right.Real) - (left.Imaginary * right.Imaginary);

            double imaginaryPart =
                (left.Real * right.Imaginary) + (left.Imaginary * right.Real);

            return new ComplexNumber() { Real = realPart, Imaginary = imaginaryPart };
        }
    }
}
