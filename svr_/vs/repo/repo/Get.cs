using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.svr_.vs.repo
{
	public class Get
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="account"></param>
		/// <param name="token"></param>
		/// <param name="repoId">Guid</param>
		/// <returns></returns>
		public static async Task<string> ExeAsync(string account, string token,string repoId)
		{

			 return await vs.Get.GetResponseAsync(account, token, $"git/repositories/{repoId}");
			
			
		}

	}
}
