internal class Program
{
    private static void Main(string[] args)
    {
        ComprobarLiquidos liquidos = new ComprobarLiquidos();
        liquidos.comprobar();
        
        ComprobarAsiento asiento = new ComprobarAsiento();
        asiento.comprobar();

        ComprobarEspejos espejos = new ComprobarEspejos();
        espejos.comprobar();

        Arrancar arrancar = new Arrancar();
        arrancar.encenderContacto();

        System.Console.WriteLine("--------------------------------------------------");
        System.Console.WriteLine("Mantenimiento preventivo correcto");
        System.Console.WriteLine("--------------------------------------------------");
    }
}