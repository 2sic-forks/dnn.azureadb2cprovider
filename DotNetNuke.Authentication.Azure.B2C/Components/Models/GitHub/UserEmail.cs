namespace DotNetNuke.Authentication.Azure.B2C.Components.Models.GitHub
{
    public partial class UserEmail
    {
        public string Email { get; set; }
        public bool Primary { get; set; }
        public bool Verified { get; set; }
        public string Visibility { get; set; }
    }
}
