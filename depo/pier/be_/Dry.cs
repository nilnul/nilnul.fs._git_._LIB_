using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.be_
{
	/// <summary>
	/// git status shows that there are no changes staged for commit 
	/// </summary>
	/// vs:
	///		<see cref="_pier_._DossiersX"/> which list all entries, some of which might already be commited;
	///	alias:
	///		neat
	///			,similar to nit, put away the staff on the pier.
	///		kept
	///		groomed
	///		orderly
	///		arranged
	///		tidy
	///		dry
	///			,<see cref="depo.IBank"/> is kept but water is dry
	///			, 干 in 干净, where 净 means <see cref="fs.git.depo.werk.dossiers_.untracked.Clean"/>
	///			
	///		clean, confusing with <see cref="depo.werk.dossiers_.untracked.Clean"/>
	public class Dry
		:
		nilnul.fs.git.depo.BeI
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be_0depo(string s) {
			return _dry_.by_._ByStatusShortX._Be_0depo(s);
			
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool be(in ModuleI val)
		{
			return _Be_0depo(val.top.en.address.en.ToString());
		}

		public bool be(in DepoI val)
		{
			return _Be_0depo(val.top1.en.address.en.ToString());

		}

		static public Dry Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Dry>.Unison;
			}
		}

	}
}
