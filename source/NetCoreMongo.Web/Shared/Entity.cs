namespace NetCoreMongo.Web.Shared
{
    public abstract class Entity
    {
        #region Constructors

        protected Entity(string id)
        {
            Id = id ?? Identity.NewId();
        }

        #endregion

        #region Properties

        public string Id { get; private set; }
        public bool IsRemoved { get; private set; }

        #endregion

        #region Public Methods

        public void Remove()
        {
            IsRemoved = true;
        }

        #endregion
    }
}