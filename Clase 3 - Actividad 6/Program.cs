namespace actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
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
                pagado += pagoMensual;                     // 0 + 100
                contadorMes++;

                Console.WriteLine("Mes: " + contadorMes);
                Console.WriteLine("Saldo actual: " + saldo.ToString("C2"));
                Console.WriteLine("Total pagado: " + saldo.ToString("C2"));

            }

            // SALDO < 0 
            Console.WriteLine("¡Deuda saldada!");

        }
    }
}
