using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetReader
	/// </summary>
	/// <remarks>
	///    class to read any type of vtk dataset
	///
	/// vtkDataSetReader is a class that provides instance variables and methods
	/// to read any type of dataset in Visualization Toolkit (vtk) format.  The
	/// output type of this class will vary depending upon the type of data
	/// file. Convenience methods are provided to keep the data as a particular
	/// type. (See text for format description details).
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataReader vtkPolyDataReader vtkRectilinearGridReader
	/// vtkStructuredPointsReader vtkStructuredGridReader vtkUnstructuredGridReader
	/// </seealso>
	// Token: 0x02000707 RID: 1799
	public class vtkDataSetReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012E9A RID: 77466 RVA: 0x001AA267 File Offset: 0x001A8467
		static vtkDataSetReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012E9B RID: 77467 RVA: 0x001AA28F File Offset: 0x001A848F
		public vtkDataSetReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012E9C RID: 77468
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E9D RID: 77469 RVA: 0x001AA2A0 File Offset: 0x001A84A0
		public new static vtkDataSetReader New()
		{
			vtkDataSetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E9E RID: 77470 RVA: 0x001AA2F4 File Offset: 0x001A84F4
		public vtkDataSetReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetReader.vtkDataSetReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012E9F RID: 77471 RVA: 0x001AA338 File Offset: 0x001A8538
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012EA0 RID: 77472
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EA1 RID: 77473 RVA: 0x001AA344 File Offset: 0x001A8544
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetReader.vtkDataSetReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012EA2 RID: 77474
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EA3 RID: 77475 RVA: 0x001AA364 File Offset: 0x001A8564
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetReader.vtkDataSetReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012EA4 RID: 77476
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this filter
		/// </summary>
		// Token: 0x06012EA5 RID: 77477 RVA: 0x001AA380 File Offset: 0x001A8580
		public vtkDataSet GetOutput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012EA6 RID: 77478
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this filter
		/// </summary>
		// Token: 0x06012EA7 RID: 77479 RVA: 0x001AA3F0 File Offset: 0x001A85F0
		public vtkDataSet GetOutput(int idx)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012EA8 RID: 77480
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_GetPolyDataOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EA9 RID: 77481 RVA: 0x001AA460 File Offset: 0x001A8660
		public vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_GetPolyDataOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06012EAA RID: 77482
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_GetRectilinearGridOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EAB RID: 77483 RVA: 0x001AA4D0 File Offset: 0x001A86D0
		public vtkRectilinearGrid GetRectilinearGridOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_GetRectilinearGridOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06012EAC RID: 77484
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_GetStructuredGridOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EAD RID: 77485 RVA: 0x001AA540 File Offset: 0x001A8740
		public vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_GetStructuredGridOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x06012EAE RID: 77486
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_GetStructuredPointsOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EAF RID: 77487 RVA: 0x001AA5B0 File Offset: 0x001A87B0
		public vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_GetStructuredPointsOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x06012EB0 RID: 77488
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_GetUnstructuredGridOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EB1 RID: 77489 RVA: 0x001AA620 File Offset: 0x001A8820
		public vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_GetUnstructuredGridOutput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06012EB2 RID: 77490
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EB3 RID: 77491 RVA: 0x001AA690 File Offset: 0x001A8890
		public override int IsA(string type)
		{
			return vtkDataSetReader.vtkDataSetReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06012EB4 RID: 77492
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EB5 RID: 77493 RVA: 0x001AA6B0 File Offset: 0x001A88B0
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetReader.vtkDataSetReader_IsTypeOf_11(type);
		}

		// Token: 0x06012EB6 RID: 77494
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EB7 RID: 77495 RVA: 0x001AA6CC File Offset: 0x001A88CC
		public new vtkDataSetReader NewInstance()
		{
			vtkDataSetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012EB8 RID: 77496
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetReader_ReadMeshSimple_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06012EB9 RID: 77497 RVA: 0x001AA728 File Offset: 0x001A8928
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkDataSetReader.vtkDataSetReader_ReadMeshSimple_14(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06012EBA RID: 77498
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetReader_ReadMetaDataSimple_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef metadata);

		/// <summary>
		/// Read metadata from file.
		/// </summary>
		// Token: 0x06012EBB RID: 77499 RVA: 0x001AA760 File Offset: 0x001A8960
		public override int ReadMetaDataSimple(string fname, vtkInformation metadata)
		{
			return vtkDataSetReader.vtkDataSetReader_ReadMetaDataSimple_15(base.GetCppThis(), fname, (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06012EBC RID: 77500
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetReader_ReadOutputType_16(HandleRef pThis);

		/// <summary>
		/// This method can be used to find out the type of output expected without
		/// needing to read the whole file.
		/// </summary>
		// Token: 0x06012EBD RID: 77501 RVA: 0x001AA798 File Offset: 0x001A8998
		public virtual int ReadOutputType()
		{
			return vtkDataSetReader.vtkDataSetReader_ReadOutputType_16(base.GetCppThis());
		}

		// Token: 0x06012EBE RID: 77502
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetReader_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EBF RID: 77503 RVA: 0x001AA7B8 File Offset: 0x001A89B8
		public new static vtkDataSetReader SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetReader vtkDataSetReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetReader.vtkDataSetReader_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetReader = (vtkDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetReader.Register(null);
				}
			}
			return vtkDataSetReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015DA RID: 5594
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015DB RID: 5595
		public new static readonly string MRClassNameKey = "class vtkDataSetReader";
	}
}
