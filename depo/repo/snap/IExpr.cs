using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap
{
	/// <summary>
	/// known as commitish; and as commitish leads to tree, so it's also treeish;
	/// </summary>
	/// vs:
	///		calc, here we need to allow Variable such as HEAD that is better regarded as Var, not Calc. The cons is that we many end of undeterminated var, but that happens in git, aften leads to an err of undefinedness;
	///	alias:
	///		revision
	///			mirrors.edge.kernel.org/pub/software/scm/git/docs/gitrevisions.html#_specifying_revisions
	///		
	internal class IExpr
	{

		/*
		 
----------------------------------------------------------------------
|    Commit-ish/Tree-ish    |                Examples
----------------------------------------------------------------------
|  1. <sha1>                | dae86e1950b1277e545cee180551750029cfe735
|  2. <describeOutput>      | v1.7.4.2-679-g3bee7fb
|  3. <refname>             | master, heads/master, refs/heads/master
|  4. <refname>@{<date>}    | master@{yesterday}, HEAD@{5 minutes ago}
|  5. <refname>@{<n>}       | master@{1}
|  6. @{<n>}                | @{1}
|  7. @{-<n>}               | @{-1}
|  8. <refname>@{upstream}  | master@{upstream}, @{u}
|  9. <rev>^                | HEAD^, v1.5.1^0
| 10. <rev>~<n>             | master~3
| 11. <rev>^{<type>}        | v0.99.8^{commit}
| 12. <rev>^{}              | v0.99.8^{}
| 13. <rev>^{/<text>}       | HEAD^{/fix nasty bug}
| 14. :/<text>              | :/fix nasty bug
----------------------------------------------------------------------		 

stackoverflow.com/questions/4044368/what-does-tree-ish-mean-in-git
		
edited May 23, 2017 at 12:10
CommunityBot
answered Sep 4, 2013 at 4:38
user456814
		*/
	}
}
