namespace Decorator.Models
{

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Repository : IRepository
    {
        #region Implementation of IRepository

        /// <inheritdoc />
        public void Operation()
        {
            Console.WriteLine("Repository.Operation()");
        }

        #endregion
    }

}
