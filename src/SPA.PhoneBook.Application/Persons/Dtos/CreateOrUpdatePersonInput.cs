

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SPA.PhoneBook.PhoneBook.Persons;

namespace SPA.PhoneBook.Persons.Dtos
{
    public class CreateOrUpdatePersonInput
    {
        [Required]
        public PersonEditDto Person { get; set; }



		//// custom codes
 
        //// custom codes end
    }
}