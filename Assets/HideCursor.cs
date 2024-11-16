using UnityEngine;

public class HideCursor : MonoBehaviour
{
	void Start()
	{
		HideAndLockCursor();
	}

	void HideAndLockCursor()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void OnApplicationFocus(bool hasFocus)
	{
		if (hasFocus)
		{
			HideAndLockCursor();
		}
	}
}