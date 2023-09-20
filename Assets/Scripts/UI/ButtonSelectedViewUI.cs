using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelectedViewUI : MonoBehaviour
{
    [SerializeField]private GameObject selectedView;

    private void OnMouseEnter() {
        selectedView.SetActive(true);   
    }
    private void OnMouseExit() {
        selectedView.SetActive(false);
    }
}
