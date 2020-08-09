using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    private static ButtonsController instance = null;
    public static ButtonsController Instance { get { return instance; } }
    public GameObject selectedDefender;
    [SerializeField] List<GameObject> buttons;
    Color grayishColor = new Color(0f, 0f, 0f);

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void DeactivateAllButtons()
    {
        foreach (GameObject button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = grayishColor;
        }
    }
}