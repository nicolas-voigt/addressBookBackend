using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addressBookBackendApi
{
    public class AddressBookEmailAddress
    {
        private String _username;

        private String _domain;
        private String _tLD;

        public AddressBookEmailAddress(String username, String domain, String tld, AddressBookCategory category)
        {
            _username = username;
            _domain = domain;
            _tLD = tld;
            Category = category;
        }
        public String EmailAddress { get; }

        internal AddressBookCategory Category { get; set; }
    }
}
