namespace Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PuntosJugador jugador1 = new PuntosJugador();
            PuntosJugador jugador2 = new PuntosJugador("Matias");
            PuntosJugador jugador3 = new PuntosJugador("Juan", 100);
            PuntosJugador jugador4 = new PuntosJugador("Pedro", 200, 5);
            PuntosJugador jugador5 = new PuntosJugador("Lucas", -50, 0);

            jugador1.MostrarInformacion();
            jugador2.MostrarInformacion();
            jugador3.MostrarInformacion();
            jugador4.MostrarInformacion();
            jugador5.MostrarInformacion();

            PuntosJugador jugador6 = jugador3 + jugador4;

            jugador6.MostrarInformacion();

            PuntosJugador jugador7 = jugador4 - jugador3;

            jugador7.MostrarInformacion();

            if (jugador3 == jugador4)
            {
                Console.WriteLine("Los jugadores tienen los mismos puntos.");
            }
            else
            {
                Console.WriteLine("Los jugadores tienen puntos diferentes.");
            }


            if (jugador4 > jugador3)
            {
                Console.WriteLine("Pedro tiene más puntos que Juan.");
            }
            else
            {
                Console.WriteLine("Pedro no tiene más puntos que Juan.");
            }


            if (jugador3 < jugador4)
            {
                Console.WriteLine("Juan tiene menos puntos que Pedro.");
            }
            else
            {
                Console.WriteLine("Juan no tiene menos puntos que Pedro.");
            }

            jugador3.AgregarPuntos(50);
            jugador3.MostrarInformacion();

            jugador3.AgregarPuntos(20,"Misión completada");
            jugador3.MostrarInformacion();

            jugador3.QuitarPuntos(50);
            jugador3.MostrarInformacion();

            jugador3.AgregarPuntos(30, "Victoria", true);
            jugador3.MostrarInformacion();


            int puntosJugador = (int)jugador3;

            PuntosJugador jugador8 = 500;
        }
    }
}
