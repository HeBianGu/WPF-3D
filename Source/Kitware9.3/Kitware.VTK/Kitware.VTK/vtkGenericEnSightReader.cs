using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericEnSightReader
	/// </summary>
	/// <remarks>
	///    class to read any type of EnSight files
	///
	/// The class vtkGenericEnSightReader allows the user to read an EnSight data
	/// set without a priori knowledge of what type of EnSight data set it is.
	/// </remarks>
	// Token: 0x020001BE RID: 446
	public class vtkGenericEnSightReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060057D6 RID: 22486 RVA: 0x0007E9E1 File Offset: 0x0007CBE1
		static vtkGenericEnSightReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericEnSightReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericEnSightReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060057D7 RID: 22487 RVA: 0x0007EA09 File Offset: 0x0007CC09
		public vtkGenericEnSightReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060057D8 RID: 22488
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060057D9 RID: 22489 RVA: 0x0007EA18 File Offset: 0x0007CC18
		public new static vtkGenericEnSightReader New()
		{
			vtkGenericEnSightReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060057DA RID: 22490 RVA: 0x0007EA6C File Offset: 0x0007CC6C
		public vtkGenericEnSightReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericEnSightReader.vtkGenericEnSightReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060057DB RID: 22491 RVA: 0x0007EAB0 File Offset: 0x0007CCB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060057DC RID: 22492
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string casefilename);

		/// <summary>
		/// Returns IsEnSightFile() by default, but can be overridden
		/// </summary>
		// Token: 0x060057DD RID: 22493 RVA: 0x0007EABC File Offset: 0x0007CCBC
		public virtual int CanReadFile(string casefilename)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_CanReadFile_01(base.GetCppThis(), casefilename);
		}

		// Token: 0x060057DE RID: 22494
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_DetermineEnSightVersion_02(HandleRef pThis, int quiet);

		/// <summary>
		/// Reads the FORMAT part of the case file to determine whether this is an
		/// EnSight6 or EnSightGold data set.  Returns an identifier listed in
		/// the FileTypes enum or -1 if an error occurred or the file could not
		/// be identified as any EnSight type.
		/// </summary>
		// Token: 0x060057DF RID: 22495 RVA: 0x0007EADC File Offset: 0x0007CCDC
		public int DetermineEnSightVersion(int quiet)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_DetermineEnSightVersion_02(base.GetCppThis(), quiet);
		}

		// Token: 0x060057E0 RID: 22496
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGenericEnSightReader_GetApplyTetrahedralize_03(HandleRef pThis);

		/// <summary>
		/// Get/set to ApplyTetrahedralize.
		/// It's used to apply a Tetrahedralize filter to prevent potential non manifold triangles
		/// produced by the ensight solver.
		/// </summary>
		// Token: 0x060057E1 RID: 22497 RVA: 0x0007EAFC File Offset: 0x0007CCFC
		public virtual bool GetApplyTetrahedralize()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetApplyTetrahedralize_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060057E2 RID: 22498
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetByteOrder_04(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x060057E3 RID: 22499 RVA: 0x0007EB24 File Offset: 0x0007CD24
		public virtual int GetByteOrder()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetByteOrder_04(base.GetCppThis());
		}

		// Token: 0x060057E4 RID: 22500
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetByteOrderAsString_05(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x060057E5 RID: 22501 RVA: 0x0007EB44 File Offset: 0x0007CD44
		public string GetByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetByteOrderAsString_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057E6 RID: 22502
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetCaseFileName_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the Case file name.
		/// </summary>
		// Token: 0x060057E7 RID: 22503 RVA: 0x0007EB80 File Offset: 0x0007CD80
		public virtual string GetCaseFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetCaseFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057E8 RID: 22504
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetCellArrayName_07(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x060057E9 RID: 22505 RVA: 0x0007EBBC File Offset: 0x0007CDBC
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetCellArrayName_07(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057EA RID: 22506
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetCellArrayStatus_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x060057EB RID: 22507 RVA: 0x0007EBF8 File Offset: 0x0007CDF8
		public int GetCellArrayStatus(string name)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetCellArrayStatus_08(base.GetCppThis(), name);
		}

		// Token: 0x060057EC RID: 22508
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetCellDataArraySelection_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x060057ED RID: 22509 RVA: 0x0007EC18 File Offset: 0x0007CE18
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetCellDataArraySelection_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060057EE RID: 22510
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetComplexDescription_10(HandleRef pThis, int n);

		/// <summary>
		/// Get the nth description for a complex variable.
		/// </summary>
		// Token: 0x060057EF RID: 22511 RVA: 0x0007EC88 File Offset: 0x0007CE88
		public string GetComplexDescription(int n)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetComplexDescription_10(base.GetCppThis(), n));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057F0 RID: 22512
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetComplexVariableType_11(HandleRef pThis, int n);

		/// <summary>
		/// Get the variable type of variable n.
		/// </summary>
		// Token: 0x060057F1 RID: 22513 RVA: 0x0007ECC4 File Offset: 0x0007CEC4
		public int GetComplexVariableType(int n)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetComplexVariableType_11(base.GetCppThis(), n);
		}

		// Token: 0x060057F2 RID: 22514
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetDescription_12(HandleRef pThis, int n);

		/// <summary>
		/// Get the nth description for a non-complex variable.
		/// </summary>
		// Token: 0x060057F3 RID: 22515 RVA: 0x0007ECE4 File Offset: 0x0007CEE4
		public string GetDescription(int n)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetDescription_12(base.GetCppThis(), n));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057F4 RID: 22516
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetDescription_13(HandleRef pThis, int n, int type);

		/// <summary>
		/// Get the nth description of a particular variable type.  Returns nullptr if no
		/// variable of this type exists in this data set.
		/// SCALAR_PER_NODE = 0; VECTOR_PER_NODE = 1;
		/// TENSOR_SYMM_PER_NODE = 2; SCALAR_PER_ELEMENT = 3;
		/// VECTOR_PER_ELEMENT = 4; TENSOR_SYMM_PER_ELEMENT = 5;
		/// SCALAR_PER_MEASURED_NODE = 6; VECTOR_PER_MEASURED_NODE = 7;
		/// COMPLEX_SCALAR_PER_NODE = 8; COMPLEX_VECTOR_PER_NODE 9;
		/// COMPLEX_SCALAR_PER_ELEMENT = 10; COMPLEX_VECTOR_PER_ELEMENT = 11;
		/// TENSOR_ASYM_PER_NODE = 12; TENSOR_ASYM_PER_ELEMENT = 13;
		/// </summary>
		// Token: 0x060057F5 RID: 22517 RVA: 0x0007ED20 File Offset: 0x0007CF20
		public string GetDescription(int n, int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetDescription_13(base.GetCppThis(), n, type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057F6 RID: 22518
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetEnSightVersion_14(HandleRef pThis);

		/// <summary>
		/// Get the EnSight file version being read.
		/// </summary>
		// Token: 0x060057F7 RID: 22519 RVA: 0x0007ED5C File Offset: 0x0007CF5C
		public virtual int GetEnSightVersion()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetEnSightVersion_14(base.GetCppThis());
		}

		// Token: 0x060057F8 RID: 22520
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetFilePath_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the file path.
		/// </summary>
		// Token: 0x060057F9 RID: 22521 RVA: 0x0007ED7C File Offset: 0x0007CF7C
		public virtual string GetFilePath()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetFilePath_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057FA RID: 22522
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetGeometryFileName_16(HandleRef pThis);

		/// <summary>
		/// Get the Geometry file name. Made public to allow access from
		/// apps requiring detailed info about the Data contents
		/// </summary>
		// Token: 0x060057FB RID: 22523 RVA: 0x0007EDB8 File Offset: 0x0007CFB8
		public virtual string GetGeometryFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetGeometryFileName_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060057FC RID: 22524
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGenericEnSightReader_GetMaximumTimeValue_17(HandleRef pThis);

		/// <summary>
		/// Get the minimum or maximum time value for this data set.
		/// </summary>
		// Token: 0x060057FD RID: 22525 RVA: 0x0007EDF4 File Offset: 0x0007CFF4
		public virtual float GetMaximumTimeValue()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetMaximumTimeValue_17(base.GetCppThis());
		}

		// Token: 0x060057FE RID: 22526
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGenericEnSightReader_GetMinimumTimeValue_18(HandleRef pThis);

		/// <summary>
		/// Get the minimum or maximum time value for this data set.
		/// </summary>
		// Token: 0x060057FF RID: 22527 RVA: 0x0007EE14 File Offset: 0x0007D014
		public virtual float GetMinimumTimeValue()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetMinimumTimeValue_18(base.GetCppThis());
		}

		// Token: 0x06005800 RID: 22528
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfCellArrays_19(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x06005801 RID: 22529 RVA: 0x0007EE34 File Offset: 0x0007D034
		public int GetNumberOfCellArrays()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfCellArrays_19(base.GetCppThis());
		}

		// Token: 0x06005802 RID: 22530
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexScalarsPerElement_20(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005803 RID: 22531 RVA: 0x0007EE54 File Offset: 0x0007D054
		public virtual int GetNumberOfComplexScalarsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexScalarsPerElement_20(base.GetCppThis());
		}

		// Token: 0x06005804 RID: 22532
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexScalarsPerNode_21(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005805 RID: 22533 RVA: 0x0007EE74 File Offset: 0x0007D074
		public virtual int GetNumberOfComplexScalarsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexScalarsPerNode_21(base.GetCppThis());
		}

		// Token: 0x06005806 RID: 22534
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVariables_22(HandleRef pThis);

		/// <summary>
		/// Get the number of variables listed in the case file.
		/// </summary>
		// Token: 0x06005807 RID: 22535 RVA: 0x0007EE94 File Offset: 0x0007D094
		public virtual int GetNumberOfComplexVariables()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexVariables_22(base.GetCppThis());
		}

		// Token: 0x06005808 RID: 22536
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVectorsPerElement_23(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005809 RID: 22537 RVA: 0x0007EEB4 File Offset: 0x0007D0B4
		public virtual int GetNumberOfComplexVectorsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexVectorsPerElement_23(base.GetCppThis());
		}

		// Token: 0x0600580A RID: 22538
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVectorsPerNode_24(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x0600580B RID: 22539 RVA: 0x0007EED4 File Offset: 0x0007D0D4
		public virtual int GetNumberOfComplexVectorsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexVectorsPerNode_24(base.GetCppThis());
		}

		// Token: 0x0600580C RID: 22540
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericEnSightReader_GetNumberOfGenerationsFromBase_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600580D RID: 22541 RVA: 0x0007EEF4 File Offset: 0x0007D0F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfGenerationsFromBase_25(base.GetCppThis(), type);
		}

		// Token: 0x0600580E RID: 22542
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericEnSightReader_GetNumberOfGenerationsFromBaseType_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600580F RID: 22543 RVA: 0x0007EF14 File Offset: 0x0007D114
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfGenerationsFromBaseType_26(type);
		}

		// Token: 0x06005810 RID: 22544
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfPointArrays_27(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x06005811 RID: 22545 RVA: 0x0007EF30 File Offset: 0x0007D130
		public int GetNumberOfPointArrays()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfPointArrays_27(base.GetCppThis());
		}

		// Token: 0x06005812 RID: 22546
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerElement_28(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005813 RID: 22547 RVA: 0x0007EF50 File Offset: 0x0007D150
		public virtual int GetNumberOfScalarsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfScalarsPerElement_28(base.GetCppThis());
		}

		// Token: 0x06005814 RID: 22548
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerMeasuredNode_29(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005815 RID: 22549 RVA: 0x0007EF70 File Offset: 0x0007D170
		public virtual int GetNumberOfScalarsPerMeasuredNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfScalarsPerMeasuredNode_29(base.GetCppThis());
		}

		// Token: 0x06005816 RID: 22550
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerNode_30(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005817 RID: 22551 RVA: 0x0007EF90 File Offset: 0x0007D190
		public virtual int GetNumberOfScalarsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfScalarsPerNode_30(base.GetCppThis());
		}

		// Token: 0x06005818 RID: 22552
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsAsymPerElement_31(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005819 RID: 22553 RVA: 0x0007EFB0 File Offset: 0x0007D1B0
		public virtual int GetNumberOfTensorsAsymPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfTensorsAsymPerElement_31(base.GetCppThis());
		}

		// Token: 0x0600581A RID: 22554
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsAsymPerNode_32(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x0600581B RID: 22555 RVA: 0x0007EFD0 File Offset: 0x0007D1D0
		public virtual int GetNumberOfTensorsAsymPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfTensorsAsymPerNode_32(base.GetCppThis());
		}

		// Token: 0x0600581C RID: 22556
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsSymmPerElement_33(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x0600581D RID: 22557 RVA: 0x0007EFF0 File Offset: 0x0007D1F0
		public virtual int GetNumberOfTensorsSymmPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfTensorsSymmPerElement_33(base.GetCppThis());
		}

		// Token: 0x0600581E RID: 22558
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsSymmPerNode_34(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x0600581F RID: 22559 RVA: 0x0007F010 File Offset: 0x0007D210
		public virtual int GetNumberOfTensorsSymmPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfTensorsSymmPerNode_34(base.GetCppThis());
		}

		// Token: 0x06005820 RID: 22560
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVariables_35(HandleRef pThis);

		/// <summary>
		/// Get the number of variables listed in the case file.
		/// </summary>
		// Token: 0x06005821 RID: 22561 RVA: 0x0007F030 File Offset: 0x0007D230
		public virtual int GetNumberOfVariables()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVariables_35(base.GetCppThis());
		}

		// Token: 0x06005822 RID: 22562
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVariables_36(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005823 RID: 22563 RVA: 0x0007F050 File Offset: 0x0007D250
		public int GetNumberOfVariables(int type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVariables_36(base.GetCppThis(), type);
		}

		// Token: 0x06005824 RID: 22564
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerElement_37(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005825 RID: 22565 RVA: 0x0007F070 File Offset: 0x0007D270
		public virtual int GetNumberOfVectorsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVectorsPerElement_37(base.GetCppThis());
		}

		// Token: 0x06005826 RID: 22566
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerMeasuredNode_38(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005827 RID: 22567 RVA: 0x0007F090 File Offset: 0x0007D290
		public virtual int GetNumberOfVectorsPerMeasuredNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVectorsPerMeasuredNode_38(base.GetCppThis());
		}

		// Token: 0x06005828 RID: 22568
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerNode_39(HandleRef pThis);

		/// <summary>
		/// Get the number of variables of a particular type.
		/// </summary>
		// Token: 0x06005829 RID: 22569 RVA: 0x0007F0B0 File Offset: 0x0007D2B0
		public virtual int GetNumberOfVectorsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVectorsPerNode_39(base.GetCppThis());
		}

		// Token: 0x0600582A RID: 22570
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetParticleCoordinatesByIndex_40(HandleRef pThis);

		/// <summary>
		/// The MeasuredGeometryFile should list particle coordinates
		/// from 0-&gt;N-1.
		/// If a file is loaded where point Ids are listed from 1-N
		/// the Id to points reference will be wrong and the data
		/// will be generated incorrectly.
		/// Setting ParticleCoordinatesByIndex to true will force
		/// all Id's to increment from 0-&gt;N-1 (relative to their order
		/// in the file) and regardless of the actual Id of the point.
		/// Warning, if the Points are listed in non sequential order
		/// then setting this flag will reorder them.
		/// </summary>
		// Token: 0x0600582B RID: 22571 RVA: 0x0007F0D0 File Offset: 0x0007D2D0
		public virtual int GetParticleCoordinatesByIndex()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetParticleCoordinatesByIndex_40(base.GetCppThis());
		}

		// Token: 0x0600582C RID: 22572
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetPointArrayName_41(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x0600582D RID: 22573 RVA: 0x0007F0F0 File Offset: 0x0007D2F0
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetPointArrayName_41(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600582E RID: 22574
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetPointArrayStatus_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600582F RID: 22575 RVA: 0x0007F12C File Offset: 0x0007D32C
		public int GetPointArrayStatus(string name)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetPointArrayStatus_42(base.GetCppThis(), name);
		}

		// Token: 0x06005830 RID: 22576
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetPointDataArraySelection_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06005831 RID: 22577 RVA: 0x0007F14C File Offset: 0x0007D34C
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetPointDataArraySelection_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005832 RID: 22578
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetReadAllVariables_44(HandleRef pThis);

		/// <summary>
		/// Set/get the flag for whether to read all the variables
		/// </summary>
		// Token: 0x06005833 RID: 22579 RVA: 0x0007F1BC File Offset: 0x0007D3BC
		public virtual int GetReadAllVariables()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetReadAllVariables_44(base.GetCppThis());
		}

		// Token: 0x06005834 RID: 22580
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetReader_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns IsEnSightFile() by default, but can be overridden
		/// </summary>
		// Token: 0x06005835 RID: 22581 RVA: 0x0007F1DC File Offset: 0x0007D3DC
		public vtkGenericEnSightReader GetReader()
		{
			vtkGenericEnSightReader vtkGenericEnSightReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetReader_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericEnSightReader = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericEnSightReader.Register(null);
				}
			}
			return vtkGenericEnSightReader;
		}

		// Token: 0x06005836 RID: 22582
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_GetTimeSets_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the time values per time set
		/// </summary>
		// Token: 0x06005837 RID: 22583 RVA: 0x0007F24C File Offset: 0x0007D44C
		public virtual vtkDataArrayCollection GetTimeSets()
		{
			vtkDataArrayCollection vtkDataArrayCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetTimeSets_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArrayCollection = (vtkDataArrayCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArrayCollection.Register(null);
				}
			}
			return vtkDataArrayCollection;
		}

		// Token: 0x06005838 RID: 22584
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGenericEnSightReader_GetTimeValue_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the time value at which to get the value.
		/// </summary>
		// Token: 0x06005839 RID: 22585 RVA: 0x0007F2BC File Offset: 0x0007D4BC
		public virtual float GetTimeValue()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetTimeValue_47(base.GetCppThis());
		}

		// Token: 0x0600583A RID: 22586
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_GetVariableType_48(HandleRef pThis, int n);

		/// <summary>
		/// Get the variable type of variable n.
		/// </summary>
		// Token: 0x0600583B RID: 22587 RVA: 0x0007F2DC File Offset: 0x0007D4DC
		public int GetVariableType(int n)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetVariableType_48(base.GetCppThis(), n);
		}

		// Token: 0x0600583C RID: 22588
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_IsA_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600583D RID: 22589 RVA: 0x0007F2FC File Offset: 0x0007D4FC
		public override int IsA(string type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_IsA_49(base.GetCppThis(), type);
		}

		// Token: 0x0600583E RID: 22590
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGenericEnSightReader_IsEnSightFile_50([MarshalAs(UnmanagedType.LPUTF8Str)] string casefilename);

		/// <summary>
		/// Returns true if the file pointed to by casefilename appears to be a
		/// valid EnSight case file.
		/// </summary>
		// Token: 0x0600583F RID: 22591 RVA: 0x0007F31C File Offset: 0x0007D51C
		public static bool IsEnSightFile(string casefilename)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_IsEnSightFile_50(casefilename) != 0;
		}

		// Token: 0x06005840 RID: 22592
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEnSightReader_IsTypeOf_51([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005841 RID: 22593 RVA: 0x0007F340 File Offset: 0x0007D540
		public new static int IsTypeOf(string type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_IsTypeOf_51(type);
		}

		// Token: 0x06005842 RID: 22594
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_NewInstance_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005843 RID: 22595 RVA: 0x0007F35C File Offset: 0x0007D55C
		public new vtkGenericEnSightReader NewInstance()
		{
			vtkGenericEnSightReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_NewInstance_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005844 RID: 22596
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_ParticleCoordinatesByIndexOff_54(HandleRef pThis);

		/// <summary>
		/// The MeasuredGeometryFile should list particle coordinates
		/// from 0-&gt;N-1.
		/// If a file is loaded where point Ids are listed from 1-N
		/// the Id to points reference will be wrong and the data
		/// will be generated incorrectly.
		/// Setting ParticleCoordinatesByIndex to true will force
		/// all Id's to increment from 0-&gt;N-1 (relative to their order
		/// in the file) and regardless of the actual Id of the point.
		/// Warning, if the Points are listed in non sequential order
		/// then setting this flag will reorder them.
		/// </summary>
		// Token: 0x06005845 RID: 22597 RVA: 0x0007F3B6 File Offset: 0x0007D5B6
		public virtual void ParticleCoordinatesByIndexOff()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ParticleCoordinatesByIndexOff_54(base.GetCppThis());
		}

		// Token: 0x06005846 RID: 22598
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_ParticleCoordinatesByIndexOn_55(HandleRef pThis);

		/// <summary>
		/// The MeasuredGeometryFile should list particle coordinates
		/// from 0-&gt;N-1.
		/// If a file is loaded where point Ids are listed from 1-N
		/// the Id to points reference will be wrong and the data
		/// will be generated incorrectly.
		/// Setting ParticleCoordinatesByIndex to true will force
		/// all Id's to increment from 0-&gt;N-1 (relative to their order
		/// in the file) and regardless of the actual Id of the point.
		/// Warning, if the Points are listed in non sequential order
		/// then setting this flag will reorder them.
		/// </summary>
		// Token: 0x06005847 RID: 22599 RVA: 0x0007F3C5 File Offset: 0x0007D5C5
		public virtual void ParticleCoordinatesByIndexOn()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ParticleCoordinatesByIndexOn_55(base.GetCppThis());
		}

		// Token: 0x06005848 RID: 22600
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_ReadAllVariablesOff_56(HandleRef pThis);

		/// <summary>
		/// Set/get the flag for whether to read all the variables
		/// </summary>
		// Token: 0x06005849 RID: 22601 RVA: 0x0007F3D4 File Offset: 0x0007D5D4
		public virtual void ReadAllVariablesOff()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ReadAllVariablesOff_56(base.GetCppThis());
		}

		// Token: 0x0600584A RID: 22602
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_ReadAllVariablesOn_57(HandleRef pThis);

		/// <summary>
		/// Set/get the flag for whether to read all the variables
		/// </summary>
		// Token: 0x0600584B RID: 22603 RVA: 0x0007F3E3 File Offset: 0x0007D5E3
		public virtual void ReadAllVariablesOn()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ReadAllVariablesOn_57(base.GetCppThis());
		}

		// Token: 0x0600584C RID: 22604
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEnSightReader_SafeDownCast_58(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600584D RID: 22605 RVA: 0x0007F3F4 File Offset: 0x0007D5F4
		public new static vtkGenericEnSightReader SafeDownCast(vtkObjectBase o)
		{
			vtkGenericEnSightReader vtkGenericEnSightReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_SafeDownCast_58((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericEnSightReader = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericEnSightReader.Register(null);
				}
			}
			return vtkGenericEnSightReader;
		}

		// Token: 0x0600584E RID: 22606
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetApplyTetrahedralize_59(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set to ApplyTetrahedralize.
		/// It's used to apply a Tetrahedralize filter to prevent potential non manifold triangles
		/// produced by the ensight solver.
		/// </summary>
		// Token: 0x0600584F RID: 22607 RVA: 0x0007F473 File Offset: 0x0007D673
		public virtual void SetApplyTetrahedralize(bool _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetApplyTetrahedralize_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005850 RID: 22608
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetByteOrder_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x06005851 RID: 22609 RVA: 0x0007F48B File Offset: 0x0007D68B
		public virtual void SetByteOrder(int _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetByteOrder_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06005852 RID: 22610
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetByteOrderToBigEndian_61(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x06005853 RID: 22611 RVA: 0x0007F49B File Offset: 0x0007D69B
		public void SetByteOrderToBigEndian()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetByteOrderToBigEndian_61(base.GetCppThis());
		}

		// Token: 0x06005854 RID: 22612
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetByteOrderToLittleEndian_62(HandleRef pThis);

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x06005855 RID: 22613 RVA: 0x0007F4AA File Offset: 0x0007D6AA
		public void SetByteOrderToLittleEndian()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetByteOrderToLittleEndian_62(base.GetCppThis());
		}

		// Token: 0x06005856 RID: 22614
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetCaseFileName_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Set/Get the Case file name.
		/// </summary>
		// Token: 0x06005857 RID: 22615 RVA: 0x0007F4B9 File Offset: 0x0007D6B9
		public void SetCaseFileName(string fileName)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetCaseFileName_63(base.GetCppThis(), fileName);
		}

		// Token: 0x06005858 RID: 22616
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetCellArrayStatus_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06005859 RID: 22617 RVA: 0x0007F4C9 File Offset: 0x0007D6C9
		public void SetCellArrayStatus(string name, int status)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetCellArrayStatus_64(base.GetCppThis(), name, status);
		}

		// Token: 0x0600585A RID: 22618
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetFilePath_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the file path.
		/// </summary>
		// Token: 0x0600585B RID: 22619 RVA: 0x0007F4DA File Offset: 0x0007D6DA
		public virtual void SetFilePath(string _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetFilePath_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600585C RID: 22620
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetParticleCoordinatesByIndex_66(HandleRef pThis, int _arg);

		/// <summary>
		/// The MeasuredGeometryFile should list particle coordinates
		/// from 0-&gt;N-1.
		/// If a file is loaded where point Ids are listed from 1-N
		/// the Id to points reference will be wrong and the data
		/// will be generated incorrectly.
		/// Setting ParticleCoordinatesByIndex to true will force
		/// all Id's to increment from 0-&gt;N-1 (relative to their order
		/// in the file) and regardless of the actual Id of the point.
		/// Warning, if the Points are listed in non sequential order
		/// then setting this flag will reorder them.
		/// </summary>
		// Token: 0x0600585D RID: 22621 RVA: 0x0007F4EA File Offset: 0x0007D6EA
		public virtual void SetParticleCoordinatesByIndex(int _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetParticleCoordinatesByIndex_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0600585E RID: 22622
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetPointArrayStatus_67(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600585F RID: 22623 RVA: 0x0007F4FA File Offset: 0x0007D6FA
		public void SetPointArrayStatus(string name, int status)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetPointArrayStatus_67(base.GetCppThis(), name, status);
		}

		// Token: 0x06005860 RID: 22624
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetReadAllVariables_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the flag for whether to read all the variables
		/// </summary>
		// Token: 0x06005861 RID: 22625 RVA: 0x0007F50B File Offset: 0x0007D70B
		public virtual void SetReadAllVariables(int _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetReadAllVariables_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06005862 RID: 22626
		[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEnSightReader_SetTimeValue_69(HandleRef pThis, float value);

		/// <summary>
		/// Set/Get the time value at which to get the value.
		/// </summary>
		// Token: 0x06005863 RID: 22627 RVA: 0x0007F51B File Offset: 0x0007D71B
		public virtual void SetTimeValue(float value)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetTimeValue_69(base.GetCppThis(), value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400081D RID: 2077
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericEnSightReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400081E RID: 2078
		public new static readonly string MRClassNameKey = "class vtkGenericEnSightReader";

		/// <summary>
		/// Set the byte order of the file (remember, more Unix workstations
		/// write big endian whereas PCs write little endian). Default is
		/// big endian (since most older PLOT3D files were written by
		/// workstations).
		/// </summary>
		// Token: 0x020001BF RID: 447
		public enum FILE_BIG_ENDIAN_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000820 RID: 2080
			FILE_BIG_ENDIAN,
			/// <summary>enum member</summary>
			// Token: 0x04000821 RID: 2081
			FILE_LITTLE_ENDIAN,
			/// <summary>enum member</summary>
			// Token: 0x04000822 RID: 2082
			FILE_UNKNOWN_ENDIAN
		}

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x020001C0 RID: 448
		public enum FileTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04000824 RID: 2084
			ENSIGHT_6,
			/// <summary>enum member</summary>
			// Token: 0x04000825 RID: 2085
			ENSIGHT_6_BINARY,
			/// <summary>enum member</summary>
			// Token: 0x04000826 RID: 2086
			ENSIGHT_GOLD,
			/// <summary>enum member</summary>
			// Token: 0x04000827 RID: 2087
			ENSIGHT_GOLD_BINARY,
			/// <summary>enum member</summary>
			// Token: 0x04000828 RID: 2088
			ENSIGHT_MASTER_SERVER
		}
	}
}
