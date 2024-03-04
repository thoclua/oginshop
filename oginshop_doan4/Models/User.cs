namespace oginshop_doan4.Models
{
	public class User : Base
	{
		public string Name { get; set; } = "";
		public int? Age { get; set; } = 0;
		public string Address { get; set; } = "";
		public string Phone { get; set; } = "";
	}
}
