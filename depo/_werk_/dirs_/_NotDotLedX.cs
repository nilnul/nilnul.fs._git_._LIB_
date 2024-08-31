using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.dirs_
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="nilnul.fs.folder_.giT_.work_.top.dirs_.noDotLed_._NontopX"/>
	static public class _NotDotLedX
	{

		static public IEnumerable<string> _Addresses_addressAssumeModule(
				string module
				,
				nilnul.win.prog_.Git git = null
			)
		{
			return nilnul.fs.folder_.giT_.work_.top.dirs_.noDotLed_._NontopX._Addresses_addressAssumeModule(module);
		}

		static public IEnumerable<DirectoryInfo> _DirInfoEs_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _DirsX._DirInfoEs_moduleAssumeAddress(module, git).Where(
				x => !x.Name.StartsWith(".")
			);
		}
	}
}