using Pizza4Ps.StaffService.Domain.Abstractions;

namespace Pizza4Ps.StaffService.Domain.Entities
{
    public class Role : EntityAuditBase<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Role()
        {
        }

        public Role(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public void UpdateRole(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
