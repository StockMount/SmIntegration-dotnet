namespace Haser.SmIntegration.Sample.Model.Order
{
    public class OrderDetail
    {
        public string IntegrationProductCode { get; set; }
        public string IntegrationProductName { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public string Telephone { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string IntegrationOrderDetailId { get; set; }
        public System.DateTime CargoDate { get; set; }
        public string CargoCompany { get; set; }
        public string CargoLabelCode { get; set; }
        public string DeliveryTitle { get; set; }
        public decimal TaxRate { get; set; }
        public bool Invoiced { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string IntegrationProductImage { get; set; }
        public decimal CostPrice { get; set; }
        public string CargoPayment { get; set; }
    }
}