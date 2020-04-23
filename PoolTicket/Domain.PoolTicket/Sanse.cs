using System;
using System.Collections.Generic;

namespace Domain.PoolTicket
{
    public class Sanse:PublicObject
    {
        /// <summary>
        /// شناسه سانس
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// تاریخ سانس
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// ساعت شروع
        /// </summary>
        public int StartHour { get; set; }
        /// <summary>
        /// ساعت پایان
        /// </summary>
        public int EndHour { get; set; }
        /// <summary>
        /// قیمت 
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// تخفیف 
        /// </summary>
        public int Discount { get; set; }
        /// <summary>
        /// ظرفیت سانس
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// تعداد رزرو ها
        /// </summary>
        public int ReserveCount { get; set; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// کلید خارجی به استخر
        /// </summary>
        public int PoolId { get; set; }
        /// <summary>
        /// استخر
        /// </summary>
        public Pool Pool { get; set; }
        public IList<Reserve> Reserves { get; set; }


    }
}
