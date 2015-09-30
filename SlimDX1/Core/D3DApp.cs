using System;
using SlimDX.Windows;

namespace Core
{
    public class D3DApp : DisposableClass
    {
        public static D3DApp GD3DApp;
        private bool _disposed;

        public RenderForm Window { get; protected set; }
        public IntPtr AppInst { get; protected set; }
        public float AspectRatio { get { return (float)ClientWidth / ClientHeight; } }
        //public bool GammaCorrectedBackBuffer { get; set; }

        protected bool AppPaused;
        protected bool Minimized;
        protected bool Maximized;
        protected bool Resizing;
        protected int Msaa4XQuality;
        protected GameTimer Timer;

        protected int ClientWidth;
        protected int ClientHeight;
    }
}