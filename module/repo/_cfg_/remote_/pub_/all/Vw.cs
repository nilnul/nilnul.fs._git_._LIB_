using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.pub_.all
{
	/// <summary>
	/// if the pub schema is nilnul-pub-, then the name for all is:
	///		nilnul-pubs
	/// </summary>
	public class Vw
		
	{
		private nilnul.win.prog_.Git _git;

		public nilnul.win.prog_.Git git
		{
			get { return _git; }
			set { _git = value; }
		}

		public Vw( nilnul.win.prog_.Git git0 = null) 
		{
			_git = git0;
		}

		public IEnumerable<git.repo._branch.name_._dnts.dnt_.Segmented> maxes(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr.repo.Name repoName
		)
		{
			var schema = fs.git.module.repo.branch_._pub.Settings1.Schema;
			var schemaAsTxts = schema.Cast<string>();

			var schemaTyped = schema.Cast<string>().Select(
				s => nilnul.txt_.vered_._id.Nom.CreateByAppending_ofId(s)
			).ToArray();

			///
			var remotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq(
				module, git
			).Select(
				b => nilnul.fs.git.repo._branch.name_._dnts.dnt_.Segmented.TryParse(b)
			)
			.Where(
				x => x is not null
			)
			
			;





			var remote4all = remotes.Where(

			b => nilnul.objs.re_.init_.EqDefault<string,
				nilnul.txt.eq_.CaseInsensitive>.Singleton.re(
					schemaAsTxts.Concat(new[] { "" })
					,

					b.Skip(schemaTyped.Length).Select(n => n.nom.ee)
				)
			);

			var maxes4all = nilnul.fs.git.repo._branch.name_._dnts.dnt_.segmented.Contrast.Singleton.max(remote4all);

			return maxes4all;

		

		}



		public IEnumerable<git.repo._branch.name_._dnts.dnt_.Segmented> maxes(nilnul.fs.git.ModuleI moduleAddress, string v)
		{
			return maxes(
				(moduleAddress)
				,
				new svr.repo.Name(v)
			);
			//throw new NotImplementedException();
		}
		public IEnumerable<git.repo._branch.name_._dnts.dnt_.Segmented> maxes(string moduleAddress, string v)
		{
			return maxes(
				nilnul.fs.git.Module.FroAddress(moduleAddress)
				,
				new svr.repo.Name(v)
			);
			//throw new NotImplementedException();
		}

	}
}
