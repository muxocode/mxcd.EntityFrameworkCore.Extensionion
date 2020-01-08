using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.contextExtended.model
{
    internal interface ITableData
    {
        string Table { get; }
        string Schema { get; }
        IEnumerable<string> Properties { get; }
        IEnumerable<string> Keys { get; }
    }
}
