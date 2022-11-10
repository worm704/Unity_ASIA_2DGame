using UnityEngine;
namespace Nick
{
    /// <summary>
    /// 傷害系統
    /// </summary>

    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;
    }
}