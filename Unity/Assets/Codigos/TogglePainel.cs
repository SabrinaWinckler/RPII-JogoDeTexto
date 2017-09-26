﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePainel : MonoBehaviour {

	public void TogglePanel (GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}
