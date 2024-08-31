namespace nilnul.fs.git.depo.repo.snap.expr_
{
	/// <summary>
	/// e.g. master@{yesterday}, HEAD@{5 minutes ago}
	/// note  the time can be:
	/// e.g. {yesterday}, {1 month 2 weeks 3 days 1 hour 1 second ago}
	/// {1979-02-26 18:30:00}
	///
	/// the ref must have an existing log ($GIT_DIR/logs/<ref>);
	/// this looks up the state of your local ref at a given time; e.g., what was in your local master branch last week.
	/// </summary>
	/// <remarks>
	///  If you want to look at commits made during certain times, see --since and --until.
	/// </remarks>
	interface ITimed { }

}
