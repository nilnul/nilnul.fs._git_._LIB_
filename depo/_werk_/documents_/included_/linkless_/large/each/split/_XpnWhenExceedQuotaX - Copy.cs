using nilnul.fs.address_.spear;
using nilnul.fs.file;
using nilnul.fs.git.depo._werk_.documents_.included_.nonlink_;
using nilnul.fs.git.depo._werk_.documents_.included_.nonlink_.large.each;
using nilnul.fs.git.depo.werk;
using nilnul.fs.git.module._work_.documents_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.documents_.included_.unlink_.large.each.split
{
	/// <summary>
	/// 
	/// </summary>
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



			var included = dossiers_._IncludedX._Denotion9spearEs_0depo(module, git)

				.ToArray();



			var unlink0linkS = included.Select(
				p => (included:p, symlink: nilnul.fs.folder.destiny.be_._ReparseX._Be_0folder_1destiny(
					module, p.denote
				))
			).ToArray();

			var infos= unlink0linkS.Select(
				t =>(
					t.included
					,
					info: t.symlink? null:new FileInfo(t.included.spear)

				)
			).ToArray();

			var totalSize2 = infos.Sum(
				i=>i.info is null ? _BakX.SYMLINK_SIZE : i.info.Length
			);

			if (totalSize2
				>
				fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInOctets
			)
			{
				throw new module._work_.documents_.upsert_.xpn_.BeyondQuotaException(
					$"total size({totalSize2}bytes) of werk:{module} will be greater than {fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInMoctets} MB (around {svrs_._aagg.LimitInMbyteX.Repo}Mb set by {typeof(svrs_._aagg.LimitInMbyteX).FullName}.{nameof(svrs_._aagg.LimitInMbyteX.Repo)} );"
				);
			}


			var unlinks = infos.Where(
				p => p.info is not null
			).ToArray();

	

			long v = nilnul.fs.git.depo._werk_.documents_.included_.nonlink_._LargeX._GetThreshold();

			var larges1 = unlinks.Where(
					i => i.info.Length > v
				);

			_SplitX._SplitLarge_0larges(
				larges1.Select(i=>i.info)
				,
				v
				,
				git
			);



		}


	}
}
