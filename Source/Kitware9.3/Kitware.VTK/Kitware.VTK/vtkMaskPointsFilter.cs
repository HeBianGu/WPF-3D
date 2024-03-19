using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMaskPointsFilter
	/// </summary>
	/// <remarks>
	///    extract points within an image/volume mask
	///
	/// vtkMaskPointsFilter extracts points that are inside an image mask. The
	/// image mask is a second input to the filter. Points that are inside a voxel
	/// marked "inside" are copied to the output. The image mask can be generated
	/// by vtkPointOccupancyFilter, with optional image processing steps performed
	/// on the mask. Thus vtkPointOccupancyFilter and vtkMaskPointsFilter are
	/// generally used together, with a pipeline of image processing algorithms
	/// in between the two filters.
	///
	/// Note also that this filter is a subclass of vtkPointCloudFilter which has
	/// the ability to produce an output mask indicating which points were
	/// selected for output. It also has an optional second output containing the
	/// points that were masked out (i.e., outliers) during processing.
	///
	/// Finally, the mask value indicating non-selection of points (i.e., the
	/// empty value) may be specified. The second input, masking image, is
	/// typically of type unsigned char so the empty value is of this type as
	/// well.
	///
	/// @warning
	/// During processing, points not within the masking image/volume are
	/// considered outside and never extracted.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointOccupancyFilter vtkPointCloudFilter
	/// </seealso>
	// Token: 0x02000448 RID: 1096
	public class vtkMaskPointsFilter : vtkPointCloudFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CC71 RID: 52337 RVA: 0x0011C783 File Offset: 0x0011A983
		static vtkMaskPointsFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaskPointsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskPointsFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC72 RID: 52338 RVA: 0x0011C7AB File Offset: 0x0011A9AB
		public vtkMaskPointsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CC73 RID: 52339
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPointsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC74 RID: 52340 RVA: 0x0011C7BC File Offset: 0x0011A9BC
		public new static vtkMaskPointsFilter New()
		{
			vtkMaskPointsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPointsFilter.vtkMaskPointsFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPointsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC75 RID: 52341 RVA: 0x0011C810 File Offset: 0x0011AA10
		public vtkMaskPointsFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMaskPointsFilter.vtkMaskPointsFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC76 RID: 52342 RVA: 0x0011C854 File Offset: 0x0011AA54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CC77 RID: 52343
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMaskPointsFilter_GetEmptyValue_01(HandleRef pThis);

		/// <summary>
		/// Set / get the values indicating whether a voxel is empty. By default, an
		/// empty voxel is marked with a zero value. Any point inside a voxel marked
		/// empty is not selected for output. All other voxels with a value that is
		/// not equal to the empty value are selected for output.
		/// </summary>
		// Token: 0x0600CC78 RID: 52344 RVA: 0x0011C860 File Offset: 0x0011AA60
		public virtual byte GetEmptyValue()
		{
			return vtkMaskPointsFilter.vtkMaskPointsFilter_GetEmptyValue_01(base.GetCppThis());
		}

		// Token: 0x0600CC79 RID: 52345
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPointsFilter_GetMask_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the masking image. It must be of type vtkImageData.
		/// </summary>
		// Token: 0x0600CC7A RID: 52346 RVA: 0x0011C880 File Offset: 0x0011AA80
		public vtkDataObject GetMask()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPointsFilter.vtkMaskPointsFilter_GetMask_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600CC7B RID: 52347
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPointsFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC7C RID: 52348 RVA: 0x0011C8F0 File Offset: 0x0011AAF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMaskPointsFilter.vtkMaskPointsFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600CC7D RID: 52349
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPointsFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC7E RID: 52350 RVA: 0x0011C910 File Offset: 0x0011AB10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMaskPointsFilter.vtkMaskPointsFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600CC7F RID: 52351
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPointsFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC80 RID: 52352 RVA: 0x0011C92C File Offset: 0x0011AB2C
		public override int IsA(string type)
		{
			return vtkMaskPointsFilter.vtkMaskPointsFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600CC81 RID: 52353
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPointsFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC82 RID: 52354 RVA: 0x0011C94C File Offset: 0x0011AB4C
		public new static int IsTypeOf(string type)
		{
			return vtkMaskPointsFilter.vtkMaskPointsFilter_IsTypeOf_06(type);
		}

		// Token: 0x0600CC83 RID: 52355
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPointsFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC84 RID: 52356 RVA: 0x0011C968 File Offset: 0x0011AB68
		public new vtkMaskPointsFilter NewInstance()
		{
			vtkMaskPointsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPointsFilter.vtkMaskPointsFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPointsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CC85 RID: 52357
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPointsFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC86 RID: 52358 RVA: 0x0011C9C4 File Offset: 0x0011ABC4
		public new static vtkMaskPointsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMaskPointsFilter vtkMaskPointsFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPointsFilter.vtkMaskPointsFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaskPointsFilter = (vtkMaskPointsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaskPointsFilter.Register(null);
				}
			}
			return vtkMaskPointsFilter;
		}

		// Token: 0x0600CC87 RID: 52359
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPointsFilter_SetEmptyValue_10(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set / get the values indicating whether a voxel is empty. By default, an
		/// empty voxel is marked with a zero value. Any point inside a voxel marked
		/// empty is not selected for output. All other voxels with a value that is
		/// not equal to the empty value are selected for output.
		/// </summary>
		// Token: 0x0600CC88 RID: 52360 RVA: 0x0011CA43 File Offset: 0x0011AC43
		public virtual void SetEmptyValue(byte _arg)
		{
			vtkMaskPointsFilter.vtkMaskPointsFilter_SetEmptyValue_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CC89 RID: 52361
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPointsFilter_SetMaskConnection_11(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the masking image. It is vtkImageData output from an algorithm.
		/// </summary>
		// Token: 0x0600CC8A RID: 52362 RVA: 0x0011CA54 File Offset: 0x0011AC54
		public void SetMaskConnection(vtkAlgorithmOutput algOutput)
		{
			vtkMaskPointsFilter.vtkMaskPointsFilter_SetMaskConnection_11(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600CC8B RID: 52363
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPointsFilter_SetMaskData_12(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the masking image. It must be of type vtkImageData.
		/// </summary>
		// Token: 0x0600CC8C RID: 52364 RVA: 0x0011CA84 File Offset: 0x0011AC84
		public void SetMaskData(vtkDataObject source)
		{
			vtkMaskPointsFilter.vtkMaskPointsFilter_SetMaskData_12(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F1D RID: 3869
		public new const string MRFullTypeName = "Kitware.VTK.vtkMaskPointsFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F1E RID: 3870
		public new static readonly string MRClassNameKey = "class vtkMaskPointsFilter";
	}
}
