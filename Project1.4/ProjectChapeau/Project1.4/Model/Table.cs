using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Table
    {
        public int tafelId { get; set; }
        public int reseveringId { get; set; }
        public TableStatus status { get; set; }

        public Table(int tafelId, int reseveringId, TableStatus status)
        {
            this.tafelId = tafelId;
            this.reseveringId = reseveringId;
            this.status = status;
        }

        public Table()
        {
        }
    }
}