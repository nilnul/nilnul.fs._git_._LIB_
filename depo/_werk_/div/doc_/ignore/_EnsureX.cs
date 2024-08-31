using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git.module.work.div._ignore.doc
{
	/// <summary>
	/// ofModule
	/// </summary>
	static public class _EnsureX
	{



		/// <summary>
		/// true if created
		/// </summary>
		/// <param name="targetAddress"></param>
		/// <returns>true if created</returns>
		static public bool Ensure(nilnul.fs.FolderI targetAddress) {
			return _doc._AtFolderX.Ensure(targetAddress);

		}
		static public bool Ensure(nilnul.fs.folder_.git_.Top targetModule) {
			return Ensure(targetModule.folder);
		}

		static public bool Ensure_ofAddress(string targetAddress) {
			return Ensure( nilnul.fs.Folder.FroAddress(targetAddress));
		}



	}
}