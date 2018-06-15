﻿// Decompiled with JetBrains decompiler
// Type: RenderHeads.Media.AVProVideo.Subtitle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE644F5D-682F-4D6E-964D-A0DD77A288F7
// Assembly location: C:\Users\André\Desktop\Assembly-CSharp.dll

namespace RenderHeads.Media.AVProVideo
{
  public class Subtitle
  {
    public int index;
    public string text;
    public int timeStartMs;
    public int timeEndMs;

    public bool IsBefore(float time)
    {
      if ((double) time > (double) this.timeStartMs)
        return (double) time > (double) this.timeEndMs;
      return false;
    }

    public bool IsTime(float time)
    {
      if ((double) time >= (double) this.timeStartMs)
        return (double) time < (double) this.timeEndMs;
      return false;
    }
  }
}