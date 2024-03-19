using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageData
	/// </summary>
	/// <remarks>
	///    topologically and geometrically regular array of data
	///
	/// vtkImageData is a data object that is a concrete implementation of
	/// vtkDataSet. vtkImageData represents a geometric structure that is
	/// a topological and geometrical regular array of points. Examples include
	/// volumes (voxel data) and pixmaps. This representation supports images
	/// up to three dimensions. The image may also be oriented (see the
	/// DirectionMatrices and related transformation methods). Note however,
	/// that not all filters support oriented images.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageTransform
	/// </seealso>
	// Token: 0x02000A63 RID: 2659
	public class vtkImageData : vtkDataSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BCC0 RID: 113856 RVA: 0x0026ECEF File Offset: 0x0026CEEF
		static vtkImageData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BCC1 RID: 113857 RVA: 0x0026ED17 File Offset: 0x0026CF17
		public vtkImageData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BCC2 RID: 113858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCC3 RID: 113859 RVA: 0x0026ED28 File Offset: 0x0026CF28
		public new static vtkImageData New()
		{
			vtkImageData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCC4 RID: 113860 RVA: 0x0026ED7C File Offset: 0x0026CF7C
		public vtkImageData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageData.vtkImageData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BCC5 RID: 113861 RVA: 0x0026EDC0 File Offset: 0x0026CFC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BCC6 RID: 113862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_AllocateScalars_01(HandleRef pThis, int dataType, int numComponents);

		/// <summary>
		/// Allocate the point scalars for this dataset. The data type determines
		/// the type of the array (VTK_FLOAT, VTK_INT etc.) where as numComponents
		/// determines its number of components.
		/// </summary>
		// Token: 0x0601BCC7 RID: 113863 RVA: 0x0026EDCB File Offset: 0x0026CFCB
		public virtual void AllocateScalars(int dataType, int numComponents)
		{
			vtkImageData.vtkImageData_AllocateScalars_01(base.GetCppThis(), dataType, numComponents);
		}

		// Token: 0x0601BCC8 RID: 113864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_AllocateScalars_02(HandleRef pThis, HandleRef pipeline_info);

		/// <summary>
		/// Allocate the point scalars for this dataset. The data type and the
		/// number of components of the array is determined by the meta-data in
		/// the pipeline information. This is usually produced by a reader/filter
		/// upstream in the pipeline.
		/// </summary>
		// Token: 0x0601BCC9 RID: 113865 RVA: 0x0026EDDC File Offset: 0x0026CFDC
		public virtual void AllocateScalars(vtkInformation pipeline_info)
		{
			vtkImageData.vtkImageData_AllocateScalars_02(base.GetCppThis(), (pipeline_info == null) ? default(HandleRef) : pipeline_info.GetCppThis());
		}

		// Token: 0x0601BCCA RID: 113866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_ComputeBounds_03(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCCB RID: 113867 RVA: 0x0026EE0B File Offset: 0x0026D00B
		public override void ComputeBounds()
		{
			vtkImageData.vtkImageData_ComputeBounds_03(base.GetCppThis());
		}

		// Token: 0x0601BCCC RID: 113868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_ComputeCellId_04(HandleRef pThis, IntPtr ijk);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), return the cell id.
		/// </summary>
		// Token: 0x0601BCCD RID: 113869 RVA: 0x0026EE1C File Offset: 0x0026D01C
		public virtual long ComputeCellId(IntPtr ijk)
		{
			return vtkImageData.vtkImageData_ComputeCellId_04(base.GetCppThis(), ijk);
		}

		// Token: 0x0601BCCE RID: 113870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_ComputeIndexToPhysicalMatrix_05(IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr result);

		/// <summary>
		/// Convert coordinates from physical space (xyz) to index space (ijk).
		/// </summary>
		// Token: 0x0601BCCF RID: 113871 RVA: 0x0026EE3C File Offset: 0x0026D03C
		public static void ComputeIndexToPhysicalMatrix(IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr result)
		{
			vtkImageData.vtkImageData_ComputeIndexToPhysicalMatrix_05(origin, spacing, direction, result);
		}

		// Token: 0x0601BCD0 RID: 113872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_ComputeInternalExtent_06(HandleRef pThis, IntPtr intExt, IntPtr tgtExt, IntPtr bnds);

		/// <summary>
		/// Given how many pixel are required on a side for boundary conditions (in
		/// bnds), the target extent to traverse, compute the internal extent (the
		/// extent for this ImageData that does not suffer from any boundary
		/// conditions) and place it in intExt
		/// </summary>
		// Token: 0x0601BCD1 RID: 113873 RVA: 0x0026EE49 File Offset: 0x0026D049
		public void ComputeInternalExtent(IntPtr intExt, IntPtr tgtExt, IntPtr bnds)
		{
			vtkImageData.vtkImageData_ComputeInternalExtent_06(base.GetCppThis(), intExt, tgtExt, bnds);
		}

		// Token: 0x0601BCD2 RID: 113874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_ComputePointId_07(HandleRef pThis, IntPtr ijk);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), return the point id.
		/// </summary>
		// Token: 0x0601BCD3 RID: 113875 RVA: 0x0026EE5C File Offset: 0x0026D05C
		public virtual long ComputePointId(IntPtr ijk)
		{
			return vtkImageData.vtkImageData_ComputePointId_07(base.GetCppThis(), ijk);
		}

		// Token: 0x0601BCD4 RID: 113876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_ComputeStructuredCoordinates_08(HandleRef pThis, IntPtr x, IntPtr ijk, IntPtr pcoords);

		/// <summary>
		/// Convenience function computes the structured coordinates for a point x[3].
		/// The voxel is specified by the array ijk[3], and the parametric coordinates
		/// in the cell are specified with pcoords[3]. The function returns a 0 if the
		/// point x is outside of the volume, and a 1 if inside the volume.
		/// </summary>
		// Token: 0x0601BCD5 RID: 113877 RVA: 0x0026EE7C File Offset: 0x0026D07C
		public virtual int ComputeStructuredCoordinates(IntPtr x, IntPtr ijk, IntPtr pcoords)
		{
			return vtkImageData.vtkImageData_ComputeStructuredCoordinates_08(base.GetCppThis(), x, ijk, pcoords);
		}

		// Token: 0x0601BCD6 RID: 113878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_CopyAndCastFrom_09(HandleRef pThis, HandleRef inData, int x0, int x1, int y0, int y1, int z0, int z1);

		/// <summary>
		/// This method is passed a input and output region, and executes the filter
		/// algorithm to fill the output from the input.
		/// It just executes a switch statement to call the correct function for
		/// the regions data types.
		/// </summary>
		// Token: 0x0601BCD7 RID: 113879 RVA: 0x0026EEA0 File Offset: 0x0026D0A0
		public virtual void CopyAndCastFrom(vtkImageData inData, int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkImageData.vtkImageData_CopyAndCastFrom_09(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x0601BCD8 RID: 113880
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_CopyAndCastFrom_10(HandleRef pThis, HandleRef inData, IntPtr extent);

		/// <summary>
		/// This method is passed a input and output region, and executes the filter
		/// algorithm to fill the output from the input.
		/// It just executes a switch statement to call the correct function for
		/// the regions data types.
		/// </summary>
		// Token: 0x0601BCD9 RID: 113881 RVA: 0x0026EEDC File Offset: 0x0026D0DC
		public virtual void CopyAndCastFrom(vtkImageData inData, IntPtr extent)
		{
			vtkImageData.vtkImageData_CopyAndCastFrom_10(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), extent);
		}

		// Token: 0x0601BCDA RID: 113882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_CopyInformationFromPipeline_11(HandleRef pThis, HandleRef information);

		/// <summary>
		/// Override these to handle origin, spacing, scalar type, and scalar
		/// number of components.  See vtkDataObject for details.
		/// </summary>
		// Token: 0x0601BCDB RID: 113883 RVA: 0x0026EF0C File Offset: 0x0026D10C
		public override void CopyInformationFromPipeline(vtkInformation information)
		{
			vtkImageData.vtkImageData_CopyInformationFromPipeline_11(base.GetCppThis(), (information == null) ? default(HandleRef) : information.GetCppThis());
		}

		// Token: 0x0601BCDC RID: 113884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_CopyInformationToPipeline_12(HandleRef pThis, HandleRef information);

		/// <summary>
		/// Copy information from this data object to the pipeline information.
		/// This is used by the vtkTrivialProducer that is created when someone
		/// calls SetInputData() to connect the image to a pipeline.
		/// </summary>
		// Token: 0x0601BCDD RID: 113885 RVA: 0x0026EF3C File Offset: 0x0026D13C
		public override void CopyInformationToPipeline(vtkInformation information)
		{
			vtkImageData.vtkImageData_CopyInformationToPipeline_12(base.GetCppThis(), (information == null) ? default(HandleRef) : information.GetCppThis());
		}

		// Token: 0x0601BCDE RID: 113886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_CopyStructure_13(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the geometric and topological structure of an input image data
		/// object.
		/// </summary>
		// Token: 0x0601BCDF RID: 113887 RVA: 0x0026EF6C File Offset: 0x0026D16C
		public override void CopyStructure(vtkDataSet ds)
		{
			vtkImageData.vtkImageData_CopyStructure_13(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601BCE0 RID: 113888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_Crop_14(HandleRef pThis, IntPtr updateExtent);

		/// <summary>
		/// Reallocates and copies to set the Extent to updateExtent.
		/// This is used internally when the exact extent is requested,
		/// and the source generated more than the update extent.
		/// </summary>
		// Token: 0x0601BCE1 RID: 113889 RVA: 0x0026EF9B File Offset: 0x0026D19B
		public override void Crop(IntPtr updateExtent)
		{
			vtkImageData.vtkImageData_Crop_14(base.GetCppThis(), updateExtent);
		}

		// Token: 0x0601BCE2 RID: 113890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_DeepCopy_15(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601BCE3 RID: 113891 RVA: 0x0026EFAC File Offset: 0x0026D1AC
		public override void DeepCopy(vtkDataObject src)
		{
			vtkImageData.vtkImageData_DeepCopy_15(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601BCE4 RID: 113892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_ExtendedNew_16(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCE5 RID: 113893 RVA: 0x0026EFDC File Offset: 0x0026D1DC
		public static vtkImageData ExtendedNew()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_ExtendedNew_16(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0601BCE6 RID: 113894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_FindAndGetCell_17(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCE7 RID: 113895 RVA: 0x0026F048 File Offset: 0x0026D248
		public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_FindAndGetCell_17(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601BCE8 RID: 113896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_FindCell_18(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCE9 RID: 113897 RVA: 0x0026F0D8 File Offset: 0x0026D2D8
		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkImageData.vtkImageData_FindCell_18(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601BCEA RID: 113898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_FindCell_19(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCEB RID: 113899 RVA: 0x0026F118 File Offset: 0x0026D318
		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkImageData.vtkImageData_FindCell_19(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601BCEC RID: 113900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_FindPoint_20(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCED RID: 113901 RVA: 0x0026F16C File Offset: 0x0026D36C
		public new virtual long FindPoint(double x, double y, double z)
		{
			return vtkImageData.vtkImageData_FindPoint_20(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601BCEE RID: 113902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_FindPoint_21(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCEF RID: 113903 RVA: 0x0026F190 File Offset: 0x0026D390
		public override long FindPoint(IntPtr x)
		{
			return vtkImageData.vtkImageData_FindPoint_21(base.GetCppThis(), x);
		}

		// Token: 0x0601BCF0 RID: 113904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkImageData_GetActualMemorySize_22(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x0601BCF1 RID: 113905 RVA: 0x0026F1B0 File Offset: 0x0026D3B0
		public override uint GetActualMemorySize()
		{
			return vtkImageData.vtkImageData_GetActualMemorySize_22(base.GetCppThis());
		}

		// Token: 0x0601BCF2 RID: 113906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetArrayIncrements_23(HandleRef pThis, HandleRef array, IntPtr increments);

		/// <summary>
		/// Since various arrays have different number of components,
		/// the will have different increments.
		/// </summary>
		// Token: 0x0601BCF3 RID: 113907 RVA: 0x0026F1D0 File Offset: 0x0026D3D0
		public void GetArrayIncrements(vtkDataArray array, IntPtr increments)
		{
			vtkImageData.vtkImageData_GetArrayIncrements_23(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), increments);
		}

		// Token: 0x0601BCF4 RID: 113908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetArrayPointer_24(HandleRef pThis, HandleRef array, IntPtr coordinates);

		/// <summary>
		/// These are convenience methods for getting a pointer
		/// from any filed array.  It is a start at expanding image filters
		/// to process any array (not just scalars).
		/// </summary>
		// Token: 0x0601BCF5 RID: 113909 RVA: 0x0026F200 File Offset: 0x0026D400
		public IntPtr GetArrayPointer(vtkDataArray array, IntPtr coordinates)
		{
			return vtkImageData.vtkImageData_GetArrayPointer_24(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), coordinates);
		}

		// Token: 0x0601BCF6 RID: 113910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetArrayPointerForExtent_25(HandleRef pThis, HandleRef array, IntPtr extent);

		/// <summary>
		/// These are convenience methods for getting a pointer
		/// from any filed array.  It is a start at expanding image filters
		/// to process any array (not just scalars).
		/// </summary>
		// Token: 0x0601BCF7 RID: 113911 RVA: 0x0026F238 File Offset: 0x0026D438
		public IntPtr GetArrayPointerForExtent(vtkDataArray array, IntPtr extent)
		{
			return vtkImageData.vtkImageData_GetArrayPointerForExtent_25(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), extent);
		}

		// Token: 0x0601BCF8 RID: 113912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetAxisUpdateExtent_26(HandleRef pThis, int axis, ref int min, ref int max, IntPtr updateExtent);

		/// <summary>
		/// Set / Get the extent on just one axis
		/// </summary>
		// Token: 0x0601BCF9 RID: 113913 RVA: 0x0026F26D File Offset: 0x0026D46D
		public virtual void GetAxisUpdateExtent(int axis, ref int min, ref int max, IntPtr updateExtent)
		{
			vtkImageData.vtkImageData_GetAxisUpdateExtent_26(base.GetCppThis(), axis, ref min, ref max, updateExtent);
		}

		// Token: 0x0601BCFA RID: 113914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetCell_27(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCFB RID: 113915 RVA: 0x0026F284 File Offset: 0x0026D484
		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_GetCell_27(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601BCFC RID: 113916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetCell_28(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCFD RID: 113917 RVA: 0x0026F2F4 File Offset: 0x0026D4F4
		public override vtkCell GetCell(int i, int j, int k)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_GetCell_28(base.GetCppThis(), i, j, k, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601BCFE RID: 113918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetCell_29(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BCFF RID: 113919 RVA: 0x0026F368 File Offset: 0x0026D568
		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkImageData.vtkImageData_GetCell_29(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601BD00 RID: 113920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetCellBounds_30(HandleRef pThis, long cellId, IntPtr bounds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD01 RID: 113921 RVA: 0x0026F398 File Offset: 0x0026D598
		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkImageData.vtkImageData_GetCellBounds_30(base.GetCppThis(), cellId, bounds);
		}

		// Token: 0x0601BD02 RID: 113922
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetCellDims_31(HandleRef pThis, IntPtr cellDims);

		/// <summary>
		/// Given the node dimensions of this grid instance, this method computes the
		/// node dimensions. The value in each dimension can will have a lowest value
		/// of "1" such that computing the total number of cells can be achieved by
		/// simply by cellDims[0]*cellDims[1]*cellDims[2].
		/// </summary>
		// Token: 0x0601BD03 RID: 113923 RVA: 0x0026F3A9 File Offset: 0x0026D5A9
		public void GetCellDims(IntPtr cellDims)
		{
			vtkImageData.vtkImageData_GetCellDims_31(base.GetCppThis(), cellDims);
		}

		// Token: 0x0601BD04 RID: 113924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetCellNeighbors_32(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD05 RID: 113925 RVA: 0x0026F3BC File Offset: 0x0026D5BC
		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkImageData.vtkImageData_GetCellNeighbors_32(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601BD06 RID: 113926
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetCellNeighbors_33(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr seedLoc);

		/// <summary>
		/// Get cell neighbors around cell located at `seedloc`, except cell of id `cellId`.
		///
		/// @warning `seedloc` is the position in the grid with the origin shifted to (0, 0, 0).
		/// This is because the backend of this method is shared with `vtkRectilinearGrid` and
		/// `vtkStructuredGrid`.
		/// </summary>
		// Token: 0x0601BD07 RID: 113927 RVA: 0x0026F404 File Offset: 0x0026D604
		public void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr seedLoc)
		{
			vtkImageData.vtkImageData_GetCellNeighbors_33(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), seedLoc);
		}

		// Token: 0x0601BD08 RID: 113928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetCellPoints_34(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD09 RID: 113929 RVA: 0x0026F44C File Offset: 0x0026D64C
		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkImageData.vtkImageData_GetCellPoints_34(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601BD0A RID: 113930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetCellSize_35(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD0B RID: 113931 RVA: 0x0026F47C File Offset: 0x0026D67C
		public override long GetCellSize(long cellId)
		{
			return vtkImageData.vtkImageData_GetCellSize_35(base.GetCppThis(), cellId);
		}

		// Token: 0x0601BD0C RID: 113932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetCellType_36(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD0D RID: 113933 RVA: 0x0026F49C File Offset: 0x0026D69C
		public override int GetCellType(long cellId)
		{
			return vtkImageData.vtkImageData_GetCellType_36(base.GetCppThis(), cellId);
		}

		// Token: 0x0601BD0E RID: 113934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetContinuousIncrements_37(HandleRef pThis, IntPtr extent, ref long incX, ref long incY, ref long incZ);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// incX is always returned with 0.  incY is returned with the
		/// increment needed to move from the end of one X scanline of data
		/// to the start of the next line.  incZ is filled in with the
		/// increment needed to move from the end of one image to the start
		/// of the next.  The proper way to use these values is to for a loop
		/// over Z, Y, X, C, incrementing the pointer by 1 after each
		/// component.  When the end of the component is reached, the pointer
		/// is set to the beginning of the next pixel, thus incX is properly set to 0.
		/// The first form of GetContinuousIncrements uses the active scalar field
		/// while the second form allows the scalar array to be passed in.
		/// </summary>
		// Token: 0x0601BD0F RID: 113935 RVA: 0x0026F4BC File Offset: 0x0026D6BC
		public virtual void GetContinuousIncrements(IntPtr extent, ref long incX, ref long incY, ref long incZ)
		{
			vtkImageData.vtkImageData_GetContinuousIncrements_37(base.GetCppThis(), extent, ref incX, ref incY, ref incZ);
		}

		// Token: 0x0601BD10 RID: 113936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetContinuousIncrements_38(HandleRef pThis, HandleRef scalars, IntPtr extent, ref long incX, ref long incY, ref long incZ);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// incX is always returned with 0.  incY is returned with the
		/// increment needed to move from the end of one X scanline of data
		/// to the start of the next line.  incZ is filled in with the
		/// increment needed to move from the end of one image to the start
		/// of the next.  The proper way to use these values is to for a loop
		/// over Z, Y, X, C, incrementing the pointer by 1 after each
		/// component.  When the end of the component is reached, the pointer
		/// is set to the beginning of the next pixel, thus incX is properly set to 0.
		/// The first form of GetContinuousIncrements uses the active scalar field
		/// while the second form allows the scalar array to be passed in.
		/// </summary>
		// Token: 0x0601BD11 RID: 113937 RVA: 0x0026F4D0 File Offset: 0x0026D6D0
		public virtual void GetContinuousIncrements(vtkDataArray scalars, IntPtr extent, ref long incX, ref long incY, ref long incZ)
		{
			vtkImageData.vtkImageData_GetContinuousIncrements_38(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), extent, ref incX, ref incY, ref incZ);
		}

		// Token: 0x0601BD12 RID: 113938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetData_39(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BD13 RID: 113939 RVA: 0x0026F508 File Offset: 0x0026D708
		public new static vtkImageData GetData(vtkInformation info)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_GetData_39((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0601BD14 RID: 113940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetData_40(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BD15 RID: 113941 RVA: 0x0026F588 File Offset: 0x0026D788
		public new static vtkImageData GetData(vtkInformationVector v, int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_GetData_40((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0601BD16 RID: 113942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetDataDimension_41(HandleRef pThis);

		/// <summary>
		/// Return the dimensionality of the data.
		/// </summary>
		// Token: 0x0601BD17 RID: 113943 RVA: 0x0026F608 File Offset: 0x0026D808
		public virtual int GetDataDimension()
		{
			return vtkImageData.vtkImageData_GetDataDimension_41(base.GetCppThis());
		}

		// Token: 0x0601BD18 RID: 113944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetDataObjectType_42(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601BD19 RID: 113945 RVA: 0x0026F628 File Offset: 0x0026D828
		public override int GetDataObjectType()
		{
			return vtkImageData.vtkImageData_GetDataObjectType_42(base.GetCppThis());
		}

		// Token: 0x0601BD1A RID: 113946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetDimensions_43(HandleRef pThis);

		/// <summary>
		/// Get dimensions of this structured points dataset.
		/// It is the number of points on each axis.
		/// Dimensions are computed from Extents during this call.
		/// \warning Non thread-safe, use second signature if you want it to be.
		/// </summary>
		// Token: 0x0601BD1B RID: 113947 RVA: 0x0026F648 File Offset: 0x0026D848
		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetDimensions_43(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BD1C RID: 113948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetDimensions_44(HandleRef pThis, IntPtr dims);

		/// <summary>
		/// Get dimensions of this structured points dataset.
		/// It is the number of points on each axis.
		/// This method is thread-safe.
		/// \warning The Dimensions member variable is not updated during this call.
		/// </summary>
		// Token: 0x0601BD1D RID: 113949 RVA: 0x0026F690 File Offset: 0x0026D890
		public virtual void GetDimensions(IntPtr dims)
		{
			vtkImageData.vtkImageData_GetDimensions_44(base.GetCppThis(), dims);
		}

		// Token: 0x0601BD1E RID: 113950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetDirectionMatrix_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the direction transform of the dataset. The direction matrix is
		/// a 3x3 transformation matrix supporting scaling and rotation.
		/// </summary>
		// Token: 0x0601BD1F RID: 113951 RVA: 0x0026F6A0 File Offset: 0x0026D8A0
		public virtual vtkMatrix3x3 GetDirectionMatrix()
		{
			vtkMatrix3x3 vtkMatrix3x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_GetDirectionMatrix_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix3x = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix3x.Register(null);
				}
			}
			return vtkMatrix3x;
		}

		// Token: 0x0601BD20 RID: 113952
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetExtent_46(HandleRef pThis);

		/// <summary>
		/// Set/Get the extent. On each axis, the extent is defined by the index
		/// of the first point and the index of the last point.  The extent should
		/// be set before the "Scalars" are set or allocated.  The Extent is
		/// stored in the order (X, Y, Z).
		/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
		/// extent of the origin.
		/// The first point (the one with Id=0) is at extent
		/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
		/// data starts at Id=0.
		/// </summary>
		// Token: 0x0601BD21 RID: 113953 RVA: 0x0026F710 File Offset: 0x0026D910
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetExtent_46(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BD22 RID: 113954
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetExtent_47(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/Get the extent. On each axis, the extent is defined by the index
		/// of the first point and the index of the last point.  The extent should
		/// be set before the "Scalars" are set or allocated.  The Extent is
		/// stored in the order (X, Y, Z).
		/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
		/// extent of the origin.
		/// The first point (the one with Id=0) is at extent
		/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
		/// data starts at Id=0.
		/// </summary>
		// Token: 0x0601BD23 RID: 113955 RVA: 0x0026F758 File Offset: 0x0026D958
		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageData.vtkImageData_GetExtent_47(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601BD24 RID: 113956
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetExtent_48(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent. On each axis, the extent is defined by the index
		/// of the first point and the index of the last point.  The extent should
		/// be set before the "Scalars" are set or allocated.  The Extent is
		/// stored in the order (X, Y, Z).
		/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
		/// extent of the origin.
		/// The first point (the one with Id=0) is at extent
		/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
		/// data starts at Id=0.
		/// </summary>
		// Token: 0x0601BD25 RID: 113957 RVA: 0x0026F770 File Offset: 0x0026D970
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkImageData.vtkImageData_GetExtent_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BD26 RID: 113958
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetExtentType_49(HandleRef pThis);

		/// <summary>
		/// The extent type is a 3D extent
		/// </summary>
		// Token: 0x0601BD27 RID: 113959 RVA: 0x0026F780 File Offset: 0x0026D980
		public override int GetExtentType()
		{
			return vtkImageData.vtkImageData_GetExtentType_49(base.GetCppThis());
		}

		// Token: 0x0601BD28 RID: 113960
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetIncrements_50(HandleRef pThis);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// GetIncrements() calls ComputeIncrements() to ensure the increments are
		/// up to date.  The first three methods compute the increments based on the
		/// active scalar field while the next three, the scalar field is passed in.
		///
		/// Note that all methods which do not have the increments passed in are not
		/// thread-safe. When working on a given `vtkImageData` instance on multiple
		/// threads, each thread should use the `inc*` overloads to compute the
		/// increments to avoid racing with other threads.
		/// </summary>
		// Token: 0x0601BD29 RID: 113961 RVA: 0x0026F7A0 File Offset: 0x0026D9A0
		public virtual IntPtr GetIncrements()
		{
			return vtkImageData.vtkImageData_GetIncrements_50(base.GetCppThis());
		}

		// Token: 0x0601BD2A RID: 113962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetIncrements_51(HandleRef pThis, ref long incX, ref long incY, ref long incZ);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// GetIncrements() calls ComputeIncrements() to ensure the increments are
		/// up to date.  The first three methods compute the increments based on the
		/// active scalar field while the next three, the scalar field is passed in.
		///
		/// Note that all methods which do not have the increments passed in are not
		/// thread-safe. When working on a given `vtkImageData` instance on multiple
		/// threads, each thread should use the `inc*` overloads to compute the
		/// increments to avoid racing with other threads.
		/// </summary>
		// Token: 0x0601BD2B RID: 113963 RVA: 0x0026F7BF File Offset: 0x0026D9BF
		public virtual void GetIncrements(ref long incX, ref long incY, ref long incZ)
		{
			vtkImageData.vtkImageData_GetIncrements_51(base.GetCppThis(), ref incX, ref incY, ref incZ);
		}

		// Token: 0x0601BD2C RID: 113964
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetIncrements_52(HandleRef pThis, IntPtr inc);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// GetIncrements() calls ComputeIncrements() to ensure the increments are
		/// up to date.  The first three methods compute the increments based on the
		/// active scalar field while the next three, the scalar field is passed in.
		///
		/// Note that all methods which do not have the increments passed in are not
		/// thread-safe. When working on a given `vtkImageData` instance on multiple
		/// threads, each thread should use the `inc*` overloads to compute the
		/// increments to avoid racing with other threads.
		/// </summary>
		// Token: 0x0601BD2D RID: 113965 RVA: 0x0026F7D1 File Offset: 0x0026D9D1
		public virtual void GetIncrements(IntPtr inc)
		{
			vtkImageData.vtkImageData_GetIncrements_52(base.GetCppThis(), inc);
		}

		// Token: 0x0601BD2E RID: 113966
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetIncrements_53(HandleRef pThis, HandleRef scalars);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// GetIncrements() calls ComputeIncrements() to ensure the increments are
		/// up to date.  The first three methods compute the increments based on the
		/// active scalar field while the next three, the scalar field is passed in.
		///
		/// Note that all methods which do not have the increments passed in are not
		/// thread-safe. When working on a given `vtkImageData` instance on multiple
		/// threads, each thread should use the `inc*` overloads to compute the
		/// increments to avoid racing with other threads.
		/// </summary>
		// Token: 0x0601BD2F RID: 113967 RVA: 0x0026F7E4 File Offset: 0x0026D9E4
		public virtual IntPtr GetIncrements(vtkDataArray scalars)
		{
			return vtkImageData.vtkImageData_GetIncrements_53(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x0601BD30 RID: 113968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetIncrements_54(HandleRef pThis, HandleRef scalars, ref long incX, ref long incY, ref long incZ);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// GetIncrements() calls ComputeIncrements() to ensure the increments are
		/// up to date.  The first three methods compute the increments based on the
		/// active scalar field while the next three, the scalar field is passed in.
		///
		/// Note that all methods which do not have the increments passed in are not
		/// thread-safe. When working on a given `vtkImageData` instance on multiple
		/// threads, each thread should use the `inc*` overloads to compute the
		/// increments to avoid racing with other threads.
		/// </summary>
		// Token: 0x0601BD31 RID: 113969 RVA: 0x0026F818 File Offset: 0x0026DA18
		public virtual void GetIncrements(vtkDataArray scalars, ref long incX, ref long incY, ref long incZ)
		{
			vtkImageData.vtkImageData_GetIncrements_54(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), ref incX, ref incY, ref incZ);
		}

		// Token: 0x0601BD32 RID: 113970
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetIncrements_55(HandleRef pThis, HandleRef scalars, IntPtr inc);

		/// <summary>
		/// Different ways to get the increments for moving around the data.
		/// GetIncrements() calls ComputeIncrements() to ensure the increments are
		/// up to date.  The first three methods compute the increments based on the
		/// active scalar field while the next three, the scalar field is passed in.
		///
		/// Note that all methods which do not have the increments passed in are not
		/// thread-safe. When working on a given `vtkImageData` instance on multiple
		/// threads, each thread should use the `inc*` overloads to compute the
		/// increments to avoid racing with other threads.
		/// </summary>
		// Token: 0x0601BD33 RID: 113971 RVA: 0x0026F84C File Offset: 0x0026DA4C
		public virtual void GetIncrements(vtkDataArray scalars, IntPtr inc)
		{
			vtkImageData.vtkImageData_GetIncrements_55(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), inc);
		}

		// Token: 0x0601BD34 RID: 113972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetIndexToPhysicalMatrix_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transformation matrix from the index space to the physical space
		/// coordinate system of the dataset. The transform is a 4 by 4 matrix.
		/// </summary>
		// Token: 0x0601BD35 RID: 113973 RVA: 0x0026F87C File Offset: 0x0026DA7C
		public virtual vtkMatrix4x4 GetIndexToPhysicalMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_GetIndexToPhysicalMatrix_56(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0601BD36 RID: 113974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetMaxCellSize_57(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD37 RID: 113975 RVA: 0x0026F8EC File Offset: 0x0026DAEC
		public override int GetMaxCellSize()
		{
			return vtkImageData.vtkImageData_GetMaxCellSize_57(base.GetCppThis());
		}

		// Token: 0x0601BD38 RID: 113976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetMaxSpatialDimension_58(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD39 RID: 113977 RVA: 0x0026F90C File Offset: 0x0026DB0C
		public override int GetMaxSpatialDimension()
		{
			return vtkImageData.vtkImageData_GetMaxSpatialDimension_58(base.GetCppThis());
		}

		// Token: 0x0601BD3A RID: 113978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetNumberOfCells_59(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD3B RID: 113979 RVA: 0x0026F92C File Offset: 0x0026DB2C
		public override long GetNumberOfCells()
		{
			return vtkImageData.vtkImageData_GetNumberOfCells_59(base.GetCppThis());
		}

		// Token: 0x0601BD3C RID: 113980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetNumberOfGenerationsFromBase_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BD3D RID: 113981 RVA: 0x0026F94C File Offset: 0x0026DB4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageData.vtkImageData_GetNumberOfGenerationsFromBase_60(base.GetCppThis(), type);
		}

		// Token: 0x0601BD3E RID: 113982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetNumberOfGenerationsFromBaseType_61([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BD3F RID: 113983 RVA: 0x0026F96C File Offset: 0x0026DB6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageData.vtkImageData_GetNumberOfGenerationsFromBaseType_61(type);
		}

		// Token: 0x0601BD40 RID: 113984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetNumberOfPoints_62(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD41 RID: 113985 RVA: 0x0026F988 File Offset: 0x0026DB88
		public override long GetNumberOfPoints()
		{
			return vtkImageData.vtkImageData_GetNumberOfPoints_62(base.GetCppThis());
		}

		// Token: 0x0601BD42 RID: 113986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetNumberOfScalarComponents_63(HandleRef meta_data);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601BD43 RID: 113987 RVA: 0x0026F9A8 File Offset: 0x0026DBA8
		public static int GetNumberOfScalarComponents(vtkInformation meta_data)
		{
			return vtkImageData.vtkImageData_GetNumberOfScalarComponents_63((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601BD44 RID: 113988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetNumberOfScalarComponents_64(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601BD45 RID: 113989 RVA: 0x0026F9D8 File Offset: 0x0026DBD8
		public int GetNumberOfScalarComponents()
		{
			return vtkImageData.vtkImageData_GetNumberOfScalarComponents_64(base.GetCppThis());
		}

		// Token: 0x0601BD46 RID: 113990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetOrigin_65(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the dataset. The origin is the position in world
		/// coordinates of the point of extent (0,0,0). This point does not have to be
		/// part of the dataset, in other words, the dataset extent does not have to
		/// start at (0,0,0) and the origin can be outside of the dataset bounding
		/// box.
		/// The origin plus spacing determine the position in space of the points.
		/// </summary>
		// Token: 0x0601BD47 RID: 113991 RVA: 0x0026F9F8 File Offset: 0x0026DBF8
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetOrigin_65(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BD48 RID: 113992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetOrigin_66(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the origin of the dataset. The origin is the position in world
		/// coordinates of the point of extent (0,0,0). This point does not have to be
		/// part of the dataset, in other words, the dataset extent does not have to
		/// start at (0,0,0) and the origin can be outside of the dataset bounding
		/// box.
		/// The origin plus spacing determine the position in space of the points.
		/// </summary>
		// Token: 0x0601BD49 RID: 113993 RVA: 0x0026FA40 File Offset: 0x0026DC40
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageData.vtkImageData_GetOrigin_66(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601BD4A RID: 113994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetOrigin_67(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the dataset. The origin is the position in world
		/// coordinates of the point of extent (0,0,0). This point does not have to be
		/// part of the dataset, in other words, the dataset extent does not have to
		/// start at (0,0,0) and the origin can be outside of the dataset bounding
		/// box.
		/// The origin plus spacing determine the position in space of the points.
		/// </summary>
		// Token: 0x0601BD4B RID: 113995 RVA: 0x0026FA52 File Offset: 0x0026DC52
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkImageData.vtkImageData_GetOrigin_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BD4C RID: 113996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetPhysicalToIndexMatrix_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transformation matrix from the physical space to the index space
		/// coordinate system of the dataset. The transform is a 4 by 4 matrix.
		/// </summary>
		// Token: 0x0601BD4D RID: 113997 RVA: 0x0026FA64 File Offset: 0x0026DC64
		public virtual vtkMatrix4x4 GetPhysicalToIndexMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_GetPhysicalToIndexMatrix_68(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0601BD4E RID: 113998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetPoint_69(HandleRef pThis, long ptId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD4F RID: 113999 RVA: 0x0026FAD4 File Offset: 0x0026DCD4
		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetPoint_69(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BD50 RID: 114000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetPoint_70(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD51 RID: 114001 RVA: 0x0026FB1D File Offset: 0x0026DD1D
		public override void GetPoint(long id, IntPtr x)
		{
			vtkImageData.vtkImageData_GetPoint_70(base.GetCppThis(), id, x);
		}

		// Token: 0x0601BD52 RID: 114002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetPointCells_71(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
		/// necessary to override GetCell(vtkIdType) in that class as well since
		/// vtkImageData::GetCell(vtkIdType) will always call
		/// vkImageData::GetCell(int,int,int)
		/// </summary>
		// Token: 0x0601BD53 RID: 114003 RVA: 0x0026FB30 File Offset: 0x0026DD30
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkImageData.vtkImageData_GetPointCells_71(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601BD54 RID: 114004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetPointGradient_72(HandleRef pThis, int i, int j, int k, HandleRef s, IntPtr g);

		/// <summary>
		/// Given structured coordinates (i,j,k) for a point in a structured point
		/// dataset, compute the gradient vector from the scalar data at that point.
		/// The scalars s are the scalars from which the gradient is to be computed.
		/// This method will treat structured point datasets of any dimension.
		/// </summary>
		// Token: 0x0601BD55 RID: 114005 RVA: 0x0026FB60 File Offset: 0x0026DD60
		public virtual void GetPointGradient(int i, int j, int k, vtkDataArray s, IntPtr g)
		{
			vtkImageData.vtkImageData_GetPointGradient_72(base.GetCppThis(), i, j, k, (s == null) ? default(HandleRef) : s.GetCppThis(), g);
		}

		// Token: 0x0601BD56 RID: 114006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageData_GetScalarComponentAsDouble_73(HandleRef pThis, int x, int y, int z, int component);

		/// <summary>
		/// For access to data from wrappers
		/// </summary>
		// Token: 0x0601BD57 RID: 114007 RVA: 0x0026FB98 File Offset: 0x0026DD98
		public virtual double GetScalarComponentAsDouble(int x, int y, int z, int component)
		{
			return vtkImageData.vtkImageData_GetScalarComponentAsDouble_73(base.GetCppThis(), x, y, z, component);
		}

		// Token: 0x0601BD58 RID: 114008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkImageData_GetScalarComponentAsFloat_74(HandleRef pThis, int x, int y, int z, int component);

		/// <summary>
		/// For access to data from wrappers
		/// </summary>
		// Token: 0x0601BD59 RID: 114009 RVA: 0x0026FBBC File Offset: 0x0026DDBC
		public virtual float GetScalarComponentAsFloat(int x, int y, int z, int component)
		{
			return vtkImageData.vtkImageData_GetScalarComponentAsFloat_74(base.GetCppThis(), x, y, z, component);
		}

		// Token: 0x0601BD5A RID: 114010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetScalarIndex_75(HandleRef pThis, IntPtr coordinates);

		/// <summary>
		/// Access the index for the scalar data
		/// </summary>
		// Token: 0x0601BD5B RID: 114011 RVA: 0x0026FBE0 File Offset: 0x0026DDE0
		public virtual long GetScalarIndex(IntPtr coordinates)
		{
			return vtkImageData.vtkImageData_GetScalarIndex_75(base.GetCppThis(), coordinates);
		}

		// Token: 0x0601BD5C RID: 114012
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetScalarIndex_76(HandleRef pThis, int x, int y, int z);

		/// <summary>
		/// Access the index for the scalar data
		/// </summary>
		// Token: 0x0601BD5D RID: 114013 RVA: 0x0026FC00 File Offset: 0x0026DE00
		public virtual long GetScalarIndex(int x, int y, int z)
		{
			return vtkImageData.vtkImageData_GetScalarIndex_76(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601BD5E RID: 114014
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetScalarIndexForExtent_77(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Access the index for the scalar data
		/// </summary>
		// Token: 0x0601BD5F RID: 114015 RVA: 0x0026FC24 File Offset: 0x0026DE24
		public virtual long GetScalarIndexForExtent(IntPtr extent)
		{
			return vtkImageData.vtkImageData_GetScalarIndexForExtent_77(base.GetCppThis(), extent);
		}

		// Token: 0x0601BD60 RID: 114016
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetScalarPointer_78(HandleRef pThis, IntPtr coordinates);

		/// <summary>
		/// Access the native pointer for the scalar data
		/// </summary>
		// Token: 0x0601BD61 RID: 114017 RVA: 0x0026FC44 File Offset: 0x0026DE44
		public virtual IntPtr GetScalarPointer(IntPtr coordinates)
		{
			return vtkImageData.vtkImageData_GetScalarPointer_78(base.GetCppThis(), coordinates);
		}

		// Token: 0x0601BD62 RID: 114018
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetScalarPointer_79(HandleRef pThis, int x, int y, int z);

		/// <summary>
		/// Access the native pointer for the scalar data
		/// </summary>
		// Token: 0x0601BD63 RID: 114019 RVA: 0x0026FC64 File Offset: 0x0026DE64
		public virtual IntPtr GetScalarPointer(int x, int y, int z)
		{
			return vtkImageData.vtkImageData_GetScalarPointer_79(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601BD64 RID: 114020
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetScalarPointer_80(HandleRef pThis);

		/// <summary>
		/// Access the native pointer for the scalar data
		/// </summary>
		// Token: 0x0601BD65 RID: 114021 RVA: 0x0026FC88 File Offset: 0x0026DE88
		public virtual IntPtr GetScalarPointer()
		{
			return vtkImageData.vtkImageData_GetScalarPointer_80(base.GetCppThis());
		}

		// Token: 0x0601BD66 RID: 114022
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetScalarPointerForExtent_81(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Access the native pointer for the scalar data
		/// </summary>
		// Token: 0x0601BD67 RID: 114023 RVA: 0x0026FCA8 File Offset: 0x0026DEA8
		public virtual IntPtr GetScalarPointerForExtent(IntPtr extent)
		{
			return vtkImageData.vtkImageData_GetScalarPointerForExtent_81(base.GetCppThis(), extent);
		}

		// Token: 0x0601BD68 RID: 114024
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetScalarSize_82(HandleRef pThis, HandleRef meta_data);

		/// <summary>
		/// Get the size of the scalar type in bytes.
		/// </summary>
		// Token: 0x0601BD69 RID: 114025 RVA: 0x0026FCC8 File Offset: 0x0026DEC8
		public virtual int GetScalarSize(vtkInformation meta_data)
		{
			return vtkImageData.vtkImageData_GetScalarSize_82(base.GetCppThis(), (meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601BD6A RID: 114026
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetScalarSize_83(HandleRef pThis);

		/// <summary>
		/// Get the size of the scalar type in bytes.
		/// </summary>
		// Token: 0x0601BD6B RID: 114027 RVA: 0x0026FCFC File Offset: 0x0026DEFC
		public virtual int GetScalarSize()
		{
			return vtkImageData.vtkImageData_GetScalarSize_83(base.GetCppThis());
		}

		// Token: 0x0601BD6C RID: 114028
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetScalarType_84(HandleRef meta_data);

		/// <summary>
		/// Convert a plane from physical to a continuous index. The plane is represented as
		/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
		/// </summary>
		// Token: 0x0601BD6D RID: 114029 RVA: 0x0026FD1C File Offset: 0x0026DF1C
		public static int GetScalarType(vtkInformation meta_data)
		{
			return vtkImageData.vtkImageData_GetScalarType_84((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601BD6E RID: 114030
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_GetScalarType_85(HandleRef pThis);

		/// <summary>
		/// Convert a plane from physical to a continuous index. The plane is represented as
		/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
		/// </summary>
		// Token: 0x0601BD6F RID: 114031 RVA: 0x0026FD4C File Offset: 0x0026DF4C
		public int GetScalarType()
		{
			return vtkImageData.vtkImageData_GetScalarType_85(base.GetCppThis());
		}

		// Token: 0x0601BD70 RID: 114032
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetScalarTypeAsString_86(HandleRef pThis);

		/// <summary>
		/// Convert a plane from physical to a continuous index. The plane is represented as
		/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
		/// </summary>
		// Token: 0x0601BD71 RID: 114033 RVA: 0x0026FD6C File Offset: 0x0026DF6C
		public string GetScalarTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageData.vtkImageData_GetScalarTypeAsString_86(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601BD72 RID: 114034
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageData_GetScalarTypeMax_87(HandleRef pThis, HandleRef meta_data);

		/// <summary>
		/// These returns the minimum and maximum values the ScalarType can hold
		/// without overflowing.
		/// </summary>
		// Token: 0x0601BD73 RID: 114035 RVA: 0x0026FDA8 File Offset: 0x0026DFA8
		public virtual double GetScalarTypeMax(vtkInformation meta_data)
		{
			return vtkImageData.vtkImageData_GetScalarTypeMax_87(base.GetCppThis(), (meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601BD74 RID: 114036
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageData_GetScalarTypeMax_88(HandleRef pThis);

		/// <summary>
		/// These returns the minimum and maximum values the ScalarType can hold
		/// without overflowing.
		/// </summary>
		// Token: 0x0601BD75 RID: 114037 RVA: 0x0026FDDC File Offset: 0x0026DFDC
		public virtual double GetScalarTypeMax()
		{
			return vtkImageData.vtkImageData_GetScalarTypeMax_88(base.GetCppThis());
		}

		// Token: 0x0601BD76 RID: 114038
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageData_GetScalarTypeMin_89(HandleRef pThis, HandleRef meta_data);

		/// <summary>
		/// These returns the minimum and maximum values the ScalarType can hold
		/// without overflowing.
		/// </summary>
		// Token: 0x0601BD77 RID: 114039 RVA: 0x0026FDFC File Offset: 0x0026DFFC
		public virtual double GetScalarTypeMin(vtkInformation meta_data)
		{
			return vtkImageData.vtkImageData_GetScalarTypeMin_89(base.GetCppThis(), (meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601BD78 RID: 114040
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageData_GetScalarTypeMin_90(HandleRef pThis);

		/// <summary>
		/// These returns the minimum and maximum values the ScalarType can hold
		/// without overflowing.
		/// </summary>
		// Token: 0x0601BD79 RID: 114041 RVA: 0x0026FE30 File Offset: 0x0026E030
		public virtual double GetScalarTypeMin()
		{
			return vtkImageData.vtkImageData_GetScalarTypeMin_90(base.GetCppThis());
		}

		// Token: 0x0601BD7A RID: 114042
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_GetSpacing_91(HandleRef pThis);

		/// <summary>
		/// Set the spacing (width,height,length) of the cubical cells that
		/// compose the data set.
		/// </summary>
		// Token: 0x0601BD7B RID: 114043 RVA: 0x0026FE50 File Offset: 0x0026E050
		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetSpacing_91(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BD7C RID: 114044
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetSpacing_92(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the spacing (width,height,length) of the cubical cells that
		/// compose the data set.
		/// </summary>
		// Token: 0x0601BD7D RID: 114045 RVA: 0x0026FE98 File Offset: 0x0026E098
		public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageData.vtkImageData_GetSpacing_92(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601BD7E RID: 114046
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetSpacing_93(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the spacing (width,height,length) of the cubical cells that
		/// compose the data set.
		/// </summary>
		// Token: 0x0601BD7F RID: 114047 RVA: 0x0026FEAA File Offset: 0x0026E0AA
		public virtual void GetSpacing(IntPtr _arg)
		{
			vtkImageData.vtkImageData_GetSpacing_93(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BD80 RID: 114048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageData_GetTupleIndex_94(HandleRef pThis, HandleRef array, IntPtr coordinates);

		/// <summary>
		/// Given a data array and a coordinate, return the index of the tuple in the
		/// array corresponding to that coordinate.
		///
		/// This method is analogous to GetArrayPointer(), but it conforms to the API
		/// of vtkGenericDataArray.
		/// </summary>
		// Token: 0x0601BD81 RID: 114049 RVA: 0x0026FEBC File Offset: 0x0026E0BC
		public long GetTupleIndex(vtkDataArray array, IntPtr coordinates)
		{
			return vtkImageData.vtkImageData_GetTupleIndex_94(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), coordinates);
		}

		// Token: 0x0601BD82 RID: 114050
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_GetVoxelGradient_95(HandleRef pThis, int i, int j, int k, HandleRef s, HandleRef g);

		/// <summary>
		/// Given structured coordinates (i,j,k) for a voxel cell, compute the eight
		/// gradient values for the voxel corners. The order in which the gradient
		/// vectors are arranged corresponds to the ordering of the voxel points.
		/// Gradient vector is computed by central differences (except on edges of
		/// volume where forward difference is used). The scalars s are the scalars
		/// from which the gradient is to be computed. This method will treat
		/// only 3D structured point datasets (i.e., volumes).
		/// </summary>
		// Token: 0x0601BD83 RID: 114051 RVA: 0x0026FEF4 File Offset: 0x0026E0F4
		public virtual void GetVoxelGradient(int i, int j, int k, vtkDataArray s, vtkDataArray g)
		{
			vtkImageData.vtkImageData_GetVoxelGradient_95(base.GetCppThis(), i, j, k, (s == null) ? default(HandleRef) : s.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		// Token: 0x0601BD84 RID: 114052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageData_HasAnyBlankCells_96(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the cells,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601BD85 RID: 114053 RVA: 0x0026FF40 File Offset: 0x0026E140
		public override bool HasAnyBlankCells()
		{
			return vtkImageData.vtkImageData_HasAnyBlankCells_96(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BD86 RID: 114054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageData_HasAnyBlankPoints_97(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the points,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601BD87 RID: 114055 RVA: 0x0026FF68 File Offset: 0x0026E168
		public override bool HasAnyBlankPoints()
		{
			return vtkImageData.vtkImageData_HasAnyBlankPoints_97(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BD88 RID: 114056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageData_HasNumberOfScalarComponents_98(HandleRef meta_data);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601BD89 RID: 114057 RVA: 0x0026FF90 File Offset: 0x0026E190
		public static bool HasNumberOfScalarComponents(vtkInformation meta_data)
		{
			return vtkImageData.vtkImageData_HasNumberOfScalarComponents_98((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis()) != 0;
		}

		// Token: 0x0601BD8A RID: 114058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageData_HasScalarType_99(HandleRef meta_data);

		/// <summary>
		/// Convert a plane from physical to a continuous index. The plane is represented as
		/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
		/// </summary>
		// Token: 0x0601BD8B RID: 114059 RVA: 0x0026FFC8 File Offset: 0x0026E1C8
		public static bool HasScalarType(vtkInformation meta_data)
		{
			return vtkImageData.vtkImageData_HasScalarType_99((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis()) != 0;
		}

		// Token: 0x0601BD8C RID: 114060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_Initialize_100(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state.
		/// </summary>
		// Token: 0x0601BD8D RID: 114061 RVA: 0x0026FFFD File Offset: 0x0026E1FD
		public override void Initialize()
		{
			vtkImageData.vtkImageData_Initialize_100(base.GetCppThis());
		}

		// Token: 0x0601BD8E RID: 114062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_IsA_101(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BD8F RID: 114063 RVA: 0x0027000C File Offset: 0x0026E20C
		public override int IsA(string type)
		{
			return vtkImageData.vtkImageData_IsA_101(base.GetCppThis(), type);
		}

		// Token: 0x0601BD90 RID: 114064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageData_IsCellVisible_102(HandleRef pThis, long cellId);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601BD91 RID: 114065 RVA: 0x0027002C File Offset: 0x0026E22C
		public byte IsCellVisible(long cellId)
		{
			return vtkImageData.vtkImageData_IsCellVisible_102(base.GetCppThis(), cellId);
		}

		// Token: 0x0601BD92 RID: 114066
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageData_IsPointVisible_103(HandleRef pThis, long ptId);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601BD93 RID: 114067 RVA: 0x0027004C File Offset: 0x0026E24C
		public byte IsPointVisible(long ptId)
		{
			return vtkImageData.vtkImageData_IsPointVisible_103(base.GetCppThis(), ptId);
		}

		// Token: 0x0601BD94 RID: 114068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageData_IsTypeOf_104([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BD95 RID: 114069 RVA: 0x0027006C File Offset: 0x0026E26C
		public new static int IsTypeOf(string type)
		{
			return vtkImageData.vtkImageData_IsTypeOf_104(type);
		}

		// Token: 0x0601BD96 RID: 114070
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_NewInstance_106(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BD97 RID: 114071 RVA: 0x00270088 File Offset: 0x0026E288
		public new vtkImageData NewInstance()
		{
			vtkImageData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_NewInstance_106(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BD98 RID: 114072
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_PrepareForNewData_107(HandleRef pThis);

		/// <summary>
		/// make the output data ready for new data to be inserted. For most
		/// objects we just call Initialize. But for image data we leave the old
		/// data in case the memory can be reused.
		/// </summary>
		// Token: 0x0601BD99 RID: 114073 RVA: 0x002700E2 File Offset: 0x0026E2E2
		public override void PrepareForNewData()
		{
			vtkImageData.vtkImageData_PrepareForNewData_107(base.GetCppThis());
		}

		// Token: 0x0601BD9A RID: 114074
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageData_SafeDownCast_108(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BD9B RID: 114075 RVA: 0x002700F4 File Offset: 0x0026E2F4
		public new static vtkImageData SafeDownCast(vtkObjectBase o)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageData.vtkImageData_SafeDownCast_108((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0601BD9C RID: 114076
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetAxisUpdateExtent_109(HandleRef pThis, int axis, int min, int max, IntPtr updateExtent, IntPtr axisUpdateExtent);

		/// <summary>
		/// Set / Get the extent on just one axis
		/// </summary>
		// Token: 0x0601BD9D RID: 114077 RVA: 0x00270173 File Offset: 0x0026E373
		public virtual void SetAxisUpdateExtent(int axis, int min, int max, IntPtr updateExtent, IntPtr axisUpdateExtent)
		{
			vtkImageData.vtkImageData_SetAxisUpdateExtent_109(base.GetCppThis(), axis, min, max, updateExtent, axisUpdateExtent);
		}

		// Token: 0x0601BD9E RID: 114078
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetDimensions_110(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Same as SetExtent(0, i-1, 0, j-1, 0, k-1)
		/// </summary>
		// Token: 0x0601BD9F RID: 114079 RVA: 0x00270189 File Offset: 0x0026E389
		public virtual void SetDimensions(int i, int j, int k)
		{
			vtkImageData.vtkImageData_SetDimensions_110(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601BDA0 RID: 114080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetDimensions_111(HandleRef pThis, IntPtr dims);

		/// <summary>
		/// Same as SetExtent(0, dims[0]-1, 0, dims[1]-1, 0, dims[2]-1)
		/// </summary>
		// Token: 0x0601BDA1 RID: 114081 RVA: 0x0027019B File Offset: 0x0026E39B
		public virtual void SetDimensions(IntPtr dims)
		{
			vtkImageData.vtkImageData_SetDimensions_111(base.GetCppThis(), dims);
		}

		// Token: 0x0601BDA2 RID: 114082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetDirectionMatrix_112(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Set/Get the direction transform of the dataset. The direction matrix is
		/// a 3x3 transformation matrix supporting scaling and rotation.
		/// </summary>
		// Token: 0x0601BDA3 RID: 114083 RVA: 0x002701AC File Offset: 0x0026E3AC
		public virtual void SetDirectionMatrix(vtkMatrix3x3 m)
		{
			vtkImageData.vtkImageData_SetDirectionMatrix_112(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x0601BDA4 RID: 114084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetDirectionMatrix_113(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set/Get the direction transform of the dataset. The direction matrix is
		/// a 3x3 transformation matrix supporting scaling and rotation.
		/// </summary>
		// Token: 0x0601BDA5 RID: 114085 RVA: 0x002701DB File Offset: 0x0026E3DB
		public virtual void SetDirectionMatrix(IntPtr elements)
		{
			vtkImageData.vtkImageData_SetDirectionMatrix_113(base.GetCppThis(), elements);
		}

		// Token: 0x0601BDA6 RID: 114086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetDirectionMatrix_114(HandleRef pThis, double e00, double e01, double e02, double e10, double e11, double e12, double e20, double e21, double e22);

		/// <summary>
		/// Set/Get the direction transform of the dataset. The direction matrix is
		/// a 3x3 transformation matrix supporting scaling and rotation.
		/// </summary>
		// Token: 0x0601BDA7 RID: 114087 RVA: 0x002701EC File Offset: 0x0026E3EC
		public virtual void SetDirectionMatrix(double e00, double e01, double e02, double e10, double e11, double e12, double e20, double e21, double e22)
		{
			vtkImageData.vtkImageData_SetDirectionMatrix_114(base.GetCppThis(), e00, e01, e02, e10, e11, e12, e20, e21, e22);
		}

		// Token: 0x0601BDA8 RID: 114088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetExtent_115(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set/Get the extent. On each axis, the extent is defined by the index
		/// of the first point and the index of the last point.  The extent should
		/// be set before the "Scalars" are set or allocated.  The Extent is
		/// stored in the order (X, Y, Z).
		/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
		/// extent of the origin.
		/// The first point (the one with Id=0) is at extent
		/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
		/// data starts at Id=0.
		/// </summary>
		// Token: 0x0601BDA9 RID: 114089 RVA: 0x00270215 File Offset: 0x0026E415
		public virtual void SetExtent(IntPtr extent)
		{
			vtkImageData.vtkImageData_SetExtent_115(base.GetCppThis(), extent);
		}

		// Token: 0x0601BDAA RID: 114090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetExtent_116(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		/// <summary>
		/// Set/Get the extent. On each axis, the extent is defined by the index
		/// of the first point and the index of the last point.  The extent should
		/// be set before the "Scalars" are set or allocated.  The Extent is
		/// stored in the order (X, Y, Z).
		/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
		/// extent of the origin.
		/// The first point (the one with Id=0) is at extent
		/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
		/// data starts at Id=0.
		/// </summary>
		// Token: 0x0601BDAB RID: 114091 RVA: 0x00270225 File Offset: 0x0026E425
		public virtual void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkImageData.vtkImageData_SetExtent_116(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		// Token: 0x0601BDAC RID: 114092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetNumberOfScalarComponents_117(int n, HandleRef meta_data);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601BDAD RID: 114093 RVA: 0x00270240 File Offset: 0x0026E440
		public static void SetNumberOfScalarComponents(int n, vtkInformation meta_data)
		{
			vtkImageData.vtkImageData_SetNumberOfScalarComponents_117(n, (meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601BDAE RID: 114094
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetOrigin_118(HandleRef pThis, double i, double j, double k);

		/// <summary>
		/// Set/Get the origin of the dataset. The origin is the position in world
		/// coordinates of the point of extent (0,0,0). This point does not have to be
		/// part of the dataset, in other words, the dataset extent does not have to
		/// start at (0,0,0) and the origin can be outside of the dataset bounding
		/// box.
		/// The origin plus spacing determine the position in space of the points.
		/// </summary>
		// Token: 0x0601BDAF RID: 114095 RVA: 0x0027026A File Offset: 0x0026E46A
		public virtual void SetOrigin(double i, double j, double k)
		{
			vtkImageData.vtkImageData_SetOrigin_118(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601BDB0 RID: 114096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetOrigin_119(HandleRef pThis, IntPtr ijk);

		/// <summary>
		/// Set/Get the origin of the dataset. The origin is the position in world
		/// coordinates of the point of extent (0,0,0). This point does not have to be
		/// part of the dataset, in other words, the dataset extent does not have to
		/// start at (0,0,0) and the origin can be outside of the dataset bounding
		/// box.
		/// The origin plus spacing determine the position in space of the points.
		/// </summary>
		// Token: 0x0601BDB1 RID: 114097 RVA: 0x0027027C File Offset: 0x0026E47C
		public virtual void SetOrigin(IntPtr ijk)
		{
			vtkImageData.vtkImageData_SetOrigin_119(base.GetCppThis(), ijk);
		}

		// Token: 0x0601BDB2 RID: 114098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetScalarComponentFromDouble_120(HandleRef pThis, int x, int y, int z, int component, double v);

		/// <summary>
		/// For access to data from wrappers
		/// </summary>
		// Token: 0x0601BDB3 RID: 114099 RVA: 0x0027028C File Offset: 0x0026E48C
		public virtual void SetScalarComponentFromDouble(int x, int y, int z, int component, double v)
		{
			vtkImageData.vtkImageData_SetScalarComponentFromDouble_120(base.GetCppThis(), x, y, z, component, v);
		}

		// Token: 0x0601BDB4 RID: 114100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetScalarComponentFromFloat_121(HandleRef pThis, int x, int y, int z, int component, float v);

		/// <summary>
		/// For access to data from wrappers
		/// </summary>
		// Token: 0x0601BDB5 RID: 114101 RVA: 0x002702A2 File Offset: 0x0026E4A2
		public virtual void SetScalarComponentFromFloat(int x, int y, int z, int component, float v)
		{
			vtkImageData.vtkImageData_SetScalarComponentFromFloat_121(base.GetCppThis(), x, y, z, component, v);
		}

		// Token: 0x0601BDB6 RID: 114102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetScalarType_122(int arg0, HandleRef meta_data);

		/// <summary>
		/// Convert a plane from physical to a continuous index. The plane is represented as
		/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
		/// </summary>
		// Token: 0x0601BDB7 RID: 114103 RVA: 0x002702B8 File Offset: 0x0026E4B8
		public static void SetScalarType(int arg0, vtkInformation meta_data)
		{
			vtkImageData.vtkImageData_SetScalarType_122(arg0, (meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601BDB8 RID: 114104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetSpacing_123(HandleRef pThis, double i, double j, double k);

		/// <summary>
		/// Set the spacing (width,height,length) of the cubical cells that
		/// compose the data set.
		/// </summary>
		// Token: 0x0601BDB9 RID: 114105 RVA: 0x002702E2 File Offset: 0x0026E4E2
		public virtual void SetSpacing(double i, double j, double k)
		{
			vtkImageData.vtkImageData_SetSpacing_123(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601BDBA RID: 114106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_SetSpacing_124(HandleRef pThis, IntPtr ijk);

		/// <summary>
		/// Set the spacing (width,height,length) of the cubical cells that
		/// compose the data set.
		/// </summary>
		// Token: 0x0601BDBB RID: 114107 RVA: 0x002702F4 File Offset: 0x0026E4F4
		public virtual void SetSpacing(IntPtr ijk)
		{
			vtkImageData.vtkImageData_SetSpacing_124(base.GetCppThis(), ijk);
		}

		// Token: 0x0601BDBC RID: 114108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_ShallowCopy_125(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601BDBD RID: 114109 RVA: 0x00270304 File Offset: 0x0026E504
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkImageData.vtkImageData_ShallowCopy_125(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601BDBE RID: 114110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformContinuousIndexToPhysicalPoint_126(HandleRef pThis, double i, double j, double k, IntPtr xyz);

		/// <summary>
		/// Convert coordinates from index space (ijk) to physical space (xyz).
		/// </summary>
		// Token: 0x0601BDBF RID: 114111 RVA: 0x00270333 File Offset: 0x0026E533
		public virtual void TransformContinuousIndexToPhysicalPoint(double i, double j, double k, IntPtr xyz)
		{
			vtkImageData.vtkImageData_TransformContinuousIndexToPhysicalPoint_126(base.GetCppThis(), i, j, k, xyz);
		}

		// Token: 0x0601BDC0 RID: 114112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformContinuousIndexToPhysicalPoint_127(HandleRef pThis, IntPtr ijk, IntPtr xyz);

		/// <summary>
		/// Convert coordinates from index space (ijk) to physical space (xyz).
		/// </summary>
		// Token: 0x0601BDC1 RID: 114113 RVA: 0x00270347 File Offset: 0x0026E547
		public virtual void TransformContinuousIndexToPhysicalPoint(IntPtr ijk, IntPtr xyz)
		{
			vtkImageData.vtkImageData_TransformContinuousIndexToPhysicalPoint_127(base.GetCppThis(), ijk, xyz);
		}

		// Token: 0x0601BDC2 RID: 114114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformContinuousIndexToPhysicalPoint_128(double i, double j, double k, IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr xyz);

		/// <summary>
		/// Convert coordinates from index space (ijk) to physical space (xyz).
		/// </summary>
		// Token: 0x0601BDC3 RID: 114115 RVA: 0x00270358 File Offset: 0x0026E558
		public static void TransformContinuousIndexToPhysicalPoint(double i, double j, double k, IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr xyz)
		{
			vtkImageData.vtkImageData_TransformContinuousIndexToPhysicalPoint_128(i, j, k, origin, spacing, direction, xyz);
		}

		// Token: 0x0601BDC4 RID: 114116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformIndexToPhysicalPoint_129(HandleRef pThis, int i, int j, int k, IntPtr xyz);

		/// <summary>
		/// Convert coordinates from index space (ijk) to physical space (xyz).
		/// </summary>
		// Token: 0x0601BDC5 RID: 114117 RVA: 0x0027036B File Offset: 0x0026E56B
		public virtual void TransformIndexToPhysicalPoint(int i, int j, int k, IntPtr xyz)
		{
			vtkImageData.vtkImageData_TransformIndexToPhysicalPoint_129(base.GetCppThis(), i, j, k, xyz);
		}

		// Token: 0x0601BDC6 RID: 114118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformIndexToPhysicalPoint_130(HandleRef pThis, IntPtr ijk, IntPtr xyz);

		/// <summary>
		/// Convert coordinates from index space (ijk) to physical space (xyz).
		/// </summary>
		// Token: 0x0601BDC7 RID: 114119 RVA: 0x0027037F File Offset: 0x0026E57F
		public virtual void TransformIndexToPhysicalPoint(IntPtr ijk, IntPtr xyz)
		{
			vtkImageData.vtkImageData_TransformIndexToPhysicalPoint_130(base.GetCppThis(), ijk, xyz);
		}

		// Token: 0x0601BDC8 RID: 114120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformPhysicalNormalToContinuousIndex_131(HandleRef pThis, IntPtr xyz, IntPtr ijk);

		/// <summary>
		/// Convert normal from physical space (xyz) to index space (ijk).
		/// </summary>
		// Token: 0x0601BDC9 RID: 114121 RVA: 0x00270390 File Offset: 0x0026E590
		public virtual void TransformPhysicalNormalToContinuousIndex(IntPtr xyz, IntPtr ijk)
		{
			vtkImageData.vtkImageData_TransformPhysicalNormalToContinuousIndex_131(base.GetCppThis(), xyz, ijk);
		}

		// Token: 0x0601BDCA RID: 114122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformPhysicalPlaneToContinuousIndex_132(HandleRef pThis, IntPtr pplane, IntPtr iplane);

		/// <summary>
		/// Convert a plane from physical to a continuous index. The plane is represented as
		/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
		/// </summary>
		// Token: 0x0601BDCB RID: 114123 RVA: 0x002703A1 File Offset: 0x0026E5A1
		public virtual void TransformPhysicalPlaneToContinuousIndex(IntPtr pplane, IntPtr iplane)
		{
			vtkImageData.vtkImageData_TransformPhysicalPlaneToContinuousIndex_132(base.GetCppThis(), pplane, iplane);
		}

		// Token: 0x0601BDCC RID: 114124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformPhysicalPointToContinuousIndex_133(HandleRef pThis, double x, double y, double z, IntPtr ijk);

		/// <summary>
		/// Convert coordinates from physical space (xyz) to index space (ijk).
		/// </summary>
		// Token: 0x0601BDCD RID: 114125 RVA: 0x002703B2 File Offset: 0x0026E5B2
		public virtual void TransformPhysicalPointToContinuousIndex(double x, double y, double z, IntPtr ijk)
		{
			vtkImageData.vtkImageData_TransformPhysicalPointToContinuousIndex_133(base.GetCppThis(), x, y, z, ijk);
		}

		// Token: 0x0601BDCE RID: 114126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageData_TransformPhysicalPointToContinuousIndex_134(HandleRef pThis, IntPtr xyz, IntPtr ijk);

		/// <summary>
		/// Convert coordinates from physical space (xyz) to index space (ijk).
		/// </summary>
		// Token: 0x0601BDCF RID: 114127 RVA: 0x002703C6 File Offset: 0x0026E5C6
		public virtual void TransformPhysicalPointToContinuousIndex(IntPtr xyz, IntPtr ijk)
		{
			vtkImageData.vtkImageData_TransformPhysicalPointToContinuousIndex_134(base.GetCppThis(), xyz, ijk);
		}

		/// <summary>
		/// Creates a vtkImageData object from a System.Drawing.Image
		/// </summary>
		/// <param name="img">The System.Drawing.Image to convert</param>
		// Token: 0x0601BDD0 RID: 114128 RVA: 0x002703D8 File Offset: 0x0026E5D8
		public static vtkImageData FromImage(Image img)
		{
			return vtkImageData.FromImage(img, 4);
		}

		/// <summary>
		/// Creates a vtkImageData object from a System.Drawing.Image
		/// </summary>
		/// <param name="img">The System.Drawing.Image to convert</param>
		/// <param name="numberOfScalarComponents">3 for RGB and 4 for RGBA</param>
		// Token: 0x0601BDD1 RID: 114129 RVA: 0x002703F4 File Offset: 0x0026E5F4
		public static vtkImageData FromImage(Image img, int numberOfScalarComponents)
		{
			Bitmap bitmap = new Bitmap(img);
			vtkUnsignedCharArray vtkUnsignedCharArray = vtkUnsignedCharArray.New();
			vtkUnsignedCharArray.SetNumberOfComponents(numberOfScalarComponents);
			vtkUnsignedCharArray.SetNumberOfTuples((long)(img.Width * img.Height));
			byte[] array = new byte[img.Width * img.Height * numberOfScalarComponents];
			int num = 0;
			for (int i = img.Height - 1; i >= 0; i--)
			{
				for (int j = 0; j < img.Width; j++)
				{
					array[num++] = bitmap.GetPixel(j, i).R;
					array[num++] = bitmap.GetPixel(j, i).G;
					array[num++] = bitmap.GetPixel(j, i).B;
					if (numberOfScalarComponents > 3)
					{
						array[num++] = bitmap.GetPixel(j, i).A;
					}
				}
			}
			Marshal.Copy(array, 0, vtkUnsignedCharArray.GetVoidPointer(0L), array.Length);
			vtkImageData vtkImageData = vtkImageData.New();
			vtkImageData.SetDimensions(img.Width, img.Height, 1);
			vtkImageData.GetPointData().SetScalars(vtkUnsignedCharArray);
			return vtkImageData;
		}

		/// <summary>
		/// Returns a System.Drawing.Bitmap created from a plane
		/// of the vtkImageData
		/// </summary>
		// Token: 0x0601BDD2 RID: 114130 RVA: 0x00270548 File Offset: 0x0026E748
		public Bitmap ToBitmap()
		{
			int num = (int)(this.GetBounds()[1] - this.GetBounds()[0]) + 1;
			int num2 = (int)(this.GetBounds()[3] - this.GetBounds()[2]) + 1;
			Bitmap bitmap = new Bitmap(num, num2);
			byte[] array = new byte[num * num2 * this.GetNumberOfScalarComponents()];
			Marshal.Copy(this.GetScalarPointer(), array, 0, num * num2 * this.GetNumberOfScalarComponents());
			int num3 = 0;
			for (int i = num2 - 1; i >= 0; i--)
			{
				for (int j = 0; j < num; j++)
				{
					if (this.GetNumberOfScalarComponents() == 3)
					{
						bitmap.SetPixel(j, i, Color.FromArgb((int)array[num3++], (int)array[num3++], (int)array[num3++]));
					}
					else
					{
						if (this.GetNumberOfScalarComponents() != 4)
						{
							throw new Exception("Invalid Number of Scalar Components");
						}
						bitmap.SetPixel(j, i, Color.FromArgb((int)array[num3++], (int)array[num3++], (int)array[num3++], (int)array[num3++]));
					}
				}
			}
			return bitmap;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DBA RID: 7610
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DBB RID: 7611
		public new static readonly string MRClassNameKey = "class vtkImageData";
	}
}
