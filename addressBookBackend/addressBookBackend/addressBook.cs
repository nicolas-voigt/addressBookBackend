using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addressBookBackendApi
{
    public class addressBook
    {
        public DateTime lastModified { get; }

        public String firstName { get; set; }
        public String lastName { get; set; }

    }
}
