
using Abp.Domain.Services;

namespace SPA.PhoneBook
{
	public abstract class PhoneBookDomainServiceBase : DomainService
	{
		/* Add your common members for all your domain services. */
		/*在领域服务中添加你的自定义公共方法*/
		
		//// custom codes
		
		//// custom codes end
		
		protected PhoneBookDomainServiceBase()
		{
			LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
		}
	}
}
