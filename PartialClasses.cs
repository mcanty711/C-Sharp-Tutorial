using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string LastName { get => _lastName; set => _lastName = value; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
