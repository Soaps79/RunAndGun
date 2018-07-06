using QGame;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
	public class WeaponCarrier : QScript
	{
		[SerializeField] private Weapon _weapon;

		void Start ()
		{
		    OnEveryUpdate += CheckForMouseClick;
		}

	    private void CheckForMouseClick()
	    {
	        if (Input.GetButtonDown("Fire1"))
	            _weapon.TryFire();
	    }
	}
}
