using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricsOnlineWebApp
{
    public partial class Product
    {
        private ElectricsOnlineWebAppEntities _ctx = new ElectricsOnlineWebAppEntities();
        public List<Product> All
        {
            get
            {
                return _ctx.Products.ToList<Product>();

            }
        }
    }
}