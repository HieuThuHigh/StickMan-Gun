using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplController : MonoBehaviour
{
    [SerializeField] private Button weaponLibButton;
    [SerializeField] private GameObject weaponLibPopup;
    [SerializeField] private GameObject challengPopup;
    [SerializeField] private Button challengButton;
    [SerializeField] private GameObject splPopup;
    [SerializeField] private GameObject line;
    [SerializeField] private Button soundButton;
    
    private void Start()
    {
        soundButton.onClick.AddListener(SoundEvent);
        weaponLibButton.onClick.AddListener(WeaponLib);
        challengButton.onClick.AddListener(Challenge);
    }

    void SoundEvent()
    {
        line.SetActive(!line.activeSelf);
    }

    void WeaponLib()
    {
        weaponLibPopup.gameObject.SetActive(true);
    }

    void Challenge()
    {
        challengPopup.gameObject.SetActive(true);
    }
}