using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMane : MonoBehaviour
{
	//　Time.timeScaleに設定する値
	[SerializeField]
	private float _timeScale = 0.1f;
	//　時間を遅くしている時間
	[SerializeField]
	private float _slowTime = 1f;
	//　経過時間
	private float _elapsedTime = 0f;
	//　時間を遅くしているかどうか
	private bool _isSlowDown = false;

	void Update()
	{
		//　スローダウンフラグがtrueの時は時間計測
		if (_isSlowDown)
		{
			_elapsedTime += Time.unscaledDeltaTime;
			if (_elapsedTime >= _slowTime)
			{
				SetNormalTime();
			}
		}
	}
	//　時間を遅らせる処理
	public void SlowDown()
	{
		_elapsedTime = 0f;
		Time.timeScale = _timeScale;
		_isSlowDown = true;
	}
	//　時間を元に戻す処理
	public void SetNormalTime()
	{
		Time.timeScale = 1f;
		_isSlowDown = false;
	}
}
