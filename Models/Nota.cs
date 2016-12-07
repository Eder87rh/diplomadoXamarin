using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace PruebaXamarinForms
{
	
		[DataTable("Notas")]
		public class Nota
		{
			[JsonProperty]
			public string Id { get; set; }

			[JsonProperty]
			public string nota { get; set; }

			[Version]
			public string Version { get; set; }
		}

}
