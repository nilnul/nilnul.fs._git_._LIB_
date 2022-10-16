using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._svr
{
	public interface LimitInMbyteI
	{
		int repo { get; }
		int push { get; }
		int blob { get; }
	}
}
