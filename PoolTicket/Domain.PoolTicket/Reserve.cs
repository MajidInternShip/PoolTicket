using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PoolTicket
{
    public class Reserve:PublicObject
    {
        /// <summary>
        /// شناسه رزرو
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// تاریخ رزرو
        /// </summary>
        public DateTime ReserveDate { get; set; }
        /// <summary>
        /// تعداد بلیط
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// کلید خارجی به کاربر رزرو کننده
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// کلید خارجی به سانس رزرو شده
        /// </summary>
        public int SanseId { get; set; }
        public Sanse Sanse { get; set; }
        /// <summary>
        /// کلید خارجی به جزئیات پرداخت
        /// </summary>
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        //methods
        public void DeleteReserve(int deleteBy)
        {
            base.DeleteIt(deleteBy);
        }
        public void AddReserve(int sanseId, int userId, DateTime date, int quantity)
        {
            this.SanseId = sanseId;
            this.UserId = userId;
            ReserveDate = date;
            this.Quantity = quantity;
        }
        
    }
}
