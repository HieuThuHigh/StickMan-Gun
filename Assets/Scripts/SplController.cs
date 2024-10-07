using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplController : MonoBehaviour
{
    [SerializeField] private Button weaponLibraryBtn;
    [SerializeField] private GameObject weaponLibraryPopup;

    private void Start()
    {
        weaponLibraryBtn.onClick.AddListener();
    }
}
