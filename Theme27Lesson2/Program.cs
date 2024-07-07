//Тема 27. Урок 2.
using Theme27Lesson2;

decimal curBalance;
Console.WriteLine("Введите баланс: ");
decimal.TryParse(Console.ReadLine(), out curBalance);
BankAccount bankAccount = new BankAccount();
curBalance = bankAccount.AddMoney(curBalance, 500);
bankAccount.PrintBalance(curBalance);
curBalance = bankAccount.WithdrawMoney(curBalance, 333);
bankAccount.PrintBalance(curBalance);

