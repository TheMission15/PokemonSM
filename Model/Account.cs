using System.Reflection.Metadata;

namespace PokemonSM.Model
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Blob ProfilePicture { get; set; }
        public int numberOfListings { get; set; }

    }
}
