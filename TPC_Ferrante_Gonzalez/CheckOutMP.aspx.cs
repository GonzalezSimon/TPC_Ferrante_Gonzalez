using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MercadoPago.Config;
using MercadoPago.Client.Common;
using MercadoPago.Client.Preference;

namespace TPC_Ferrante_Gonzalez
{
    public partial class CheckOutMP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MercadoPagoConfig.AccessToken = "TEST-8650963571641233-072207-e6dd2a055dafe385439a88bb5fb66266-532051842";

            
            // ...


            //////////////////////////////////DATOS COMPRADOR
            var payer = new PreferencePayerRequest
            {
                Name = "Charles",
                Surname = "Luevano",
                Email = "charles@hotmail.com",
                Phone = new PhoneRequest
                {
                    AreaCode = "",
                    Number = "949 128 866",
                },

                Identification = new IdentificationRequest
                {
                    Type = "DNI",
                    Number = "12345678",
                },

                Address = new AddressRequest
                {
                    StreetName = "Cuesta Miguel Armendáriz",
                    StreetNumber = "1004",
                    ZipCode = "11020",
                },
            };



            ////////////////////////////////////////////////////Datos producto
            ///
            var item = new PreferenceItemRequest
            {
                Id = "1234",
                Title = "Lightweight Paper Table",
                Description = "Inspired by the classic foldable art of origami",
                CategoryId = "home",
                Quantity = 3,
                CurrencyId = "ARS",
                UnitPrice = 55.41m,
            };









            ///////////////////////////////////gets de pago
            var request = new PreferenceRequest
            {
                // ...
                BackUrls = new PreferenceBackUrlsRequest
                {
                    Success = "https://www.tu-sitio/success",
                    Failure = "http://www.tu-sitio/failure",
                    Pending = "http://www.tu-sitio/pendings",
                },
                AutoReturn = "approved",
            };
        }
    }
}