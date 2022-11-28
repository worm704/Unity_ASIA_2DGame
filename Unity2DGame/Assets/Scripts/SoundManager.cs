using UnityEngine;

namespace Nick
{

    /// <summary>
    /// 音效管理器
    /// </summary>
    /// 套用程式時進行:要求元件(類型(元件)) - 第一次套用腳本給元件時會添加元件
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            //this此類別
            instance = this;

            aud = GetComponent<AudioSource>();
        }


        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound">音效</param>
        /// <param name="rangeVolume">音量範圍</param>
        public void Playsound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }

    }
}