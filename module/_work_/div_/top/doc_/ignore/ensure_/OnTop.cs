using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git.module.work.div_.top._ignore.doc.ensure_
{
	/// <summary>
	/// ofModule
	/// </summary>
	static public class _DotNetX
	{
		
		static public bool Ensure(nilnul.fs.git.ModuleI targetAddress) {
			return div._ignore._doc._AtFolderX.Ensure(targetAddress.top);

		}

		static public bool Ensure(nilnul.fs.git.Module targetAddress) {
			return Ensure(
				(targetAddress) as nilnul.fs.git.ModuleI
			);

		}


		/// <summary>
		/// true if created
		/// </summary>
		/// <param name="targetAddress"></param>
		/// <returns>true if created</returns>
		static public bool Ensure(nilnul.fs.folder_.git_.Top targetAddress) {
			return Ensure(
				new nilnul.fs.git.Module(targetAddress)
			);

		}
		static public bool Ensure(nilnul.fs.FolderI targetModule) {
			return Ensure(new nilnul.fs.folder_.git_.Top(targetModule));
		}

		static public bool Ensure_ofFolderAddress(string targetAddress) {
			return Ensure( nilnul.fs.Folder.FroAddress(targetAddress));
		}



	
	}
}