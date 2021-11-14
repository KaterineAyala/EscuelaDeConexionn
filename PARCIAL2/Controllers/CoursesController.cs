using EscuelaDeConexionn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EscuelaDeConexionn.Controllers
{
    public class CoursesController : Controller
    {
        CoursesRepository coursesRepository = new CoursesRepository();
       

        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Combobox()
        {
         
            var informacionofCourses = coursesRepository.ListDataCourses();

        
            List<SelectListItem> ComboboxOfCourses = new List<SelectListItem>();


            foreach (var iteracion in informacionofCourses)
            {
                ComboboxOfCourses.Add(new SelectListItem

                {
                    Text = iteracion.Title,
                    Value = Convert.ToString(iteracion.CouserId)
                }
                    );

                ViewBag.listofstudentcombobox = ComboboxOfCourses;
            }

            return View();
        }
    }
}