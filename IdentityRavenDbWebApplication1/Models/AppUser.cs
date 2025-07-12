using Raven.Identity;

namespace IdentityRavenDbWebApplication1.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// The user's full name.
        /// </summary>
        public string FullName { get; set; } = string.Empty;
    }
}
