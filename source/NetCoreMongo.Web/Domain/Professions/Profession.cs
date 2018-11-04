using NetCoreMongo.Web.Shared;

namespace NetCoreMongo.Web.Domain.Professions
{
    public class Profession : Entity
    {
        #region Constructors

        public Profession(string description, string id = null)
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