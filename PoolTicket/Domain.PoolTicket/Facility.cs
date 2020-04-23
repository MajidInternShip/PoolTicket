using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Domain.PoolTicket
{
    public class Facility
    {
        /// <summary>
        /// شناسه امکانات
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// نام امکانات
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///توضیحات
        /// </summary>
        public string Description { get; set; }


        public void CheckFacilityNameNotEmpty(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("نام را وارد کنید");

            }
        }
        public void CheckNameIsUniqe(string name)
        {
            throw new NotImplementedException("باید پیاده سازی شود");
        }
        public void CreateFacility(string name, string description)
        {
            CheckFacilityNameNotEmpty(name);
            CheckNameIsUniqe(name);
            this.Name = name;
            this.Description = description;
        }

    }
    
}
