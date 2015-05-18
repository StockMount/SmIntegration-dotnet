using System;
using System.Collections.Generic;

namespace Haser.SmIntegration.Sample.Model.Order
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Nickname { get; set; }
        public DateTime OrderDate { get; set; }
        public string IntegrationOrderCode { get; set; }
        public string ListingStatus { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalIdentification { get; set; }
        public string TaxNumber { get; set; }
        public string TaxAuthority { get; set; }
        public string Telephone { get; set; }
        public string Note { get; set; }
        public string CompanyTitle { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}