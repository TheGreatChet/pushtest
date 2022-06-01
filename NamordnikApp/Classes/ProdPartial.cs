using NamordnikApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamordnikApp.ADO
{
    public partial class Product
    {
        public string MaterialList
        {
            get
            {
                string a = "";
                foreach (var item in ConnectionClass.connection.ProductMaterial.Where(c => c.ProductID == ID))
                {
                    a += ConnectionClass.connection.Material.Where(c => c.ID == item.MaterialID).First().Title + ", ";
                }
                return a;
            }
        }

        public string ActualImage
        {
            get
            {
                if (Image != null)
                    return "/Resources" + Image;
                else
                    return "/Resources/products/picture.png";
            }
        }
    }
}
