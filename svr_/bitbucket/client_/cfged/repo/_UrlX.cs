﻿using nilnul.fs.git.svr_.bb.client_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.bb.client_.cfged.repo
{
	[Obsolete("superseded by " + nameof(url_._WithAccX) + " for url with no username brings errors")]
	static public class _UrlX
	{

		public static string Gen(string repoName,string username)
		{
			return svr_.bb.client.repo._UrlX.Gen(Cfged.Credential.UserName,repoName);
			//return $"https://{_ApiX.DOMAIN}/{Cfged.Credential.UserName}/{repoName}.git";

		}


	}
}
