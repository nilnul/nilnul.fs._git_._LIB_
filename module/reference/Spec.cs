using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.@ref
{
	/*refspec>…​ 
Specify what destination ref to update with what source object. The format of a <refspec> parameter is an optional plus +, followed by the source object <src>, followed by a colon :, followed by the destination ref <dst>.


The <src> is often the name of the branch you would want to push, but it can be any arbitrary "SHA-1 expression", such as master~4 or HEAD (see gitrevisions[7]).


The <dst> tells which ref on the remote side is updated with this push. Arbitrary expressions cannot be used here, an actual ref must be named. If git push [<repository>] without any <refspec> argument is set to update some ref at the destination with <src> with remote.<repository>.push configuration variable, :<dst> part can be omitted—​such a push will update a ref that <src> normally updates without any <refspec> on the command line. Otherwise, missing :<dst> means to update the same ref as the <src>.


The object referenced by <src> is used to update the <dst> reference on the remote side. By default this is only allowed if <dst> is not a tag (annotated or lightweight), and then only if it can fast-forward <dst>. By having the optional leading +, you can tell nilnul.win.prog_.Git to update the <dst> ref even if it is not allowed by default (e.g., it is not a fast-forward.) This does not attempt to merge <src> into <dst>. See EXAMPLES below for details.


tag <tag> means the same as refs/tags/<tag>:refs/tags/<tag>.


Pushing an empty <src> allows you to delete the <dst> ref from the remote repository.


The special refspec : (or +: to allow non-fast-forward updates) directs nilnul.win.prog_.Git to push "matching" branches: for every branch that exists on the local side, the remote side is updated if a branch of the same name already exists on the remote side.
*/
	/// <summary>
	/// 
	/// </summary>
	class Spec
	{
	}
}
