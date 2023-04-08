using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal class ChatbotService
    {
        public async Task<string> GetResponseAsync(string userInput)
        {
            await Task.Delay(500); // Simulate a small delay
            return $"Chatbot: {userInput}";
        }
    }
}
