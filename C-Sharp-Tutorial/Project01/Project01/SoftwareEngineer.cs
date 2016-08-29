using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    class SoftwareEngineer:Coder
    {
        public string projectName;
        public string team;
        public int numberOfTeamMembers;

        public override void solveProblems()
        {
            //base.solveProblems();
            Console.WriteLine("Problem solved");
        }

        public override double purchaseCoffee()
        {
           return base.purchaseCoffee();
        }
    }
}
