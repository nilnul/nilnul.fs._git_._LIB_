using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.dirs_.nontop_
{
	/// <summary>
	/// each dnt shall be not dot led
	/// </summary>
	/// </remarks>
	///
	static public class _NotDotLedX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="work_nontop">work_.nontop</param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<string> Addresses_ofAddress(
			string work_nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return work_.nontop.dirs_._NontopX._Addresses_addressAssumeNontop(work_nontop, git).Where(
				x=>	!nilnul.fs.address_.nonrt._ToeX.Toe(x).StartsWith(".") 
			);
		}
	}
}
