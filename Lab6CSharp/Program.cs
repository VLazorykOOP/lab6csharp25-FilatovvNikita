

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

static void Task1()
{
    List<Worker> workers = new List<Worker>();

    workers.Add(new Personnel("John", "Smith", "Factory", 150));
    workers.Add(new Engineer("Elithabet", "Mondales", "Progamming", 8));
    workers.Add(new Administration("Jimmy", "Bouth", "Hotel", 5000));
    workers.Add(new Engineer("Elithabet", "Smith", "Developer", 6));
    workers.Add(new Administration("Jimmy", "Wood", "Gas station", 6000));
    workers.Add(new Personnel("John", "Bear", "Office", 300));

    Console.WriteLine();

    foreach (Worker worker in workers)
    {
        worker.Show();
    }
}

static void Task2()
{
    List<PhoneBook> phoneBooks = new List<PhoneBook>();

    phoneBooks.Add(new Persona("Smith", "123 Main St", "555-1234"));
    phoneBooks.Add(new Company("Tech Corp", "456 Elm St", "555-5678", "555-8765", "Alice Johnson"));
    phoneBooks.Add(new Friend("Brown", "789 Oak St", "555-2697", new DateTime(2000, 5, 15)));

    foreach (PhoneBook phoneBook in phoneBooks)
    {
        phoneBook.PrintInfo();
    }
    Console.Write("Enter search criteria: ");
    string criteria = Console.ReadLine();
    foreach (PhoneBook phoneBook in phoneBooks)
    {
        phoneBook.SearchCriteria(criteria);
    }
}

static void Task3()
{
    List<PhoneBook> contacts = new List<PhoneBook>();

    try
    {
        contacts.Add(new Persona("Ivanov", "Kyiv", "+380501234567"));
        contacts.Add(new Friend("Petrenko", "Lviv", "+380671112233", new DateTime(1990, 5, 1)));
        contacts.Add(new Company("TechCorp", "Odesa", "+38044332211", "+38044332299", "Andriy"));

        contacts.Add(new Persona("", "Kharkiv", "12345"));
    }
    catch (InvalidPhoneNumberException ex)
    {
        Console.WriteLine($"Помилка номера телефону: {ex.Message}");
    }
    catch (EmptyFieldException ex)
    {
        Console.WriteLine($"Помилка поля: {ex.Message}");
    }
    catch (InvalidCastException ex)
    {
        Console.WriteLine($"Неможливо привести тип: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Загальна помилка: {ex.Message}");
    }

    Console.WriteLine("\nПошук за критерієм 'Pet':");
    foreach (var contact in contacts)
    {
        try
        {
            contact.SearchCriteria("Pet");

            if (contact is Friend friend)
            {
                object obj = friend;
                Company comp = (Company)obj;
            }
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Неможливо перетворити Friend в Company.");
        }
    }
}

static void Task4()
{
    List<Worker> workers = new List<Worker>();

    workers.Add(new Personnel("Alice", "Johnson", "Warehouse", 200));
    workers.Add(new Engineer("Michael", "Brown", "Software Development", 10));
    workers.Add(new Administration("Sarah", "Connor", "Resort", 7000));

    Console.WriteLine();

    foreach (Worker worker in workers)
    {
        worker.Show();
    }
}

Task4();