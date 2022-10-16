using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.nonrepo._work_.dirs_
{
	static public class _NotDotLedX
	{
	

		static public IEnumerable<DirectoryInfo> _DirInfoEs_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return _DirsX._Infos_addressAssumeNonrepo(module, git).Where(
				x=> !x.Name.StartsWith(".")
			);
			
		}

		

	}
}
