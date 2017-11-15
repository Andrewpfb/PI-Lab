using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace MVC5_3.Models
{
    public class Video
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        [NotMapped]
        public FileStream Filestream { get; private set; }

        public Video() { }
        public Video(string name)
        {
            Title = name;
        }
    }
}