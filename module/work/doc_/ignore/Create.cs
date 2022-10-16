using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div_.top.doc_.ignore
{
	/// <summary>
	/// assume it's creatable (not occupied by an address, either file or folder)
	/// </summary>
	static public class _CreateX
	{
		static public void _wouldForce(string targetAddress, IEnumerable<string> lines)
		{
			System.IO.File.WriteAllText(
				targetAddress
				,
				nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(lines));
		}
		static public void WouldForce(nilnul.fs.address_.SpearI targetAddress, IEnumerable<string> lines)
		{
			_wouldForce(
				targetAddress.ToString()
				,
				lines
			);
		}

		static public void WouldForce(string targetAddress, IEnumerable<string> lines)
		{
			WouldForce(new nilnul.fs.address_.spear_.AddressVowen(targetAddress), lines);
		}

		static public void WouldForce(nilnul.fs.git.ModuleI module, IEnumerable<string> lines)
		{
			WouldForce(
				div_.top.doc_._IgnoreX.Spear(module)
				,
				lines
			);
		}

		static public void VowNonExist(
			string targetAddress
			, IEnumerable<string> lines
		)
		{
			nilnul.obj.vow_.False.Vow(System.IO.File.Exists(targetAddress));
			WouldForce(targetAddress,lines);
		}
	}
}
