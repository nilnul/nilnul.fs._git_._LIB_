using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage.commit_.emptible_
{
	/// <summary>
	/// <seealso cref="module.repo.snap_.Msgless"/>
	/// </summary>
	static public  class _MsglessX
	{
		/// git commit --allow-empty --allow-empty-message --message=""
		/// git commit --allow-empty --allow-empty-message -m ""
		/// git commit --allow-empty --allow-empty-message --no-edit
		///
		static public void _Commit_addressAssumeModule(string _addressAssumeModule, nilnul.os.prog_.Git git = null)
		{
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
				_addressAssumeModule
				,
				"commit --allow-empty --allow-empty-message --message=\"\""
				,
				git
			);
		}
	}
}
