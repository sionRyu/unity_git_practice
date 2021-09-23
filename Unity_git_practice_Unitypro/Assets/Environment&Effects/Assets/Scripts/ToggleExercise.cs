using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleExercise : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Toggle toggle;

    private void Awake()
    {
        toggle.onValueChanged.AddListener(OnToggleValueChangedEvent01);
    }

    public void OnToggleValueChangedEvent01(bool boolean)
    {
        player.SetActive(boolean);
        Debug.Log("Toggle Key"+ boolean);
    }

    public void OnToggleValueChangedEvent02(bool boolean)
    {
        Debug.Log("Toggle Key" + boolean);
    }
}
