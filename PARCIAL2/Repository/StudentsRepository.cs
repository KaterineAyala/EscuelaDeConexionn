using EscuelaDeConexionn.Models;
using EscuelaDeConexionn.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaDeConexionn.Repository
{
    public class StudentsRepository : IStudents
    {
        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();



        public List<Students> ListOfStudents()
        {
            var listadodestudiantes = bd.Students.ToList();

            return listadodestudiantes;
        }
    }
}