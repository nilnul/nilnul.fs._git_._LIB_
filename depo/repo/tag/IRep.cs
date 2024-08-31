using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tag
{
	internal class IRep
	{
		/*
		 <rev>^{tag} can be used to ensure that <rev> identifies an existing tag object.
		 */

		/*
		 <rev>^{object} can be used to make sure <rev> names an object that exists, without requiring <rev> to be a tag, and without dereferencing <rev>; because a tag is already an object, it does not have to be dereferenced even once to get to an object.
		 */
	}
}
