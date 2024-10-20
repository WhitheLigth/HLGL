using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLGL.Temperatura
{
    public class StringManipulator
    {
        // Método para invertir una cadena
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Método para eliminar espacios en blanco
        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
