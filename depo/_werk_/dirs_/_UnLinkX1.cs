using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.dirs_
{
	/// <summary>
	/// unlink at this part. the parent might be a link.
	/// </summary>
	///
	/// <see cref="nilnul.fs.folder_.giT_.work_.nontop.dirs_.nonlink_._NontopX"/>

	static public class _UnLinkX1
	{
	

		static public IEnumerable<string> _Addresses_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _DirsX._Addresses_assumeModuleAddress(
				module
				,
				git
			).Where(
				x=>
				nilnul.fs.folder.dir.be_.symlink._AntoX._Be_assumeAddressAsParented(
					x
				)
			);
			
		}
	}
}