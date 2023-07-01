namespace nilnul.fs.git.svr.client_
{
	/// <summary>
	/// client (both svr and cred and all needed to access svr) excuding credential (which is stored separately in OS credential manager and would be dynamically fetched)
	/// in some cases we might include accName in client; we store only password in credential manager and the url there will include the username such as zhangsan@example.com
	/// </summary>
	//[Serializable]
	public interface AccVaultedI:svr.ClientI,IAccVaulted
	{
		/// <summary>
		/// key stored in windows vault(credential manager); we use this key to fetch password.
		/// </summary>
		string credKey4push { get; }
		//string createRepo(string repo);
		string gitUrl(string repo);

		//nilnul.fs.git.svr.ClientI genClient();
	}

}
