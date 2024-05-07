using Task_Project.Model;

public static class ContactService
{
	public static void AddContact(Contact contact)
	{
		contact.Id = ContactData.Contacts.Count + 1; // Generate unique ID
		ContactData.Contacts.Add(contact);
	}

	public static List<Contact> GetContacts()
	{
		return ContactData.Contacts;
	}

	public static void UpdateContact(Contact contact)
	{
		var existingContact = ContactData.Contacts.FirstOrDefault(c => c.Id == contact.Id);
		if (existingContact != null)
		{
			existingContact.FirstName = contact.FirstName;
			existingContact.LastName = contact.LastName;
			existingContact.Email = contact.Email;
			existingContact.PhoneNumber = contact.PhoneNumber;
		}
	}

	public static void DeleteContact(int id)
	{
		var contactToRemove = ContactData.Contacts.FirstOrDefault(c => c.Id == id);
		if (contactToRemove != null)
		{
			ContactData.Contacts.Remove(contactToRemove);
		}
	}
}
