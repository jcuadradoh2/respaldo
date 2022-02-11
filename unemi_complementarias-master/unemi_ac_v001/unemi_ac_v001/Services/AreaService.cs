using System;
using System.Collections.Generic;
using System.Text;
using unemi_ac_v001.Model;

namespace unemi_ac_v001.Services
{
    public class AreaService
    {
        public List<Area> ConsultaArea()
        {
            var area = new List<Area>();
            area.Add(new Area() {Name = "Cientifico" });
            return area;
        }
    }
}
