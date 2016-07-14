using UnityEngine;
using System.Collections;

public class fontsize : MonoBehaviour {

	public static int GetFontSizeFromWidth(GUIStyle style, GUIContent contents, float width) {
		
		int size = 0;

		for (int i = 1; ; i++) {

			style.fontSize = i;
		
			Vector2 v = style.CalcSize(contents);
		
			if (v.x < width) {
		
				size = i;
		
			} else {

				break;
		
			}
		
		}
	
		return size;

	}
}
