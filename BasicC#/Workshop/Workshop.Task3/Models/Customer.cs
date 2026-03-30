namespace Workshop.Task3.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CardNumber { get; set; }
        private int CardPin { get; set; }
        private int Balance { get; set; }

        public Customer()
        {
            
        }
        public Customer(string firstName, string lastName, int cardNumber, int cardPin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            CardPin = cardPin;
            Balance = balance;
        }

        public bool CheckCardPin(int enteredPin)
        {
            return CardPin == enteredPin;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }

        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0.");
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal successful. New balance: {Balance}");
        }

        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0.");
            }

            Balance += amount;
            Console.WriteLine($"Deposit successful. New balance: {Balance}");
        }
    }
}
