using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Instantiate this class.
	/// </summary>
	// Token: 0x0200031D RID: 797
	public class vtkFocalPlanePointPlacer : vtkPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008EDC RID: 36572 RVA: 0x000CBA5A File Offset: 0x000C9C5A
		static vtkFocalPlanePointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFocalPlanePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFocalPlanePointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008EDD RID: 36573 RVA: 0x000CBA82 File Offset: 0x000C9C82
		public vtkFocalPlanePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008EDE RID: 36574
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFocalPlanePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008EDF RID: 36575 RVA: 0x000CBA90 File Offset: 0x000C9C90
		public new static vtkFocalPlanePointPlacer New()
		{
			vtkFocalPlanePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008EE0 RID: 36576 RVA: 0x000CBAE4 File Offset: 0x000C9CE4
		public vtkFocalPlanePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008EE1 RID: 36577 RVA: 0x000CBB28 File Offset: 0x000C9D28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008EE2 RID: 36578
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlanePointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008EE3 RID: 36579 RVA: 0x000CBB34 File Offset: 0x000C9D34
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ComputeWorldPosition_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x06008EE4 RID: 36580
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlanePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position, and a reference
		/// world position, compute a new world position. The
		/// orientation will be the standard coordinate axes, and the
		/// computed world position will be created by projecting
		/// the display point onto a plane that is parallel to
		/// the focal plane and runs through the reference world
		/// position. This method is typically used to move existing
		/// points.
		/// </summary>
		// Token: 0x06008EE5 RID: 36581 RVA: 0x000CBB6C File Offset: 0x000C9D6C
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x06008EE6 RID: 36582
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008EE7 RID: 36583 RVA: 0x000CBBA8 File Offset: 0x000C9DA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008EE8 RID: 36584
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008EE9 RID: 36585 RVA: 0x000CBBC8 File Offset: 0x000C9DC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008EEA RID: 36586
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFocalPlanePointPlacer_GetOffset_05(HandleRef pThis);

		/// <summary>
		/// Optionally specify a signed offset from the focal plane for the points to
		/// be placed at.  If negative, the constraint plane is offset closer to the
		/// camera. If positive, its further away from the camera.
		/// </summary>
		// Token: 0x06008EEB RID: 36587 RVA: 0x000CBBE4 File Offset: 0x000C9DE4
		public virtual double GetOffset()
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetOffset_05(base.GetCppThis());
		}

		// Token: 0x06008EEC RID: 36588
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFocalPlanePointPlacer_GetPointBounds_06(HandleRef pThis);

		/// <summary>
		/// Optionally Restrict the points to a set of bounds. The placer will
		/// invalidate points outside these bounds.
		/// </summary>
		// Token: 0x06008EED RID: 36589 RVA: 0x000CBC04 File Offset: 0x000C9E04
		public virtual double[] GetPointBounds()
		{
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetPointBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008EEE RID: 36590
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFocalPlanePointPlacer_GetPointBounds_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Optionally Restrict the points to a set of bounds. The placer will
		/// invalidate points outside these bounds.
		/// </summary>
		// Token: 0x06008EEF RID: 36591 RVA: 0x000CBC4C File Offset: 0x000C9E4C
		public virtual void GetPointBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetPointBounds_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06008EF0 RID: 36592
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFocalPlanePointPlacer_GetPointBounds_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Optionally Restrict the points to a set of bounds. The placer will
		/// invalidate points outside these bounds.
		/// </summary>
		// Token: 0x06008EF1 RID: 36593 RVA: 0x000CBC64 File Offset: 0x000C9E64
		public virtual void GetPointBounds(IntPtr _arg)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetPointBounds_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06008EF2 RID: 36594
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlanePointPlacer_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008EF3 RID: 36595 RVA: 0x000CBC74 File Offset: 0x000C9E74
		public override int IsA(string type)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06008EF4 RID: 36596
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlanePointPlacer_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008EF5 RID: 36597 RVA: 0x000CBC94 File Offset: 0x000C9E94
		public new static int IsTypeOf(string type)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_IsTypeOf_10(type);
		}

		// Token: 0x06008EF6 RID: 36598
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFocalPlanePointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008EF7 RID: 36599 RVA: 0x000CBCB0 File Offset: 0x000C9EB0
		public new vtkFocalPlanePointPlacer NewInstance()
		{
			vtkFocalPlanePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008EF8 RID: 36600
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFocalPlanePointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008EF9 RID: 36601 RVA: 0x000CBD0C File Offset: 0x000C9F0C
		public new static vtkFocalPlanePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkFocalPlanePointPlacer vtkFocalPlanePointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFocalPlanePointPlacer = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFocalPlanePointPlacer.Register(null);
				}
			}
			return vtkFocalPlanePointPlacer;
		}

		// Token: 0x06008EFA RID: 36602
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFocalPlanePointPlacer_SetOffset_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Optionally specify a signed offset from the focal plane for the points to
		/// be placed at.  If negative, the constraint plane is offset closer to the
		/// camera. If positive, its further away from the camera.
		/// </summary>
		// Token: 0x06008EFB RID: 36603 RVA: 0x000CBD8B File Offset: 0x000C9F8B
		public virtual void SetOffset(double _arg)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SetOffset_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06008EFC RID: 36604
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFocalPlanePointPlacer_SetPointBounds_15(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Optionally Restrict the points to a set of bounds. The placer will
		/// invalidate points outside these bounds.
		/// </summary>
		// Token: 0x06008EFD RID: 36605 RVA: 0x000CBD9B File Offset: 0x000C9F9B
		public virtual void SetPointBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SetPointBounds_15(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06008EFE RID: 36606
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFocalPlanePointPlacer_SetPointBounds_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Optionally Restrict the points to a set of bounds. The placer will
		/// invalidate points outside these bounds.
		/// </summary>
		// Token: 0x06008EFF RID: 36607 RVA: 0x000CBDB3 File Offset: 0x000C9FB3
		public virtual void SetPointBounds(IntPtr _arg)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SetPointBounds_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F00 RID: 36608
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlanePointPlacer_ValidateWorldPosition_17(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Validate a world position. All world positions
		/// are valid so these methods always return 1.
		/// </summary>
		// Token: 0x06008F01 RID: 36609 RVA: 0x000CBDC4 File Offset: 0x000C9FC4
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ValidateWorldPosition_17(base.GetCppThis(), worldPos);
		}

		// Token: 0x06008F02 RID: 36610
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFocalPlanePointPlacer_ValidateWorldPosition_18(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Validate a world position. All world positions
		/// are valid so these methods always return 1.
		/// </summary>
		// Token: 0x06008F03 RID: 36611 RVA: 0x000CBDE4 File Offset: 0x000C9FE4
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ValidateWorldPosition_18(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF4 RID: 3060
		public new const string MRFullTypeName = "Kitware.VTK.vtkFocalPlanePointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF5 RID: 3061
		public new static readonly string MRClassNameKey = "class vtkFocalPlanePointPlacer";
	}
}
