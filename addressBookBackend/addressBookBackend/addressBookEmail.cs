using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addressBookBackendApi
{
    public class addressBookEmail
    {
        public String emailAddress { get; set; }

        public addressBookCategory category { get; set; }
    }
}
