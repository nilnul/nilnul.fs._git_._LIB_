using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_._git._cfg_
{
	class Push
	{
		/*
		 


Hi Eric,

According to Trevor's  thread, there is no limit for repository size of Visual Studio Online currently. You can try to set
the command as below:
git config --global --unset http.postBuffer


Charles-Li

		 Hi Charles,

Unfortunately, that did not work.  I used nilnul.win.prog_.Git BASH and ran the unset http.postbuffer command described in your post but received the same error.  However, I ran it using the command line instead of through a Gui and received the following:


Compressing objects: 100% (27/27), done. Unable to rewind rpc post data - try increasing http.postBuffer
 Fatal: The remote end hung up unexpectedly 2.00 KiB/s
 ... 

I checked the repository online and verified that my most recent commits were not pushed. I tried creating a repository on Kiln and was able to push everything to it with no problems. After doing a bit of research I found a StackExchange post that recommended using the command:

git config --global http.postBuffer 524288000 

I did another pushed which zipped through "Writing Objects" and created what appears to be a 54mb pack. After staring at a blinking cursor for about 20 minutes it finally came back with a done message and a check of the remote repository shows all my commits were successfully pushed.

Thanks for your help, it looks like increasing the buffer is what did the trick.

		 */
	}
}
