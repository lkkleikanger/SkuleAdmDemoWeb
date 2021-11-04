using System;
using System.Collections.Generic;

namespace SkuleAdmDemoWeb.Models
{
    public class Elev : Person
    {
        String klasse;
        Int kull;
        
        List<Fag> fag = new List<Fag>();
    }
}