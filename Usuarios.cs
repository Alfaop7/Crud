using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class Usuarios
    {
        public int id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NumTelefonico { get; set; }
        public int NumeroCasa { get; set; }
        public string DueñoArrendatario { get; set; }

        public Usuarios() {}
        public Usuarios(int id, string PrimerNombre, string SegundoNombre, string ApellidoPaterno, string ApellidoMaterno, string NumTelefonico, int NumeroCasa, string DueñoArrendatario)
        {
            this.id = id;
            this.PrimerNombre = PrimerNombre;
            this.SegundoNombre = SegundoNombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.NumTelefonico = NumTelefonico;
            this.NumeroCasa = NumeroCasa;
            this.DueñoArrendatario = DueñoArrendatario;
        }




    }
}
