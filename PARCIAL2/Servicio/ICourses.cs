using EscuelaDeConexionn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaDeConexionn.Servicio
{
    interface ICourses
    {

        void Create(Courses c);
        void Delete(Courses c);
        void Update(Courses c);

        List<Courses> ListDataCourses();
    }
}
