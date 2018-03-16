using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit.Fixtures;
using fit;
using InsurancePremiums;

namespace PremiumTest
{
    public class FixtureClass : ColumnFixture
    {
        static public int age;
        static public string gender;

        static public  double CalcPremium()
        {

            Class1 c1 = new Class1();
            double x =  c1.CalcPremium(age, gender);
            return x;


        }

    }
}
