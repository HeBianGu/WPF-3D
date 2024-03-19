using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHDFReader
	/// </summary>
	/// <remarks>
	///    VTKHDF format reader.
	///
	/// </remarks>
	// Token: 0x020001E1 RID: 481
	public class vtkHDFReader : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005B6A RID: 23402 RVA: 0x0008493F File Offset: 0x00082B3F
		static vtkHDFReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHDFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHDFReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005B6B RID: 23403 RVA: 0x00084967 File Offset: 0x00082B67
		public vtkHDFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005B6C RID: 23404
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B6D RID: 23405 RVA: 0x00084978 File Offset: 0x00082B78
		public new static vtkHDFReader New()
		{
			vtkHDFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHDFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B6E RID: 23406 RVA: 0x000849CC File Offset: 0x00082BCC
		public vtkHDFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHDFReader.vtkHDFReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005B6F RID: 23407 RVA: 0x00084A10 File Offset: 0x00082C10
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005B70 RID: 23408
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDFReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the file (type) with the given name can be read by this
		/// reader. If the file has a newer version than the reader, we still say
		/// we can read the file type and we fail later, when we try to read the file.
		/// This enables clients (ParaView) to distinguish between failures when we
		/// need to look for another reader and failures when we don't.
		/// </summary>
		// Token: 0x06005B71 RID: 23409 RVA: 0x00084A1C File Offset: 0x00082C1C
		public virtual int CanReadFile(string name)
		{
			return vtkHDFReader.vtkHDFReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x06005B72 RID: 23410
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetCellArrayName_02(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06005B73 RID: 23411 RVA: 0x00084A3C File Offset: 0x00082C3C
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkHDFReader.vtkHDFReader_GetCellArrayName_02(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005B74 RID: 23412
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetCellDataArraySelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06005B75 RID: 23413 RVA: 0x00084A78 File Offset: 0x00082C78
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_GetCellDataArraySelection_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005B76 RID: 23414
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetFieldDataArraySelection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06005B77 RID: 23415 RVA: 0x00084AE8 File Offset: 0x00082CE8
		public virtual vtkDataArraySelection GetFieldDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_GetFieldDataArraySelection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005B78 RID: 23416
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the input file.
		/// </summary>
		// Token: 0x06005B79 RID: 23417 RVA: 0x00084B58 File Offset: 0x00082D58
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHDFReader.vtkHDFReader_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005B7A RID: 23418
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHDFReader_GetHasTransientData_06(HandleRef pThis);

		/// <summary>
		/// Getters and setters for transient data
		/// - HasTransientData is a boolean that flags whether the file has temporal data
		/// - NumberOfSteps is the number of time steps contained in the file
		/// - Step is the time step to be read or last read by the reader
		/// - TimeValue is the value corresponding to the Step property
		/// - TimeRange is an array with the {min, max} values of time for the data
		/// </summary>
		// Token: 0x06005B7B RID: 23419 RVA: 0x00084B94 File Offset: 0x00082D94
		public virtual bool GetHasTransientData()
		{
			return vtkHDFReader.vtkHDFReader_GetHasTransientData_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06005B7C RID: 23420
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHDFReader_GetMaximumLevelsToReadByDefaultForAMR_07(HandleRef pThis);

		/// <summary>
		/// Boolean property determining whether to merge partitions when reading unstructured data.
		///
		/// Merging partitions (true) allows the reader to return either `vtkUnstructuredGrid` or
		/// `vtkPolyData` directly while not merging (false) them returns a `vtkPartitionedDataSet`. It is
		/// advised to set this value to false when using the internal cache (UseCache == true) since the
		/// partitions are what are stored in the cache and merging them before outputting would
		/// effectively double the memory constraints.
		///
		/// Default is true
		/// </summary>
		// Token: 0x06005B7D RID: 23421 RVA: 0x00084BBC File Offset: 0x00082DBC
		public virtual uint GetMaximumLevelsToReadByDefaultForAMR()
		{
			return vtkHDFReader.vtkHDFReader_GetMaximumLevelsToReadByDefaultForAMR_07(base.GetCppThis());
		}

		// Token: 0x06005B7E RID: 23422
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHDFReader_GetMergeParts_08(HandleRef pThis);

		/// <summary>
		/// Boolean property determining whether to merge partitions when reading unstructured data.
		///
		/// Merging partitions (true) allows the reader to return either `vtkUnstructuredGrid` or
		/// `vtkPolyData` directly while not merging (false) them returns a `vtkPartitionedDataSet`. It is
		/// advised to set this value to false when using the internal cache (UseCache == true) since the
		/// partitions are what are stored in the cache and merging them before outputting would
		/// effectively double the memory constraints.
		///
		/// Default is true
		/// </summary>
		// Token: 0x06005B7F RID: 23423 RVA: 0x00084BDC File Offset: 0x00082DDC
		public virtual bool GetMergeParts()
		{
			return vtkHDFReader.vtkHDFReader_GetMergeParts_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06005B80 RID: 23424
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDFReader_GetNumberOfCellArrays_09(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x06005B81 RID: 23425 RVA: 0x00084C04 File Offset: 0x00082E04
		public int GetNumberOfCellArrays()
		{
			return vtkHDFReader.vtkHDFReader_GetNumberOfCellArrays_09(base.GetCppThis());
		}

		// Token: 0x06005B82 RID: 23426
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHDFReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B83 RID: 23427 RVA: 0x00084C24 File Offset: 0x00082E24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHDFReader.vtkHDFReader_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06005B84 RID: 23428
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHDFReader_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B85 RID: 23429 RVA: 0x00084C44 File Offset: 0x00082E44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHDFReader.vtkHDFReader_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06005B86 RID: 23430
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDFReader_GetNumberOfPointArrays_12(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x06005B87 RID: 23431 RVA: 0x00084C60 File Offset: 0x00082E60
		public int GetNumberOfPointArrays()
		{
			return vtkHDFReader.vtkHDFReader_GetNumberOfPointArrays_12(base.GetCppThis());
		}

		// Token: 0x06005B88 RID: 23432
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHDFReader_GetNumberOfSteps_13(HandleRef pThis);

		/// <summary>
		/// Getters and setters for transient data
		/// - HasTransientData is a boolean that flags whether the file has temporal data
		/// - NumberOfSteps is the number of time steps contained in the file
		/// - Step is the time step to be read or last read by the reader
		/// - TimeValue is the value corresponding to the Step property
		/// - TimeRange is an array with the {min, max} values of time for the data
		/// </summary>
		// Token: 0x06005B89 RID: 23433 RVA: 0x00084C80 File Offset: 0x00082E80
		public virtual long GetNumberOfSteps()
		{
			return vtkHDFReader.vtkHDFReader_GetNumberOfSteps_13(base.GetCppThis());
		}

		// Token: 0x06005B8A RID: 23434
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetOutputAsDataSet_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a vtkDataSet pointer.
		/// </summary>
		// Token: 0x06005B8B RID: 23435 RVA: 0x00084CA0 File Offset: 0x00082EA0
		public vtkDataSet GetOutputAsDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_GetOutputAsDataSet_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005B8C RID: 23436
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetOutputAsDataSet_15(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a vtkDataSet pointer.
		/// </summary>
		// Token: 0x06005B8D RID: 23437 RVA: 0x00084D10 File Offset: 0x00082F10
		public vtkDataSet GetOutputAsDataSet(int index)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_GetOutputAsDataSet_15(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005B8E RID: 23438
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetPointArrayName_16(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06005B8F RID: 23439 RVA: 0x00084D80 File Offset: 0x00082F80
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkHDFReader.vtkHDFReader_GetPointArrayName_16(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005B90 RID: 23440
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_GetPointDataArraySelection_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06005B91 RID: 23441 RVA: 0x00084DBC File Offset: 0x00082FBC
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_GetPointDataArraySelection_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005B92 RID: 23442
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHDFReader_GetStep_18(HandleRef pThis);

		/// <summary>
		/// Getters and setters for transient data
		/// - HasTransientData is a boolean that flags whether the file has temporal data
		/// - NumberOfSteps is the number of time steps contained in the file
		/// - Step is the time step to be read or last read by the reader
		/// - TimeValue is the value corresponding to the Step property
		/// - TimeRange is an array with the {min, max} values of time for the data
		/// </summary>
		// Token: 0x06005B93 RID: 23443 RVA: 0x00084E2C File Offset: 0x0008302C
		public virtual long GetStep()
		{
			return vtkHDFReader.vtkHDFReader_GetStep_18(base.GetCppThis());
		}

		// Token: 0x06005B94 RID: 23444
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHDFReader_GetTimeValue_19(HandleRef pThis);

		/// <summary>
		/// Getters and setters for transient data
		/// - HasTransientData is a boolean that flags whether the file has temporal data
		/// - NumberOfSteps is the number of time steps contained in the file
		/// - Step is the time step to be read or last read by the reader
		/// - TimeValue is the value corresponding to the Step property
		/// - TimeRange is an array with the {min, max} values of time for the data
		/// </summary>
		// Token: 0x06005B95 RID: 23445 RVA: 0x00084E4C File Offset: 0x0008304C
		public virtual double GetTimeValue()
		{
			return vtkHDFReader.vtkHDFReader_GetTimeValue_19(base.GetCppThis());
		}

		// Token: 0x06005B96 RID: 23446
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHDFReader_GetUseCache_20(HandleRef pThis);

		/// <summary>
		/// Boolean property determining whether to use the internal cache or not (default is false).
		///
		/// Internal cache is useful when reading transient data to never re-read something that has
		/// already been cached.
		/// </summary>
		// Token: 0x06005B97 RID: 23447 RVA: 0x00084E6C File Offset: 0x0008306C
		public virtual bool GetUseCache()
		{
			return vtkHDFReader.vtkHDFReader_GetUseCache_20(base.GetCppThis()) != 0;
		}

		// Token: 0x06005B98 RID: 23448
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDFReader_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B99 RID: 23449 RVA: 0x00084E94 File Offset: 0x00083094
		public override int IsA(string type)
		{
			return vtkHDFReader.vtkHDFReader_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06005B9A RID: 23450
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDFReader_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B9B RID: 23451 RVA: 0x00084EB4 File Offset: 0x000830B4
		public new static int IsTypeOf(string type)
		{
			return vtkHDFReader.vtkHDFReader_IsTypeOf_22(type);
		}

		// Token: 0x06005B9C RID: 23452
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_MergePartsOff_23(HandleRef pThis);

		/// <summary>
		/// Boolean property determining whether to merge partitions when reading unstructured data.
		///
		/// Merging partitions (true) allows the reader to return either `vtkUnstructuredGrid` or
		/// `vtkPolyData` directly while not merging (false) them returns a `vtkPartitionedDataSet`. It is
		/// advised to set this value to false when using the internal cache (UseCache == true) since the
		/// partitions are what are stored in the cache and merging them before outputting would
		/// effectively double the memory constraints.
		///
		/// Default is true
		/// </summary>
		// Token: 0x06005B9D RID: 23453 RVA: 0x00084ECE File Offset: 0x000830CE
		public virtual void MergePartsOff()
		{
			vtkHDFReader.vtkHDFReader_MergePartsOff_23(base.GetCppThis());
		}

		// Token: 0x06005B9E RID: 23454
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_MergePartsOn_24(HandleRef pThis);

		/// <summary>
		/// Boolean property determining whether to merge partitions when reading unstructured data.
		///
		/// Merging partitions (true) allows the reader to return either `vtkUnstructuredGrid` or
		/// `vtkPolyData` directly while not merging (false) them returns a `vtkPartitionedDataSet`. It is
		/// advised to set this value to false when using the internal cache (UseCache == true) since the
		/// partitions are what are stored in the cache and merging them before outputting would
		/// effectively double the memory constraints.
		///
		/// Default is true
		/// </summary>
		// Token: 0x06005B9F RID: 23455 RVA: 0x00084EDD File Offset: 0x000830DD
		public virtual void MergePartsOn()
		{
			vtkHDFReader.vtkHDFReader_MergePartsOn_24(base.GetCppThis());
		}

		// Token: 0x06005BA0 RID: 23456
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BA1 RID: 23457 RVA: 0x00084EEC File Offset: 0x000830EC
		public new vtkHDFReader NewInstance()
		{
			vtkHDFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHDFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005BA2 RID: 23458
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDFReader_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BA3 RID: 23459 RVA: 0x00084F48 File Offset: 0x00083148
		public new static vtkHDFReader SafeDownCast(vtkObjectBase o)
		{
			vtkHDFReader vtkHDFReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDFReader.vtkHDFReader_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHDFReader = (vtkHDFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHDFReader.Register(null);
				}
			}
			return vtkHDFReader;
		}

		// Token: 0x06005BA4 RID: 23460
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_SetFileName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the input file.
		/// </summary>
		// Token: 0x06005BA5 RID: 23461 RVA: 0x00084FC7 File Offset: 0x000831C7
		public virtual void SetFileName(string _arg)
		{
			vtkHDFReader.vtkHDFReader_SetFileName_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06005BA6 RID: 23462
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_SetMaximumLevelsToReadByDefaultForAMR_29(HandleRef pThis, uint _arg);

		/// <summary>
		/// Boolean property determining whether to merge partitions when reading unstructured data.
		///
		/// Merging partitions (true) allows the reader to return either `vtkUnstructuredGrid` or
		/// `vtkPolyData` directly while not merging (false) them returns a `vtkPartitionedDataSet`. It is
		/// advised to set this value to false when using the internal cache (UseCache == true) since the
		/// partitions are what are stored in the cache and merging them before outputting would
		/// effectively double the memory constraints.
		///
		/// Default is true
		/// </summary>
		// Token: 0x06005BA7 RID: 23463 RVA: 0x00084FD7 File Offset: 0x000831D7
		public virtual void SetMaximumLevelsToReadByDefaultForAMR(uint _arg)
		{
			vtkHDFReader.vtkHDFReader_SetMaximumLevelsToReadByDefaultForAMR_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06005BA8 RID: 23464
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_SetMergeParts_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean property determining whether to merge partitions when reading unstructured data.
		///
		/// Merging partitions (true) allows the reader to return either `vtkUnstructuredGrid` or
		/// `vtkPolyData` directly while not merging (false) them returns a `vtkPartitionedDataSet`. It is
		/// advised to set this value to false when using the internal cache (UseCache == true) since the
		/// partitions are what are stored in the cache and merging them before outputting would
		/// effectively double the memory constraints.
		///
		/// Default is true
		/// </summary>
		// Token: 0x06005BA9 RID: 23465 RVA: 0x00084FE7 File Offset: 0x000831E7
		public virtual void SetMergeParts(bool _arg)
		{
			vtkHDFReader.vtkHDFReader_SetMergeParts_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005BAA RID: 23466
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_SetStep_31(HandleRef pThis, long _arg);

		/// <summary>
		/// Getters and setters for transient data
		/// - HasTransientData is a boolean that flags whether the file has temporal data
		/// - NumberOfSteps is the number of time steps contained in the file
		/// - Step is the time step to be read or last read by the reader
		/// - TimeValue is the value corresponding to the Step property
		/// - TimeRange is an array with the {min, max} values of time for the data
		/// </summary>
		// Token: 0x06005BAB RID: 23467 RVA: 0x00084FFF File Offset: 0x000831FF
		public virtual void SetStep(long _arg)
		{
			vtkHDFReader.vtkHDFReader_SetStep_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06005BAC RID: 23468
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_SetUseCache_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean property determining whether to use the internal cache or not (default is false).
		///
		/// Internal cache is useful when reading transient data to never re-read something that has
		/// already been cached.
		/// </summary>
		// Token: 0x06005BAD RID: 23469 RVA: 0x0008500F File Offset: 0x0008320F
		public virtual void SetUseCache(bool _arg)
		{
			vtkHDFReader.vtkHDFReader_SetUseCache_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005BAE RID: 23470
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_UseCacheOff_33(HandleRef pThis);

		/// <summary>
		/// Boolean property determining whether to use the internal cache or not (default is false).
		///
		/// Internal cache is useful when reading transient data to never re-read something that has
		/// already been cached.
		/// </summary>
		// Token: 0x06005BAF RID: 23471 RVA: 0x00085027 File Offset: 0x00083227
		public virtual void UseCacheOff()
		{
			vtkHDFReader.vtkHDFReader_UseCacheOff_33(base.GetCppThis());
		}

		// Token: 0x06005BB0 RID: 23472
		[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHDFReader_UseCacheOn_34(HandleRef pThis);

		/// <summary>
		/// Boolean property determining whether to use the internal cache or not (default is false).
		///
		/// Internal cache is useful when reading transient data to never re-read something that has
		/// already been cached.
		/// </summary>
		// Token: 0x06005BB1 RID: 23473 RVA: 0x00085036 File Offset: 0x00083236
		public virtual void UseCacheOn()
		{
			vtkHDFReader.vtkHDFReader_UseCacheOn_34(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400088B RID: 2187
		public new const string MRFullTypeName = "Kitware.VTK.vtkHDFReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400088C RID: 2188
		public new static readonly string MRClassNameKey = "class vtkHDFReader";
	}
}
