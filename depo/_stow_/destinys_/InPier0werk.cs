using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.destinys_
{
	/// <summary>
	/// in pier or in werk.
	/// it might be:
	///		in pier but not werk. <see cref="_pier_.dossiers_.INotInWerk"/>
	///		or in werk but not in pier <see cref="_werk_.dossiers_.IUntracked"/>
	///		,or in both <see cref="_werk_.dossiers_.ITracked"/>
	/// </summary>
	internal interface IInPier0werk:IDestinies
	{
	}


}
