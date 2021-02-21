using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addressBookBackendApi
{
    public class AddressBook
    {

        public AddressBook()
        {

        }

        public AddressBook(long id)
        {
            Id = id;
            PhoneNumbers = new Dictionary<AddressBookCategory, AddressBookPhoneNumber>();
            EmailAddresses = new Dictionary<AddressBookCategory, AddressBookEmailAddress>();
        }
        public long Id { get; }
        public DateTime LastModified { get; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Company { get; set; }

        public IDictionary<AddressBookCategory, AddressBookURL> URLs { get; }

        public void Add(AddressBookURL website)
        {
            URLs.Add(website.Category, website);
        }

        public IDictionary<AddressBookCategory, AddressBookPhoneNumber> PhoneNumbers { get; }

        public void Add(AddressBookPhoneNumber phoneNumber)
        {
            PhoneNumbers.Add(phoneNumber.Category, phoneNumber);
        }

        public IDictionary<AddressBookCategory, AddressBookEmailAddress> EmailAddresses { get; }

        public void Add(AddressBookEmailAddress emailAddress)
        {
            EmailAddresses.Add(emailAddress.Category, emailAddress);
        }

    }
}
