namespace Ejercicio39f.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Convertir a Nro. Romano");
                Console.Write("Ingrese un nro. entero entre 1 y 5:");
                var nroIngresado = int.Parse(Console.ReadLine());
                if (nroIngresado >= 1 && nroIngresado <= 5)
                {
                    string nroRomano = ConvertirANroRomano(nroIngresado);
                    Console.WriteLine($"{nroIngresado} equivale a {nroRomano} en notación romana");
                }
                else
                {
                    Console.WriteLine("Nro ingresado fuera del rango permitido");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Nro ingresado no es válido");
            } 
            Console.ReadLine();
        }

        private static string ConvertirANroRomano(int nroIngresado)
        {
            string romano = "";
            switch(nroIngresado)
            {
                case 1:
                    romano = "I";
                    break;
                case 2:
                    romano = "II";
                break;
                    case 3:
                    romano = "III";
                    break;
                case 4:
                    romano = "IV";
                    break;
                default:
                    romano = "V";
                    break;
                        
            }
            return romano;
        }
    }
}