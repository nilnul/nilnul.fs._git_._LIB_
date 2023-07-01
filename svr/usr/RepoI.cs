using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client
{
	/// <summary>
	/// a client may maitain multiple organizations.
	/// process repos. Some svr delegates the functions of client into subservices such as Auth, Repo, etc.
	/// This would also help factor the supertype, and reduce breaks as many types already inherit the supertype.
	/// </summary>
	public interface RepoI
		:
		_repo_.EnsureI
		,
		_repo_.Ensure_assumeUnnormedI
		,
		_repo_.ConnectionI
		,
		_repo_.UrlI
		,
		_repo_.BaseUrl4RepoI
		,
		_repo_.url_.Txt4sshI
		

		//,
		//ISerializable
	{

	}
}
