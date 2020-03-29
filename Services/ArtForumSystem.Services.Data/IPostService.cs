﻿namespace ArtForumSystem.Services.Data
{
    using System.Threading.Tasks;

    public interface IPostService
    {
        Task<int> CreateAsync(string title, string content, int categoryId, string userId);
    }
}
