using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSortFileNames
	/// </summary>
	/// <remarks>
	///    Group and sort a set of filenames
	///
	/// vtkSortFileNames will take a list of filenames (e.g. from
	/// a file load dialog) and sort them into one or more series.  If
	/// the input list of filenames contains any directories, these can
	/// be removed before sorting using the SkipDirectories flag.  This
	/// class should be used where information about the series groupings
	/// can be determined by the filenames, but it might not be successful
	/// in cases where the information about the series groupings is
	/// stored in the files themselves (e.g DICOM).
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReader2
	/// </seealso>
	// Token: 0x02000732 RID: 1842
	public class vtkSortFileNames : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013355 RID: 78677 RVA: 0x001B2927 File Offset: 0x001B0B27
		static vtkSortFileNames()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSortFileNames.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortFileNames"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013356 RID: 78678 RVA: 0x001B294F File Offset: 0x001B0B4F
		public vtkSortFileNames(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013357 RID: 78679
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFileNames_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013358 RID: 78680 RVA: 0x001B2960 File Offset: 0x001B0B60
		public new static vtkSortFileNames New()
		{
			vtkSortFileNames result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013359 RID: 78681 RVA: 0x001B29B4 File Offset: 0x001B0BB4
		public vtkSortFileNames() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSortFileNames.vtkSortFileNames_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601335A RID: 78682 RVA: 0x001B29F8 File Offset: 0x001B0BF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601335B RID: 78683
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFileNames_GetFileNames_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the full list of sorted filenames.
		/// </summary>
		// Token: 0x0601335C RID: 78684 RVA: 0x001B2A04 File Offset: 0x001B0C04
		public virtual vtkStringArray GetFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_GetFileNames_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601335D RID: 78685
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFileNames_GetGrouping_02(HandleRef pThis);

		/// <summary>
		/// Sort the file names into groups, according to similarity in
		/// filename name and path.  Files in different directories,
		/// or with different extensions, or which do not fit into the same
		/// numbered series will be placed into different groups.  This is
		/// off by default.
		/// </summary>
		// Token: 0x0601335E RID: 78686 RVA: 0x001B2A74 File Offset: 0x001B0C74
		public virtual int GetGrouping()
		{
			return vtkSortFileNames.vtkSortFileNames_GetGrouping_02(base.GetCppThis());
		}

		// Token: 0x0601335F RID: 78687
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFileNames_GetIgnoreCase_03(HandleRef pThis);

		/// <summary>
		/// Ignore case when sorting.  This flag is honored by both
		/// the sorting and the grouping. This is off by default.
		/// </summary>
		// Token: 0x06013360 RID: 78688 RVA: 0x001B2A94 File Offset: 0x001B0C94
		public virtual int GetIgnoreCase()
		{
			return vtkSortFileNames.vtkSortFileNames_GetIgnoreCase_03(base.GetCppThis());
		}

		// Token: 0x06013361 RID: 78689
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFileNames_GetInputFileNames_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a list of file names to group and sort.
		/// </summary>
		// Token: 0x06013362 RID: 78690 RVA: 0x001B2AB4 File Offset: 0x001B0CB4
		public virtual vtkStringArray GetInputFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_GetInputFileNames_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013363 RID: 78691
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFileNames_GetNthGroup_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the Nth group of file names.  This method should only
		/// be used if grouping is on.  If grouping is off, it will always
		/// return null.
		/// </summary>
		// Token: 0x06013364 RID: 78692 RVA: 0x001B2B24 File Offset: 0x001B0D24
		public virtual vtkStringArray GetNthGroup(int i)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_GetNthGroup_05(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013365 RID: 78693
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSortFileNames_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013366 RID: 78694 RVA: 0x001B2B94 File Offset: 0x001B0D94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSortFileNames.vtkSortFileNames_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06013367 RID: 78695
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSortFileNames_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013368 RID: 78696 RVA: 0x001B2BB4 File Offset: 0x001B0DB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSortFileNames.vtkSortFileNames_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06013369 RID: 78697
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFileNames_GetNumberOfGroups_08(HandleRef pThis);

		/// <summary>
		/// Get the number of groups that the names were split into, if
		/// grouping is on.  The filenames are automatically split into
		/// groups, where the filenames in each group will be identical
		/// except for their series numbers.  If grouping is not on, this
		/// method will return zero.
		/// </summary>
		// Token: 0x0601336A RID: 78698 RVA: 0x001B2BD0 File Offset: 0x001B0DD0
		public virtual int GetNumberOfGroups()
		{
			return vtkSortFileNames.vtkSortFileNames_GetNumberOfGroups_08(base.GetCppThis());
		}

		// Token: 0x0601336B RID: 78699
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFileNames_GetNumericSort_09(HandleRef pThis);

		/// <summary>
		/// Sort the files numerically, rather than lexicographically.
		/// For filenames that contain numbers, this means the order will be
		/// ["file8.dat", "file9.dat", "file10.dat"]
		/// instead of the usual alphabetic sorting order
		/// ["file10.dat" "file8.dat", "file9.dat"].
		/// NumericSort is off by default.
		/// </summary>
		// Token: 0x0601336C RID: 78700 RVA: 0x001B2BF0 File Offset: 0x001B0DF0
		public virtual int GetNumericSort()
		{
			return vtkSortFileNames.vtkSortFileNames_GetNumericSort_09(base.GetCppThis());
		}

		// Token: 0x0601336D RID: 78701
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFileNames_GetSkipDirectories_10(HandleRef pThis);

		/// <summary>
		/// Skip directories. If this flag is set, any input item that
		/// is a directory rather than a file will not be included in
		/// the output.  This is off by default.
		/// </summary>
		// Token: 0x0601336E RID: 78702 RVA: 0x001B2C10 File Offset: 0x001B0E10
		public virtual int GetSkipDirectories()
		{
			return vtkSortFileNames.vtkSortFileNames_GetSkipDirectories_10(base.GetCppThis());
		}

		// Token: 0x0601336F RID: 78703
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_GroupingOff_11(HandleRef pThis);

		/// <summary>
		/// Sort the file names into groups, according to similarity in
		/// filename name and path.  Files in different directories,
		/// or with different extensions, or which do not fit into the same
		/// numbered series will be placed into different groups.  This is
		/// off by default.
		/// </summary>
		// Token: 0x06013370 RID: 78704 RVA: 0x001B2C2F File Offset: 0x001B0E2F
		public virtual void GroupingOff()
		{
			vtkSortFileNames.vtkSortFileNames_GroupingOff_11(base.GetCppThis());
		}

		// Token: 0x06013371 RID: 78705
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_GroupingOn_12(HandleRef pThis);

		/// <summary>
		/// Sort the file names into groups, according to similarity in
		/// filename name and path.  Files in different directories,
		/// or with different extensions, or which do not fit into the same
		/// numbered series will be placed into different groups.  This is
		/// off by default.
		/// </summary>
		// Token: 0x06013372 RID: 78706 RVA: 0x001B2C3E File Offset: 0x001B0E3E
		public virtual void GroupingOn()
		{
			vtkSortFileNames.vtkSortFileNames_GroupingOn_12(base.GetCppThis());
		}

		// Token: 0x06013373 RID: 78707
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_IgnoreCaseOff_13(HandleRef pThis);

		/// <summary>
		/// Ignore case when sorting.  This flag is honored by both
		/// the sorting and the grouping. This is off by default.
		/// </summary>
		// Token: 0x06013374 RID: 78708 RVA: 0x001B2C4D File Offset: 0x001B0E4D
		public virtual void IgnoreCaseOff()
		{
			vtkSortFileNames.vtkSortFileNames_IgnoreCaseOff_13(base.GetCppThis());
		}

		// Token: 0x06013375 RID: 78709
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_IgnoreCaseOn_14(HandleRef pThis);

		/// <summary>
		/// Ignore case when sorting.  This flag is honored by both
		/// the sorting and the grouping. This is off by default.
		/// </summary>
		// Token: 0x06013376 RID: 78710 RVA: 0x001B2C5C File Offset: 0x001B0E5C
		public virtual void IgnoreCaseOn()
		{
			vtkSortFileNames.vtkSortFileNames_IgnoreCaseOn_14(base.GetCppThis());
		}

		// Token: 0x06013377 RID: 78711
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFileNames_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013378 RID: 78712 RVA: 0x001B2C6C File Offset: 0x001B0E6C
		public override int IsA(string type)
		{
			return vtkSortFileNames.vtkSortFileNames_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06013379 RID: 78713
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFileNames_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601337A RID: 78714 RVA: 0x001B2C8C File Offset: 0x001B0E8C
		public new static int IsTypeOf(string type)
		{
			return vtkSortFileNames.vtkSortFileNames_IsTypeOf_16(type);
		}

		// Token: 0x0601337B RID: 78715
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFileNames_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601337C RID: 78716 RVA: 0x001B2CA8 File Offset: 0x001B0EA8
		public new vtkSortFileNames NewInstance()
		{
			vtkSortFileNames result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601337D RID: 78717
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_NumericSortOff_19(HandleRef pThis);

		/// <summary>
		/// Sort the files numerically, rather than lexicographically.
		/// For filenames that contain numbers, this means the order will be
		/// ["file8.dat", "file9.dat", "file10.dat"]
		/// instead of the usual alphabetic sorting order
		/// ["file10.dat" "file8.dat", "file9.dat"].
		/// NumericSort is off by default.
		/// </summary>
		// Token: 0x0601337E RID: 78718 RVA: 0x001B2D02 File Offset: 0x001B0F02
		public virtual void NumericSortOff()
		{
			vtkSortFileNames.vtkSortFileNames_NumericSortOff_19(base.GetCppThis());
		}

		// Token: 0x0601337F RID: 78719
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_NumericSortOn_20(HandleRef pThis);

		/// <summary>
		/// Sort the files numerically, rather than lexicographically.
		/// For filenames that contain numbers, this means the order will be
		/// ["file8.dat", "file9.dat", "file10.dat"]
		/// instead of the usual alphabetic sorting order
		/// ["file10.dat" "file8.dat", "file9.dat"].
		/// NumericSort is off by default.
		/// </summary>
		// Token: 0x06013380 RID: 78720 RVA: 0x001B2D11 File Offset: 0x001B0F11
		public virtual void NumericSortOn()
		{
			vtkSortFileNames.vtkSortFileNames_NumericSortOn_20(base.GetCppThis());
		}

		// Token: 0x06013381 RID: 78721
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFileNames_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013382 RID: 78722 RVA: 0x001B2D20 File Offset: 0x001B0F20
		public new static vtkSortFileNames SafeDownCast(vtkObjectBase o)
		{
			vtkSortFileNames vtkSortFileNames = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSortFileNames = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSortFileNames.Register(null);
				}
			}
			return vtkSortFileNames;
		}

		// Token: 0x06013383 RID: 78723
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_SetGrouping_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Sort the file names into groups, according to similarity in
		/// filename name and path.  Files in different directories,
		/// or with different extensions, or which do not fit into the same
		/// numbered series will be placed into different groups.  This is
		/// off by default.
		/// </summary>
		// Token: 0x06013384 RID: 78724 RVA: 0x001B2D9F File Offset: 0x001B0F9F
		public virtual void SetGrouping(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetGrouping_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06013385 RID: 78725
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_SetIgnoreCase_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Ignore case when sorting.  This flag is honored by both
		/// the sorting and the grouping. This is off by default.
		/// </summary>
		// Token: 0x06013386 RID: 78726 RVA: 0x001B2DAF File Offset: 0x001B0FAF
		public virtual void SetIgnoreCase(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetIgnoreCase_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06013387 RID: 78727
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_SetInputFileNames_24(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set a list of file names to group and sort.
		/// </summary>
		// Token: 0x06013388 RID: 78728 RVA: 0x001B2DC0 File Offset: 0x001B0FC0
		public void SetInputFileNames(vtkStringArray input)
		{
			vtkSortFileNames.vtkSortFileNames_SetInputFileNames_24(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06013389 RID: 78729
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_SetNumericSort_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Sort the files numerically, rather than lexicographically.
		/// For filenames that contain numbers, this means the order will be
		/// ["file8.dat", "file9.dat", "file10.dat"]
		/// instead of the usual alphabetic sorting order
		/// ["file10.dat" "file8.dat", "file9.dat"].
		/// NumericSort is off by default.
		/// </summary>
		// Token: 0x0601338A RID: 78730 RVA: 0x001B2DEF File Offset: 0x001B0FEF
		public virtual void SetNumericSort(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetNumericSort_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601338B RID: 78731
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_SetSkipDirectories_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Skip directories. If this flag is set, any input item that
		/// is a directory rather than a file will not be included in
		/// the output.  This is off by default.
		/// </summary>
		// Token: 0x0601338C RID: 78732 RVA: 0x001B2DFF File Offset: 0x001B0FFF
		public virtual void SetSkipDirectories(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetSkipDirectories_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601338D RID: 78733
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_SkipDirectoriesOff_27(HandleRef pThis);

		/// <summary>
		/// Skip directories. If this flag is set, any input item that
		/// is a directory rather than a file will not be included in
		/// the output.  This is off by default.
		/// </summary>
		// Token: 0x0601338E RID: 78734 RVA: 0x001B2E0F File Offset: 0x001B100F
		public virtual void SkipDirectoriesOff()
		{
			vtkSortFileNames.vtkSortFileNames_SkipDirectoriesOff_27(base.GetCppThis());
		}

		// Token: 0x0601338F RID: 78735
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_SkipDirectoriesOn_28(HandleRef pThis);

		/// <summary>
		/// Skip directories. If this flag is set, any input item that
		/// is a directory rather than a file will not be included in
		/// the output.  This is off by default.
		/// </summary>
		// Token: 0x06013390 RID: 78736 RVA: 0x001B2E1E File Offset: 0x001B101E
		public virtual void SkipDirectoriesOn()
		{
			vtkSortFileNames.vtkSortFileNames_SkipDirectoriesOn_28(base.GetCppThis());
		}

		// Token: 0x06013391 RID: 78737
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortFileNames_Update_29(HandleRef pThis);

		/// <summary>
		/// Update the output filenames from the input filenames.
		/// This method is called automatically by GetFileNames()
		/// and GetNumberOfGroups() if the input names have changed.
		/// </summary>
		// Token: 0x06013392 RID: 78738 RVA: 0x001B2E2D File Offset: 0x001B102D
		public virtual void Update()
		{
			vtkSortFileNames.vtkSortFileNames_Update_29(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001632 RID: 5682
		public new const string MRFullTypeName = "Kitware.VTK.vtkSortFileNames";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001633 RID: 5683
		public new static readonly string MRClassNameKey = "class vtkSortFileNames";
	}
}
