using System.Text.RegularExpressions;

namespace nilnul.fs.git.svr_.gitlab.repo
{
	/// <summary>
	/// todo:
	/// </summary>
	static public class _NameX
	{
		
		public static string RegexAsTxt = $@"(
					^ (0*) (?>{_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) (0*) (?>{_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) (0*) $
				)"
			;



		static public string Encode(string intendedName) {

			return Regex.Replace(
				intendedName
				,
				$@"(
					^ (?'a'0*) (?={_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) (?'a'0*) (?={_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) (?'a'0*) $
				)"
				,
				m=>m.Result(
				"0${a}"
				)
				, RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline
			);
	
		}


		static public string Decode(string intendedName) {



			 string pattern = $@"
					^ 0(?'a'0*) (?={_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) 0(?'a'0*) (?={_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) 0(?'a'0*) $
				";
#if DEBUG

			var matched = Regex.Match(intendedName, pattern, RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline );


#endif




			return  Regex.Replace(
				intendedName
				,
				pattern
				,
				m => m.Result("${a}")
				//"$1"
				,
				RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline

			);
	
		}

	}
}
