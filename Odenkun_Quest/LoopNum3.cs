using UnityEngine;
using System.Collections;
using System;

public class LoopNum3 : MonoBehaviour
{
	public enum MenuItem
	{
		GAMESTART,
		LEADERSBOARD,
		CONFIG,
		QUIT,
	};

	[SerializeField]
	MenuItem
	menuItem;

	int itemLength = 4;

	KeyAction upArrow = new KeyAction (KeyCode.UpArrow);
	KeyAction downArrow = new KeyAction (KeyCode.DownArrow);

	void FixedUpdate ()
	{
		upArrow.Action (delegate {
			menuItem = (MenuItem)(((int)menuItem + itemLength - 1) % itemLength);
		});

		downArrow.Action (delegate {
			menuItem = (MenuItem)(((int)menuItem + 1) % itemLength);
		});
	}

	class KeyAction
	{
		const int firstStoppingFPSwait = 30;
		const int repeatFPSwait = 4;

		KeyCode keyCode;
		int gauge;
		bool prev;

		public KeyAction (KeyCode keyCode)
		{
			this.keyCode = keyCode;
		}

		public void Action (Action action)
		{
			if (Input.GetKey (keyCode)) {
				if (!prev) {
					gauge = firstStoppingFPSwait;
					action ();
				} else {
					gauge--;
					if (gauge < 0) {
						gauge = repeatFPSwait;
						action ();
					}
				}
				prev = true;
			} else {
				prev = false;
			}
		}
	}
		
}
