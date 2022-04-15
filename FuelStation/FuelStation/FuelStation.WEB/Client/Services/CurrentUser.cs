using FuelStation.Shared;

namespace FuelStation.WEB.Client.Services
{
    public class CurrentUser
    {
        public string UserName { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool IsLogedIn { get; set; }
    }
}
