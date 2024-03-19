using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXYPlotWidget
	/// </summary>
	/// <remarks>
	///    2D widget for manipulating a XY plot
	///
	/// This class provides support for interactively manipulating the position,
	/// size, and orientation of a XY Plot. It listens to Left mouse events and
	/// mouse movement. It will change the cursor shape based on its location. If
	/// the cursor is over an edge of thea XY plot it will change the cursor shape
	/// to a resize edge shape. If the position of a XY plot is moved to be close to
	/// the center of one of the four edges of the viewport, then the XY plot will
	/// change its orientation to align with that edge. This orientation is sticky
	/// in that it will stay that orientation until the position is moved close to
	/// another edge.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorObserver
	/// </seealso>
	// Token: 0x02000390 RID: 912
	public class vtkXYPlotWidget : vtkInteractorObserver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A5DB RID: 42459 RVA: 0x000EB60F File Offset: 0x000E980F
		static vtkXYPlotWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXYPlotWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXYPlotWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A5DC RID: 42460 RVA: 0x000EB637 File Offset: 0x000E9837
		public vtkXYPlotWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A5DD RID: 42461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYPlotWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5DE RID: 42462 RVA: 0x000EB648 File Offset: 0x000E9848
		public new static vtkXYPlotWidget New()
		{
			vtkXYPlotWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYPlotWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5DF RID: 42463 RVA: 0x000EB69C File Offset: 0x000E989C
		public vtkXYPlotWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXYPlotWidget.vtkXYPlotWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A5E0 RID: 42464 RVA: 0x000EB6E0 File Offset: 0x000E98E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A5E1 RID: 42465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXYPlotWidget_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5E2 RID: 42466 RVA: 0x000EB6EC File Offset: 0x000E98EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXYPlotWidget.vtkXYPlotWidget_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600A5E3 RID: 42467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXYPlotWidget_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5E4 RID: 42468 RVA: 0x000EB70C File Offset: 0x000E990C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXYPlotWidget.vtkXYPlotWidget_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600A5E5 RID: 42469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYPlotWidget_GetXYPlotActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the XY plot used by this Widget. One is created automatically.
		/// </summary>
		// Token: 0x0600A5E6 RID: 42470 RVA: 0x000EB728 File Offset: 0x000E9928
		public virtual vtkXYPlotActor GetXYPlotActor()
		{
			vtkXYPlotActor vtkXYPlotActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_GetXYPlotActor_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYPlotActor = (vtkXYPlotActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYPlotActor.Register(null);
				}
			}
			return vtkXYPlotActor;
		}

		// Token: 0x0600A5E7 RID: 42471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYPlotWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5E8 RID: 42472 RVA: 0x000EB798 File Offset: 0x000E9998
		public override int IsA(string type)
		{
			return vtkXYPlotWidget.vtkXYPlotWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A5E9 RID: 42473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYPlotWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5EA RID: 42474 RVA: 0x000EB7B8 File Offset: 0x000E99B8
		public new static int IsTypeOf(string type)
		{
			return vtkXYPlotWidget.vtkXYPlotWidget_IsTypeOf_05(type);
		}

		// Token: 0x0600A5EB RID: 42475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYPlotWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5EC RID: 42476 RVA: 0x000EB7D4 File Offset: 0x000E99D4
		public new vtkXYPlotWidget NewInstance()
		{
			vtkXYPlotWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYPlotWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A5ED RID: 42477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYPlotWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A5EE RID: 42478 RVA: 0x000EB830 File Offset: 0x000E9A30
		public new static vtkXYPlotWidget SafeDownCast(vtkObjectBase o)
		{
			vtkXYPlotWidget vtkXYPlotWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYPlotWidget = (vtkXYPlotWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYPlotWidget.Register(null);
				}
			}
			return vtkXYPlotWidget;
		}

		// Token: 0x0600A5EF RID: 42479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXYPlotWidget_SetEnabled_09(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods for turning the interactor observer on and off.
		/// </summary>
		// Token: 0x0600A5F0 RID: 42480 RVA: 0x000EB8AF File Offset: 0x000E9AAF
		public override void SetEnabled(int arg0)
		{
			vtkXYPlotWidget.vtkXYPlotWidget_SetEnabled_09(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A5F1 RID: 42481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXYPlotWidget_SetXYPlotActor_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the XY plot used by this Widget. One is created automatically.
		/// </summary>
		// Token: 0x0600A5F2 RID: 42482 RVA: 0x000EB8C0 File Offset: 0x000E9AC0
		public virtual void SetXYPlotActor(vtkXYPlotActor arg0)
		{
			vtkXYPlotWidget.vtkXYPlotWidget_SetXYPlotActor_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D55 RID: 3413
		public new const string MRFullTypeName = "Kitware.VTK.vtkXYPlotWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D56 RID: 3414
		public new static readonly string MRClassNameKey = "class vtkXYPlotWidget";
	}
}
