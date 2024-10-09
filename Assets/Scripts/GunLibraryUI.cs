using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class GunLibraryUI : MonoBehaviour
    {
        [SerializeField] private Image img;
        [SerializeField] private WeaponInfo _weaponInfo;
        [SerializeField] private Button _button;

        public WeaponInfo WeaponInfo
        {
            get => _weaponInfo;
            set => _weaponInfo = value;
        }

        private void Awake()
        {
            _button.onClick.AddListener(() =>
            {
                
            });
        }
    }
}