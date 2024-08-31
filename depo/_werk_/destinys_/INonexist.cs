namespace nilnul.fs.git.depo._werk_.destinys_
{
	/// within the scope of <see cref="werk"/>, if a file is missing, we will not not notice it. So it's not deleted, or missing. it's just nonexistant;
	/// <summary>
	/// as we are based on <see cref="_pier_"/> which in turn is also based on <see cref="repo"/>, we also consider those that might exist in <see cref="_pier_"/>
	/// </summary>
	/// <remarks>
	/// put this under <see cref="IXpn"/>, we can regard <see cref="dossiers_"/> are all existant; otherwise, we need to create <see cref="dossiers_.exist_"/>
	/// </remarks>
	/// vs:
	///		<see cref="_pier_.dossiers_.IUntracked"/> is not taken as <see cref="_pier_.dossiers_.IXpn"/>, as <see cref="pier"/> is often processed together with head, and it's not like werk visible to us directly--pier is in <see cref="depo._rack_"/>. But we can also consider to change <see cref="_pier_"/> to exclude nonexistant entries;
	///
	/// might be<see cref="tracked_.revised_.IDropped"/>
	/// or
	/// <see cref="untracked_"/> but not existant.

	interface INonexistInWerk :IDestinies { }


}
