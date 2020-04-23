using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PoolTicket
{
    public class Picture:PublicObject
    {
        /// <summary>
        /// شناسه عکس
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// فایل عکس
        /// </summary>
        public byte[] ImageData { get; set; }
        /// <summary>
        /// فرمت عکس
        /// </summary>
        public string ImageMimeType { get; set; }
        /// <summary>
        /// کلید خارجی به جدول استخر
        /// </summary>
        public int? PoolId { get; set; }
        public Pool Pool { get; set; }
        /// <summary>
        /// کلید خارجی به جدول امکانات استخر
        /// </summary>
        public int? PoolFacilityId { get; set; }
        public PoolFacility PoolFacility { get; set; }

        //methods

        public void AddPicture(byte[] imageData, string imageMimeType, int? poolId, int? poolfacilityId = null)
        {
            this.ImageData = ImageData;
            this.ImageMimeType = imageMimeType;
            this.PoolId = poolId;
            this.PoolFacilityId = poolfacilityId;
        }
        public void DeletePicture(int deleteBy)
        {
            base.DeleteIt(deleteBy);
        }
    }
}
