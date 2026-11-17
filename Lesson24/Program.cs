using Lesson24.Enums;
using Lesson24.Helpers;
using Lesson24.Models;

List<User> users = new List<User>()
{
    new User("USR001", "Giorgi Beridze", "giorgi@gmail.com", "123456", "599123456"),
    new User("USR002", "Nino Kapanadze", "nino@gmail.com", "123456", "577123456"),
    new User("USR003", "Luka Maisuradze", "luka@gmail.com", "123456", "555123456"),
    new User("USR004", "Ana Gelashvili", "ana@gmail.com", "123456", "568123456"),
    new User("USR005", "Dato Chikovani", "dato@gmail.com", "123456", "595123456")
};

//Bank bank = new Bank("bank1", 10000);

//bank.Users.AddRange(users);

//foreach (User user in users)
//{
//    user.BankAccounts.Add(new BankAccount(1000, user));
//    user.BankAccounts.Add(new BankAccount(2000, user));
//}

//FileHelper<Bank>.WriteInFile(FILE_PATHS.BanksPath, bank);
//FileHelper<User>.WriteInFile(FILE_PATHS.UsersPath, users);

//FileHelper<Bank>.ReadFromFile(FILE_PATHS.BanksPath);
//Console.WriteLine();
//FileHelper<User>.ReadFromFile(FILE_PATHS.UsersPath);

await JsonHelper<User>.WriteInJsonAsync(FILE_PATHS.UsersPath, users);

List<User> users1 = new List<User>()
{
    new User("asd", "asd", "asda", "asda", "asdasd"),
    new BankSupport("asd", "asd", "asda", "asda", "asdasd")
};