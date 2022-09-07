using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspx
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            void NewFunction(out int t)
            {
                t = 1;
            }

            NewFunction(out var i);
            
            Console.WriteLine(i);
        }
    }
}