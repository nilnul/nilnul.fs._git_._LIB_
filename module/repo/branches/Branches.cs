using nilnul.win.process;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module
{
	public class Branches
	{


		private nilnul.win.prog_.Git _git;

		public nilnul.win.prog_.Git git
		{
			get { return _git; }
			set { _git = value; }
		}


		private string _workspace;

		public string workspace
		{
			get { return _workspace; }
			set { _workspace = value; }
		}


		public Branches(nilnul.win.prog_.Git git, string workspace)
		{
			_git = git;
			

			_workspace = workspace;
		}
		public  void ensureBranch( string branch) {

			if (notContainBranch(branch))
			{
				createBranch(branch);
			}


		}

		public  bool notContainBranch(string branch) {

			return ! containBranch(branch);

		}


		public  bool containBranch(string branch) {

			return getBranches().Contains(branch);

		}

		/// <summary>
		/// by checkout if branches count is zero; by branch otherwise.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="module"></param>
		/// <param name="branch"></param>
		static public void _CreateBranch(nilnul.win.prog_.Git git, string module,  string branch) {

			string[] branches;
			try
			{
				branches = GetBranches_throws(module).ToArray();

				if (branches.Count() == 0)
				{

					nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
						module
						,
						"checkout -b " + branch

					);

				}
				else
				{

					 win.prog_.git.run.exitCode.vow_._NilX.OfAddress(module, "branch " + branch);
					
				}




			}
			catch (Exception)
			{


				throw;
			}



		}

		public  void createBranch( string branch)
		{
			string[] branches;
			try
			{
				branches= GetBranches_throws(workspace).ToArray();

				if (branches.Count() ==0)
				{
					nilnul.win.prog_.git.run.result._Void_throwErrX.OfAddress(
						workspace
						,
						"checkout -b "+branch	

					);
				}
				else
				{

					var result=nilnul.win.prog_.git.run._ResultX.Result_ofAddress(workspace, "branch " + branch);
					if (result.beErr)
					{
						throw new _git.ReportErrException(result.err);

					}
				}



			}
			catch (Exception)
			{
				

				throw;
			}
		}

		//static public void MoveBranch2Head() {

		//}

		/*
		 
		 git symbolic-ref HEAD refs/heads/otherbranch


If you need to commit on this branch, you'll want to reset the index too otherwise you'll end up committing something based on the last checked out branch.
git reset


			 */
		static public void Head2Branch() { }

		static public IEnumerable<string> GetBranches(string workingDir, TextWriter log, TextWriter err)
		{
			try
			{
				return GetBranches_throws(workingDir);
			}
			catch (Exception e)
			{
				err.WriteLine(
					"Error in GetBranches of " + workingDir + ": " + e.Message
				);
				return null;
				//throw;
			}
		}
		public IEnumerable<string> getBranches()
		{
			

			var result = nilnul.win.prog_.git.run._ResultX.Result_ofAddress(_workspace, "branch");
		


			if (result.beErr)
			{


				throw new _git.ReportErrException(result.err);
			}
			else
			{
				var outputBranches = result.msg.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");



				var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));
				var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

				return defaultBranch.Union(nonDefaultBranch);



			}


		}

		static public IEnumerable<string> GetBranches_throws(string workingDir)
		{
			

			var result = nilnul.win.prog_.git.run._ResultX.Result_ofAddress(workingDir, "branch");
		


			if (result.beErr)
			{


				throw new _git.ReportErrException(result.err);
			}
			else
			{
				var outputBranches = result.msg.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");



				var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));
				var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

				return defaultBranch.Union(nonDefaultBranch);



			}


		}


	}
}
