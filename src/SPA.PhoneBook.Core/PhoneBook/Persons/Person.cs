using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using SPA.PhoneBook.PhoneBook.PhoneNumbers;

namespace SPA.PhoneBook.PhoneBook.Persons
{
    public class Person:FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxNameLength)]
        public string Name { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        [EmailAddress]
        [MaxLength(PhoneBookConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(PhoneBookConsts.MaxAddressLength)]
        public string Address { get; set; }
        /// <summary>
        /// 电话号码的属性
        /// </summary>

        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
