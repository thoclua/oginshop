using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.Repository
{
	public interface INew : IBaseRepository<News>
	{

	}
	public class NewRepository : BaseRepository<News>, INew
	{
		public NewRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
