using System;
using System.Threading.Tasks;
using System.Net.Http;
using ModernHttpClient;
using System.Net;
using Xamarin.Forms;

namespace FormsWebService
{
	public class WebServiceHelper
	{
		public WebServiceHelper ()
		{
		}

		public async Task<string> GetResponseFromUrlAsync (string html)
		{
			var url = html;
			string json = "";

			using (HttpClient client = new HttpClient (new NativeMessageHandler())) {
				var response = await client.GetAsync (url);
				json = await response.Content.ReadAsStringAsync ();
			}

			return json;
		}

		public async Task GetResponseFromUrl (string html, Editor editor)
		{
			var url = html;
			string json = "";

			using (HttpClient client = new HttpClient (new NativeMessageHandler())) {
				var response = await client.GetAsync (url);
				json = await response.Content.ReadAsStringAsync ();
			}
				
			editor.Text = json;
		}
	}
}

