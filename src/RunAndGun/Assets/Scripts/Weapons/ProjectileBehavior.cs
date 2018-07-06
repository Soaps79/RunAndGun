using UnityEngine;

namespace Assets.Scripts.Weapons
{
    [CreateAssetMenu(menuName = "ScriptableObjects/ProjectileBehavior")]
    public class ProjectileBehavior : ScriptableObject
    {
        public float Speed;
        public Sprite Sprite;
    }
}