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
        }
        public long Id { get; }
        public DateTime LastModified { get; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

    }
}
