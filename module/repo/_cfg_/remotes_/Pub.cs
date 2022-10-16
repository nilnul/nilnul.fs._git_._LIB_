using nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_
{

	/// <summary>
	/// create remote for svrs that are setup for pub branches.
	/// </summary>
	///
	//[PartialImplementation]
	public class Pub :
		nilnul.obj.Box1<
			fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs
		>
	{
		private nilnul.win.prog_.Git _git;

		public nilnul.win.prog_.Git git
		{
			get { return _git; }
			set { _git = value; }
		}

		public Pub(Nom1nonemptyEs val, nilnul.win.prog_.Git git0 = null) : base(val)
		{
			_git = git0;
		}

		public void ensureRemotes(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr.repo.Name repoName
		)
		{
			var schema = fs.git.module.repo._cfg_.remote_._pub.Settings1.Schema;
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
				x=>x is not null
			)
			.Where(
				s =>
				nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.eq_.CaseInsensitive>.Singleton.re(
					schemaTyped.Select(schemaSeg => schemaSeg.ee)
					,
					s.Select(ss => ss.nom.ee)

				)
			)
			;


			for (int i = 0; i < this.boxed.svcs.ee.Count(); i++)
			{

				var noms = this.boxed.noms.ee.ElementAt(i);

				///get all branches
				///

				///for each host such as github
				var branches4svc = remotes.Where(

					b =>
				nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.eq_.CaseInsensitive>.Singleton.re(
					noms.Select(schemaSeg => schemaSeg.ee)
					,

					b.Skip(schemaTyped.Length).Select(n => n.nom.ee)
				)
				);


				///compare and select the newest.

				var maxes = nilnul.fs.git.repo._branch.name_._dnts.dnt_.segmented.Contrast.Singleton.max(branches4svc);

				if (maxes.Take(2).Count() != 1)
				{

					var comparer = nilnul.txt_._versioned.version_.decs.Comparer.Singleton;

					var comparer4nuly = new nilnul.obj.comp_.ovNuly_.NulMin<txt_._versioned.version_.idable_.decs_.Underlined>(comparer);

					var firstSchema = new
						nilnul.obj.op_.binary.cumulator.Cumulate<txt_._versioned.version_.idable_.decs_.Underlined>(
						new nilnul.obj.op_.binary.Cumulator<txt_._versioned.version_.idable_.decs_.Underlined?>(
							null    //nullable
							,
							new nilnul.obj.op_.Binary<txt_._versioned.version_.idable_.decs_.Underlined>(
								(x, y) => comparer4nuly.Compare(x, y) >= 0 ? x : y
							)
						)
					);

					var maxVer = firstSchema.cumulate(
						branches4svc.Select(b => b.First().ver)
					);
					txt_._versioned.version_.idable_.decs_.Underlined nextVer;

					if (maxVer is null)
					{
						nextVer = new txt_._versioned.version_.idable_.decs_.Underlined();
					}
					else
					{
						nextVer = new txt_._versioned.version_.idable_.decs_.Underlined(
							maxVer.trunk
							,
							new txt_.num_.radix.prefixed_.Dec1(
								maxVer.appendix.prefix
								,
								maxVer.appendix.main + 1
							)
						);
					}

					//create this.

					if (
						boxed.svcs.ee.ElementAt(i) is fs.git.svr_.github.client_.vaulted_.orged.Repo4pub githubRepo
					)
					{
						githubRepo.tryEnsure(repoName);
					}
					else
					{
						boxed.svcs.ee.ElementAt(i).ensure(repoName);
					}

					//create the remote

					nilnul.fs.git.module.repo._cfg_.remote.create_._ResultX.Result(
						module
						,
						string.Join(
							"-",
							(new[] { schemaAsTxts.First() + nextVer.ToString() }).Concat(
								schemaAsTxts.Skip(1) ).Concat(
								noms.Select(n => n.ToString())
							)
						)
						,
						boxed.svcs.ee.ElementAt(i).urn(repoName)
						,
						_git
					);

				}



			}

		}

		public void ensureRemotes(nilnul.fs.git.ModuleI moduleAddress, string v)
		{
			ensureRemotes(
				(moduleAddress)
				,
				new svr.repo.Name(v)
			);
			//throw new NotImplementedException();
		}
		public void ensureRemotes(string moduleAddress, string v)
		{
			ensureRemotes(
				nilnul.fs.git.Module.FroAddress(moduleAddress)
				,
				new svr.repo.Name(v)
			);
			//throw new NotImplementedException();
		}

	}
}
