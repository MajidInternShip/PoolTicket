using System;

namespace Domain.PoolTicket
{
    public class PublicObject
    {
        public bool IsActive { get; set; } = true;
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public string Description { get; set; }

        public void DeleteIt(int deletedBy)
        {
            this.CheckEntityIsDelete();
            IsDel = true;
            DeletedDate = DateTime.Now;
            DeletedBy = deletedBy;
        }
        public void CheckEntityIsDelete()
        {
            if (this.IsDel)
                throw new InvalidOperationException("این اطلاعات از قبل حذف شده است");
        }

        public void ModifyIt(int modifiedBy)
        {
            ModifiedDate = DateTime.Now;
            ModifiedBy = modifiedBy;
        }

        public void CreateIt(int createBy)
        {
            ModifiedDate = null;
            ModifiedBy = null;
            CreatedDate = DateTime.Now;
            CreatedBy = createBy;
            DeletedDate = null;
            DeletedBy = null;
        }

        public void ActiveIt(int userId)
        {
            IsActive = true;
            ModifiedDate = DateTime.Now;
            ModifiedBy = userId;
        }

        public void DeActiveIt(int userId)
        {
            IsActive = false;
            ModifiedDate = DateTime.Now;
            ModifiedBy = userId;
        }
        public void SetDescription(int userId,string description)
        {
            ModifiedDate = DateTime.Now;
            ModifiedBy = userId;
            Description = description;
        }
    }
}
