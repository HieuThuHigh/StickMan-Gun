using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class WeaponLibraryController : MonoBehaviour
{
   [SerializeField] private Button[] buttons;
   [SerializeField] private Button backButton;
   [SerializeField] private GameObject[] gameObjectsPopup;
   [SerializeField] private GameObject  splPopup;
   
   private Color _defaultColor = Color.white;
   private Color _selectedColor  = Color.yellow;

   private void Start()
   {
      for (int i = 0; i < buttons.Length; i++)
      {
         int index = i;
         buttons[i].onClick.AddListener(() => EventClicked(index));
      }
      backButton.onClick.AddListener(() =>
      {
         gameObjectsPopup[0].SetActive(true);
         this.gameObject.SetActive(false);
      });
      ResetButtonColors();
   }

   void ResetButtonColors()
   {
      for (int i = 0; i < buttons.Length; i++)
      {
         buttons[i].image.color = _defaultColor;
      }
   }

   void EventClicked(int index)
   {
      ResetButtonColors();
      for (int i = 0; i < gameObjectsPopup.Length; i++)
      {
         gameObjectsPopup[i].SetActive(i == index);
      }
      buttons[index].image.color = _selectedColor;
   }

}
