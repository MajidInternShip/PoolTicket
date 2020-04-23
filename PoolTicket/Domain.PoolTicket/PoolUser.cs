using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PoolTicket
{
    public class PoolUser
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///کلید خارجی به استخر
        /// </summary>
        public int PoolId { get; set; }
        /// <summary>
        /// استخر
        /// </summary>
        public Pool Pool { get; set; }
        /// <summary>
        /// کلید خارجی به کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// کاربر
        /// </summary>
        public User User { get; set; }
    }
}
