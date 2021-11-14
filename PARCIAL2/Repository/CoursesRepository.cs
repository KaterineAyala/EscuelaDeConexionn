using EscuelaDeConexionn.Models;
using EscuelaDeConexionn.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaDeConexionn.Repository



    {
        public class CoursesRepository : ICourses
        {
            EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();


            public void Create(Courses c)
            {
                bd.Courses.Add(c);
                bd.SaveChanges();
            }

            public void Delete(Courses c)
            {
                c = bd.Courses.Find(c.CouserId);
                _ = c;
                bd.Courses.Remove(c);
                bd.SaveChanges();
            }

            public List<Courses> ListDataCourses()
            {
                var ListOfDataCourse = bd.Courses.ToList();

                return ListOfDataCourse;
            }

            public void Update(Courses c)
            {
                throw new NotImplementedException();
            }
        }
    }
