﻿namespace PorSalud.Domain.Entities
{
    public interface IEntity
    {
        long Id { get; set; }

        bool IsArchived { get; set; }
    }
}
