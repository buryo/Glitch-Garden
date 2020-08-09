using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] ButtonsController buttonsController;

    private void OnMouseDown()
    {
        int defenderCost = buttonsController.GetSelectedDefenderPrice();

        if (StarController.BuyIfEnoughStars(defenderCost))
        {
            Spawn();
        }
    }

    private Vector2 GetClickedSquare()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 mousePos)
    {
        float newX = Mathf.RoundToInt(mousePos.x);
        float newY = Mathf.RoundToInt(mousePos.y);
        return new Vector2(newX, newY);
    }

    private void Spawn()
    {
        if (buttonsController.selectedDefender)
            Instantiate(buttonsController.selectedDefender, GetClickedSquare(), transform.rotation);
        else Debug.Log("Select defender first!");
    }
}
