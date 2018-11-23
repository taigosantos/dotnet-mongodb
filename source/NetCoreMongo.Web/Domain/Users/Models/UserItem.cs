namespace NetCoreMongo.Web.Domain.Users.Models
{
    public class UserItem
    {
        #region Properties

        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public string Profession { get; internal set; }
        public string Country { get; internal set; }

        #endregion
    }
}