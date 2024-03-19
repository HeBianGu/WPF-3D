using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeFilter
	/// </summary>
	/// <remarks>
	///    extract separate components of data from different datasets
	///
	/// vtkMergeFilter is a filter that extracts separate components of data from
	/// different datasets and merges them into a single dataset. The output from
	/// this filter is of the same type as the input (i.e., vtkDataSet.) It treats
	/// both cell and point data set attributes.
	/// </remarks>
	// Token: 0x02000980 RID: 2432
	public class vtkMergeFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601952B RID: 103723 RVA: 0x00234725 File Offset: 0x00232925
		static vtkMergeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601952C RID: 103724 RVA: 0x0023474D File Offset: 0x0023294D
		public vtkMergeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601952D RID: 103725
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601952E RID: 103726 RVA: 0x0023475C File Offset: 0x0023295C
		public new static vtkMergeFilter New()
		{
			vtkMergeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601952F RID: 103727 RVA: 0x002347B0 File Offset: 0x002329B0
		public vtkMergeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeFilter.vtkMergeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019530 RID: 103728 RVA: 0x002347F4 File Offset: 0x002329F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019531 RID: 103729
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_AddField_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef input);

		/// <summary>
		/// Set the object from which to extract a field and the name
		/// of the field. Note that this does not create pipeline
		/// connectivity.
		/// </summary>
		// Token: 0x06019532 RID: 103730 RVA: 0x00234800 File Offset: 0x00232A00
		public void AddField(string name, vtkDataSet input)
		{
			vtkMergeFilter.vtkMergeFilter_AddField_01(base.GetCppThis(), name, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06019533 RID: 103731
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_GetGeometry_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify object from which to extract geometry information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetGeometryConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019534 RID: 103732 RVA: 0x00234830 File Offset: 0x00232A30
		public vtkDataSet GetGeometry()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_GetGeometry_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019535 RID: 103733
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_GetNormals_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the object from which to extract normal information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetNormalsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019536 RID: 103734 RVA: 0x002348A0 File Offset: 0x00232AA0
		public vtkDataSet GetNormals()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_GetNormals_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019537 RID: 103735
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019538 RID: 103736 RVA: 0x00234910 File Offset: 0x00232B10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeFilter.vtkMergeFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06019539 RID: 103737
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601953A RID: 103738 RVA: 0x00234930 File Offset: 0x00232B30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeFilter.vtkMergeFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601953B RID: 103739
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_GetScalars_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify object from which to extract scalar information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetScalarConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0601953C RID: 103740 RVA: 0x0023494C File Offset: 0x00232B4C
		public vtkDataSet GetScalars()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_GetScalars_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601953D RID: 103741
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_GetTCoords_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the object from which to extract texture coordinates
		/// information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetTCoordsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0601953E RID: 103742 RVA: 0x002349BC File Offset: 0x00232BBC
		public vtkDataSet GetTCoords()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_GetTCoords_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601953F RID: 103743
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_GetTensors_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the object from which to extract tensor data.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetTensorsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019540 RID: 103744 RVA: 0x00234A2C File Offset: 0x00232C2C
		public vtkDataSet GetTensors()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_GetTensors_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019541 RID: 103745
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_GetVectors_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the object from which to extract vector information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetVectorsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019542 RID: 103746 RVA: 0x00234A9C File Offset: 0x00232C9C
		public vtkDataSet GetVectors()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_GetVectors_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019543 RID: 103747
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeFilter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019544 RID: 103748 RVA: 0x00234B0C File Offset: 0x00232D0C
		public override int IsA(string type)
		{
			return vtkMergeFilter.vtkMergeFilter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06019545 RID: 103749
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeFilter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019546 RID: 103750 RVA: 0x00234B2C File Offset: 0x00232D2C
		public new static int IsTypeOf(string type)
		{
			return vtkMergeFilter.vtkMergeFilter_IsTypeOf_11(type);
		}

		// Token: 0x06019547 RID: 103751
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019548 RID: 103752 RVA: 0x00234B48 File Offset: 0x00232D48
		public new vtkMergeFilter NewInstance()
		{
			vtkMergeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019549 RID: 103753
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601954A RID: 103754 RVA: 0x00234BA4 File Offset: 0x00232DA4
		public new static vtkMergeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMergeFilter vtkMergeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFilter.vtkMergeFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeFilter = (vtkMergeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeFilter.Register(null);
				}
			}
			return vtkMergeFilter;
		}

		// Token: 0x0601954B RID: 103755
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetGeometryConnection_15(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify object from which to extract geometry information.
		/// Equivalent to SetInputConnection(0, algOutput)
		/// </summary>
		// Token: 0x0601954C RID: 103756 RVA: 0x00234C24 File Offset: 0x00232E24
		public void SetGeometryConnection(vtkAlgorithmOutput algOutput)
		{
			vtkMergeFilter.vtkMergeFilter_SetGeometryConnection_15(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0601954D RID: 103757
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetGeometryInputData_16(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Specify object from which to extract geometry information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetGeometryConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0601954E RID: 103758 RVA: 0x00234C54 File Offset: 0x00232E54
		public void SetGeometryInputData(vtkDataSet input)
		{
			vtkMergeFilter.vtkMergeFilter_SetGeometryInputData_16(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601954F RID: 103759
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetNormalsConnection_17(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set  the connection from which to extract normal information.
		/// Equivalent to SetInputConnection(3, algOutput)
		/// </summary>
		// Token: 0x06019550 RID: 103760 RVA: 0x00234C84 File Offset: 0x00232E84
		public void SetNormalsConnection(vtkAlgorithmOutput algOutput)
		{
			vtkMergeFilter.vtkMergeFilter_SetNormalsConnection_17(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019551 RID: 103761
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetNormalsData_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the object from which to extract normal information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetNormalsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019552 RID: 103762 RVA: 0x00234CB4 File Offset: 0x00232EB4
		public void SetNormalsData(vtkDataSet arg0)
		{
			vtkMergeFilter.vtkMergeFilter_SetNormalsData_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019553 RID: 103763
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetScalarsConnection_19(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify object from which to extract scalar information.
		/// Equivalent to SetInputConnection(1, algOutput)
		/// </summary>
		// Token: 0x06019554 RID: 103764 RVA: 0x00234CE4 File Offset: 0x00232EE4
		public void SetScalarsConnection(vtkAlgorithmOutput algOutput)
		{
			vtkMergeFilter.vtkMergeFilter_SetScalarsConnection_19(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019555 RID: 103765
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetScalarsData_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify object from which to extract scalar information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetScalarConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019556 RID: 103766 RVA: 0x00234D14 File Offset: 0x00232F14
		public void SetScalarsData(vtkDataSet arg0)
		{
			vtkMergeFilter.vtkMergeFilter_SetScalarsData_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019557 RID: 103767
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetTCoordsConnection_21(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set the connection from which to extract texture coordinates
		/// information.
		/// Equivalent to SetInputConnection(4, algOutput)
		/// </summary>
		// Token: 0x06019558 RID: 103768 RVA: 0x00234D44 File Offset: 0x00232F44
		public void SetTCoordsConnection(vtkAlgorithmOutput algOutput)
		{
			vtkMergeFilter.vtkMergeFilter_SetTCoordsConnection_21(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019559 RID: 103769
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetTCoordsData_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the object from which to extract texture coordinates
		/// information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetTCoordsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0601955A RID: 103770 RVA: 0x00234D74 File Offset: 0x00232F74
		public void SetTCoordsData(vtkDataSet arg0)
		{
			vtkMergeFilter.vtkMergeFilter_SetTCoordsData_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601955B RID: 103771
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetTensorsConnection_23(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set the connection from which to extract tensor data.
		/// Equivalent to SetInputConnection(5, algOutput)
		/// </summary>
		// Token: 0x0601955C RID: 103772 RVA: 0x00234DA4 File Offset: 0x00232FA4
		public void SetTensorsConnection(vtkAlgorithmOutput algOutput)
		{
			vtkMergeFilter.vtkMergeFilter_SetTensorsConnection_23(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0601955D RID: 103773
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetTensorsData_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the object from which to extract tensor data.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetTensorsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0601955E RID: 103774 RVA: 0x00234DD4 File Offset: 0x00232FD4
		public void SetTensorsData(vtkDataSet arg0)
		{
			vtkMergeFilter.vtkMergeFilter_SetTensorsData_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601955F RID: 103775
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetVectorsConnection_25(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set the connection from which to extract vector information.
		/// Equivalent to SetInputConnection(2, algOutput)
		/// </summary>
		// Token: 0x06019560 RID: 103776 RVA: 0x00234E04 File Offset: 0x00233004
		public void SetVectorsConnection(vtkAlgorithmOutput algOutput)
		{
			vtkMergeFilter.vtkMergeFilter_SetVectorsConnection_25(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019561 RID: 103777
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFilter_SetVectorsData_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the object from which to extract vector information.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetVectorsConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x06019562 RID: 103778 RVA: 0x00234E34 File Offset: 0x00233034
		public void SetVectorsData(vtkDataSet arg0)
		{
			vtkMergeFilter.vtkMergeFilter_SetVectorsData_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BBE RID: 7102
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BBF RID: 7103
		public new static readonly string MRClassNameKey = "class vtkMergeFilter";
	}
}
