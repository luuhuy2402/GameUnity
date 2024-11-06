using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggleButton : MonoBehaviour
{
	[SerializeField] private AudioSource musicSource; // AudioSource để phát nhạc
	[SerializeField] private Sprite musicOnIcon; // Icon khi nhạc bật
	[SerializeField] private Sprite musicOffIcon; // Icon khi nhạc tắt
	private bool isMusicOn = true; // Trạng thái nhạc
	private Image buttonImage; // Hình ảnh trên button

	private void Start()
	{
		// Lấy Image component từ button
		buttonImage = GetComponent<Image>();

		// Khởi tạo trạng thái nhạc và icon
		UpdateButtonIcon();
	}

	public void ToggleMusic()
	{
		// Đổi trạng thái nhạc
		isMusicOn = !isMusicOn;

		// Bật/tắt nhạc theo trạng thái
		if (isMusicOn)
		{
			musicSource.Play();
		}
		else
		{
			musicSource.Pause();
		}

		// Cập nhật icon của button
		UpdateButtonIcon();
	}

	private void UpdateButtonIcon()
	{
		// Đổi icon trên button dựa trên trạng thái nhạc
		buttonImage.sprite = isMusicOn ? musicOnIcon : musicOffIcon;
	}
}
