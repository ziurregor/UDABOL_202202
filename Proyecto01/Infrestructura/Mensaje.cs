﻿using System;
using System.Collections.Generic;
using Modelo;

namespace Infrestructura
{
    public class Mensaje:IMensaje
    {
        public Mensaje()
        {
        }

        public bool Conectar(string cadenaDeConexion, Type tipo)
        {
            throw new NotImplementedException();
        }

        public bool Conectar()
        {
            throw new NotImplementedException();
        }

        public bool EliminarRegistro(int Id)
        {
            throw new NotImplementedException();
        }

        public bool GrabaRegistro(Mensajes mensajes)
        {
            throw new NotImplementedException();
        }

        public List<Mensajes> LeerTabla()
        {
            throw new NotImplementedException();
        }

        public bool RecuperaRegistro(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

