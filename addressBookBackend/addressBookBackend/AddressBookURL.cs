using System;

namespace addressBookBackendApi
{
    public class AddressBookURL
    {
        public String Url { get; set; }
        public String getFormattedUrl { get; set; }

        internal AddressBookCategory Category { get; set; }
    }
}