using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#define SOME_AMAZON_REPO_NOT_CREATED
using nilnul.fs.git.svr.client_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.nom_.newest.nulable.backfill_
{
	static public class _GithubX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.txt_._vered.Name remoteNameNom
			,

			nilnul.fs.git.svr_.github.client_.Vaulted amazon

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return _BackfillLocalX.NewlyCreated(
				gitTop
				,
				remoteNameNom
				,
				new nilnul.fs.git.svr_.github.client_.vaulted.Repo4pub(amazon)
				, svrRepoName, git
			);

		}


		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.github.client_.Vaulted amazon

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return NewlyCreated(
				gitTop
				,
				 txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(remoteNameNom)
				 ,
				 amazon
				 ,
				 svrRepoName
				 ,
				 git
			);
		}



		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.github.client_.Vaulted amazon

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			)
		{
			return NewlyCreated(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom
				,
				amazon,

				svrRepoName);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom

						,

			nilnul.fs.git.svr_.github.client_.Vaulted amazon


			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop), remoteNameNom, amazon, svrRepoName);
		}

		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.github.client_.Vaulted amazon

			,
			string svrRepoName)
		{
			return NewlyCreated(
				gitTop
				, remoteNameNom
				,
				amazon
				, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static bool NewlyCreated(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
						,

			nilnul.fs.git.svr_.github.client_.Vaulted amazon
			,
			string svrRepoName
		)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop)
				, remoteNameNom
				, amazon
				, (svrRepoName)
			);
		}


		public static bool NewlyCreated(
			string gitTop
												,
			string remoteNameNom
						,

			nilnul.fs.git.svr_.github.client_.Vaulted amazon
			,
			string svrRepoName
		)
		{
			return NewlyCreated(
				 fs.Folder.FroAddress(gitTop)
				, remoteNameNom
				, amazon
				, (svrRepoName)
			);
		}

	}

}

