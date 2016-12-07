
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;

namespace PruebaXamarinForms
{
	public class ResClient
	{
		public string Serialize()
		{
			var countries = new[] {
				new Country { Name= "México"},
				new Country {Name= "Costa Rica"}
			};

			string json = JsonConvert.SerializeObject(countries);
			Debug.WriteLine(json);
			return json;
		}

		public void Deserialize()
		{
			var json = Serialize();
			var parsedJson = JsonConvert.DeserializeObject<IEnumerable<Country>>(json);

			foreach (Country item in parsedJson)
			{
				Debug.WriteLine(item.Name);
			}
		}
	}
}
