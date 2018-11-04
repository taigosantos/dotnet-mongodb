using NetCoreMongo.Web.Shared;

namespace NetCoreMongo.Web.Domain.Countries
{
    public class Country : Entity
    {
        #region Constructors

        public Country(string description, string id = null)
            : base(id)
        {
            Description = description;
        }

        #endregion

        #region Properties

        public string Description { get; private set; }

        #endregion
    }
}