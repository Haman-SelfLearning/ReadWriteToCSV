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
        [CsvColumn(Name="Year")]
        public string Year { get; set; }
        [CsvColumn(Name="Score")]
        public string Score { get; set; }
        [CsvColumn(Name = "Title")]
        public string Title { get; set; }

    }
}
