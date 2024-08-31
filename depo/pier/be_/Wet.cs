using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.be_
{
	/// <summary>
	/// git status shows that there are no changes staged for commit 
	/// </summary>
	/// alias:
	///		Disheveled
	///		dirty
	///		messy
	///		unkempt
	///		unswept
	///		wet
	///		soak

	public class Wet
		:
		nilnul.fs.git.depo.be.anto_.BeDefault<Dry>
		,
		nilnul.fs.git.depo.BeI
	{
		static public bool _Be_0depo(string address) {
			return !Dry._Be_0depo(address);
		}

	
		static public Wet Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Wet>.Unison;
			}
		}

	}
}
