using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.repo._name.txt
{
	/*extern alias txt;*/
	/// https://gitlab.com/gitlab-org/gitlab/-/merge_requests/80055
	/// [a-z0-9]+([._-][a-z0-9]+)*(/[a-z0-9]+([._-][a-z0-9]+)*)*
	/// old project name unchanged. 
	/// <summary>
	/// name cannot start with "-".
	/// space is better avoided.
	/// </summary>
	public class Be : /*txt::*/nilnul.txt.BeI
	{
		/// <summary>
		/// note that the created name is case insensitive.
		/// </summary>
		public const string SPECIAL="[^A-Za-z0-9]";
		public bool be(string obj)
		{
			//var nonspecial = "[A-Za-z0-9]";
			
			var special = "[^A-Za-z0-9]";

			return !Regex.IsMatch(
				obj
				,
				$@"^{special}|{special}{special}|{special}$"
				//$@"^{nonspecial}(?!.*[_.-]{{2,}}).*{nonspecial}$"  //Path must not start or end with a special character and must not contain consecutive special characters.

				//"[A-Za-z0-9-_]([A-Za-z0-9_.-]*[A-Za-z0-9_-])*"
				,
				RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline
			);
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
