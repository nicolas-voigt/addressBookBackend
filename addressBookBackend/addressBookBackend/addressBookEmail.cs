using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addressBookBackendApi
{
    public class AddressBookEmail
    {
        public String emailAddress { get; set; }

        public AddressBookCategory category { get; set; }
    }
}
