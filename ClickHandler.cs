using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public UIManager uIManager;

    private void OnMouseDown()
    {
        uIManager.AddCash();
    }
}
