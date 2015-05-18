using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.UI;
using Haser.SmIntegration.Sample.Model.General;
using Haser.SmIntegration.Sample.Model.Order;
using Haser.SmIntegration.Sample.Model.Parameter;

namespace Haser.SmIntegration.Sample
{
    public partial class Default : Page
    {
        const string ApiLink = "http://smintegration.stockmount.com";
        const string ApiKey = "************************";
        const string ApiPassword = "*****************************";
        const string ApiCulture = "en-US"; //{en-US, tr-TR}

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void setOrder_Click(object sender, EventArgs e)
        {
            // Prepare configuration and order parameter
            OrderParameters parameters = new OrderParameters
            {
                Configuration = new Configuration
                {
                    ApiKey = ApiKey,
                    ApiPassword = ApiPassword,
                    Culture = ApiCulture
                },
                Order = new Order  
                {
                    OrderId = 0, // OrderId = 0 : Insert, OrderId > 0 : Update
                    Nickname = "CustomerNickname", // Unique Nickname or Email
                    Name = "Name",
                    Surname = "Surname",
                    OrderDate = DateTime.Now,
                    IntegrationOrderCode = "IOC8888",
                    ListingStatus = "New", // New, Approved, Shipped, Delivered, Rejected, Completed
                    CompanyTitle = "CompanyTitle", // Fullname can be used instead
                    Fullname = "Customer full name", // CompanyTitle can be used instead
                    PersonalIdentification = "PersonalIdentification",
                    // (TaxNumber & TaxAuthority) can be used instead. TaxNumber, TaxAuthority and PersonalIdentification are not required
                    TaxNumber = "TaxNumber",
                    // PersonalIdentification only can be used instead. TaxNumber, TaxAuthority and PersonalIdentification are not required
                    TaxAuthority = "TaxAuthority",
                    // PersonalIdentification only can be used instead. TaxNumber, TaxAuthority and PersonalIdentification are not required
                    Telephone = "Telephone",
                    Address = "Invoice address",
                    District = "District",
                    City = "City",
                    ZipCode = "ZipCode",
                    Note = "Note",
                    OrderDetails = new List<OrderDetail>
                    {
                        new OrderDetail
                        {
                            IntegrationOrderDetailId = "IOC8888D1",
                            IntegrationProductCode = "ProductCode01",
                            IntegrationProductName = "Product name 01",
                            Quantity = 5,
                            Price = new decimal(55.56),
                            Address = "Different delivery address if not same as invoice address",
                            Telephone = "Telephone", 
                            District = "District",
                            City = "City",
                            ZipCode = "ZipCode",
                            CargoDate = DateTime.Now,
                            CargoCompany = "CargoCompany",
                            CargoPayment = "Buyer", // { Seller, Buyer, Unknown}
                            CargoLabelCode = "CargoLabelCode",
                            DeliveryTitle = "DeliveryTitle",
                            TaxRate = new decimal(18),
                            Invoiced = false, // { true, false}
                            InvoiceDate = DateTime.Now,
                            IntegrationProductImage = "http://www.website.com/images/image.jpg", // An image path
                            CostPrice = new decimal(40.20)
                        },
                        new OrderDetail
                        {
                            IntegrationProductCode = "ProductCode02",
                            IntegrationProductName = "Product name 02",
                            Quantity = 7,
                            Price = new decimal(33)
                        },
                        new OrderDetail
                        {
                            IntegrationProductCode = "ProductCode03",
                            IntegrationProductName = "Product name 03",
                            Quantity = 8,
                            Price = new decimal(88.99)
                        }

                    }

                }
            };




            ResultModel result = SetOrder(parameters);

            if (result.Result)
            {
                int orderId = Convert.ToInt32(result.Response);
                // OrderId can be used for update then
                lblMessage.Text = " Success. Order Id:" + orderId;
            }
            else
            {
                 lblMessage.Text = " Failure. Error: " + result.ErrorMessage;
            }
        } 

        protected void updateOrder_Click(object sender, EventArgs e)
        {
            // Prepare configuration and order parameter
            OrderParameters parameters = new OrderParameters
            {
                Configuration = new Configuration
                {
                    ApiKey = ApiKey,
                    ApiPassword = ApiPassword,
                    Culture = ApiCulture
                },
                Order = new Order
                {
                    OrderId = 99999999, // OrderId = 0 : Insert, OrderId > 0 : Update
                    Nickname = "CustomerNickname", // Unique Nickname or Email
                    Name = "Name",
                    Surname = "Surname",
                    OrderDate = DateTime.Now,
                    IntegrationOrderCode = "IOC8888",
                    ListingStatus = "New", // New, Approved, Shipped, Delivered, Rejected, Completed
                    CompanyTitle = "CompanyTitle", // Fullname can be used instead
                    Fullname = "Customer full name", // CompanyTitle can be used instead
                    PersonalIdentification = "PersonalIdentification",
                    // (TaxNumber & TaxAuthority) can be used instead. TaxNumber, TaxAuthority and PersonalIdentification are not required
                    TaxNumber = "TaxNumber",
                    // PersonalIdentification only can be used instead. TaxNumber, TaxAuthority and PersonalIdentification are not required
                    TaxAuthority = "TaxAuthority",
                    // PersonalIdentification only can be used instead. TaxNumber, TaxAuthority and PersonalIdentification are not required
                    Telephone = "Telephone",
                    Address = "Invoice address",
                    District = "District",
                    City = "City",
                    ZipCode = "ZipCode",
                    Note = "Note",
                    OrderDetails = new List<OrderDetail>
                    {
                        new OrderDetail
                        {
                            IntegrationOrderDetailId = "IOC8888D1",
                            IntegrationProductCode = "ProductCode01",
                            IntegrationProductName = "Product name 01",
                            Quantity = 5,
                            Price = new decimal(55.56),
                            Address = "Different delivery address if not same as invoice address",
                            Telephone = "Telephone", 
                            District = "District",
                            City = "City",
                            ZipCode = "ZipCode",
                            CargoDate = DateTime.Now,
                            CargoCompany = "CargoCompany",
                            CargoPayment = "Buyer", // { Seller, Buyer, Unknown}
                            CargoLabelCode = "CargoLabelCode",
                            DeliveryTitle = "DeliveryTitle",
                            TaxRate = new decimal(18),
                            Invoiced = false, // { true, false}
                            InvoiceDate = DateTime.Now,
                            IntegrationProductImage = "http://www.website.com/images/image.jpg", // An image path
                            CostPrice = new decimal(40.20)
                        },
                        new OrderDetail
                        {
                            IntegrationProductCode = "ProductCode02",
                            IntegrationProductName = "Product name 02",
                            Quantity = 7,
                            Price = new decimal(33)
                        },
                        new OrderDetail
                        {
                            IntegrationProductCode = "ProductCode03",
                            IntegrationProductName = "Product name 03",
                            Quantity = 8,
                            Price = new decimal(88.99)
                        }

                    }

                }
            };




            ResultModel result = SetOrder(parameters);

            if (result.Result)
            {
                int orderId = Convert.ToInt32(result.Response); 
                lblMessage.Text = " Success. Order Id:" + orderId;
            }
            else
            {
                lblMessage.Text = " Failure. Error: " + result.ErrorMessage;
            }
        }

        protected void setOrderListingStatus_Click(object sender, EventArgs e)
        {
            // Prepare configuration and order parameter
            OrderParameters parameters = new OrderParameters
            {
                Configuration = new Configuration
                {
                    ApiKey = ApiKey,
                    ApiPassword = ApiPassword,
                    Culture = ApiCulture
                },
               
                Order = new Order
                {
                    OrderId = 115147, // OrderId = 0 : Insert, OrderId > 0 : Update  
                    ListingStatus = "Shipped", // New, Approved, Shipped, Delivered, Rejected, Completed  

                }
            };




            ResultModel result = SetOrderListingStatus(parameters);

            if (result.Result)
            { 
                lblMessage.Text = " Success. Order listing status has been updated.";
            }
            else
            {
                lblMessage.Text = " Failure. Error: " + result.ErrorMessage;
            }
        }

        #region Webservice 

        public ResultModel SetOrder(Parameters parameters)
        {
            ResultModel result = new ResultModel();

            try
            {
                HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(ApiLink)
                };

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Service name
                using (HttpResponseMessage response = client.PostAsJsonAsync("Api/Order/SetOrder", parameters).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = response.Content.ReadAsAsync<ResultModel>().Result;
                        if (result.Result)
                        {
                            // Other operations can be performed 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                // Log Exception
            }

            return result;
        }

        public ResultModel SetOrderListingStatus(Parameters parameters)
        {
            ResultModel result = new ResultModel();

            try
            {
                HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(ApiLink)
                };

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Service name
                using (HttpResponseMessage response = client.PostAsJsonAsync("Api/Order/SetOrderListingStatus", parameters).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = response.Content.ReadAsAsync<ResultModel>().Result;
                        if (result.Result)
                        {
                            // Other operations can be performed 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                // Log Exception
            }

            return result;
        }

        #endregion
    } 

}