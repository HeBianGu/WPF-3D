using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearCellExtrusionFilter
	/// </summary>
	/// <remarks>
	///    extrude polygonal data to create 3D cells from 2D cells
	///
	/// vtkLinearCellExtrusionFilter is a modeling filter. It takes polygonal data as
	/// input and generates an unstructured grid data on output. The input dataset is swept
	/// according to the input cell data array value along the cell normal and creates
	/// new 3D primitives.
	/// Triangles will become Wedges, Quads will become Hexahedrons,
	/// and Polygons will become Polyhedrons.
	/// This filter currently takes into account only polys and discard vertices, lines and strips.
	/// Unlike the vtkLinearExtrusionFilter, this filter is designed to extrude each cell independently
	/// using its normal and its scalar value.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearExtrusionFilter
	/// </seealso>
	// Token: 0x0200055F RID: 1375
	public class vtkLinearCellExtrusionFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F3B1 RID: 62385 RVA: 0x001535F1 File Offset: 0x001517F1
		static vtkLinearCellExtrusionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearCellExtrusionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearCellExtrusionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F3B2 RID: 62386 RVA: 0x00153619 File Offset: 0x00151819
		public vtkLinearCellExtrusionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F3B3 RID: 62387
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearCellExtrusionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3B4 RID: 62388 RVA: 0x00153628 File Offset: 0x00151828
		public new static vtkLinearCellExtrusionFilter New()
		{
			vtkLinearCellExtrusionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearCellExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3B5 RID: 62389 RVA: 0x0015367C File Offset: 0x0015187C
		public vtkLinearCellExtrusionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F3B6 RID: 62390 RVA: 0x001536C0 File Offset: 0x001518C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F3B7 RID: 62391
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0600F3B8 RID: 62392 RVA: 0x001536CB File Offset: 0x001518CB
		public void CreateDefaultLocator()
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x0600F3B9 RID: 62393
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearCellExtrusionFilter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points.
		/// By default, an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600F3BA RID: 62394 RVA: 0x001536DC File Offset: 0x001518DC
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetLocator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0600F3BB RID: 62395
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLinearCellExtrusionFilter_GetMergeDuplicatePoints_03(HandleRef pThis);

		/// <summary>
		/// Specify if the algorithm should merge duplicate points.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3BC RID: 62396 RVA: 0x0015374C File Offset: 0x0015194C
		public virtual bool GetMergeDuplicatePoints()
		{
			return vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetMergeDuplicatePoints_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F3BD RID: 62397
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3BE RID: 62398 RVA: 0x00153774 File Offset: 0x00151974
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F3BF RID: 62399
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3C0 RID: 62400 RVA: 0x00153794 File Offset: 0x00151994
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600F3C1 RID: 62401
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLinearCellExtrusionFilter_GetScaleFactor_06(HandleRef pThis);

		/// <summary>
		/// Specify the scale factor applied on the cell value during extrusion.
		/// Default is 1.0
		/// </summary>
		// Token: 0x0600F3C2 RID: 62402 RVA: 0x001537B0 File Offset: 0x001519B0
		public virtual double GetScaleFactor()
		{
			return vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetScaleFactor_06(base.GetCppThis());
		}

		// Token: 0x0600F3C3 RID: 62403
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLinearCellExtrusionFilter_GetUseUserVector_07(HandleRef pThis);

		/// <summary>
		/// Specify if the algorithm should use the specified vector instead of cell normals.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3C4 RID: 62404 RVA: 0x001537D0 File Offset: 0x001519D0
		public virtual bool GetUseUserVector()
		{
			return vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetUseUserVector_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F3C5 RID: 62405
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearCellExtrusionFilter_GetUserVector_08(HandleRef pThis);

		/// <summary>
		/// Specify the scale factor applied on the cell value during extrusion.
		/// </summary>
		// Token: 0x0600F3C6 RID: 62406 RVA: 0x001537F8 File Offset: 0x001519F8
		public virtual double[] GetUserVector()
		{
			IntPtr intPtr = vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetUserVector_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F3C7 RID: 62407
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_GetUserVector_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify the scale factor applied on the cell value during extrusion.
		/// </summary>
		// Token: 0x0600F3C8 RID: 62408 RVA: 0x00153840 File Offset: 0x00151A40
		public virtual void GetUserVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetUserVector_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F3C9 RID: 62409
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_GetUserVector_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the scale factor applied on the cell value during extrusion.
		/// </summary>
		// Token: 0x0600F3CA RID: 62410 RVA: 0x00153852 File Offset: 0x00151A52
		public virtual void GetUserVector(IntPtr _arg)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_GetUserVector_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F3CB RID: 62411
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearCellExtrusionFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3CC RID: 62412 RVA: 0x00153864 File Offset: 0x00151A64
		public override int IsA(string type)
		{
			return vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600F3CD RID: 62413
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearCellExtrusionFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3CE RID: 62414 RVA: 0x00153884 File Offset: 0x00151A84
		public new static int IsTypeOf(string type)
		{
			return vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_IsTypeOf_12(type);
		}

		// Token: 0x0600F3CF RID: 62415
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_MergeDuplicatePointsOff_13(HandleRef pThis);

		/// <summary>
		/// Specify if the algorithm should merge duplicate points.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3D0 RID: 62416 RVA: 0x0015389E File Offset: 0x00151A9E
		public virtual void MergeDuplicatePointsOff()
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_MergeDuplicatePointsOff_13(base.GetCppThis());
		}

		// Token: 0x0600F3D1 RID: 62417
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_MergeDuplicatePointsOn_14(HandleRef pThis);

		/// <summary>
		/// Specify if the algorithm should merge duplicate points.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3D2 RID: 62418 RVA: 0x001538AD File Offset: 0x00151AAD
		public virtual void MergeDuplicatePointsOn()
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_MergeDuplicatePointsOn_14(base.GetCppThis());
		}

		// Token: 0x0600F3D3 RID: 62419
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearCellExtrusionFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3D4 RID: 62420 RVA: 0x001538BC File Offset: 0x00151ABC
		public new vtkLinearCellExtrusionFilter NewInstance()
		{
			vtkLinearCellExtrusionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearCellExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F3D5 RID: 62421
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearCellExtrusionFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3D6 RID: 62422 RVA: 0x00153918 File Offset: 0x00151B18
		public new static vtkLinearCellExtrusionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLinearCellExtrusionFilter vtkLinearCellExtrusionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearCellExtrusionFilter = (vtkLinearCellExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearCellExtrusionFilter.Register(null);
				}
			}
			return vtkLinearCellExtrusionFilter;
		}

		// Token: 0x0600F3D7 RID: 62423
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_SetLocator_18(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Specify a spatial locator for merging points.
		/// By default, an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600F3D8 RID: 62424 RVA: 0x00153998 File Offset: 0x00151B98
		public virtual void SetLocator(vtkIncrementalPointLocator _arg)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_SetLocator_18(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0600F3D9 RID: 62425
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_SetMergeDuplicatePoints_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if the algorithm should merge duplicate points.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3DA RID: 62426 RVA: 0x001539C7 File Offset: 0x00151BC7
		public virtual void SetMergeDuplicatePoints(bool _arg)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_SetMergeDuplicatePoints_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F3DB RID: 62427
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_SetScaleFactor_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the scale factor applied on the cell value during extrusion.
		/// Default is 1.0
		/// </summary>
		// Token: 0x0600F3DC RID: 62428 RVA: 0x001539DF File Offset: 0x00151BDF
		public virtual void SetScaleFactor(double _arg)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_SetScaleFactor_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F3DD RID: 62429
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_SetUseUserVector_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if the algorithm should use the specified vector instead of cell normals.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3DE RID: 62430 RVA: 0x001539EF File Offset: 0x00151BEF
		public virtual void SetUseUserVector(bool _arg)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_SetUseUserVector_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F3DF RID: 62431
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_SetUserVector_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the scale factor applied on the cell value during extrusion.
		/// </summary>
		// Token: 0x0600F3E0 RID: 62432 RVA: 0x00153A07 File Offset: 0x00151C07
		public virtual void SetUserVector(double _arg1, double _arg2, double _arg3)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_SetUserVector_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F3E1 RID: 62433
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_SetUserVector_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the scale factor applied on the cell value during extrusion.
		/// </summary>
		// Token: 0x0600F3E2 RID: 62434 RVA: 0x00153A19 File Offset: 0x00151C19
		public virtual void SetUserVector(IntPtr _arg)
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_SetUserVector_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F3E3 RID: 62435
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_UseUserVectorOff_24(HandleRef pThis);

		/// <summary>
		/// Specify if the algorithm should use the specified vector instead of cell normals.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3E4 RID: 62436 RVA: 0x00153A29 File Offset: 0x00151C29
		public virtual void UseUserVectorOff()
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_UseUserVectorOff_24(base.GetCppThis());
		}

		// Token: 0x0600F3E5 RID: 62437
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearCellExtrusionFilter_UseUserVectorOn_25(HandleRef pThis);

		/// <summary>
		/// Specify if the algorithm should use the specified vector instead of cell normals.
		/// Default is false
		/// </summary>
		// Token: 0x0600F3E6 RID: 62438 RVA: 0x00153A38 File Offset: 0x00151C38
		public virtual void UseUserVectorOn()
		{
			vtkLinearCellExtrusionFilter.vtkLinearCellExtrusionFilter_UseUserVectorOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011C9 RID: 4553
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearCellExtrusionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011CA RID: 4554
		public new static readonly string MRClassNameKey = "class vtkLinearCellExtrusionFilter";
	}
}
