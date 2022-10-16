using Amazon.CodeCommit.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.aws.acc.repo._create
{

	static public class _ResponseX
	{
		//static public string Phrase(this RepositoryMetadata meta) {
		//	return JsonConvert.SerializeObject(meta);
		//}

		static public string Phrase(this CreateRepositoryResponse meta) {
			return JsonConvert.SerializeObject(meta);
		}

	

	}
}
