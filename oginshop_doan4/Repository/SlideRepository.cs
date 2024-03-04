using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.Repository
{
	public interface Islide : IBaseRepository<slide>
	{

	}
	public class SlideRepository : BaseRepository<slide>, Islide
	{
		public SlideRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
