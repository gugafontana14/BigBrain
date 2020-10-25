using System.Collections.Generic;

namespace BigBrain.Api.User.Domain.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        
        public IEnumerable<string> BusinessPhones { get; set; }

        public string DisplayName { get; set; }

        public string GivenName { get; set; }

        public string JobTitle { get; set; }

        public string Mail { get; set; }

        public string MobilePhone { get; set; }

        public string OfficeLocation { get; set; }

        public string PreferredLanguage { get; set; }

        public string Surname { get; set; }

        public string UserPrincipalName { get; set; }
    }
}
