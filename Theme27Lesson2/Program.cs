//Тема 27. Урок 2.
using Theme27Lesson2;

decimal curBalance=0;
BankAccount bankAccount = new BankAccount();
bool program = true;
do
{
    Console.Clear();
    Console.WriteLine("Какое действие вы хотите выполнить:\n" +
    "пополнить/снять/проверить баланс/выйти?");
    string str = Console.ReadLine();
    switch (str)
    {
        case "пополнить":
            {
                decimal addSum;
                Console.Write("Введите сумму, которую хотите внести: ");
                if(decimal.TryParse(Console.ReadLine(), out addSum)&&addSum>0)
                curBalance = bankAccount.AddMoney(curBalance, addSum);
                else Console.WriteLine("Введите сумму больше нуля.");
            }
            break;
        case "снять":
            {
                decimal subSum;
                Console.Write("Введите сумму, которую хотите вывести: ");
                if (decimal.TryParse(Console.ReadLine(), out subSum) && subSum > 0)
                    curBalance = bankAccount.WithdrawMoney(curBalance, subSum);
                else Console.WriteLine("Введите сумму больше нуля.");
                
            }
            break;
        case "проверить баланс": bankAccount.PrintBalance(curBalance); break;
        case "выйти": program=false; break;
        default: Console.WriteLine("Неверная команда"); break;
    }
    Console.ReadKey();
}
while (program == true);
Environment.Exit(0);
    
