namespace nilnul.fs.git.depo._pier_.dossier._meta
{
	///32-bit mode, split into (high to low bits)
	///
	/// <summary>
	///  the first 16bits are reserved by git for internal usage(computations); <see href="https://github.com/git/git/blob/7e8bfb0412581daf8f3c89909f1d37844e8610dd/cache.h#L85"/>
	///  , They *must* not overlap with any valid modes, and they *must* not be emitted to outside world - i.e.appear on disk or network.In other words, it's just temporary fields, only in memory, which we internally use, but they have to stay in-house. ( we need to padding it to int the 32bits for a computer 32strong byte anyway.). 'unused' bits must be zero.
	///  
	/// the other 16 bits are:
	///		1000	000		110100100
	///		(a)		(b)		(c)
	///		,where Part (a) is a 4-bit object type, valid values in binary are
	///			1000 (regular file)
	///			, 1010 (symbolic link)
	///			and 1110 (gitlink  ,a special type of symbolic link that points to a Git repository object); this is borrowed from classiccal unix notations, and mostly match the Linux/Unix inode bits.;
	///			
	///		Part (b) is 3-bit unused, must be zero;
	///		Part (c) is 9-bit unix permission (often expressed
	///			rw-r--r--, or rw-rw-r--
	///			,
	///			grouped in three triplet:
	///			owner(read,write,exe), group(read,write,exe),other(read,write,exe)
	///		)as where Only 0755 and 0644 are valid for regular files, Symbolic links and gitlinks have value 0 in this field.
	///		
	/// 
	/// </summary>
	/// <remarks>
	///  a mode of 0o100644 (note: it's octal; the first is a bit, the remaining char is 3bits each; total 16bits;) ('1000000 110100100'), which means it's a normal file.
	///  Other options are 0o100755 (0b1000000111101101), which means it's an executable file;
	///		and 0o120000(0b1010000000000000) , which specifies a symbolic link. 
	///		0b0100000000000000 (0o040000): Directory
	///			,shown in ls-files, but not commited;
	///		1000000110110100 (100664): Regular non-executable group-writeable file
	///		1110000000000000 (160000): Gitlink
	///
	/// 
	/// </remarks>
	/// alias:
	///		mode
	///		tag
	///		flag
	///		Meta
	///		mode
	///		kind
	enum IAccess { }


}
