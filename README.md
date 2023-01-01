# Kogane Internet Checker Instance

インターネットに接続しているか確認できるクラス

## 使用例

```cs
using Cysharp.Threading.Tasks;
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    private readonly InternetCheckerInstance m_instance = new
    (
        "8.8.8.8", // Google Public DNS
        "8.8.4.4", // Google Public DNS
        "4.2.2.2", // Level 3 Communications
        "4.2.2.3", // Level 3 Communications
        "4.2.2.4"  // Level 3 Communications
    );

    private async UniTaskVoid Start()
    {
        Debug.Log( await m_instance.IsOnlineAsync( 5 ) );
    }
}
```