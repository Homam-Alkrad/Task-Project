using Task_Project.Model;

public static class ContactData
{
	public static List<Contact> Contacts { get; private set; } = new List<Contact>();

	static ContactData()
	{
        Contacts = new List<Contact>
        {
            new Contact { Id = 1, FirstName = "Homam", LastName = "Ahmad", Email = "alkurdihom@gmail.com", PhoneNumber = "0791089960" },
            new Contact { Id = 2, FirstName = "Qasem", LastName = "Alkrad", Email = "h.alkrad.dev@gmail.com", PhoneNumber = "0797412338" },
            new Contact { Id = 3, FirstName = "Sami", LastName = "Waledd", Email = "homam@gmail.com", PhoneNumber = "07863254" }
        };
    }
}
