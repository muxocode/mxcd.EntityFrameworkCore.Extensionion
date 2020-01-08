using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.contextExtended.model
{
    internal class TableData : ITableData
    {
        public string Table { get; set; }

        public string Schema { get; set; }

        public IEnumerable<string> Properties { get; set; }

        public IEnumerable<string> Keys { get; set; }
    }
}
