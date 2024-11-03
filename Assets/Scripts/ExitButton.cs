using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
	public void ExitGame()
	{
		// Kiểm tra nếu đang trong trình chỉnh sửa (Editor) của Unity
		#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
		#else
				// Thoát game nếu đang chạy trên máy tính
				Application.Quit();
		#endif
	}
}
