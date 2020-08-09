using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private ButtonsController buttonsController;

    private void Start()
    {
        buttonsController = FindObjectOfType<ButtonsController>();
    }

    private void OnMouseDown()
    {
        Spawn();
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
        Instantiate(buttonsController.selectedDefender, GetClickedSquare(), transform.rotation);
    }
}
