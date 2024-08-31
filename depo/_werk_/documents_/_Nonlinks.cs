using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_
{
	/// <summary>
	/// if the module is linked, this returns empty.
	/// </summary>
	///
	[Obsolete(nameof(_NonlinkX))]
	static public class _UnLinkX
	{

		static public IEnumerable<string> OfAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			if (nilnul.fs.folder.be_._NormalX.Be_ofAddress(module) )
			{
				return nilnul.fs.git.module_.unlink._work_.documents_._UnlinkX.Addresses_ofAddress(module);
			}
			return new string[0];
		}

		public static IEnumerable<FileInfo> FileInfoS_ofAddress(string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return OfAddress(module).Select(x => new FileInfo(x));
			//throw new NotImplementedException();
		}

		static public IEnumerable<string> Addresses(
			nilnul.fs.git._module_.TopI module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return OfAddress(module.top.en.address.ToString(),git);
		}

	}
}
