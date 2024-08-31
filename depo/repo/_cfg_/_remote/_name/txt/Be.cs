using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_._remote._name.txt
{
	/*extern alias txt;*/
	public class Be
		: 
		/*txt::*/
		nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return Regex.IsMatch(obj, "[a-zA-Z_0-9]+");	//\w is digits and letters
			//throw new NotImplementedException();
		}


		static public Be Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Be>.Instance;
			}
		}

	}
}
