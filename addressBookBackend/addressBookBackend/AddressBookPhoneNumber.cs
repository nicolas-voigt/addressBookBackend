using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addressBookBackendApi
{
    public class AddressBookPhoneNumber
    {
        private int _countryCode;
        private int _areaCode;
        private int _number;
        private int _extension;

        public AddressBookPhoneNumber(int countryCode, int areaCode, int number, int extension, AddressBookCategory category)
        {
            _countryCode = countryCode;
            _areaCode = areaCode;
            _number = number;
            _extension = extension;
            Category = category;
        }

        public AddressBookPhoneNumber(String unformattedInput)
        {
            //TODO
        }

        public String FormattedPhoneNumber { get; }

        public String PhoneCallableNumber { get; }

        internal AddressBookCategory Category { get; set; }
    }
}
