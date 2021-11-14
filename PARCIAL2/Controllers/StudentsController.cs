using EscuelaDeConexionn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EscuelaDeConexionn.Controllers
{
    public class StudentsController : Controller
    {
        StudentsRepository studentsRepository = new StudentsRepository();


        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Combobox()
        {
            var informacionofStudents = studentsRepository.ListOfStudents();


            List<SelectListItem> ComboboxOfStudents = new List<SelectListItem>();


            foreach (var iteracion in informacionofStudents)
            {
                ComboboxOfStudents.Add(new SelectListItem

                {
                    Text = iteracion.FirstMidName,
                    Value = Convert.ToString(iteracion.StudentId)
                }
                    );

                ViewBag.listofstudentcombobox = ComboboxOfStudents;
            }
            return View();
        }
    
    }

}