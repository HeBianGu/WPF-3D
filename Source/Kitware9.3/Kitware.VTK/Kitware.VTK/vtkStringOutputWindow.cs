using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStringOutputWindow
	/// </summary>
	/// <remarks>
	///    File Specific output window class
	///
	/// Writes debug/warning/error output to a log file instead of the console.
	/// To use this class, instantiate it and then call SetInstance(this).
	///
	/// </remarks>
	// Token: 0x02000B7F RID: 2943
	public class vtkStringOutputWindow : vtkOutputWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EB83 RID: 125827 RVA: 0x002B90EC File Offset: 0x002B72EC
		static vtkStringOutputWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringOutputWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB84 RID: 125828 RVA: 0x002B9114 File Offset: 0x002B7314
		public vtkStringOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EB85 RID: 125829
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB86 RID: 125830 RVA: 0x002B9124 File Offset: 0x002B7324
		public new static vtkStringOutputWindow New()
		{
			vtkStringOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringOutputWindow.vtkStringOutputWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB87 RID: 125831 RVA: 0x002B9178 File Offset: 0x002B7378
		public vtkStringOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStringOutputWindow.vtkStringOutputWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB88 RID: 125832 RVA: 0x002B91BC File Offset: 0x002B73BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EB89 RID: 125833
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringOutputWindow_DisplayText_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file.
		/// New lines are converted to carriage return new lines.
		/// </summary>
		// Token: 0x0601EB8A RID: 125834 RVA: 0x002B91C7 File Offset: 0x002B73C7
		public override void DisplayText(string arg0)
		{
			vtkStringOutputWindow.vtkStringOutputWindow_DisplayText_01(base.GetCppThis(), arg0);
		}

		// Token: 0x0601EB8B RID: 125835
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringOutputWindow_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB8C RID: 125836 RVA: 0x002B91D8 File Offset: 0x002B73D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStringOutputWindow.vtkStringOutputWindow_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601EB8D RID: 125837
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringOutputWindow_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB8E RID: 125838 RVA: 0x002B91F8 File Offset: 0x002B73F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStringOutputWindow.vtkStringOutputWindow_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601EB8F RID: 125839
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkStringOutputWindow_GetOutput_04(HandleRef pThis);

		/// <summary>
		/// Get the current output as a string
		/// </summary>
		// Token: 0x0601EB90 RID: 125840 RVA: 0x002B9214 File Offset: 0x002B7414
		public string GetOutput()
		{
			return vtkStringOutputWindow.vtkStringOutputWindow_GetOutput_04(base.GetCppThis());
		}

		// Token: 0x0601EB91 RID: 125841
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringOutputWindow_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB92 RID: 125842 RVA: 0x002B9234 File Offset: 0x002B7434
		public override int IsA(string type)
		{
			return vtkStringOutputWindow.vtkStringOutputWindow_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601EB93 RID: 125843
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringOutputWindow_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB94 RID: 125844 RVA: 0x002B9254 File Offset: 0x002B7454
		public new static int IsTypeOf(string type)
		{
			return vtkStringOutputWindow.vtkStringOutputWindow_IsTypeOf_06(type);
		}

		// Token: 0x0601EB95 RID: 125845
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringOutputWindow_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB96 RID: 125846 RVA: 0x002B9270 File Offset: 0x002B7470
		public new vtkStringOutputWindow NewInstance()
		{
			vtkStringOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringOutputWindow.vtkStringOutputWindow_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EB97 RID: 125847
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringOutputWindow_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB98 RID: 125848 RVA: 0x002B92CC File Offset: 0x002B74CC
		public new static vtkStringOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkStringOutputWindow vtkStringOutputWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringOutputWindow.vtkStringOutputWindow_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringOutputWindow = (vtkStringOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringOutputWindow.Register(null);
				}
			}
			return vtkStringOutputWindow;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020E5 RID: 8421
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringOutputWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020E6 RID: 8422
		public new static readonly string MRClassNameKey = "class vtkStringOutputWindow";
	}
}
