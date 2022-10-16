namespace nilnul.fs.git.svr_.gitlab
{
	static public class _ClientX
	{
		/// <summary>
		/// the key used by git; we can also use this in nilnulBak, even though in latter we may later use a customized crypted one
		/// </summary>
		/// <param name="acc"></param>
		/// <returns></returns>
		static public string VaultKey(string acc) {
			return $"git:https://{acc}@gitlab.com";
		}
	}
}
