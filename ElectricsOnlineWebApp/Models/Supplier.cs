using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricsOnlineWebApp
{
    public partial class Supplier
    {
        private ElectricsOnlineWebAppEntities _ctx = new ElectricsOnlineWebAppEntities();

        public IEnumerable<Supplier> All
        {
            get
            {
                return _ctx.Suppliers;
            }
        }
    }
}