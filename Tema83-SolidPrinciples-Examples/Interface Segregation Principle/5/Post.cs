using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._5
{
    public class Post : IPost, ILikeable, ICommentable
    {
        private int _likes;
        private List<string> _comments;

        public int PostId { get; private set; }
        public string Author { get; private set; }
        public string Content { get; private set; }
        public DateTime Timestamp { get; private set; }

        public int Likes => _likes;
        public List<string> Comments => _comments;

        public Post(int postId, string author, string content)
        {
            PostId = postId;
            Author = author;
            Content = content;
            Timestamp = DateTime.Now;
            _likes = 0;
            _comments = new List<string>();
        }

        public void Like()
        {
            _likes++;
            Console.WriteLine($"{Author}'s post ({PostId}) was liked. Total likes: {_likes}");
        }

        public void Unlike()
        {
            if (_likes > 0)
            {
                _likes--;
                Console.WriteLine($"{Author}'s post ({PostId}) was unliked. Total likes: {_likes}");
            }
        }

        public void AddComment(string comment)
        {
            _comments.Add(comment);
            Console.WriteLine($"{Author}'s post ({PostId}) received a new comment: '{comment}'");
        }

        public void RemoveComment(string comment)
        {
            if (_comments.Contains(comment))
            {
                _comments.Remove(comment);
                Console.WriteLine($"{Author}'s post ({PostId}) comment '{comment}' was removed.");
            }
        }
    }
}
