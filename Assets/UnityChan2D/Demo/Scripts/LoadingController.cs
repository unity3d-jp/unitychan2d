using UnityEngine;
using System.Collections;

namespace UnityChan2D.Demo
{
    public class LoadingController : MonoBehaviour
    {
        [SceneName]
        public string nextLevel;

        private IEnumerator Start()
        {
            yield return new WaitForSeconds(3);

            Application.LoadLevel(nextLevel);
        }
    }
}