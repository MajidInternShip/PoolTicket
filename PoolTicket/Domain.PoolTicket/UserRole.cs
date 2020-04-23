using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PoolTicket
{
    public class UserRole
    {
        /// <summary>
        /// شناسه 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// کلید خارجی به جدول کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// کاربر
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// کلید خارجی به جدول نقش ها
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// نقش
        /// </summary>
        public Role Role { get; set; }
    }
}
