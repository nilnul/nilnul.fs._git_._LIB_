namespace nilnul.fs.git.module.repo
{
	/*
	 * If config parameter "core.logAllRefUpdates" is true and the ref is:

one under "refs/heads/", "refs/remotes/", "refs/notes/", or
a pseudoref like HEAD or ORIG_HEAD; or
the file "$GIT_DIR/logs/<ref>" exists
then git update-ref will append a line to the log file "$GIT_DIR/logs/<ref>" (dereferencing all symbolic refs before creating the log name) describing the change in ref value.*/
	interface IRefing { }
}
