#nullable disable
using MagicOnion;
using MessagePack;

namespace YourGameServer.Interface // Unity cannot accpect 'namespace YourProjectName.Interface;' yet
{
    // Defines .NET interface as a Server/Client IDL.
    // The interface is shared between server and client.
    public interface IAccountService : IService<IAccountService>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="signup"></param>
        /// <returns></returns>
        UnaryResult<SignInRequestResult> SignUp(SignInRequest signup);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        UnaryResult<LogInRequestResult> LogIn(LogInRequest param);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UnaryResult<RenewTokenRequestResult> RenewToken();

        /// <summary>
        /// Log out
        /// </summary>
        /// <returns>none</returns>
        UnaryResult<Nil> LogOut();
    }
}
