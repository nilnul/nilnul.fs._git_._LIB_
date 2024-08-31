namespace nilnul.fs.git.depo.repo.snap.expr_
{
	/// <summary>
	/// <rev>^{<type>}, e.g. v0.99.8^{commit}
	/// ;A suffix ^ followed by an object type name enclosed in brace pair means dereference the object at <rev> recursively until an object of type <type> is found or the object cannot be dereferenced anymore (in which case, barf).
	/// </summary>
	/// <remarks>
	/// as we are under <see cref="snap"/>, here we only are concerned about commit;
	/// for other types <see cref="repo.refer.IExpr"/>
	/// </remarks>
	interface ITyped { }

}
