using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_10
{
    public enum FileAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

    public class User
    {
        public string Name { get; set; }
        public FileAccess Permissions { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User
            {
                Name = "John Doe",
                Permissions = FileAccess.Read | FileAccess.Write
            };

            User user2 = new User
            {
                Name = "Jane Doe",
                Permissions = FileAccess.Read | FileAccess.Execute
            };

            Console.WriteLine($"{user1.Name} has the following permissions: {user1.Permissions}");
            Console.WriteLine($"{user2.Name} has the following permissions: {user2.Permissions}");
        }
    }
    }
