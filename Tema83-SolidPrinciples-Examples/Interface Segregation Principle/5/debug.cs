using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._5
{
    public class debug
    {
        public debug()
        {
            Post post1 = new Post(1, "JohnDoe", "Hello, World!");
            Post post2 = new Post(2, "JaneSmith", "Check out this beautiful sunset!");

            post1.Like();
            post1.Like();
            post1.Unlike();
            post1.AddComment("Nice post!");
            post1.AddComment("Keep it up!");

            post2.Like();
            post2.AddComment("Amazing photo!");
        }
    }
}
