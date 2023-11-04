using FairyGUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUI
{
    public class RoomManager
    {
        private static List<RoomInfoData> roomList;

        private static int roomIndex = 1;
        public static int RoomIndex => roomIndex;

        public static void OpenRommDialog()
        {
            UIManager.OpenDialog(DialogType.RoomCommonDialog);
            UIManager.OpenDialog(GetCurRoomInfoData().dialogType);
        }

        public static bool ChangeRoom(int changeIndex)
        {
            var nextRoomIndex = roomIndex + changeIndex;

            if (nextRoomIndex < 0 || roomList != null && nextRoomIndex >= roomList.Count)
                return false;

            UIManager.CloseDialog(GetRoomInfoData(roomIndex).dialogType);
            roomIndex = nextRoomIndex;
            UIManager.OpenDialog(GetRoomInfoData(roomIndex).dialogType);
            return true;
        }

        /// <summary>
        /// �ı䷿��༭״̬
        /// </summary>
        /// <param name="isEdit">true:�༭��</param>
        public static void ChangeRoomEditState(bool isEdit)
        {
            var roomCommonDialog = UIManager.GetDialog("RoomCommonDialog") as RoomCommonDialog;
            if (isEdit)
            {
                roomCommonDialog?.EnterEditMode();
                UIManager.CloseDialog(GetCurRoomInfoData().dialogType);
            }
            else
            {
                roomCommonDialog?.ExitEditMode();
                UIManager.OpenDialog(GetCurRoomInfoData().dialogType);
            }
        }

        public static RoomInfoData GetCurRoomInfoData()
        {
            return GetRoomInfoData(roomIndex);
        }

        public static RoomInfoData GetRoomInfoData(int targetRoomIndex)
        {
            if (roomList == null)
                InitRoomData();

            var targetRoomData = roomList[targetRoomIndex];
            return roomList[targetRoomIndex];
        }

        public static void InitRoomData()
        {
            roomList = new List<RoomInfoData>()
            {
                new RoomInfoData(){roomName = "��ñ��", dialogType = DialogType.RoomRoleDialog},
                new RoomInfoData(){roomName = "����", dialogType = DialogType.RoomLobbyDialog},
                new RoomInfoData(){roomName = "������", dialogType = DialogType.RoomAlchemistDialog},
                new RoomInfoData(){roomName = "������", dialogType = DialogType.None},
            };

        }
    }

    public enum RoomType
    {
        Cloakroom,      // ��ñ��
        Lobby,          // ����
        Alchemy,        // ������
        Portals,        // ������
    }

    public class RoomInfoData
    {
        public string roomName;
        public DialogType dialogType;
    }
}
