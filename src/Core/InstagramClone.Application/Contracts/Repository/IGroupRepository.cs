﻿using InstagramClone.Application.Contracts.Repository.Common;
using InstagramClone.Domain.Entities;

namespace InstagramClone.Application.Contracts.Repository
{
    public interface IGroupRepository : ISoftRemovableRepository<Group, Guid>;
}