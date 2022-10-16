using Amazon.CodeCommit;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.aw_.ohio.client_
{
	static public class _CfgedX
	{
		static public AmazonCodeCommitClient Ensured = Ensure();
		static public AmazonCodeCommitClient Ensure()
		{
			var saved = nilnul.win.app_._CredManX.Ensure(
				_UsEastX.domain
			);
			if (saved == null)
			{
				throw new exception_.UnexpectedException("after ensure the credential shall not be null.");
				return null;
			}
			return new AmazonCodeCommitClient(
				 new BasicAWSCredentials(
					 saved.UserName
					 ,
					 saved.Password
					)
				,
				 Amazon.RegionEndpoint.USEast2
			);
		}

	}
}
