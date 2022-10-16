using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.prj
{
	public class Get
	{

		public static async Task<string> GetResponseAsync(string account, string prj,string token,string area)
		{
			
			try
			{
				var username = string.Empty;    // "2";
				//var password = token;   // "password";
				//var workingArea = $"git/repositories/{repo}";

				

				//var gitNewUrl = $"https://{account}.visualstudio.com/DefaultCollection/_apis/projects?api-version=1.0";

				var gitNewUrl =vs.url_.WithPrj.GenerateUrl1_0( account, prj,area);

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, token))));

					using (HttpResponseMessage response = client.GetAsync(
								gitNewUrl).Result)
					{
						response.EnsureSuccessStatusCode();
						string responseBody = await response.Content.ReadAsStringAsync();

						return (responseBody);
					}
				}
			}
			catch (Exception ex)
			{
				throw;
			}
		}

	}
}
