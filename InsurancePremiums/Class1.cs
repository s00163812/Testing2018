using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit.Fixtures;
using fit;


namespace InsurancePremiums
{
     public class Class1
    {
        public double CalcPremium(int age, string gender)
        {
            double premium;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                {
                    premium = 5.0;
                }
                else if (age >= 31)
                {
                    premium = 2.50;
                }
                else
                {
                    premium = 0.0;
                }
            }
            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                {
                    premium = 6.0;
                }
                else if (age >= 36)
                {
                    premium = 5.0;
                }
                else
                {
                    premium = 0.0;
                }
            }
            else
            {
                premium = 0.0;
            }


            if (age >= 50)
            {
                premium = premium * 0.15;
            }

            return premium;
        }
    }

    public class FixtureClass : ColumnFixture
    {
        static public int age;
        static public string gender;

        static public double CalcPremium()
        {

            Class1 c1 = new Class1();
            double x = c1.CalcPremium(age, gender);
            return x;


        }

    }
}