using QGame;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
	public class WeaponCarrier : QScript
	{
		[SerializeField] private Weapon _weaponPrefab;
	    private Weapon _weapon;

        void Start ()
		{
		    OnEveryUpdate += CheckForMouseClick;
		    _weapon = Instantiate(_weaponPrefab, transform);
		}

	    private void CheckForMouseClick()
	    {
	        if (Input.GetButton("Fire1"))
	            _weapon.TryFire();
	    }
	}
}
