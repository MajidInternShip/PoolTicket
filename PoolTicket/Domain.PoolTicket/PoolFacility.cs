

namespace Domain.PoolTicket
{
    public class PoolFacility
    {
        /// <summary>
        /// شناسه امکانات استخرها
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// وضعیت امکانات استختر
        /// </summary>
        public FacilityState State { get; set; }
        /// <summary>
        /// ظرفیت امکانات
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// کلید خارجی به جدول امکانات پایه
        /// </summary>

        public int FacilityId { get; set; }
        public Facility Facility { get; set; }

        /// <summary>
        /// کلید خارجی به جدول استخر
        /// </summary>
        public int PoolId { get; set; }
        public Pool Pool { get; set; }


    }

}
