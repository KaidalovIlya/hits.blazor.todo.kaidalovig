using Microsoft.EntityFrameworkCore;
using Todo.ServerApp.Data.Interfaces;

namespace Todo.ServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}
