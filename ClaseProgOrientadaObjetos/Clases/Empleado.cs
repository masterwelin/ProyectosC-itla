﻿namespace ClaseProgOrientadaObjetos.Clases
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nss { get; set; }

        public abstract decimal Calcular();

    }
}
