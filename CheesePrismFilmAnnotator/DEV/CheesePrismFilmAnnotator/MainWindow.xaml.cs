using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheesePrismFilmAnnotator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            Logger.Log($"로그인 시도: 사용자명={username}");
            bool loginResult = await LoginAsync(username, password);
            if (loginResult)
            {
                Logger.Log($"로그인 성공: 사용자명={username}");
                MessageBox.Show("로그인 성공!", "알림", MessageBoxButton.OK, MessageBoxImage.Information);
                var mainPage = new MainPage();
                mainPage.Show();
                this.Close();
            }
            else
            {
                Logger.Log($"로그인 실패: 사용자명={username}");
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async Task<bool> LoginAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                var url = "https://example.com/api/login"; // 실제 API 주소로 변경
                var payload = new { username = username, password = password };
                var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
                try
                {
                    var response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log($"로그인 예외 발생: {ex.Message}");
                }
            }
            return false;
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin_Click(btnLogin, new RoutedEventArgs());
            }
        }
    }
}