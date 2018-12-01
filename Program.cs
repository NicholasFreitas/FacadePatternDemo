using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class Program
    {
        /*
         Facade is deceptively simple. I had to some some research and to really get a grasp of things.
         But in short, it allows me to sort of generalize and abstract subsystem(s) so that the consumer
         of my code can just work with the simple interface, rather than fret about the underlying details.*/
         /*
          Facades ar very implementation specific so it can be tricky to represent how it's supposed to be used.
          this example assumes I have two subsystems, and I've implemented them. So, I want to use the methods from one
          subsystem and some from another subsystem. Rather than complicate things for the client. I just abstract that away
          to a more generalized interface.

            ==========================              ==================
            |IFacade                 |              | ISubsystemOne  |
            ========================== ---Has-A---> ==================
            |HighLevelProcessOne()   |       |      | FirstProcess() |
            |HighLevelProcessTwo()   |       |      | SecondProcess()|
            |HighLevelProcessThree() |       |      | ThirdProcess() |
            ==========================       |      ==================
                                             |
                                             |      ==================
                                             |      | ISubSystemTwo  |
                                             -----> ==================
                                                    | StepOne()      |
                                                    | StepTwo()      |
                                                    | StepThree()    |
                                                    ==================

             */

        static void Main(string[] args)
        {
            //We have our two sub systems.
            var sub1 = new SubSystemOne();
            var sub2 = new SubSystemTwo();


            //we bind them throug the contructor. this is not exactly part of the facade
            // pattern but I'm doing it to demonstrate the principle of the pattern
            var highLvlSystem = new HighLevelImplementation(sub1,sub2);


            //The abstraction. We have no idea which subsystem is really called
            //we just know that two subsystems are called. They both come together
            //in the high level process which the facade contracts us to implement.
            highLvlSystem.HighLevelProcessOne();
            highLvlSystem.HighLevelProcessTwo();
            highLvlSystem.HighLevelProcessThree();


            //Facade is a tricky one because it is heavily dependent on the context of what you're trying to abstract.
            //* I know this sorta looks like Strategy and Command patterns, ignore the similariy. Understand the context.
            // I'm abstracting subsystem call to a higher level process interface. For easy client consumption.

        }
    }
}
