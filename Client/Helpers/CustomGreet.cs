using System;

namespace BlazorTeste.Client.Helpers
{
    public class CustomGreet
    {
        public static string customGreeting(string value)
        {
            return value.ToUpper() + " hoje é " + DateTime.Today;
        }
    }
}