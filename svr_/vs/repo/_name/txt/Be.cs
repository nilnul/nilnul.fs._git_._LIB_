using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.repo._name.txt
{
	/*extern alias txt;*/
	/// <summary>
	/// name cannot start with "-".
	/// space is better avoided.
	/// </summary>
	public class Be : /*txt::*/nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return Regex.IsMatch(
				obj
				,
				@"\A[A-Za-z0-9-]([A-Za-z0-9_.-]{0,62}[A-Za-z0-9_-])\z" //max length 64; https://docs.microsoft.com/en-us/azure/devops/organizations/settings/naming-restrictions?view=vsts
				,
				RegexOptions.IgnorePatternWhitespace
			) ;
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
