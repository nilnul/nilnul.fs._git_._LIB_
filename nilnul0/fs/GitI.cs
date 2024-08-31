using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs
{
	/// <summary>
	/// this is: 
	///		a file system with version control; together with some programs
	///		a system that involves client and server. in this sense we can have both local program/data and comminuncation with remote andlocal
	///		git.program (for local program)
	///		git.module(
	///			local folder initiated for git version control
	///		)
	///		git.svr
	///		git.svr.client or just git.client
	///	because the local module will only make sense when a git program is running, so nilnul.win.prog_.Git can act as git.Program
	/// an open-source/third-party version control software that is used to process file/folders
	///
	/// </summary>
	/// todo: use libgit2sharp instead of git cli?
	///		,git cli:
	///			,as long as the tool is robust avaible, we have it
	///			,and, the tool and our lib have the same behavior
	///		,libgit
	///			, more robust
	///			, easier to debug
	///			, deep adaption or change is possible, after all, it's written in C#;
	///			, as long as the lib is consistent with the git cli, we have too the same behavior.
	public interface GitI
	{

	}
}
