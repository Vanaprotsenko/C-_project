using System.Collections.Generic;
using System.Linq;

namespace CRMSystem
{
    public class Role
    {
        public string RoleName { get; set; }
        public List<Permission> Permissions { get; set; }

        public Role(string roleName)
        {
            RoleName = roleName;
            Permissions = new List<Permission>();
        }

        public void AddPermission(Permission permission)
        {
            Permissions.Add(permission);
        }

        public bool HasPermission(string permissionName)
        {
            return Permissions.Any(p => p.Name.Equals(permissionName, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
