using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryERP.Domain
{
    public class Member : User
    {
        public string FriendlyUrl { get; set; }
        public string ProfileImage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Summary { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string WebsiteUrl { get; set; }

        public Address Address { get; set; }
    }
}
