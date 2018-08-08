

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using SPA.PhoneBook.PhoneBook.Persons;
using System.Collections.Generic;
using SPA.PhoneBook.PhoneBook.PhoneNumbers;

namespace SPA.PhoneBook.Persons.Dtos
{
    public class PersonListDto : FullAuditedEntityDto
    {

/// <summary>
/// Name
/// </summary>
[MaxLength(2147483647, ErrorMessage="Name超出最大长度")]
[Required(ErrorMessage="Name不能为空")]
public string Name { get; set; }


/// <summary>
/// EmailAddress
/// </summary>
[MaxLength(2147483647, ErrorMessage="EmailAddress超出最大长度")]
public string EmailAddress { get; set; }


/// <summary>
/// Address
/// </summary>
[MaxLength(2147483647, ErrorMessage="Address超出最大长度")]
public string Address { get; set; }


/// <summary>
/// PhoneNumbers
/// </summary>
public ICollection<PhoneNumber> PhoneNumbers { get; set; }






		//// custom codes
 
        //// custom codes end
    }
}