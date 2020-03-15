namespace ArtForumSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ArtForumSystem.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<(string Name, string ImageUrl)>
            {
                ("Scrapbook", "https://itison.imgix.net/system/201205/7079/1336728292/original.jpg?w=572&h=378"),
                ("Acrylic paintings", "https://www.artyandcraft.com/wp-content/uploads/2019/05/12-24-Colors-15-36ML-Acrylic-Paint-Set-for-Painting-Supllies-Professional-Hand-Painted-DIY-Creation.jpg"),
                ("Decoupage", "https://craftsbyamanda.com/wp-content/uploads/2017/11/Wood-Slice-Ornaments-s2.jpg"),
                ("Tools", "https://previews.123rf.com/images/natashapankina/natashapankina1607/natashapankina160700047/60457536-hand-drawn-doodle-art-and-craft-tools-icons-set-vector-illustration-art-instruments-symbols-collecti.jpg"),
                ("Techniques", "https://1.bp.blogspot.com/-kc84uBfGl5Q/Uvlpz0A9FRI/AAAAAAAAEdE/qbu8seaDSQ8/s1600/5736663211_7738dcb50f_o.jpg"),
                ("Tutorials", "https://lh3.googleusercontent.com/YSl2a-E62rgrdFfa7rbPRT3UkCcTveKF3RHIWygYDoq4AMYY9IIXLcpvzV5EqLx10Ifa=w1440-h620"),
                ("News", "https://i.pinimg.com/originals/1c/83/43/1c83439f454354eaee82bd2dce01d28d.jpg"),
            };

            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category.Name,
                    Description = category.Name,
                    Title = category.Name,
                    ImageUrl = category.ImageUrl,
                });
            }
        }
    }
}
