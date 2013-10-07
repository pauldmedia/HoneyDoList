using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoneyDoList.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int TaskRank { get; set; }
        public DateTime TaskDate { get; set; }
    }
}