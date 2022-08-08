using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    internal class InheritanceEX02 : InheritanceEX
    {
        public void ItalianFood()
        {
            Console.WriteLine("The Italian Chef makes italian food");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }


    }
}
