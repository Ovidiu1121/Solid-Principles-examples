using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._2
{
    public class Bond : Asset
    {
        public string Issuer { get; set; }
        public double FaceValue { get; set; }
        public double InterestRate { get; set; }
        public int YearsToMaturity { get; set; }

        public Bond(string issuer, double faceValue, double interestRate, int yearsToMaturity)
        {
            Issuer = issuer;
            FaceValue = faceValue;
            InterestRate = interestRate;
            YearsToMaturity = yearsToMaturity;
        }

        public override double GetValue()
        {
            double presentValue = FaceValue / Math.Pow(1 + InterestRate, YearsToMaturity);
            return presentValue;
        }
    }
}
