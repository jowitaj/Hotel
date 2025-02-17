﻿using System.Collections.Generic;
using System.Threading.Tasks;
using zlobek.Entities;

namespace zlobek.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccount();
        Task<Account> GetAccount(int id);
        Task<Account> CreateAccount(Account account);
        Task<bool> UpdateAccount(int id, Account account);
        Task<bool> DeleteAccount(int id);
        Task<Account> GetAccountByEmail(string email);
        Task<string> GetRoleForAccount(string email);
    }
}
