using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._reference._name.txt
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
			return Regex.IsMatch(obj, @"\Arefs(/[a-zA-Z0-9_.-]+){1,}\z"); //\w is digits and letters ; such as refs/heads/master or refs/tags/v1

			///# must not contain /.
			///	(?!.*/\.)
			//	# must not end with .lock
			//	(?<!\.lock)$
			///


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
