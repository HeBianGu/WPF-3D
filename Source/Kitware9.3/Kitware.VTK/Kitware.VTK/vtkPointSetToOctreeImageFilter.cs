using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSetToOctreeImageFilter
	/// </summary>
	/// <remarks>
	///    convert a point set to an octree image
	///
	/// vtkPointSetToOctreeImageFilter is a filter that converts a vtkPointSet to an
	/// a vtkPartitionedDataset with one vtkImageData with a number of points per cell target.
	///
	/// The reason we output a vtkPartitionedDataset is because the WHOLE_EXTENT needs to be dynamic.
	///
	/// The scalars of the vtkImageData are an octree unsigned char cell data array. Each bit of the
	/// unsigned char indicates if the point-set had a point close to one of the 8 corners of the cell.
	///
	/// It can optionally also output a cell data array based on an input point-data scalar array by
	/// setting SetInputArrayToProcess. This array will have 1 or many components that represent
	/// different functions i.e. last value, min, max, count, sum, mean.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///  vtkOctreeImageToPointSetFilter
	/// </seealso>
	// Token: 0x02000496 RID: 1174
	public class vtkPointSetToOctreeImageFilter : vtkPartitionedDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D7CA RID: 55242 RVA: 0x0012C10F File Offset: 0x0012A30F
		static vtkPointSetToOctreeImageFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSetToOctreeImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetToOctreeImageFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D7CB RID: 55243 RVA: 0x0012C137 File Offset: 0x0012A337
		public vtkPointSetToOctreeImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D7CC RID: 55244
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToOctreeImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7CD RID: 55245 RVA: 0x0012C148 File Offset: 0x0012A348
		public new static vtkPointSetToOctreeImageFilter New()
		{
			vtkPointSetToOctreeImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToOctreeImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7CE RID: 55246 RVA: 0x0012C19C File Offset: 0x0012A39C
		public vtkPointSetToOctreeImageFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D7CF RID: 55247 RVA: 0x0012C1E0 File Offset: 0x0012A3E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D7D0 RID: 55248
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeCountOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get if the count of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7D1 RID: 55249 RVA: 0x0012C1EB File Offset: 0x0012A3EB
		public virtual void ComputeCountOff()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeCountOff_01(base.GetCppThis());
		}

		// Token: 0x0600D7D2 RID: 55250
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeCountOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get if the count of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7D3 RID: 55251 RVA: 0x0012C1FA File Offset: 0x0012A3FA
		public virtual void ComputeCountOn()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeCountOn_02(base.GetCppThis());
		}

		// Token: 0x0600D7D4 RID: 55252
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeLastValueOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get if the last value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: Because multithreading is employed the last value computation is not deterministic.
		/// </summary>
		// Token: 0x0600D7D5 RID: 55253 RVA: 0x0012C209 File Offset: 0x0012A409
		public virtual void ComputeLastValueOff()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeLastValueOff_03(base.GetCppThis());
		}

		// Token: 0x0600D7D6 RID: 55254
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeLastValueOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get if the last value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: Because multithreading is employed the last value computation is not deterministic.
		/// </summary>
		// Token: 0x0600D7D7 RID: 55255 RVA: 0x0012C218 File Offset: 0x0012A418
		public virtual void ComputeLastValueOn()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeLastValueOn_04(base.GetCppThis());
		}

		// Token: 0x0600D7D8 RID: 55256
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeMaxOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get if the max value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7D9 RID: 55257 RVA: 0x0012C227 File Offset: 0x0012A427
		public virtual void ComputeMaxOff()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeMaxOff_05(base.GetCppThis());
		}

		// Token: 0x0600D7DA RID: 55258
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeMaxOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get if the max value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7DB RID: 55259 RVA: 0x0012C236 File Offset: 0x0012A436
		public virtual void ComputeMaxOn()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeMaxOn_06(base.GetCppThis());
		}

		// Token: 0x0600D7DC RID: 55260
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeMeanOff_07(HandleRef pThis);

		/// <summary>
		/// Set/Get if the mean value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
		/// not.
		/// </summary>
		// Token: 0x0600D7DD RID: 55261 RVA: 0x0012C245 File Offset: 0x0012A445
		public virtual void ComputeMeanOff()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeMeanOff_07(base.GetCppThis());
		}

		// Token: 0x0600D7DE RID: 55262
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeMeanOn_08(HandleRef pThis);

		/// <summary>
		/// Set/Get if the mean value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
		/// not.
		/// </summary>
		// Token: 0x0600D7DF RID: 55263 RVA: 0x0012C254 File Offset: 0x0012A454
		public virtual void ComputeMeanOn()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeMeanOn_08(base.GetCppThis());
		}

		// Token: 0x0600D7E0 RID: 55264
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeMinOff_09(HandleRef pThis);

		/// <summary>
		/// Set/Get if the min value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7E1 RID: 55265 RVA: 0x0012C263 File Offset: 0x0012A463
		public virtual void ComputeMinOff()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeMinOff_09(base.GetCppThis());
		}

		// Token: 0x0600D7E2 RID: 55266
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeMinOn_10(HandleRef pThis);

		/// <summary>
		/// Set/Get if the min value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7E3 RID: 55267 RVA: 0x0012C272 File Offset: 0x0012A472
		public virtual void ComputeMinOn()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeMinOn_10(base.GetCppThis());
		}

		// Token: 0x0600D7E4 RID: 55268
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeSumOff_11(HandleRef pThis);

		/// <summary>
		/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7E5 RID: 55269 RVA: 0x0012C281 File Offset: 0x0012A481
		public virtual void ComputeSumOff()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeSumOff_11(base.GetCppThis());
		}

		// Token: 0x0600D7E6 RID: 55270
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ComputeSumOn_12(HandleRef pThis);

		/// <summary>
		/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7E7 RID: 55271 RVA: 0x0012C290 File Offset: 0x0012A490
		public virtual void ComputeSumOn()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ComputeSumOn_12(base.GetCppThis());
		}

		// Token: 0x0600D7E8 RID: 55272
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeCount_13(HandleRef pThis);

		/// <summary>
		/// Set/Get if the count of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7E9 RID: 55273 RVA: 0x0012C2A0 File Offset: 0x0012A4A0
		public virtual bool GetComputeCount()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetComputeCount_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D7EA RID: 55274
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeLastValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get if the last value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: Because multithreading is employed the last value computation is not deterministic.
		/// </summary>
		// Token: 0x0600D7EB RID: 55275 RVA: 0x0012C2C8 File Offset: 0x0012A4C8
		public virtual bool GetComputeLastValue()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetComputeLastValue_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D7EC RID: 55276
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeMax_15(HandleRef pThis);

		/// <summary>
		/// Set/Get if the max value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7ED RID: 55277 RVA: 0x0012C2F0 File Offset: 0x0012A4F0
		public virtual bool GetComputeMax()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetComputeMax_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D7EE RID: 55278
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeMean_16(HandleRef pThis);

		/// <summary>
		/// Set/Get if the mean value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
		/// not.
		/// </summary>
		// Token: 0x0600D7EF RID: 55279 RVA: 0x0012C318 File Offset: 0x0012A518
		public virtual bool GetComputeMean()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetComputeMean_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D7F0 RID: 55280
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeMin_17(HandleRef pThis);

		/// <summary>
		/// Set/Get if the min value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7F1 RID: 55281 RVA: 0x0012C340 File Offset: 0x0012A540
		public virtual bool GetComputeMin()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetComputeMin_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D7F2 RID: 55282
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeSum_18(HandleRef pThis);

		/// <summary>
		/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D7F3 RID: 55283 RVA: 0x0012C368 File Offset: 0x0012A568
		public virtual bool GetComputeSum()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetComputeSum_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D7F4 RID: 55284
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7F5 RID: 55285 RVA: 0x0012C390 File Offset: 0x0012A590
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600D7F6 RID: 55286
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7F7 RID: 55287 RVA: 0x0012C3B0 File Offset: 0x0012A5B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600D7F8 RID: 55288
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCell_21(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each cell of the output image.
		/// This data member is used to determine the number dimensions of the output image.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D7F9 RID: 55289 RVA: 0x0012C3CC File Offset: 0x0012A5CC
		public virtual int GetNumberOfPointsPerCell()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCell_21(base.GetCppThis());
		}

		// Token: 0x0600D7FA RID: 55290
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each cell of the output image.
		/// This data member is used to determine the number dimensions of the output image.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D7FB RID: 55291 RVA: 0x0012C3EC File Offset: 0x0012A5EC
		public virtual int GetNumberOfPointsPerCellMaxValue()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600D7FC RID: 55292
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMinValue_23(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each cell of the output image.
		/// This data member is used to determine the number dimensions of the output image.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D7FD RID: 55293 RVA: 0x0012C40C File Offset: 0x0012A60C
		public virtual int GetNumberOfPointsPerCellMinValue()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600D7FE RID: 55294
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToOctreeImageFilter_GetProcessInputPointArray_24(HandleRef pThis);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D7FF RID: 55295 RVA: 0x0012C42C File Offset: 0x0012A62C
		public virtual bool GetProcessInputPointArray()
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_GetProcessInputPointArray_24(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D800 RID: 55296
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToOctreeImageFilter_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D801 RID: 55297 RVA: 0x0012C454 File Offset: 0x0012A654
		public override int IsA(string type)
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0600D802 RID: 55298
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToOctreeImageFilter_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D803 RID: 55299 RVA: 0x0012C474 File Offset: 0x0012A674
		public new static int IsTypeOf(string type)
		{
			return vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_IsTypeOf_26(type);
		}

		// Token: 0x0600D804 RID: 55300
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToOctreeImageFilter_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D805 RID: 55301 RVA: 0x0012C490 File Offset: 0x0012A690
		public new vtkPointSetToOctreeImageFilter NewInstance()
		{
			vtkPointSetToOctreeImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToOctreeImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D806 RID: 55302
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOff_29(HandleRef pThis);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D807 RID: 55303 RVA: 0x0012C4EA File Offset: 0x0012A6EA
		public virtual void ProcessInputPointArrayOff()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOff_29(base.GetCppThis());
		}

		// Token: 0x0600D808 RID: 55304
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOn_30(HandleRef pThis);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D809 RID: 55305 RVA: 0x0012C4F9 File Offset: 0x0012A6F9
		public virtual void ProcessInputPointArrayOn()
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOn_30(base.GetCppThis());
		}

		// Token: 0x0600D80A RID: 55306
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToOctreeImageFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D80B RID: 55307 RVA: 0x0012C508 File Offset: 0x0012A708
		public new static vtkPointSetToOctreeImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPointSetToOctreeImageFilter vtkPointSetToOctreeImageFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSetToOctreeImageFilter = (vtkPointSetToOctreeImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSetToOctreeImageFilter.Register(null);
				}
			}
			return vtkPointSetToOctreeImageFilter;
		}

		// Token: 0x0600D80C RID: 55308
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetComputeCount_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the count of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D80D RID: 55309 RVA: 0x0012C587 File Offset: 0x0012A787
		public virtual void SetComputeCount(bool _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetComputeCount_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D80E RID: 55310
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetComputeLastValue_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the last value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: Because multithreading is employed the last value computation is not deterministic.
		/// </summary>
		// Token: 0x0600D80F RID: 55311 RVA: 0x0012C59F File Offset: 0x0012A79F
		public virtual void SetComputeLastValue(bool _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetComputeLastValue_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D810 RID: 55312
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetComputeMax_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the max value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D811 RID: 55313 RVA: 0x0012C5B7 File Offset: 0x0012A7B7
		public virtual void SetComputeMax(bool _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetComputeMax_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D812 RID: 55314
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetComputeMean_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the mean value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		///
		/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
		/// not.
		/// </summary>
		// Token: 0x0600D813 RID: 55315 RVA: 0x0012C5CF File Offset: 0x0012A7CF
		public virtual void SetComputeMean(bool _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetComputeMean_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D814 RID: 55316
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetComputeMin_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the min value for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D815 RID: 55317 RVA: 0x0012C5E7 File Offset: 0x0012A7E7
		public virtual void SetComputeMin(bool _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetComputeMin_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D816 RID: 55318
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetComputeSum_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x0600D817 RID: 55319 RVA: 0x0012C5FF File Offset: 0x0012A7FF
		public virtual void SetComputeSum(bool _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetComputeSum_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D818 RID: 55320
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetNumberOfPointsPerCell_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the average number of points in each cell of the output image.
		/// This data member is used to determine the number dimensions of the output image.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D819 RID: 55321 RVA: 0x0012C617 File Offset: 0x0012A817
		public virtual void SetNumberOfPointsPerCell(int _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetNumberOfPointsPerCell_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D81A RID: 55322
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToOctreeImageFilter_SetProcessInputPointArray_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D81B RID: 55323 RVA: 0x0012C627 File Offset: 0x0012A827
		public virtual void SetProcessInputPointArray(bool _arg)
		{
			vtkPointSetToOctreeImageFilter.vtkPointSetToOctreeImageFilter_SetProcessInputPointArray_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD4 RID: 4052
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetToOctreeImageFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD5 RID: 4053
		public new static readonly string MRClassNameKey = "class vtkPointSetToOctreeImageFilter";
	}
}
