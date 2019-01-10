using UnityEngine;
using System.Collections;

public class LoginSvc : MonoBehaviour
{

    public void InitSys()
    {
        Debug.Log("业务系统启动...");
    }

    public void EnterLogin()
    {
        //TODO
        //异步加载场景
        ResService.Instance.AsyncLoadScene(Constants.SceneLogin);

        //并显示加载进度条
        //加载完成后再打开注册登录界面
    }
}
