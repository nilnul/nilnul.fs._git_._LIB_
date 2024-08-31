using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.add_.all.commit_
{
	static public class _AllowEmptyX
	{

		static public void Exe(nilnul.fs.folder_.git_.Top module, nilnul.fs.git.module.index._commit.Msg msg, nilnul.win.prog_.Git git=null)
		{
			index.add_._AllX.Exe(module, git);
			nilnul.fs.git.module.index.commit_.allowEmpty_._MsgX.Txt(module, msg, git);

		}

		static public void Exe( string module, string _msg, nilnul.win.prog_.Git git=null)
		{
			Exe(
				 fs.folder_.git_.Top.FroAddress(module)
				, new nilnul.fs.git.module.index._commit.Msg(_msg)
				,git
			);
		}

	}
}
