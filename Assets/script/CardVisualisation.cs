using UnityEngine;
using UnityEngine.UI;

namespace down
{
    class CardVisualisation : MonoBehaviour
    {
        public Text life;
        public Text attack;
        public Text defense;
        public Text rank;


        public Text title;
        public Text detail;
        public Image art;

        public Card card;

        private void Start()
        {
            loadCard(card);
        }

        public void loadCard(Card card)
        {
            if (card == null)
                return;

            this.card = card;
            title.text = card.name;
            art.sprite = card.art;

            if (string.IsNullOrEmpty(card.description))
                detail.gameObject.SetActive(false);
            else
            {
                detail.gameObject.SetActive(true);
                detail.text = card.description;
            }
            
            

            life.text = card.life.ToString();

            if (card.damage == 0)
                attack.gameObject.SetActive(false);
            else
            {
                attack.gameObject.SetActive(true);
                attack.text = card.damage.ToString();
            }
                

            if (card.defense == 0)
                defense.gameObject.SetActive(false);
            else
            {
                defense.gameObject.SetActive(true);
                defense.text = card.defense.ToString();
            }

            rank.text = card.rank.ToString();

        }

    }
}
