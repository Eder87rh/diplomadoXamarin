using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace PruebaXamarinForms
{
	[DataTable("Contacts")]
	public class Contact
	{
		[JsonProperty]
		public string Id { get; set;}

		[JsonProperty]
		public string Name { get; set; }

		[Version]
		public string Version { get; set;}
	}
}
