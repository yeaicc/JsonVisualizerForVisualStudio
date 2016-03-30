using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(JsonVisualizerForVisualStudio.JsonVisualizer),
typeof(VisualizerObjectSource),
Target = typeof(string),
Description = "Json 可视化工具")]
namespace JsonVisualizerForVisualStudio
{
    public class JsonVisualizer : DialogDebuggerVisualizer
    {
        /// <summary>
        /// 当Visual Studio中点击该工具时，需要该工具显示时执行
        /// </summary>
        /// <param name="windowService">窗体服务</param>
        /// <param name="objectProvider">调试对象提供程序</param>
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            string json = (objectProvider.GetObject() ?? "").ToString();
            JsonVisualizerForm form = new JsonVisualizerForm { Json = json };
            windowService.ShowDialog(form);
        }

        public static void TestShowVisualizer(object value)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(value, typeof(JsonVisualizer));
            visualizerHost.ShowVisualizer();
        }
    }
}
