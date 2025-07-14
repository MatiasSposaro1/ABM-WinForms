using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMElectrodomésticos
{
    public  class Electrodomestico
    {
        public int Id { get; set; } // autoincremental
        public string Codigo { get; set; } // ej: "0001"
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Caracteristicas { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaIngreso { get; set; }

        // Constructor completo
        public Electrodomestico(int id, string codigo, string tipo, string marca, string modelo, string caracteristicas, int stock, decimal precio, DateTime fechaIngreso)
        {
            Id = id;
            Codigo = codigo;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Caracteristicas = caracteristicas;
            Stock = stock;
            Precio = precio;
            FechaIngreso = fechaIngreso;
        }

        // Constructor sin ID (para cuando insertamos uno nuevo)
        public Electrodomestico(string codigo, string tipo, string marca, string modelo, string caracteristicas, int stock, decimal precio, DateTime fechaIngreso)
        {
            Codigo = codigo;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Caracteristicas = caracteristicas;
            Stock = stock;
            Precio = precio;
            FechaIngreso = fechaIngreso;
        }
    }
}
