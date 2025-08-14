using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._branch._name.txt
{
	///*extern alias txt;*/
	public class Be
		: 
		///*txt::*/
		nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return Regex.IsMatch(obj, "[a-zA-Z0-9_]+");	//\w is digits and letters
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
