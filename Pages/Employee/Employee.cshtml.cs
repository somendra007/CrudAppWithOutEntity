using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrudAppWithOutEntity.Data.EmployeeData;

namespace CrudAppWithOutEntity.Pages.Employee
{
    public class EmployeeModel : PageModel
    {
        private readonly SqlEmployeeRepo _sqlEmployeeRepo;
        public EmployeeModel(SqlEmployeeRepo _employeeRepo) => this._sqlEmployeeRepo = _employeeRepo;

        [BindProperty]
        public EmployeeModel employeeModel { get; set; }
        public void OnGet()
        {

        }
        public ActionResult OnPost()
        {
            
        }
    }
}
