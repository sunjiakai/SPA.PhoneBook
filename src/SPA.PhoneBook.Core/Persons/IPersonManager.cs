

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using SPA.PhoneBook.PhoneBook.Persons;


namespace SPA.PhoneBook.Persons
{
    public interface IPersonManager : IDomainService
    {

        /// <summary>
    /// 初始化方法
    ///</summary>
        void InitPerson();



		//// custom codes
 
        //// custom codes end

    }
}
