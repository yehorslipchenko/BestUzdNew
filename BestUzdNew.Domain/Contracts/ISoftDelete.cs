﻿namespace BestUzdNew.Domain.Contracts
{
    public interface ISoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}
