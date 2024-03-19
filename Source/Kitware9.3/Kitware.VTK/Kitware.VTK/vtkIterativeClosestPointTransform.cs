using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIterativeClosestPointTransform
	/// </summary>
	/// <remarks>
	///    Implementation of the ICP algorithm.
	///
	/// Match two surfaces using the iterative closest point (ICP) algorithm.
	/// The core of the algorithm is to match each vertex in one surface with
	/// the closest surface point on the other, then apply the transformation
	/// that modify one surface to best match the other (in a least square sense).
	/// This has to be iterated to get proper convergence of the surfaces.
	/// @attention
	/// Use vtkTransformPolyDataFilter to apply the resulting ICP transform to
	/// your data. You might also set it to your actor's user transform.
	/// @attention
	/// This class makes use of vtkLandmarkTransform internally to compute the
	/// best fit. Use the GetLandmarkTransform member to get a pointer to that
	/// transform and set its parameters. You might, for example, constrain the
	/// number of degrees of freedom of the solution (i.e. rigid body, similarity,
	/// etc.) by checking the vtkLandmarkTransform documentation for its SetMode
	/// member.
	/// </remarks>
	/// <seealso>
	///
	/// vtkLandmarkTransform
	/// </seealso>
	// Token: 0x02000A74 RID: 2676
	public class vtkIterativeClosestPointTransform : vtkLinearTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C06A RID: 114794 RVA: 0x002747F0 File Offset: 0x002729F0
		static vtkIterativeClosestPointTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIterativeClosestPointTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIterativeClosestPointTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C06B RID: 114795 RVA: 0x00274818 File Offset: 0x00272A18
		public vtkIterativeClosestPointTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C06C RID: 114796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C06D RID: 114797 RVA: 0x00274828 File Offset: 0x00272A28
		public new static vtkIterativeClosestPointTransform New()
		{
			vtkIterativeClosestPointTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C06E RID: 114798 RVA: 0x0027487C File Offset: 0x00272A7C
		public vtkIterativeClosestPointTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C06F RID: 114799 RVA: 0x002748C0 File Offset: 0x00272AC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C070 RID: 114800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_CheckMeanDistanceOff_01(HandleRef pThis);

		/// <summary>
		/// Force the algorithm to check the mean distance between two iterations.
		/// Default is Off.
		/// </summary>
		// Token: 0x0601C071 RID: 114801 RVA: 0x002748CB File Offset: 0x00272ACB
		public virtual void CheckMeanDistanceOff()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_CheckMeanDistanceOff_01(base.GetCppThis());
		}

		// Token: 0x0601C072 RID: 114802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_CheckMeanDistanceOn_02(HandleRef pThis);

		/// <summary>
		/// Force the algorithm to check the mean distance between two iterations.
		/// Default is Off.
		/// </summary>
		// Token: 0x0601C073 RID: 114803 RVA: 0x002748DA File Offset: 0x00272ADA
		public virtual void CheckMeanDistanceOn()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_CheckMeanDistanceOn_02(base.GetCppThis());
		}

		// Token: 0x0601C074 RID: 114804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetCheckMeanDistance_03(HandleRef pThis);

		/// <summary>
		/// Force the algorithm to check the mean distance between two iterations.
		/// Default is Off.
		/// </summary>
		// Token: 0x0601C075 RID: 114805 RVA: 0x002748EC File Offset: 0x00272AEC
		public virtual int GetCheckMeanDistance()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetCheckMeanDistance_03(base.GetCppThis());
		}

		// Token: 0x0601C076 RID: 114806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetLandmarkTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal landmark transform. Use it to constrain the number of
		/// degrees of freedom of the solution (i.e. rigid body, similarity, etc.).
		/// </summary>
		// Token: 0x0601C077 RID: 114807 RVA: 0x0027490C File Offset: 0x00272B0C
		public virtual vtkLandmarkTransform GetLandmarkTransform()
		{
			vtkLandmarkTransform vtkLandmarkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetLandmarkTransform_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C078 RID: 114808
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a spatial locator for speeding up the search process.
		/// An instance of vtkCellLocator is used by default.
		/// </summary>
		// Token: 0x0601C079 RID: 114809 RVA: 0x0027497C File Offset: 0x00272B7C
		public virtual vtkCellLocator GetLocator()
		{
			vtkCellLocator vtkCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetLocator_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLocator = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLocator.Register(null);
				}
			}
			return vtkCellLocator;
		}

		// Token: 0x0601C07A RID: 114810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIterativeClosestPointTransform_GetMaximumMeanDistance_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum mean distance between two iteration. If the mean
		/// distance is lower than this, the convergence stops. The default
		/// is 0.01.
		/// </summary>
		// Token: 0x0601C07B RID: 114811 RVA: 0x002749EC File Offset: 0x00272BEC
		public virtual double GetMaximumMeanDistance()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMaximumMeanDistance_06(base.GetCppThis());
		}

		// Token: 0x0601C07C RID: 114812
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetMaximumNumberOfIterations_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations. Default is 50.
		/// </summary>
		// Token: 0x0601C07D RID: 114813 RVA: 0x00274A0C File Offset: 0x00272C0C
		public virtual int GetMaximumNumberOfIterations()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMaximumNumberOfIterations_07(base.GetCppThis());
		}

		// Token: 0x0601C07E RID: 114814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetMaximumNumberOfLandmarks_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of landmarks sampled in your dataset.
		/// If your dataset is dense, then you will typically not need all the
		/// points to compute the ICP transform. The default is 200.
		/// </summary>
		// Token: 0x0601C07F RID: 114815 RVA: 0x00274A2C File Offset: 0x00272C2C
		public virtual int GetMaximumNumberOfLandmarks()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMaximumNumberOfLandmarks_08(base.GetCppThis());
		}

		// Token: 0x0601C080 RID: 114816
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIterativeClosestPointTransform_GetMeanDistance_09(HandleRef pThis);

		/// <summary>
		/// Get the mean distance between the last two iterations.
		/// </summary>
		// Token: 0x0601C081 RID: 114817 RVA: 0x00274A4C File Offset: 0x00272C4C
		public virtual double GetMeanDistance()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistance_09(base.GetCppThis());
		}

		// Token: 0x0601C082 RID: 114818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceMode_10(HandleRef pThis);

		/// <summary>
		/// Specify the mean distance mode. This mode expresses how the mean
		/// distance is computed. The RMS mode is the square root of the average
		/// of the sum of squares of the closest point distances. The Absolute
		/// Value mode is the mean of the sum of absolute values of the closest
		/// point distances. The default is VTK_ICP_MODE_RMS
		/// </summary>
		// Token: 0x0601C083 RID: 114819 RVA: 0x00274A6C File Offset: 0x00272C6C
		public virtual int GetMeanDistanceMode()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceMode_10(base.GetCppThis());
		}

		// Token: 0x0601C084 RID: 114820
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetMeanDistanceModeAsString_11(HandleRef pThis);

		/// <summary>
		/// Specify the mean distance mode. This mode expresses how the mean
		/// distance is computed. The RMS mode is the square root of the average
		/// of the sum of squares of the closest point distances. The Absolute
		/// Value mode is the mean of the sum of absolute values of the closest
		/// point distances. The default is VTK_ICP_MODE_RMS
		/// </summary>
		// Token: 0x0601C085 RID: 114821 RVA: 0x00274A8C File Offset: 0x00272C8C
		public string GetMeanDistanceModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceModeAsString_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601C086 RID: 114822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceModeMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the mean distance mode. This mode expresses how the mean
		/// distance is computed. The RMS mode is the square root of the average
		/// of the sum of squares of the closest point distances. The Absolute
		/// Value mode is the mean of the sum of absolute values of the closest
		/// point distances. The default is VTK_ICP_MODE_RMS
		/// </summary>
		// Token: 0x0601C087 RID: 114823 RVA: 0x00274AC8 File Offset: 0x00272CC8
		public virtual int GetMeanDistanceModeMaxValue()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceModeMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0601C088 RID: 114824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceModeMinValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the mean distance mode. This mode expresses how the mean
		/// distance is computed. The RMS mode is the square root of the average
		/// of the sum of squares of the closest point distances. The Absolute
		/// Value mode is the mean of the sum of absolute values of the closest
		/// point distances. The default is VTK_ICP_MODE_RMS
		/// </summary>
		// Token: 0x0601C089 RID: 114825 RVA: 0x00274AE8 File Offset: 0x00272CE8
		public virtual int GetMeanDistanceModeMinValue()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceModeMinValue_13(base.GetCppThis());
		}

		// Token: 0x0601C08A RID: 114826
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C08B RID: 114827 RVA: 0x00274B08 File Offset: 0x00272D08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601C08C RID: 114828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C08D RID: 114829 RVA: 0x00274B28 File Offset: 0x00272D28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601C08E RID: 114830
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetNumberOfIterations_16(HandleRef pThis);

		/// <summary>
		/// Get the number of iterations since the last update
		/// </summary>
		// Token: 0x0601C08F RID: 114831 RVA: 0x00274B44 File Offset: 0x00272D44
		public virtual int GetNumberOfIterations()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetNumberOfIterations_16(base.GetCppThis());
		}

		// Token: 0x0601C090 RID: 114832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetSource_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source and target data sets.
		/// </summary>
		// Token: 0x0601C091 RID: 114833 RVA: 0x00274B64 File Offset: 0x00272D64
		public virtual vtkDataSet GetSource()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetSource_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601C092 RID: 114834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_GetStartByMatchingCentroids_18(HandleRef pThis);

		/// <summary>
		/// Starts the process by translating source centroid to target centroid.
		/// The default is Off.
		/// </summary>
		// Token: 0x0601C093 RID: 114835 RVA: 0x00274BD4 File Offset: 0x00272DD4
		public virtual int GetStartByMatchingCentroids()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetStartByMatchingCentroids_18(base.GetCppThis());
		}

		// Token: 0x0601C094 RID: 114836
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetTarget_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source and target data sets.
		/// </summary>
		// Token: 0x0601C095 RID: 114837 RVA: 0x00274BF4 File Offset: 0x00272DF4
		public virtual vtkDataSet GetTarget()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetTarget_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601C096 RID: 114838
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_Inverse_20(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.  This is done by switching the
		/// source and target.
		/// </summary>
		// Token: 0x0601C097 RID: 114839 RVA: 0x00274C63 File Offset: 0x00272E63
		public override void Inverse()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_Inverse_20(base.GetCppThis());
		}

		// Token: 0x0601C098 RID: 114840
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C099 RID: 114841 RVA: 0x00274C74 File Offset: 0x00272E74
		public override int IsA(string type)
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0601C09A RID: 114842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIterativeClosestPointTransform_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C09B RID: 114843 RVA: 0x00274C94 File Offset: 0x00272E94
		public new static int IsTypeOf(string type)
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_IsTypeOf_22(type);
		}

		// Token: 0x0601C09C RID: 114844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_MakeTransform_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x0601C09D RID: 114845 RVA: 0x00274CB0 File Offset: 0x00272EB0
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_MakeTransform_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C09E RID: 114846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C09F RID: 114847 RVA: 0x00274D0C File Offset: 0x00272F0C
		public new vtkIterativeClosestPointTransform NewInstance()
		{
			vtkIterativeClosestPointTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C0A0 RID: 114848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIterativeClosestPointTransform_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C0A1 RID: 114849 RVA: 0x00274D68 File Offset: 0x00272F68
		public new static vtkIterativeClosestPointTransform SafeDownCast(vtkObjectBase o)
		{
			vtkIterativeClosestPointTransform vtkIterativeClosestPointTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIterativeClosestPointTransform = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIterativeClosestPointTransform.Register(null);
				}
			}
			return vtkIterativeClosestPointTransform;
		}

		// Token: 0x0601C0A2 RID: 114850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetCheckMeanDistance_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the algorithm to check the mean distance between two iterations.
		/// Default is Off.
		/// </summary>
		// Token: 0x0601C0A3 RID: 114851 RVA: 0x00274DE7 File Offset: 0x00272FE7
		public virtual void SetCheckMeanDistance(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetCheckMeanDistance_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C0A4 RID: 114852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetLocator_28(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set/Get a spatial locator for speeding up the search process.
		/// An instance of vtkCellLocator is used by default.
		/// </summary>
		// Token: 0x0601C0A5 RID: 114853 RVA: 0x00274DF8 File Offset: 0x00272FF8
		public void SetLocator(vtkCellLocator locator)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetLocator_28(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0601C0A6 RID: 114854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetMaximumMeanDistance_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum mean distance between two iteration. If the mean
		/// distance is lower than this, the convergence stops. The default
		/// is 0.01.
		/// </summary>
		// Token: 0x0601C0A7 RID: 114855 RVA: 0x00274E27 File Offset: 0x00273027
		public virtual void SetMaximumMeanDistance(double _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMaximumMeanDistance_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C0A8 RID: 114856
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetMaximumNumberOfIterations_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations. Default is 50.
		/// </summary>
		// Token: 0x0601C0A9 RID: 114857 RVA: 0x00274E37 File Offset: 0x00273037
		public virtual void SetMaximumNumberOfIterations(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMaximumNumberOfIterations_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C0AA RID: 114858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetMaximumNumberOfLandmarks_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of landmarks sampled in your dataset.
		/// If your dataset is dense, then you will typically not need all the
		/// points to compute the ICP transform. The default is 200.
		/// </summary>
		// Token: 0x0601C0AB RID: 114859 RVA: 0x00274E47 File Offset: 0x00273047
		public virtual void SetMaximumNumberOfLandmarks(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMaximumNumberOfLandmarks_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C0AC RID: 114860
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceMode_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the mean distance mode. This mode expresses how the mean
		/// distance is computed. The RMS mode is the square root of the average
		/// of the sum of squares of the closest point distances. The Absolute
		/// Value mode is the mean of the sum of absolute values of the closest
		/// point distances. The default is VTK_ICP_MODE_RMS
		/// </summary>
		// Token: 0x0601C0AD RID: 114861 RVA: 0x00274E57 File Offset: 0x00273057
		public virtual void SetMeanDistanceMode(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMeanDistanceMode_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C0AE RID: 114862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceModeToAbsoluteValue_33(HandleRef pThis);

		/// <summary>
		/// Specify the mean distance mode. This mode expresses how the mean
		/// distance is computed. The RMS mode is the square root of the average
		/// of the sum of squares of the closest point distances. The Absolute
		/// Value mode is the mean of the sum of absolute values of the closest
		/// point distances. The default is VTK_ICP_MODE_RMS
		/// </summary>
		// Token: 0x0601C0AF RID: 114863 RVA: 0x00274E67 File Offset: 0x00273067
		public void SetMeanDistanceModeToAbsoluteValue()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMeanDistanceModeToAbsoluteValue_33(base.GetCppThis());
		}

		// Token: 0x0601C0B0 RID: 114864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceModeToRMS_34(HandleRef pThis);

		/// <summary>
		/// Specify the mean distance mode. This mode expresses how the mean
		/// distance is computed. The RMS mode is the square root of the average
		/// of the sum of squares of the closest point distances. The Absolute
		/// Value mode is the mean of the sum of absolute values of the closest
		/// point distances. The default is VTK_ICP_MODE_RMS
		/// </summary>
		// Token: 0x0601C0B1 RID: 114865 RVA: 0x00274E76 File Offset: 0x00273076
		public void SetMeanDistanceModeToRMS()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMeanDistanceModeToRMS_34(base.GetCppThis());
		}

		// Token: 0x0601C0B2 RID: 114866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetSource_35(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the source and target data sets.
		/// </summary>
		// Token: 0x0601C0B3 RID: 114867 RVA: 0x00274E88 File Offset: 0x00273088
		public void SetSource(vtkDataSet source)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetSource_35(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601C0B4 RID: 114868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetStartByMatchingCentroids_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Starts the process by translating source centroid to target centroid.
		/// The default is Off.
		/// </summary>
		// Token: 0x0601C0B5 RID: 114869 RVA: 0x00274EB7 File Offset: 0x002730B7
		public virtual void SetStartByMatchingCentroids(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetStartByMatchingCentroids_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C0B6 RID: 114870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_SetTarget_37(HandleRef pThis, HandleRef target);

		/// <summary>
		/// Specify the source and target data sets.
		/// </summary>
		// Token: 0x0601C0B7 RID: 114871 RVA: 0x00274EC8 File Offset: 0x002730C8
		public void SetTarget(vtkDataSet target)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetTarget_37(base.GetCppThis(), (target == null) ? default(HandleRef) : target.GetCppThis());
		}

		// Token: 0x0601C0B8 RID: 114872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_StartByMatchingCentroidsOff_38(HandleRef pThis);

		/// <summary>
		/// Starts the process by translating source centroid to target centroid.
		/// The default is Off.
		/// </summary>
		// Token: 0x0601C0B9 RID: 114873 RVA: 0x00274EF7 File Offset: 0x002730F7
		public virtual void StartByMatchingCentroidsOff()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_StartByMatchingCentroidsOff_38(base.GetCppThis());
		}

		// Token: 0x0601C0BA RID: 114874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIterativeClosestPointTransform_StartByMatchingCentroidsOn_39(HandleRef pThis);

		/// <summary>
		/// Starts the process by translating source centroid to target centroid.
		/// The default is Off.
		/// </summary>
		// Token: 0x0601C0BB RID: 114875 RVA: 0x00274F06 File Offset: 0x00273106
		public virtual void StartByMatchingCentroidsOn()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_StartByMatchingCentroidsOn_39(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DDF RID: 7647
		public new const string MRFullTypeName = "Kitware.VTK.vtkIterativeClosestPointTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE0 RID: 7648
		public new static readonly string MRClassNameKey = "class vtkIterativeClosestPointTransform";
	}
}
