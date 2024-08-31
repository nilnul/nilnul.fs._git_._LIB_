using nilnul.fs.address_.spear;
using nilnul.fs.file;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.upsert
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(fs.git.depo.werk._BakX) + " is preferred as it also splits; this is out of favor, as archived (while not changed in werk) large file wouldnot be split;",true)]
	static public class _Split4largeX
	{
		static public long InOctets_beforeAllowance= (
			(long)(svrs_._aagg.LimitInMbyteX.Blob)
		) * nilnul.num_.radix_.binary_.Mega.INT32 // 1048576
		;

		/// <summary>
		/// after some margin;
		/// </summary>
		/// should we put this in cfg?
		/// eg:
		///		100moctets now turns 100*.98 moctets;
		static public long InOctets= ((long)(svrs_._aagg.LimitInMbyteX.Blob * .98)) * nilnul.num_.radix_.binary_.Mega.INT32;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <exception cref="documents_.upsert_.xpn_.BeyondQuotaException"
		static public void _XpnIfBeyondQuota_assumeModule(
			string module, nilnul.win.prog_.Git git=null
		) {

			var nonlinkFileEs= _UpsertX.Document0linkEs(module, git).Select(
				d=>nilnul.fs.address_.Spear.Parse( 
						System.IO.Path.Combine(module,d)
				)
			).Where(
				p=>nilnul.fs.address_.spear.be_.File.Singleton.be(p ) /// exclude linked folder; in git, linked folder is returned
				&&
				nilnul.fs.file.be_.Nonlink.Singleton.Be(p) // if its linked file: the size is disregarded, and we wouldnot split it.
			).Select(
				a=> new FileInfo(a.ToString())
			).Select(
				 t=>(
					t
					,
					t.Length
				)
			).ToArray();

			var upperBound = svrs_._aagg.LimitX.PushInBytes;// * .9;
			var upperBoundInMb = svrs_._aagg.LimitInMbyteX.Push;// * .9;

			var currentRepoSizeInMbytes =
				//nilnul.fs.git.module.repo._SizeX.Kb_addressAssumeModule
				nilnul.fs.git.module.repo.size_._StdSynX.Kb_addressAssumeModule
				(
				module,git
			)/1024+1;

			var sumOfPush = nonlinkFileEs.Select(t => t.Length).Sum();
			var sumOfPushInMb = sumOfPush / 1048576 +1;

			/// as we now can push in batches, the following is not a concern now.
			//if ( sumOfPush>= upperBound )
			//{
			//	throw new documents_.upsert_.xpn_.BeyondQuotaException(
			//		$"size({sumOfPush}octets) of the coming commit of {module} is greater than {upperBound}bytes set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Push)}"
			//	);
			//}

			var totalSizeInMb = sumOfPushInMb + currentRepoSizeInMbytes;
			if ( totalSizeInMb >=
				fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInMoctets
				/*
				svrs_._aagg.LimitInMbyteX.Repo *
				0.9	// we allow some misc files to be added;
				*/
			)
			{
				throw new documents_.upsert_.xpn_.BeyondQuotaException(
					$"total size({totalSizeInMb}MB) of repo:{module} after the commint commit will be greater than {svrs_._aagg.LimitInMbyteX.Repo}Mb set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Repo)}"
				);

			}

			var blobUpperInOctets = fs.git.depo._werk_.document_._large.Settings1.Default.limit8octets;// ((long) ( svrs_._aagg.LimitInMbyteX.Blob * .9 ) )* 1048576;
			if (blobUpperInOctets<1048576)
			{
				throw new ArgumentOutOfRangeException(
					$"{blobUpperInOctets} is less than 1moctets due to say misconfiguration;"
				);
			}

			nonlinkFileEs.Where(
				d =>
				d.Length >=blobUpperInOctets
			).ForEach(
				t=>
				nilnul.fs.file.split_._ThinToeX._Folder0nul_Split1drop_assumeFile_assumePositive(
					t.Item1
					,
					blobUpperInOctets
				)
			);

		}


	}
}
