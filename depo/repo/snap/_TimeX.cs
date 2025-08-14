using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap
{
	static public class _TimeX
	{

		/// git show --pretty=%aI HEAD
		///
		/// <summary>
		/// author time in strict ISO 8601 format;
		/// not commit time, which might be the committer in merging a pull request
		/// </summary>
		///<remarks>
		///</remarks>
		///<returns>
		/// eg:
		///		2025-06-17T12:47:00+00:00
		/// </returns>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Msg_0depo_1snap(
			string depo, string snapId, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				///$"show --pretty=%aI {snapId}"		/// will show content
				///
				$"log -1 --pretty=%aI {snapId}"		/// will show content

				, git
			).Trim();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTimeOffset _Zoned_0depo_1snap(
			string depo, string snapId, nilnul.os.prog_.Git git = default
		)
		{

			return DateTimeOffset.ParseExact(
				_Msg_0depo_1snap(depo,snapId,git)
				,
				"yyyy-MM-ddTHH:mm:sszzz"    /// zzz  = K for offset datetime ;
				// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings#KSpecifier
				,
				System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.RoundtripKind
			);
		}



	}
}
