using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.svr_.vs.work
{
	public class Get
	{

		public static async Task<string> ExeAsync(string account, string token)
		{
			
			try
			{
				string username = string.Empty;    // "2";
				var password = token;   // "password";
				var taskType = "Task";

				

				//var gitNewUrl = $"https://{account}.visualstudio.com/DefaultCollection/_apis/projects?api-version=1.0";

				var gitNewUrl =vs.work.Url.Gen_v10( account, taskType);

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password))));

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
