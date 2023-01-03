using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.commit
{
	public class Tag
	{
		static public void Exe(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string tag)
		{
			tag = tag.Trim();
			if (nilnul.txt.be_.contain_.White.Singleton.be(tag))
			{
				tag = nilnul.txt.op_.Quote.Singleton.op(tag);
			}
			
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"tag {tag}");
		}

		static public void Exe( nilnul.fs.Folder _module, string tag)
		{
			Exe( nilnul.win.prog_.Git.StaticInstance, _module,tag);
		}

		static public void Annotate(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string tag, string msg)
		{
			msg = msg.Trim();
			if (nilnul.txt.be_.contain_.White.Singleton.be(msg))
			{
				msg = nilnul.txt.op_.Quote.Singleton.op(msg);
			}
			
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"tag {tag} -m{msg}");
		}

		static public void Annotate( nilnul.fs.Folder _module, string tag, string msg)
		{
			Annotate(nilnul.win.prog_.Git.StaticInstance, _module,tag,msg);
		}

	}
}
