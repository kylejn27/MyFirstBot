using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using DSharpPlus;

namespace PingPongBot {
    class Program {
        static void Main(string[] args) {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync() {
            string botToken = ConfigurationManager.AppSettings.Get("BotToken");

            var discord = new DiscordClient(new DiscordConfiguration() {
                Token = botToken,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged     
            });

            discord.MessageCreated += async (s, e) => {
                if(e.Message.Content.ToLower().StartsWith("ping")) {
                    await e.Message.RespondAsync("pong");
                }
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}