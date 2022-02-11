using System;
using System.Collections.Generic;
using System.Text;
using unemi_ac_v001.Model;

namespace unemi_ac_v001.Services
{
    public class AlumnoService
    {

        public List<AlumnoCls> llenar()
        {
            var alum = new List<AlumnoCls>();
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            alum.Add(new AlumnoCls() { Name = "Cientifico", Email = "algo@gmail.com", FNacimiento = DateTime.Parse("04-05-1997"), Foto = null, Lastname = "Cuadrado", Telefono = "0967088667" });
            return alum;
        }

      
    }
}
