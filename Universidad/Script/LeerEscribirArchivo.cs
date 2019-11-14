using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Universidad.Script
{
    class LeerEscribirArchivo
    {

        static public void CrearFichero()
        {
            StreamWriter fichero;
            if (!File.Exists("Matriculas.txt"))
            {
                fichero = File.CreateText("Matriculas.txt");
                fichero.WriteLine(1);
                fichero.Close();
            }
            if (!File.Exists("ClaveProfesor.txt"))
            {
                fichero = File.CreateText("ClaveProfesor.txt");
                fichero.WriteLine(1);
                fichero.Close();
            }
            if (!File.Exists("ClaveMateria.txt"))
            {
                fichero = File.CreateText("ClaveMateria.txt");
                fichero.WriteLine(1);
                fichero.Close();
            }
            if (!File.Exists("ClaveAula.txt"))
            {
                fichero = File.CreateText("ClaveAula.txt");
                fichero.WriteLine(1);
                fichero.Close();
            }
            if (!File.Exists("ConnectAllId.txt"))
            {
                fichero = File.CreateText("ConnectAllId.txt");
                fichero.WriteLine(1);
                fichero.Close();
            }
            if (!File.Exists("ProfesorMateria.txt"))
            {
                fichero = File.CreateText("ProfesorMateria.txt");
                fichero.WriteLine(1);
                fichero.Close();
            }
        }
        static private void LeerFicheroMatricula()
        {
            StreamReader fichero2;
            fichero2 = File.OpenText("Matriculas.txt");
            string matriculasString = fichero2.ReadLine();
            fichero2.Close();
            DatosEstaticos.Matricula = int.Parse(matriculasString);
        }
        static private void LeerFicheroProfesorMateria()
        {
            StreamReader fichero2;
            fichero2 = File.OpenText("ProfesorMateria.txt");
            string profesorMateriaSt = fichero2.ReadLine();
            fichero2.Close();
            DatosEstaticos.profesorMateriaId = int.Parse(profesorMateriaSt);
        }
        static private void LeerFicheroClaveProfesor()
        {
            StreamReader fichero2;
            fichero2 = File.OpenText("ClaveProfesor.txt");
            string ClaveProfesorString = fichero2.ReadLine();
            fichero2.Close();
            DatosEstaticos.clave_profesor = int.Parse(ClaveProfesorString);
        }
        static private void LeerFicheroClaveMateria()
        {
            StreamReader fichero2;
            fichero2 = File.OpenText("ClaveMateria.txt");
            string ClaveMateriaString = fichero2.ReadLine();
            fichero2.Close();
            DatosEstaticos.clave_materia = int.Parse(ClaveMateriaString);
        }
        static private void LeerFicheroClaveAula()
        {
            StreamReader fichero2;
            fichero2 = File.OpenText("ClaveAula.txt");
            string ClaveAulaString = fichero2.ReadLine();
            fichero2.Close();
            DatosEstaticos.clave_aula = int.Parse(ClaveAulaString);
        }
        static private void LeerFicheroConnectAllId()
        {
            StreamReader fichero2;
            fichero2 = File.OpenText("ConnectAllId.txt");
            string ConnectAllIdS = fichero2.ReadLine();
            fichero2.Close();
            DatosEstaticos.connectAllId = int.Parse(ConnectAllIdS);
        }
        static public void LeeroCrearFichero()
        {
            CrearFichero();
            LeerFicheroProfesorMateria();
            LeerFicheroMatricula();
            LeerFicheroClaveProfesor();
            LeerFicheroClaveMateria();
            LeerFicheroClaveAula();
            LeerFicheroConnectAllId();
        }

        static public void escribirFicheroMatricula()
        {
            StreamWriter sw = new StreamWriter("Matriculas.txt");
            sw.Write(DatosEstaticos.Matricula);
            sw.Close();
        }

        static public void escribirFicheroProfesorMateria()
        {
            StreamWriter sw = new StreamWriter("ProfesorMateria.txt");
            sw.Write(DatosEstaticos.profesorMateriaId);
            sw.Close();
        }
        static public void escribirFicheroClaveProfesor()
        {
            StreamWriter sw = new StreamWriter("ClaveProfesor.txt");
            sw.Write(DatosEstaticos.clave_profesor);
            sw.Close();
        }
        static public void escribirFicheroClaveMateria()
        {
            StreamWriter sw = new StreamWriter("ClaveMateria.txt");
            sw.Write(DatosEstaticos.clave_materia);
            sw.Close();
        }
        static public void escribirFicheroClaveAula()
        {
            StreamWriter sw = new StreamWriter("ClaveAula.txt");
            sw.Write(DatosEstaticos.clave_aula);
            sw.Close();
        }
        static public void escribirFicheroConnectAllId()
        {
            StreamWriter sw = new StreamWriter("ConnectAllId.txt");
            sw.Write(DatosEstaticos.connectAllId);
            sw.Close();
        }

    }
}