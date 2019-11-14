using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Script
{
    class CargaComboBox
    {
        public string[] diviciones = { "A", "B" };
        public string[] provinciasArgentinasArray = { "Buenos Aires","Catamarca","Chaco","Chubut","Córdoba","Corrientes","Entre Ríos",
                                           "Formosa","Jujuy","La Pampa","La Rioja","Mendoza","Misiones","Neuquén","Río Negro","Salta","San Juan",
                                           "San Luis","Santa Cruz","Santa Fe","Santiago del Estero","Tierra del Fuego","Tucumán", };

        public string[] localidadesChacoArgentinaArray = { "Avia Terai","Campo Largo","Charata","Colonia Benítez","Colonia Elisa","Colonias Unidas","Comandancia Frías",
                "Concepción del Bermejo","Coronel Du Graty","Corzuela","El Paranacito","El Sauzalito","Fortín Belgrano","Gancedo","General José de San Martín",
                "General Pinedo","Gran Resistencia‎","Hermoso Campo","Horquilla","Isla Soto","Juan José Castelli","La Clotilde","La Escondida","La Leonesa","La Tigra" ,"La Verde",
                "Las Breñas","Las Garcitas","Las Palmas","Los Frentones","Machagai","Makallé","Margarita Belén","Miraflores","Misión Nueva Pompeya",
                "Napenay","Pampa del Indio",
                "Pampa del Infierno","Presidencia de la Plaza","Presidencia Roca", "Presidencia Roque Sáenz Peña‎","Puerto Bermejo","Puerto Las Palmas","Puerto Tirol","Quitilipi",
                "San Bernardo" ,"Paraje San Fernando","Santa Sylvina","Taco Pozo","Tres Isletas","Villa Ángela","Villa Berthet","Villa Río Bermejito"};

        public int[] EdadArray = {17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,
                        60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99};

        public string[] generoComboArray = { "Masculino", "Femenino", "Otro" };
        public string[] paisesArray = {"Argentina" };

        static public List<string> usuarioAlumno = new List<string>();
        static public List<string> passAlumno = new List<string>();
        static public void cargarPassUsuario()
        {
            usuarioAlumno.Add("admin");
            usuarioAlumno.Add("profesor");
            usuarioAlumno.Add("36115256");
            passAlumno.Add("admin");
            passAlumno.Add("profesor");
            passAlumno.Add("36115256");
        }
    }
}
