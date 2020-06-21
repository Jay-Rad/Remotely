﻿using System;

namespace Remotely.Server.Models
{
    public class RemoteControlFrame
    {

        public RemoteControlFrame(byte[] frameBytes, int left, int top, int width, int height, bool endOfFrame, int screenWidth, int screenHeight, string viewerID, string machineName, DateTimeOffset startTime)
        {
            this.FrameBytes = frameBytes;
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
            this.EndOfFrame = endOfFrame;
            this.ScreenWidth = screenWidth;
            this.ScreenHeight = screenHeight;
            this.ViewerID = viewerID;
            this.MachineName = machineName;
            this.StartTime = startTime;
            this.Ticks = DateTimeOffset.Now.Subtract(startTime).Ticks;
        }
        public byte[] FrameBytes { get; private set; }
        public int Left { get; private set; }
        public int Top { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool EndOfFrame { get; private set; }
        public int ScreenWidth { get; private set; }
        public int ScreenHeight { get; private set; }
        public string ViewerID { get; private set; }
        public string MachineName { get; private set; }
        public DateTimeOffset StartTime { get; private set; }
        public long Ticks { get; private set; }
    }
}
