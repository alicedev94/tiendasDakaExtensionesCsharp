﻿namespace TEC_AL_0002.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string[] Roles { get; set; }
    }
}