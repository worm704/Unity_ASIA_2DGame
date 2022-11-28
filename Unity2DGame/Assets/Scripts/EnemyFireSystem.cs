using UnityEngine;
namespace Nick
{
    /// <summary>
    /// 敵人發射系統
    /// </summary>

    public class EnemyFireSystem : FireSystemBase

    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            //呼叫方法
            //SpawnBullet();
        }

        private void OnBecameVisible()
        {
            //延遲重複呼叫方法(方法名稱，延遲時間，間隔)
            InvokeRepeating("SpawnBullet", 0, interval);
        }
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }


    }
}