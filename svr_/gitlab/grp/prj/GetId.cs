using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.grp.prj
{
	/// <summary>
	/// 
	/// </summary>
	class GetId
	{
		//	curl -v -H "Content-Type: application/json" \
		//https://gitlab.com/api/v3/projects/gitlab-org%2Fgitlab-ce
		/// where namespace and project name is seprated by "/" encoded as "%2F"
		///

		/*
		 If you know your project name, you can get the project id by using the following API:

curl --header "Private-Token: <your_token>" -X GET https://gitlab.com/api/v4/projects?search=<exact_project_name>

		You can query projects with search attribute e.g:

http://gitlab.com/api/v3/projects?private_token=xxx&search=myprojectname
https://gitlab.com/api/v4/projects?search=<exact_project_name>

		curl --header "PRIVATE-TOKEN: <your_access_token>" "https://gitlab.example.com/api/v4/search?scope=projects&search=flight"

		curl --header "PRIVATE-TOKEN: <token>" -X GET https://gitlab.com/api/v4/groups/<group_id>/search?scope=projects&search=<project_name>

		curl --header "PRIVATE-TOKEN: <your_access_token>" "https://gitlab.example.com/api/v4/groups/3/search?scope=projects&search=flight"


This will return a JSON that includes the id:

[
  {
     "id":<project id>, ...
  }
]
		 */




		/*
		 just use https://gitlab.com/api/v4/projects/gitlab-org%2Fgitlab-ce directly when you want to interact with a project.

		but somebody report 404
		 */
	}
}
