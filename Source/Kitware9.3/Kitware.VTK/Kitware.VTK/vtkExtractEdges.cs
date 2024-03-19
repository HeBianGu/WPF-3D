using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractEdges
	/// </summary>
	/// <remarks>
	///    extract cell edges from any type of dataset
	///
	/// vtkExtractEdges is a filter to extract edges from a dataset. Edges
	/// are extracted as lines in an output vtkPolyData.
	///
	/// There are two modes of extraction depending on the data member
	/// UseAllPoints, If UseAllPoints is enabled, then the output points contain
	/// all of the input points, and the point ids of the output lines (i.e.,
	/// edges) remain unchanged from the input point numbering.  If UseAllPoints
	/// is disabled (which is the default), then the numbering of the output points
	/// may change, and any unused points are omitted from the filter output.
	///
	/// @warning
	/// If present in the filter input, output cell data is produced for the
	/// output edges. Since an edge may be used by more than one cell, this is
	/// potentially an undefined behavior. To ensure deterministic output, the
	/// cell data from the cell with smallest cell id is copied to the output
	/// edge.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFeatureEdges
	/// </seealso>
	// Token: 0x02000965 RID: 2405
	public class vtkExtractEdges : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601902E RID: 102446 RVA: 0x0022E3B3 File Offset: 0x0022C5B3
		static vtkExtractEdges()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractEdges.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractEdges"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601902F RID: 102447 RVA: 0x0022E3DB File Offset: 0x0022C5DB
		public vtkExtractEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019030 RID: 102448
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019031 RID: 102449 RVA: 0x0022E3EC File Offset: 0x0022C5EC
		public new static vtkExtractEdges New()
		{
			vtkExtractEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEdges.vtkExtractEdges_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019032 RID: 102450 RVA: 0x0022E440 File Offset: 0x0022C640
		public vtkExtractEdges() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractEdges.vtkExtractEdges_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019033 RID: 102451 RVA: 0x0022E484 File Offset: 0x0022C684
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019034 RID: 102452
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEdges_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x06019035 RID: 102453 RVA: 0x0022E48F File Offset: 0x0022C68F
		public void CreateDefaultLocator()
		{
			vtkExtractEdges.vtkExtractEdges_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x06019036 RID: 102454
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEdges_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default an instance
		/// of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019037 RID: 102455 RVA: 0x0022E4A0 File Offset: 0x0022C6A0
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEdges.vtkExtractEdges_GetLocator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019038 RID: 102456
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExtractEdges_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Return the modified time also considering the locator since it may be
		/// modified independent of this filter.
		/// </summary>
		// Token: 0x06019039 RID: 102457 RVA: 0x0022E510 File Offset: 0x0022C710
		public override ulong GetMTime()
		{
			return vtkExtractEdges.vtkExtractEdges_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0601903A RID: 102458
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractEdges_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601903B RID: 102459 RVA: 0x0022E530 File Offset: 0x0022C730
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractEdges.vtkExtractEdges_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601903C RID: 102460
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractEdges_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601903D RID: 102461 RVA: 0x0022E550 File Offset: 0x0022C750
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractEdges.vtkExtractEdges_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601903E RID: 102462
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractEdges_GetUseAllPoints_06(HandleRef pThis);

		/// <summary>
		/// Indicates whether all of the points of the input mesh should exist in
		/// the output, i.e., whether point renumbering is permitted. By default,
		/// UseAllPoints is disabled, so that unused points are omitted from the
		/// output.
		/// </summary>
		// Token: 0x0601903F RID: 102463 RVA: 0x0022E56C File Offset: 0x0022C76C
		public virtual bool GetUseAllPoints()
		{
			return vtkExtractEdges.vtkExtractEdges_GetUseAllPoints_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06019040 RID: 102464
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractEdges_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019041 RID: 102465 RVA: 0x0022E594 File Offset: 0x0022C794
		public override int IsA(string type)
		{
			return vtkExtractEdges.vtkExtractEdges_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06019042 RID: 102466
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractEdges_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019043 RID: 102467 RVA: 0x0022E5B4 File Offset: 0x0022C7B4
		public new static int IsTypeOf(string type)
		{
			return vtkExtractEdges.vtkExtractEdges_IsTypeOf_08(type);
		}

		// Token: 0x06019044 RID: 102468
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEdges_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019045 RID: 102469 RVA: 0x0022E5D0 File Offset: 0x0022C7D0
		public new vtkExtractEdges NewInstance()
		{
			vtkExtractEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEdges.vtkExtractEdges_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019046 RID: 102470
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractEdges_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an instance.
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019047 RID: 102471 RVA: 0x0022E62C File Offset: 0x0022C82C
		public new static vtkExtractEdges SafeDownCast(vtkObjectBase o)
		{
			vtkExtractEdges vtkExtractEdges = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractEdges.vtkExtractEdges_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractEdges = (vtkExtractEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractEdges.Register(null);
				}
			}
			return vtkExtractEdges;
		}

		// Token: 0x06019048 RID: 102472
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEdges_SetLocator_12(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default an instance
		/// of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019049 RID: 102473 RVA: 0x0022E6AC File Offset: 0x0022C8AC
		public virtual void SetLocator(vtkIncrementalPointLocator _arg)
		{
			vtkExtractEdges.vtkExtractEdges_SetLocator_12(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601904A RID: 102474
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEdges_SetUseAllPoints_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicates whether all of the points of the input mesh should exist in
		/// the output, i.e., whether point renumbering is permitted. By default,
		/// UseAllPoints is disabled, so that unused points are omitted from the
		/// output.
		/// </summary>
		// Token: 0x0601904B RID: 102475 RVA: 0x0022E6DB File Offset: 0x0022C8DB
		public virtual void SetUseAllPoints(bool _arg)
		{
			vtkExtractEdges.vtkExtractEdges_SetUseAllPoints_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601904C RID: 102476
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEdges_UseAllPointsOff_14(HandleRef pThis);

		/// <summary>
		/// Indicates whether all of the points of the input mesh should exist in
		/// the output, i.e., whether point renumbering is permitted. By default,
		/// UseAllPoints is disabled, so that unused points are omitted from the
		/// output.
		/// </summary>
		// Token: 0x0601904D RID: 102477 RVA: 0x0022E6F3 File Offset: 0x0022C8F3
		public virtual void UseAllPointsOff()
		{
			vtkExtractEdges.vtkExtractEdges_UseAllPointsOff_14(base.GetCppThis());
		}

		// Token: 0x0601904E RID: 102478
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractEdges_UseAllPointsOn_15(HandleRef pThis);

		/// <summary>
		/// Indicates whether all of the points of the input mesh should exist in
		/// the output, i.e., whether point renumbering is permitted. By default,
		/// UseAllPoints is disabled, so that unused points are omitted from the
		/// output.
		/// </summary>
		// Token: 0x0601904F RID: 102479 RVA: 0x0022E702 File Offset: 0x0022C902
		public virtual void UseAllPointsOn()
		{
			vtkExtractEdges.vtkExtractEdges_UseAllPointsOn_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B83 RID: 7043
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractEdges";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B84 RID: 7044
		public new static readonly string MRClassNameKey = "class vtkExtractEdges";
	}
}
