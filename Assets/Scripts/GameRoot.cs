/****************************************************
    文件：GameRoot.cs
	作者：Jerry
    邮箱: riverlihuo@163.com
    日期：2019/1/10 10:50:48
	功能：游戏启动入口
*****************************************************/

using UnityEngine;
using UnityEditor;

public class GameRoot : MonoBehaviour 
{ 
    public static GameRoot instance = null;
    public LoadingWnd loadingWnd;



    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(this);
        Init();
        Debug.Log("Game Start...");
    }

    private void Init()
    {
        //资源加载服务系统初始化
        ResService res = GetComponent<ResService>();
        res.InitService();

        //业务系统初始化
        LoginSvc login = GetComponent<LoginSvc>();
        login.InitSys();
        login.EnterLogin();
    }


}