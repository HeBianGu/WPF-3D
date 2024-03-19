using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericDataObjectReader
	/// </summary>
	/// <remarks>
	///    class to read any type of vtk data object
	///
	/// vtkGenericDataObjectReader is a class that provides instance variables and methods
	/// to read any type of data object in Visualization Toolkit (vtk) format.  The
	/// output type of this class will vary depending upon the type of data
	/// file. Convenience methods are provided to return the data as a particular
	/// type. (See text for format description details).
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataReader vtkGraphReader vtkPolyDataReader vtkRectilinearGridReader
	/// vtkStructuredPointsReader vtkStructuredGridReader vtkTableReader
	/// vtkTreeReader vtkUnstructuredGridReader
	/// </seealso>
	// Token: 0x02000708 RID: 1800
	public class vtkGenericDataObjectReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012EC0 RID: 77504 RVA: 0x001AA837 File Offset: 0x001A8A37
		static vtkGenericDataObjectReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericDataObjectReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataObjectReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012EC1 RID: 77505 RVA: 0x001AA85F File Offset: 0x001A8A5F
		public vtkGenericDataObjectReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012EC2 RID: 77506
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EC3 RID: 77507 RVA: 0x001AA870 File Offset: 0x001A8A70
		public new static vtkGenericDataObjectReader New()
		{
			vtkGenericDataObjectReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EC4 RID: 77508 RVA: 0x001AA8C4 File Offset: 0x001A8AC4
		public vtkGenericDataObjectReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericDataObjectReader.vtkGenericDataObjectReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012EC5 RID: 77509 RVA: 0x001AA908 File Offset: 0x001A8B08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012EC6 RID: 77510
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetGraphOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EC7 RID: 77511 RVA: 0x001AA914 File Offset: 0x001A8B14
		public vtkGraph GetGraphOutput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetGraphOutput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x06012EC8 RID: 77512
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetMoleculeOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EC9 RID: 77513 RVA: 0x001AA984 File Offset: 0x001A8B84
		public vtkMolecule GetMoleculeOutput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetMoleculeOutput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x06012ECA RID: 77514
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataObjectReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ECB RID: 77515 RVA: 0x001AA9F4 File Offset: 0x001A8BF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012ECC RID: 77516
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataObjectReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ECD RID: 77517 RVA: 0x001AAA14 File Offset: 0x001A8C14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012ECE RID: 77518
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this filter
		/// </summary>
		// Token: 0x06012ECF RID: 77519 RVA: 0x001AAA30 File Offset: 0x001A8C30
		public vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012ED0 RID: 77520
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetOutput_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this filter
		/// </summary>
		// Token: 0x06012ED1 RID: 77521 RVA: 0x001AAAA0 File Offset: 0x001A8CA0
		public vtkDataObject GetOutput(int idx)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetOutput_06(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012ED2 RID: 77522
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetPolyDataOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012ED3 RID: 77523 RVA: 0x001AAB10 File Offset: 0x001A8D10
		public vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetPolyDataOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012ED4 RID: 77524
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetRectilinearGridOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012ED5 RID: 77525 RVA: 0x001AAB80 File Offset: 0x001A8D80
		public vtkRectilinearGrid GetRectilinearGridOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetRectilinearGridOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012ED6 RID: 77526
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetStructuredGridOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012ED7 RID: 77527 RVA: 0x001AABF0 File Offset: 0x001A8DF0
		public vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetStructuredGridOutput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012ED8 RID: 77528
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetStructuredPointsOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012ED9 RID: 77529 RVA: 0x001AAC60 File Offset: 0x001A8E60
		public vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetStructuredPointsOutput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012EDA RID: 77530
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetTableOutput_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EDB RID: 77531 RVA: 0x001AACD0 File Offset: 0x001A8ED0
		public vtkTable GetTableOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetTableOutput_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06012EDC RID: 77532
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetTreeOutput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EDD RID: 77533 RVA: 0x001AAD40 File Offset: 0x001A8F40
		public vtkTree GetTreeOutput()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetTreeOutput_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x06012EDE RID: 77534
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_GetUnstructuredGridOutput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as various concrete types. This method is typically used
		/// when you know exactly what type of data is being read.  Otherwise, use
		/// the general GetOutput() method. If the wrong type is used nullptr is
		/// returned.  (You must also set the filename of the object prior to
		/// getting the output.)
		/// </summary>
		// Token: 0x06012EDF RID: 77535 RVA: 0x001AADB0 File Offset: 0x001A8FB0
		public vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_GetUnstructuredGridOutput_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012EE0 RID: 77536
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataObjectReader_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EE1 RID: 77537 RVA: 0x001AAE20 File Offset: 0x001A9020
		public override int IsA(string type)
		{
			return vtkGenericDataObjectReader.vtkGenericDataObjectReader_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06012EE2 RID: 77538
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataObjectReader_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EE3 RID: 77539 RVA: 0x001AAE40 File Offset: 0x001A9040
		public new static int IsTypeOf(string type)
		{
			return vtkGenericDataObjectReader.vtkGenericDataObjectReader_IsTypeOf_15(type);
		}

		// Token: 0x06012EE4 RID: 77540
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EE5 RID: 77541 RVA: 0x001AAE5C File Offset: 0x001A905C
		public new vtkGenericDataObjectReader NewInstance()
		{
			vtkGenericDataObjectReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012EE6 RID: 77542
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataObjectReader_ReadMeshSimple_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06012EE7 RID: 77543 RVA: 0x001AAEB8 File Offset: 0x001A90B8
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkGenericDataObjectReader.vtkGenericDataObjectReader_ReadMeshSimple_18(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06012EE8 RID: 77544
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataObjectReader_ReadMetaDataSimple_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef metadata);

		/// <summary>
		/// Read metadata from file.
		/// </summary>
		// Token: 0x06012EE9 RID: 77545 RVA: 0x001AAEF0 File Offset: 0x001A90F0
		public override int ReadMetaDataSimple(string fname, vtkInformation metadata)
		{
			return vtkGenericDataObjectReader.vtkGenericDataObjectReader_ReadMetaDataSimple_19(base.GetCppThis(), fname, (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06012EEA RID: 77546
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataObjectReader_ReadOutputType_20(HandleRef pThis);

		/// <summary>
		/// This method can be used to find out the type of output expected without
		/// needing to read the whole file.
		/// </summary>
		// Token: 0x06012EEB RID: 77547 RVA: 0x001AAF28 File Offset: 0x001A9128
		public virtual int ReadOutputType()
		{
			return vtkGenericDataObjectReader.vtkGenericDataObjectReader_ReadOutputType_20(base.GetCppThis());
		}

		// Token: 0x06012EEC RID: 77548
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectReader_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EED RID: 77549 RVA: 0x001AAF48 File Offset: 0x001A9148
		public new static vtkGenericDataObjectReader SafeDownCast(vtkObjectBase o)
		{
			vtkGenericDataObjectReader vtkGenericDataObjectReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectReader.vtkGenericDataObjectReader_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataObjectReader = (vtkGenericDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataObjectReader.Register(null);
				}
			}
			return vtkGenericDataObjectReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015DC RID: 5596
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataObjectReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015DD RID: 5597
		public new static readonly string MRClassNameKey = "class vtkGenericDataObjectReader";
	}
}
