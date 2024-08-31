namespace nilnul.fs.git.depo.repo.refer.expr_
{
	/// <summary>
	/// <rev>^{<type>}, e.g. v0.99.8^{commit}
	/// ;A suffix ^ followed by an object type name enclosed in brace pair means dereference the object at <rev> recursively until an object of type <type> is found or the object cannot be dereferenced anymore (in which case, barf).
	/// </summary>
	/// <remarks>
	/// <rev>^{tree} describes the corresponding tree object.
	/// <rev>^0 is a short-hand for <rev>^{commit}.
	/// <rev>^{object} can be used to make sure <rev> names an object that exists, without requiring <rev> to be a tag, and without dereferencing <rev>; because a tag is already an object, it does not have to be dereferenced even once to get to an object.
	/// <rev>^{tag} can be used to ensure that <rev> identifies an existing tag object.
	/// </remarks>
	interface ITyped { }

}
