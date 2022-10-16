using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;
using nilnul.win.prog_;

namespace nilnul.fs.git.folder_.git_
{
	/// <summary>
	/// a module's work (no embed repo),
	/// or
	/// bare repo
	/// or
	/// a folder that can be convertable to module
	///		such as:
	///		plain / work
	///		
	///	excluding:
	///		repo in module
	/// </summary>
	public class NotEmbedRepo
		:
		nilnul.fs.folder.be_.git_.repo.embed.anto.vow.En
	{
		public NotEmbedRepo(Folder val) : base(val)
		{
		}

	
	}
}
