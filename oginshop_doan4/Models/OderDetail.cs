namespace oginshop_doan4.Models
{
	public class OderDetail : Base
	{
		public int OderId { get; set; } = 0;
		public int ProductId { get; set; } = 0;

		public decimal? Price { get; set; } = 0;

		public int Quantity { get; set; } = 0;

	}
}
