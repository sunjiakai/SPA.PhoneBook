using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SPA.PhoneBook.PhoneBook.Persons;

namespace SPA.PhoneBook.PhoneBook.PhoneNumbers
{
    public class PhoneNumber :Entity<long>, IHasCreationTime
    {
        /// <summary>
        /// 电话
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxPhoneNumberLength)]
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneType Type { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>

        public virtual int PersonId { get; set; }
        /// <summary>
        /// 电话所属用户
        /// </summary>

        public Person Person { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>

        public DateTime CreationTime { get; set; }
    }
}
