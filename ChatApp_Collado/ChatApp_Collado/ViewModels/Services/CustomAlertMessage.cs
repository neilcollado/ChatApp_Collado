using System;
using System.Threading.Tasks;

namespace ChatApp_Collado
{
    public interface CustomAlertMessage
    {
        Task ShowAsync(string title, string message);
    }
}
