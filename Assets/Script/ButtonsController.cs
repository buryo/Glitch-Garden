using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    private static ButtonsController instance = null;
    public static ButtonsController Instance { get { return instance; } }
    public Defender selectedDefender;
    [SerializeField] List<GameObject> buttons;
    Color grayishColor = new Color(0f, 0f, 0f);

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// Set the defender
    /// </summary>
    public void SetDefender(Defender defender)
    {
        DeactivateAllButtons();
        selectedDefender = defender;
    }

    /// <summary>
    /// Return the selected Defender's price in Stars
    /// </summary>
    /// <returns>Defender price</returns>
    public int GetSelectedDefenderPrice()
    {
        return selectedDefender.GetComponentInChildren<Defender>().StarCost;
    }

    /// <summary>
    /// Deactivate all selectable defenders on the canvas
    /// </summary>
    public void DeactivateAllButtons()
    {
        foreach (GameObject button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = grayishColor;
        }
    }
}