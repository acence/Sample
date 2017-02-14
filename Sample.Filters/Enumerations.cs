using System;

namespace Sample.Filters
{
	public enum FilterStatementConnector { And, Or }
	
	public enum FilterOperation
	{
        Equals,
        Contains,
        StartsWith,
        EndsWith,
        NotEquals,
        GreaterThan,
        GreaterThanOrEquals,
        LessThan,
        LessThanOrEquals
	}
}
