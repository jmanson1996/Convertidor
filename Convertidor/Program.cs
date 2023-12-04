namespace Convertidor
{
    class Program
    {
        static void Main()
        {
            int opcion;
            char repetir;
            var metodo = new Program();
            do
            {
                Console.WriteLine("Ingrese la opcion que desee");
                Console.WriteLine(" 1. convertidor de m/s \n" +
                    "2.Convertido de km/h " +
                    "3.Salir");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        
                        metodo.Conversar1();
                        break;
                        case 2:
                        metodo.Conversor2();
;                        break;
                    case 3:
                        Console.ReadLine ();
                        break;
                    default:
                        Console.WriteLine("Opciones incorrecta ");
                        break;
                }
                Console.WriteLine("Desea repetir otra conversion digite S o N");
                repetir =  Convert.ToChar(Console.ReadLine());  
            } while ( repetir=='s' || repetir == 'S'  );

    {

            }



        }
       public static double entrada;

        public  void Conversar1()
        {

            Console.WriteLine(" ingrese   una velocidad en m/s");
            entrada = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{entrada} m/s ={ entrada * 3600/1000} k/h");
        } 
        public void Conversor2()
        {
            Console.WriteLine("Ingrese una velocidad  en km/h");
            entrada = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine($" {entrada} k/m = {entrada*1000/3600} m/s");
        }




    }




}
