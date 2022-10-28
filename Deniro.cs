using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace ReadWriteToCSV
{
    [Serializable]
    public class Deniro
    {
        [CsvColumn(Name="Year",FieldIndex = 1)]
        public string Year { get; set; }
        [CsvColumn(Name="Score", FieldIndex = 2)]
        public string Score { get; set; }
        [CsvColumn(Name = "Title",FieldIndex = 3)]
        public string Title { get; set; }

    }
}
