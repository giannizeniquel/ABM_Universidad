using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Entitys;

namespace Universidad.Script
{
    static class DatosEstaticos
    {
        static public int Matricula { get; set; }
        static public int clave_profesor { get; set; }
        static public int clave_materia { get; set; }
        static public int clave_aula { get; set; }
        static public int connectAllId { get; set; }
        static public int profesorMateriaId { get; set; }
        static public alumno alumnoEstatico { get; set; }
        static public int estadoCargaMaterias { get; set; }
        static public profesor profesorEstatico { get; set; }
        static public int materiaId { get; set; }

        static public int accesoUsuario { get; set; }
        static public void SumarMatricula()
        {
            Matricula++;
            LeerEscribirArchivo.escribirFicheroMatricula();
        }
        static public void SumarProfesorMateria()
        {
            profesorMateriaId++;
            LeerEscribirArchivo.escribirFicheroProfesorMateria();
        }
        static public void SumarClaveProfesor()
        {
            clave_profesor++;
            LeerEscribirArchivo.escribirFicheroClaveProfesor();
        }
        static public void SumarClaveMateria()
        {
            clave_materia++;
            LeerEscribirArchivo.escribirFicheroClaveMateria();
        }
        static public void SumarClaveAula()
        {
            clave_aula++;
            LeerEscribirArchivo.escribirFicheroClaveAula();
        }
        static public void SumarConnectAllId()
        {
            connectAllId++;
            LeerEscribirArchivo.escribirFicheroConnectAllId();
        }
    }
}
