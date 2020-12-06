using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Telegram.Bot;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = File.ReadAllText(@"D:\С#\code\Intensiv_bot\token.txt");
           // Console.WriteLine(token);
           // Console.ReadLine();

            TelegramBotClient bot = new TelegramBotClient(token);
            Console.WriteLine($"@{bot.GetMeAsync().Result.Username} start...");

            int max = 5;
            Random random = new Random();
            Dictionary<long, int> db = new Dictionary<long, int>();


            bot.OnMessage += (s, arg) =>
            {
                #region var

                string msgText = arg.Message.Text;
                string firstName = arg.Message.Chat.FirstName;
                string replyMsg = String.Empty;
                int msgId = arg.Message.MessageId;
                long chatId = arg.Message.Chat.Id;

                int user = 0;
                string path = $"id_{chatId.ToString().Substring(0, 5)}";
                bool skip = false;

                Console.WriteLine($"{firstName}: {msgText}");
                #endregion

                if (msgText == "/restart" || !db.ContainsKey(chatId))
                {
                    int StartGame = random.Next(20, 30);
                    db[chatId] = StartGame;
                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    skip = true;
                    replyMsg = $"Загадано число: {db[chatId]}";
                }
                else 
                {
                    if (db[chatId] <= 0) return;

                    int.TryParse(msgText, out user);
                    if (!(user >= 1 && user <= max))
                    { 
                        skip = true;
                        replyMsg = $"Обнаружено читерство. Число: {db[chatId]}";
                    }
                    if (!skip) 
                    {
                        db[chatId] -= user;
                        replyMsg = $"\nХод {firstName}: {user}. Число {db[chatId]}";
                        if (db[chatId] <= 0) 
                        {
                            replyMsg = $"Победил {firstName}";
                            skip = true;
                        }
                    }

                }

                if (!skip) 
                {
                    int temp = random.Next(max) + 1;
                    db[chatId] -= temp;
                    replyMsg = $"\n Ход бота: {temp} Число: {db[chatId]}";
                    if (db[chatId] <= 0) replyMsg = "бот победил";
                }

                bot.SendTextMessageAsync(
                    chatId: chatId,
                    text: replyMsg,
                    replyToMessageId: msgId);
            };


            bot.StartReceiving();
            Console.ReadLine();
        }

        
    }
}
