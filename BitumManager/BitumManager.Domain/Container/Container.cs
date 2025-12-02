namespace BitumManager.Domain.Container
{
    public class Container
    {
        public Guid Id { get; set; }

        public required double Capacity { get; set; } //обязательно при создании указывать вместимость в тоннах

        public required int Number {  get; set; }

        public string? Information { get; set; }



        //связь с другими таблицами будем делать в виде Guid ТаблицаId, чтобы не было прямой связи
    }
}

/*
 * резервуар температура дата
 * 
 * 
 */
//нужно создать сводную таблицу с резервуарами, датами и температурами их каждый день