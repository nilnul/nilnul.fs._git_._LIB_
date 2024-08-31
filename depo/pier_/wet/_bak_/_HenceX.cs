using nilnul.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs.git.depo.pier_.wet._bak_
{
	/// <summary>
	///  create a commit from the index, and tag that commit;
	/// </summary>
	/// <remarks>
	/// this is called from <see cref="pier._BakX"/>, which in turn is called from within <see cref="depo_.IWrought"/>
	/// </remarks>
	/// alias:
	///		ahead
	///		forth
	///		onward
	///		ongoing
	///		
	static public class _HenceX
	{
		public static string? _Tag4child0Nul_0depo_1regex4tag_2ver8regex(
			string depo
			,
			string regex4tag
			, string verName = "ver"
			, os.prog_.Git git = null
		)
		{


			var oldTags = nilnul.fs.git.depo.repo.tags._VwX._Names_0depo(depo, git).Select(
				t => Regex.Match(
					t,
					regex4tag
				)
			).Where(m => m.Success).ToArray();


			string latestTagName = null;

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

				latestTagName = latest.Value;


				// get parents of current commit

				var parents = nilnul.fs.git.depo.repo.snap_.current.parents._VwX._Parents_0depo(depo, git);

				var parentsOfOldTag = nilnul.fs.git.depo.repo.tag.snap.parents._VwX._Parents_0depo(
					depo, latestTagName, git
				);

				/// are the two the same?
				///
				if (nilnul.set.Eq<string>.Unison.Equals(parents, parentsOfOldTag))
				{
					/// tree is the same?
					///

					if (
						nilnul.fs.git.depo.repo.tree.eq_._OfTag9currentX._DestinationsSame_0depo_1tag(depo, latestTagName, git)
					)
					{
						return latestTagName;
						//return latestTagName;
					}
				}


			}
			return null;
		}



		static public string _Tag_0depo8dirty_1head_2bak(
			string depo
			,
			string _oldHead
			,
			string bakBatch
			,
			nilnul.os.prog_.Git git = null
		)
		{
			#region the head might be unborn, hence tag might fail
#if false

			//lets tag it;

			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(
				depo
				,
				$"tag {bakBatch}"
			);


#endif
			#endregion

			//commit to current branch;

			//string _oldHead = nilnul.fs.git.module.repo.current._VwX._Txt_0depo(depo);

			Trace.TraceInformation($"oldHead:{_oldHead} of {depo}");
			Trace.TraceInformation($"create branch {bakBatch}  for {depo}");

			var batchNob = nilnul.txt_.vered._KeyX._Txt(bakBatch);

			var bakTagSuffix = $"-pier-hence";

			var bakOverhead = $"{bakBatch}{bakTagSuffix}";
			var branch = $"{bakOverhead}-h";    //where r means head hatched.

			try
			{
				nilnul.fs.git.module.branch.create_._CheckoutX._Vod_assumeModuleAddress_assumeBranch(
					depo, branch
				);
			}
			catch (Exception x)
			{
				throw new Exception($"exception {x} when: checkout -b {branch} @ {depo}", x);
			}


			Trace.TraceInformation($"committing pier for {depo}");

			try
			{
				nilnul.fs.git.module.stage.commit._VodX._Vod_addressAssumeModule_assumeNub(
					depo, git
				);

			}
			catch (Exception ex)
			{
				Trace.TraceError($" when commiting pier for {depo}:{ex}");
				Trace.TraceInformation($"setting head to original @ {depo}");

				/// some times, on symbolic-ref setting, a console window says:
				/// Rename from HEAD.lock to HEAD failed. Should I try again?
				/// 
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(depo);

				nilnul.fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(depo, _oldHead);
				Trace.TraceInformation($"setted head to original @ {depo}");

				throw new Exception($"when commiting pier for head:{_oldHead} at {depo}:", ex);
			}



			var tag = $"{bakOverhead}";
			///now we have a snap, it's doable to tag it;
			/// todo:
			///		find a tag
			///			,latest of given nob
			///			, snap is hence
			///			, tree is same with this one.
			///

			var verName = "ver";

			var oldTagFound = _Tag4child0Nul_0depo_1regex4tag_2ver8regex(
				depo, @$"\A{Regex.Escape(batchNob)}(?'{verName}'\d*){bakTagSuffix}\z", verName, git: git
			);
			/*
			#if false

						var oldTags = nilnul.fs.git.depo.repo.tags._VwX._Names_0depo(depo, git).Select(
							t => Regex.Match(
								t,
								@$"\A{Regex.Escape(batchNob)}(?'{verName}'\d*){bakTagSuffix}\z"
							)
						).Where(m => m.Success).ToArray();

						bool useOldTag = false;
						string latestTagName = null;

						if (oldTags.Any())
						{
							var latest = oldTags.Aggregate(
								(m, m1) => long.Parse(m.Groups[verName].Value) <= long.Parse(m1.Groups[verName].Value) ? m1 : m
							);
							latestTagName = latest.Value;


							// get parents of current commit

							var parents = nilnul.fs.git.depo.repo.snap_.current.parents._VwX._Parents_0depo(depo, git);

							var parentsOfOldTag = nilnul.fs.git.depo.repo.tag.snap.parents._VwX._Parents_0depo(
								depo, latestTagName, git
							);

							/// are the two the same?
							///
							if (nilnul.set.Eq<string>.Unison.Equals(parents, parentsOfOldTag))
							{
								/// tree is the same?
								///

								if (
									nilnul.fs.git.depo.repo.tree.eq_._ByTag9currentX._DestinationsSame_0depo_1tag(depo, latestTagName, git)
								)
								{
									useOldTag = true;
									//return latestTagName;
								}
							}


						}
			#endif
			*/

			if (oldTagFound is null)
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

			fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(depo, _oldHead); // we need to remove the tmp branch; so here we set to another reference.
			#region do we need to update index?
#if false
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(
				depo
				,
				$"update-index {bakBatch}-pier"
			);


#endif
			#endregion
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


			return oldTagFound ?? tag;




		}
	}
}
