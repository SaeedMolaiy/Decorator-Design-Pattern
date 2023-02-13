namespace Decorator.Models
{

    /// <summary>
    /// The 'Concrete Decorator' class
    /// </summary>
    public class DatabaseLogger : Decorator
    {
        public new void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        private static void AddedBehavior()
        {
            Console.WriteLine("DatabaseLogger : I logged a message in database");
        }
    }

}
