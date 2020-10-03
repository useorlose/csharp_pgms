using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProjectMVC.Controllers
{
    public class EmpDataController : Controller
    {
      
        public ViewResult AllEmployees()
        {
            var context = new MyEntities();
            var model = context.EmpTable.ToList();
            return View(model);
        }

        public ViewResult Find(string id)
        {
            int empId = int.Parse(id);
            var context = new MyEntities();
            var model = context.EmpTable.FirstOrDefault((e) => e.EmpID == empId);
            return View(model);

        }
        [HttpPost]
        public ActionResult Find(EmpTable emp)
        {
            var context = new MyEntities();
            var model = context.EmpTable.FirstOrDefault((e) => e.EmpID == emp.EmpID);
            model.EmpName = emp.EmpName;
            model.EmpAddress = emp.EmpAddress;
            model.EmpSalary = emp.EmpSalary;
            context.SaveChanges();
            return RedirectToAction("AllEmployees");
        }

        public ViewResult Find(string id)
        {
            int empId = int.Parse(id);
            var context = new MyEntities();
            var model = context.EmpTable.FirstOrDefault((e) => e.EmpID == empId);
            return View(model);

        }

        [HttpPost]
        public ActionResult NewEmployee(EmpTable emp)
        {
            var context = new MyEntities();
            context.EmpTable.Add(emp);
            context.SaveChanges();
            return RedirectToAction("AllEmployees");
        }

        public ActionResult Delete(string id)
        {
            
            int empId = int.Parse(id);
            var context = new MyEntities();
            var model = context.EmpTables.FirstOrDefault((e) => e.EmpID == empId);
            context.EmpTables.Remove(model);
            context.SaveChanges();
            return RedirectToAction("AllEmployees");
        }
    }
}




