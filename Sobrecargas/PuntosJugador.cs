using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecargas
{
    internal class PuntosJugador
    {
        private string nombreJugador;
        private int puntos;
        private int nivel;

        public PuntosJugador() : this("Jugador")
        {
        }

        public PuntosJugador(string nombreJugador) : this(nombreJugador, 0)
        {
        }

        public PuntosJugador(string nombreJugador, int puntos) : this(nombreJugador, puntos, 1)
        {
        }

        public PuntosJugador(string nombreJugador, int puntos, int nivel)
        {
            this.nombreJugador = nombreJugador;

            if (puntos < 0)
            {
                this.puntos = 0;
            }
            else
            {
                this.puntos = puntos;
            }

            if (nivel < 1)
            {
                this.nivel = 1;
            }
            else
            {
                this.nivel = nivel;
            }
        }

        public string ObtenerNombre()
        {
            return nombreJugador;
        }

        public int ObtenerPuntos()
        {
            return puntos;
        }

        public int ObtenerNivel()
        {
            return nivel;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombreJugador + ", Puntos: " + this.puntos + ", Nivel: " + nivel);
        }

        public static PuntosJugador operator +(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            return new PuntosJugador(
                jugador1.nombreJugador + " y " + jugador2.nombreJugador,
                jugador1.puntos + jugador2.puntos,
                jugador1.nivel
            );
        }
        public static PuntosJugador operator -(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            return new PuntosJugador(
                jugador1.nombreJugador,
                jugador1.puntos - jugador2.puntos,
                jugador1.nivel
            );
        }

        public static bool operator ==(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            return jugador1.puntos == jugador2.puntos;
        }

        public static bool operator !=(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            return jugador1.puntos != jugador2.puntos;
        }

        public static bool operator >(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            return jugador1.puntos > jugador2.puntos;
        }

        public static bool operator <(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            return jugador1.puntos < jugador2.puntos;
        }

        public void AgregarPuntos(int puntos)
        {
            if (puntos > 0)
            {
                this.puntos += puntos;
            }
        }

        public void AgregarPuntos(int puntos, string motivo)
        {
            if (puntos > 0)
            {
                this.puntos += puntos;
                Console.WriteLine("Motivo: " + motivo);
            }
        }

        public void AgregarPuntos(int puntos, string motivo, bool bonificacion)
        {
            if (puntos > 0)
            {
                if (bonificacion)
                {
                    puntos = puntos + (puntos / 10);
                }

                this.puntos += puntos;

                Console.WriteLine("Motivo: " + motivo);
                Console.WriteLine("Bonificación aplicada: " + bonificacion);
            }
        }

        public void QuitarPuntos(int cantidad)
        {
            if (cantidad > 0)
            {
                puntos -= cantidad;

                if (puntos < 0)
                {
                    puntos = 0;
                }
            }
        }

        public static explicit operator int(PuntosJugador jugador)
        {
            return jugador.puntos;
        }

        public static implicit operator PuntosJugador (int puntos)
        {
            return new PuntosJugador("Jugador", puntos,1 );
        }
    }
}
