using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._reference.name_._strict.txt
{
	/*extern alias txt;*/
	public class Be
		: 
		/*txt::*/
		nilnul.txt.BeI
	{
		/// <summary>
		/// refs/heads/master
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool be(string obj)
		{
			return Regex.IsMatch(obj, @"\Arefs(/[a-zA-Z0-9_-]+){2}\z");	//\w is digits and letters ; such as refs/heads/master
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
