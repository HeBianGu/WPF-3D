using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAnnotationLink
	/// </summary>
	/// <remarks>
	///    An algorithm for linking annotations among objects
	///
	/// vtkAnnotationLink is a simple source filter which outputs the
	/// vtkAnnotationLayers object stored internally.  Multiple objects may share
	/// the same annotation link filter and connect it to an internal pipeline so
	/// that if one object changes the annotation set, it will be pulled into all
	/// the other objects when their pipelines update.
	///
	/// The shared vtkAnnotationLayers object (a collection of annotations) is
	/// shallow copied to output port 0.
	///
	/// vtkAnnotationLink can also store a set of domain maps. A domain map is
	/// simply a table associating values between domains. The domain of each
	/// column is defined by the array name of the column. The domain maps are
	/// sent to a multi-block dataset in output port 1.
	///
	/// Output ports 0 and 1 can be set as input ports 0 and 1 to
	/// vtkConvertSelectionDomain, which can use the domain maps to convert the
	/// domains of selections in the vtkAnnotationLayers to match a particular
	/// data object (set as port 2 on vtkConvertSelectionDomain).
	///
	/// The shared vtkAnnotationLayers object also stores a "current selection"
	/// normally interpreted as the interactive selection of an application.
	/// As a convenience, this selection is sent to output port 2 so that it
	/// can be connected to pipelines requiring a vtkSelection.
	/// </remarks>
	// Token: 0x0200086F RID: 2159
	public class vtkAnnotationLink : vtkAnnotationLayersAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060166B2 RID: 91826 RVA: 0x001F844C File Offset: 0x001F664C
		static vtkAnnotationLink()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotationLink.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotationLink"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060166B3 RID: 91827 RVA: 0x001F8474 File Offset: 0x001F6674
		public vtkAnnotationLink(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060166B4 RID: 91828
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLink_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166B5 RID: 91829 RVA: 0x001F8484 File Offset: 0x001F6684
		public new static vtkAnnotationLink New()
		{
			vtkAnnotationLink result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166B6 RID: 91830 RVA: 0x001F84D8 File Offset: 0x001F66D8
		public vtkAnnotationLink() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnnotationLink.vtkAnnotationLink_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060166B7 RID: 91831 RVA: 0x001F851C File Offset: 0x001F671C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060166B8 RID: 91832
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLink_AddDomainMap_01(HandleRef pThis, HandleRef map);

		/// <summary>
		/// The domain mappings.
		/// </summary>
		// Token: 0x060166B9 RID: 91833 RVA: 0x001F8528 File Offset: 0x001F6728
		public void AddDomainMap(vtkTable map)
		{
			vtkAnnotationLink.vtkAnnotationLink_AddDomainMap_01(base.GetCppThis(), (map == null) ? default(HandleRef) : map.GetCppThis());
		}

		// Token: 0x060166BA RID: 91834
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLink_GetAnnotationLayers_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The annotations to be shared.
		/// </summary>
		// Token: 0x060166BB RID: 91835 RVA: 0x001F8558 File Offset: 0x001F6758
		public virtual vtkAnnotationLayers GetAnnotationLayers()
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_GetAnnotationLayers_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		// Token: 0x060166BC RID: 91836
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLink_GetCurrentSelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set or get the current selection in the annotation layers.
		/// </summary>
		// Token: 0x060166BD RID: 91837 RVA: 0x001F85C8 File Offset: 0x001F67C8
		public virtual vtkSelection GetCurrentSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_GetCurrentSelection_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x060166BE RID: 91838
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLink_GetDomainMap_04(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The domain mappings.
		/// </summary>
		// Token: 0x060166BF RID: 91839 RVA: 0x001F8638 File Offset: 0x001F6838
		public vtkTable GetDomainMap(int i)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_GetDomainMap_04(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060166C0 RID: 91840
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAnnotationLink_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Get the mtime of this object.
		/// </summary>
		// Token: 0x060166C1 RID: 91841 RVA: 0x001F86A8 File Offset: 0x001F68A8
		public override ulong GetMTime()
		{
			return vtkAnnotationLink.vtkAnnotationLink_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x060166C2 RID: 91842
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLink_GetNumberOfDomainMaps_06(HandleRef pThis);

		/// <summary>
		/// The domain mappings.
		/// </summary>
		// Token: 0x060166C3 RID: 91843 RVA: 0x001F86C8 File Offset: 0x001F68C8
		public int GetNumberOfDomainMaps()
		{
			return vtkAnnotationLink.vtkAnnotationLink_GetNumberOfDomainMaps_06(base.GetCppThis());
		}

		// Token: 0x060166C4 RID: 91844
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotationLink_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166C5 RID: 91845 RVA: 0x001F86E8 File Offset: 0x001F68E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnnotationLink.vtkAnnotationLink_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060166C6 RID: 91846
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotationLink_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166C7 RID: 91847 RVA: 0x001F8708 File Offset: 0x001F6908
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnnotationLink.vtkAnnotationLink_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060166C8 RID: 91848
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLink_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166C9 RID: 91849 RVA: 0x001F8724 File Offset: 0x001F6924
		public override int IsA(string type)
		{
			return vtkAnnotationLink.vtkAnnotationLink_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060166CA RID: 91850
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLink_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166CB RID: 91851 RVA: 0x001F8744 File Offset: 0x001F6944
		public new static int IsTypeOf(string type)
		{
			return vtkAnnotationLink.vtkAnnotationLink_IsTypeOf_10(type);
		}

		// Token: 0x060166CC RID: 91852
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLink_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166CD RID: 91853 RVA: 0x001F8760 File Offset: 0x001F6960
		public new vtkAnnotationLink NewInstance()
		{
			vtkAnnotationLink result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060166CE RID: 91854
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLink_RemoveAllDomainMaps_13(HandleRef pThis);

		/// <summary>
		/// The domain mappings.
		/// </summary>
		// Token: 0x060166CF RID: 91855 RVA: 0x001F87BA File Offset: 0x001F69BA
		public void RemoveAllDomainMaps()
		{
			vtkAnnotationLink.vtkAnnotationLink_RemoveAllDomainMaps_13(base.GetCppThis());
		}

		// Token: 0x060166D0 RID: 91856
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLink_RemoveDomainMap_14(HandleRef pThis, HandleRef map);

		/// <summary>
		/// The domain mappings.
		/// </summary>
		// Token: 0x060166D1 RID: 91857 RVA: 0x001F87CC File Offset: 0x001F69CC
		public void RemoveDomainMap(vtkTable map)
		{
			vtkAnnotationLink.vtkAnnotationLink_RemoveDomainMap_14(base.GetCppThis(), (map == null) ? default(HandleRef) : map.GetCppThis());
		}

		// Token: 0x060166D2 RID: 91858
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLink_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166D3 RID: 91859 RVA: 0x001F87FC File Offset: 0x001F69FC
		public new static vtkAnnotationLink SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		// Token: 0x060166D4 RID: 91860
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLink_SetAnnotationLayers_16(HandleRef pThis, HandleRef layers);

		/// <summary>
		/// The annotations to be shared.
		/// </summary>
		// Token: 0x060166D5 RID: 91861 RVA: 0x001F887C File Offset: 0x001F6A7C
		public virtual void SetAnnotationLayers(vtkAnnotationLayers layers)
		{
			vtkAnnotationLink.vtkAnnotationLink_SetAnnotationLayers_16(base.GetCppThis(), (layers == null) ? default(HandleRef) : layers.GetCppThis());
		}

		// Token: 0x060166D6 RID: 91862
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLink_SetCurrentSelection_17(HandleRef pThis, HandleRef sel);

		/// <summary>
		/// Set or get the current selection in the annotation layers.
		/// </summary>
		// Token: 0x060166D7 RID: 91863 RVA: 0x001F88AC File Offset: 0x001F6AAC
		public virtual void SetCurrentSelection(vtkSelection sel)
		{
			vtkAnnotationLink.vtkAnnotationLink_SetCurrentSelection_17(base.GetCppThis(), (sel == null) ? default(HandleRef) : sel.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001934 RID: 6452
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotationLink";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001935 RID: 6453
		public new static readonly string MRClassNameKey = "class vtkAnnotationLink";
	}
}
