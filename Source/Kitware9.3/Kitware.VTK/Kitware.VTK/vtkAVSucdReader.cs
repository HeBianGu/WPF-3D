using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAVSucdReader
	/// </summary>
	/// <remarks>
	///    reads a dataset in AVS "UCD" format
	///
	/// vtkAVSucdReader creates an unstructured grid dataset. It reads binary or
	/// ASCII files stored in UCD format, with optional data stored at the nodes
	/// or at the cells of the model. A cell-based fielddata stores the material
	/// id. The class can automatically detect the endian-ness of the binary files.
	///
	/// @par Thanks:
	/// Thanks to Guenole Harel and Emmanuel Colin (Supelec engineering school,
	/// France) and Jean M. Favre (CSCS, Switzerland) who co-developed this class.
	/// Thanks to Isabelle Surin (isabelle.surin at cea.fr, CEA-DAM, France) who
	/// supervised the internship of the first two authors. Thanks to Daniel
	/// Aguilera (daniel.aguilera at cea.fr, CEA-DAM, France) who contributed code
	/// and advice. Please address all comments to Jean Favre (jfavre at cscs.ch)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGAMBITReader
	/// </seealso>
	// Token: 0x020001FA RID: 506
	public class vtkAVSucdReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006142 RID: 24898 RVA: 0x0008C343 File Offset: 0x0008A543
		static vtkAVSucdReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAVSucdReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAVSucdReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006143 RID: 24899 RVA: 0x0008C36B File Offset: 0x0008A56B
		public vtkAVSucdReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006144 RID: 24900
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVSucdReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006145 RID: 24901 RVA: 0x0008C37C File Offset: 0x0008A57C
		public new static vtkAVSucdReader New()
		{
			vtkAVSucdReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAVSucdReader.vtkAVSucdReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006146 RID: 24902 RVA: 0x0008C3D0 File Offset: 0x0008A5D0
		public vtkAVSucdReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAVSucdReader.vtkAVSucdReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006147 RID: 24903 RVA: 0x0008C414 File Offset: 0x0008A614
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006148 RID: 24904
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_BinaryFileOff_01(HandleRef pThis);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed to ascii).
		/// </summary>
		// Token: 0x06006149 RID: 24905 RVA: 0x0008C41F File Offset: 0x0008A61F
		public virtual void BinaryFileOff()
		{
			vtkAVSucdReader.vtkAVSucdReader_BinaryFileOff_01(base.GetCppThis());
		}

		// Token: 0x0600614A RID: 24906
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_BinaryFileOn_02(HandleRef pThis);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed to ascii).
		/// </summary>
		// Token: 0x0600614B RID: 24907 RVA: 0x0008C42E File Offset: 0x0008A62E
		public virtual void BinaryFileOn()
		{
			vtkAVSucdReader.vtkAVSucdReader_BinaryFileOn_02(base.GetCppThis());
		}

		// Token: 0x0600614C RID: 24908
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_DisableAllCellArrays_03(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600614D RID: 24909 RVA: 0x0008C43D File Offset: 0x0008A63D
		public void DisableAllCellArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_DisableAllCellArrays_03(base.GetCppThis());
		}

		// Token: 0x0600614E RID: 24910
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_DisableAllPointArrays_04(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600614F RID: 24911 RVA: 0x0008C44C File Offset: 0x0008A64C
		public void DisableAllPointArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_DisableAllPointArrays_04(base.GetCppThis());
		}

		// Token: 0x06006150 RID: 24912
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_EnableAllCellArrays_05(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06006151 RID: 24913 RVA: 0x0008C45B File Offset: 0x0008A65B
		public void EnableAllCellArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_EnableAllCellArrays_05(base.GetCppThis());
		}

		// Token: 0x06006152 RID: 24914
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_EnableAllPointArrays_06(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06006153 RID: 24915 RVA: 0x0008C46A File Offset: 0x0008A66A
		public void EnableAllPointArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_EnableAllPointArrays_06(base.GetCppThis());
		}

		// Token: 0x06006154 RID: 24916
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetBinaryFile_07(HandleRef pThis);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed to ascii).
		/// </summary>
		// Token: 0x06006155 RID: 24917 RVA: 0x0008C47C File Offset: 0x0008A67C
		public virtual int GetBinaryFile()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetBinaryFile_07(base.GetCppThis());
		}

		// Token: 0x06006156 RID: 24918
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetByteOrder_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the endian-ness of the binary file.
		/// </summary>
		// Token: 0x06006157 RID: 24919 RVA: 0x0008C49C File Offset: 0x0008A69C
		public virtual int GetByteOrder()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetByteOrder_08(base.GetCppThis());
		}

		// Token: 0x06006158 RID: 24920
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVSucdReader_GetByteOrderAsString_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the endian-ness of the binary file.
		/// </summary>
		// Token: 0x06006159 RID: 24921 RVA: 0x0008C4BC File Offset: 0x0008A6BC
		public string GetByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetByteOrderAsString_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600615A RID: 24922
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVSucdReader_GetCellArrayName_10(HandleRef pThis, int index);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600615B RID: 24923 RVA: 0x0008C4F8 File Offset: 0x0008A6F8
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetCellArrayName_10(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600615C RID: 24924
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetCellArrayStatus_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600615D RID: 24925 RVA: 0x0008C534 File Offset: 0x0008A734
		public int GetCellArrayStatus(string name)
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetCellArrayStatus_11(base.GetCppThis(), name);
		}

		// Token: 0x0600615E RID: 24926
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_GetCellDataRange_12(HandleRef pThis, int cellComp, int index, IntPtr min, IntPtr max);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600615F RID: 24927 RVA: 0x0008C554 File Offset: 0x0008A754
		public void GetCellDataRange(int cellComp, int index, IntPtr min, IntPtr max)
		{
			vtkAVSucdReader.vtkAVSucdReader_GetCellDataRange_12(base.GetCppThis(), cellComp, index, min, max);
		}

		// Token: 0x06006160 RID: 24928
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVSucdReader_GetFileName_13(HandleRef pThis);

		/// <summary>
		/// Specify file name of AVS UCD datafile to read
		/// </summary>
		// Token: 0x06006161 RID: 24929 RVA: 0x0008C568 File Offset: 0x0008A768
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetFileName_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006162 RID: 24930
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_GetNodeDataRange_14(HandleRef pThis, int nodeComp, int index, IntPtr min, IntPtr max);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06006163 RID: 24931 RVA: 0x0008C5A2 File Offset: 0x0008A7A2
		public void GetNodeDataRange(int nodeComp, int index, IntPtr min, IntPtr max)
		{
			vtkAVSucdReader.vtkAVSucdReader_GetNodeDataRange_14(base.GetCppThis(), nodeComp, index, min, max);
		}

		// Token: 0x06006164 RID: 24932
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfCellArrays_15(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06006165 RID: 24933 RVA: 0x0008C5B8 File Offset: 0x0008A7B8
		public int GetNumberOfCellArrays()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCellArrays_15(base.GetCppThis());
		}

		// Token: 0x06006166 RID: 24934
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfCellComponents_16(HandleRef pThis);

		/// <summary>
		/// Get the number of data components at the nodes and cells.
		/// </summary>
		// Token: 0x06006167 RID: 24935 RVA: 0x0008C5D8 File Offset: 0x0008A7D8
		public virtual int GetNumberOfCellComponents()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCellComponents_16(base.GetCppThis());
		}

		// Token: 0x06006168 RID: 24936
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfCellFields_17(HandleRef pThis);

		/// <summary>
		/// Get the number of data fields at the cell centers.
		/// </summary>
		// Token: 0x06006169 RID: 24937 RVA: 0x0008C5F8 File Offset: 0x0008A7F8
		public virtual int GetNumberOfCellFields()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCellFields_17(base.GetCppThis());
		}

		// Token: 0x0600616A RID: 24938
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfCells_18(HandleRef pThis);

		/// <summary>
		/// Get the total number of cells.
		/// </summary>
		// Token: 0x0600616B RID: 24939 RVA: 0x0008C618 File Offset: 0x0008A818
		public virtual int GetNumberOfCells()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCells_18(base.GetCppThis());
		}

		// Token: 0x0600616C RID: 24940
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfFields_19(HandleRef pThis);

		/// <summary>
		/// Get the number of data fields for the model. Unused because VTK
		/// has no methods for it.
		/// </summary>
		// Token: 0x0600616D RID: 24941 RVA: 0x0008C638 File Offset: 0x0008A838
		public virtual int GetNumberOfFields()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfFields_19(base.GetCppThis());
		}

		// Token: 0x0600616E RID: 24942
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAVSucdReader_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600616F RID: 24943 RVA: 0x0008C658 File Offset: 0x0008A858
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06006170 RID: 24944
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAVSucdReader_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006171 RID: 24945 RVA: 0x0008C678 File Offset: 0x0008A878
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06006172 RID: 24946
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfNodeComponents_22(HandleRef pThis);

		/// <summary>
		/// Get the number of data components at the nodes and cells.
		/// </summary>
		// Token: 0x06006173 RID: 24947 RVA: 0x0008C694 File Offset: 0x0008A894
		public virtual int GetNumberOfNodeComponents()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfNodeComponents_22(base.GetCppThis());
		}

		// Token: 0x06006174 RID: 24948
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfNodeFields_23(HandleRef pThis);

		/// <summary>
		/// Get the number of data fields at the nodes.
		/// </summary>
		// Token: 0x06006175 RID: 24949 RVA: 0x0008C6B4 File Offset: 0x0008A8B4
		public virtual int GetNumberOfNodeFields()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfNodeFields_23(base.GetCppThis());
		}

		// Token: 0x06006176 RID: 24950
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfNodes_24(HandleRef pThis);

		/// <summary>
		/// Get the total number of nodes.
		/// </summary>
		// Token: 0x06006177 RID: 24951 RVA: 0x0008C6D4 File Offset: 0x0008A8D4
		public virtual int GetNumberOfNodes()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfNodes_24(base.GetCppThis());
		}

		// Token: 0x06006178 RID: 24952
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetNumberOfPointArrays_25(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06006179 RID: 24953 RVA: 0x0008C6F4 File Offset: 0x0008A8F4
		public int GetNumberOfPointArrays()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfPointArrays_25(base.GetCppThis());
		}

		// Token: 0x0600617A RID: 24954
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVSucdReader_GetPointArrayName_26(HandleRef pThis, int index);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600617B RID: 24955 RVA: 0x0008C714 File Offset: 0x0008A914
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetPointArrayName_26(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600617C RID: 24956
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_GetPointArrayStatus_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600617D RID: 24957 RVA: 0x0008C750 File Offset: 0x0008A950
		public int GetPointArrayStatus(string name)
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetPointArrayStatus_27(base.GetCppThis(), name);
		}

		// Token: 0x0600617E RID: 24958
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600617F RID: 24959 RVA: 0x0008C770 File Offset: 0x0008A970
		public override int IsA(string type)
		{
			return vtkAVSucdReader.vtkAVSucdReader_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x06006180 RID: 24960
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVSucdReader_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006181 RID: 24961 RVA: 0x0008C790 File Offset: 0x0008A990
		public new static int IsTypeOf(string type)
		{
			return vtkAVSucdReader.vtkAVSucdReader_IsTypeOf_29(type);
		}

		// Token: 0x06006182 RID: 24962
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVSucdReader_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006183 RID: 24963 RVA: 0x0008C7AC File Offset: 0x0008A9AC
		public new vtkAVSucdReader NewInstance()
		{
			vtkAVSucdReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAVSucdReader.vtkAVSucdReader_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006184 RID: 24964
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVSucdReader_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006185 RID: 24965 RVA: 0x0008C808 File Offset: 0x0008AA08
		public new static vtkAVSucdReader SafeDownCast(vtkObjectBase o)
		{
			vtkAVSucdReader vtkAVSucdReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAVSucdReader.vtkAVSucdReader_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAVSucdReader = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAVSucdReader.Register(null);
				}
			}
			return vtkAVSucdReader;
		}

		// Token: 0x06006186 RID: 24966
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_SetBinaryFile_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Is the file to be read written in binary format (as opposed to ascii).
		/// </summary>
		// Token: 0x06006187 RID: 24967 RVA: 0x0008C887 File Offset: 0x0008AA87
		public virtual void SetBinaryFile(int _arg)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetBinaryFile_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06006188 RID: 24968
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_SetByteOrder_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the endian-ness of the binary file.
		/// </summary>
		// Token: 0x06006189 RID: 24969 RVA: 0x0008C897 File Offset: 0x0008AA97
		public virtual void SetByteOrder(int _arg)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetByteOrder_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600618A RID: 24970
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_SetByteOrderToBigEndian_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the endian-ness of the binary file.
		/// </summary>
		// Token: 0x0600618B RID: 24971 RVA: 0x0008C8A7 File Offset: 0x0008AAA7
		public void SetByteOrderToBigEndian()
		{
			vtkAVSucdReader.vtkAVSucdReader_SetByteOrderToBigEndian_35(base.GetCppThis());
		}

		// Token: 0x0600618C RID: 24972
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_SetByteOrderToLittleEndian_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the endian-ness of the binary file.
		/// </summary>
		// Token: 0x0600618D RID: 24973 RVA: 0x0008C8B6 File Offset: 0x0008AAB6
		public void SetByteOrderToLittleEndian()
		{
			vtkAVSucdReader.vtkAVSucdReader_SetByteOrderToLittleEndian_36(base.GetCppThis());
		}

		// Token: 0x0600618E RID: 24974
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_SetCellArrayStatus_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600618F RID: 24975 RVA: 0x0008C8C5 File Offset: 0x0008AAC5
		public void SetCellArrayStatus(string name, int status)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetCellArrayStatus_37(base.GetCppThis(), name, status);
		}

		// Token: 0x06006190 RID: 24976
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_SetFileName_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of AVS UCD datafile to read
		/// </summary>
		// Token: 0x06006191 RID: 24977 RVA: 0x0008C8D6 File Offset: 0x0008AAD6
		public virtual void SetFileName(string _arg)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetFileName_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06006192 RID: 24978
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVSucdReader_SetPointArrayStatus_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.  by
		/// default, ALL data fields are the nodes and cells are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06006193 RID: 24979 RVA: 0x0008C8E6 File Offset: 0x0008AAE6
		public void SetPointArrayStatus(string name, int status)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetPointArrayStatus_39(base.GetCppThis(), name, status);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008BE RID: 2238
		public new const string MRFullTypeName = "Kitware.VTK.vtkAVSucdReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008BF RID: 2239
		public new static readonly string MRClassNameKey = "class vtkAVSucdReader";
	}
}
