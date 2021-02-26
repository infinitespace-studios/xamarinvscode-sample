using System.ComponentModel;
using Xamarin.Forms;
using MyFormsApp.ViewModels;

namespace MyFormsApp.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}