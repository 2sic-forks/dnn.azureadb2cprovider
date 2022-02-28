using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNuke.Authentication.Azure.B2C.Components.Models.GitHub
{

    public partial class UserProfile
    {
        public string Login { get; set; }
        public long Id { get; set; }
        public string NodeId { get; set; }
        public Uri AvatarUrl { get; set; }
        public string GravatarId { get; set; }
        public Uri Url { get; set; }
        public Uri HtmlUrl { get; set; }
        public Uri FollowersUrl { get; set; }
        public string FollowingUrl { get; set; }
        public string GistsUrl { get; set; }
        public string StarredUrl { get; set; }
        public Uri SubscriptionsUrl { get; set; }
        public Uri OrganizationsUrl { get; set; }
        public Uri ReposUrl { get; set; }
        public string EventsUrl { get; set; }
        public Uri ReceivedEventsUrl { get; set; }
        public string Type { get; set; }
        public bool SiteAdmin { get; set; }
        public string Name { get; set; }
        public object Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public object Email { get; set; }
        public object Hireable { get; set; }
        public object Bio { get; set; }
        public object TwitterUsername { get; set; }
        public long PublicRepos { get; set; }
        public long PublicGists { get; set; }
        public long Followers { get; set; }
        public long Following { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public long PrivateGists { get; set; }
        public long TotalPrivateRepos { get; set; }
        public long OwnedPrivateRepos { get; set; }
        public long DiskUsage { get; set; }
        public long Collaborators { get; set; }
        public bool TwoFactorAuthentication { get; set; }
        public Plan Plan { get; set; }
    }

    public partial class Plan
    {
        public string Name { get; set; }
        public long Space { get; set; }
        public long Collaborators { get; set; }
        public long PrivateRepos { get; set; }
    }
}
