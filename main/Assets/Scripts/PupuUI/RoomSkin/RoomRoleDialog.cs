using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUI
{
    public class RoomRoleDialog : Dialog
    {

        private List<SkinInfoData> skinDataList;

        protected override void OnInit()
        {
            base.OnInit();


            skinDataList = new List<SkinInfoData>();
            skinDataList.Add(new SkinInfoData { type = SkinType.Food, icon = "ui://RoomLobby/type_1", name = "ƻ��", num = 1, desc = "�ܺ�" });
            skinDataList.Add(new SkinInfoData { type = SkinType.Food, icon = "ui://RoomLobby/type_2", name = "�����", num = 1, desc = "һ��" });
            skinDataList.Add(new SkinInfoData { type = SkinType.Play, icon = "ui://RoomLobby/type_3", name = "����", num = 1, desc = "�ܺ�" });

        }


        // ��������
        public enum SkinType
        {
            Food = 1,       // ����
            Play = 2,       // ���
            Study = 3,      // ѧϰ
        }
        public class SkinInfoData
        {
            public SkinType type;
            public string icon;
            public string name;
            public string desc;
            public int num;
        }
    }
}

