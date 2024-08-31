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

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.nom_.newest.nulable
{
	/// <summary>
	/// create one if there is none.
	/// </summary>
	static public class _BackfillLocalX
	{

		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.txt_._vered.Name remoteNameNom
			,

			nilnul.fs.git.svr.client.RepoI repoSvc

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var newestKey = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(
				gitTop,
				remoteNameNom
				,
				git
			);

			if (newestKey is null)
			{
				

				nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
					gitTop
					,
					new _remote.Name(
						remoteNameNom
					)
						,

					repoSvc.url(svrRepoName)
				);

				return true;

			}

			var url = remote.url.vw_._RemoteGetUrlX.Url(
				gitTop
				,
				new _remote.Name(
					newestKey
				)
				,
				git
			);

			var repoName = nilnul.fs.git.svr.client.repo._UrlX.RepoName(url);

			if (repoName != svrRepoName.ed)
			{
				Trace.TraceWarning(
					$"in {gitTop}, repo#{repoName} per the newest remote {newestKey} url, is different than expected:{svrRepoName}"
				);
			}

			return false;


		}


		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

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

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

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

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon


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

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

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

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon
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

	}

}

