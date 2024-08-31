using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_
{
	public class Unlink : nilnul.fs.git.module.be_.unlink.vow.En
	{
		public Unlink(ModuleI module) : base(module)
		{
		}

		static public Unlink FroAddress(string address) {
			return new Unlink(
				nilnul.fs.git.Module.FroAddress(address)
			);
		}
	}
}
