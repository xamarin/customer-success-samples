using System;
using System.Threading.Tasks;

namespace SimpleUITestApp
{
	public interface ILogin
	{
		void AuthenticateWithTouchId(LoginPage page);
		Task<bool> SetPasswordForUsername(string username, string password);
		Task<bool> CheckLogin(string username, string password);
		Task SaveUsername(string username);
		Task<string> GetSavedUsername();

	}
}

