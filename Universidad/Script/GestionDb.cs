using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Entitys;
namespace Universidad.Script
{
    class GestionDb
    {

        static public void CargarAulumnoDb(string nombre, string apellido, string dni, string telefono, string pais, string provincia, string localidad,
            int edad, string genero, DateTime nacimiento, string direccion)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                alumno newA = new alumno(DatosEstaticos.Matricula, nombre, apellido, dni, telefono, pais, provincia, localidad, edad, genero, nacimiento, direccion);
                DatosEstaticos.SumarMatricula();
                db.alumno.Add(newA);
                db.SaveChanges();
            }
        }
        static public bool EsAlumnoNuevo(alumno a)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                var lstConnectAll = db.connectAll;
                foreach (var ca in lstConnectAll)
                {
                    if (ca.alumnoId_1 == a.alumnoId)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static public void InscribirAlumnoMateria(int alumnoId, int cursoMateriaId, int aulaId)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                connectAll newConnectAll = new connectAll(DatosEstaticos.connectAllId, alumnoId, cursoMateriaId, aulaId);
                db.connectAll.Add(newConnectAll);
                DatosEstaticos.SumarConnectAllId();
                db.SaveChanges();
            }
        }
        static public void CargarProfesorDb(string nombre, string apellido, string dni, string telefono, int edad,
            string direccion, string pais, string provincia, string localidad, DateTime nacimiento, string genero)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                profesor newProf = new profesor(DatosEstaticos.clave_profesor, nombre, apellido, dni, telefono, edad,
                    direccion, pais, provincia, localidad, nacimiento, genero);

                DatosEstaticos.SumarClaveProfesor();
                db.profesor.Add(newProf);
                db.SaveChanges();
            }
        }
        static public void AsignarMateriasProfesor(int profesorId, int materiaId, string turno)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                ProfesorMateria pm = new ProfesorMateria(DatosEstaticos.profesorMateriaId, profesorId, materiaId, turno);

                DatosEstaticos.SumarProfesorMateria();
                db.ProfesorMateria.Add(pm);
                db.SaveChanges();
            }
        }
        static public void RemoveAlumno(int id)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                alumno a = db.alumno.Find(id);
                var lstconnectAll = db.connectAll;
                foreach (var ca in lstconnectAll)
                {
                    if (ca.alumnoId_1 == id)
                    {
                        db.connectAll.Remove(ca);
                    }
                }
                db.alumno.Remove(a);
                db.SaveChanges();
            }
        }
    }
}

