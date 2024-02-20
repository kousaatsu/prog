using System;
using System.Collections.Generic;

namespace PhoneBook
{
	public class PhoneBook
	{
		private List<Contact> _contacts { get; set; } = new List<Contact>();
		public string Output;
		public void Add(Contact contact)
		{
			_contacts.Add(contact);
		}
		public void Delete(string name)
		{
			Contact contact = _contacts.Find(c => c.Name == name);
			_contacts.Remove(contact);
		}
		public void ShowByName(string name)
		{
			Contact contact = _contacts.Find(c => c.Name == name);
			if (contact == null)
			{
				Console.WriteLine("Contact not found");
			}
			else
			{
				ShowContact(contact);
			}
		}
		private void ShowAllList(List<Contact> contacts)
		{
			foreach (Contact contact in _contacts)
			{
				ShowContact(contact);
			}
		}

		public void ShowAll()
		{
			ShowAllList(_contacts);
		}

		private void ShowContact(Contact contact)
		{
			Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
		}
		//добавление, удаление, поиск по имени, вывод всех контактов
	}
}