using Photon.Pun;
using UnityEngine.SceneManagement;

namespace MultiGunner
{
    public class ServerConnecter : MonoBehaviourPunCallbacks
    {
        private const string _lobbyScene = "Lobby";
        public void Start()
        {
            PhotonNetwork.ConnectToBestCloudServer();
        }
        public override void OnConnectedToMaster()
        {
            SceneManager.LoadScene(_lobbyScene);
        }
    }
}