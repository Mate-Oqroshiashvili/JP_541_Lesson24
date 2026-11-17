using Lesson24.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Lesson24.Helpers
{
    internal static class JsonHelper<T>
    {
        private static readonly string[] _paths = new string[]
        {
            @"C:\Users\Mate_Okroshiashvili\Desktop\BankSystem\BankUsers.json",
            @"C:\Users\Mate_Okroshiashvili\Desktop\BankSystem\Banks.json",
            @"C:\Users\Mate_Okroshiashvili\Desktop\BankSystem\Transactions.json"
        };

        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };

        public async static Task WriteInJsonAsync(FILE_PATHS path, T entity)
        {
            await using FileStream stream = 
                File.Create(_paths[Convert.ToInt32(path)]);

            await JsonSerializer
                .SerializeAsync(stream, entity, _options);
        }

        public async static Task WriteInJsonAsync(FILE_PATHS path, List<T> values)
        {
            await using FileStream stream = 
                File.Create(_paths[Convert.ToInt32(path)]);

            await JsonSerializer
                .SerializeAsync(stream, values, _options);
        }
    }
}
