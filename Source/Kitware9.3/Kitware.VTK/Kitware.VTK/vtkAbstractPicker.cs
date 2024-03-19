using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractPicker
	/// </summary>
	/// <remarks>
	///    define API for picking subclasses
	///
	/// vtkAbstractPicker is an abstract superclass that defines a minimal API
	/// for its concrete subclasses. The minimum functionality of a picker is
	/// to return the x-y-z global coordinate position of a pick (the pick
	/// itself is defined in display coordinates).
	///
	/// The API to this class is to invoke the Pick() method with a selection
	/// point (in display coordinates - pixels) and a renderer. Then get the
	/// resulting pick position in global coordinates with the GetPickPosition()
	/// method.
	///
	/// vtkPicker fires events during the picking process.  These
	/// events are StartPickEvent, PickEvent, and EndPickEvent which are
	/// invoked prior to picking, when something is picked, and after all picking
	/// candidates have been tested. Note that during the pick process the
	/// PickEvent of vtkProp (and its subclasses such as vtkActor) is fired
	/// prior to the PickEvent of vtkPicker.
	///
	/// @warning
	/// vtkAbstractPicker and its subclasses will not pick props that are
	/// "unpickable" (see vtkProp) or are fully transparent (if transparency
	/// is a property of the vtkProp).
	///
	/// @warning
	/// There are two classes of pickers: those that pick using geometric methods
	/// (typically a ray cast); and those that use rendering hardware. Geometric
	/// methods return more information but are slower. Hardware methods are much
	/// faster and return minimal information. Examples of geometric pickers
	/// include vtkPicker, vtkCellPicker, and vtkPointPicker. Examples of hardware
	/// pickers include vtkWorldPointPicker and vtkPropPicker.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPropPicker uses hardware acceleration to pick an instance of vtkProp.
	/// (This means that 2D and 3D props can be picked, and it's relatively fast.)
	/// If you need to pick cells or points, you might wish to use vtkCellPicker
	/// or vtkPointPicker. vtkWorldPointPicker is the fastest picker, returning
	/// an x-y-z coordinate value using the hardware z-buffer. vtkPicker can be
	/// used to pick the bounding box of 3D props.
	/// </seealso>
	// Token: 0x020000BC RID: 188
	public abstract class vtkAbstractPicker : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002956 RID: 10582 RVA: 0x0003CE3F File Offset: 0x0003B03F
		static vtkAbstractPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002957 RID: 10583 RVA: 0x0003CE67 File Offset: 0x0003B067
		public vtkAbstractPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002958 RID: 10584 RVA: 0x0003CE75 File Offset: 0x0003B075
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002959 RID: 10585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_AddPickList_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an actor to the pick list.
		/// </summary>
		// Token: 0x0600295A RID: 10586 RVA: 0x0003CE80 File Offset: 0x0003B080
		public void AddPickList(vtkProp arg0)
		{
			vtkAbstractPicker.vtkAbstractPicker_AddPickList_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600295B RID: 10587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_DeletePickList_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Delete an actor from the pick list.
		/// </summary>
		// Token: 0x0600295C RID: 10588 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		public void DeletePickList(vtkProp arg0)
		{
			vtkAbstractPicker.vtkAbstractPicker_DeletePickList_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600295D RID: 10589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPicker_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600295E RID: 10590 RVA: 0x0003CEE0 File Offset: 0x0003B0E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractPicker.vtkAbstractPicker_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600295F RID: 10591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPicker_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002960 RID: 10592 RVA: 0x0003CF00 File Offset: 0x0003B100
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractPicker.vtkAbstractPicker_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06002961 RID: 10593
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPicker_GetPickFromList_05(HandleRef pThis);

		/// <summary>
		/// Use these methods to control whether to limit the picking to this list
		/// (rather than renderer's actors). Make sure that the pick list contains
		/// actors that referred to by the picker's renderer.
		/// </summary>
		// Token: 0x06002962 RID: 10594 RVA: 0x0003CF1C File Offset: 0x0003B11C
		public virtual int GetPickFromList()
		{
			return vtkAbstractPicker.vtkAbstractPicker_GetPickFromList_05(base.GetCppThis());
		}

		// Token: 0x06002963 RID: 10595
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPicker_GetPickList_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the list of actors in the PickList.
		/// </summary>
		// Token: 0x06002964 RID: 10596 RVA: 0x0003CF3C File Offset: 0x0003B13C
		public vtkPropCollection GetPickList()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetPickList_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		// Token: 0x06002965 RID: 10597
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPicker_GetPickPosition_07(HandleRef pThis);

		/// <summary>
		/// Return position in global coordinates of pick point.
		/// </summary>
		// Token: 0x06002966 RID: 10598 RVA: 0x0003CFAC File Offset: 0x0003B1AC
		public virtual double[] GetPickPosition()
		{
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetPickPosition_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002967 RID: 10599
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_GetPickPosition_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Return position in global coordinates of pick point.
		/// </summary>
		// Token: 0x06002968 RID: 10600 RVA: 0x0003CFF4 File Offset: 0x0003B1F4
		public virtual void GetPickPosition(IntPtr data)
		{
			vtkAbstractPicker.vtkAbstractPicker_GetPickPosition_08(base.GetCppThis(), data);
		}

		// Token: 0x06002969 RID: 10601
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPicker_GetRenderer_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the renderer in which pick event occurred.
		/// </summary>
		// Token: 0x0600296A RID: 10602 RVA: 0x0003D004 File Offset: 0x0003B204
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetRenderer_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x0600296B RID: 10603
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPicker_GetSelectionPoint_10(HandleRef pThis);

		/// <summary>
		/// Get the selection point in screen (pixel) coordinates. The third
		/// value is related to z-buffer depth. (Normally should be =0.)
		/// </summary>
		// Token: 0x0600296C RID: 10604 RVA: 0x0003D074 File Offset: 0x0003B274
		public virtual double[] GetSelectionPoint()
		{
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetSelectionPoint_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600296D RID: 10605
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_GetSelectionPoint_11(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the selection point in screen (pixel) coordinates. The third
		/// value is related to z-buffer depth. (Normally should be =0.)
		/// </summary>
		// Token: 0x0600296E RID: 10606 RVA: 0x0003D0BC File Offset: 0x0003B2BC
		public virtual void GetSelectionPoint(IntPtr data)
		{
			vtkAbstractPicker.vtkAbstractPicker_GetSelectionPoint_11(base.GetCppThis(), data);
		}

		// Token: 0x0600296F RID: 10607
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_InitializePickList_12(HandleRef pThis);

		/// <summary>
		/// Initialize list of actors in pick list.
		/// </summary>
		// Token: 0x06002970 RID: 10608 RVA: 0x0003D0CC File Offset: 0x0003B2CC
		public void InitializePickList()
		{
			vtkAbstractPicker.vtkAbstractPicker_InitializePickList_12(base.GetCppThis());
		}

		// Token: 0x06002971 RID: 10609
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPicker_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002972 RID: 10610 RVA: 0x0003D0DC File Offset: 0x0003B2DC
		public override int IsA(string type)
		{
			return vtkAbstractPicker.vtkAbstractPicker_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06002973 RID: 10611
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPicker_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002974 RID: 10612 RVA: 0x0003D0FC File Offset: 0x0003B2FC
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPicker.vtkAbstractPicker_IsTypeOf_14(type);
		}

		// Token: 0x06002975 RID: 10613
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPicker_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002976 RID: 10614 RVA: 0x0003D118 File Offset: 0x0003B318
		public new vtkAbstractPicker NewInstance()
		{
			vtkAbstractPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002977 RID: 10615
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPicker_Pick_16(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		/// <summary>
		/// Perform pick operation with selection point provided. Normally the
		/// first two values for the selection point are x-y pixel coordinate, and
		/// the third value is =0. Return non-zero if something was successfully
		/// picked.
		/// </summary>
		// Token: 0x06002978 RID: 10616 RVA: 0x0003D174 File Offset: 0x0003B374
		public virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkAbstractPicker.vtkAbstractPicker_Pick_16(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06002979 RID: 10617
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPicker_Pick_17(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

		/// <summary>
		/// provided. Normally the first two values for the selection point
		/// are x-y pixel coordinate, and the third value is =0. Return
		/// non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x0600297A RID: 10618 RVA: 0x0003D1B0 File Offset: 0x0003B3B0
		public int Pick(IntPtr selectionPt, vtkRenderer ren)
		{
			return vtkAbstractPicker.vtkAbstractPicker_Pick_17(base.GetCppThis(), selectionPt, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600297B RID: 10619
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPicker_Pick3DPoint_18(HandleRef pThis, IntPtr arg0, HandleRef arg1);

		/// <summary>
		/// Perform pick operation with selection point provided. The
		/// selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x0600297C RID: 10620 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		public virtual int Pick3DPoint(IntPtr arg0, vtkRenderer arg1)
		{
			return vtkAbstractPicker.vtkAbstractPicker_Pick3DPoint_18(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600297D RID: 10621
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPicker_Pick3DRay_19(HandleRef pThis, IntPtr arg0, IntPtr arg1, HandleRef arg2);

		/// <summary>
		/// Perform pick operation with selection point and orientation provided.
		/// The selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x0600297E RID: 10622 RVA: 0x0003D220 File Offset: 0x0003B420
		public virtual int Pick3DRay(IntPtr arg0, IntPtr arg1, vtkRenderer arg2)
		{
			return vtkAbstractPicker.vtkAbstractPicker_Pick3DRay_19(base.GetCppThis(), arg0, arg1, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis());
		}

		// Token: 0x0600297F RID: 10623
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_PickFromListOff_20(HandleRef pThis);

		/// <summary>
		/// Use these methods to control whether to limit the picking to this list
		/// (rather than renderer's actors). Make sure that the pick list contains
		/// actors that referred to by the picker's renderer.
		/// </summary>
		// Token: 0x06002980 RID: 10624 RVA: 0x0003D256 File Offset: 0x0003B456
		public virtual void PickFromListOff()
		{
			vtkAbstractPicker.vtkAbstractPicker_PickFromListOff_20(base.GetCppThis());
		}

		// Token: 0x06002981 RID: 10625
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_PickFromListOn_21(HandleRef pThis);

		/// <summary>
		/// Use these methods to control whether to limit the picking to this list
		/// (rather than renderer's actors). Make sure that the pick list contains
		/// actors that referred to by the picker's renderer.
		/// </summary>
		// Token: 0x06002982 RID: 10626 RVA: 0x0003D265 File Offset: 0x0003B465
		public virtual void PickFromListOn()
		{
			vtkAbstractPicker.vtkAbstractPicker_PickFromListOn_21(base.GetCppThis());
		}

		// Token: 0x06002983 RID: 10627
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPicker_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002984 RID: 10628 RVA: 0x0003D274 File Offset: 0x0003B474
		public new static vtkAbstractPicker SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPicker vtkAbstractPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPicker = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPicker.Register(null);
				}
			}
			return vtkAbstractPicker;
		}

		// Token: 0x06002985 RID: 10629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPicker_SetPickFromList_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Use these methods to control whether to limit the picking to this list
		/// (rather than renderer's actors). Make sure that the pick list contains
		/// actors that referred to by the picker's renderer.
		/// </summary>
		// Token: 0x06002986 RID: 10630 RVA: 0x0003D2F3 File Offset: 0x0003B4F3
		public virtual void SetPickFromList(int _arg)
		{
			vtkAbstractPicker.vtkAbstractPicker_SetPickFromList_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000564 RID: 1380
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000565 RID: 1381
		public new static readonly string MRClassNameKey = "class vtkAbstractPicker";
	}
}
