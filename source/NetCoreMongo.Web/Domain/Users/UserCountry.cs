namespace NetCoreMongo.Web.Domain.Users
{
    public class UserCountry
    {
        #region Constructors

        public UserCountry(string description, string id)
        {
            Id = id;
            Description = description;
        }

        #endregion

        #region Properties

        public string Id { get; private set; }
        public string Description { get; private set; }

        #endregion
    }
}