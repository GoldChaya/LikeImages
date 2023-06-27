using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApril26.Data
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateUploaded { get; set; }
        public int Likes { get; set; }
    }
}
