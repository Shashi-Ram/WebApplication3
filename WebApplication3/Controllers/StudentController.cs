using Microsoft.AspNetCore.Mvc;
using CrudEntity.Models;
using CrudEntity.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace CrudEntity.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public StudentController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }


        //.This code binding the Student data in grid
        public IActionResult Index()
        {
            List<StudentViewModel> studentViews = (from std in dbContext.Students
                                                   join sts in dbContext.States on std.StateId equals sts.StateId
                                                   join city in dbContext.Cities on std.CityId equals city.CityId
                                                   join gnd in dbContext.Gender on std.Gender_Id equals gnd.GenderId
                                                   //join tech1 in dbContext.Technology on std.Android equals tech1.TechnologiesId
                                                   //join tech2 in dbContext.Technology on std.Csharp equals tech2.TechnologiesId
                                                   //// join tech3 in dbContext.Technology on std.Python equals tech3.TechnologiesId
                                                   //join tech4 in dbContext.Technology on std.Java equals tech4.TechnologiesId
                                                   select new StudentViewModel()
                                                   {
                                                       Id = std.Id,
                                                       FirstName = std.FirstName,
                                                       MobileNumber = std.MobileNumber,
                                                       State = sts.State,
                                                       City = city.City,
                                                       Gender=gnd.Gender
                                                       //android = tech1.Title,
                                                   //    csharp = tech2.Title,
                                                     //  python = tech3.Title,
                                                       //java = tech4.Title

                                                   }).ToList();
            return View(studentViews);

        }
        public IActionResult Create()
        {

            return View();
        }

        //This code is to create customer and save into database
        [HttpPost]
        public IActionResult Create(Students students)
        
        
        {
            if (ModelState.IsValid)
            {

                dbContext.Add(students);
                dbContext.SaveChanges();
                return RedirectToAction("Index", "Student");
            }
            else
            {
                return View(students);
            }
        }

        public JsonResult GetCity(int id)
        {
            var cities = dbContext.Cities.Where(e => e.State_Id == id).ToList();
            return Json(cities);
        }



        //This code select a single customer in database and show in  create customer form to update customer
        public IActionResult Update(int id)
        {
            var students = dbContext.Students.SingleOrDefault(e => e.Id == id);
            return View(students);
        }

        //This code updates the customer in database and save it
        [HttpPost]
        public IActionResult Update(Students students)
        {
            dbContext.Update(students);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //This code select a single customer in database by id and remove it
        public IActionResult Delete(int id)
        {
            var students = dbContext.Students.SingleOrDefault(e => e.Id == id);
            dbContext.Remove(students);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        public JsonResult GetStates()
        {
            var states = dbContext.States.ToList();
            return Json(states);
        }
        //public JsonResult gtGender()
        //{
        //    var gender = dbContext.Gender.ToList();
        //    return Json(gender);
        //}






    }
}
