﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class JsonHeaders
    {
        public JsonHeaders(string llave, string valor)
        {
            this.Llave = llave;
            this.Valor = valor;
        }
        public string Llave { get; set; }
        public string Valor { get; set; }
    }
    public enum HttpMethod
    {
        GET = 1,
        POST = 2
    }
}
