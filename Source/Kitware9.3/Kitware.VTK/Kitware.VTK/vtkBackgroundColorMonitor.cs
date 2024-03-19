using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBackgroundColorMonitor
	/// tracks state of background color(s).
	///
	///
	/// vtkBackgroundColorMonitor -- A helper for painters that
	/// tracks state of background color(s). A Painter could use this
	/// to skip expensive processing that is only needed when
	/// background color changes. This class queries VTK renderer
	/// rather than OpenGL state in order to support VTK's gradient
	/// background.
	///
	/// this is not intended to be shared. each object should use it's
	/// own instance of this class. it's intended to be called once per
	/// render.
	/// </summary>
	// Token: 0x020007C9 RID: 1993
	public class vtkBackgroundColorMonitor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014654 RID: 83540 RVA: 0x001CDDF7 File Offset: 0x001CBFF7
		static vtkBackgroundColorMonitor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBackgroundColorMonitor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBackgroundColorMonitor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014655 RID: 83541 RVA: 0x001CDE1F File Offset: 0x001CC01F
		public vtkBackgroundColorMonitor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014656 RID: 83542
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBackgroundColorMonitor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014657 RID: 83543 RVA: 0x001CDE30 File Offset: 0x001CC030
		public new static vtkBackgroundColorMonitor New()
		{
			vtkBackgroundColorMonitor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBackgroundColorMonitor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014658 RID: 83544 RVA: 0x001CDE84 File Offset: 0x001CC084
		public vtkBackgroundColorMonitor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014659 RID: 83545 RVA: 0x001CDEC8 File Offset: 0x001CC0C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601465A RID: 83546
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBackgroundColorMonitor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601465B RID: 83547 RVA: 0x001CDED4 File Offset: 0x001CC0D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601465C RID: 83548
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBackgroundColorMonitor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601465D RID: 83549 RVA: 0x001CDEF4 File Offset: 0x001CC0F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601465E RID: 83550
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBackgroundColorMonitor_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601465F RID: 83551 RVA: 0x001CDF10 File Offset: 0x001CC110
		public override int IsA(string type)
		{
			return vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06014660 RID: 83552
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBackgroundColorMonitor_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014661 RID: 83553 RVA: 0x001CDF30 File Offset: 0x001CC130
		public new static int IsTypeOf(string type)
		{
			return vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_IsTypeOf_04(type);
		}

		// Token: 0x06014662 RID: 83554
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBackgroundColorMonitor_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014663 RID: 83555 RVA: 0x001CDF4C File Offset: 0x001CC14C
		public new vtkBackgroundColorMonitor NewInstance()
		{
			vtkBackgroundColorMonitor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBackgroundColorMonitor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014664 RID: 83556
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBackgroundColorMonitor_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014665 RID: 83557 RVA: 0x001CDFA8 File Offset: 0x001CC1A8
		public new static vtkBackgroundColorMonitor SafeDownCast(vtkObjectBase o)
		{
			vtkBackgroundColorMonitor vtkBackgroundColorMonitor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBackgroundColorMonitor = (vtkBackgroundColorMonitor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBackgroundColorMonitor.Register(null);
				}
			}
			return vtkBackgroundColorMonitor;
		}

		// Token: 0x06014666 RID: 83558
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBackgroundColorMonitor_StateChanged_08(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Fetches the current background color state and
		/// updates the internal copies of the data. returns
		/// true if any of the tracked colors or modes have
		/// changed. Typically this is the only function a
		/// user needs to call.
		/// </summary>
		// Token: 0x06014667 RID: 83559 RVA: 0x001CE028 File Offset: 0x001CC228
		public bool StateChanged(vtkRenderer ren)
		{
			return vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_StateChanged_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis()) != 0;
		}

		// Token: 0x06014668 RID: 83560
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBackgroundColorMonitor_Update_09(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Update the internal state if anything changed. Note,
		/// this is done automatically in SateChanged.
		/// </summary>
		// Token: 0x06014669 RID: 83561 RVA: 0x001CE064 File Offset: 0x001CC264
		public void Update(vtkRenderer ren)
		{
			vtkBackgroundColorMonitor.vtkBackgroundColorMonitor_Update_09(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017B0 RID: 6064
		public new const string MRFullTypeName = "Kitware.VTK.vtkBackgroundColorMonitor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017B1 RID: 6065
		public new static readonly string MRClassNameKey = "class vtkBackgroundColorMonitor";
	}
}
