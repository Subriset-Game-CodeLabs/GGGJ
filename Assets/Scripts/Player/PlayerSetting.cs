using UnityEngine;

namespace Player{
    
    [CreateAssetMenu(fileName = "PlayerSetting", menuName = "Data/PlayerSetting")] 
    public class PlayerSetting: GGJData
    {
        [SerializeField] private float _moveSpeed = 5f;
        public float MoveSpeed => _moveSpeed;
    }
}