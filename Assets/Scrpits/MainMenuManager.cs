using UnityEngine;
using UnityEngine.SceneManagement; // Rất quan trọng: Phải có dòng này để dùng chức năng quản lý Scene

public class MainMenuManager : MonoBehaviour
{
    // Hàm này sẽ được gọi khi bấm nút Start
    public void StartGame()
    {
        // Chuyển đến scene có tên là "Scene2"
        // Hãy chắc chắn tên này khớp với tên file scene của bạn
        SceneManager.LoadScene("Scene");

        // Hoặc bạn có thể chuyển bằng chỉ số (index) trong Build Settings
        // SceneManager.LoadScene(1);
    }

    // Hàm này dành cho nút EXIT
    public void QuitGame()
    {
        Debug.Log("QUIT GAME!"); // Dòng này chỉ để kiểm tra trong Editor
        Application.Quit();
    }
}