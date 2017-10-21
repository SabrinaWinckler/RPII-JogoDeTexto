using UnityEngine;

namespace Unity {

    public class TogglePainel : MonoBehaviour
    {

        public void TogglePanel(GameObject panel)
        {
            panel.SetActive(!panel.activeSelf);
        }
    }

}