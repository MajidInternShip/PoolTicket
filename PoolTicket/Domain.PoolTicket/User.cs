using System;

namespace Domain.PoolTicket
{
    public class User:PublicObject
    {
        /// <summary>
        /// شناسه کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// نام کاربر
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// فامیلی کاربر
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// شماره موبایل کاربر
        /// </summary>
        public string MobileNumber { get; set; }
        /// <summary>
        /// نام کاربری
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// پسورد
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime Birthday { get; set; }


        public void RegisterUser(string mobileNumber,string userName,string password)
        {
            CheckMobileNumberNotEmpty(mobileNumber);
            CheckUserNameNotEmpty(userName);
            CheckUserNameIsUnique(userName);
            this.MobileNumber = mobileNumber;
            this.UserName = userName;
            this.Password = password;
        }
        public void CheckMobileNumberNotEmpty(string mobileNumber)
        {
            if (String.IsNullOrEmpty(mobileNumber))
                throw new ArgumentNullException("شماره همراه را وارد کنید");
        }
        public void CheckUserNameNotEmpty(string userName)
        {
            if (String.IsNullOrEmpty(userName))
                throw new ArgumentNullException("نام کاربری را وارد کنید");
        }
        public void CheckUserNameIsUnique(string userName)
        {
            throw new Exception();
        }
        //ادامه ی متدها به همین صورت نوشته میشود



    }
}
