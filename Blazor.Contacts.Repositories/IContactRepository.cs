using Blazor.Contacts.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Repositories
{
	public interface IContactRepository
	{
		Task<bool> InsertContact(Contact contact);
		Task<bool> UpdateContact(Contact contact);
		Task DeleteContact(int id);
		Task<IEnumerable<Contact>> GetAllContacts();
		Task<Contact> GetDetails(int id);
	}
}
