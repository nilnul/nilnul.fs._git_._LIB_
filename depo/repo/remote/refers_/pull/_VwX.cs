using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote.refers_.pull
{
	static public class _VwX
	{

		static public string _Msg_0depo_1remote(
			string depo, string remote, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo, $"ls-remote {remote} refs/pull/*", git
			);
		}


		static public IEnumerable<(string hash, string refer)> _Snap9refEs_0depo_1snap(
			string depo, string remote, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				_Msg_0depo_1remote(depo, remote, git) ?? ""
			).Select(
				r =>
				{
					var a = r.Split(
										[' ', '\t']

									)
					;

					if (a.Length != 2)
					{
						throw new IndexOutOfRangeException(
							$"{nilnul.obj.str._PhraseX.Phrase(a)}.length shall be 2;"
						);
					}
					return (hash: a[0], refer: a[1]);

		}
			);



		}
}
}
