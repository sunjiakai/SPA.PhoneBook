

using Abp.Runtime.Validation;
using SPA.PhoneBook.Dtos;
using SPA.PhoneBook.PhoneBook.Persons;

namespace SPA.PhoneBook.Persons.Dtos
{
    public class GetPersonsInput : PagedAndSortedInputDto, IShouldNormalize
    {
          /// <summary>
		 /// 模糊搜索使用的关键字
		 ///</summary>
        public string Filter { get; set; }


		//// custom codes
 
        //// custom codes end

			  /// <summary>
			 /// 正常化排序使用
			///</summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }


    }
}
