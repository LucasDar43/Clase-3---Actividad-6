namespace actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            6)	Supongamos que usted le debe $1000 a la compañía de la tarjeta de crédito y los intereses son de 1.5% del saldo. 
                Usted opta por dejar de usar la tarjeta y pagar mensualmente una cantidad fija. 
                Escriba un programa que permita el ingreso de un monto y luego liste los saldos 
                y el total pagado hasta que se salde la deuda. 
            */
            
            double interesMensual = 0.015;
            double saldo = 1000;
            double pagado = 0;
            int contadorMes = 0;

            Console.WriteLine("DEUDA = $1000");
            Console.WriteLine("Ingrese monto fijo mensual que abonara");
            int pagoMensual = int.Parse(Console.ReadLine());

            while(saldo > 0){
                double intereses = saldo * interesMensual; //15
                saldo += intereses;                        //1000 + 15
                saldo -= pagoMensual;                      //1000 - pago  (ej 1000-100)                             
                pagado += pagoMensual + interesMensual;         // 0 + 100
                contadorMes++;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Mes: " + contadorMes);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo actual: " + saldo.ToString("C2"));
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Total pagado: " + pagado.ToString("C2"));
                Console.ResetColor();
            }

            //SALDO < 0
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Deuda saldada!");
            Console.ResetColor();

        }
    }
}
