using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PruebaXamarinForms
{
	public partial class ContactsPage : ContentPage
	{
		private AzureClient _client; 
		public ObservableCollection<Nota> Items { get; set;}

		Command RefreshCommand { get; set;}

		public ContactsPage()
		{
			Items = new ObservableCollection<Nota>();
			RefreshCommand = new Command(()=>Load());
			_client = new AzureClient() ;

			InitializeComponent(); 
		}

		public async void Load()
		{
			IsBusy = true;
			Items.Clear();

			var result = await _client.GetNotas();

			foreach (var item in result)
			{
				Items.Add(item);
			}
			IsBusy = false;
		}
	}
}
