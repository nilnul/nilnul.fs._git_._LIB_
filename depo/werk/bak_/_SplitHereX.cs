using Microsoft.VisualStudio.Services.Common;
using nilnul.fs.file.be;
using nilnul.obj.lex_._byt.bind_.name_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk.bak_
{
	/// <summary>
	/// not split in advance.
	/// 
	/// </summary>
	/// <remarks>
	/// This is called from <see cref="fs.git.depo_.IWrought"/>
	/// 
	/// </remarks>
	/// 
	static public class _SplitHereX
	{

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

			var upperHier = $"{bakBatch}{suffix4werk}";

			var tags = new List<string>();

			/// this would be the tip of the shelf
			string werkBranch = $"{upperHier}-o"; //used to move around


			/// to0do: consider using "git stash", which throws when there is no commits;
			//string _oldHead = fs.git.module.repo.current._VwX._Txt_0depo(_depo, git);
			Trace.TraceInformation($"oldHead:{_oldHead} of {_depo}");
			Trace.TraceInformation($"switching to branch {werkBranch}  for {_depo}");

			try
			{
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

				throw new Exception($"exception {x} when: checkout -b {werkBranch} @ {_depo}", x);
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
				fs.git.module.repo.current._AssignX._Assign_addressAssumeModule_assumeHead(_depo, _oldHead
					, git
					);
				Trace.TraceInformation($"setted head to original @ {_depo}");
				throw new Exception($"when resetting on orphan branch @ {_depo}:", ex);
			}

			#region MyRegion
#if false
			var documents = nilnul.fs.git.module._work_.documents_._UpsertX.Document0linkEs(
				_depo
			); // excluding symlinks
			var untracked = nilnul.fs.git.depo._werk_.dossiers_.untracked_._UnignoredX._GetDossiers_0depo(_depo);

#endif
			#endregion


			var included = nilnul.fs.git.depo._werk_.dossiers_._IncludedX._Denotions_0depo(_depo, git);


			var sized = new Dictionary<string, long>();

			included.Each(
			   d => sized.Add(d, allowed_0dossier(d))
		   );

			#region split

			var blobUpperInOctets = fs.git.depo._werk_.document_._large.Settings1.Default.limit8octets;// ((long) ( svrs_._aagg.LimitInMbyteX.Blob * .9 ) )* 1048576;
			if (blobUpperInOctets < 1048576)
			{
				blobUpperInOctets = 100 * nilnul.num_.radix_.binary_.Mega.INT32;
				//restore();
				
				//throw new ArgumentOutOfRangeException(
				//	$"{blobUpperInOctets} is less than 1moctets due to say misconfiguration;"
				//);
			}

			sized.Where(
				d =>
				d.Value >= blobUpperInOctets
			).Each(
				t =>
				nilnul.fs.file.split_._ThinToeX._Folder0nul_Split1drop_assumeFile_assumePositive(
					System.IO.Path.Combine(_depo, t.Key)
					,
					blobUpperInOctets
				)
			);

			#endregion
			#region file might changed. we need to refersh the included.

			included = nilnul.fs.git.depo._werk_.dossiers_._IncludedX._Denotions_0depo(_depo, git);


			sized = new Dictionary<string, long>();

			included.Each(
			   d => sized.Add(d, allowed_0dossier(d))
		   );




			#endregion

			#region check the total size

	

			var upperBound = svrs_._aagg.LimitX.PushInBytes;// * .9;
			var upperBoundInMb = svrs_._aagg.LimitInMbyteX.Push;// * .9;

			var currentRepoSizeInMbytes =
				//nilnul.fs.git.module.repo._SizeX.Kb_addressAssumeModule
				nilnul.fs.git.module.repo.size_._StdSynX.Kb_addressAssumeModule
				(
				_depo, git
			) / 1024 + 1;

			var sumOfPush = sized.Values.Sum();
			var sumOfPushInMb = sumOfPush / 1048576 + 1;

	

			var totalSizeInMb = sumOfPushInMb + currentRepoSizeInMbytes;
			if (totalSizeInMb >=
				fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInMoctets
			/*
			svrs_._aagg.LimitInMbyteX.Repo *
			0.9	// we allow some misc files to be added;
			*/
			)
			{
				restore();
				throw new module._work_.documents_.upsert_.xpn_.BeyondQuotaException(
					$"total size({totalSizeInMb}MB) of repo:{_depo} after the commint commit will be greater than {svrs_._aagg.LimitInMbyteX.Repo}Mb set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Repo)}"
				);

			}


		


			#endregion

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

			div8set.Each(
				d => forestBuilder.add(
					d
				)
			);

			rel_.net_._tree.Unconstrained<string> tree4div = forestBuilder.SingleOrDefault();

			if (tree4div is null)
			{
				return [];
			}

			long batchMax = 512l * nilnul.num_.radix_.binary_.Mega.INT32;

			List<List<string>> batches = new();

			procTree(tree4div);


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
						d => allowed_0dossier(d.document))
				)
				{

					var doc8document = doc.document;
					//get the size.

					var allowedSize = allowed_0dossier(doc8document); //some doc might size 0;

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

			long allowed_0dossier(string file)
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
					return 4096;
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
							nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX._Vow_0worksite(
														_depo
														,
														git
														,
														new[] {
								$"add"
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
						);

						/// are the two the same?
						///
						if (parentsOfOldTag.Take(2).Count() == (i == 0 ? 0 : 1))
						{
							/// tree is the same?
							///

							if (
								nilnul.fs.git.depo.repo.tree.eq_._ByTag9currentX._DestinationsSame_0depo_1tag(_depo, latestTagName, git)
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
			///
			string tempBranch = werkBranch;// upperHier + "-_reset-0";
										   //nilnul.txt_._GuidX.Construct_noHyphen(Guid.NewGuid());

			Trace.TraceInformation($"creating temp branch:{tempBranch} @ {_depo}");


			//nilnul.win.prog_.git.run.exitCode.vow_._NilX._Vod_0address_1argument_2xpn(_depo, $"checkout -b {tempBranch}", $"exception when checkout -b {tempBranch} @{_depo}", git); // as the below operation might move current branch, hence we create new one without worrying about moving other branch;

			Trace.TraceInformation($"created temp branch{tempBranch}  @ {_depo}");
			#endregion
			Trace.TraceInformation($"backtracking head  @ {_depo}");
			///change the index to the HEAD~   , which is the commited stage;
			///also moved branch


			Trace.TraceInformation($"backtracked  @ {_depo}");

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


			Trace.TraceInformation($"removing tmp branch @ {_depo}");

			//// avoid the lock of files in .git such as head.lock or index.lock
			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);

			try
			{
				nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX._Vod_0address_1argument(_depo, $"branch -D {tempBranch}", git);

			}
			catch (Exception x)
			{

				throw new fs.git.repo.act_.xpn_.FsAccessDenied(
					$"deleting branch:{tempBranch} at {_depo} failed, cuz that, say, some file is already occupied as explained in: could not delete reference refs/heads/_2301061150396684925: unable to create file D:/13/d/nilnul._plant_/eg_(Git/water_(Git/fresh_(Git/surface_(Git/.git/packed-refs.new: File exists;", x
				);
			}

			Trace.TraceInformation($"removed tmp branch  @ {_depo}");

			return tags;

		}
	}
}
