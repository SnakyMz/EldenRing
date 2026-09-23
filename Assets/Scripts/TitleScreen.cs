using UnityEngine;
using Unity.Netcode;

public class TitleScreen : MonoBehaviour
{
    public void StartNetworkAsHost()
    {
        NetworkManager.Singleton.StartHost();
    }
}
