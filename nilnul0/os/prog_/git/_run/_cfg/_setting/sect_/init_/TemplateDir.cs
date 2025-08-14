using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git._run._cfg._setting.sect_.init_
{
	/// <summary>
	/// eg:
	/// git config --global init.templateDir '~/Templates/git.git'
	///
	/// #and when:
	/// echo 'ref: refs/heads/default' > ~/Templates/git.git/HEAD
	///# then: 
	/// Files and directories in the template directory whose name do not start with a dot will be copied to the $GIT_DIR after it is created.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	class TemplateDir
    {
    }
}
