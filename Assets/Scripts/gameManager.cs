using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    Character _character;

    public Character character
    {
        get
        {
            return _character;
        }

        set
        {
            _character = value;
        }
    }

    void Awake()
    {
        instance = this;
    }


}
