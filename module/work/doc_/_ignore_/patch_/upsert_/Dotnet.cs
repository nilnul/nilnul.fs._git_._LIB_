using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_.div_.top.doc.upsert_
{
	/// <summary>
	/// create the file if not exist;
	/// patch the ignore file to reflect dotnet ignores if exists
	/// </summary>
	static public class _DotnetX
	{
		static public void Exe(nilnul.fs.git._module_.TopI top)
		{
			Exe(top.top.ToString());
		}

		static public void Exe(string top)
		{
			nilnul.fs.git.module._ignore.apply_._DotNetX.Ensure(top /*todo*/);
			_dotnet._PatchX.Exe(top);

			//if (nilnul.fs.git.module._ignore.apply_._DotNetX.Ensure(top /*todo*/))
			//{

			//}
			//else
			//{
			//_dotnet._PatchX.Exe(top);

			//}
			
		}
	}
}