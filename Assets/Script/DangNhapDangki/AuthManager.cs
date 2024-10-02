using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Để sử dụng InputField và Text

public class AuthManager : MonoBehaviour
{
    // Các trường nhập liệu cho phần đăng nhập
    public InputField loginUsername;  // Ô nhập liệu cho tên đăng nhập/email
    public InputField loginPassword;  // Ô nhập liệu cho mật khẩu

    // Các trường nhập liệu cho phần đăng ký
    public InputField registerUsername;         // Ô nhập tên người dùng
    public InputField registerEmail;            // Ô nhập email
    public InputField registerPassword;         // Ô nhập mật khẩu
    public InputField registerConfirmPassword;  // Ô nhập xác nhận lại mật khẩu

    // Dòng văn bản để phản hồi cho người dùng (hiển thị thông báo)
    public Text feedbackText;

    // Hàm xử lý đăng nhập
    public void Login()
    {
        // Lấy dữ liệu từ các ô nhập liệu
        string username = loginUsername.text; 
        string password = loginPassword.text;

        // Kiểm tra tài khoản mẫu (bạn có thể kết nối với cơ sở dữ liệu ở đây)
        if (username == "test" && password == "1234") // Tài khoản mẫu cho việc kiểm tra
        {
            feedbackText.text = "Đăng nhập thành công!";
            // Sau khi đăng nhập thành công, bạn có thể chuyển sang màn hình khác.
            // Ví dụ: SceneManager.LoadScene("MainScene");
        }
        else
        {
            feedbackText.text = "Thông tin đăng nhập không chính xác.";
        }
    }

    // Hàm xử lý đăng ký
    public void Register()
    {
        // Kiểm tra xem mật khẩu có trùng khớp không
        if (registerPassword.text == registerConfirmPassword.text)
        {
            feedbackText.text = "Đăng ký thành công!";
            // Bạn có thể lưu dữ liệu người dùng (ví dụ: sử dụng PlayerPrefs hoặc gọi API để lưu trên server)
            // Ví dụ: PlayerPrefs.SetString("Username", registerUsername.text);
        }
        else
        {
            feedbackText.text = "Mật khẩu không khớp, vui lòng thử lại.";
        }
    }
}
