using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleGameCS
{
    /// <summary>
    /// 애플리케이션 진입점 클래스.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// 애플리케이션의 주 진입점.
        /// WinForms 비주얼 스타일을 활성화하고 MainForm을 실행한다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                    // Windows 비주얼 스타일 적용
            Application.SetCompatibleTextRenderingDefault(false); // GDI+ 텍스트 렌더링 사용
            Application.Run(new MainForm());                     // 메인 폼 실행
        }
    }
}
