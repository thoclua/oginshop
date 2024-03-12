namespace oginshop_doan4.Models
{
	public class Order : Base
	{
		
		public int userid { get; set; } =0 ;
		public string Phone { get; set; } = "";
		public string Address { get; set; } = "";
		public decimal? Totalmoney { get; set; } = 0;

		public string status { get; set; } = "";

	}
}
