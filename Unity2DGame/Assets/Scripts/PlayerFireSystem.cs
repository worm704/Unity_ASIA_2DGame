using UnityEngine;
namespace Nick
{
    /// <summary>
    /// 
    /// </summary>


    public class PlayerFireSystem : FireSystemBase
    {
        //偵測玩家輸入行為:鍵盤、滑鼠、觸控與搖桿
        private void Update()
        {
            //如果 玩家按下 空白鍵 就生成子彈
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                SpawnBullet();
            }
        }
    }
}