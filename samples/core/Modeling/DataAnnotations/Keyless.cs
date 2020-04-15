﻿using Microsoft.EntityFrameworkCore;

namespace EFModeling.DataAnnotations.Keyless
{
    class BlogsContext : DbContext
    {
        public DbSet<BlogPostsCount> BlogPostCounts { get; set; }
    }

    #region Keyless
    [Keyless]
    public class BlogPostsCount
    {
        public string BlogName { get; set; }
        public int PostCount { get; set; }
    }
    #endregion
}