using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursorActor
	/// </summary>
	/// <remarks>
	///    Represent a reslice cursor
	///
	/// A reslice cursor consists of a pair of lines (cross hairs), thin or thick,
	/// that may be interactively manipulated for thin/thick reformats through the
	/// data.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursor vtkResliceCursorPolyDataAlgorithm vtkResliceCursorWidget
	/// vtkResliceCursorRepresentation vtkResliceCursorLineRepresentation
	/// </seealso>
	// Token: 0x02000363 RID: 867
	public class vtkResliceCursorActor : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009DEA RID: 40426 RVA: 0x000DFAFA File Offset: 0x000DDCFA
		static vtkResliceCursorActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursorActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009DEB RID: 40427 RVA: 0x000DFB22 File Offset: 0x000DDD22
		public vtkResliceCursorActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009DEC RID: 40428
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009DED RID: 40429 RVA: 0x000DFB30 File Offset: 0x000DDD30
		public new static vtkResliceCursorActor New()
		{
			vtkResliceCursorActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009DEE RID: 40430 RVA: 0x000DFB84 File Offset: 0x000DDD84
		public vtkResliceCursorActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceCursorActor.vtkResliceCursorActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009DEF RID: 40431 RVA: 0x000DFBC8 File Offset: 0x000DDDC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009DF0 RID: 40432
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x06009DF1 RID: 40433 RVA: 0x000DFBD4 File Offset: 0x000DDDD4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009DF2 RID: 40434
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_GetCenterlineActor_02(HandleRef pThis, int axis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the centerline actor along a particular axis
		/// </summary>
		// Token: 0x06009DF3 RID: 40435 RVA: 0x000DFC1C File Offset: 0x000DDE1C
		public vtkActor GetCenterlineActor(int axis)
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_GetCenterlineActor_02(base.GetCppThis(), axis, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06009DF4 RID: 40436
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_GetCenterlineProperty_03(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get property of the internal actor.
		/// </summary>
		// Token: 0x06009DF5 RID: 40437 RVA: 0x000DFC8C File Offset: 0x000DDE8C
		public vtkProperty GetCenterlineProperty(int i)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_GetCenterlineProperty_03(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009DF6 RID: 40438
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_GetCursorAlgorithm_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cursor algorithm. The cursor must be set on the algorithm
		/// </summary>
		// Token: 0x06009DF7 RID: 40439 RVA: 0x000DFCFC File Offset: 0x000DDEFC
		public virtual vtkResliceCursorPolyDataAlgorithm GetCursorAlgorithm()
		{
			vtkResliceCursorPolyDataAlgorithm vtkResliceCursorPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_GetCursorAlgorithm_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorPolyDataAlgorithm = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorPolyDataAlgorithm.Register(null);
				}
			}
			return vtkResliceCursorPolyDataAlgorithm;
		}

		// Token: 0x06009DF8 RID: 40440
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkResliceCursorActor_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Get the actors mtime plus consider its algorithm.
		/// </summary>
		// Token: 0x06009DF9 RID: 40441 RVA: 0x000DFD6C File Offset: 0x000DDF6C
		public override ulong GetMTime()
		{
			return vtkResliceCursorActor.vtkResliceCursorActor_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x06009DFA RID: 40442
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorActor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009DFB RID: 40443 RVA: 0x000DFD8C File Offset: 0x000DDF8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursorActor.vtkResliceCursorActor_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06009DFC RID: 40444
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorActor_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009DFD RID: 40445 RVA: 0x000DFDAC File Offset: 0x000DDFAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursorActor.vtkResliceCursorActor_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06009DFE RID: 40446
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_GetThickSlabProperty_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get property of the internal actor.
		/// </summary>
		// Token: 0x06009DFF RID: 40447 RVA: 0x000DFDC8 File Offset: 0x000DDFC8
		public vtkProperty GetThickSlabProperty(int i)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_GetThickSlabProperty_08(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009E00 RID: 40448
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorActor_HasTranslucentPolygonalGeometry_09(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry? No.
		/// </summary>
		// Token: 0x06009E01 RID: 40449 RVA: 0x000DFE38 File Offset: 0x000DE038
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkResliceCursorActor.vtkResliceCursorActor_HasTranslucentPolygonalGeometry_09(base.GetCppThis());
		}

		// Token: 0x06009E02 RID: 40450
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorActor_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009E03 RID: 40451 RVA: 0x000DFE58 File Offset: 0x000DE058
		public override int IsA(string type)
		{
			return vtkResliceCursorActor.vtkResliceCursorActor_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06009E04 RID: 40452
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorActor_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009E05 RID: 40453 RVA: 0x000DFE78 File Offset: 0x000DE078
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursorActor.vtkResliceCursorActor_IsTypeOf_11(type);
		}

		// Token: 0x06009E06 RID: 40454
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009E07 RID: 40455 RVA: 0x000DFE94 File Offset: 0x000DE094
		public new vtkResliceCursorActor NewInstance()
		{
			vtkResliceCursorActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009E08 RID: 40456
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorActor_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06009E09 RID: 40457 RVA: 0x000DFEF0 File Offset: 0x000DE0F0
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkResliceCursorActor.vtkResliceCursorActor_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009E0A RID: 40458
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorActor_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06009E0B RID: 40459 RVA: 0x000DFF20 File Offset: 0x000DE120
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkResliceCursorActor.vtkResliceCursorActor_RenderOpaqueGeometry_15(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009E0C RID: 40460
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorActor_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods
		/// </summary>
		// Token: 0x06009E0D RID: 40461 RVA: 0x000DFF54 File Offset: 0x000DE154
		public new static vtkResliceCursorActor SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursorActor vtkResliceCursorActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorActor.vtkResliceCursorActor_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorActor = (vtkResliceCursorActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorActor.Register(null);
				}
			}
			return vtkResliceCursorActor;
		}

		// Token: 0x06009E0E RID: 40462
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorActor_SetUserMatrix_17(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set the user matrix on all the internal actors.
		/// </summary>
		// Token: 0x06009E0F RID: 40463 RVA: 0x000DFFD4 File Offset: 0x000DE1D4
		public new virtual void SetUserMatrix(vtkMatrix4x4 matrix)
		{
			vtkResliceCursorActor.vtkResliceCursorActor_SetUserMatrix_17(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CBC RID: 3260
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CBD RID: 3261
		public new static readonly string MRClassNameKey = "class vtkResliceCursorActor";
	}
}
