using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_
{

	static public class _UpsertX
	{
		[Obsolete(nameof(Document0linkEs))]
		static public IEnumerable<string> Documents(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _ChangeX.Documents(module, git).Except(
				_DeletedX.Documents(module,git)
			);
		}
		static public IEnumerable<string> Document0linkEs(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _ChangeX.Document0symlinkEs(module, git).Except(
				_DeletedX.Document0symlinkEs(module,git)
			);
		}
	}
}