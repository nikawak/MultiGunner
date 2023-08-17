using Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

namespace MultiGunner
{
    public class LobbyManager : MonoBehaviourPunCallbacks
    {
        private const string _gameScene = "Game";
        private RoomOptions _defaultOptions = new RoomOptions()
        {
            MaxPlayers = 4
        };
        [SerializeField] private InputField _roomName;
        public void CreateRoom()
        {
            PhotonNetwork.CreateRoom(_roomName.text, _defaultOptions);
        }
        public void ConnectRoom()
        {

        }
        public void ConnectRandomRoom()
        {
            PhotonNetwork.JoinRandomRoom();
        }
        public override void OnJoinedRoom()
        {
            PhotonNetwork.LoadLevel(_gameScene);
        }
    }
}