using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo
{
	/// <summary>
	/// bak the depo, including push branches/tags to designated remotes.
	/// </summary>
	/// <remarks>
	/// we better leave the marker interface here, but put the implementations in another separate project, as this project shall concentrate on the core|essential self-consistent functionalities of git;
	/// naming the depo is deferred to nilnul.dev.BAK; 
	/// </remarks>
	/// todo:
	///		measure each reachable|nondangling snapshot such that it wont exceed the push size of a server;
	///
	/// <see cref="fs.git.depo.stow.bak_._WerkAtOrphanX"/>
	/// <see cref="fs.git.depo.werk.IBak"/>
	internal class IBak
	{
	}
}
