using Spine.Unity;
using UnityEngine;

namespace GameLogic
{
    public class MainGame
    {
        public static Player player;
        public static void StartGame()
        {
            //player = new Player("player", "Spine/spineboy-pro/spineboy-pro_prefab");
        }

        public static void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //RaycastHit hit;
                //if (Physics.Raycast(ray, out hit))
                //{
                //    GameObject go = hit.collider.gameObject;    //���ѡ������
                //    string goName = go.name;    //���ѡ����������֣�ʹ��hit.transform.nameҲ����
                //    if (goName == "player")
                //        player?.ChangeAni();

                //    Debug.Log("goName" + goName);
                //}

                //player?.ChangeAni();
            }
        }
    }
}
