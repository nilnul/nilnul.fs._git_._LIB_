using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.repo.name_
{
	/// <summary>
	/// not normed in constructor
	/// </summary>
	///
	[Obsolete("",true)]

	public class Normed : repo.Name // _name.txt.be.vow.Ee
	{

		static public Normed _Normalize(string intendedName)
		{
			return new Normed(
				
				intendedName ///*.Replace("-","-_")*/.Replace(".", "-")
			);
		}

		public Normed(string val) : base(_NameX.Encode(val))
		{

		}


	

	}
}
