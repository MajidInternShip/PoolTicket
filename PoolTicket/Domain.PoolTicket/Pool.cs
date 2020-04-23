using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Domain.PoolTicket
{
    public class Pool:PublicObject
    {
        /// <summary>
        /// شناسه استخر
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// نام استخر
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ظرفیت  استخر
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// ساعت شروع
        /// </summary>
        public int StartHour { get; set; }
        /// <summary>
        /// ساعت پایان
        /// </summary>
        public int EndHour { get; set; }
        /// <summary>
        /// کلید خارجی به جدول آدرس
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public Address Address { get; set; }

        public IList<PoolUser> PoolUsers { get; set; }
        public IList<PoolFacility> Facilities { get; set; }
        public IList<Sanse> Sanses { get; set; }
        public IList<Picture> Pictures { get; set; }

        //// -----methods--------

        public void CheckPoolNameNotEmpty(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("نام استخر را وارد کنید");
            }
        }
        public void CheckPoolNameUniqeInCity(string name, int addressId)
        {
            //Later Write code for this method to check the uniqe name in city
            // for example in city Qom we should have one Pool with name دریا
        }
        public void CreatePool(string name, int addressId, int createdBy, int capacity, int startHour, int endHour)
        {

            CheckPoolNameNotEmpty(name);
            CheckPoolNameUniqeInCity(name, addressId);
            base.CreateIt(createdBy);
            this.Name = name;
            this.AddressId = addressId;
            this.Capacity = capacity;
            this.StartHour = StartHour;
            this.EndHour = endHour;
        }
        public void DeletePool(int deleteBy)
        {
            base.DeleteIt(deleteBy);
        }

    }
}
