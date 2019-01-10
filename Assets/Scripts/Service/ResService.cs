/****************************************************
    文件：ResService.cs
	作者：Jerry
    邮箱: riverlihuo@163.com
    日期：2019/01/10 11:33
	功能：资源加载服务
*****************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResService : MonoBehaviour
{
    public static ResService Instance = null;

    public void InitService()
    {
        Instance = this;
        Debug.Log("init ResService...");
    }

    public void AsyncLoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
