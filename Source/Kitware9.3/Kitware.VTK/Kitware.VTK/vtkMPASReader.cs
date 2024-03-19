using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMPASReader
	/// </summary>
	/// <remarks>
	///    Read an MPAS netCDF file
	///
	/// This program reads an MPAS netCDF data file to allow paraview to
	/// display a dual-grid sphere or latlon projection.  Also allows
	/// display of primal-grid sphere.
	/// The variables that have time dim are available to ParaView.
	///
	/// Assume all variables are of interest if they have dims
	/// (Time, nCells|nVertices, nVertLevels, [nTracers]).
	/// Does not deal with edge data.
	///
	/// When using this reader, it is important that you remember to do the
	///             following:
	///   1.  When changing a selected variable, remember to select it also
	///       in the drop down box to "color by".  It doesn't color by that variable
	///       automatically.
	///   2.  When selecting multilayer sphere view, make layer thickness around
	///       100,000.
	///   3.  When selecting multilayer lat/lon view, make layer thickness around 10.
	///   4.  Always click the -Z orientation after making a switch from lat/lon to
	///       sphere, from single to multilayer or changing thickness.
	///   5.  Be conservative on the number of changes you make before hitting Apply,
	///       since there may be bugs in this reader.  Just make one change and then
	///       hit Apply.
	///
	///
	/// Christine Ahrens (cahrens@lanl.gov)
	/// Version 1.3
	/// </remarks>
	// Token: 0x0200016B RID: 363
	public class vtkMPASReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600451C RID: 17692 RVA: 0x00064B63 File Offset: 0x00062D63
		static vtkMPASReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMPASReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMPASReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600451D RID: 17693 RVA: 0x00064B8B File Offset: 0x00062D8B
		public vtkMPASReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600451E RID: 17694
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600451F RID: 17695 RVA: 0x00064B9C File Offset: 0x00062D9C
		public new static vtkMPASReader New()
		{
			vtkMPASReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004520 RID: 17696 RVA: 0x00064BF0 File Offset: 0x00062DF0
		public vtkMPASReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMPASReader.vtkMPASReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004521 RID: 17697 RVA: 0x00064C34 File Offset: 0x00062E34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004522 RID: 17698
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Returns true if the given file can be read.
		/// </summary>
		// Token: 0x06004523 RID: 17699 RVA: 0x00064C40 File Offset: 0x00062E40
		public static int CanReadFile(string filename)
		{
			return vtkMPASReader.vtkMPASReader_CanReadFile_01(filename);
		}

		// Token: 0x06004524 RID: 17700
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_DisableAllCellArrays_02(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004525 RID: 17701 RVA: 0x00064C5A File Offset: 0x00062E5A
		public void DisableAllCellArrays()
		{
			vtkMPASReader.vtkMPASReader_DisableAllCellArrays_02(base.GetCppThis());
		}

		// Token: 0x06004526 RID: 17702
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_DisableAllPointArrays_03(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004527 RID: 17703 RVA: 0x00064C69 File Offset: 0x00062E69
		public void DisableAllPointArrays()
		{
			vtkMPASReader.vtkMPASReader_DisableAllPointArrays_03(base.GetCppThis());
		}

		// Token: 0x06004528 RID: 17704
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_EnableAllCellArrays_04(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004529 RID: 17705 RVA: 0x00064C78 File Offset: 0x00062E78
		public void EnableAllCellArrays()
		{
			vtkMPASReader.vtkMPASReader_EnableAllCellArrays_04(base.GetCppThis());
		}

		// Token: 0x0600452A RID: 17706
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_EnableAllPointArrays_05(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600452B RID: 17707 RVA: 0x00064C87 File Offset: 0x00062E87
		public void EnableAllPointArrays()
		{
			vtkMPASReader.vtkMPASReader_EnableAllPointArrays_05(base.GetCppThis());
		}

		// Token: 0x0600452C RID: 17708
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetAllDimensions_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the point/cell arrays contain dimensions other than Time, nCells, or
		/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
		/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
		/// retrieve the dimension names. GetDimensionSize returns the number of values
		/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
		/// to fix a given dimension at when extracting slices of data.
		/// </summary>
		// Token: 0x0600452D RID: 17709 RVA: 0x00064C98 File Offset: 0x00062E98
		public vtkStringArray GetAllDimensions()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetAllDimensions_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0600452E RID: 17710
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetCellArrayName_07(HandleRef pThis, int index);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600452F RID: 17711 RVA: 0x00064D08 File Offset: 0x00062F08
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkMPASReader.vtkMPASReader_GetCellArrayName_07(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004530 RID: 17712
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetCellArrayStatus_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004531 RID: 17713 RVA: 0x00064D44 File Offset: 0x00062F44
		public int GetCellArrayStatus(string name)
		{
			return vtkMPASReader.vtkMPASReader_GetCellArrayStatus_08(base.GetCppThis(), name);
		}

		// Token: 0x06004532 RID: 17714
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetCenterLonRange_09(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004533 RID: 17715 RVA: 0x00064D64 File Offset: 0x00062F64
		public virtual int[] GetCenterLonRange()
		{
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetCenterLonRange_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004534 RID: 17716
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_GetCenterLonRange_10(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004535 RID: 17717 RVA: 0x00064DAC File Offset: 0x00062FAC
		public virtual void GetCenterLonRange(ref int _arg1, ref int _arg2)
		{
			vtkMPASReader.vtkMPASReader_GetCenterLonRange_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06004536 RID: 17718
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_GetCenterLonRange_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004537 RID: 17719 RVA: 0x00064DBD File Offset: 0x00062FBD
		public virtual void GetCenterLonRange(IntPtr _arg)
		{
			vtkMPASReader.vtkMPASReader_GetCenterLonRange_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06004538 RID: 17720
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetDimensionCurrentIndex_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dim);

		/// <summary>
		/// If the point/cell arrays contain dimensions other than Time, nCells, or
		/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
		/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
		/// retrieve the dimension names. GetDimensionSize returns the number of values
		/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
		/// to fix a given dimension at when extracting slices of data.
		/// </summary>
		// Token: 0x06004539 RID: 17721 RVA: 0x00064DD0 File Offset: 0x00062FD0
		public int GetDimensionCurrentIndex(string dim)
		{
			return vtkMPASReader.vtkMPASReader_GetDimensionCurrentIndex_12(base.GetCppThis(), dim);
		}

		// Token: 0x0600453A RID: 17722
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkMPASReader_GetDimensionName_13(HandleRef pThis, int idx);

		/// <summary>
		/// If the point/cell arrays contain dimensions other than Time, nCells, or
		/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
		/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
		/// retrieve the dimension names. GetDimensionSize returns the number of values
		/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
		/// to fix a given dimension at when extracting slices of data.
		/// </summary>
		// Token: 0x0600453B RID: 17723 RVA: 0x00064DF0 File Offset: 0x00062FF0
		public string GetDimensionName(int idx)
		{
			return vtkMPASReader.vtkMPASReader_GetDimensionName_13(base.GetCppThis(), idx);
		}

		// Token: 0x0600453C RID: 17724
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetDimensionSize_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dim);

		/// <summary>
		/// If the point/cell arrays contain dimensions other than Time, nCells, or
		/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
		/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
		/// retrieve the dimension names. GetDimensionSize returns the number of values
		/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
		/// to fix a given dimension at when extracting slices of data.
		/// </summary>
		// Token: 0x0600453D RID: 17725 RVA: 0x00064E10 File Offset: 0x00063010
		public int GetDimensionSize(string dim)
		{
			return vtkMPASReader.vtkMPASReader_GetDimensionSize_14(base.GetCppThis(), dim);
		}

		// Token: 0x0600453E RID: 17726
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetFileName_15(HandleRef pThis);

		/// <summary>
		/// Specify file name of MPAS data file to read.
		/// </summary>
		// Token: 0x0600453F RID: 17727 RVA: 0x00064E30 File Offset: 0x00063030
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMPASReader.vtkMPASReader_GetFileName_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004540 RID: 17728
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMPASReader_GetIsAtmosphere_16(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004541 RID: 17729 RVA: 0x00064E6C File Offset: 0x0006306C
		public virtual bool GetIsAtmosphere()
		{
			return vtkMPASReader.vtkMPASReader_GetIsAtmosphere_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06004542 RID: 17730
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMPASReader_GetIsZeroCentered_17(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004543 RID: 17731 RVA: 0x00064E94 File Offset: 0x00063094
		public virtual bool GetIsZeroCentered()
		{
			return vtkMPASReader.vtkMPASReader_GetIsZeroCentered_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06004544 RID: 17732
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetLayerThickness_18(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004545 RID: 17733 RVA: 0x00064EBC File Offset: 0x000630BC
		public virtual int GetLayerThickness()
		{
			return vtkMPASReader.vtkMPASReader_GetLayerThickness_18(base.GetCppThis());
		}

		// Token: 0x06004546 RID: 17734
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetLayerThicknessRange_19(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004547 RID: 17735 RVA: 0x00064EDC File Offset: 0x000630DC
		public virtual int[] GetLayerThicknessRange()
		{
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetLayerThicknessRange_19(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004548 RID: 17736
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_GetLayerThicknessRange_20(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004549 RID: 17737 RVA: 0x00064F24 File Offset: 0x00063124
		public virtual void GetLayerThicknessRange(ref int _arg1, ref int _arg2)
		{
			vtkMPASReader.vtkMPASReader_GetLayerThicknessRange_20(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600454A RID: 17738
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_GetLayerThicknessRange_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x0600454B RID: 17739 RVA: 0x00064F35 File Offset: 0x00063135
		public virtual void GetLayerThicknessRange(IntPtr _arg)
		{
			vtkMPASReader.vtkMPASReader_GetLayerThicknessRange_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600454C RID: 17740
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMPASReader_GetMTime_22(HandleRef pThis);

		/// <summary>
		/// Returns true if the given file can be read.
		/// </summary>
		// Token: 0x0600454D RID: 17741 RVA: 0x00064F48 File Offset: 0x00063148
		public override ulong GetMTime()
		{
			return vtkMPASReader.vtkMPASReader_GetMTime_22(base.GetCppThis());
		}

		// Token: 0x0600454E RID: 17742
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetMaximumCells_23(HandleRef pThis);

		/// <summary>
		/// Get the number of data cells
		/// </summary>
		// Token: 0x0600454F RID: 17743 RVA: 0x00064F68 File Offset: 0x00063168
		public virtual int GetMaximumCells()
		{
			return vtkMPASReader.vtkMPASReader_GetMaximumCells_23(base.GetCppThis());
		}

		// Token: 0x06004550 RID: 17744
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetMaximumPoints_24(HandleRef pThis);

		/// <summary>
		/// Get the number of points
		/// </summary>
		// Token: 0x06004551 RID: 17745 RVA: 0x00064F88 File Offset: 0x00063188
		public virtual int GetMaximumPoints()
		{
			return vtkMPASReader.vtkMPASReader_GetMaximumPoints_24(base.GetCppThis());
		}

		// Token: 0x06004552 RID: 17746
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetNumberOfCellArrays_25(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004553 RID: 17747 RVA: 0x00064FA8 File Offset: 0x000631A8
		public int GetNumberOfCellArrays()
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfCellArrays_25(base.GetCppThis());
		}

		// Token: 0x06004554 RID: 17748
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetNumberOfCellVars_26(HandleRef pThis);

		/// <summary>
		/// Get the number of data variables at the cell centers and points
		/// </summary>
		// Token: 0x06004555 RID: 17749 RVA: 0x00064FC8 File Offset: 0x000631C8
		public virtual int GetNumberOfCellVars()
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfCellVars_26(base.GetCppThis());
		}

		// Token: 0x06004556 RID: 17750
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMPASReader_GetNumberOfDimensions_27(HandleRef pThis);

		/// <summary>
		/// If the point/cell arrays contain dimensions other than Time, nCells, or
		/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
		/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
		/// retrieve the dimension names. GetDimensionSize returns the number of values
		/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
		/// to fix a given dimension at when extracting slices of data.
		/// </summary>
		// Token: 0x06004557 RID: 17751 RVA: 0x00064FE8 File Offset: 0x000631E8
		public long GetNumberOfDimensions()
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfDimensions_27(base.GetCppThis());
		}

		// Token: 0x06004558 RID: 17752
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMPASReader_GetNumberOfGenerationsFromBase_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004559 RID: 17753 RVA: 0x00065008 File Offset: 0x00063208
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfGenerationsFromBase_28(base.GetCppThis(), type);
		}

		// Token: 0x0600455A RID: 17754
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMPASReader_GetNumberOfGenerationsFromBaseType_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600455B RID: 17755 RVA: 0x00065028 File Offset: 0x00063228
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfGenerationsFromBaseType_29(type);
		}

		// Token: 0x0600455C RID: 17756
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetNumberOfPointArrays_30(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600455D RID: 17757 RVA: 0x00065044 File Offset: 0x00063244
		public int GetNumberOfPointArrays()
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfPointArrays_30(base.GetCppThis());
		}

		// Token: 0x0600455E RID: 17758
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetNumberOfPointVars_31(HandleRef pThis);

		/// <summary>
		/// Get the number of data variables at the cell centers and points
		/// </summary>
		// Token: 0x0600455F RID: 17759 RVA: 0x00065064 File Offset: 0x00063264
		public virtual int GetNumberOfPointVars()
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfPointVars_31(base.GetCppThis());
		}

		// Token: 0x06004560 RID: 17760
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetOutput_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output
		/// </summary>
		// Token: 0x06004561 RID: 17761 RVA: 0x00065084 File Offset: 0x00063284
		public new vtkUnstructuredGrid GetOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetOutput_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004562 RID: 17762
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetOutput_33(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output
		/// </summary>
		// Token: 0x06004563 RID: 17763 RVA: 0x000650F4 File Offset: 0x000632F4
		public new vtkUnstructuredGrid GetOutput(int idx)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetOutput_33(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004564 RID: 17764
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetPointArrayName_34(HandleRef pThis, int index);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004565 RID: 17765 RVA: 0x00065164 File Offset: 0x00063364
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkMPASReader.vtkMPASReader_GetPointArrayName_34(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004566 RID: 17766
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetPointArrayStatus_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004567 RID: 17767 RVA: 0x000651A0 File Offset: 0x000633A0
		public int GetPointArrayStatus(string name)
		{
			return vtkMPASReader.vtkMPASReader_GetPointArrayStatus_35(base.GetCppThis(), name);
		}

		// Token: 0x06004568 RID: 17768
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMPASReader_GetProjectLatLon_36(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004569 RID: 17769 RVA: 0x000651C0 File Offset: 0x000633C0
		public virtual bool GetProjectLatLon()
		{
			return vtkMPASReader.vtkMPASReader_GetProjectLatLon_36(base.GetCppThis()) != 0;
		}

		// Token: 0x0600456A RID: 17770
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMPASReader_GetShowMultilayerView_37(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x0600456B RID: 17771 RVA: 0x000651E8 File Offset: 0x000633E8
		public virtual bool GetShowMultilayerView()
		{
			return vtkMPASReader.vtkMPASReader_GetShowMultilayerView_37(base.GetCppThis()) != 0;
		}

		// Token: 0x0600456C RID: 17772
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMPASReader_GetUseDimensionedArrayNames_38(HandleRef pThis);

		/// <summary>
		/// If true, dimension info is included in the array name. For instance,
		/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
		/// This is useful for user-visible array selection, but is disabled by default
		/// for backwards compatibility.
		/// </summary>
		// Token: 0x0600456D RID: 17773 RVA: 0x00065210 File Offset: 0x00063410
		public virtual bool GetUseDimensionedArrayNames()
		{
			return vtkMPASReader.vtkMPASReader_GetUseDimensionedArrayNames_38(base.GetCppThis()) != 0;
		}

		// Token: 0x0600456E RID: 17774
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkMPASReader_GetVerticalDimension_39(HandleRef pThis);

		/// <summary>
		/// Get/Set the name to the dimension that identifies the vertical dimension.
		/// Defaults to "nVertLevels".
		/// </summary>
		// Token: 0x0600456F RID: 17775 RVA: 0x00065238 File Offset: 0x00063438
		public virtual string GetVerticalDimension()
		{
			return vtkMPASReader.vtkMPASReader_GetVerticalDimension_39(base.GetCppThis());
		}

		// Token: 0x06004570 RID: 17776
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_GetVerticalLevel_40(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004571 RID: 17777 RVA: 0x00065258 File Offset: 0x00063458
		public int GetVerticalLevel()
		{
			return vtkMPASReader.vtkMPASReader_GetVerticalLevel_40(base.GetCppThis());
		}

		// Token: 0x06004572 RID: 17778
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_GetVerticalLevelRange_41(HandleRef pThis);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004573 RID: 17779 RVA: 0x00065278 File Offset: 0x00063478
		public virtual int[] GetVerticalLevelRange()
		{
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetVerticalLevelRange_41(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004574 RID: 17780
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_GetVerticalLevelRange_42(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004575 RID: 17781 RVA: 0x000652C0 File Offset: 0x000634C0
		public virtual void GetVerticalLevelRange(ref int _arg1, ref int _arg2)
		{
			vtkMPASReader.vtkMPASReader_GetVerticalLevelRange_42(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06004576 RID: 17782
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_GetVerticalLevelRange_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004577 RID: 17783 RVA: 0x000652D1 File Offset: 0x000634D1
		public virtual void GetVerticalLevelRange(IntPtr _arg)
		{
			vtkMPASReader.vtkMPASReader_GetVerticalLevelRange_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06004578 RID: 17784
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_IsA_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004579 RID: 17785 RVA: 0x000652E4 File Offset: 0x000634E4
		public override int IsA(string type)
		{
			return vtkMPASReader.vtkMPASReader_IsA_44(base.GetCppThis(), type);
		}

		// Token: 0x0600457A RID: 17786
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMPASReader_IsTypeOf_45([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600457B RID: 17787 RVA: 0x00065304 File Offset: 0x00063504
		public new static int IsTypeOf(string type)
		{
			return vtkMPASReader.vtkMPASReader_IsTypeOf_45(type);
		}

		// Token: 0x0600457C RID: 17788
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600457D RID: 17789 RVA: 0x00065320 File Offset: 0x00063520
		public new vtkMPASReader NewInstance()
		{
			vtkMPASReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_NewInstance_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600457E RID: 17790
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMPASReader_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600457F RID: 17791 RVA: 0x0006537C File Offset: 0x0006357C
		public new static vtkMPASReader SafeDownCast(vtkObjectBase o)
		{
			vtkMPASReader vtkMPASReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMPASReader = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMPASReader.Register(null);
				}
			}
			return vtkMPASReader;
		}

		// Token: 0x06004580 RID: 17792
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetCellArrayStatus_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06004581 RID: 17793 RVA: 0x000653FB File Offset: 0x000635FB
		public void SetCellArrayStatus(string name, int status)
		{
			vtkMPASReader.vtkMPASReader_SetCellArrayStatus_49(base.GetCppThis(), name, status);
		}

		// Token: 0x06004582 RID: 17794
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetCenterLon_50(HandleRef pThis, int val);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004583 RID: 17795 RVA: 0x0006540C File Offset: 0x0006360C
		public void SetCenterLon(int val)
		{
			vtkMPASReader.vtkMPASReader_SetCenterLon_50(base.GetCppThis(), val);
		}

		// Token: 0x06004584 RID: 17796
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetDimensionCurrentIndex_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dim, int idx);

		/// <summary>
		/// If the point/cell arrays contain dimensions other than Time, nCells, or
		/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
		/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
		/// retrieve the dimension names. GetDimensionSize returns the number of values
		/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
		/// to fix a given dimension at when extracting slices of data.
		/// </summary>
		// Token: 0x06004585 RID: 17797 RVA: 0x0006541C File Offset: 0x0006361C
		public void SetDimensionCurrentIndex(string dim, int idx)
		{
			vtkMPASReader.vtkMPASReader_SetDimensionCurrentIndex_51(base.GetCppThis(), dim, idx);
		}

		// Token: 0x06004586 RID: 17798
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetFileName_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of MPAS data file to read.
		/// </summary>
		// Token: 0x06004587 RID: 17799 RVA: 0x0006542D File Offset: 0x0006362D
		public virtual void SetFileName(string _arg)
		{
			vtkMPASReader.vtkMPASReader_SetFileName_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06004588 RID: 17800
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetIsAtmosphere_53(HandleRef pThis, byte _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004589 RID: 17801 RVA: 0x0006543D File Offset: 0x0006363D
		public virtual void SetIsAtmosphere(bool _arg)
		{
			vtkMPASReader.vtkMPASReader_SetIsAtmosphere_53(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600458A RID: 17802
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetIsZeroCentered_54(HandleRef pThis, byte _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x0600458B RID: 17803 RVA: 0x00065455 File Offset: 0x00063655
		public virtual void SetIsZeroCentered(bool _arg)
		{
			vtkMPASReader.vtkMPASReader_SetIsZeroCentered_54(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600458C RID: 17804
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetLayerThickness_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x0600458D RID: 17805 RVA: 0x0006546D File Offset: 0x0006366D
		public virtual void SetLayerThickness(int _arg)
		{
			vtkMPASReader.vtkMPASReader_SetLayerThickness_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600458E RID: 17806
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetPointArrayStatus_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600458F RID: 17807 RVA: 0x0006547D File Offset: 0x0006367D
		public void SetPointArrayStatus(string name, int status)
		{
			vtkMPASReader.vtkMPASReader_SetPointArrayStatus_56(base.GetCppThis(), name, status);
		}

		// Token: 0x06004590 RID: 17808
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetProjectLatLon_57(HandleRef pThis, byte _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004591 RID: 17809 RVA: 0x0006548E File Offset: 0x0006368E
		public virtual void SetProjectLatLon(bool _arg)
		{
			vtkMPASReader.vtkMPASReader_SetProjectLatLon_57(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004592 RID: 17810
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetShowMultilayerView_58(HandleRef pThis, byte _arg);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004593 RID: 17811 RVA: 0x000654A6 File Offset: 0x000636A6
		public virtual void SetShowMultilayerView(bool _arg)
		{
			vtkMPASReader.vtkMPASReader_SetShowMultilayerView_58(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004594 RID: 17812
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetUseDimensionedArrayNames_59(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, dimension info is included in the array name. For instance,
		/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
		/// This is useful for user-visible array selection, but is disabled by default
		/// for backwards compatibility.
		/// </summary>
		// Token: 0x06004595 RID: 17813 RVA: 0x000654BE File Offset: 0x000636BE
		public virtual void SetUseDimensionedArrayNames(bool _arg)
		{
			vtkMPASReader.vtkMPASReader_SetUseDimensionedArrayNames_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004596 RID: 17814
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetVerticalDimension_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name to the dimension that identifies the vertical dimension.
		/// Defaults to "nVertLevels".
		/// </summary>
		// Token: 0x06004597 RID: 17815 RVA: 0x000654D6 File Offset: 0x000636D6
		public virtual void SetVerticalDimension(string _arg)
		{
			vtkMPASReader.vtkMPASReader_SetVerticalDimension_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06004598 RID: 17816
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_SetVerticalLevel_61(HandleRef pThis, int level);

		/// <summary>
		/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
		/// for the dimension returned by GetVerticalDimension.
		/// </summary>
		// Token: 0x06004599 RID: 17817 RVA: 0x000654E6 File Offset: 0x000636E6
		public void SetVerticalLevel(int level)
		{
			vtkMPASReader.vtkMPASReader_SetVerticalLevel_61(base.GetCppThis(), level);
		}

		// Token: 0x0600459A RID: 17818
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_UseDimensionedArrayNamesOff_62(HandleRef pThis);

		/// <summary>
		/// If true, dimension info is included in the array name. For instance,
		/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
		/// This is useful for user-visible array selection, but is disabled by default
		/// for backwards compatibility.
		/// </summary>
		// Token: 0x0600459B RID: 17819 RVA: 0x000654F6 File Offset: 0x000636F6
		public virtual void UseDimensionedArrayNamesOff()
		{
			vtkMPASReader.vtkMPASReader_UseDimensionedArrayNamesOff_62(base.GetCppThis());
		}

		// Token: 0x0600459C RID: 17820
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMPASReader_UseDimensionedArrayNamesOn_63(HandleRef pThis);

		/// <summary>
		/// If true, dimension info is included in the array name. For instance,
		/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
		/// This is useful for user-visible array selection, but is disabled by default
		/// for backwards compatibility.
		/// </summary>
		// Token: 0x0600459D RID: 17821 RVA: 0x00065505 File Offset: 0x00063705
		public virtual void UseDimensionedArrayNamesOn()
		{
			vtkMPASReader.vtkMPASReader_UseDimensionedArrayNamesOn_63(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000722 RID: 1826
		public new const string MRFullTypeName = "Kitware.VTK.vtkMPASReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000723 RID: 1827
		public new static readonly string MRClassNameKey = "class vtkMPASReader";
	}
}
