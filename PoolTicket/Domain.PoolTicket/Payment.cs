using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PoolTicket
{
    public class Payment:PublicObject 
    {
        /// <summary>
        /// شناسه پرداخت
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// پول پرداخت شده
        /// </summary>
        public int PayedMoney { get; set; }
        /// <summary>
        /// نوع پرداخت
        /// </summary>
        public PaymentType PaymentType { get; set; }
        /// <summary>
        /// وضعیت پرداخت کامل
        /// </summary>
        public bool IsComplete { get; set; }
        /// <summary>
        /// وضعیت پرداخت کنسل
        /// </summary>
        public bool IsCanceled { get; set; }
        /// <summary>
        /// کد تراکنش
        /// </summary>
        public string PayedCode { get; set; }
        /// <
        /// summary>
        /// کلید خارجی به رزرو0
        /// </summary>
        public int ReservId { get; set; }
        /// <summary>
        /// رزرو
        /// </summary>
        public Reserve Reserve { get; set; }

        //methods

        //پرداخت نقدی 
        public void PayCashMoney(int reserveId, int money)
        {
            PaymentType = PaymentType.CASHPAYMENT;
            PayedMoney = money;
            IsComplete = true;
            IsCanceled = false;
            ReservId = reserveId;
            PayedCode = null;

        }
        /// <summary>
        /// پرداخت اینترنتی
        /// </summary>
        /// <param name="reserveId">کلید خارجی به رزرو</param>
        /// <param name="money">مقدار پرداخت</param>
        /// <param name="payCode"> کدپیگیری تراکنش</param>
        public void PayInternetMoney(int reserveId, int money, string payCode)
        {
            PaymentType = PaymentType.INTERNETPAYMENT;
            PayedMoney = money;
            this.PayedCode = payCode;
            IsComplete = true;
            IsCanceled = false;

        }
    }

}
    
