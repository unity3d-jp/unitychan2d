using UnityEngine;

namespace UnityChan2D.Demo
{
    public class Loop : MonoBehaviour
    {
        public Collider2D to;
        public float offsetX;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag != "Player") return;

            var pos = to.transform.position;

            other.transform.position = new Vector2(pos.x + offsetX, other.transform.position.y);
        }
    }
}