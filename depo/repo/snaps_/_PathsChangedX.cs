using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps_
{

    static public class _PathsChangedX
    {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="pathPattern">
		/// eg:
		///		*{studentId}/**
		/// </param>
		/// <returns></returns>
		static public DateTimeOffset[] _Times_0depo_1pathPattern(string depo, string pathPattern)
		{

			var l = nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo
				,
				///$"show --pretty=%aI {snapId}"		/// will show content
				///
				$"log --pretty=%aI --all -- {pathPattern}"     /// --all
			);

			var lines = nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(l)
			.Select(
				x =>DateTimeOffset.ParseExact(
					x
					,
					"yyyy-MM-ddTHH:mm:sszzz"    /// zzz  = K for offset datetime ;
					// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings#KSpecifier
					,
					System.Globalization.CultureInfo.InvariantCulture
					,
					System.Globalization.DateTimeStyles.RoundtripKind
				)

			);

			return lines.ToArray();



		}
	}
}
