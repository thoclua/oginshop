using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.Repository
{
	public interface ICategory : IBaseRepository<Category>
	{
	}
	public class CategoryRepository : BaseRepository<Category>, ICategory
	{
		public CategoryRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
