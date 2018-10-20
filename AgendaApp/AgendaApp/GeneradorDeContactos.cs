﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AgendaApp
{
    class GeneradorDeContactos
    {
        private static List<string> ListaNombres = 
            new List<string>
        {
            "Juan", "Pedro", "Gustavo", "Rodolfo", "Manuel",
            "Cristina", "Regina", "Georgina", "Manuela"
        };

        private static List<string> ListaApellidos =
            new List<string>
        {
            "Gonzáles", "Pastrana", "Pérez", "López", "Trinidad",
            "Berrospi", "Escobar", "Sánchez", "Uwu"
        };

        public static ObservableCollection<Contacto> CrearContactos()
        {
            var random = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for(int i = 0; i < 25; i++)
            {
                var nombres = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var apellidos = ListaApellidos[random.Next(ListaApellidos.Count - 1)];
                var calle = ListaNombres[random.Next(ListaNombres.Count - 1)];

                var contacto = new Contacto
                {
                    nombre = nombres + " " + apellidos,
                    telefono = GenerarTelefono(),
                    direccion = "Avenida " + calle + ", número " + random.Next(1, 1000)
                };
                contactos.Add(contacto);
            }
            return contactos;
        }

        private static string GenerarTelefono()
        {
            var random = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(random.Next(100, 999));
            telefono.Append(")");
            telefono.Append(random.Next(1000000, 9999999));
            return telefono.ToString();
        }

    }
}
