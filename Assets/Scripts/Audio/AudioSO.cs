using UnityEngine;

namespace Audio
{
    [CreateAssetMenu(menuName = "Audio Manager", fileName = "Sounds SO")]
    public class AudioSO : AudioData
    {
        public SoundList[] sounds;
    }
}
