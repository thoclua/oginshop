using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.DataTransferObject;
using oginshop_doan4.Models;
using oginshop_doan4.Repository;
using System.Reflection;

namespace oginshop_doan4.Controllers
{
	public class SlideController : Controller
	{
		private IBaseRepository<slide> _BannerRepository;
		private ApplicationDbContext _context;
		public SlideController(ApplicationDbContext context, IBaseRepository<slide> BannerRepository)
		{
			_context = context;
			_BannerRepository = BannerRepository;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult DataTableAjaxRespone(DataTableAjaxPostModel postModel)
		{
			//Kiem tra search
			var search = "";
			if (postModel.search != null)
			{
				search = postModel.search.value;
			}

			//Kiem tra sap xep
			var columName = "id";
			var columASC = false;

			if (postModel.order != null)
			{
				columName = postModel.columns[postModel.order[0].column].name;
				if (postModel.order[0].dir.Equals("asc"))
				{
					columASC = true;
				}
				if (postModel.order[0].dir.Equals("desc"))
				{
					columASC = false;
				}
			}
			//Kiem tra phan trang
			var start = postModel.start;
			var length = postModel.length;

			//Goi vao Repository va dien cac tham so phu hop
			var result = _BannerRepository.BuildResponseForDataTableLibrary(
				r => (string.IsNullOrEmpty(search)) || (
					(!string.IsNullOrEmpty(search)) && (
						r.slide_code.ToLower().Contains(search.ToLower())
					)
				),
				columName,
				columASC,
				start,
				postModel.draw,
				length


				);
			return View(result);
		}

		[HttpGet]
		public IActionResult CreateOrUpdateBanner(int Id)
		{

			var model = new slide();
			if (Id > 0)
			{
				var data = _BannerRepository.GetById(Id);
				model = data.DataRows.FirstOrDefault();
			}

			return View(model);
		}

		[HttpPost]
		public IActionResult Save(slide entity)
		{
			var result = _BannerRepository.Save(entity.id, entity);
			return View(result);
		}

		[HttpGet]
		public IActionResult Delete(int Id)
		{
			var result = _BannerRepository.Delete(Id);
			return View(result);
		}

	}
}
