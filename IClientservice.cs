using StoreManagmentSystem.Data.Models;
using StoreManagmentSystem.Data.ViewModels;

namespace StoreManagmentSystem.Services
{
    public interface IClientService
    {
        public string ClientUpdate(ClientVM client);
        public string ClientDelete(string name);
        public Client MerrClientByName(string name);
        public List<Client> Klientet();
        public string Create(ClientVM client);
    }
}