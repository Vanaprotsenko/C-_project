namespace CRMSystem
{
    public class Permission
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Permission(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
