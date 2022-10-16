using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._branch._name.txt
{
	/*extern alias txt;*/
	[Obsolete(nameof(nilnul.fs.git.repo._branch._name.txt.Be))]
	public class Be
		: 
		/*txt::*/
		nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return nilnul.fs.git.repo._branch._name.txt.Be.Singleton.be(obj);
			//return Regex.IsMatch(obj, @"\A[a-zA-Z0-9_]+\z");	//\w is digits and letters
			//throw new NotImplementedException();
		}

		static public Be Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Be>.Instance;
			}
		}


		

	}
}
