using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApril26.Data
{
    public class ImageRepository
    {
        private string _connectionString;
        public ImageRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Image> GetImages()
        {
            using var context = new ImageDBContext(_connectionString);
            return context.Images.OrderByDescending(i => i.DateUploaded).ToList();
        }

        public void Add(Image image)
        {
            using var context = new ImageDBContext(_connectionString);
            context.Images.Add(image);
            context.SaveChanges();
        }

        public Image GetImage(int id)
        {
            using var context = new ImageDBContext(_connectionString);
            return context.Images.FirstOrDefault(i => i.Id == id);
        }

        public void AddLike(int id)
        {
            using var context = new ImageDBContext(_connectionString);
            context.Database.ExecuteSqlInterpolated($"UPDATE Images SET Likes = Likes + 1 WHERE Id = {id}");
        }

        public int GetLikes(int id)
        {
            using var context = new ImageDBContext(_connectionString);
            return context.Images.Where(i => i.Id == id).Select(i => i.Likes).FirstOrDefault();
        }


    }
}
