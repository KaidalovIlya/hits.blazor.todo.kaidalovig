﻿using Todo.ServerApp.Data.Interfaces;

namespace Todo.ServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> Tasks { get;  } = 
        [
                new() { Id = 1, Title = "Задача 1", Description = "Описание задачи 1", CreatedDate=DateTime.Now },
                new() { Id = 2, Title = "Задача 2", Description = "Описание задачи 2", CreatedDate=DateTime.Now },
                new() { Id = 3, Title = "Задача 3", Description = "Описание задачи 3", CreatedDate=DateTime.Now },
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

		public Task<IEnumerable<TaskItem>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }

        public Task SaveAsync(Task item) 
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
