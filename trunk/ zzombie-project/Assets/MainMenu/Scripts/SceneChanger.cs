using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	public int mainMenu;
	private int currentLevel;

	public void Awake()
	{
		currentLevel = Application.loadedLevel;
	}

	public void ChangeTo(int scene)
	{
		Application.LoadLevel(scene);
	}

	public void Update()
	{
		if (currentLevel == mainMenu)
			return;

		#if CROSS_PLATFORM_INPUT
		if (CrossPlatformInput.GetButtonDown("Cancel"))
			Application.LoadLevel(0);
		#else
		if (Input.GetKey(KeyCode.Escape))
			Application.LoadLevel(0);
		#endif
	}
}
