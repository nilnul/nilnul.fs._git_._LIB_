using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.fs.git;
using nilnul.win.proc_.timeout_.end;
using nilnul.win.prog._run._result;

namespace nilnul.win.prog_.git.run_.timeout_.end
{
	
	/// <summary>
	/// 
	/// </summary>
	static public class _CodX
	{

		static public  int OfAddress(string arg, string dir, int? life = null, int? bye = null, Git git=null)
		{

			return nilnul.win.proc_.started_.timeout_.end.Cod.Singleton.ofAddress(
				nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				
				,
				arg
				,
				dir
				,life,
				bye
			);
		}

		public static int OfAddress(string arg, ShieldI en, int? life=null, int? bye=null, Git git=null)
		{
			return OfAddress(arg, en.ToString(),life,bye, git );
			
		}
		public static int OfAddress(string arg, ModuleI module, int? life = null, int? bye = null, Git git=null)
		{
			return OfAddress(arg, module.top1.en.address.en,life,bye, git );
		}

	}
}
