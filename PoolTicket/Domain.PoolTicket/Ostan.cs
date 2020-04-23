using System;
using System.Collections.Generic;


namespace Domain.PoolTicket
{
    public class Ostan
    {
        /// <summary>
        /// شناسه استان
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// نام استان
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// شهرهای استان
        /// </summary>
        public IList<City> Cities { get; set; }


        //methods

        public void CheckOstanNameNotEmpty(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("نام استان را وارد کنید");
            }
        }

        public void CheckOstanNameIsUniqe(string name)
        {
            //write code to check the name is uniqe
            throw new NotImplementedException("باید پیاده سازی شود");
        }

        public void CreateOstan(string name)
        {
            CheckOstanNameNotEmpty(name);
            CheckOstanNameIsUniqe(name);
            this.Name = name;
        }

    }
}
