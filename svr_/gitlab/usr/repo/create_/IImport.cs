using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr.repo.create_
{
	/// <summary>
	/// if you import, say from github, a new project is created.
	/// </summary>
	class IImport
	{
	}

	/*forum.gitlab.com/t/create-a-new-project-in-a-group-using-api/1552
	 * by: axil, GitLab Team
 You can add more options as stated in http://doc.gitlab.com/ce/api/projects.html#create-project 2.7k

for example:

curl --header "PRIVATE-TOKEN: gDGnJwv56z2Xfj2B83Es" -X POST "https://gitlab.com/api/v3/projects?name=foobartest&issues_enabled=false"



	&description=This%20is%20a%20description

	note: the percent encoding;

	*/
	interface IOptions { }
}
