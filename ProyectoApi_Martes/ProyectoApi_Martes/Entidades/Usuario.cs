﻿using ProyectoApi_Martes.Models;
using System.Collections.Generic;

namespace ProyectoApi_Martes.Entidades
{
    public class Usuario
    {
        public string Identificacion { get; set; }
        public string Contrasenna { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public long ConsecutivoRol { get; set; }
        public string NombreRol { get; set; }
    }

    public class ConfirmacionUsuario
    {
        public int Codigo { get; set; }
        public string Detalle { get; set; }
        public List<IniciarSesionUsuario_Result> Datos { get; set; }
        public IniciarSesionUsuario_Result Dato { get; set; }
    }

}