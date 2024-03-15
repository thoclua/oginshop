using Microsoft.AspNetCore.Mvc;
using oginshop_doan4.Data;
using oginshop_doan4.DataTransferObject;
using oginshop_doan4.Models;
using oginshop_doan4.Repository;

namespace oginshop_doan4.Controllers
{
    public class RoleController : Controller
    {
        private IBaseRepository<Role> _roleRepository;
        private ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context, IBaseRepository<Role> roleRepository)
        {
            _context = context;
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
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
            var result = _roleRepository.BuildResponseForDataTableLibrary(
                r => (string.IsNullOrEmpty(search)) || (
                    (!string.IsNullOrEmpty(search)) && (
                        r.Name.ToLower().Contains(search.ToLower())
                    )
                ),
                columName,
                columASC,
                start,
                postModel.draw,
                length
                //"CategoryRole"

                );




            return Ok(result);
        }

        [HttpGet]
        public IActionResult CreateOrUpdate(int Id)
        {
            //ViewBag.CategoryId = new SelectList(_context.GetRoles.ToList(), "id", "Title");
            var model = new Role();
            if (Id > 0)
            {
                var data = _roleRepository.GetById(Id);
                model = data.DataRows.FirstOrDefault();
            }

            return PartialView(model);
        }

        [HttpPost]
        public IActionResult Save(Role entity)
        {
            var result = _roleRepository.Save(entity.id, entity);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var result = _roleRepository.Delete(Id);
            return Ok(result);
        }
    }
}
