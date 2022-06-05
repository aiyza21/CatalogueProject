﻿using System;
using Newtonsoft.Json;

namespace CatalogueProject
{
    internal class Catalog<T> : List<T> where T : Products
    {
        public T Item { get { return _value; } }
        private T _value;

        public Catalog(T value)
        {
            _value = value;
        }
    }
}

