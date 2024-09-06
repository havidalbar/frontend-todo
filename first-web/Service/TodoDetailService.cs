using System;
using first_web.Model;

namespace first_web.Service
{
    public class TodoDetailService
    {
        private readonly HttpClient _httpClient;

        public TodoDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TodoDetail>> GetTodoDetailsAsync(string todoId)
        {
            return await _httpClient.GetFromJsonAsync<List<TodoDetail>>($"https://1752-182-2-143-137.ngrok-free.app/todos/{todoId}/details");
        }

        public async Task<TodoDetail> GetTodoDetailAsync(string todoDetailId)
        {
            return await _httpClient.GetFromJsonAsync<TodoDetail>($"https://1752-182-2-143-137.ngrok-free.app/tododetails/{todoDetailId}");
        }

        public async Task CreateTodoDetailAsync(string todoId, TodoDetail todoDetail)
        {
            await _httpClient.PostAsJsonAsync($"https://1752-182-2-143-137.ngrok-free.app/todos/{todoId}/details", todoDetail);
        }

        public async Task UpdateTodoDetailAsync(TodoDetail todoDetail)
        {
            await _httpClient.PutAsJsonAsync($"https://1752-182-2-143-137.ngrok-free.app/tododetails/{todoDetail.TodoDetailId}", todoDetail);
        }

        public async Task DeleteTodoDetailAsync(string todoDetailId)
        {
            await _httpClient.DeleteAsync($"https://1752-182-2-143-137.ngrok-free.app/tododetails/{todoDetailId}");
        }
    }
}

