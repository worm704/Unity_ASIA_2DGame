using UnityEngine;
namespace Nick
{
    /// <summary>
    /// 移動系統
    /// </summary>

    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            // transform指此物件的Transform元件
            // Translate(x,y,z)位移
            // *乘法
            // Time.deltaTime 每幀的時間
            transform.Translate(speed *Time.deltaTime, 0, 0);
        }
    }
}
