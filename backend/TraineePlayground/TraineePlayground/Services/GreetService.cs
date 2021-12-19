using System;
using System.Threading;

namespace TraineePlayground.Services
{
    public class GreetService
    {
        private string userName;
        private string greetPrefix = "Hello ";

        public string Greet(string userName)
        {
            this.userName = userName;
            return GenerateGreet();
        }

        private string GenerateGreet()
        {
            // Let me think a few seconds... What was your name again... I am getting old...
            Thread.Sleep(5000);

            return greetPrefix + userName;
        }
    }
}
