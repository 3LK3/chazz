using UnityEngine;

namespace Chazz.UI
{
    public class GameIntroController : MonoBehaviour
    {
        public void StartGame()
        {


            Show(false);
        }

        private void Show(bool shouldBeVisible = true)
        {
            GetComponent<Canvas>().enabled = shouldBeVisible;
        }
    }
}
