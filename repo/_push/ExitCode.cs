namespace nilnul.fs.git.repo._push
{
	public enum ExitCode
	{
		SvrErr = 1

/*Enumerating objects: 1539, done.
Counting objects: 100% (1539/1539), done.
Delta compression using up to 4 threads
Compressing objects: 100% (1322/1322), done.
Writing objects: 100% (1539/1539), 201.92 MiB | 1.89 MiB/s, done.
Total 1539 (delta 778), reused 310 (delta 166)
fatal: the remote end hung up unexpectedly
fatal: the remote end hung up unexpectedly
error: RPC failed; HTTP 404 curl 22 Send failure: Connection was reset
Everything up-to-date
*/
/*push was rejected because its size is greater than the 5120 MB limit for pushes in this repository. Learn more at https://aka.ms/gitlimit)
! [remote rejected] */
,
		
		
		/*Git.exe push --all --progress "gitlab"

fatal: unable to access '***': Operation timed out after 300031 milliseconds with 0 out of 0 bytes received


git did not exit cleanly (exit code 128) (301063 ms @ 2018/6/10 14:34:41)
*/

		/// <summary>
		/// 
		/// </summary>
		/// 

		Unfound = 128

	}
}
