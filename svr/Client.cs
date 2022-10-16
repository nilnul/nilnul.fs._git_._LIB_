using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{
	/// <summary>
	/// the info needed for a client to connect to a svr. hence the info includes both svr info and credential info.
	/// </summary>
	/// 
	//[Serializable]		invalid on interface

		[Obsolete(nameof(git.svr.ClientI))]
	public interface ClientI
	{

		/// <summary>
		/// create the repo.
		/// </summary>
		/// <param name="repo"></param>
		/// <returns>if repo already exists, return false; if newly created, return true</returns>
		string ensureRepo(string repo);

	}


}
