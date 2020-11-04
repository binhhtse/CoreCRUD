using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace jQueryDatatables.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDataTabelData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();

                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnAscDesc = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int resultTotal = 0;

                var departmentData = (from tblObj in _departmentRepository.GetAll() select tblObj);
                

                //Sorting
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnAscDesc)))
                {
                    departmentData = _departmentRepository.GetAll().OrderBy(sortColumn + " " + sortColumnAscDesc);
                }

                //Search
                if (!string.IsNullOrEmpty(searchValue))
                {
                    departmentData = departmentData.Where(t => t.DepartmentName.Contains(searchValue));
                }

                resultTotal = departmentData.Count();
                var result = departmentData.Skip(skip).Take(pageSize).ToList();
                return Json(new { draw = draw, recordsFiltered = resultTotal, recordsTotal = resultTotal, data = result });

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IActionResult AddEditDepartment(int id)
        {
            Department department = new Department();
            if (id > 0) department = _departmentRepository.Find(b => b.ID == id);
            return PartialView("_DepartmentForm", department);
        }

        [HttpPost]
        public async Task<string> AddEditDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                if (department.ID > 0)
                {
                    //Department.LastModifiedDate = DateTime.Now;
                    //Department.LastUpdateUser = "Admin";
                    _departmentRepository.Update(department, department.ID);
                    return "Department Info Updated Successfully";
                }
                else
                {
                    //department.CreatedDate = DateTime.Now;
                    //department.CreationUser = "Admin";
                    await _departmentRepository.AddAsyn(department);
                    var result = await _departmentRepository.SaveAsync();

                    var successMessage = "Department Info Created Successfully. Name: " + department.DepartmentName;
                    TempData["successAlert"] = successMessage;
                    return "Department Info Created Successfully";
                }
            }
            return "Failed";
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Department department = _departmentRepository.Get(id);
            _departmentRepository.Delete(department);
            return RedirectToAction("Index");
        }


    }
}
