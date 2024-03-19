using System.ComponentModel.DataAnnotations.Schema;

namespace oginshop_doan4.Models
{
	public class User : Base
	{
		public string Name { get; set; } = "";
        public string Email { get; set; }
        public int? Age { get; set; } = 0;	
        public string Password { get; set; }
        public string Phone { get; set; } = "";
        public string Address { get; set; } = ""; 
        
        [ForeignKey("RoleId")]
        public virtual Role GetRoleId {  get; set; }

        
	}
}
