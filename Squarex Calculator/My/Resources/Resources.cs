// Decompiled with JetBrains decompiler
// Type: Calculator.My.Resources.Resources
// Assembly: Cubex Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9CBA80DF-BA4E-4690-831D-86D63FAF3D82
// Assembly location: C:\Program Files (x86)\Squarex Calculator\Squarex Calculator.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Calculator.My.Resources
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  [StandardModule]
  [HideModuleName]
  [CompilerGenerated]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Calculator.My.Resources.Resources.resourceMan, (object) null))
          Calculator.My.Resources.Resources.resourceMan = new ResourceManager("Calculator.Resources", typeof (Calculator.My.Resources.Resources).Assembly);
        return Calculator.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Calculator.My.Resources.Resources.resourceCulture;
      set => Calculator.My.Resources.Resources.resourceCulture = value;
    }
  }
}
