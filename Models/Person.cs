using System;

namespace SkuleAdmDemoWeb.Models
{
    public class Person
    {
        String fornamn;
        String etternamn;
        String mellomnanm;

        String visningsnamn ( String fornamn, String etternamn, String mellomnamn ) {
            return fornamn + etternamn + mellomnanm;
        }

        DateTime fodselsdato;

        public int alder (){
            TimeSpan a = DateTime.Now.Subtract(fodselsdato);
            DateTime d = new DateTime(a.Ticks);
            return d.Year-1;
        }

        String kjonn;
    }
}