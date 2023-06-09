﻿using Intern.Entities;
using Intern.ViewModels.BillAdmin;

namespace Intern.ViewModels.Order
{
    public class AllBillDetails
    {
        public Bill Bill { get; set; }
        public List<BillDetailAndProduct> billDetailAndProductList { get; set; }
        public List<Sales>? Sales { get; set; }
    }
}
