using SlimDX.Windows;

namespace SlimDX1
{
    static class Program
    {
        static void Main()
        {
            var form = new RenderForm("Tutorial 1: Basic Window");
            MessagePump.Run(form, () => { });
        }
    }
}
