using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpatialRepresentationFilter
	/// </summary>
	/// <remarks>
	///    generate polygonal model of spatial search object (i.e., a vtkLocator)
	///
	/// vtkSpatialRepresentationFilter generates an polygonal representation of a
	/// spatial search (vtkLocator) object. The representation varies depending
	/// upon the nature of the spatial search object. For example, the
	/// representation for vtkOBBTree is a collection of oriented bounding
	/// boxes. This input to this filter is a dataset of any type, and the output
	/// is polygonal data. You must also specify the spatial search object to
	/// use.
	///
	/// Generally spatial search objects are used for collision detection and
	/// other geometric operations, but in this filter one or more levels of
	/// spatial searchers can be generated to form a geometric approximation to
	/// the input data. This is a form of data simplification, generally used to
	/// accelerate the rendering process. Or, this filter can be used as a
	/// debugging/ visualization aid for spatial search objects.
	///
	/// This filter can generate one or more  vtkPolyData blocks corresponding to
	/// different levels in the spatial search tree. The block ids range from 0
	/// (root level) to MaximumLevel. Note that the block for level "id" is not computed
	/// unless a AddLevel(id) method is issued. Thus, if you desire three levels of output
	/// (say 2,4,7), you would have to invoke AddLevel(2), AddLevel(4), and
	/// AddLevel(7). If GenerateLeaves is set to true (off by default), all leaf nodes
	/// of the locator (which may be at different levels) are computed and stored in
	/// block with id MaximumLevel + 1.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLocator vtkPointLocator vtkCellLocator vtkOBBTree
	/// </seealso>
	// Token: 0x020008DE RID: 2270
	public class vtkSpatialRepresentationFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017747 RID: 96071 RVA: 0x0020E897 File Offset: 0x0020CA97
		static vtkSpatialRepresentationFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpatialRepresentationFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpatialRepresentationFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017748 RID: 96072 RVA: 0x0020E8BF File Offset: 0x0020CABF
		public vtkSpatialRepresentationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017749 RID: 96073
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatialRepresentationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601774A RID: 96074 RVA: 0x0020E8D0 File Offset: 0x0020CAD0
		public new static vtkSpatialRepresentationFilter New()
		{
			vtkSpatialRepresentationFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601774B RID: 96075 RVA: 0x0020E924 File Offset: 0x0020CB24
		public vtkSpatialRepresentationFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601774C RID: 96076 RVA: 0x0020E968 File Offset: 0x0020CB68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601774D RID: 96077
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatialRepresentationFilter_AddLevel_01(HandleRef pThis, int level);

		/// <summary>
		/// Add a level to be computed.
		/// </summary>
		// Token: 0x0601774E RID: 96078 RVA: 0x0020E973 File Offset: 0x0020CB73
		public void AddLevel(int level)
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_AddLevel_01(base.GetCppThis(), level);
		}

		// Token: 0x0601774F RID: 96079
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatialRepresentationFilter_GenerateLeavesOff_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of leaf nodes. Off by default.
		/// </summary>
		// Token: 0x06017750 RID: 96080 RVA: 0x0020E983 File Offset: 0x0020CB83
		public virtual void GenerateLeavesOff()
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GenerateLeavesOff_02(base.GetCppThis());
		}

		// Token: 0x06017751 RID: 96081
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatialRepresentationFilter_GenerateLeavesOn_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of leaf nodes. Off by default.
		/// </summary>
		// Token: 0x06017752 RID: 96082 RVA: 0x0020E992 File Offset: 0x0020CB92
		public virtual void GenerateLeavesOn()
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GenerateLeavesOn_03(base.GetCppThis());
		}

		// Token: 0x06017753 RID: 96083
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSpatialRepresentationFilter_GetGenerateLeaves_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of leaf nodes. Off by default.
		/// </summary>
		// Token: 0x06017754 RID: 96084 RVA: 0x0020E9A4 File Offset: 0x0020CBA4
		public virtual bool GetGenerateLeaves()
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetGenerateLeaves_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06017755 RID: 96085
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpatialRepresentationFilter_GetMaximumLevel_05(HandleRef pThis);

		/// <summary>
		/// Get the maximum level that is available. Populated during
		/// RequestData().
		/// </summary>
		// Token: 0x06017756 RID: 96086 RVA: 0x0020E9CC File Offset: 0x0020CBCC
		public virtual int GetMaximumLevel()
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetMaximumLevel_05(base.GetCppThis());
		}

		// Token: 0x06017757 RID: 96087
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017758 RID: 96088 RVA: 0x0020E9EC File Offset: 0x0020CBEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06017759 RID: 96089
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601775A RID: 96090 RVA: 0x0020EA0C File Offset: 0x0020CC0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601775B RID: 96091
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatialRepresentationFilter_GetSpatialRepresentation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the locator that will be used to generate the representation.
		/// </summary>
		// Token: 0x0601775C RID: 96092 RVA: 0x0020EA28 File Offset: 0x0020CC28
		public virtual vtkLocator GetSpatialRepresentation()
		{
			vtkLocator vtkLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetSpatialRepresentation_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLocator = (vtkLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLocator.Register(null);
				}
			}
			return vtkLocator;
		}

		// Token: 0x0601775D RID: 96093
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpatialRepresentationFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601775E RID: 96094 RVA: 0x0020EA98 File Offset: 0x0020CC98
		public override int IsA(string type)
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601775F RID: 96095
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpatialRepresentationFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017760 RID: 96096 RVA: 0x0020EAB8 File Offset: 0x0020CCB8
		public new static int IsTypeOf(string type)
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_IsTypeOf_10(type);
		}

		// Token: 0x06017761 RID: 96097
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatialRepresentationFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017762 RID: 96098 RVA: 0x0020EAD4 File Offset: 0x0020CCD4
		public new vtkSpatialRepresentationFilter NewInstance()
		{
			vtkSpatialRepresentationFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017763 RID: 96099
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatialRepresentationFilter_ResetLevels_13(HandleRef pThis);

		/// <summary>
		/// Remove all levels.
		/// </summary>
		// Token: 0x06017764 RID: 96100 RVA: 0x0020EB2E File Offset: 0x0020CD2E
		public void ResetLevels()
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_ResetLevels_13(base.GetCppThis());
		}

		// Token: 0x06017765 RID: 96101
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpatialRepresentationFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017766 RID: 96102 RVA: 0x0020EB40 File Offset: 0x0020CD40
		public new static vtkSpatialRepresentationFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSpatialRepresentationFilter vtkSpatialRepresentationFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpatialRepresentationFilter = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpatialRepresentationFilter.Register(null);
				}
			}
			return vtkSpatialRepresentationFilter;
		}

		// Token: 0x06017767 RID: 96103
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatialRepresentationFilter_SetGenerateLeaves_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the generation of leaf nodes. Off by default.
		/// </summary>
		// Token: 0x06017768 RID: 96104 RVA: 0x0020EBBF File Offset: 0x0020CDBF
		public virtual void SetGenerateLeaves(bool _arg)
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_SetGenerateLeaves_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017769 RID: 96105
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpatialRepresentationFilter_SetSpatialRepresentation_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the locator that will be used to generate the representation.
		/// </summary>
		// Token: 0x0601776A RID: 96106 RVA: 0x0020EBD8 File Offset: 0x0020CDD8
		public virtual void SetSpatialRepresentation(vtkLocator arg0)
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_SetSpatialRepresentation_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A31 RID: 6705
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpatialRepresentationFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A32 RID: 6706
		public new static readonly string MRClassNameKey = "class vtkSpatialRepresentationFilter";
	}
}
