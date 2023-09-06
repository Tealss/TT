using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject option;

    public void OptionSet()
    {
        if(option.activeSelf == true)
            option.SetActive(false);
        else
            option.SetActive(true);
    }


}
