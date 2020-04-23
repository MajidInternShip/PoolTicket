using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PoolTicket
{
    public class Address
    {
        /// <summary>
        /// شناسه آدرس
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// آدرس دقیق  
        /// </summary>
        public string ExactAddress { get; set; }
        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// عرض جغرافیایی
        /// </summary>
        public decimal? Latitude { get; set; }
        /// <summary>
        /// طول جغرافیایی
        /// </summary>
        public decimal? Longitdue { get; set; }
        /// <summary>
        /// کلید خارجی به شهر
        /// </summary>
        public int CityId { get; set; }
        //شهر
        public City City { get; set; }

        ////methods
        public void CheckAddressNotEmpty(string address)
        {
            if (String.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException("آدرس باید  وارد شود");
            }
        }
        public void CheckCityIdExist(int CityId)
        {
            //check this foreign key exist
            throw new NotImplementedException(" باید پیاده سازی شود");
        }
        public void CreateAddress(string address, int cityId, decimal? latidude = null, decimal? longitude = null, string postalCode = null)
        {
            CheckAddressNotEmpty(address);
            CheckCityIdExist(cityId);
            this.ExactAddress = address;
            this.CityId = CityId;
            this.Latitude = latidude;
            this.Longitdue = longitude;
            this.PostalCode = postalCode;
        }


    }
}
