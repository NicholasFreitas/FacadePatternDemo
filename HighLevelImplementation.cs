using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class HighLevelImplementation : IFacade
    {
        ISubsystemOne _subsystemOne;

        ISubsystemTwo _subsystemTwo;

        public HighLevelImplementation(ISubsystemOne subOne,ISubsystemTwo subTwo)
        {
            _subsystemOne = subOne;
            _subsystemTwo = subTwo;
        }
        
        public void HighLevelProcessOne() => _subsystemOne.FirstProcess();

        public void HighLevelProcessTwo() => _subsystemTwo.StepTwo();

        public void HighLevelProcessThree() => _subsystemOne.ThirdProcess();
                
    }
}
