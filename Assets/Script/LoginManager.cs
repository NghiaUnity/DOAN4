using UnityEngine;
using UnityEngine.UI; // Đối với các thành phần UI
using TMPro; // Đối với các thành phần TextMeshPro (nếu sử dụng)
using UnityEngine.SceneManagement; // Để quản lý chuyển cảnh

public class LoginManager : MonoBehaviour
{
    public TMP_InputField emailInput; // Trường nhập cho email
    public TMP_InputField passwordInput; // Trường nhập cho mật khẩu
    public Button loginButton; // Nút để đăng nhập
    public Button createAccountButton; // Nút để tạo tài khoản

    private void Start()
    {
        // Thêm các listener cho các nút
        loginButton.onClick.AddListener(OnLoginButtonClick);
        createAccountButton.onClick.AddListener(OnCreateAccountButtonClick);
    }

    private void OnLoginButtonClick()
    {
        // Lấy thông tin người dùng
        string email = emailInput.text;
        string password = passwordInput.text;

        // Gọi phương thức xác thực
        AuthenticateUser(email, password);
    }

    private void AuthenticateUser(string email, string password)
    {
        // Xác thực mẫu (thay thế bằng logic thực tế của bạn)
        if (IsValidUser(email, password))
        {
            Debug.Log("Đăng nhập thành công!");
            SceneManager.LoadScene("PlayGame"); // Tải cảnh trò chơi của bạn
        }
        else
        {
            Debug.Log("Đăng nhập thất bại. Thông tin không hợp lệ.");
        }
    }

    private bool IsValidUser(string email, string password)
    {
        // Thay thế bằng logic xác thực của bạn (ví dụ: kiểm tra cơ sở dữ liệu)
        return email == "admin" && password == "123"; 
    }

    private void OnCreateAccountButtonClick()
    {
        Debug.Log("Chuyển đến màn hình tạo tài khoản");
        SceneManager.LoadScene("PlayGame");
    }
}
