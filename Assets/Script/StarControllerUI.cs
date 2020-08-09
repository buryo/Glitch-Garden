using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarControllerUI : MonoBehaviour
{

    // I want to serialize a float and I want other scripts to access it, but I don't want other scripts to be able to set it.
    [SerializeField] private TextMeshProUGUI _starsText = default;
    public TextMeshProUGUI StarsText => _starsText;
    // End

    // Start is called before the first frame update
    void Start()
    {
        StarController.OnStarChanged += SetStar;
    }

    public void SetStar(int star)
    {
        _starsText.text = star.ToString();
    }
}
