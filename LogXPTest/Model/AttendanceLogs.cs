using System.ComponentModel.DataAnnotations;

namespace LogXPTest.Model
{
    public class AttendanceLogs
    {
        [Key]
        public int AttendanceLogId { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime LogDateTime { get; set; }
        public string Direction { get; set; }
        public string Device { get; set; }
        public DateTime? DarwinPullTime { get; set; }
    }
}
