using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.AspNetCore.SignalR;

namespace Test.Hubs
{
    public class MessagingHub : AbpHub
    {
        public override Task OnConnectedAsync()
        {
            var currentUserName = CurrentUser.UserName; //Access to the current user info
            return base.OnConnectedAsync();
        }

        [Authorize]
        public async Task SendMessage(string targetUserName, string message)
        {
            var currentUserName = CurrentUser.UserName; //Access to the current user info
        }

    }
}