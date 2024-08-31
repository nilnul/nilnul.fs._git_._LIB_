using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{

	[Obsolete(nameof(DepoI))]
	public interface ModuleI
		:
		DepoI
		,
		_module_.TopI
		,
		IModule
	{
		
	}
}
