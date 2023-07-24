using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCdb.Models;

namespace MVCdb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppdbContext db;
            public EmployeeController(AppdbContext db)
        {
            this.db=db;
        }

        // GET: EmployeeController
        [Route("data/index")]
        public ActionResult Index()
        {
            return View(db.Employees.ToList<Employee>());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
          Employee obj=  db.Employees.FirstOrDefault(emp=>emp.Id == id); 
           
            return View(obj);
           
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
       
        public ActionResult Create(Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Employees.Add(emp);
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
           Employee obj= db.Employees.Find(id);
            return View(obj);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    db.Employees.Update(emp);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee obj = db.Employees.Find(id);
            return View(obj);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        
        public ActionResult Delete(int id, Employee emp)
        {
            try
            {
               
                
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }
           
        }
    }
}
