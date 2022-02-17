using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMane : MonoBehaviour
{
	//�@Time.timeScale�ɐݒ肷��l
	[SerializeField]
	private float _timeScale = 0.1f;
	//�@���Ԃ�x�����Ă��鎞��
	[SerializeField]
	private float _slowTime = 1f;
	//�@�o�ߎ���
	private float _elapsedTime = 0f;
	//�@���Ԃ�x�����Ă��邩�ǂ���
	private bool _isSlowDown = false;

	void Update()
	{
		//�@�X���[�_�E���t���O��true�̎��͎��Ԍv��
		if (_isSlowDown)
		{
			_elapsedTime += Time.unscaledDeltaTime;
			if (_elapsedTime >= _slowTime)
			{
				SetNormalTime();
			}
		}
	}
	//�@���Ԃ�x�点�鏈��
	public void SlowDown()
	{
		_elapsedTime = 0f;
		Time.timeScale = _timeScale;
		_isSlowDown = true;
	}
	//�@���Ԃ����ɖ߂�����
	public void SetNormalTime()
	{
		Time.timeScale = 1f;
		_isSlowDown = false;
	}
}
