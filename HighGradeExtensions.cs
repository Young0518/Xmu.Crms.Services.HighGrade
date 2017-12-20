using Xmu.Crms.Services.HighGrade;
using Xmu.Crms.Services.Insomnia;
using Xmu.Crms.Shared.Service;

namespace Microsoft.Extensions.DependencyInjection
{ 
    public static class HighGradeExtensions
    {
        // 为每一个你写的Service写一个这样的函数，把 UserService 替换为你实现的 Service
        public static IServiceCollection AddHighGradeTimerService(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<ITimerService, TimerService>();
        }
    }
}
