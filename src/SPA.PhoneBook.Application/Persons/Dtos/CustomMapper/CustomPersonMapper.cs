

using AutoMapper;
using SPA.PhoneBook.Persons;
using SPA.PhoneBook.PhoneBook.Persons;

namespace SPA.PhoneBook.Persons.Dtos.CustomMapper
{

    /// <summary>
    /// 配置Person的AutoMapper
    ///</summary>
    internal static class CustomerPersonMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Person, PersonListDto>();
            configuration.CreateMap<PersonEditDto, Person>();



            //// custom codes

            //// custom codes end

        }
    }
}
