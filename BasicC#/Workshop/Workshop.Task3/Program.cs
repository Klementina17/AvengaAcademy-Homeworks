using System.Diagnostics;
using System.Net.NetworkInformation;
using Workshop.Task3.Models;

Customer[] customers = new Customer[]
{
    new Customer("Klementina","Dimitrova",123456789,234,0),
    new Customer("Kirila","Dimitrova",987654321,246,0)
};
Random random = new Random();

bool UserInterface()
{
    Console.Clear();
    Console.WriteLine("1) Login 2) Register new: ");
    bool isActionValid = int.TryParse(Console.ReadLine(), out int action);

    if(!isActionValid || action<1 || action > 2)
    {
        Console.WriteLine("Choose valid action.");
        Console.ReadLine();
        return false;
    }

    switch (action)
    {
        case 1:
            return Login();
        case 2:
            return Register();
        default:
            break;
    }
    return false;
}

bool Login()
{
    Customer customer = FindCustomer(GetCardNumber(),GetCardPin());

    if (customer != null)
    {
        Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}.");
        Console.ReadLine();
        while (true)
        {
            Console.WriteLine(@"Choose action from the given menu: 1)Check Balance 2)Withdraw 3)Deposit 4)Exit");
            bool isChoiceValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isChoiceValid && choice > 0 && choice < 5)
            {
                switch (choice)
                {
                    case 1:
                        customer.CheckBalance();
                        break;
                    case 2:
                        int moneyToGet = getAmount();
                        customer.Withdraw(moneyToGet);
                        break;
                    case 3:
                        int moneyToAdd = addAmount();
                        customer.Deposit(moneyToAdd);
                        break;
                    case 4:
                        return true;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please choose valide action!");
            }

            Console.WriteLine("Press any key to start over or X to exit!");
            if (Console.ReadLine().ToLower() == "x")
                return true;
        }
    }
    else
    {
        Console.WriteLine("Invalid card number or PIN!");
        Console.ReadLine();
        return false;
    }
}

bool Register()
{
        Console.WriteLine("Enter your FirstName");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your FirstName");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your LastName");

    int cardNumber = GenerateUniqueCardNumber();
    int cardPin= random.Next(100, 1000);

    Customer newCustomer = new Customer(firstName,lastName,cardNumber,cardPin,0);

    Array.Resize(ref customers, customers.Length + 1);
    customers[customers.Length - 1] = newCustomer;
    Console.WriteLine("Registration successful!");
    Console.WriteLine($"Your Card Number: {cardNumber}");
    Console.WriteLine($"Your PIN: {cardPin}");
    Console.ReadLine();
    return false;
}

Customer FindCustomer(int cardNumber,int pin)
{
    foreach(Customer customer in customers)
    {
        if (customer.CardNumber == cardNumber)
        {
            if(customer.CheckCardPin(pin))
            {
                return customer;
            }
        }
    }
    return null;
}
int GetCardNumber()
{
    while (true)
    {
        Console.WriteLine("Enter CardNumber: ");
        bool isCardNumValid = int.TryParse(Console.ReadLine(), out int cardNumber);

        if (isCardNumValid) return cardNumber;

        Console.WriteLine("Enter correct CardNumber!");
    }
}
int GetCardPin()
{
    while (true)
    {
        Console.WriteLine("Enter CardPin: ");
        bool isCardPinValid = int.TryParse(Console.ReadLine(), out int cardPin);

        if (isCardPinValid) return cardPin;
        Console.WriteLine("Enter correct Pin!");
    }
}
int getAmount()
{
    while (true)
    {
        Console.WriteLine("Enter amount to withdraw:");
        bool isAmountValid = int.TryParse(Console.ReadLine(), out int amount);
        if (isAmountValid) return amount;

        Console.WriteLine("Enter valid amount!");
    }
}
int addAmount()
{
    while (true)
    {
        Console.WriteLine("Enter amount to deposit:");
        bool isAmountValid = int.TryParse(Console.ReadLine(), out int amount);
        if (isAmountValid) return amount;
        Console.WriteLine("Enter valid amount!");
    }
}
int GenerateUniqueCardNumber()
{
    Random random = new Random();
    while (true)
    {
        int cardNumber = random.Next(1_000_000_000, 2_000_000_000);

        if (!CardNumberExists(cardNumber)) return cardNumber;
    }
}
bool CardNumberExists(int cardNumber)
{
    foreach (var customer in customers)
    {
        if (customer.CardNumber == cardNumber)
            return true;
    }
    return false;
}
while (!UserInterface()) ;

