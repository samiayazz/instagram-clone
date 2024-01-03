﻿using InstagramClone.Domain.Entities.Content;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories.Content
{
    public class CommentRepository : SoftRemovableRepositoryBase<Comment, Guid>
    {
        public CommentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}