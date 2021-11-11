using System;

namespace SkuleAdmDemoWeb.Models
{
    public class Person
    {
        Kjonn kjonn;
        String namn;
        DateTime bursdag;
        public enum Kjonn{
            Kvinne=0,
            Mann=1
        }
        public String GetNamn()
        {return namn;}
        public DateTime GetBursdag()
        {return bursdag;}
        public Kjonn GetKjonn()
        {return kjonn;}
    }
}