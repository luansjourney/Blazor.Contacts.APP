using Blazor.Contacts.Shared;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Contacts.Client.Services
{
	public interface IContactService
	{
		Task SaveContact(Contact contact);
		Task DeleteContact(int id);
		Task<IEnumerable<Contact>> GetAllContacts();
		Task<Contact> GetDetails(int id);
	}
}
