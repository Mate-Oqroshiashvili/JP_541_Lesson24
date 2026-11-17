using Lesson24.Enums;

namespace Lesson24.Helpers
{
    internal static class FileHelper<T>
    {
        private static readonly string[] _paths = new string[]
        {
            @"C:\Users\Mate_Okroshiashvili\Desktop\BankSystem\BankUsers.txt",
            @"C:\Users\Mate_Okroshiashvili\Desktop\BankSystem\Banks.txt",
            @"C:\Users\Mate_Okroshiashvili\Desktop\BankSystem\Transactions.txt"
        };

        public static void WriteInFile(FILE_PATHS filePath, T entity, bool append = false)
        {
            using (StreamWriter writer = new StreamWriter(
                _paths[Convert.ToInt32(filePath)], append: append))
            {
                writer.WriteLine(entity);
            }
        }

        public static void WriteInFile(FILE_PATHS filePath, List<T> values, bool append = false)
        {
            using (StreamWriter writer = new StreamWriter(
                _paths[Convert.ToInt32(filePath)], append: append))
            {
                foreach (T entity in values) 
                {
                    writer.WriteLine(entity);
                }
            }
        }

        public static void ReadFromFile(FILE_PATHS filePath)
        {
            using (StreamReader reader = new StreamReader(
                _paths[Convert.ToInt32(filePath)]))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
