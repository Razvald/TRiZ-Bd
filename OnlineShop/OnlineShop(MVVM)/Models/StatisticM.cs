﻿using OnlineShop_MVVM_.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_MVVM_.Models
{
    public class StatisticM
    {
        public string SearchPoint { get; set; }
        public string SearchEmp { get; set;}

        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<PickupPoint> PickupPoints { get; set; }
    }
}
