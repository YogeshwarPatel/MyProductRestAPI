using System;
using System.Collections.Generic;
using System.Text;
using MyProductCore.EntityLayer.myProduct;
using System.Collections.ObjectModel;

namespace MyProductCore.EntityLayer.myProduct
{
    public class Customer
    {
        public Customer()
        {
        }

        public String CustomerCode { get; set; }
        public String CustomerName { get; set; }
        public String BillingAddress { get; set; }
        public String DeliveryAddress { get; set; }
        public String DeliveryPhone { get; set; }
        public String BillingState { get; set; }
        public String BillingPostcode { get; set; }
    }
}
