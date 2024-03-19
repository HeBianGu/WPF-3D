using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProcrustesAlignmentFilter
	/// </summary>
	/// <remarks>
	///    aligns a set of pointsets together
	///
	///
	/// vtkProcrustesAlignmentFilter is a filter that takes a set of pointsets
	/// (any object derived from vtkPointSet) and aligns them in a least-squares
	/// sense to their mutual mean. The algorithm is iterated until convergence,
	/// as the mean must be recomputed after each alignment.
	///
	/// vtkProcrustesAlignmentFilter requires a vtkMultiBlock input consisting
	/// of vtkPointSets as first level children.
	///
	/// The default (in vtkLandmarkTransform) is for a similarity alignment.
	/// For a rigid-body alignment (to build a 'size-and-shape' model) use:
	///
	///    GetLandmarkTransform()-&gt;SetModeToRigidBody().
	///
	/// Affine alignments are not normally used but are left in for completeness:
	///
	///    GetLandmarkTransform()-&gt;SetModeToAffine().
	///
	/// vtkProcrustesAlignmentFilter is an implementation of:
	///
	///    J.C. Gower (1975)
	///    Generalized Procrustes Analysis. Psychometrika, 40:33-51.
	///
	/// @warning
	/// All of the input pointsets must have the same number of points.
	///
	/// @par Thanks:
	/// Tim Hutton and Rasmus Paulsen who developed and contributed this class
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLandmarkTransform
	/// </seealso>
	// Token: 0x02000613 RID: 1555
	public class vtkProcrustesAlignmentFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010E7C RID: 69244 RVA: 0x00178D91 File Offset: 0x00176F91
		static vtkProcrustesAlignmentFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcrustesAlignmentFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcrustesAlignmentFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010E7D RID: 69245 RVA: 0x00178DB9 File Offset: 0x00176FB9
		public vtkProcrustesAlignmentFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010E7E RID: 69246
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates with similarity transform.
		/// </summary>
		// Token: 0x06010E7F RID: 69247 RVA: 0x00178DC8 File Offset: 0x00176FC8
		public new static vtkProcrustesAlignmentFilter New()
		{
			vtkProcrustesAlignmentFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates with similarity transform.
		/// </summary>
		// Token: 0x06010E80 RID: 69248 RVA: 0x00178E1C File Offset: 0x0017701C
		public vtkProcrustesAlignmentFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010E81 RID: 69249 RVA: 0x00178E60 File Offset: 0x00177060
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010E82 RID: 69250
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_GetLandmarkTransform_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal landmark transform. Use it to constrain the number of
		/// degrees of freedom of the alignment (i.e. rigid body, similarity, etc.).
		/// The default is a similarity alignment.
		/// </summary>
		// Token: 0x06010E83 RID: 69251 RVA: 0x00178E6C File Offset: 0x0017706C
		public virtual vtkLandmarkTransform GetLandmarkTransform()
		{
			vtkLandmarkTransform vtkLandmarkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetLandmarkTransform_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLandmarkTransform = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLandmarkTransform.Register(null);
				}
			}
			return vtkLandmarkTransform;
		}

		// Token: 0x06010E84 RID: 69252
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_GetMeanPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the estimated mean point cloud
		/// </summary>
		// Token: 0x06010E85 RID: 69253 RVA: 0x00178EDC File Offset: 0x001770DC
		public virtual vtkPoints GetMeanPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetMeanPoints_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x06010E86 RID: 69254
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E87 RID: 69255 RVA: 0x00178F4C File Offset: 0x0017714C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010E88 RID: 69256
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E89 RID: 69257 RVA: 0x00178F6C File Offset: 0x0017716C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010E8A RID: 69258
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcrustesAlignmentFilter_GetOutputPointsPrecision_05(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. If the desired precision is
		/// DEFAULT_PRECISION and any of the inputs are double precision, then the
		/// mean points will be double precision. Otherwise, if the desired
		/// precision is DEFAULT_PRECISION and all the inputs are single precision,
		/// then the mean points will be single precision.
		/// </summary>
		// Token: 0x06010E8B RID: 69259 RVA: 0x00178F88 File Offset: 0x00177188
		public virtual int GetOutputPointsPrecision()
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetOutputPointsPrecision_05(base.GetCppThis());
		}

		// Token: 0x06010E8C RID: 69260
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProcrustesAlignmentFilter_GetStartFromCentroid_06(HandleRef pThis);

		/// <summary>
		/// When on, the initial alignment is to the centroid
		/// of the cohort curves.  When off, the alignment is to the
		/// centroid of the first input.  Default is off for
		/// backward compatibility.
		/// </summary>
		// Token: 0x06010E8D RID: 69261 RVA: 0x00178FA8 File Offset: 0x001771A8
		public virtual bool GetStartFromCentroid()
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetStartFromCentroid_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06010E8E RID: 69262
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcrustesAlignmentFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E8F RID: 69263 RVA: 0x00178FD0 File Offset: 0x001771D0
		public override int IsA(string type)
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06010E90 RID: 69264
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcrustesAlignmentFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E91 RID: 69265 RVA: 0x00178FF0 File Offset: 0x001771F0
		public new static int IsTypeOf(string type)
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_IsTypeOf_08(type);
		}

		// Token: 0x06010E92 RID: 69266
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E93 RID: 69267 RVA: 0x0017900C File Offset: 0x0017720C
		public new vtkProcrustesAlignmentFilter NewInstance()
		{
			vtkProcrustesAlignmentFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010E94 RID: 69268
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E95 RID: 69269 RVA: 0x00179068 File Offset: 0x00177268
		public new static vtkProcrustesAlignmentFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProcrustesAlignmentFilter vtkProcrustesAlignmentFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcrustesAlignmentFilter = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcrustesAlignmentFilter.Register(null);
				}
			}
			return vtkProcrustesAlignmentFilter;
		}

		// Token: 0x06010E96 RID: 69270
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcrustesAlignmentFilter_SetOutputPointsPrecision_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. If the desired precision is
		/// DEFAULT_PRECISION and any of the inputs are double precision, then the
		/// mean points will be double precision. Otherwise, if the desired
		/// precision is DEFAULT_PRECISION and all the inputs are single precision,
		/// then the mean points will be single precision.
		/// </summary>
		// Token: 0x06010E97 RID: 69271 RVA: 0x001790E7 File Offset: 0x001772E7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SetOutputPointsPrecision_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E98 RID: 69272
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcrustesAlignmentFilter_SetStartFromCentroid_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// When on, the initial alignment is to the centroid
		/// of the cohort curves.  When off, the alignment is to the
		/// centroid of the first input.  Default is off for
		/// backward compatibility.
		/// </summary>
		// Token: 0x06010E99 RID: 69273 RVA: 0x001790F7 File Offset: 0x001772F7
		public virtual void SetStartFromCentroid(bool _arg)
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SetStartFromCentroid_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010E9A RID: 69274
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcrustesAlignmentFilter_StartFromCentroidOff_14(HandleRef pThis);

		/// <summary>
		/// When on, the initial alignment is to the centroid
		/// of the cohort curves.  When off, the alignment is to the
		/// centroid of the first input.  Default is off for
		/// backward compatibility.
		/// </summary>
		// Token: 0x06010E9B RID: 69275 RVA: 0x0017910F File Offset: 0x0017730F
		public virtual void StartFromCentroidOff()
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_StartFromCentroidOff_14(base.GetCppThis());
		}

		// Token: 0x06010E9C RID: 69276
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcrustesAlignmentFilter_StartFromCentroidOn_15(HandleRef pThis);

		/// <summary>
		/// When on, the initial alignment is to the centroid
		/// of the cohort curves.  When off, the alignment is to the
		/// centroid of the first input.  Default is off for
		/// backward compatibility.
		/// </summary>
		// Token: 0x06010E9D RID: 69277 RVA: 0x0017911E File Offset: 0x0017731E
		public virtual void StartFromCentroidOn()
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_StartFromCentroidOn_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001383 RID: 4995
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcrustesAlignmentFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001384 RID: 4996
		public new static readonly string MRClassNameKey = "class vtkProcrustesAlignmentFilter";
	}
}
