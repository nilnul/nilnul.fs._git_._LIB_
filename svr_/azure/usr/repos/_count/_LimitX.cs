using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.usr.repos._count
{
	internal class _LimitX
	{
		///learn.microsoft.com/en-us/azure/devops/organizations/settings/work/object-limits?view=azure-devops#project
		///
		/// 1000
		///
		/// but the email, and the web ui when usr tries to create new when limit is reached, says it's 2000;
		/// <summary>
		/// the limit for new user is: 2000
		/// for old user, the limit might 2200;
		/// </summary>
		/// <remarks>
		/// when creating new prj, usr might receive such msg:
		///		Your organization has 1816 projects, and you are limited to having no more than 2200 projects. Learn more about project limits: https://aka.ms/projectlimits
		///	
		/// </remarks>
		/// <returns></returns>
		static public int PerCfg() {
			return fs.git.Properties.Settings.Default.svr__azure_usr_repos__count_limit;
		}
	}
}
