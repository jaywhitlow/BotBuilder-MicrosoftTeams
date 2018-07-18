// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// Teams channel account detailing user Azure Active Directory details.
    /// </summary>
    public partial class TeamsChannelAccount : ChannelAccount
    {
        /// <summary>
        /// Initializes a new instance of the TeamsChannelAccount class.
        /// </summary>
        public TeamsChannelAccount() { }

        /// <summary>
        /// Initializes a new instance of the TeamsChannelAccount class.
        /// </summary>
        /// <param name="id">Channel id for the user or bot on this channel
        /// (Example: joe@smith.com, or @joesmith or 123456)</param>
        /// <param name="name">Display friendly name</param>
        /// <param name="objectId">Unique Azure Active Directory object
        /// Id.</param>
        /// <param name="givenName">Given name part of the user name.</param>
        /// <param name="surname">Surname part of the user name.</param>
        /// <param name="email">Email Id of the user.</param>
        /// <param name="userPrincipalName">Unique user principal name</param>
        public TeamsChannelAccount(string id = default(string), string name = default(string), string objectId = default(string), string givenName = default(string), string surname = default(string), string email = default(string), string userPrincipalName = default(string))
            : base(id, name)
        {
            ObjectId = objectId;
            GivenName = givenName;
            Surname = surname;
            Email = email;
            UserPrincipalName = userPrincipalName;
        }

        /// <summary>
        /// Gets or sets unique Azure Active Directory object Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }
        
        /// <summary>
        /// Gets or sets given name part of the user name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets surname part of the user name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets email Id of the user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets unique user principal name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userPrincipalName")]
        public string UserPrincipalName { get; set; }
        
        /// <summary>
        /// Sets the ObjectId property with the value of aadObjectId.
        /// This is how the AAD object Id is passed from a bot framework message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "aadObjectId")]
        private string AADObjectId { set { ObjectId = value; } }
    }
}
