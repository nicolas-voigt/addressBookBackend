using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addressBookBackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private ILogger<AddressBookController> _logger;

        public AddressBookController(ILogger<AddressBookController> logger) => _logger = logger;

        [HttpGet]
        [Route("{addressBookId}")]
        public IEnumerable<AddressBook> Get(long addressBookId)
        {
            AddressBook[] Results = new AddressBook[1];
            Results[0] = new AddressBook(addressBookId);
            // security layer

            // DB layer

            // return layer
            return Results;

        }

        [HttpPost]
        [Route("{addressBookId}")]
        public long Post(AddressBook editEntry)
        {
            return editEntry.Id;
        }

        [HttpDelete]
        [Route("{addressBookId}")]
        public void Delete(int addressBookId)
        {
        }

        [HttpPut]
        public long Put(AddressBook newEntry)
        {
            return newEntry.Id;
        }
    }
}
