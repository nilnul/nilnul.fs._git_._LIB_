using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.win.proc_.timeout_.end;
using nilnul.win.prog._run._result;

namespace nilnul.win.prog_.git.run
{
	public interface CodMsgI {
		nilnul.win.prog._run._result.CodMsg codMsg(nilnul.fs.FolderI folder, string arg, nilnul.win.prog_.Git git = null);
	}

	public abstract class CodMsgA : CodMsgI
	{
		public abstract prog._run._result.CodMsg codMsg(FolderI folder, string arg, Git git = null);
	}

}
