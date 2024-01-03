﻿using InstagramClone.Application.Contracts.Repository.Common;
using InstagramClone.Domain.Entities.Chat;

namespace InstagramClone.Application.Contracts.Repository.Chat
{
    public interface IMessageRepository : ISoftRemovableRepository<Message, Guid>;
}