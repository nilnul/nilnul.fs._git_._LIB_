using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_._rule_
{
	/*# you can skip this first one if it is not already excluded by prior patterns
!application/

application/*
!application/language/

application/language/*
!application/language/gr/
Note
The trailing /* is significant:

The pattern dir/ excludes a directory named dir and (implicitly) everything under it.
With dir/, nilnul.win.prog_.Git will never look at anything under dir, and thus will never apply any of the “un-exclude” patterns to anything under dir.
The pattern dir/* says nothing about dir itself; it just excludes everything under dir. With dir/*, nilnul.win.prog_.Git will process the direct contents of dir, giving other patterns a chance to “un-exclude” some bit of the content (!dir/sub/).*/
	class Neg
	{
	}
}
