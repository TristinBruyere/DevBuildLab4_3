using System;
using System.Collections.Generic;

namespace Lab4_3
{
    class Customer
    {
        private string pCompany;
        private string pContactName;
        private string pContactEmail;
        private string pPhone;

        public Customer(string _Company, string _ContactName, string _ContactEmail, string _Phone)
        {
            pCompany = _Company;
            pContactName = _ContactName;
            pContactEmail = _ContactEmail;
            pPhone = _Phone;
        }

        public string GetCompany()
        {
            return pCompany;
        }
        public void SetCompany(string _Company)
        {
            pCompany = _Company;
        }
        public string GetContactName()
        {
            return pContactName;
        }
        public void SetContactName(string _ContactName)
        {
            pContactName = _ContactName;
        }
        public string GetContactEmail()
        {
            return pContactEmail;
        }
        public void SetContactEmail(string _ContactEmail)
        {
            pContactEmail = _ContactEmail;
        }
        public string GetPhone()
        {
            return pPhone;
        }
        public void SetPhone(string _Phone)
        {
            pPhone = _Phone;
        }
        public override string ToString()
        {
            return $"\n===== CUSTOMER INFO =====\nCompany: {pCompany}, Name: {pContactName}, Email: {pContactEmail}, Phone Number: {pPhone}\n";
        }
    }

    class Program
    {
        static bool KeepGoing()
        {
            while (true)
            {

                Console.WriteLine("Would you like to go again? (y/n)");

                string response = Console.ReadLine().ToLower();

                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n.");
                }
            }
        }
        static void PrintCustomers(List<Customer> customerList)
        {
            foreach (Customer next in customerList)
            {
                Console.WriteLine(next);
            }
        }

        static Customer SearchCompanies(List<Customer> customer, string company)
        {
            foreach (Customer next in customer)
            {
                if (next.GetCompany() == company)
                {
                    return next;
                }
            }
            return null;
        }

        static Customer SearchCustomers(List<Customer> customers, string name)
        {
            foreach (Customer next in customers)
            {
                if (next.GetContactName() == name)
                {
                    return next;
                }
            }
            return null;
        }

        static Customer SearchEmail(List<Customer> customers, string email)
        {
            foreach (Customer next in customers)
            {
                if (next.GetContactEmail() == email)
                {
                    return next;
                }
            }
            return null;
        }

        static Customer SearchPhone(List<Customer> customers, string phone)
        {
            foreach (Customer next in customers)
            {
                if (next.GetPhone() == phone)
                {
                    return next;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            //      Testing
            //
            //Customer c0 = new Customer("Rocket", "Tristin", "Tristin@rocket.com", "7341111111");
            //Console.WriteLine(c0);
            //c0.SetCompany("Walmart");
            //Console.WriteLine(c0.GetCompany());
            //c0.SetContactName("Willy");
            //Console.WriteLine(c0.GetContactName());
            //c0.SetContactEmail("willywonka@yahoo.com");
            //Console.WriteLine(c0.GetContactEmail());
            //c0.SetPhone("8887776666");
            //Console.WriteLine(c0.GetPhone());
            //Console.WriteLine(c0);

            List<Customer> clients = new List<Customer>();

            Customer c1 = new Customer("Rocket", "Tristin", "Tristin@rocket.com", "7341111111");
            clients.Add(c1);
            c1 = new Customer("ZapZone", "Bob", "bob@bobington.com", "1112223333");
            clients.Add(c1);
            c1 = new Customer("Cross Fit", "Mary", "mary@crossfit.com", "1320982375");
            clients.Add(c1);

            PrintCustomers(clients);

            Console.WriteLine("Company search:");
            c1 = SearchCompanies(clients, "Rocket");
            Console.WriteLine(c1);

            do {
                Console.Write("Would you like to search by (C)ompany name, (N)ame, (E)-mail, or (P)hone number?: ");
                string searchChoice = Console.ReadLine().ToUpper();
                switch (searchChoice)
                {
                    case "C":
                        Console.Write("Enter the name of the company: ");
                        string companySearch = Console.ReadLine();
                        c1 = SearchCompanies(clients, companySearch);
                        if (c1 != null)
                        {
                            Console.WriteLine("Company found!");
                            Console.WriteLine(c1);
                        }
                        else
                        {
                            Console.WriteLine("That company doesn't exist.");
                        }
                        break;
                    case "N":
                        Console.Write("Enter the name of the customer: ");
                        string nameSearch = Console.ReadLine();
                        c1 = SearchCustomers(clients, nameSearch);
                        if (c1 != null)
                        {
                            Console.WriteLine("Customer found!");
                            Console.WriteLine(c1);
                        }
                        else
                        {
                            Console.WriteLine("That customer doesn't exist.");
                        }
                        break;
                    case "E":
                        Console.Write("Enter the e-mail of the customer: ");
                        string emailSearch = Console.ReadLine();
                        c1 = SearchEmail(clients, emailSearch);
                        if (c1 != null)
                        {
                            Console.WriteLine("Customer found!");
                            Console.WriteLine(c1);
                        }
                        else
                        {
                            Console.WriteLine("That e-mail doesn't exist.");
                        }
                        break;
                    case "P":
                        Console.Write("Enter the phone number of the customer: ");
                        string phoneSearch = Console.ReadLine();
                        c1 = SearchPhone(clients, phoneSearch);
                        if (c1 != null)
                        {
                            Console.WriteLine("Customer found!");
                            Console.WriteLine(c1);
                        }
                        else
                        {
                            Console.WriteLine("That phone number doesn't exist.");
                        }
                        break;
                    default:
                        Console.WriteLine("That is not a valid choice");
                        break;
                }
            } while (KeepGoing());
            Console.WriteLine("Goodbye!");
        }
    }
}
