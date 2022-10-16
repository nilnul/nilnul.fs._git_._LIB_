using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.svr_.vs.processes
{
	public class Get
	{

		static public string GetListOfProcesses(string account,string token)
		{
			

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri( VisualStudio.GenerateBaseUrl(account));
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", 
					Convert.ToBase64String(
						System.Text.ASCIIEncoding.ASCII.GetBytes(
							string.Format("{0}:{1}", "", token)
						)
					)
				);

				HttpResponseMessage response = client.GetAsync("_apis/process/processes?api-version=2.2").Result;

				if (response.IsSuccessStatusCode)
				{
					return  response.Content.ReadAsStringAsync().Result;
				}
					return  response.Content.ReadAsStringAsync().Result;
				

				
			}
		}
	}
}
