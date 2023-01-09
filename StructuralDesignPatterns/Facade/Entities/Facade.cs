using FacadePattern.Entities;

namespace FacadePattern.Entities
{
    internal class Facade
    {
        protected SubsystemOne _subsystemOne;
        protected SubsystemTwo _subsystemTwo;

        public Facade(SubsystemOne subsystemOne, SubsystemTwo subsystemTwo)
        {
            this._subsystemOne = subsystemOne;
            this._subsystemTwo = subsystemTwo;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";

            result += this._subsystemOne.OperationOne();
            result += this._subsystemTwo.OperationThree();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystemOne.OperationTwo();
            result += this._subsystemTwo.OperationFour();

            return result;
        }
    }
}
