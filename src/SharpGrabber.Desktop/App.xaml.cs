﻿using Avalonia;
using Avalonia.Markup.Xaml;

namespace SharpGrabber.Desktop
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
