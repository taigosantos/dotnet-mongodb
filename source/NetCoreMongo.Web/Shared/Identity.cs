using MongoDB.Bson;

namespace NetCoreMongo.Web.Shared
{
    public class Identity
    {
        #region Fields

        private readonly ObjectId _newId;

        #endregion

        #region Constructors

        public Identity(string newId)
        {
            _newId = new ObjectId(newId);
        }

        #endregion

        #region Public Methods

        public static string NewId()
        {
            var newId = ObjectId.GenerateNewId();
            return newId.ToString();
        }

        public static implicit operator string(Identity input)
        {
            return input.ToString();
        }

        #endregion

        #region Override Methods

        public override string ToString()
        {
            return _newId.ToString();
        }

        #endregion
    }
}