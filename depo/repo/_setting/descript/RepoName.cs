using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo._setting.descript
{
	/// this is in consisitency with what nilnul proposes in <see cref="nilnul.lang_.ling.Inverse"/>, inverse the traditional artical from code in comment to ling in comment;
	///
	/// <summary>
	/// get a repo name from <see cref="_setting.Description"/>
	/// </summary>
	/// <remarks>
	///	 a name, and some comment
	/// <see cref="nilnul.lang_._cot_"/>
	/// eg:
	///		#blank lines
	///         
	///
	///		the-name
	///		#another comment
	/// </remarks>
	/// <see cref="nilnul.fs."/>
 
	static public class _RepoNameX
	{

		static public string? _Identy0nul_0depo(string depo, nilnul.os.prog_.Git? git = null)
		{
			
			return _setting._DescriptionX.DescriptionAsLines0nul(
				depo,git
			)?.Select(x=>x.Trim()).Where(
				t=>
				string.Empty !=t
				&& !t.StartsWith("#")
				&& t!=_descript.TheSettingsX.DefaultLine
				&& Regex.IsMatch(t, @"\A([^\d\W]\w*)(\.\w+)*\z" )  /// if it contains space, it's excluded.
			).ToArray().SingleOrDefault(); //xpn if pluarl; nul if empty;
		}

	}
}
