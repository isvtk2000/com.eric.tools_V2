using UnityEngine;
using UnityEngine.SceneManagement;
namespace Eric.tools
{   /// <summary>
    /// 場景控制
    /// </summary>
    public class SenceControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="senceName"></param>
        public void LoadSence(string senceName)
        {
            //載入場景
            SceneManager.LoadScene(senceName);
        }
        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void QuitGame()
        {
            //離開程式
            Application.Quit();
        }
    }
}


