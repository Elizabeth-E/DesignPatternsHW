using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class RobotAdapter : IAttacker
    {
        private Robot robot;

        public RobotAdapter(string person)
        {
            robot = new Robot();
            AssignDriver(person);
        }

        public string Driver => robot.Person;

        public void AssignDriver(string driver)
        {
            robot.MoveByPerson(driver);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
