using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class SubSystemOne : ISubsystemOne
    {
        public void FirstProcess()
        {
            Console.WriteLine("SS1:1");
        }

        public void SecondProcess()
        {
            Console.WriteLine("SS1:2");
        }

        public void ThirdProcess()
        {
            Console.WriteLine("SS1:3");
        }
    }
}
