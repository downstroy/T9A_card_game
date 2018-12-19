using UnityEngine;

namespace down
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {

        public int life;
        public int damage;
        public int defense;
        public int rank;

        public string name;
        public Sprite art;
        public string description; 
    }
}

