﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRotationalExtrusionFilter
	/// </summary>
	/// <remarks>
	///    sweep polygonal data creating "skirt" from free edges and lines, and lines from vertices
	///
	/// vtkRotationalExtrusionFilter is a modeling filter. It takes polygonal
	/// data as input and generates polygonal data on output. The input dataset
	/// is swept around an axis to create new polygonal primitives. These
	/// primitives form a "skirt" or swept surface. For example, sweeping a
	/// line results in a cylindrical shell, and sweeping a circle creates a
	/// torus.
	///
	/// There are a number of control parameters for this filter. You can
	/// control whether the sweep of a 2D object (i.e., polygon or triangle
	/// strip) is capped with the generating geometry via the "Capping" instance
	/// variable. Also, you can control the angle of rotation, whether
	/// translation along the axis is performed along with the rotation, and around
	/// which axis this is done.
	/// (Translation is useful for creating "springs".) You also can adjust
	/// the radius of the generating geometry using the "DeltaRotation" instance
	/// variable.
	///
	/// The skirt is generated by locating certain topological features. Free
	/// edges (edges of polygons or triangle strips only used by one polygon or
	/// triangle strips) generate surfaces. This is true also of lines or
	/// polylines. Vertices generate lines.
	///
	/// This filter can be used to model axisymmetric objects like cylinders,
	/// bottles, and wine glasses; or translational/rotational symmetric objects
	/// like springs or corkscrews.
	///
	/// @warning
	/// If the object sweeps 360 degrees, radius does not vary, and the object
	/// does not translate, capping is not performed. This is because the cap
	/// is unnecessary.
	///
	/// @warning
	/// Some polygonal objects have no free edges (e.g., sphere). When swept,
	/// this will result in two separate surfaces if capping is on, or no surface
	/// if capping is off.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearExtrusionFilter
	/// </seealso>
	// Token: 0x0200056B RID: 1387
	public class vtkRotationalExtrusionFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F582 RID: 62850 RVA: 0x00155855 File Offset: 0x00153A55
		static vtkRotationalExtrusionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRotationalExtrusionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRotationalExtrusionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F583 RID: 62851 RVA: 0x0015587D File Offset: 0x00153A7D
		public vtkRotationalExtrusionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F584 RID: 62852
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationalExtrusionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create object with capping on, angle of 360 degrees, resolution = 12, and
		/// no translation along z-axis.
		/// vector (0,0,1), and point (0,0,0).
		/// </summary>
		// Token: 0x0600F585 RID: 62853 RVA: 0x0015588C File Offset: 0x00153A8C
		public new static vtkRotationalExtrusionFilter New()
		{
			vtkRotationalExtrusionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationalExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create object with capping on, angle of 360 degrees, resolution = 12, and
		/// no translation along z-axis.
		/// vector (0,0,1), and point (0,0,0).
		/// </summary>
		// Token: 0x0600F586 RID: 62854 RVA: 0x001558E0 File Offset: 0x00153AE0
		public vtkRotationalExtrusionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F587 RID: 62855 RVA: 0x00155924 File Offset: 0x00153B24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F588 RID: 62856
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_CappingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the skirt.
		/// </summary>
		// Token: 0x0600F589 RID: 62857 RVA: 0x0015592F File Offset: 0x00153B2F
		public virtual void CappingOff()
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_CappingOff_01(base.GetCppThis());
		}

		// Token: 0x0600F58A RID: 62858
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_CappingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the skirt.
		/// </summary>
		// Token: 0x0600F58B RID: 62859 RVA: 0x0015593E File Offset: 0x00153B3E
		public virtual void CappingOn()
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_CappingOn_02(base.GetCppThis());
		}

		// Token: 0x0600F58C RID: 62860
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRotationalExtrusionFilter_GetAngle_03(HandleRef pThis);

		/// <summary>
		/// Set/Get angle of rotation.
		/// </summary>
		// Token: 0x0600F58D RID: 62861 RVA: 0x00155950 File Offset: 0x00153B50
		public virtual double GetAngle()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetAngle_03(base.GetCppThis());
		}

		// Token: 0x0600F58E RID: 62862
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationalExtrusionFilter_GetCapping_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the skirt.
		/// </summary>
		// Token: 0x0600F58F RID: 62863 RVA: 0x00155970 File Offset: 0x00153B70
		public virtual int GetCapping()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetCapping_04(base.GetCppThis());
		}

		// Token: 0x0600F590 RID: 62864
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRotationalExtrusionFilter_GetDeltaRadius_05(HandleRef pThis);

		/// <summary>
		/// Set/Get change in radius during sweep process.
		/// </summary>
		// Token: 0x0600F591 RID: 62865 RVA: 0x00155990 File Offset: 0x00153B90
		public virtual double GetDeltaRadius()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetDeltaRadius_05(base.GetCppThis());
		}

		// Token: 0x0600F592 RID: 62866
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRotationalExtrusionFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F593 RID: 62867 RVA: 0x001559B0 File Offset: 0x00153BB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F594 RID: 62868
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRotationalExtrusionFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F595 RID: 62869 RVA: 0x001559D0 File Offset: 0x00153BD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600F596 RID: 62870
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationalExtrusionFilter_GetResolution_08(HandleRef pThis);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F597 RID: 62871 RVA: 0x001559EC File Offset: 0x00153BEC
		public virtual int GetResolution()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetResolution_08(base.GetCppThis());
		}

		// Token: 0x0600F598 RID: 62872
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationalExtrusionFilter_GetResolutionMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F599 RID: 62873 RVA: 0x00155A0C File Offset: 0x00153C0C
		public virtual int GetResolutionMaxValue()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetResolutionMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600F59A RID: 62874
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationalExtrusionFilter_GetResolutionMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F59B RID: 62875 RVA: 0x00155A2C File Offset: 0x00153C2C
		public virtual int GetResolutionMinValue()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetResolutionMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600F59C RID: 62876
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationalExtrusionFilter_GetRotationAxis_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the axis around which the rotation is done.
		/// </summary>
		// Token: 0x0600F59D RID: 62877 RVA: 0x00155A4C File Offset: 0x00153C4C
		public virtual double[] GetRotationAxis()
		{
			IntPtr intPtr = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetRotationAxis_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F59E RID: 62878
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_GetRotationAxis_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the axis around which the rotation is done.
		/// </summary>
		// Token: 0x0600F59F RID: 62879 RVA: 0x00155A94 File Offset: 0x00153C94
		public virtual void GetRotationAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetRotationAxis_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F5A0 RID: 62880
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_GetRotationAxis_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the axis around which the rotation is done.
		/// </summary>
		// Token: 0x0600F5A1 RID: 62881 RVA: 0x00155AA6 File Offset: 0x00153CA6
		public virtual void GetRotationAxis(IntPtr _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetRotationAxis_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F5A2 RID: 62882
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRotationalExtrusionFilter_GetTranslation_14(HandleRef pThis);

		/// <summary>
		/// Set/Get total amount of translation along the rotation axis.
		/// </summary>
		// Token: 0x0600F5A3 RID: 62883 RVA: 0x00155AB8 File Offset: 0x00153CB8
		public virtual double GetTranslation()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetTranslation_14(base.GetCppThis());
		}

		// Token: 0x0600F5A4 RID: 62884
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationalExtrusionFilter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5A5 RID: 62885 RVA: 0x00155AD8 File Offset: 0x00153CD8
		public override int IsA(string type)
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600F5A6 RID: 62886
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRotationalExtrusionFilter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5A7 RID: 62887 RVA: 0x00155AF8 File Offset: 0x00153CF8
		public new static int IsTypeOf(string type)
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_IsTypeOf_16(type);
		}

		// Token: 0x0600F5A8 RID: 62888
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationalExtrusionFilter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5A9 RID: 62889 RVA: 0x00155B14 File Offset: 0x00153D14
		public new vtkRotationalExtrusionFilter NewInstance()
		{
			vtkRotationalExtrusionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationalExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F5AA RID: 62890
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRotationalExtrusionFilter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F5AB RID: 62891 RVA: 0x00155B70 File Offset: 0x00153D70
		public new static vtkRotationalExtrusionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRotationalExtrusionFilter vtkRotationalExtrusionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRotationalExtrusionFilter = (vtkRotationalExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRotationalExtrusionFilter.Register(null);
				}
			}
			return vtkRotationalExtrusionFilter;
		}

		// Token: 0x0600F5AC RID: 62892
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_SetAngle_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get angle of rotation.
		/// </summary>
		// Token: 0x0600F5AD RID: 62893 RVA: 0x00155BEF File Offset: 0x00153DEF
		public virtual void SetAngle(double _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetAngle_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F5AE RID: 62894
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_SetCapping_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the capping of the skirt.
		/// </summary>
		// Token: 0x0600F5AF RID: 62895 RVA: 0x00155BFF File Offset: 0x00153DFF
		public virtual void SetCapping(int _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetCapping_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F5B0 RID: 62896
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_SetDeltaRadius_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get change in radius during sweep process.
		/// </summary>
		// Token: 0x0600F5B1 RID: 62897 RVA: 0x00155C0F File Offset: 0x00153E0F
		public virtual void SetDeltaRadius(double _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetDeltaRadius_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F5B2 RID: 62898
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_SetResolution_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F5B3 RID: 62899 RVA: 0x00155C1F File Offset: 0x00153E1F
		public virtual void SetResolution(int _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetResolution_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F5B4 RID: 62900
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_SetRotationAxis_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the axis around which the rotation is done.
		/// </summary>
		// Token: 0x0600F5B5 RID: 62901 RVA: 0x00155C2F File Offset: 0x00153E2F
		public virtual void SetRotationAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetRotationAxis_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F5B6 RID: 62902
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_SetRotationAxis_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the axis around which the rotation is done.
		/// </summary>
		// Token: 0x0600F5B7 RID: 62903 RVA: 0x00155C41 File Offset: 0x00153E41
		public virtual void SetRotationAxis(IntPtr _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetRotationAxis_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F5B8 RID: 62904
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRotationalExtrusionFilter_SetTranslation_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get total amount of translation along the rotation axis.
		/// </summary>
		// Token: 0x0600F5B9 RID: 62905 RVA: 0x00155C51 File Offset: 0x00153E51
		public virtual void SetTranslation(double _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetTranslation_26(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011E7 RID: 4583
		public new const string MRFullTypeName = "Kitware.VTK.vtkRotationalExtrusionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011E8 RID: 4584
		public new static readonly string MRClassNameKey = "class vtkRotationalExtrusionFilter";
	}
}
