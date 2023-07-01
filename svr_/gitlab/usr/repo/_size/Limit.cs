using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.repo._size
{

	public class Limit
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>per
		/// https://about.gitlab.com/2015/04/08/gitlab-dot-com-storage-limit-raised-to-10gb-per-repo/
		///  including LFS.
		/// ,
		/// https://docs.gitlab.com/ee/user/admin_area/settings/account_and_limit_settings.html
		/// </remarks>
		/// ,
		public const int Gb = 10; //GB
	}
}
