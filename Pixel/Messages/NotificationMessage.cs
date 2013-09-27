﻿using Hardcodet.Wpf.TaskbarNotification;

namespace Pixel.Messages {
  public class NotificationMessage {
    public NotificationMessage(string title, string text, BalloonIcon icon) {
      Title = title;
      Text = text;
      Icon = icon;
    }

    public string Title { get; private set; }
    public string Text { get; private set; }
    public BalloonIcon Icon { get; private set; }
  }
}