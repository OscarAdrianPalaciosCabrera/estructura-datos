using System;

namespace Ejercicio3
{
    // Creamos la clase socio y definimos las variables privadas a utilizar en esta clase
    class socio
    {
        private string nom;
        private double antig;

        //Pedimos los datos por teclado para rellenar las variables por medio de este constructor
        public socio()
        {
            Console.WriteLine("Por favor digite el nombre del socio");
            nom = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------");
                        
            Console.WriteLine("Por favor digite la antiguedad del socio en años, el dato puede ser decimal");
            antig = double.Parse(Console.ReadLine());
            Console.WriteLine("///////////////////////////////////////////////////////////");

        }

        //Agregamos un metodo con tipo de retorno double para retornar la antiguedad de cada socio
        public double returnantig()
        {
            return antig;
        }

        /* Utilizamos este metodo para escribir el mensaje de respuesta que se le mostrara en pantalla al usuario,
         * indicando el nombre y la antiguedad del socio (lo hacemos aqui debido a que las variables nom y antig son privadas para esta clase)*/
        public void mostrar()
        {
            Console.WriteLine("El socio con mayor antiguedad es: {0}, ya que ha estado durante {1} años en la empresa", nom, antig);
        }
    }

    //Creamos la clase club y definimos los objetos privados a utilizar en esta clase
    class club
    {
        private socio soc1, soc2, soc3;

        //Rellenamos los objetos de esta clase mediante un constructor que hace llamado al metodo constructor de la clase socio
        public club()
        {
            soc1 = new socio();
            soc2 = new socio();
            soc3 = new socio();
        }

        /* Agregamos un metodo que por medio de si condicionales haga las respectivas comparaciones de antiguedad entre
         * los 3 socios u objetos de esta clase.*/                 
        public void mayorantig()
        {
            if (soc1.returnantig() > soc2.returnantig() && soc1.returnantig() > soc3.returnantig())
            {
                /*Con un llamado al metodo mostrar para los diferentes socios u objetos que se encuentran en los si condicionales,
                 * imprimimos en pantalla el mensaje que indica cual de los 3 socios es el mas antiguo en la empresa y cuantos años lleva en esta*/
                soc1.mostrar();               
            }
            else if (soc2.returnantig() > soc1.returnantig() && soc2.returnantig() > soc3.returnantig())
            {
                soc2.mostrar();                
            }
            else if (soc3.returnantig() > soc1.returnantig() && soc3.returnantig() > soc2.returnantig())
            {
                soc3.mostrar();
                
            }

            //Agregamos un ReadKey para que el programa se finalice al ajecutar una tecla
            Console.ReadKey();
        }
       
        //utulizamos el metodo Main para ejecutar el programa
        static void Main(string[] args)
        {
            club cl = new club();
            cl.mayorantig();
        }
    }
}
