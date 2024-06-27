using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lugares_CR_logica
{
    public class LogLugares_RC
    {

     public Res_ingresarLugares IngresarLugares(Req_Lugares req)
        {
            Res_ingresarLugares res = new Res_ingresarLugares();
            try
            {
                //Aqui se hace la logica de ingreso
                res.resultado = true;
                res.Estado = true;
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.Estado = false;
            }
            return res;
        }

    }
}
