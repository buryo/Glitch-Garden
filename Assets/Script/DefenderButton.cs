using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    private ButtonsController buttonsController;
    Color whiteColor = new Color(255f, 255f, 255f);

    private void Start()
    {
        buttonsController = FindObjectOfType<ButtonsController>();
    }

    public void ActivateSelectedButton()
    {
        buttonsController.DeactivateAllButtons();
        gameObject.GetComponent<SpriteRenderer>().color = whiteColor;
    }

    private void OnMouseDown()
    {
        ActivateSelectedButton();
    }
}