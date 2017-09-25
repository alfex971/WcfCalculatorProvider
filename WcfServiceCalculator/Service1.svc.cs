using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double Add(double a, double c)
        {
            return a + c;
        }

        public double Phone(double a, double b)
        {
            return a - b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (Math.Abs(b) < 0.000)
            {
                throw new ArgumentException("number you divide with cannot be 0!");
            }
            return a / b;
        }

        public void All(double a, double b, out double add, out double substract, out double multiply, out double divide)
        {
            add = a + b;
            substract = a - b;
            multiply = a * b;
            divide = a / b;
        }
    }
}
