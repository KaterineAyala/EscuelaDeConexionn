using EscuelaDeConexionn.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EscuelaDeConexionn.Models;

namespace EscuelaDeConexionn.Repository
{
    public class EnrollementRepository : IEnrollement
    {
        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();
        public List<Erollements> UnionDeTablas()
        {
            var ConsultaJoin = bd.Erollements.Include(e => e.Students).Include(c => c.Courses).ToList();

            return ConsultaJoin;
        }
    }
}