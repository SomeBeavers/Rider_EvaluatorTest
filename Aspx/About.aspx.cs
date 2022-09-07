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

            var method1 = i == 1 ? Method1() : Method2();

            Console.WriteLine(i);
        }

        private int Method2()
        {
            return 2;
        }

        private int Method1()
        {
            return 1;
        }
    }
}