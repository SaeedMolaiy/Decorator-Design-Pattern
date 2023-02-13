namespace Decorator.Models
{

    /// <summary>
    /// The 'Concrete Decorator' class
    /// </summary>
    public class Logger : Decorator
    {
        public new void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        private static void AddedBehavior()
        {
            Console.WriteLine("Logger : I logged a message in physical path");
        }
    }

}
