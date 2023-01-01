using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Kogane
{
    public sealed class InternetCheckerInstance
    {
        private readonly IReadOnlyList<string> m_addresses;

        public InternetCheckerInstance( params string[] addresses )
            : this( ( IReadOnlyList<string> )addresses )
        {
        }

        public InternetCheckerInstance( IReadOnlyList<string> addresses )
        {
            m_addresses = addresses;
        }

        public async UniTask<bool> IsOnlineAsync( float timeoutSeconds )
        {
            foreach ( var address in m_addresses )
            {
                var result = await PingUtils.SendAsync( address, timeoutSeconds );

                if ( result.IsSuccess ) return true;
            }

            return false;
        }
    }
}