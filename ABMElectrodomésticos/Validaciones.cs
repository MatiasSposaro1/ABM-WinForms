using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMElectrodomésticos
{
    public class Validaciones
    {
        // Valida si el código es válido: debe tener 4 dígitos numéricos (ej: "0001")
        public static bool CodigoValido(string codigo)
        {
          
            return !string.IsNullOrWhiteSpace(codigo) && codigo.Length == 4 && codigo.All(char.IsDigit);
        }

        // Valida si un texto solo contiene letras y espacios (para campos como marca, tipo, modelo)
        public static bool TextoValido(string texto)
        {
           
            return !string.IsNullOrWhiteSpace(texto) && texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        // Valida si un string representa un número entero válido mayor o igual a 0 (para stock)
        public static bool NumeroEnteroValido(string texto)
        {
           
            return int.TryParse(texto, out int valor) && valor >= 0;
        }

        // Valida si un string representa un número decimal válido mayor o igual a 0 (para precio)
        public static bool PrecioValido(string texto)
        {
            
            return decimal.TryParse(texto, out decimal precio) && precio >= 0;
        }

        // Valida si un string representa una fecha válida (para fecha de ingreso)
        public static bool FechaValida(string texto)
        {
            
            return DateTime.TryParse(texto, out _);
        }

        // Valida si el campo está vacío o contiene solo espacios
        public static bool CampoVacio(string texto)
        {
            
            return string.IsNullOrWhiteSpace(texto);
        }
    }
}
