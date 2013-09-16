using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemClient.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public IList<ImageModel> Images { get; set; }
        public string ImageSource { get; set; }
        public DateTime Date { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
        public ICollection<VoteModel> Votes { get; set; }
    }
}
