using LogXPTest.Data;
using LogXPTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LogXPTest.Controllers
{
    [Route("api/[controller]")]     //to provide the route of the api
    [ApiController]
    public class ExpenseItemController
    {
        private ApiDbContext _dbContext;
        public ExpenseItemController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<AttendanceLogs>> GetExpenses()
        {
            return await _dbContext.AttendanceLogs.FromSqlRaw(@"
            SELECT TOP (10) [AttendanceLogId],
               [EmployeeCode],
               [LogDateTime],
               [Direction],
               [Device],
               [DarwinPullTime]
                FROM [DataForDarwinBox].[dbo].[AttendanceLogs]
                WHERE CAST(LogDateTime AS DATE) = CAST(GETDATE() AS DATE)
                AND [Device] = 'Gayathri Front Door'
            ")
            .ToListAsync();
        }
    }
}
