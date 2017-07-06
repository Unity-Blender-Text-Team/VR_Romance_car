﻿//------------------------------------------------------------------------
// ● 使用ライブラリの宣言
//------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
//========================================================================
// ■ UI_Title
//------------------------------------------------------------------------
//	タイトルのUIクラス。
//========================================================================

public class UI_Title : MonoBehaviour {
	//--------------------------------------------------------------------
	// ● メンバ変数
	//--------------------------------------------------------------------

	//--------------------------------------------------------------------
	// ● 初期化
	//--------------------------------------------------------------------
	void Start() {
	}
	//--------------------------------------------------------------------
	// ● 更新
	//--------------------------------------------------------------------
	void Update() {
	}
	//--------------------------------------------------------------------
	// ● ボタンが押されたコールバック関数
	//--------------------------------------------------------------------
	public void on_click(Button button) {
		// 押されたボタン名で分岐
		switch (button.name) {
			// 開始ボタンの場合
			case "Button_Start":
				SceneManager.LoadScene("Field");	// フィールド場面に遷移
				break;

			// 終了ボタンの場合
			case "Button_End":
				Application.Quit();					// アプリ終了
				break;
		}
	}
}
