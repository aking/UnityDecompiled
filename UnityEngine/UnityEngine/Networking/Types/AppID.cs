﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.Types.AppID
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.ComponentModel;

namespace UnityEngine.Networking.Types
{
  /// <summary>
  ///   <para>The AppID identifies the application on the Unity Cloud or UNET servers.</para>
  /// </summary>
  [DefaultValue(AppID.Invalid)]
  public enum AppID : ulong
  {
    Invalid = 18446744073709551615, // 0xFFFFFFFFFFFFFFFF
  }
}