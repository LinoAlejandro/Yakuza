using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Services;
using Yakuza.Models;

namespace Yakuza.WebService
{
    /// <summary>
    /// Summary description for Examen
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Examen : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string compararCadenas(string nombre1, string nombre2)
        {
            YakuzaEntities db = new YakuzaEntities();
            List<TipoDeTarjeta> tarjetas = db.TipoDeTarjeta.ToList<TipoDeTarjeta>();
            foreach (TipoDeTarjeta tarjeta in tarjetas)
            {
                if (tarjeta.descripcionTipo.Equals(nombre1))
                {
                    return "si existe el parametro 1";
                }
                else
                {
                    if (tarjeta.descripcionTipo.Equals(nombre2))
                    {
                        return "si existe el parametro 2";
                    }
                }
            }

            return "no existe ningún parametro";
        }

        [WebMethod]
        public List<string> showTipoDeTarjetas()
        {
            YakuzaEntities db = new YakuzaEntities();
            List<TipoDeTarjeta> tarjetas = db.TipoDeTarjeta.ToList();
            List<string> tarjetasString = new List<string>();
            foreach (TipoDeTarjeta tipo in tarjetas)
            {
                tarjetasString.Add(tipo.descripcionTipo + tipo.idTipo);
            }
            return tarjetasString;
        }
    }
}
