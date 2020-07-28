using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni.Code
{
    static class Helpers
    {
        public static string StampaPersona(Persona p)
        {
            if (p == null) throw new MyPersonalException();
            return $"Nome: {p.Nome} - Cognome: {p.Cognome}";
        }
    }

    public class MyPersonalException : Exception
    {
        public MyPersonalException()
            : base("Guarda che l'oggetto che mi stai passando è null, vile!")
        {
        }
    }
}
