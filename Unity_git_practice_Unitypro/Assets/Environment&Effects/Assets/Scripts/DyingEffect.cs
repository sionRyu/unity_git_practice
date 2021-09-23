using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingEffect : MonoBehaviour
{
    [SerializeField]
    private GameObject dieEffect;


    


    private void OnDestroy()
    {
        dieEffect.SetActive(true);
        

        // Æø¹ßÀÌÆåÆ® ºÒ·¯¿À±â
    }


}
