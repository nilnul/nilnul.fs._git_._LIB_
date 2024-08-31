using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/*
	 The requirements to run transcrypt are minimal:
Bash
Git
OpenSSL
...and optionally:
GnuPG - for secure configuration import/export

		You also need access to the transcrypt script itself. You can add it directly to your repository, or just put it somewhere in your $PATH:
$ git clone https://github.com/elasticdog/transcrypt.git
$ cd transcrypt/
$ sudo ln -s ${PWD}/transcrypt /usr/local/bin/transcrypt

		Initialize an Unconfigured Repository
transcrypt will interactively prompt you for the required information, all you have to do run the script within a Git repository:
$ cd <path-to-your-repo>/
$ transcrypt
If you already know the values you want to use, you can specify them directly using the command line options. Run transcrypt --help for more details.
Designate a File to be Encrypted
Once a repository has been configured with transcrypt, you can designate for files to be encrypted by applying the "crypt" filter and diff to a pattern in the top-level .gitattributes config. If that pattern matches a file in your repository, the file will be transparently encrypted once you stage and commit it:
$ cd <path-to-your-repo>/
$ echo 'sensitive_file  filter=crypt diff=crypt' >> .gitattributes
$ git add .gitattributes sensitive_file
$ git commit -m 'Add encrypted version of a sensitive file'
The .gitattributes file should be committed and tracked along with everything else in your repository so clones will be aware of what is encrypted. Make sure you don't accidentally add a pattern that would encrypt this file :-)
For your reference, if you find the above description confusing, you'll find that this repository has been configured following these exact steps.
Listing the Currently Encrypted Files
For convenience, transcrypt also adds a Git alias to allow you to list all of the currently encrypted files in a repository:
$ git ls-crypt
sensitive_file
Alternatively, you can use the --list command line option:
$ transcrypt --list
sensitive_file
You can also use this to verify your .gitattributes patterns when designating new files to be encrypted, as the alias will list pattern matches as long as everything has been staged (via git add).
After committing things, but before you push to a remote repository, you can validate that files are encrypted as expected by viewing them in their raw form:
$ git show HEAD:<path-to-file> --no-textconv
The <path-to-file> in the above command must be relative to the top-level of the repository. Alternatively, you can use the --show-raw command line option and provide a path relative to your current directory:
$ transcrypt --show-raw sensitive_file
Initialize a Clone of a Configured Repository
If you have just cloned a repository containing files that are encrypted, you'll want to configure transcrypt with the same cipher and password as the origin repository. The owner of the origin repository can dump the credentials for you by running the --display command line option:
$ transcrypt --display
The current repository was configured using transcrypt v0.2.0
and has the following configuration:

  CIPHER:   aes-256-cbc
  PASSWORD: correct horse battery staple

Copy and paste the following command to initialize a cloned repository:

  transcrypt -c aes-256-cbc -p 'correct horse battery staple'
Once transcrypt has stored the matching credentials, it will force a checkout of any exising encrypted files in order to decrypt them.
Rekeying
Periodically, you may want to change the encryption cipher or password used to encrypt the files in your repository. You can do that easily with transcrypt's rekey option:
$ transcrypt --rekey
As a warning, rekeying will remove your ability to see historical diffs of the encrypted files in plain text. Changes made with the new key will still be visible, and you can always see the historical diffs in encrypted form by disabling the text conversion filters:
$ git log --patch --no-textconv
After rekeying, all clones of your repository should flush their transcrypt credentials, fetch and merge the new encrypted files via Git, and then re-configure transcrypt with the new credentials.
$ transcrypt --flush-credentials
$ git fetch origin
$ git merge origin/master
$ transcrypt -c aes-256-cbc -p 'the-new-password'
Command Line Options
Completion scripts for both Bash and Zsh are included in the contrib/ directory.
transcrypt [option...]

  -c, --cipher=CIPHER
         the symmetric cipher to utilize for encryption;
         defaults to aes-256-cbc

  -p, --password=PASSWORD
         the password to derive the key from;
         defaults to 30 random base64 characters

  -y, --yes
         assume yes and accept defaults for non-specified options

  -d, --display
         display the current repository's cipher and password

  -r, --rekey
         re-encrypt all encrypted files using new credentials

  -f, --flush-credentials
         remove the locally cached encryption credentials and  re-encrypt
         any files that had been previously decrypted

  -F, --force
         ignore whether the git directory is clean, proceed with the
         possibility that uncommitted changes are overwritten

  -u, --uninstall
         remove  all  transcrypt  configuration  from  the repository and
         leave files in the current working copy decrypted

  -l, --list
         list all of the transparently encrypted files in the repository,
         relative to the top-level directory

  -s, --show-raw=FILE
         show  the  raw file as stored in the git commit object; use this
         to check if files are encrypted as expected

  -e, --export-gpg=RECIPIENT
         export  the  repository's cipher and password to a file encrypted
         for a gpg recipient

  -i, --import-gpg=FILE
         import the password and cipher from a gpg encrypted file

  -v, --version
         print the version information

  -h, --help
         view this help message

		 */
	static public class _TranscryptX
	{
		/// we can use 
		///			bash transcrypt
		///				-or-
		///			wsl transcrypt 
		///		to run
		///		
		///in running, we are prompted to key in password

		/// we can append an extension ".transcrypted" to a file to make it transcrypted.

		public static void CreateInstaller(nilnul.fs.FolderI folder)
		{
			System.IO.File.WriteAllText(
				new nilnul.fs.address_.spear_.ParentDoc(folder.address.en, "transcrypt").ToString()
				,
				Properties.Resources.transcrypt
			);
		}
		public const string Batch_Name = "transcrypt.bat";
		public static void CreateBatch4Setup(nilnul.fs.FolderI folder)
		{
			System.IO.File.WriteAllText(
				new nilnul.fs.address_.spear_.ParentDoc(folder.address.en,Batch_Name ).ToString()
				,
				nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(
				//$@"bash.exe transcrypt -y"
				$@"""{nilnul.win.prog_._BashX.SPEAR}"" transcrypt -y"


				,"pause"
				)


				//Properties.Resources.transcryptBat
			);
		}
		public static void CreateBatch4Setup_froRsc(nilnul.fs.FolderI folder)
		{
			System.IO.File.WriteAllText(
				new nilnul.fs.address_.spear_.ParentDoc(folder.address.en,Batch_Name ).ToString()
				,
				Properties.Resources.transcryptBat
			);
		}



		[Obsolete("may not work; need testing")]
		public static void RunInstaller(nilnul.fs.FolderI folder, string pass) {
			nilnul.win.proc_.end.cod.Vod.Singleton.vod(
				nilnul.win.prog_._BashX.SPEAR
				,
				$"transcrypt -p={pass}",
				folder
			);
				//.run_.shell_.newWin_.min_.invis_.popTitle._CodeX..cod..Vod
		}

		public static void RunBash2Setup(nilnul.fs.FolderI folder)
		{
			nilnul.win.proc_.end.cod.Vod.Singleton.vod(
				nilnul.win.prog_._BashX.SPEAR
				,
				$"transcrypt -y",
				folder
			);
				//.run_.shell_.newWin_.min_.invis_.popTitle._CodeX..cod..Vod
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folder"></param>
		/// <remarks>
		///  error code 1 if rerun
		/// </remarks>
		public static void RunBatch4Setup(nilnul.fs.FolderI folder)
		{

		

			var x = new nilnul.fs.address_.spear_.ParentDoc(folder.address.en, Batch_Name).ToString();

			nilnul.win.prog_.exT_.bat._RunX.RunInParent(x);

			
		}


		public static void PutAttribute(nilnul.fs.FolderI folder) {
			
		}

		public static void CreateInstaller(string val)
		{
			CreateInstaller(nilnul.fs.Folder.FroAddress(val));

		}

		public static void RunInstaller(string val)
		{
			RunBatch4Setup(nilnul.fs.Folder.FroAddress(val));
		}
		public static void RunBash2Setup(string val)
		{
			RunBash2Setup(nilnul.fs.Folder.FroAddress(val));
		}


		public static void CreateBatch4Setup(string val)
		{
			CreateBatch4Setup(nilnul.fs.Folder.FroAddress(val));

		}

		public static void CreateBatch4Setup_froRsc(string val)
		{
			CreateBatch4Setup_froRsc(nilnul.fs.Folder.FroAddress(val));

		}


		public static void Build(string module)
		{
			nilnul.fs.git.module._TranscryptX.CreateInstaller(module);

			nilnul.fs.git.module._TranscryptX.CreateBatch4Setup_froRsc(module);

			//nilnul.fs.git.module._TranscryptX.RunBash2Setup(module); //when running the bat in shell, normal; but in c# there will be error.

		}
	}
}
