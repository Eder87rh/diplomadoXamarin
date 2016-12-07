using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace PruebaXamarinForms
{
public class AzureClient
{
	private IMobileServiceClient _client;
	private IMobileServiceTable<Nota> _table;

	public AzureClient()
	{
		_client = 
		new 
	MobileServiceClient("http://EderadoXamarinTest.azurewebsites.net");

		_table = _client.GetTable<Nota>();
	}

	public Task<IEnumerable<Nota>> GetNotas()
	{
		return _table.ToEnumerableAsync();
	}

}
}
