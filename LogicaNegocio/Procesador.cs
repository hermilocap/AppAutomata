using LogicaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Procesador
    {
        Cadenas cadenas = new Cadenas();
        public string Operaciones(int index, string cadena, string potencia)
        {
            StringBuilder stringBuilder = new StringBuilder();
            switch (index)
            {
                case 0:
                    cadenas.x = string.Concat(Enumerable.Repeat(cadena, 2));
                    cadenas.Longitud = string.Concat(Enumerable.Repeat(cadena, 2)).Length.ToString();
                    stringBuilder.Append("xx: " + cadenas.x + " longitud: " + cadenas.Longitud);
                    break;
                case 1:
                    cadenas.x = string.Concat(Enumerable.Repeat(cadena, 3));
                    cadenas.Longitud = string.Concat(Enumerable.Repeat(cadena, 3)).Length.ToString();
                    stringBuilder.Append("xxx: " + cadenas.x + " longitud: " + cadenas.Longitud);
                    break;
                case 2:
                    cadenas.x = string.Concat(Enumerable.Repeat(cadena, 3));
                    cadenas.Longitud = string.Concat(Enumerable.Repeat(cadena, 3)).Length.ToString();
                    stringBuilder.Append("x3: " + cadenas.x + " longitud: " + cadenas.Longitud);
                    break;
                case 3:
                    cadenas.x = "λ";
                    cadenas.Longitud = "0";
                    stringBuilder.Append("x0: " + cadenas.x + " longitud: " + cadenas.Longitud);
                    break;
                case 4:
                    cadenas.x = string.Concat(Enumerable.Repeat(cadena, 8));
                    cadenas.Longitud = string.Concat(Enumerable.Repeat(cadena, 8)).Length.ToString();
                    stringBuilder.Append("x8: " + cadenas.x + " longitud: " + cadenas.Longitud);
                    break;
                case 5:
                    foreach (char item in cadena)
                    {
                        cadenas.CadenaInvertida = item + cadenas.CadenaInvertida;
                    }
                    //Console.WriteLine("x-4:" + invertida + invertida + invertida + invertida + " Longitud: " + invertida.Length * 3);
                    cadenas.x = string.Concat(Enumerable.Repeat(cadena, 4));
                    cadenas.Longitud = string.Concat(Enumerable.Repeat(cadena, 4)).Length.ToString();
                    stringBuilder.Append("x-4: " + cadenas.x + " longitud: " + cadenas.Longitud);
                    break;
            }
            return stringBuilder.ToString();
        }
        public string OperacionesEjercicio2(int index, string x, string y, string z, string potencia)
        {
            StringBuilder stringBuilder = new StringBuilder();
            switch (index)
            {
                case 0:
                    cadenas.x = string.Concat(Enumerable.Repeat(x, 1));
                    cadenas.y = string.Concat(Enumerable.Repeat(y, 1));
                    cadenas.ResultadoCadena = cadenas.x + cadenas.y;
                    cadenas.Longitud = Convert.ToString(string.Concat(Enumerable.Repeat(x, 1)).Length + string.Concat(Enumerable.Repeat(y, 1)).Length);
                    cadenas.Prefijo = ObetenerPrefijo((x + y), y);
                    cadenas.Sufijo = ObetenerSufijo((x + y), x);
                    stringBuilder.Append("xy: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;
                case 1:
                    cadenas.x = string.Concat(Enumerable.Repeat(x, 1));
                    cadenas.z = string.Concat(Enumerable.Repeat(z, 1));
                    cadenas.ResultadoCadena = cadenas.x + cadenas.z;
                    cadenas.Longitud = Convert.ToString(string.Concat(Enumerable.Repeat(x, 1)).Length + string.Concat(Enumerable.Repeat(z, 1)).Length);
                    cadenas.Prefijo = ObetenerPrefijo((x + z), z);
                    cadenas.Sufijo = ObetenerSufijo((x + z), x);
                    stringBuilder.Append("xz: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;

                case 2:
                    cadenas.y = string.Concat(Enumerable.Repeat(y, 1));
                    cadenas.z = string.Concat(Enumerable.Repeat(z, 1));
                    cadenas.ResultadoCadena = cadenas.y + cadenas.z;
                    cadenas.Longitud = Convert.ToString(string.Concat(Enumerable.Repeat(y, 1)).Length + string.Concat(Enumerable.Repeat(z, 1)).Length);
                    cadenas.Prefijo = ObetenerPrefijo((x + y + z), z);
                    cadenas.Sufijo = ObetenerSufijo((y + z), y);
                    stringBuilder.Append("xz: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;
                case 3:
                    cadenas.x = string.Concat(Enumerable.Repeat(x, 1));
                    cadenas.y = string.Concat(Enumerable.Repeat(y, 1));
                    cadenas.z = string.Concat(Enumerable.Repeat(z, 1));
                    cadenas.ResultadoCadena = cadenas.x + cadenas.y + cadenas.z;
                    cadenas.Longitud = Convert.ToString(string.Concat(Enumerable.Repeat(x, 1)).Length + string.Concat(Enumerable.Repeat(y, 1)).Length + string.Concat(Enumerable.Repeat(z, 1)).Length);
                    cadenas.Prefijo = ObetenerPrefijo((y + z), z);
                    cadenas.Sufijo = ObetenerSufijo((x + y + z), x);
                    stringBuilder.Append("xz: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;
                case 4:
                    cadenas.x = string.Concat(Enumerable.Repeat(x, 2));
                    cadenas.y = string.Concat(Enumerable.Repeat(y, 2));
                    //cadenas.z = string.Concat(Enumerable.Repeat(z, 1));
                    cadenas.ResultadoCadena = cadenas.x + cadenas.y;
                    cadenas.Longitud = Convert.ToString(string.Concat(Enumerable.Repeat(x, 2)).Length + string.Concat(Enumerable.Repeat(y, 2)).Length + string.Concat(Enumerable.Repeat(z, 1)).Length);
                    cadenas.Prefijo = ObetenerPrefijo((x + x + y + y), y);
                    cadenas.Sufijo = ObetenerSufijo((x + x + y + y), x);
                    stringBuilder.Append("x2y2: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;
                case 5:
                    cadenas.x = string.Concat(Enumerable.Repeat(x, 1));
                    cadenas.y = string.Concat(Enumerable.Repeat(y, 1));
                    //cadenas.z = string.Concat(Enumerable.Repeat(z, 1));
                    cadenas.ResultadoCadena = string.Concat(Enumerable.Repeat(cadenas.x + cadenas.y, 2));
                    cadenas.Longitud = Convert.ToString(string.Concat(Enumerable.Repeat(cadenas.x + cadenas.y, 2)).Length);
                    cadenas.Prefijo = ObetenerPrefijo((x + y + x + y), y);
                    cadenas.Sufijo = ObetenerSufijo((x + y + x + y), x);
                    stringBuilder.Append("(xy)2: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;
                case 6:
                    cadenas.z = string.Concat(Enumerable.Repeat(z, 1));
                    cadenas.x = string.Concat(Enumerable.Repeat(x, 2));
                    //cadenas.z = string.Concat(Enumerable.Repeat(z, 1));
                    foreach (char item in cadenas.z + cadenas.x)
                    {
                        cadenas.CadenaInvertida = item + cadenas.CadenaInvertida;
                    }
                    cadenas.ResultadoCadena = string.Concat(Enumerable.Repeat(cadenas.CadenaInvertida, 3));
                    cadenas.Longitud = Convert.ToString(string.Concat(Enumerable.Repeat(cadenas.CadenaInvertida, 3)).Length);
                    cadenas.Prefijo = cadenas.ResultadoCadena.Substring(0, string.Concat(Enumerable.Repeat(cadenas.CadenaInvertida, 2)).Length);//ObetenerPrefijo(cadenas.ResultadoCadena, cadenas.CadenaInvertida_zxx);
                    cadenas.Sufijo = cadenas.ResultadoCadena.Substring(string.Concat(Enumerable.Repeat(cadenas.CadenaInvertida, 1)).Length, string.Concat(Enumerable.Repeat(cadenas.CadenaInvertida, 2)).Length);
                    stringBuilder.Append("(zxx)-3: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;
                case 7:
                    cadenas.z = string.Concat(Enumerable.Repeat(z, 3));
                    cadenas.x = string.Concat(Enumerable.Repeat(x, 1));
                    cadenas.y = string.Concat(Enumerable.Repeat(y, 1));
                    foreach (char item in cadenas.x)
                    {
                        cadenas.CadenaInvertida = item + cadenas.CadenaInvertida;
                    }
                    foreach (char item in cadenas.y)
                    {
                        cadenas.CadenaInvertida_zxx = item + cadenas.CadenaInvertida_zxx;
                    }
                    cadenas.ResultadoCadena = cadenas.z + cadenas.CadenaInvertida + string.Concat(Enumerable.Repeat(cadenas.CadenaInvertida_zxx, 2));
                    //cadenas.CadenaInvertida = "";
                    string cadena_InvertidaFinal = "";
                    foreach (var item in cadenas.ResultadoCadena)
                    {
                        cadena_InvertidaFinal = item + cadena_InvertidaFinal;
                    }
                    string cadena_z_invertida = "";
                    foreach (char item in cadenas.z)
                    {
                        cadena_z_invertida = item + cadena_z_invertida;
                    }
                    cadenas.ResultadoCadena = string.Concat(Enumerable.Repeat(cadena_InvertidaFinal, 3));
                    cadenas.Longitud = Convert.ToString(cadenas.ResultadoCadena.Length);
                    cadenas.Prefijo = cadenas.ResultadoCadena.Substring(0, string.Concat(Enumerable.Repeat(cadenas.y, 1)).Length);//ObetenerPrefijo(cadenas.ResultadoCadena, cadenas.CadenaInvertida_zxx);
                    cadenas.Sufijo = cadenas.ResultadoCadena.Substring(string.Concat(Enumerable.Repeat(cadenas.y, 2)).Length);
                    stringBuilder.Append("(z3x-1y-2)-3: " + cadenas.ResultadoCadena + " longitud: " + cadenas.Longitud + " " + "Sufijo: " + cadenas.Prefijo + " " + "Prefijo: " + cadenas.Sufijo);
                    break;
            }
            return stringBuilder.ToString();
        }
        public string OperacionesEjercicio3(int index)
        {
            Lenguajes lenguajes = new Lenguajes();
            lenguajes.L1 = new string[] { "anita", "lava", "la", "tina" };
            lenguajes.L2 = new string[] { "hola", "como", "estas", "amigo" };
            lenguajes.L3 = new string[] { "a", "arca", "amor", "amigo", "animo", "teoria", "grupo", "salon", "cara" };
            string[] resultado;
            string[] resultadoUnion;
            List<string> resultado1 = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            switch (index)
            {
                case 0:
                    //L1∪L2 L3
                    resultado = lenguajes.L1.Union(lenguajes.L2).ToArray();
                    for (int x = 0; x < resultado.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L3.Length; y++)
                        {
                            stringBuilder.Append(resultado[x].ToString() + lenguajes.L3[y].ToString());
                        }
                    }
                    break;
                case 1:
                    //(L1 L2 )∪L3
                    for (int x = 0; x < lenguajes.L1.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L2.Length; y++)
                        {
                            resultado1.Add(lenguajes.L1[x].ToString() + lenguajes.L2[y].ToString());
                            resultadoUnion = resultado1.Union(lenguajes.L3).ToArray();
                            foreach (var item in resultadoUnion)
                            {
                                if (item != null || item == "")
                                {
                                    stringBuilder.Append(item + ",");
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    //L1^2
                    for (int x = 0; x < lenguajes.L1.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L1.Length; y++)
                        {
                            stringBuilder.Append(lenguajes.L1[x].ToString() + lenguajes.L1[y].ToString() + ",");
                        }
                    }
                    break;
                case 3:
                    //L2+
                    foreach (var item in lenguajes.L2)
                    {
                        stringBuilder.Append($"{item}" + ",");
                    }
                    for (int x = 0; x < lenguajes.L2.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L2.Length; y++)
                        {
                            stringBuilder.Append(lenguajes.L2[x].ToString() + lenguajes.L2[y].ToString() + ",");
                        }
                    }
                    break;
                case 4:
                    //L2 *
                    stringBuilder.Append("{λ}");
                    foreach (var item in lenguajes.L2)
                    {
                        stringBuilder.Append($"{item}" + ",");
                    }
                    for (int x = 0; x < lenguajes.L2.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L2.Length; y++)
                        {
                            stringBuilder.Append(lenguajes.L2[x].ToString() + lenguajes.L2[y].ToString() + ",");
                        }
                    }
                    break;
                case 5:
                    //L2-1
                    for (int y = 0; y < lenguajes.L2.Length; y++)
                    {
                        string reversed = Reverse(lenguajes.L2[y]);
                        stringBuilder.Append(reversed + ",");
                    }
                    break;
            }
            return stringBuilder.ToString();
        }
        public string OperacionesEjercicio3_Parte2(int index)
        {
            Lenguajes lenguajes = new Lenguajes();
            lenguajes.L1 = new string[] { "001AF", "10FFAA", "109012", "667800" };
            lenguajes.L2 = new string[] { "00", "10", "12", "45", "66", "77" };
            lenguajes.L3 = new string[] { "1", "0", "3", "5", "6", "F", "A", "B", "C" };
            string[] resultado;
            string[] resultadoUnion;
            List<string> resultado1 = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            switch (index)
            {
                case 0:
                    //(L1UL2)L3 ya existe
                    resultado = lenguajes.L1.Union(lenguajes.L2).ToArray();
                    for (int x = 0; x < resultado.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L3.Length; y++)
                        {
                            stringBuilder.Append(resultado[x].ToString() + lenguajes.L3[y].ToString());
                        }
                    }
                    break;
                case 1:
                    //(L1L2)∪L3 ya existe
                    for (int x = 0; x < lenguajes.L1.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L2.Length; y++)
                        {
                            resultado1.Add(lenguajes.L1[x].ToString() + lenguajes.L2[y].ToString());
                            resultadoUnion = resultado1.Union(lenguajes.L3).ToArray();
                            foreach (var item in resultadoUnion)
                            {
                                if (item != null || item == "")
                                {
                                    stringBuilder.Append(item + ",");
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    //L1^2
                    for (int x = 0; x < lenguajes.L1.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L1.Length; y++)
                        {
                            stringBuilder.Append(lenguajes.L1[x].ToString() + lenguajes.L1[y].ToString() + ",");
                        }
                    }
                    break;
                case 3:
                    //L2+
                    foreach (var item in lenguajes.L2)
                    {
                        stringBuilder.Append($"{item}" + ",");
                    }
                    for (int x = 0; x < lenguajes.L2.Length; x++)
                    {
                        for (int y = 0; y < lenguajes.L2.Length; y++)
                        {
                            stringBuilder.Append(lenguajes.L2[x].ToString() + lenguajes.L2[y].ToString() + ",");
                        }
                    }
                    break;
                case 4:
                    //L2-1∪ (L1L3) ya existe
                    List<string> listUnion = new List<string>();
                    for (int y = 0; y < lenguajes.L2.Length; y++)
                    {
                        string reversed = Reverse(lenguajes.L2[y]);
                        listUnion.Add(reversed);
                    }
                    resultado = lenguajes.L1.Union(lenguajes.L3).ToArray();
                    listUnion.Union(resultado).ToArray();
                    foreach (var item in listUnion)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
                case 5:
                    //L2-1
                    for (int y = 0; y < lenguajes.L2.Length; y++)
                    {
                        string reversed = Reverse(lenguajes.L2[y]);
                        stringBuilder.Append(reversed + ",");
                    }
                    break;
            }
            return stringBuilder.ToString();
        }
        public string OperacionesEjercicio4(int index)
        {
            Cadenas cadenas = new Cadenas();
            cadenas.a = "a";
            cadenas.b = "b";
            cadenas.c = "c";
            cadenas.d = "d";
            cadenas.z = "z";
            StringBuilder stringBuilder = new StringBuilder();
            List<string> cadenaregular = new List<string>();
            List<string> cadenaregular2 = new List<string>();
            List<string> cadenaregular3 = new List<string>();
            List<string> cadenaregular4 = new List<string>();
            List<string> cadenaregularUnion = new List<string>();
            string[] resultado;
            List<string> AhastaN = new List<string>();
            List<string> bhastaN = new List<string>();
            List<string> abchastaN = new List<string>();
            switch (index)
            {
                case 0:
                    //(ab) | (cz) | d *
                    string[] regular = new string[] { cadenas.a + cadenas.b, cadenas.c + cadenas.z };
                    for (int i = 1; i <= 20; i++)
                    {
                        cadenaregular.Add(string.Concat(Enumerable.Repeat(cadenas.d, i)));
                    }
                    resultado = regular.Union(cadenaregular.ToArray()).ToArray();
                    foreach (var item in resultado)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
                case 1:
                    // string[] regular = new string[] { cadenas.a + cadenas.b, cadenas.c + cadenas.z };
                    //(ab) | (cz) | d *
                    for (int i = 1; i <= 5; i++)
                    {
                        AhastaN.Add(string.Concat(Enumerable.Repeat(cadenas.a, i)));
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        bhastaN.Add(string.Concat(Enumerable.Repeat(cadenas.b, i)));
                    }
                    for (int x = 0; x < AhastaN.ToArray().Length; x++)
                    {
                        for (int y = 0; y < bhastaN.ToArray().Length; y++)
                        {
                            cadenaregular.Add(AhastaN[x].ToString() + bhastaN[y].ToString() + cadenas.c);
                            //cadenaregular.Add(AhastaN[x].ToString() + bhastaN[y].ToString() + cadenas.c + ",");
                            //stringBuilder.Append(AhastaN[x].ToString() + bhastaN[y].ToString()+cadenas.c+",");
                        }
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        bhastaN.Add(string.Concat(Enumerable.Repeat(cadenas.b, i)));
                        //stringBuilder.Append(string.Concat(Enumerable.Repeat(cadenas.b, i)));
                    }
                    for (int i = 0; i < bhastaN.ToArray().Length; i++)
                    {
                        cadenaregularUnion.Add(bhastaN[i].ToString() + cadenas.d + cadenas.z);
                        //stringBuilder.Append(bhastaN[i].ToString()  + cadenas.d +cadenas.z+ ",");
                    }
                    resultado = cadenaregular.Union(cadenaregularUnion.ToArray()).ToArray();
                    foreach (var item in resultado)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
                case 2:
                    //(abc)*z
                    regular = new string[] { "λ", cadenas.z };
                    for (int i = 1; i <= 20; i++)
                    {
                        abchastaN.Add(string.Concat(Enumerable.Repeat(cadenas.a + cadenas.b + cadenas.c, i)) + cadenas.z);
                        //stringBuilder.Append(string.Concat(Enumerable.Repeat(cadenas.a + cadenas.b + cadenas.c, i))+cadenas.z+",");
                    }
                    resultado = regular.Union(abchastaN).ToArray();
                    foreach (var item in resultado)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
                case 3:
                    string[] asolo = new string[] { cadenas.a };
                    string[] bsolo = new string[] { cadenas.b };
                    string[] unionab;
                    //string[] unionabhastan;
                    unionab = asolo.Union(bsolo).ToArray();
                    for (int i = 0; i < unionab.Length; i++)
                    {
                        for (int x = 0; x < unionab.Length; x++)
                        {
                            cadenaregular.Add(unionab[i] + unionab[x]);
                        }
                    }
                    for (int i = 0; i < unionab.Length; i++)
                    {
                        for (int x = 0; x < cadenaregular.ToArray().Length; x++)
                        {
                            cadenaregular2.Add(unionab[i] + cadenaregular[x]);
                        }
                    }
                    for (int i = 0; i < unionab.Length; i++)
                    {
                        for (int x = 0; x < cadenaregular2.ToArray().Length; x++)
                        {
                            cadenaregular3.Add(unionab[i] + cadenaregular2[x]);
                        }
                    }
                    for (int i = 0; i < unionab.Length; i++)
                    {
                        for (int x = 0; x < cadenaregular3.ToArray().Length; x++)
                        {
                            cadenaregular4.Add(unionab[i] + cadenaregular3[x]);
                        }
                    }
                    //unionabhastan = unionab
                    //    .Union(cadenaregular
                    //    .Union(cadenaregular2.ToArray()
                    //    .Union(cadenaregular3.ToArray()
                    //    .Union(cadenaregular4.ToArray()))).ToArray()).ToArray();
                    for (int i = 1; i <= 4; i++)
                    {
                        AhastaN.Add(string.Concat(Enumerable.Repeat(cadenas.a, i)));
                    }
                    resultado = AhastaN.Union(cadenaregular4.ToArray()).ToArray();
                    foreach (var item in resultado)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
                case 4:
                    List<string> absolo = new List<string>();
                    List<string> bcsolo = new List<string>();
                    for (int i = 1; i <= 10; i++)
                    {
                        absolo.Add(string.Concat(Enumerable.Repeat(cadenas.a + cadenas.b, i)));
                    }
                    for (int x = 1; x <= 10; x++)
                    {
                        bcsolo.Add(string.Concat(Enumerable.Repeat(cadenas.b + cadenas.c, x)));
                    }
                    for (int x = 0; x < absolo.ToArray().Length; x++)
                    {
                        for (int y = 0; y < bcsolo.ToArray().Length; y++)
                        {
                            cadenaregular.Add(absolo[x].ToString() + bcsolo[y].ToString());
                        }
                    }
                    foreach (var item in cadenaregular)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
            }
            return stringBuilder.ToString();
        }
        public string OperacionesEjercicio5(int index)
        {
            Cadenas cadenas = new Cadenas();
            cadenas.a = "a";
            cadenas.b = "b";
            cadenas.c = "c";
            cadenas.d = "d";
            cadenas.z = "z";
            cadenas.u = "u";
            cadenas.e = "e";
            cadenas.m = "m";
            List<string> abdhastaN = new List<string>();
            List<string> zhastaN = new List<string>();
            List<string> unionabczhastaN = new List<string>();
            string[] abhastaN = new string[] {cadenas.a+cadenas.b};
            List<string> cadenaRegular = new List<string>();
            List<string> cadenaRegular2 = new List<string>();
            List<string> cadenaRegular3 = new List<string>();
            List<string> cadenaRegular4 = new List<string>();
            List<string> cadenaRegular5 = new List<string>();
            List<string> cadenaRegular6 = new List<string>();
            List<string> cadenaRegular7 = new List<string>();
            string[] resultado1;
            StringBuilder stringBuilder = new StringBuilder();
            switch (index)
            {
                case 0:
                    //abc+z*
                    for (int i = 1; i <= 5; i++)
                    {
                        abdhastaN.Add(string.Concat(Enumerable.Repeat(cadenas.c, i)));
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        zhastaN.Add(string.Concat(Enumerable.Repeat(cadenas.z, i)));
                    }
                    for (int i = 0; i < abhastaN.ToArray().Length; i++)
                    {
                        for (int x = 0; x < abdhastaN.ToArray().Length; x++)
                        {
                            cadenaRegular.Add(abhastaN[i].ToString() + abdhastaN[x].ToString());
                        }
                    }
                    //resultado
                    for (int x = 0; x < cadenaRegular.ToArray().Length; x++)
                    {
                        for (int y = 0; y < zhastaN.ToArray().Length; y++)
                        {
                            cadenaRegular2.Add(cadenaRegular[x].ToString() + zhastaN[y].ToString());
                        }
                    }
                    string[] abc_sigma = new string[] { "abcλ"};
                    resultado1 = abc_sigma.Union(cadenaRegular2.ToArray()).ToArray();

                    foreach (var item in resultado1)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
                case 1:
                    //((λ|1)e)*
                    //=(λ|1)=λU1={λ,1}
                    //(λ|1)e={λ,1}{e}={1e}
                    string[] solouno = new string[] {"1"};
                    string[] econcatenacion = new string[] {cadenas.e };
                    string[] econcatenacion2sigma = new string[] { "λ" };

                    List<string> unionList = new List<string>();
                    for (int y = 0; y < solouno.Length; y++)
                    {
                        for (int x = 0; x < econcatenacion.Length; x++)
                        {
                           cadenaRegular.Add(solouno[y] + econcatenacion[x]);
                          // stringBuilder.Append(solouno[y] + econcatenacion[x]);
                        }
                    }
                    for (int x = 0; x < econcatenacion2sigma.Length; x++)
                    {
                        for (int y = 0; y < econcatenacion.Length; y++)
                        {
                            //stringBuilder.AppendLine();
                            cadenaRegular2.Add(econcatenacion2sigma[x] + econcatenacion[y]);
                           // stringBuilder.Append(solouno[x] + econcatenacion2sigma[y]);
                        }
                    }
                    
                    resultado1 = cadenaRegular.Union(cadenaRegular2.ToArray()).ToArray();
                    for (int x = 0; x < resultado1.Length; x++)
                    {
                        for (int y = 0; y < resultado1.Length; y++)
                        {
                            cadenaRegular3.Add(resultado1[x] + resultado1[y]);
                        }
                    }

                    for (int x = 0; x < resultado1.Length; x++)
                    {
                        for (int y = 0; y < cadenaRegular3.ToArray().Length; y++)
                        {
                            cadenaRegular4.Add(resultado1[x] + cadenaRegular3[y]);
                        }
                    }

                    for (int x = 0; x < resultado1.Length; x++)
                    {
                        for (int y = 0; y < cadenaRegular4.ToArray().Length; y++)
                        {
                            cadenaRegular5.Add(resultado1[x] + cadenaRegular4[y]);
                        }
                    }
                    for (int x = 0; x < resultado1.Length; x++)
                    {
                        for (int y = 0; y < cadenaRegular5.ToArray().Length; y++)
                        {
                            cadenaRegular6.Add(resultado1[x] + cadenaRegular5[y]);
                        }
                    }
                    foreach (var item in cadenaRegular6)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    //foreach (var item in unionList)
                    //{
                    //    //stringBuilder.Append(item+",");
                    //    for (int i = 1; i <= 5; i++)
                    //    {
                    //        stringBuilder.Append(string.Concat(Enumerable.Repeat(item, i))+",");
                    //    }
                    //}
                    break;
                case 2:
                    //pendiente de revisar bien
                    //(1|2)*z((e|u)(m|c))+
                    //(12z)(12z)=112
                    string[] concatenacion= new string[] { "1","2" };
                    string[] uno = new string[] { "1" };
                    string[] dos = new string[] { "2" };
                    string[] sigma1 = new string[] { "λ" };
                   // string[] sigma = new string[] { "λ" };
                    string[] e = new string[] { cadenas.e};
                    string[] u = new string[] { cadenas.u };
                    string[] m = new string[] { cadenas.m };
                    string[] c = new string[] { cadenas.c };
                    string[] z = new string[] { cadenas.z };
                    List<string> resultado3=new List<string>();
                    List<string> resultado4 = new List<string>();
                    string[] resultado2;
                    resultado1 = new string[] { cadenas.e,cadenas.u }; //e.Union(u.ToArray()).ToArray();
                    resultado2 = new string[] { cadenas.c,cadenas.m }; //m.Union(c.ToArray()).ToArray();
                    concatenacion = uno.Union(dos).ToArray();

                    for (int x = 0; x < concatenacion.Length; x++)
                    {
                        for (int y = 0; y < concatenacion.Length; y++)
                        {
                           // stringBuilder.Append(concatenacion[x] + concatenacion[y]);
                            resultado3.Add(concatenacion[x] + concatenacion[y]);
                        }
                    }
                    for (int x = 0; x < concatenacion.Length; x++)
                    {
                        for (int y = 0; y < resultado3.ToArray().Length; y++)
                        {
                            resultado4.Add(concatenacion[x] + resultado3[y]);
                        }
                    }
                    //vdfgd
                    string[] unodosz = new string[] { "λz", "12z"};
                    
                    for (int x = 0; x < resultado1.Length; x++)
                    {
                        for (int y = 0; y < resultado2.Length; y++)
                        {
                           
                            cadenaRegular.Add(resultado1[x]+resultado2[y]);
                        }
                    }
                    //string[] resultado;
                    for (int x = 0; x < cadenaRegular.ToArray().Length; x++)
                    {
                        for (int i = 0; i < cadenaRegular.ToArray().Length; i++)
                        {
                            cadenaRegular2.Add(cadenaRegular[x] + cadenaRegular[i]);
                        }
                    }
                    for (int i = 0; i < cadenaRegular.ToArray().Length; i++)
                    {
                        for (int y = 0; y < cadenaRegular2.ToArray().Length; y++)
                        {
                            cadenaRegular3.Add(cadenaRegular[i] + cadenaRegular2[y]);
                        }
                    }
                    for (int i = 0; i < unodosz.Length; i++)
                    {
                        for (int y = 0; y < cadenaRegular3.ToArray().Length; y++)
                        {
                            cadenaRegular4.Add(unodosz[i] + cadenaRegular3[y]);
                        }
                    }
                    foreach (var item in cadenaRegular4)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;

                case 3:
                    //
                    //(a + bc+z*) +
                    string[] sigma = new string[] { "λ" };
                    string[] zresultado;
                    string[] b = new string[] { "b" };

                    for (int i = 1; i<=3; i++)
                    {
                        cadenaRegular.Add(string.Concat(Enumerable.Repeat(cadenas.a,i)));
                    }
                    for (int i = 1; i <=3; i++)
                    {
                        cadenaRegular2.Add(string.Concat(Enumerable.Repeat(cadenas.c, i)));
                    }
                    for (int i = 1; i <=3; i++)
                    {
                        cadenaRegular3.Add(string.Concat(Enumerable.Repeat(cadenas.z, i)));
                    }
                    zresultado = sigma.Union(cadenaRegular3.ToArray()).ToArray();
                    //concatencion
                    for (int i = 0; i < cadenaRegular.ToArray().Length; i++)
                    {
                        for (int x = 0; x < b.ToArray().Length; x++)
                        {
                            cadenaRegular4.Add(cadenaRegular[i] + b[x]);
                        }
                    }
                    for (int i = 0; i < cadenaRegular4.ToArray().Length; i++)
                    {
                        for (int x = 0; x < cadenaRegular2.ToArray().Length; x++)
                        {
                            cadenaRegular5.Add(cadenaRegular4[i] + cadenaRegular2[x]);
                        }
                    }
                    for (int i = 0; i < cadenaRegular5.ToArray().Length; i++)
                    {
                        for (int x = 0; x < zresultado.ToArray().Length; x++)
                        {
                            cadenaRegular6.Add(cadenaRegular5[i] + zresultado[x]);
                        }
                    }
                    foreach (var item in cadenaRegular6)
                    {
                        stringBuilder.Append(item + ",");
                    }
                    break;
                case 4:
                    //((@ + $%+&+ ) + (#+@")")/
                    //fsfsf
                    //sfdsf
                    //fsdfs
                    //fsfsdf*
                    /*dasdad
                     * dasda
                     * dasdas
                     * dasdas
                     * dsada
                     * 
                     */
                    /* 
                    "/"DSDS

                     */

                    for (int i = 0; i <=2 ; i++)
                    {
                     cadenaRegular.Add(string.Concat(Enumerable.Repeat("@",i)));
                    }
                    for (int i = 0; i <=2; i++)
                    {
                        cadenaRegular2.Add(string.Concat(Enumerable.Repeat("$%", i)));
                    }
                    for (int i = 0; i <= 2; i++)
                    {
                        cadenaRegular3.Add(string.Concat(Enumerable.Repeat("&", i)));
                    }
                    for (int i = 0; i <cadenaRegular.ToArray().Length ; i++)
                    {
                        for (int x = 0; x < cadenaRegular2.ToArray().Length; x++)
                        {
                            cadenaRegular4.Add(cadenaRegular[i] + cadenaRegular2[x]);
                        }
                    }
                    for (int i = 0; i < cadenaRegular3.ToArray().Length; i++)
                    {
                        for (int x = 0; x < cadenaRegular4.ToArray().Length; x++)
                        {
                            cadenaRegular5.Add(cadenaRegular[i] + cadenaRegular4[x]);
                        }
                    }
                    //
                    // regular = new string[] { "λ", cadenas.z };
                    List<string> abchastaN = new List<string>();
                    for (int i = 1; i <= 2; i++)
                    {
                        abchastaN.Add(string.Concat(Enumerable.Repeat("#", i)) + "@\"\"");
                    }
                    //concatenando todos
                    for (int i = 0; i < cadenaRegular5.ToArray().Length; i++)
                    {
                        for (int x = 0; x < abchastaN.ToArray().Length; x++)
                        {
                            cadenaRegular6.Add(cadenaRegular5[i] + abchastaN[x]);
                        }
                    }
                    //primera concatenacion el mismo
                    for (int i = 0; i < cadenaRegular6.ToArray().Length; i++)
                    {
                        for (int x = 0; x < cadenaRegular6.ToArray().Length; x++)
                        {
                            cadenaRegular7.Add(cadenaRegular6[i] + cadenaRegular6[x]);
                        }
                    }
                    foreach (var item in cadenaRegular7)
                    {
                        stringBuilder.Append(item+",");
                    }
                    break;
            }
            return stringBuilder.ToString();
        }
        public List<string> CargarEjercicios()
        {
            List<string> listaOperaciones = new List<string>();
            listaOperaciones.Add("Ejericio Presentacion 2");
            listaOperaciones.Add("Ejericio Presentacion 2 Parte 2");
            listaOperaciones.Add("Ejercicio Presentacion 3");
            listaOperaciones.Add("Ejercicio Presentacion 3 Parte2");
            listaOperaciones.Add("Ejercicio Presentacion 4");
            listaOperaciones.Add("Ejercicio Presentacion 5");

            return listaOperaciones;
        }
        public List<string> CargarOperaciones(int index)
        {
            List<string> listaOperaciones = new List<string>();
            switch (index)
            {
                case 0:
                    listaOperaciones.Add("xx");
                    listaOperaciones.Add("xxx");
                    listaOperaciones.Add("x3");
                    listaOperaciones.Add("x0");
                    listaOperaciones.Add("x8");
                    listaOperaciones.Add("x-4");
                    break;
                case 1:
                    listaOperaciones.Add("xy");
                    listaOperaciones.Add("xz");
                    listaOperaciones.Add("yz");
                    listaOperaciones.Add("xyz");
                    listaOperaciones.Add("x2y2");
                    listaOperaciones.Add("(xy)2");
                    listaOperaciones.Add("(zxx)-3");
                    listaOperaciones.Add("(z3x-1y-2)-3");
                    break;
                case 2:
                    listaOperaciones.Add("(L1∪L2) L3");//14
                    listaOperaciones.Add("(L1 L2 )∪L3");
                    listaOperaciones.Add("L1^2");
                    listaOperaciones.Add("L2^+");
                    listaOperaciones.Add("L2^*");
                    listaOperaciones.Add("L2^-1");
                    break;
                case 3:
                    listaOperaciones.Add("(L1∪L2)L3");//ya existe
                    listaOperaciones.Add("L1L2)∪L3");//ya existe
                    listaOperaciones.Add("L1^2");//ya existe
                    listaOperaciones.Add("L2^+");//ya existe
                    listaOperaciones.Add("L2-1∪(L1L3)");
                    listaOperaciones.Add("L2-1"); //ya existe
                    break;
                case 4:
                    listaOperaciones.Add("(ab)|(cz)|d*");
                    listaOperaciones.Add("a+b+c | b+d z ");
                    listaOperaciones.Add("(abc)*z ");
                    listaOperaciones.Add("(a|b)*+|a ");
                    listaOperaciones.Add("(ab)+ (bc)+");
                    break;
                case 5:
                    listaOperaciones.Add("a)abc+z*");
                    listaOperaciones.Add("((λ | 1)e) *");
                    listaOperaciones.Add("(1|2)*z((e|u)(m|c))+");
                    listaOperaciones.Add("(a + bc+z*) +");
                    listaOperaciones.Add("((@ + $%+&+ ) + (#+@)) *");
                    break;
            }
            return listaOperaciones;
        }
        string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string ObetenerSufijo(string cadena, string sufijo)
        {
            if (cadena.StartsWith(sufijo))
            {
                cadena = cadena.Remove(0, sufijo.Length);
            }
            return cadena;
        }
        public string ObetenerPrefijo(string cadena, string prefijo)
        {
            if (cadena.EndsWith(prefijo))
            {
                cadena = cadena.Remove(cadena.Length - prefijo.Length, prefijo.Length);
            }
            return cadena;
        }
    }
}