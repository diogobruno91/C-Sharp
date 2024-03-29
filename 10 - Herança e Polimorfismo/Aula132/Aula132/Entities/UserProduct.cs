﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula132.Entities
{
    class UserProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UserProduct() { }

        public UserProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";

        }

    }
}
