using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellCentersPointPlacer
	/// </summary>
	/// <remarks>
	///    Snaps points at the center of a cell
	///
	///
	/// vtkCellCentersPointPlacer is a class to snap points on the center of cells.
	/// The class has 3 modes. In the ParametricCenter mode, it snaps points
	/// to the parametric center of the cell (see vtkCell). In CellPointsMean
	/// mode, points are snapped to the mean of the points in the cell.
	/// In 'None' mode, no snapping is performed. The computed world position
	/// is the picked position within the cell.
	///
	/// @par Usage:
	/// The actors that render data and wish to be considered for placement
	/// by this placer are added to the list as
	/// <code>
	/// placer-&gt;AddProp( actor );
	/// </code>
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointPlacer
	/// </seealso>
	// Token: 0x020002EE RID: 750
	public class vtkCellCentersPointPlacer : vtkPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060086AF RID: 34479 RVA: 0x000C0557 File Offset: 0x000BE757
		static vtkCellCentersPointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellCentersPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellCentersPointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060086B0 RID: 34480 RVA: 0x000C057F File Offset: 0x000BE77F
		public vtkCellCentersPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060086B1 RID: 34481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCentersPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060086B2 RID: 34482 RVA: 0x000C0590 File Offset: 0x000BE790
		public new static vtkCellCentersPointPlacer New()
		{
			vtkCellCentersPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCentersPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060086B3 RID: 34483 RVA: 0x000C05E4 File Offset: 0x000BE7E4
		public vtkCellCentersPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060086B4 RID: 34484 RVA: 0x000C0628 File Offset: 0x000BE828
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060086B5 RID: 34485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCentersPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086B6 RID: 34486 RVA: 0x000C0634 File Offset: 0x000BE834
		public virtual void AddProp(vtkProp arg0)
		{
			vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_AddProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060086B7 RID: 34487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer and a display position in pixel coordinates,
		/// compute the world position and orientation where this point
		/// will be placed. This method is typically used by the
		/// representation to place the point initially.
		/// For the Terrain point placer this computes world points that
		/// lie at the specified height above the terrain.
		/// </summary>
		// Token: 0x060086B8 RID: 34488 RVA: 0x000C0664 File Offset: 0x000BE864
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x060086B9 RID: 34489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position, and a reference world
		/// position, compute the new world position and orientation
		/// of this point. This method is typically used by the
		/// representation to move the point.
		/// </summary>
		// Token: 0x060086BA RID: 34490 RVA: 0x000C069C File Offset: 0x000BE89C
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x060086BB RID: 34491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCentersPointPlacer_GetCellPicker_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the Prop picker.
		/// </summary>
		// Token: 0x060086BC RID: 34492 RVA: 0x000C06D8 File Offset: 0x000BE8D8
		public virtual vtkCellPicker GetCellPicker()
		{
			vtkCellPicker vtkCellPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_GetCellPicker_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellPicker = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellPicker.Register(null);
				}
			}
			return vtkCellPicker;
		}

		// Token: 0x060086BD RID: 34493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_GetMode_05(HandleRef pThis);

		/// <summary>
		/// Modes to change the point placement. Parametric center picks
		/// the parametric center within the cell. CellPointsMean picks
		/// the average of all points in the cell. When the mode is None,
		/// the input point is passed through unmodified. Default is CellPointsMean.
		/// </summary>
		// Token: 0x060086BE RID: 34494 RVA: 0x000C0748 File Offset: 0x000BE948
		public virtual int GetMode()
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_GetMode_05(base.GetCppThis());
		}

		// Token: 0x060086BF RID: 34495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086C0 RID: 34496 RVA: 0x000C0768 File Offset: 0x000BE968
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060086C1 RID: 34497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086C2 RID: 34498 RVA: 0x000C0788 File Offset: 0x000BE988
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060086C3 RID: 34499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_GetNumberOfProps_08(HandleRef pThis);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086C4 RID: 34500 RVA: 0x000C07A4 File Offset: 0x000BE9A4
		public int GetNumberOfProps()
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_GetNumberOfProps_08(base.GetCppThis());
		}

		// Token: 0x060086C5 RID: 34501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_HasProp_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086C6 RID: 34502 RVA: 0x000C07C4 File Offset: 0x000BE9C4
		public int HasProp(vtkProp arg0)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_HasProp_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060086C7 RID: 34503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086C8 RID: 34504 RVA: 0x000C07F8 File Offset: 0x000BE9F8
		public override int IsA(string type)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060086C9 RID: 34505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086CA RID: 34506 RVA: 0x000C0818 File Offset: 0x000BEA18
		public new static int IsTypeOf(string type)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_IsTypeOf_11(type);
		}

		// Token: 0x060086CB RID: 34507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCentersPointPlacer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086CC RID: 34508 RVA: 0x000C0834 File Offset: 0x000BEA34
		public new vtkCellCentersPointPlacer NewInstance()
		{
			vtkCellCentersPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCentersPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060086CD RID: 34509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCentersPointPlacer_RemoveAllProps_14(HandleRef pThis);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086CE RID: 34510 RVA: 0x000C088E File Offset: 0x000BEA8E
		public virtual void RemoveAllProps()
		{
			vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_RemoveAllProps_14(base.GetCppThis());
		}

		// Token: 0x060086CF RID: 34511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCentersPointPlacer_RemoveViewProp_15(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086D0 RID: 34512 RVA: 0x000C08A0 File Offset: 0x000BEAA0
		public virtual void RemoveViewProp(vtkProp prop)
		{
			vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_RemoveViewProp_15(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060086D1 RID: 34513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellCentersPointPlacer_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060086D2 RID: 34514 RVA: 0x000C08D0 File Offset: 0x000BEAD0
		public new static vtkCellCentersPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkCellCentersPointPlacer vtkCellCentersPointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellCentersPointPlacer = (vtkCellCentersPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellCentersPointPlacer.Register(null);
				}
			}
			return vtkCellCentersPointPlacer;
		}

		// Token: 0x060086D3 RID: 34515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellCentersPointPlacer_SetMode_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Modes to change the point placement. Parametric center picks
		/// the parametric center within the cell. CellPointsMean picks
		/// the average of all points in the cell. When the mode is None,
		/// the input point is passed through unmodified. Default is CellPointsMean.
		/// </summary>
		// Token: 0x060086D4 RID: 34516 RVA: 0x000C094F File Offset: 0x000BEB4F
		public virtual void SetMode(int _arg)
		{
			vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_SetMode_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060086D5 RID: 34517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_ValidateDisplayPosition_18(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		/// <summary>
		/// Given a display position, check the validity of this position.
		/// </summary>
		// Token: 0x060086D6 RID: 34518 RVA: 0x000C0960 File Offset: 0x000BEB60
		public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_ValidateDisplayPosition_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		// Token: 0x060086D7 RID: 34519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_ValidateWorldPosition_19(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Given a world position check the validity of this
		/// position according to the constraints of the placer
		/// </summary>
		// Token: 0x060086D8 RID: 34520 RVA: 0x000C0998 File Offset: 0x000BEB98
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_ValidateWorldPosition_19(base.GetCppThis(), worldPos);
		}

		// Token: 0x060086D9 RID: 34521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellCentersPointPlacer_ValidateWorldPosition_20(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a world position and a world orientation,
		/// validate it according to the constraints of the placer.
		/// </summary>
		// Token: 0x060086DA RID: 34522 RVA: 0x000C09B8 File Offset: 0x000BEBB8
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkCellCentersPointPlacer.vtkCellCentersPointPlacer_ValidateWorldPosition_20(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B5D RID: 2909
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellCentersPointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B5E RID: 2910
		public new static readonly string MRClassNameKey = "class vtkCellCentersPointPlacer";

		/// <summary>
		/// Modes to change the point placement. Parametric center picks
		/// the parametric center within the cell. CellPointsMean picks
		/// the average of all points in the cell. When the mode is None,
		/// the input point is passed through unmodified. Default is CellPointsMean.
		/// </summary>
		// Token: 0x020002EF RID: 751
		public enum CellPointsMean_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B60 RID: 2912
			CellPointsMean = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B61 RID: 2913
			None,
			/// <summary>enum member</summary>
			// Token: 0x04000B62 RID: 2914
			ParametricCenter = 0
		}
	}
}
