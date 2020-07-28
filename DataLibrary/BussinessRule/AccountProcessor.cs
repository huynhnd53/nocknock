using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessRule
{
    public static class AccountProcessor
    {
        public static int CreateAccount(string username, string password)
        {
            AccountModel data = new AccountModel
            {
                Username = username,
                Password = password
            };
            string sql = @"INSERT INTO dbo.Account VALUES(@Username, @Password)";
            return SqlDataAccess.InsertData(sql, data);
        }

        public static bool IsValidLogin(string username, string password)
        {
            AccountModel data = new AccountModel
            {
                Username = username,
                Password = password
            };
            string sql = @"SELECT * FROM dbo.Account WHERE Username = @Username and Password = @Password";
            AccountModel result = SqlDataAccess.FindData<AccountModel>(sql, data);
            return result != null;
        }

        public static bool IsExistedUsername(string username)
        {
            AccountModel data = new AccountModel { Username = username };
            string sql = @"SELECT * FROM dbo.Account WHERE Username = @Username";
            AccountModel result = SqlDataAccess.FindData<AccountModel>(sql, data);
            return result != null;
        }

        public static int GetAccountIdByUsername(string username)
        {
            AccountModel data = new AccountModel
            {
                Username = username,
            };
            string sql = @"SELECT * FROM dbo.Account WHERE Username = @Username";
            AccountModel result = SqlDataAccess.FindData<AccountModel>(sql, data);
            return SqlDataAccess.FindData<AccountModel>(sql, data).AccountID;
        }

        public static int UpdateAccount(string username, string password)
        {
            AccountModel data = new AccountModel
            {
                Username = username,
                Password = password
            };
            string sql = @"UPDATE dbo.Account SET Password = @Password WHERE Username = @Username";
            return SqlDataAccess.InsertData(sql, data);
        }
    }
}