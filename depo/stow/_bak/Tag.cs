using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow._bak
{
	static public class _TagX
	{

		static string? _Tag4current0Nul_0depo_1regex4tag_2ver8regex(
	   string _depo
	   ,
	   string regex4tag
	   , string verName = "ver"
	   , os.prog_.Git git = null
	   )
		{


			var oldTags = nilnul.fs.git.depo.repo.tags_.Current.Unison._names_0depo(_depo, git).Select(
				t => Regex.Match(
					t,
					regex4tag
				)
			).Where(m => m.Success).ToArray();

			long p(Match c)
			{

				string v = (c.Groups[verName]?.Value ?? "");
				//nilnul.num.integer_.int64
				if (v == string.Empty)
				{
					return 0;

				}
				return long.Parse(v);
			}

			if (oldTags.Any())
			{
				var latest = oldTags.Aggregate(
					(Func<Match, Match, Match>)((a, c) =>
					{
						return p(a) < p(c) ? c : a;


					})
				);

				var latestTagName = latest.Value;

				return latestTagName;


			}
			return null;
		}



		public static string? _OldTag0Nul_0depo_1regex4tag_2parents_3ver8regex(
			string _depo
			,
			string regex4tag
			, bool parents
			, string verName = "ver"
			, os.prog_.Git git = null
		)
		{


			var oldTags = nilnul.fs.git.depo.repo.tags._VwX._Names_0depo(_depo, git).Select(
				t => Regex.Match(
					t,
					regex4tag
				)
			).Where(m => m.Success).ToArray();

			string latestTagName = null;

			if (oldTags.Any())
			{
				var latest = oldTags.Aggregate(
					(a, c) => long.Parse(a.Groups[verName]?.Value ?? "0") < long.Parse(c.Groups[verName]?.Value ?? "0") ? c : a
				);

				latestTagName = latest.Value;



				var parentsOfOldTag = nilnul.fs.git.depo.repo.tag.snap.parents._VwX._Parents_0depo(
					_depo, latestTagName, git
				);

				/// are the two the same?
				///
				if (parentsOfOldTag.Take(2).Count() == (parents ? 1 : 0))
				{
					/// tree is the same?
					///

					if (
						nilnul.fs.git.depo.repo.tree.eq_._ByTag9currentX._DestinationsSame_0depo_1tag(_depo, latestTagName, git)
					)
					{
						//useOldTag = true;
						return latestTagName;
					}
				}


			}
			return null;
		}


	}
}
