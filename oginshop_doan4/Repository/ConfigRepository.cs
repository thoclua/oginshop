using oginshop_doan4.Data;
using oginshop_doan4.Models;

namespace oginshop_doan4.Repository
{
	public interface IConfig : IBaseRepository<config>
	{

	}
	public class ConfigRepository : BaseRepository<config>, IConfig
	{
		public ConfigRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
