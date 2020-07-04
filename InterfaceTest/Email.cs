using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Email : ISendable
    {
        private string email = "admin@c.com";
        public void Send(string msg)
        {
            Console.WriteLine($"{msg} to {email}");
        }
    }

    public class SnailMail : ISendable
    {
        public string Address { get; set; }

        public void Send(string msg)
        {
            Console.WriteLine($"Visit {Address} and deliver note: {msg}");
        }

        public bool CheckAddress()
        {
            // Check...
            return true;
        }
    }

    public class SMS : ISendable
    {
        public string Phone { get; set; }

        public void Send(string msg)
        {
            Console.WriteLine($"Send message {msg} to {Phone}");

        }

        public void TestPhoneNumber()
        {
            //...

        }
    }


}
