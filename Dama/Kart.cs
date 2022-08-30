using System;
using System.Collections.Generic;
using System.Text;

namespace Dama
{
    public class Kart
    {
        public int Id { get; set; }
        public string SetNo { get; set; }
        public string SetType { get; set; }
        public string KartName => SetType+ SetNo ;
    }
}
