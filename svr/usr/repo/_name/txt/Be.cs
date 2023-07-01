using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.repo._name.txt
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
				"[A-Za-z0-9-_]([A-Za-z0-9_.-]*[A-Za-z0-9_-])*"
				,
				RegexOptions.IgnorePatternWhitespace
			);
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
