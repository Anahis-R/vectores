using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS

{
    class numerosficheros
    {
        static String[] Unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "sietes", "ocho", "nueve", "diez",
        "once","doce","trece","catorce","quince","dieciseis","diecisiete","dieciocho","diecinueve" };
        static String[] Decenas = { "cero","diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noeventa" };
        static String[] Centenas = { "cien", "doscientos", "trescientos", "cuatrocintos", "cuatro", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };


        public static void testUnidades()
        {
            foreach (string cad in Unidades)
            {
                Console.WriteLine(cad);
            }
        }
        /// <summary>
        /// Devielve el equivalente en letras y Unidades
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static String getUnidades(int num)
        {
            String aux = "";

            if (num >= 0 && num < 20)
                aux = Unidades[num];

            return aux;
        }
        public static String getDecenas(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
                aux = Unidades[num];
            if (num >= 20 && num < 100)
                aux = Decenas[num / 10];
            return aux;
        }
    }
}
