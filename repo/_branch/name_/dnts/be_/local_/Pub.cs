using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch.name_.dnts.be_.local_
{
	static public class _PubX
	{
		static public bool IsPub_assumeBranch(string local0remoteBranch) {
			var isLocal = be_._LocalX.IsLocal(local0remoteBranch);
			if (isLocal)
			{
				var schema = fs.git.module.repo.branch_._pub.Settings1.Schema;
				var schemaTyped = schema.Cast<string>().Select(
					s => nilnul.txt_.vered_._id.Nom.CreateByAppending_ofId(s)
				).ToArray();

				///
				
				var parsed0nul =

					 nilnul.fs.git.repo._branch.name_._dnts.dnt_.Segmented.TryParse(local0remoteBranch);
				if (parsed0nul is null)
				{
					return false;
				}
				return nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.eq_.CaseInsensitive>.Singleton.re(
					schemaTyped.Select(schemaSeg => schemaSeg.ee)
					,
					parsed0nul.Select(v => v.nom.ToString())
				);


			}
			return false;
		}
	}
}
