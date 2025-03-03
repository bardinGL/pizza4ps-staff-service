using Pizza4Ps.StaffService.Domain.Abstractions;

namespace Pizza4Ps.StaffService.Domain.Entities
{
    public class Shift : EntityAuditBase<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }

        public Shift()
        {
        }

        public Shift(Guid id, string name, string description, int capacity)
        {
            Id = id;
            Name = name;
            Description = description;
            Capacity = capacity;
        }

        public void UpdateShift(string name, string description, int capacity)
        {
            Name = name;
            Description = description;
            Capacity = capacity;
        }
    }
}
