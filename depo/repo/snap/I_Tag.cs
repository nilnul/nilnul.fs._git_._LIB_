namespace nilnul.fs.git.depo.repo.snap
{
	/// <summary>
	/// we have to make that <see cref="fs.git.depo.repo.Tag"/> to inherit this, to mean that repo.tag is in fact repo.snap.tag; but per nilnul dev naming rules, namespaces parent type shall be not a subtype of the namespace descendent. So here we use _Tag as as the sup type of <see cref="fs.git.depo.repo.Tag"/>;
	/// </summary>
	interface I_Tag { }
}
