using BlazorTodoApp.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorTodoApp.Services
{
    public class UserService
    {
        private readonly HttpClient _client;

        public UserService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<UserInfo>> GetUsersAsync()
        {
            var response = await _client.GetJsonAsync<AllUsers>("?results=20&nat=us");

            return response.Results;
        }
    }
}
