using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    internal class ObjectMethodsEX
    {
        public string name;
        public string major;
        public double gpa;

        public ObjectMethodsEX(string aName, string aMajor, double aGpa)
        { 
            name = aName;
            major = aMajor; 
            gpa = aGpa; 
        }

        public bool HonorRoll()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
