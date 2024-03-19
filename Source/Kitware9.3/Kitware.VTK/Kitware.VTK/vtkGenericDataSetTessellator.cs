using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericDataSetTessellator
	/// </summary>
	/// <remarks>
	///    tessellates generic, higher-order datasets into linear cells
	///
	///
	/// vtkGenericDataSetTessellator is a filter that subdivides a
	/// vtkGenericDataSet into linear elements (i.e., linear VTK
	/// cells). Tetrahedras are produced from 3D cells; triangles from 2D cells;
	/// and lines from 1D cells. The subdivision process depends on the cell
	/// tessellator associated with the input generic dataset, and its associated
	/// error metric. (These can be specified by the user if necessary.)
	///
	/// This filter is typically used to convert a higher-order, complex dataset
	/// represented by a vtkGenericDataSet into a conventional vtkDataSet that can
	/// be operated on by linear VTK graphics filters (end of pipeline for
	/// rendering).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
	/// </seealso>
	// Token: 0x0200049B RID: 1179
	public class vtkGenericDataSetTessellator : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D90E RID: 55566 RVA: 0x0012D960 File Offset: 0x0012BB60
		static vtkGenericDataSetTessellator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericDataSetTessellator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataSetTessellator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D90F RID: 55567 RVA: 0x0012D988 File Offset: 0x0012BB88
		public vtkGenericDataSetTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D910 RID: 55568
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSetTessellator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D911 RID: 55569 RVA: 0x0012D998 File Offset: 0x0012BB98
		public new static vtkGenericDataSetTessellator New()
		{
			vtkGenericDataSetTessellator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D912 RID: 55570 RVA: 0x0012D9EC File Offset: 0x0012BBEC
		public vtkGenericDataSetTessellator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D913 RID: 55571 RVA: 0x0012DA30 File Offset: 0x0012BC30
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D914 RID: 55572
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x0600D915 RID: 55573 RVA: 0x0012DA3B File Offset: 0x0012BC3B
		public void CreateDefaultLocator()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x0600D916 RID: 55574
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSetTessellator_GetKeepCellIds_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off generation of a cell centered attribute with ids of the
		/// original cells (as an input cell is tessellated into several linear
		/// cells).
		/// The name of the data array is "OriginalIds". It is true by default.
		/// </summary>
		// Token: 0x0600D917 RID: 55575 RVA: 0x0012DA4C File Offset: 0x0012BC4C
		public virtual int GetKeepCellIds()
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetKeepCellIds_02(base.GetCppThis());
		}

		// Token: 0x0600D918 RID: 55576
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSetTessellator_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D919 RID: 55577 RVA: 0x0012DA6C File Offset: 0x0012BC6C
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetLocator_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0600D91A RID: 55578
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGenericDataSetTessellator_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the locator.
		/// </summary>
		// Token: 0x0600D91B RID: 55579 RVA: 0x0012DADC File Offset: 0x0012BCDC
		public override ulong GetMTime()
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x0600D91C RID: 55580
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSetTessellator_GetMerging_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D91D RID: 55581 RVA: 0x0012DAFC File Offset: 0x0012BCFC
		public virtual int GetMerging()
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetMerging_05(base.GetCppThis());
		}

		// Token: 0x0600D91E RID: 55582
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D91F RID: 55583 RVA: 0x0012DB1C File Offset: 0x0012BD1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600D920 RID: 55584
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D921 RID: 55585 RVA: 0x0012DB3C File Offset: 0x0012BD3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600D922 RID: 55586
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSetTessellator_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D923 RID: 55587 RVA: 0x0012DB58 File Offset: 0x0012BD58
		public override int IsA(string type)
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600D924 RID: 55588
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSetTessellator_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D925 RID: 55589 RVA: 0x0012DB78 File Offset: 0x0012BD78
		public new static int IsTypeOf(string type)
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_IsTypeOf_09(type);
		}

		// Token: 0x0600D926 RID: 55590
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_KeepCellIdsOff_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off generation of a cell centered attribute with ids of the
		/// original cells (as an input cell is tessellated into several linear
		/// cells).
		/// The name of the data array is "OriginalIds". It is true by default.
		/// </summary>
		// Token: 0x0600D927 RID: 55591 RVA: 0x0012DB92 File Offset: 0x0012BD92
		public virtual void KeepCellIdsOff()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_KeepCellIdsOff_10(base.GetCppThis());
		}

		// Token: 0x0600D928 RID: 55592
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_KeepCellIdsOn_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off generation of a cell centered attribute with ids of the
		/// original cells (as an input cell is tessellated into several linear
		/// cells).
		/// The name of the data array is "OriginalIds". It is true by default.
		/// </summary>
		// Token: 0x0600D929 RID: 55593 RVA: 0x0012DBA1 File Offset: 0x0012BDA1
		public virtual void KeepCellIdsOn()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_KeepCellIdsOn_11(base.GetCppThis());
		}

		// Token: 0x0600D92A RID: 55594
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_MergingOff_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D92B RID: 55595 RVA: 0x0012DBB0 File Offset: 0x0012BDB0
		public virtual void MergingOff()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_MergingOff_12(base.GetCppThis());
		}

		// Token: 0x0600D92C RID: 55596
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_MergingOn_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D92D RID: 55597 RVA: 0x0012DBBF File Offset: 0x0012BDBF
		public virtual void MergingOn()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_MergingOn_13(base.GetCppThis());
		}

		// Token: 0x0600D92E RID: 55598
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSetTessellator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D92F RID: 55599 RVA: 0x0012DBD0 File Offset: 0x0012BDD0
		public new vtkGenericDataSetTessellator NewInstance()
		{
			vtkGenericDataSetTessellator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D930 RID: 55600
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSetTessellator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600D931 RID: 55601 RVA: 0x0012DC2C File Offset: 0x0012BE2C
		public new static vtkGenericDataSetTessellator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericDataSetTessellator vtkGenericDataSetTessellator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSetTessellator = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSetTessellator.Register(null);
				}
			}
			return vtkGenericDataSetTessellator;
		}

		// Token: 0x0600D932 RID: 55602
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_SetKeepCellIds_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off generation of a cell centered attribute with ids of the
		/// original cells (as an input cell is tessellated into several linear
		/// cells).
		/// The name of the data array is "OriginalIds". It is true by default.
		/// </summary>
		// Token: 0x0600D933 RID: 55603 RVA: 0x0012DCAB File Offset: 0x0012BEAB
		public virtual void SetKeepCellIds(int _arg)
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SetKeepCellIds_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D934 RID: 55604
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_SetLocator_18(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D935 RID: 55605 RVA: 0x0012DCBC File Offset: 0x0012BEBC
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SetLocator_18(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D936 RID: 55606
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSetTessellator_SetMerging_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D937 RID: 55607 RVA: 0x0012DCEB File Offset: 0x0012BEEB
		public virtual void SetMerging(int _arg)
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SetMerging_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FDE RID: 4062
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataSetTessellator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FDF RID: 4063
		public new static readonly string MRClassNameKey = "class vtkGenericDataSetTessellator";
	}
}
