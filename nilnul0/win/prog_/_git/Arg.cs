using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace nilnul.win.prog_._git
{
	extern alias character;
	/// <summary>
	/// the argument in git. quoted, or no space
	/// </summary>
	public class Arg
		 : nilnul.obj.be.vow.Ed_beDefaultable<string, _arg.txt.Be>
	{
		public Arg(string val) : base(val)
		{
		}

		public override string ToString()
		{
			if (ed.StartsWith("\""))
			{
				return ed.Substring(1);
			}
			return ed;
		}

		/*(these are subtly different in multiple ways). In some cases this means the fastest way is to use the middle command. (Incidentally, the -- here is to make sure nilnul.win.prog_.Git can distinguish between a path name and an option or branch name. For instance, if you have a file named --theirs, it will look like an option, but -- will tell nilnul.win.prog_.Git that no, it's really a path name.)*/
	}


}
