using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;

namespace nilnul.fs.git.module._ignore_.exclude.put
{
	/// <summary>
	/// create the file if not exist;
	/// patch the ignore file to reflect dotnet ignores if exists
	/// </summary>
	static public class _IfLinesNonemptyX
	{
		static public void Void(nilnul.fs.git.ModuleI top, IEnumerable<string> lines)
		{
			if (lines.Any())
			{
				PutX.Exe(top, lines);
			}
		}

		static public void _OfModuleAddress(string top, IEnumerable<string> lines)
		{
			Void(nilnul.fs.git.Module.FroAddress(top), lines);
		}

		public static void Void(ModuleI module, IEnumerable<DivisionI> buts)
		{
			Void(
				(module)
				,
				buts.Select(
					x => x.ToString().Replace(@"\", "/")
				)
			);
		}


		public static void Void_ofModuleAddress(string module, IEnumerable<DivisionI> buts)
		{
			Void(
				nilnul.fs.git.Module.FroAddress(module)
				,
				buts
			);
		}
	}
}
