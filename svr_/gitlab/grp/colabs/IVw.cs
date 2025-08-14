using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.grp.colabs
{
	/*
	 *

	stackoverflow.com/questions/31498473/gitlab-api-for-all-projects-under-group


	 
	 This gives first 20 projects in the group.

curl --header "PRIVATE-TOKEN: xxxxxxxxxxxxxxx" https://gitlab.your_namespace.com/api/v4/groups/your_group_id/projects
To get more projects we should add 'page' and 'per_page' parameter.

The below request will fetch you up to 100 projects under requested group.

 curl --header "PRIVATE-TOKEN: xxxxxxxxxxxxxxx" https://gitlab.your_namespace.com/api/v4/groups/your_group_id/projects?&per_page=100" .  
If you now want all projects, you have to loop through the pages. Change the page parameter.
	 
	 */
	/// <summary>
	/// 
	/// </summary>
	internal class IVw
	{
	}
}
