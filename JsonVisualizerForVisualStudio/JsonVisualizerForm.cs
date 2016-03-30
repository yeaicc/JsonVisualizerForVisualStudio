using System;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Forms;

namespace JsonVisualizerForVisualStudio
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class JsonVisualizerForm : Form
    {
        public JsonVisualizerForm()
        {
            InitializeComponent();
            jsonWebBrowser.ObjectForScripting = this;
        }

        /// <summary>
        /// 要显示Json或文本
        /// </summary>
        public string Json
        {
            get;
            set;
        }

        /// <summary>
        /// 供WebBrowser调用以获取Json或文本
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return Json;
        }

        /// <summary>
        /// HTML临时文件地址
        /// </summary>
        private static string tempPath = "";

        private void JsonVisualizerForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tempPath))
            {
                string tp = Path.GetTempPath();
                string pn = Path.GetRandomFileName();
                string path = tp.Trim('\\') + "\\" + pn;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                tempPath = path;
                Assembly assembly = Assembly.GetExecutingAssembly();
                Stream stream = assembly.GetManifestResourceStream("JsonVisualizerForVisualStudio.json-color.html");
                string htmlFile = tempPath + "\\json-color.html";
                using (FileStream fs = new FileStream(htmlFile, FileMode.Create, FileAccess.ReadWrite))
                {
                    // 不使用CopeTo，兼容V3.5框架
                    byte[] bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, (int)stream.Length);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Flush();
                    fs.Close();
                }
                tempPath = htmlFile;
            }
            // 导航到临时文件，来处理和显示Json
            jsonWebBrowser.Navigate(tempPath);
        }
    }
}
