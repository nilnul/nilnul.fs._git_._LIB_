using nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.pub_
{
	
	/// <summary>
	/// the remote name is multiple noms, like:  
	/// </summary>
	public class Noms :
		nilnul.obj.Box1<
			fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonempty
		>
	{
		private nilnul.win.prog_.Git _git;

		public nilnul.win.prog_.Git git
		{
			get { return _git; }
			set { _git = value; }
		}

		public Noms(Nom1nonempty val, nilnul.win.prog_.Git git0 = null) : base(val)
		{
			_git = git0;
		}

		void ensureRemotes(nilnul.fs.git.ModuleI module, nilnul.fs.git.svr.repo.Name repoName)
		{
			var schema = fs.git.module.repo.branch_._pub.Settings1.Schema;
			var schemaTyped = schema.Cast<string>().Select(
				s => nilnul.txt_.vered_._id.Nom.CreateByAppending_ofId(s)
			).ToArray();

			var branches = nilnul.fs.git.module.repo.branches_.local._VwX.CurrentAndRemaining(module, git).Select(b => nilnul.fs.git.repo._branch.name_._dnts.dnt_.Segmented.Parse(b))
			.Where(
				s =>
				nilnul.objs.re_.init_.EqDefault<string,nilnul.txt.eq_.CaseInsensitive>.Singleton.re(
					s.Select( ss=>ss.nom.ee)
					,
					schemaTyped.Select(schemaSeg=>schemaSeg.ee)

				)
			)
			;


			for (int i = 0; i < this.boxed.svcs.ee.Count(); i++)
			{

				var nom = this.boxed.noms.ee.ElementAt(i);

				///get all branches
				///


				var branches4svc=branches.Where(
					b=> b.Skip(schemaTyped.Length).FirstOrDefault()?.nom.ee ==nom.ee
				);

				


				///compare and select the newest.
				var comp = new nilnul.obj.comp_.ByTag<nilnul.fs.git.repo._branch.name_._dnts.dnt_.Segmented,   >(


				);

				nilnul.txt_._vered.ver_.switched_.Suffixing







			}
			foreach (var item in this.boxed.svcs.ee)
			{


			}
		}
	}
}
