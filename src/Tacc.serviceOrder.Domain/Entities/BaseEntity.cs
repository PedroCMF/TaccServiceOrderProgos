namespace Tacc.serviceOrder.Domain.Entities
{
    public abstract class  BaseEntity //esta classe será herdada por todas as outras entidades do sistema, para evitar repetição de código, como por exemplo o Id
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow; //pega a data atual do servidor, para evitar problemas de fuso horário
        public bool active { get; set; } = true; //para indicar se a entidade está ativa ou não
    }
}
