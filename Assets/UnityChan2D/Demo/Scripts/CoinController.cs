using System.Collections;
using UnityEngine;

namespace UnityChan2D.Demo
{
    public class CoinController : MonoBehaviour
    {
        public AudioClip getCoin;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                PointController.instance.AddCoin();
                AudioSourceController.instance.PlayOneShot(getCoin);
                Destroy(gameObject);
            }
        }
    }
}