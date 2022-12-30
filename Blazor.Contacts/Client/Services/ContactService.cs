using Blazor.Contacts.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Contacts.Client.Services
{
	public class ContactService : IContactService
	{
		private readonly HttpClient _httpClient;

		public ContactService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task DeleteContact(int id)
		{
			try
			{
				await _httpClient.DeleteAsync($"api/contacts/{id}");
			}
			catch (System.Exception)
			{

				throw;
			}
		}

		public async Task<IEnumerable<Contact>> GetAllContacts()
		{
			try
			{
				return await _httpClient.GetFromJsonAsync<IEnumerable<Contact>>($"api/contacts");
			}
			catch (System.Exception)
			{

				throw;
			}
		}

		public async Task<Contact> GetDetails(int id)
		{
			try
			{
				return await _httpClient.GetFromJsonAsync<Contact>($"api/contacts/{id}");
			}
			catch (System.Exception)
			{

				throw;
			}
		}

		public async Task SaveContact(Contact contact)
		{
			try
			{
				if(contact.Id == 0)
				{
					//insert
					await _httpClient.PostAsJsonAsync<Contact>($"api/contacts", contact);
				}
				else
				{
					//Update
					await _httpClient.PutAsJsonAsync<Contact>($"api/contacts/{contact.Id}", contact);
				}
			}
			catch (System.Exception)
			{

				throw;
			}
		}
	}
}
