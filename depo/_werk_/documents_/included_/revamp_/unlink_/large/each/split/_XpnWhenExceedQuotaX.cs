using nilnul.fs.address_.spear;
using nilnul.fs.file;
using nilnul.fs.git.depo.werk;
using nilnul.fs.git.module._work_.documents_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_.included_.nonlink_.large.each.split
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(documents_.included_.unlink_.large.each.split._XpnWhenExceedQuotaX),true)]
	static public class _XpnWhenExceedQuotaX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <exception cref="documents_.upsert_.xpn_.BeyondQuotaException"
		static public void _XpnIfBeyondQuota_0depo(
			string module, nilnul.win.prog_.Git git = null
		)
		{



			//var included = _IncludedX._Documents_0depo(module, git);

			var nonlinks = _LinklessX._Document9info9sizeEs_0depo(module, git).ToArray();


			var larges = _LargeX._Document9info9sizeEs_0includedNonlinks(
				nonlinks
				, out var threshold
				, git
			).ToArray();

			var revampedExceptLarge = _UpsertX.Document0linkEs(module, git).Except(
				//for those split, they are not taken as large
				larges.Select(l => l.document)  // in case they are in upsert; as we will split them later, hence we here unlist them.
			).Select(
				d =>
				{

					(string document, FileInfo info, long size) found = nonlinks.Where(x => x.document == d).SingleOrDefault();
					if (found.document is null)
					{
						return (d, _BakX.SYMLINK_SIZE);
					}

					return (d, size: found.size);

				}).ToArray();/// a barrier is needed here to avoid intermingled git run.


			var currentRepoSizeInMbytes =
				//nilnul.fs.git.module.repo._SizeX.Kb_addressAssumeModule


				(nilnul.fs.git.module.repo.size_._StdSynX.Kb_addressAssumeModule
				(
				module, git
			) + 1023) / 1024;

			var sumOfPushNonlarge = revampedExceptLarge.Sum(t => t.size);


			/// as we now can push in batches, the following is not a concern now.
			//if ( sumOfPush>= upperBound )
			//{
			//	throw new documents_.upsert_.xpn_.BeyondQuotaException(
			//		$"size({sumOfPush}octets) of the coming commit of {module} is greater than {upperBound}bytes set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Push)}"
			//	);
			//}

			var totalSizeInMb = currentRepoSizeInMbytes
				+ (
					(
						(
							sumOfPushNonlarge
							+
							 larges.Sum(l => l.size)
						 )
						 +
						 (nilnul.num_.radix_.binary_.Mega.INT32 - 1)
					 )
					 /
					 nilnul.num_.radix_.binary_.Mega.INT32

				 )
			;

			if (totalSizeInMb
				>
				fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInMoctets
			/*
			svrs_._aagg.LimitInMbyteX.Repo *
			0.9	// we allow some misc files to be added;
			*/
			)
			{// exception rather than split it, if we cannot handle that
				throw new module._work_.documents_.upsert_.xpn_.BeyondQuotaException(
					$"total size({totalSizeInMb}MB) of repo:{module} after the comming|next commit will be greater than or equal to{fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInMoctets} MB (around {svrs_._aagg.LimitInMbyteX.Repo}Mb set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Repo)} );"
				);

			}

			_SplitX._SplitLarge_0larges(
				larges.Select(l => l.info)
				,
				threshold
				,
				git
			);



		}


	}
}
