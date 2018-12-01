using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class SubSystemTwo : ISubsystemTwo
    {
        public void StepOne()
        {
            Console.WriteLine("SS2-1");
        }

        public void StepThree()
        {
            Console.WriteLine("SS2-3");
        }

        public void StepTwo()
        {
            Console.WriteLine("SS2-2");
        }
    }
}
