namespace ArtForumSystem.Web.ViewModels.Posts
{
    using ArtForumSystem.Data.Models;
    using ArtForumSystem.Services.Mapping;

    public class CategoryDropDownViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
