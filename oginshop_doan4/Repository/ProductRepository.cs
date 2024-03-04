using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.Repository
{
	public interface IProduct : IBaseRepository<Product>
	{
	}
	public class ProductRepository : BaseRepository<Product>, IProduct
	{
		public ProductRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
