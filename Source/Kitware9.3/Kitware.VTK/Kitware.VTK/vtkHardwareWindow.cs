using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHardwareWindow
	/// </summary>
	/// <remarks>
	///    create a window for renderers to draw into
	///
	/// vtkHardwareWindow is an abstract object representing a UI based
	/// window that can be drawn to. This class is defines an interface that
	/// GUI specific subclasses (Win32, X, Cocoa) should support.
	///
	/// This class is meant to be Graphics library agnostic. In that it should
	/// contain as little graphics library specific code as possible, ideally none.
	/// In contrast to classes such as vtkWinOpenGLRenderWindow which contain
	/// significant ties to OpenGL.
	///
	/// </remarks>
	// Token: 0x020005FC RID: 1532
	public class vtkHardwareWindow : vtkWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060109F7 RID: 68087 RVA: 0x00173304 File Offset: 0x00171504
		static vtkHardwareWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHardwareWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHardwareWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060109F8 RID: 68088 RVA: 0x0017332C File Offset: 0x0017152C
		public vtkHardwareWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060109F9 RID: 68089
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109FA RID: 68090 RVA: 0x0017333C File Offset: 0x0017153C
		public new static vtkHardwareWindow New()
		{
			vtkHardwareWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareWindow.vtkHardwareWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109FB RID: 68091 RVA: 0x00173390 File Offset: 0x00171590
		public vtkHardwareWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHardwareWindow.vtkHardwareWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060109FC RID: 68092 RVA: 0x001733D4 File Offset: 0x001715D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060109FD RID: 68093
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareWindow_Create_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109FE RID: 68094 RVA: 0x001733DF File Offset: 0x001715DF
		public virtual void Create()
		{
			vtkHardwareWindow.vtkHardwareWindow_Create_01(base.GetCppThis());
		}

		// Token: 0x060109FF RID: 68095
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHardwareWindow_Destroy_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A00 RID: 68096 RVA: 0x001733EE File Offset: 0x001715EE
		public virtual void Destroy()
		{
			vtkHardwareWindow.vtkHardwareWindow_Destroy_02(base.GetCppThis());
		}

		// Token: 0x06010A01 RID: 68097
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwareWindow_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A02 RID: 68098 RVA: 0x00173400 File Offset: 0x00171600
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHardwareWindow.vtkHardwareWindow_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010A03 RID: 68099
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHardwareWindow_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A04 RID: 68100 RVA: 0x00173420 File Offset: 0x00171620
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHardwareWindow.vtkHardwareWindow_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010A05 RID: 68101
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwareWindow_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A06 RID: 68102 RVA: 0x0017343C File Offset: 0x0017163C
		public override int IsA(string type)
		{
			return vtkHardwareWindow.vtkHardwareWindow_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06010A07 RID: 68103
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHardwareWindow_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A08 RID: 68104 RVA: 0x0017345C File Offset: 0x0017165C
		public new static int IsTypeOf(string type)
		{
			return vtkHardwareWindow.vtkHardwareWindow_IsTypeOf_06(type);
		}

		// Token: 0x06010A09 RID: 68105
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareWindow_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A0A RID: 68106 RVA: 0x00173478 File Offset: 0x00171678
		public new vtkHardwareWindow NewInstance()
		{
			vtkHardwareWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareWindow.vtkHardwareWindow_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010A0B RID: 68107
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHardwareWindow_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A0C RID: 68108 RVA: 0x001734D4 File Offset: 0x001716D4
		public new static vtkHardwareWindow SafeDownCast(vtkObjectBase o)
		{
			vtkHardwareWindow vtkHardwareWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHardwareWindow.vtkHardwareWindow_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwareWindow = (vtkHardwareWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwareWindow.Register(null);
				}
			}
			return vtkHardwareWindow;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400134E RID: 4942
		public new const string MRFullTypeName = "Kitware.VTK.vtkHardwareWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400134F RID: 4943
		public new static readonly string MRClassNameKey = "class vtkHardwareWindow";
	}
}
