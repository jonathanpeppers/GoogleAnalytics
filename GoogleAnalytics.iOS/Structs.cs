using System;
using ObjCRuntime;

namespace GoogleAnalytics.iOS
{
	[Native]
	public enum GAILogLevel : nuint
	{
		None = 0,
		Error = 1,
		Warning = 2,
		Info = 3,
		Verbose = 4
	}

	[Native]
	public enum GAIDispatchResult : nuint
	{
		NoData,
		Good,
		Error
	}

	public enum GAIErrorCode : uint
	{
		NoError = 0,
		DatabaseError,
		NetworkError
	}
}
