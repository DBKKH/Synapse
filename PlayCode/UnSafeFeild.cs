﻿//https://ufcpp.net/study/csharp/rm_default.html
using System;

class UnSafeFeild
{
	public void Output()
	{
		// 初期化せずにフィールドを読んでみる(既定値が入っている)
		var a = new DefaultValues();
		Console.WriteLine(a.i); //0
		Console.WriteLine(a.x); //0
		Console.WriteLine((int)a.c); //0->'\0' (ヌル文字)は表示できないので数値化して表示
		Console.WriteLine(a.b); // False
		Console.WriteLine(a.s == null); // null は表示できないので比較で。True になる
		//this.X(); //エラーになる
	}

	void X<T>()
	{
		Console.WriteLine(default(T)); // 型に応じて、null とか 0 とかになる
	}
}

class DefaultValues
{
	public int i;
	public double x;
	public char c;
	public bool b;
	public string s;
}
