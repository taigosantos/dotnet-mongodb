using NetCoreMongo.Web.Shared;

namespace NetCoreMongo.Web.Domain.Users
{
    public class UserEmail : Entity
    {
        #region Constructors

        public UserEmail(string address, string id = null)
            : base(id)
        {
            Address = address;
        }

        #endregion

        #region Properties

        public string Address { get; private set; }

        #endregion

        #region Public Methods

        public void Update(string address)
        {
            Address = address;
        }

        #endregion
    }
}