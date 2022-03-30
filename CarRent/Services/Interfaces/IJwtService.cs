namespace CarRent.Services.Interfaces
{
    public interface IJwtService
    {
        public string GetAdminJwtToken(string adminPassword);
    }
}
