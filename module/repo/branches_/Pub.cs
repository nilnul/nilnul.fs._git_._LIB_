using nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_
{
	/// <summary>
	/// each and all.
	///		eg:
	///			nilnul-pub-azure
	///			nilnul-pub-github
	///			nilnul-pubs
	/// </summary>
	interface IPub
	{
	}

	/// <summary>
	/// create remote for svrs that are setup for pub branches.
	/// </summary>
	///
	//[PartialImplementation]
	public class Pub 
	{
		private nilnul.win.prog_.Git _git;

		public nilnul.win.prog_.Git git
		{
			get { return _git; }
			set { _git = value; }
		}

		public Pub( nilnul.win.prog_.Git git0 = null) 
		{
			_git = git0;
		}

		public IEnumerable<git.repo._branch.name_._dnts.dnt_.Segmented> branches(nilnul.fs.git.ModuleI module)
		{
			var schema = fs.git.module.repo.branch_._pub.Settings1.Schema;
			var schemaTyped = schema.Cast<string>().Select(
				s => nilnul.txt_.vered_._id.Nom.CreateByAppending_ofId(s)
			).ToArray();

			///
			var branches = nilnul.fs.git.module.repo.branches_.local._VwX.CurrentAndRemaining(
				module, git
			).Select(
				b => nilnul.fs.git.repo._branch.name_._dnts.dnt_.Segmented.Parse(b)
			)
			.Where(
				s =>
				nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.eq_.CaseInsensitive>.Singleton.re(
					schemaTyped.Select(schemaSeg => schemaSeg.ee)
					,
					s.Select(ss => ss.nom.ee)
				)
			);

			return branches;
		}
		public bool isCurrentPub(nilnul.fs.git.ModuleI module)
		{
			var schema = fs.git.module.repo.branch_._pub.Settings1.Schema;
			var schemaTyped = schema.Cast<string>().Select(
				s => nilnul.txt_.vered_._id.Nom.CreateByAppending_ofId(s)
			).ToArray();

			///
			var branches = nilnul.fs.git.module.repo.branch_.current.nulable._VwX.Nuly(
				module, git
			) ?? "";
			var parsed0nul =

				 nilnul.fs.git.repo._branch.name_._dnts.dnt_.Segmented.TryParse(branches);
			if (parsed0nul is null)
			{
				return false;
			}
			return nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.eq_.CaseInsensitive>.Singleton.re(
				schemaTyped.Select(schemaSeg => schemaSeg.ee)
				,
				parsed0nul.Select(v=>v.nom.ToString())
			);

		}

		public void vowCurrentIsPub(nilnul.fs.git.ModuleI module) {
			nilnul.bit.vow_.True1.Vow(
				isCurrentPub(module)
				,
				$"current branch of {module} is not pub branch."
			);
		}

	}
}
