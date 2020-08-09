using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    private ButtonsController buttonsController;
    [SerializeField] GameObject defenderPrefab;
    Color whiteColor = new Color(255f, 255f, 255f);

    private void Start()
    {
        buttonsController = FindObjectOfType<ButtonsController>();
    }

    public void ActivateSelectedButton()
    {
        buttonsController.SetDefender(defenderPrefab);
        gameObject.GetComponent<SpriteRenderer>().color = whiteColor;
    }

    private void OnMouseDown()
    {
        ActivateSelectedButton();
    }
}