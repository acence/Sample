﻿using System;
using System.Collections.Generic;
using Sample.Filters;

namespace Sample.Filters
{
	public class FilterStatement<TPropertyType> : IFilterStatement
	{
		public FilterStatementConnector Connector { get; set; }
        public string PropertyName { get; set; }
        public FilterOperation Operation { get; set; }
        public object Value { get; set; }
		
		public FilterStatement(string propertyName, FilterOperation operation, TPropertyType value, FilterStatementConnector connector = FilterStatementConnector.And)
		{
			PropertyName = propertyName;
			Connector = connector;
			Operation = operation;
			if (typeof(TPropertyType).IsArray)
			{
				if (operation != FilterOperation.Contains) throw new ArgumentException("Only 'Operacao.Contains' supports arrays as parameters.");
				var listType = typeof(List<>);
                var constructedListType = listType.MakeGenericType(typeof(TPropertyType).GetElementType());
                Value = Activator.CreateInstance(constructedListType, value);
			}
			else
			{
				Value = value;
			}
		}
		
		public override string ToString()
        {
            return string.Format("{0} {1} {2}", PropertyName, Operation.ToString().Substring(0,2), Value);
        }
	}
}