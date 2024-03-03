using System;

namespace Todo.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>// Classe abstrata para garantir que todas as entidades tenham um id
    {
        public Guid Id { get; private set; }
        
        public Entity()
        {
            Id = Guid.NewGuid();// Gera um novo id para a entidade
        }

        public bool Equals(Entity? other)
        {
            return Id == other?.Id;// Compara se o id da entidade é igual ao id da outra entidade
        }

    }
}