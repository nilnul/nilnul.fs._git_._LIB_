using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch.name_._vered._prefix.txt
{
	public class Be 
		:
		//nilnul.txt.be_.And<nilnul.txt_._vered_._name.txt.Be, nilnul.fs.git.repo._branch._name.txt.Be>
				//, 
	nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return Regex.IsMatch(obj, @"\A([a-zA-Z0-9_]*[a-zA-Z_])?\z", RegexOptions.Singleline);    //\w is digits and letters
			;
			//throw new NotImplementedException();
		}


		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}

	}
}
