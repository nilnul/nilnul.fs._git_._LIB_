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
	static public class _Split4largeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <exception cref="documents_.upsert_.xpn_.BeyondQuotaException"
		static public void _XpnIfBeyondQuota_assumeModule(
			string module, nilnul.win.prog_.Git git=null
		) {

			var nonlinkFileEs=_UpsertX.Document0linkEs(module, git).Select(
				d=>
nilnul.fs.address_.Spear.Parse( 
						System.IO.Path.Combine(module,d))
					
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

			var upperBoundInMb = svrs_._aagg.LimitInMbyteX.Push * .9;

			var currentRepoSizeInMbytes =
				//nilnul.fs.git.module.repo._SizeX.Kb_addressAssumeModule
				nilnul.fs.git.module.repo.size_._StdSynX.Kb_addressAssumeModule
				(
				module,git
			)/1024+1;

			var sumOfPushInMb = nonlinkFileEs.Select(t => t.Length).Sum() / 1048576 +1;

			if ( sumOfPushInMb>= upperBoundInMb )
			{
				throw new documents_.upsert_.xpn_.BeyondQuotaException(
					$"size({sumOfPushInMb}Moctets) of the coming commit of {module} is greater than {upperBoundInMb}Mb set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Push)}"
				);
			}
			var totalSizeInMb = sumOfPushInMb + currentRepoSizeInMbytes;
			if ( totalSizeInMb >= svrs_._aagg.LimitInMbyteX.Repo)
			{
				throw new documents_.upsert_.xpn_.BeyondQuotaException(
					$"total size({totalSizeInMb}MB) of repo:{module} after the commint commit will be greater than {svrs_._aagg.LimitInMbyteX.Repo}Mb set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Repo)}"
				);

			}

			var blobUpperInMb = ((long) ( svrs_._aagg.LimitInMbyteX.Blob * .9 ) )* 1048576;

			nonlinkFileEs.Where(
				d =>
				d.Length >=blobUpperInMb
			).ForEach(
				t=>
				nilnul.fs.file.split_._ThinToeX._Folder0nul_Split1drop_assumeFile_assumePositive(
					t.Item1
					,
					blobUpperInMb
				)
			);

		}


	}
}
