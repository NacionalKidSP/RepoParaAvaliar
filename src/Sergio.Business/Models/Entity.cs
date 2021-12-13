using System;


namespace Sergio.Business.Models
{
    //todas as outras classes sao entidades entao essa classe e a mae, ela nao pode
    //ser instanciada, deve ser herdada
    public abstract class Entity
    {
        //construtor é protegido e so a classe que tiver herdando pode acessar ele
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        //todas vao ter um id
        public Guid Id { get; set; }
    }
}
