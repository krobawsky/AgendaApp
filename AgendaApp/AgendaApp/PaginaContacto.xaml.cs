﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaContacto : ContentPage
	{
		public PaginaContacto (Contacto contacto)
		{
			InitializeComponent ();

            BackgroundColor = Color.FromHex("#eceff1");
            BindingContext = contacto;

        }
	}
}