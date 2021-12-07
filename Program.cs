using System;
using System.Threading.Tasks;

namespace MyFirstBot {
    class Program {
        static void Main(string[] args) {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync() {
            Console.WriteLine("Async Main!");
        }
    }
}