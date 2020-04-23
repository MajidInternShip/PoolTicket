using System;
namespace Domain.PoolTicket
{
    public class City
    {
        /// <summary>
        /// شناسه شهر
        /// </summary>
        public int Id { get; set;}
        /// <summary>
        /// نام شهر
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// کلید خارجی به استان
        /// </summary>
        public int OstanId { get; set; }
        /// <summary>
        /// استان شهر
        /// </summary>
        public Ostan Ostan { get; set; }

        //methods
        public void CheckCityNameNotEmpty(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("نام شهر باید وارد شود");
            }
        }
        public void CheckCityNameIsUniqe(string name, int ostanId)
        {
            //we can have two city with same name but their Ostan's should different
            throw new NotImplementedException("باید پیاده سازی شود");
        }
        public void CheckOstanIdIsExist(int ostanId)
        {
            //should check if this OstanId is exist in table Ostan
            throw new NotImplementedException("باید پیاده سازی شود");
        }
        public void CreateCity(string name, int ostanId)
        {
            CheckCityNameNotEmpty(name);
            CheckOstanIdIsExist(ostanId);
            CheckCityNameIsUniqe(name, ostanId);
            this.Name = name;
            this.OstanId = ostanId;
        }
    }
}
