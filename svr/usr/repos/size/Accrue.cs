using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repos.size
{
	/// <summary>
	/// the quota for the storage of each client can be amplified each period of time (eg, a day).
	/// thus the quota at a time can be computed as:
	///		A e^rt, where A is the initial quota, t is how many periods/days, r is the accrue rate. r is nonneg, such as the quota will not decrease.
	///		if r is nil, the quoto will keep constant.
	///		if r is positive, the quota will grow.
	///	when usr thinks he neglects sth, or when the settings need to be updated along with the advancing of time/tech, usr need to make minor changes. A growing quot can always nonblock such needs.
	///		r can be regarded as a constraint of flow of each timespan.
	///	how large shall r be?
	///		we recommend that the size should be set with regards to:
	///			1) a txt file size for each day.
	///			2) the initial quota will double over the life expectancy of human kind. for example,  supposing globally it's 70yrs,   then A e^(r*70) = 2A, so r=ln(2)/70 = 0.01.
	///			3) yearly growth should be less than 10%, or 5%. a fair return rate of investment.
	///		So if the initial quota is 10G, anual growth shall be 0.01. monthly growth shall be 0.000829538114346162, which is less than 0.001, which is, 10M. and daily additional growth shall be 0.00003, which is 10000M*0.00003,  which is  300k.
	///		so the daily additional growth shall be in (300k, 3M), and correspondingly the yearly additional growth shall be in (100M, 1G)
	/// </summary>
	class Accrue
	{
	}
}
