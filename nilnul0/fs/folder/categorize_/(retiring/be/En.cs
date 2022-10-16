using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;

namespace nilnul.fs.git.folder.be
{
	public class En : nilnul.obj.be.En<nilnul.fs.location_.Folder, nilnul.fs.git.folder.BeI>
	{
		public En(location_.Folder val, BeI be) : base(val, be)
		{
		}
	}
}
