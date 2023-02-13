namespace Decorator.Models
{

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public class Decorator : IRepository
    {
        protected IRepository Component;

        public void SetComponent(IRepository component)
        {
            Component = component;
        }

        #region Implementation of IRepository

        /// <inheritdoc />
        public void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }

        #endregion
    }

}
