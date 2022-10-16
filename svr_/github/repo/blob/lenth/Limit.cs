using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.repo.blob.lenth
{
	public class Limit
	{
		
		/// err msg, even for ssh:
		/// this exceeds GitHub's file size limit of 100.00 MB, as of 220821
		///File revisionOfRequirement4(froJia/yanlian/changjing/scene1/17.rar is 464.73 MB; this exceeds GitHub's file size limit of 100.00 MB
		///remote: error: File revisionOfRequirement4(froJia/yanlian/changjing/scene2/17.rar is 459.92 MB; this exceeds GitHub's file size limit of 100.00 MB
		/// <summary>
		/// 
		/// </summary>
		public const int InMbyte = 100;
	}
}
