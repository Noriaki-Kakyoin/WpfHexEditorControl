﻿using System.Windows;
using System.Windows.Threading;

namespace WPFHexaEditor.Core.MethodExtention
{
    public static class ApplicationExtention
    {
        public static void DoEvents(this Application app)
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background,
                new DispatcherOperationCallback(ExitFrame), frame);
            Dispatcher.PushFrame(frame);
        }

        private static object ExitFrame(object f)
        {
            ((DispatcherFrame)f).Continue = false;

            return null;
        }
    }
}
