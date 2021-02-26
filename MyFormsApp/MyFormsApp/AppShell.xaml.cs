using System;
using System.Collections.Generic;
using MyFormsApp.ViewModels;
using MyFormsApp.Views;
using Xamarin.Forms;

namespace MyFormsApp
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
