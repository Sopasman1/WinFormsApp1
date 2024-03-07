using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Nombre_persona
    {
        protected string Nombre
        {
            get {return Nombre;} 
            set {Nombre = value;}
       
        }
        protected string Apellidopaterno
        {
            get { return Apellidopaterno; }
            set { Apellidopaterno = value; }
        }
        protected string Apellidomaterno
        {
            get {return Nombre; }
            set { Nombre = value;}
        }
      protected Nombre_persona()
        {
            Nombre = "";
            Apellidopaterno = "";
            Apellidomaterno = "";
        }

    }
}
