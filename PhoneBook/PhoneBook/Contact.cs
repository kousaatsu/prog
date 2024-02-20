using System;

namespace PhoneBook
{
	public class Contact
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public long Number { get; set; }

		public Contact(string _name, long _number, int _id)
		{
			Name = _name;
			Number = _number;
			Id = _id;
		}

		//добавление, удаление, поиск по имени, вывод всех контактов
	}
}