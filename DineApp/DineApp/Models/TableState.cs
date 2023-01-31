using Microsoft.AspNetCore.Http.Connections;

namespace DineApp.Models
{
    public enum TableState
    {
        Available,
        Ordered,
        Waiting,
        Finished,
    }
}
