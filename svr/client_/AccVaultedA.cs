using System;
using System.Configuration;

namespace nilnul.fs.git.svr.client_
{
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	public abstract class AccVaultedA : AccVaultedI
	{
		public abstract string credKey4push { get; }

		public abstract ClientI genClient();

		//public abstract string createRepo(string repo);
		public abstract string gitUrl(string repo);
	}

}
