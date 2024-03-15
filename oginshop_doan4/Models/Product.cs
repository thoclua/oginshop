using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oginshop_doan4.Models
{
	public class Product : Base
	{
		public string Name { get; set; } = "";

		public string Description { get; set; } = "";

		public string Inmage { get; set; } = "";

		public decimal? Price { get; set; } = 0;

		public Boolean? Sale { get; set; }

		[Range(1,5)]
		public int? Rating { get; set; } = 0;

		public int? Quantity { get; set; } = 0;

		public int? CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public Category? CategoryProduct { get; set; }
	}
}
