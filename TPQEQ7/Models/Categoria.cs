﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPQEQ7.Models
{
    public class Categoria
    {
        //inicializacion
        private int _id;
        private string _nombre;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }
    }
}