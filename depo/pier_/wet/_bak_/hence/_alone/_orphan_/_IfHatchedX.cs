using Microsoft.VisualStudio.Services.Common.CommandLine;
using nilnul.obj.seq;
using nilnul.time_.datetime.border;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs.git.depo.pier_.wet._bak_.hence._alone._orphan_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _IfHatchedX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="bakBatch"></param>
		/// <param name="git"></param>
		/// <exception cref="Exception"></exception>
		/// <exception cref="fs.git.repo.act_.xpn_.FsAccessDenied"></exception>
		static public string _Tag_0wet1hatchedDepo_1head_2bak(
			string depo
			,
			string _oldHead
			,
			string bakBatch
			,
			nilnul.os.prog_.Git git = null
		)
		{


			/// <see cref="_HenceX"/> has tagged the commited index.

			//commit to orphan branch;

			//string _oldHead = nilnul.fs.git.module.repo.current._VwX._Txt_0depo(depo);

			Trace.TraceInformation($"oldHead:{_oldHead} of {depo}");

			var batchNob = nilnul.txt_.vered._KeyX._Txt(bakBatch);

			var bakTagSuffix = $"-pier-orphan";


			var superintendent = $"{bakBatch}{bakTagSuffix}";



			var branch = $"{superintendent}-o";
			Trace.TraceInformation($"create orphan branch:{branch} for {depo}");

			try
			{
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(depo);

				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(
					depo,
					$"checkout --orphan {branch}" //don't use switch --orphan as it may fail due to:
					/*
					 error: Your local changes to the following files would be overwritten by checkout:
.gitignore
Please commit your changes or stash them before you switch branches.
Aborting
					 */
					// it seems that switch would try to reset stage and|or work, resulting loss of modification to workspace; it will complain about modified, not deleted;
					,
					git
				);

			}
			catch (Exception x)
			{
				throw new Exception($"exception {x} when: checkout -orphan {branch} @ {depo}", x);
			}


			Trace.TraceInformation($"committing pier for {depo}");

			try
			{
				/// in log, 
				/// when running git commit -m"pier2orphan" @ D:\1\d\nilnul._animal_\eg_(Git\nonaqua_(Git\bird_(Git\eagle_(Git: 1
				/// at
				/// nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(String module, String argument, Git git)
				///

				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(depo);

				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(
					depo,
					$"commit -m\"pier2orphan\""
					,
					git
				);
			}
			catch (Exception ex)
			{
				Trace.TraceError($" when commiting pier to orphan for {depo}:{ex}");
				Trace.TraceInformation($"setting head to original @ {depo}");


				nilnul.fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(depo, _oldHead);
				Trace.TraceInformation($"setted head to original @ {depo}");

				throw;
			}


			var verName = "ver";

			var oldTags = nilnul.fs.git.depo.repo.tags._VwX._Names_0depo(depo, git).Select(
				t => Regex.Match(
					t,
					@$"\A{Regex.Escape(batchNob)}(?'{verName}'\d*){bakTagSuffix}\z"
				)
			).Where(m => m.Success).ToArray();


			//bool useOldTag = false;
			string latestTagName0Nul = null;

			if (oldTags.Any())
			{
				long p(Match c)
				{

					string v = (c.Groups[verName]?.Value ?? "");
					//nilnul.num.integer_.int64
					if (v == string.Empty)
					{
						return 0;

					}
					return long.Parse(v);
				}
				var latest = oldTags.Aggregate(
					(a, c) => p(a) < p(c) ? c : a
				);
				var latestTagName = latest.Value;



				var parentsOfOldTag = nilnul.fs.git.depo.repo.tag.snap.parents._VwX._Parents_0depo(
					depo, latestTagName, git
				);

				/// are the two the same?
				///
				if (parentsOfOldTag.None())
				{
					/// tree is the same?
					///

					if (
						nilnul.fs.git.depo.repo.tree.eq_._OfTag9currentX._DestinationsSame_0depo_1tag(depo, latestTagName, git)
					)
					{
						latestTagName0Nul = latestTagName;
						//useOldTag = true;
						//return latestTagName;
					}
				}


			}




			var tag = $"{superintendent}";
			if (latestTagName0Nul is null)
			{
				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(
					depo
					,
					$"tag {tag}"
				);


			}

			/// some times, on symbolic-ref setting, a console window says:
			/// Rename from HEAD.lock to HEAD failed. Should I try again?
			/// 
			nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(depo);

			fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(depo, _oldHead);

			//nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(
			//	depo
			//	,
			//	$"update-index {bakBatch}-pier"
			//);
			try
			{
				/// some times, on remove branch for wet orphan pier, a console window says:
				/// Rename from config.lock to config failed. Should I try again?
				/// 
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(depo);


				nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX._Vod_0address_1argument(depo, $"branch -D {branch}", git);

			}
			catch (Exception x)
			{

				throw new fs.git.repo.act_.xpn_.FsAccessDenied(
					$"deleting branch:{branch} at {depo} failed, cuz that, say, some file is already occupied as explained in: could not delete reference refs/heads/_2301061150396684925: unable to create file D:/13/d/somDepo1/.git/packed-refs.new: File exists;", x
				);
			}

			Trace.TraceInformation($"removed tmp branch:{branch}  @ {depo}");

			return latestTagName0Nul ?? tag;
			






		}
	}
}
