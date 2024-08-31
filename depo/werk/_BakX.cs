using Microsoft.VisualStudio.Services.Common;
using nilnul.fs.file.be;
using nilnul.obj.lex_._byt.bind_.name_;
using nilnul.obj.seq.be_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk
{
	/// <summary>
	/// we will reset the stage. to avoid loss of work, this shall be called from within <see cref="stow.bak_"/>, or shelve the <see cref="depo.IPier"/> into repo in advance and restore the pier later.
	/// 
	/// </summary>
	/// <remarks>
	/// This is called from <see cref="fs.git.depo_.IWrought"/>
	/// ;here we don't split large files;
	/// </remarks>
	/// 
	static public class _BakX
	{
		public const int SYMLINK_SIZE = 4096;

		static string? _Old4end0Nul_0depo_1last_2regex4tag_3ver8regex(
		   string _depo
			, string lastTag
		   ,
		   string regex4tag
		   , string verName = "ver"
		   , os.prog_.Git git = null
	   )
		{


			var oldTags = nilnul.fs.git.depo.repo.tags_._AtX._Names_0depo_1tag(_depo, lastTag, git).Select(
				t => Regex.Match(
					t,
					regex4tag
				)
			).Where(m => m.Success).ToArray();

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

			if (oldTags.Any())
			{
				var latest = oldTags.Aggregate(
					(Func<Match, Match, Match>)((a, c) =>
					{
						return p(a) < p(c) ? c : a;


					})
				);

				var latestTagName = latest.Value;

				return latestTagName;


			}
			return null;
		}


		static public List<string> _Tags_0depo_1head_2bak_3pier0nul(
			string _depo
			,
			string _oldHead
			,
			string bakBatch
			,
			string _pierRef
			,
			nilnul.os.prog_.Git git = null
		)
		{

			var batchNob = nilnul.txt_.vered._KeyX._Txt(bakBatch);

			const string suffix4werk = "-werk";

			var upperHier = $"{bakBatch}{suffix4werk}";  ///eg: bak223344554400-werk

			var tags = new List<string>();

			/// this would be the tip of the shelf
			string werkBranch = $"{upperHier}-o"; //used to move around, where 'o' means:


			/// to0do: consider using "git stash", which throws when there is no commits;
			//string _oldHead = fs.git.module.repo.current._VwX._Txt_0depo(_depo, git);
			Trace.TraceInformation($"oldHead:{_oldHead} of {_depo}");
			Trace.TraceInformation($"switching to branch {werkBranch}  for {_depo}");

			try
			{

				/// in log, when running git checkout --orphan bak2401102001140352965-werk-o @ D:\1\d\nilnul._dev_\_TEST_(Git: 128
				///, to fend off any residued *.lock;
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);

				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
					_depo,
					$"checkout --orphan {werkBranch}" //don't use switch --orphan as it may fail due to:
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

				throw new Exception($"exception {x} when: checkout --orphan {werkBranch} @ {_depo}", x);
			}


			try
			{
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);

				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(
					_depo, $"reset", git
				); /// we presume that the <see cref=""/>

			}
			catch (TaskCanceledException ex)
			{
				Trace.TraceError($" when resetting on the newly created orphan branch:{werkBranch} for {_depo}:{ex}");
				Trace.TraceInformation($"setting head to original:{_oldHead} @ {_depo}");

				/// some times, on symbolic-ref setting, a console window says:
				/// Rename from HEAD.lock to HEAD failed. Should I try again?
				/// 
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);


				fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(_depo, _oldHead
					, git
					); // succeed even if there is .git/config.lock
				Trace.TraceInformation($"setted head to original:{_oldHead} @ {_depo}");
				throw new Exception($"when resetting on orphan branch:{werkBranch} @ {_depo}, possible lock doesnot dissappear in a given time:", ex);


			}
			catch (Exception ex)
			{
				Trace.TraceError($" when resetting on the newly created orphan branch for {_depo}:{ex}");
				Trace.TraceInformation($"setting head to original @ {_depo}");

				/// some times, on symbolic-ref setting, a console window says:
				/// Rename from HEAD.lock to HEAD failed. Should I try again?
				/// 
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);

				fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(
					_depo, _oldHead
					, git
				);
				Trace.TraceInformation($"setted head to original @ {_depo}");
				throw new Exception($"when resetting on orphan branch @ {_depo}:", ex);
			}

			#region upserted werk relative to:
#if false
			var documents = nilnul.fs.git.module._work_.documents_._UpsertX.Document0linkEs(
				_depo
			); // excluding symlinks
			var untracked = nilnul.fs.git.depo._werk_.dossiers_.untracked_._UnignoredX._GetDossiers_0depo(_depo);

#endif
			#endregion


			var included = nilnul.fs.git.depo._werk_.dossiers_._IncludedX._Denotions_0depo(_depo, git);


			//var sized = new Dictionary<string, long>();

			//included.Each(
			//   d => sized.Add(d, allowed_0document(d))
			//  );


			var document9parentEs = included.Select(
				x => (
				document: x
				,
				div: _GetDiv_0document(x).Replace('\\', '/')
				)
			).ToArray();

			static string _GetDiv_0document(string document)
			{
				var r = System.IO.Path.GetDirectoryName(document);
				if (r == string.Empty)
				{
					return r; // the div now is "";
				}

				return r + System.IO.Path.DirectorySeparatorChar;

				//return nilnul.txt.op_.unary_.fs_.EnsureEndWithDirSep.Singleton.op(
				//	System.IO.Path.GetDirectoryName(document)
				//);
			}

			var grouped = document9parentEs.GroupBy(
				d => d.div
			).ToArray();


			var forestBuilder = new nilnul.rel_.net_._taxonomy.ForestBuilder<string>(
				(x, y) =>
				y.StartsWith(x) // && y != x
			);

			var keys = grouped.Select(g => g.Key);

			var div8set = new nilnul.txt.Set(
				keys
			//document9parentEs.Select(d => d.div)
			);


#if nonexist_root_would_later_entail_xpn
			#region add a virtual root
			div8set.Add(
				""
			);

			#endregion
#endif

			div8set.Each(
				d => forestBuilder.add(
					d
				)
			);



			long batchMax = 512l * nilnul.num_.radix_.binary_.Mega.INT32;

			List<List<string>> batches = new();

			//rel_.net_._tree.Unconstrained<string> tree4div = forestBuilder.SingleOrDefault();
			//if (tree4div is null)
			//{
			//	return [];
			//}
			//procTree(tree4div);

			forestBuilder.Each(
				t => procTree(t)
			);


			void procTree(rel_.net_._tree.Unconstrained<string> tree)
			{

				var r = procTreeRecur(tree, new List<string>(), 0);

				var d = r.documents;

				if (d.Any())
				{
					batches.Add(d);
				}

			}

			(List<string> documents, long size) procTreeRecur(
				rel_.net_._tree.Unconstrained<string> tree, List<string> current, long totalSize
			)
			{
				foreach (var child in tree.children)
				{
					var x = procTreeRecur(child, current, totalSize);

					current = x.Item1;
					totalSize = x.size;
				}

				//var docsFirst = current;

				//var remainedSize = batchMax - totalSize;

				var batches4docs = new List<List<string>>();
				var current4docs = new List<string>();
				var totalSize4docs = 0l;

				//add doc;
				/// docs act as a separator if thick enough, or a padding when not;
				foreach (
					var doc in grouped.Single(g => g.Key == tree.root).OrderBy(
						d => allowed_0document(d.document))
				)
				{

					var doc8document = doc.document;
					//get the size.

					var allowedSize = allowed_0document(doc8document); //some doc might size 0;

					var totalSize2be = totalSize4docs + allowedSize;

					if (totalSize2be <= batchMax)
					{
						current4docs.Add(doc8document);
						totalSize4docs = totalSize2be;
					}
					else
					{
						batches4docs.Add(current4docs);
						current4docs = new List<string>() { doc8document };
						totalSize4docs = allowedSize;
					}

				}

				/// now let's see whether docs would fit into previous:
				var batches4docsCount = batches4docs.Count;
				if (batches4docsCount == 0)
				{

					totalSize += totalSize4docs;

					if (totalSize <= batchMax)
					{
						/// glue to previous, open to next2glue;
						///

						if (current.Any()) //either can be empty;
						{
							current.AddRange(current4docs);

						}
						else
						{
							current = current4docs; // for perf
						}
					}
					else
					{

						//now the sum of sizes are greater, that means neither is empty;
						// unglue from previous.

						batches.Add(current);

						//batches.Add(batches4docs.First());
						batches.Add(current4docs);
						// closed for next .

						current = new List<string>();
						totalSize = 0;

					}
				}
				else
				{
					//unglue from previous:
					if (current.Any()) // some doc might 0-sized;
					{
						batches.Add(current);
					}

					batches.AddRange(
						batches4docs
					);

					batches.Add(current4docs); //shut from next;

					current = new List<string>();
					totalSize = 0;
				}
				return (current, totalSize);
			}

			long allowed_0document(string file)
			{
				return allowed(System.IO.Path.Combine(_depo, file));
			}


			long allowed(string file)
			{
				if (
					/// it might be folder that is symlink
					nilnul.fs.location.be_.Symlink._Be_0location(
						file
					)
				)
				{
					return SYMLINK_SIZE;
				}
				return new System.IO.FileInfo(
					file
				).Length;
			}

			var infix4batch = $"{suffix4werk}-batch-";

			var tag4batchPrefix =
				$"{bakBatch}{infix4batch}"

				//$"{upperHier}-batch-"

				;
			const string verName = "ver";



			try
			{
				for (int i = 0; i < batches.Count; i++)
				{
					//batches[i].Each(
					//	d => nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX.OfAddress(
					//		_depo
					//		,
					//		new[] {
					//	$"add"
					//	,
					//	d
					//		},
					//		git
					//	)
					//);

					batches[i].Batch(20).Each(
						d =>
						{
							///some times, a console window says that: "Rename from index.lock to index failed.Should I try again?"
							/// or in log:
							/// fatal: Unable to write new index file;cod:128;
							nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);

							nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX._Vow_0worksite(
														_depo
														,
														git
														,
														new[] {
								$"add"
								,
								"--"	/// will this accomodate destiny that begins with "-" or "--"
														}.Concat(
															d
														)
													);
							Thread.Sleep(1000);
						}
					);/// add the same time to avoid index.lock being latently unlocked, emitting "unable to write index file" error;
					  /// todo: thread.sleep? add by subbatching?

					  ///commit, then push
					  ///
					nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);


					/// todo: shown in console?
					nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX.OfAddress(
						_depo
						,
						$"commit -m\"batch{i} commited\""
						, git
					);


					var oldTags = nilnul.fs.git.depo.repo.tags._VwX._Names_0depo(_depo, git).Select(
						t => Regex.Match(
							t,
							@$"\A{Regex.Escape(batchNob)}(?'{verName}'\d*){infix4batch}{i}\z"
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
							_depo, latestTagName, git
						).ToArray();

						/// are the two the same?
						/// todo: child of the previous tag.
						if (parentsOfOldTag.Take(2).Count() == (i == 0 ? 0 : 1))
						{
							/// tree is the same?
							///

							if (
								nilnul.fs.git.depo.repo.tree.eq_._OfTag9currentX._DestinationsSame_0depo_1tag(_depo, latestTagName, git)
							)
							{
								latestTagName0Nul = latestTagName;
								//useOldTag = true;
								//return latestTagName;
							}
						}


					}


					if (latestTagName0Nul is null)
					{

						var tag4batch = $"{tag4batchPrefix}{i}";

						nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX.OfAddress(
							_depo
							,
							$"tag {tag4batch}"
							, git
						);
						tags.Add(tag4batch);
					}
					else
					{
						/// some times, on reset, a console window says, after listing unstaged entries:
						/// Rename from index.lock to index failed. Should I try again?
						/// 
						nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);

						string arg = $"reset tags/{latestTagName0Nul}";
						try
						{

							//nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX.OfAddress
							nilnul.os.prog_.git.run_.exit.cod.vow_.nil_._CustomXpnX.OfAddress( // use this to show the console, lest the 'onDue' exit early
								_depo
								,
								arg
								, git
							); // what does this mean?
						}
						catch (Exception x)
						{

							throw new Exception($"{x} when {arg} @ {_depo};", x);
						}

						tags.Add(latestTagName0Nul);
					}
				}

			}
			catch (Exception)
			{
				restore();
				throw;
			}
			if (tags.Any()) //tag needs a snap;
			{

				var suffix = "end";
				/// the old tag must be pointing to current.

				var oldTag4end = _Old4end0Nul_0depo_1last_2regex4tag_3ver8regex(
					_depo
					,
					tags.Last()
					,
					$@"\A{batchNob}(?'{verName}'\d*){infix4batch}{suffix}\z"

					,
					git: git
				);

				// _Tag4current0Nul_0depo_1regex4tag_2ver8regex(
				//	_depo
				//	,
				//	$@"\A{batchNob}(?'{verName}'\d*){infix4batch}{suffix}\z"

				//	,
				//	git: git
				//);


				if (oldTag4end is null)
				{
					var tag4batch = $"{tag4batchPrefix}{suffix}";

					nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX.OfAddress(
						_depo
						,
						$"tag {tag4batch}"
						, git
					);

					tags.Add(tag4batch);


				}
				else
				{
					tags.Add(oldTag4end);
				}

			}
			/// the tags shall be ordered, as the last ones may accumulate previous work if it's not pushed, into a too large push;

			Trace.TraceInformation($"added and committed all changes at branch:{werkBranch} for: {_depo}");


			#region make a tmp branch such that we can step back with the tip therein moving, without affecting current branch or others
			///create temp branch to backoff
			//Trace.TraceInformation($"creating temp branch:{fixedBranch} @ {_depo}");
			///
			//try
			//{

			//	nilnul.win.prog_.git.run.exitCode.vow_._NilX._Vod_0address_1argument_2xpn(
			//		_depo
			//		,
			//		$"checkout -b {fixedBranch}", $"exception when checkout -b {fixedBranch} @{_depo}", git); // as the below operation might move current branch, hence we create new one without worrying about moving other branch;

			//}
			//catch (Exception)
			//{
			//	restore();

			//	throw;
			//}

			//Trace.TraceInformation($"created temp branch{fixedBranch}  @ {_depo}");
			#endregion

			string fixedBranch = $"{upperHier}-clan"; // werkBranch;// upperHier + "-_reset-0";
													 //nilnul.txt_._GuidX.Construct_noHyphen(Guid.NewGuid());


			///github wont show a repo when there is no branch but tags;
			try
			{
				/// some times, a console shows that:Rename from config.lock to config failed, and asks user to confirm whether to try again. Hence, here we insert the following line:
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);

				var nonblanks = nilnul.fs.git.depo.repo.snap.henceforth.branchs._VwX._Nonblanks_0depo_1branch(_depo, werkBranch, git);

				int v = nonblanks.Take(2).Count();
				if (
					v
					<
#if DEBUG
2
#else


					2
#endif
				)
				{

					nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX._Vod_0address_1argument(
						_depo,
						$"branch {fixedBranch} refs/heads/{werkBranch}"		/// 'refs/heads/' is for reducing ambiguity;
						, git);
				}
				//if (v >= 3)
				//{
				//	nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX._Vod_0address_1argument(_depo, $"branch -D {fixedBranch}", git);
				//}

			}
			catch (Exception x)
			{
				restore();
				throw new fs.git.repo.act_.xpn_.FsAccessDenied(
					$"deleting branch:{werkBranch} at {_depo} failed, cuz that, say, some file is already occupied as explained in: could not delete reference refs/heads/_2301061150396684925: unable to create file D:/13/d/nilnul._plant_/eg_(Git/water_(Git/fresh_(Git/surface_(Git/.git/packed-refs.new: File exists;", x
				);
			}


			#region restore head

			Trace.TraceInformation($"backtracking head  @ {_depo}");
			///change the index to the HEAD~   , which is the commited stage;
			///also moved branch



			void restore()
			{
				if (_pierRef is not null)
				{
					nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);
					nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(_depo, $"reset {_pierRef}", git); // also moving the resetBranch

				}

				Trace.TraceInformation($"setting head to original  @ {_depo}");

				//// avoid the lock of files in .git such as head.lock or index.lock
				///

				/// some times, on symbolic-ref setting, a console window says:
				/// Rename from HEAD.lock to HEAD failed. Should I try again?
				/// 
				nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);

				fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(_depo, _oldHead, git);
				if (_pierRef is null)
				{
					nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due._ForceX._Vod_0depo(_depo);
					nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(_depo, $"reset", git); // also moving the resetBranch
				}
				else
				{
					/// todo: in the old stage, there might be files added previously, but changed (eg:deleted due to the splitting of large files) from werk. We might need to update-index?
				}



				Trace.TraceInformation($"setted head to original  @ {_depo}");
			}

			restore();


			Trace.TraceInformation($"backtracked  @ {_depo}");

			#endregion


#if remove_branch_for_bak || true
			Trace.TraceInformation($"removing tmp branch {werkBranch} @ {_depo}");

			//// avoid the lock of files in .git such as head.lock or index.lock
			///
			try
			{
					nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX._Vod_0address_1argument(
						_depo
						,
						$"branch -D {werkBranch}"
						,
						git);

			}
			catch (Exception x)
			{
				throw new Exception($"xpn when dropping tmp branch:{werkBranch}", x );
			}

			Trace.TraceInformation($"removed tmp branch {werkBranch} @ {_depo}");
#endif


			return tags;

		}
	}
}
