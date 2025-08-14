using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.document
{
	/// <summary>
	/// it first copies it to the index. Whenever it does this, it writes the file to slot zero. Writing to slot zero wipes out slots 1-3, if they are occupied.
	/// 
	/// </summary>
	internal class ICheckout
	{
	}
}
