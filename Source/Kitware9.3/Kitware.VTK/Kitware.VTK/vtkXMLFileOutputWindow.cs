using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLFileOutputWindow
	/// </summary>
	/// <remarks>
	///    XML File Specific output window class
	///
	/// Writes debug/warning/error output to an XML file. Uses prefined XML
	/// tags for each text display method. The text is processed to replace
	/// XML markup characters.
	///
	///   DisplayText - \&lt;Text\&gt;
	///
	///   DisplayErrorText - \&lt;Error\&gt;
	///
	///   DisplayWarningText - \&lt;Warning\&gt;
	///
	///   DisplayGenericWarningText - \&lt;GenericWarning\&gt;
	///
	///   DisplayDebugText - \&lt;Debug\&gt;
	///
	/// The method DisplayTag outputs the text unprocessed. To use this
	/// class, instantiate it and then call SetInstance(this).
	/// </remarks>
	// Token: 0x02000B8B RID: 2955
	public class vtkXMLFileOutputWindow : vtkFileOutputWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ED29 RID: 126249 RVA: 0x002BB7C7 File Offset: 0x002B99C7
		static vtkXMLFileOutputWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLFileOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLFileOutputWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED2A RID: 126250 RVA: 0x002BB7EF File Offset: 0x002B99EF
		public vtkXMLFileOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ED2B RID: 126251
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED2C RID: 126252 RVA: 0x002BB800 File Offset: 0x002B9A00
		public new static vtkXMLFileOutputWindow New()
		{
			vtkXMLFileOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED2D RID: 126253 RVA: 0x002BB854 File Offset: 0x002B9A54
		public vtkXMLFileOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED2E RID: 126254 RVA: 0x002BB898 File Offset: 0x002B9A98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ED2F RID: 126255
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLFileOutputWindow_DisplayDebugText_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file. The text is processed to
		/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
		/// Each display method outputs a different XML tag.
		/// </summary>
		// Token: 0x0601ED30 RID: 126256 RVA: 0x002BB8A3 File Offset: 0x002B9AA3
		public override void DisplayDebugText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayDebugText_01(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED31 RID: 126257
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLFileOutputWindow_DisplayErrorText_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file. The text is processed to
		/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
		/// Each display method outputs a different XML tag.
		/// </summary>
		// Token: 0x0601ED32 RID: 126258 RVA: 0x002BB8B3 File Offset: 0x002B9AB3
		public override void DisplayErrorText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayErrorText_02(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED33 RID: 126259
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLFileOutputWindow_DisplayGenericWarningText_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file. The text is processed to
		/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
		/// Each display method outputs a different XML tag.
		/// </summary>
		// Token: 0x0601ED34 RID: 126260 RVA: 0x002BB8C3 File Offset: 0x002B9AC3
		public override void DisplayGenericWarningText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayGenericWarningText_03(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED35 RID: 126261
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLFileOutputWindow_DisplayTag_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file without processing it.
		/// </summary>
		// Token: 0x0601ED36 RID: 126262 RVA: 0x002BB8D3 File Offset: 0x002B9AD3
		public virtual void DisplayTag(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayTag_04(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED37 RID: 126263
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLFileOutputWindow_DisplayText_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file. The text is processed to
		/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
		/// Each display method outputs a different XML tag.
		/// </summary>
		// Token: 0x0601ED38 RID: 126264 RVA: 0x002BB8E3 File Offset: 0x002B9AE3
		public override void DisplayText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayText_05(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED39 RID: 126265
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLFileOutputWindow_DisplayWarningText_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file. The text is processed to
		/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
		/// Each display method outputs a different XML tag.
		/// </summary>
		// Token: 0x0601ED3A RID: 126266 RVA: 0x002BB8F3 File Offset: 0x002B9AF3
		public override void DisplayWarningText(string arg0)
		{
			vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_DisplayWarningText_06(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED3B RID: 126267
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED3C RID: 126268 RVA: 0x002BB904 File Offset: 0x002B9B04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601ED3D RID: 126269
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED3E RID: 126270 RVA: 0x002BB924 File Offset: 0x002B9B24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601ED3F RID: 126271
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLFileOutputWindow_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED40 RID: 126272 RVA: 0x002BB940 File Offset: 0x002B9B40
		public override int IsA(string type)
		{
			return vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601ED41 RID: 126273
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLFileOutputWindow_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED42 RID: 126274 RVA: 0x002BB960 File Offset: 0x002B9B60
		public new static int IsTypeOf(string type)
		{
			return vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_IsTypeOf_10(type);
		}

		// Token: 0x0601ED43 RID: 126275
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileOutputWindow_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED44 RID: 126276 RVA: 0x002BB97C File Offset: 0x002B9B7C
		public new vtkXMLFileOutputWindow NewInstance()
		{
			vtkXMLFileOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ED45 RID: 126277
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileOutputWindow_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED46 RID: 126278 RVA: 0x002BB9D8 File Offset: 0x002B9BD8
		public new static vtkXMLFileOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkXMLFileOutputWindow vtkXMLFileOutputWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLFileOutputWindow.vtkXMLFileOutputWindow_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLFileOutputWindow = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLFileOutputWindow.Register(null);
				}
			}
			return vtkXMLFileOutputWindow;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002106 RID: 8454
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLFileOutputWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002107 RID: 8455
		public new static readonly string MRClassNameKey = "class vtkXMLFileOutputWindow";
	}
}
