using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABORATORIO1_AMY_NOELIA_LARA_MENJIVAR.Entidades;

namespace LABORATORIO1_AMY_NOELIA_LARA_MENJIVAR.Negocio
{
    public class ClsPersona
    {
        public String Calcular(Persona per)
        {
            double pro = per.Peso / Math.Pow(per.Altura, 2);

            if (pro > 25) 
            {
                return ("Tiene sobre peso");
            }
            else 
            {
            return ("Peso Ideal");
            }
        }
        public String MayorEdad(Persona per)
        {
            if (per.Edad >= 18)
            {
                return ("Mayor de edad");
            }
            else
            {
                return ("Menor de edad");
            }
        }

    }
}
