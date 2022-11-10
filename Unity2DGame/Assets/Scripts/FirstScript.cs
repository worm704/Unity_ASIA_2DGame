using UnityEngine;
namespace Nick

{
    /// <summary>
    /// 第一個腳本
    /// 2022.10.13
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region 註解區域
        //縮排 快捷鍵:Tab
        //格式化文件 快捷鍵:Ctrl+K D
        //單行註解

        /*多行註解
         * 多行註解
         */

        //A a 不相同的字
        #region 事件區域
        //喚醒事件:遊戲開始時執行一次
        private void Awake()
        {
            //輸出
            print("哈囉，沃德~");
        }
        //開始事件 Awake後執行一次
        private void Start()
        {
            print("<color=yellow>開始事件</color>");
        }
        //更新事件:Start之後執行，執行約60FPS
        private void Update()
        {
            print("<color=green>更新事件</color>");
        }
        #endregion
    }
    #endregion

}