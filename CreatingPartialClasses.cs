using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreatingPartialClasses
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SamplePartialClass obj = new SamplePartialClass();
            //obj.
        }
    }
    public interface IEmployee
    {
        void EmployeeMethod();
    }

    public interface ICustomer  
    {
        void CustomerMethod();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreatingPartialClasses
{
    public partial class SamplePartialClass : ICustomer
    {
        public void CustomerMethod()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreatingPartialClasses
{
    public partial class SamplePartialClass : IEmployee
    {
        public void EmployeeMethod()
        {

        }
    }
}
