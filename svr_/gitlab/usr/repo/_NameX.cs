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


		/// <summary>
		/// 
		/// </summary>
		/// <param name="unnormedName">
		///raw; unnormalized name
		/// </param>
		/// <returns></returns>

		static public string Encode(string unnormedName) {

			return Regex.Replace(
				unnormedName
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
				"0${a}"	//prepend 0s to "", or "00", ..., if it's between two special anchors;
				)
				, RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline
			);
	
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="normedName">
		/// normalized name;
		/// </param>
		/// <returns></returns>
		static public string Decode(string normedName) {



			 string pattern = $@"
					^ 0(?'a'0*) (?={_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) 0(?'a'0*) (?={_name.txt.Be.SPECIAL})
					|
					(?<={_name.txt.Be.SPECIAL}) 0(?'a'0*) $
				";
#if DEBUG

			var matched = Regex.Match(normedName, pattern, RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline );


#endif




			return  Regex.Replace(
				normedName
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
