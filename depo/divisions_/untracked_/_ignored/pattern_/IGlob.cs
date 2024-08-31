using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.divisions_.untracked_._ignored.pattern_
{
	///linux.die.net/man/7/glob
	///
	///POSIX.2, 3.13
	///
	/// , interprets anything into some meaning. try to never report error; in otherwords, "err like" is interpreted as a special meaning|purpose.
	/// <summary>
	///  A '/' in a pathname cannot be matched by a '?' or '*' wildcard, or by a range like "[.-0]". A range cannot contain an explicit '/' character; this would lead to a syntax error.
	///
	/// If a filename starts with a '.', this character must be matched explicitly
	/// 
	/// ?,* if not betwee []
	/// [sth], where the string enclosed by the brackets cannot be empty; therefore ']' can be allowed between the brackets, provided that it is the first character, eg:  []]
	///		,and [][!] meaning "][!"
	///
	/// "[ -%]" stands for "[ !"#$%]", note the space character in the beginning.
	/// []-] means ']' or '-'
	/// [--0] matches one of "-.0", as in ascii, "-./0" is a slice, and '/' cannot be matched.
	///
	/// [!sth], eg: [!]a-] matches any single character except ']', 'a' and '-'.
	///
	/// 
	/// One can remove the special meaning of '?', '*' and '[' by preceding them by a backslash, or, in case this is part of a shell command line, enclosing them in quotes.
	/// Between brackets these characters stand for themselves. Thus, "[[?*\]" matches the four characters '[', '?', '*' and '\'.
	/// </summary>
	/// vs:Regex
	///		Note that wildcard patterns are not regular expressions, although they are a bit similar. First of all, they match filenames, rather than text, and secondly, the conventions are not the same: for example, in a regular expression '*' means zero or more copies of the preceding thing.
	///		
	internal class IGlob
	{
	}
}
