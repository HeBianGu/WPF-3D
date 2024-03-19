using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectionBase
	/// </summary>
	/// <remarks>
	///    abstract base class for all extract selection
	/// filters.
	///
	/// vtkExtractSelectionBase is an abstract base class for all extract selection
	/// filters. It defines some properties common to all extract selection filters.
	/// </remarks>
	// Token: 0x020006B1 RID: 1713
	public class vtkExtractSelectionBase : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060124E0 RID: 74976 RVA: 0x0019A545 File Offset: 0x00198745
		static vtkExtractSelectionBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectionBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectionBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060124E1 RID: 74977 RVA: 0x0019A56D File Offset: 0x0019876D
		public vtkExtractSelectionBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060124E2 RID: 74978 RVA: 0x0019A57B File Offset: 0x0019877B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060124E3 RID: 74979
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectionBase_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124E4 RID: 74980 RVA: 0x0019A588 File Offset: 0x00198788
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060124E5 RID: 74981
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectionBase_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124E6 RID: 74982 RVA: 0x0019A5A8 File Offset: 0x001987A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060124E7 RID: 74983
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectionBase_GetPreserveTopology_03(HandleRef pThis);

		/// <summary>
		/// This flag tells the extraction filter not to convert the selected
		/// output into an unstructured grid, but instead to produce a vtkInsidedness
		/// array and add it to the input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x060124E8 RID: 74984 RVA: 0x0019A5C4 File Offset: 0x001987C4
		public virtual int GetPreserveTopology()
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_GetPreserveTopology_03(base.GetCppThis());
		}

		// Token: 0x060124E9 RID: 74985
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectionBase_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124EA RID: 74986 RVA: 0x0019A5E4 File Offset: 0x001987E4
		public override int IsA(string type)
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060124EB RID: 74987
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectionBase_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124EC RID: 74988 RVA: 0x0019A604 File Offset: 0x00198804
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_IsTypeOf_05(type);
		}

		// Token: 0x060124ED RID: 74989
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectionBase_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124EE RID: 74990 RVA: 0x0019A620 File Offset: 0x00198820
		public new vtkExtractSelectionBase NewInstance()
		{
			vtkExtractSelectionBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectionBase.vtkExtractSelectionBase_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectionBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060124EF RID: 74991
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectionBase_PreserveTopologyOff_07(HandleRef pThis);

		/// <summary>
		/// This flag tells the extraction filter not to convert the selected
		/// output into an unstructured grid, but instead to produce a vtkInsidedness
		/// array and add it to the input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x060124F0 RID: 74992 RVA: 0x0019A67A File Offset: 0x0019887A
		public virtual void PreserveTopologyOff()
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_PreserveTopologyOff_07(base.GetCppThis());
		}

		// Token: 0x060124F1 RID: 74993
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectionBase_PreserveTopologyOn_08(HandleRef pThis);

		/// <summary>
		/// This flag tells the extraction filter not to convert the selected
		/// output into an unstructured grid, but instead to produce a vtkInsidedness
		/// array and add it to the input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x060124F2 RID: 74994 RVA: 0x0019A689 File Offset: 0x00198889
		public virtual void PreserveTopologyOn()
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_PreserveTopologyOn_08(base.GetCppThis());
		}

		// Token: 0x060124F3 RID: 74995
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectionBase_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124F4 RID: 74996 RVA: 0x0019A698 File Offset: 0x00198898
		public new static vtkExtractSelectionBase SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectionBase vtkExtractSelectionBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectionBase.vtkExtractSelectionBase_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectionBase = (vtkExtractSelectionBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectionBase.Register(null);
				}
			}
			return vtkExtractSelectionBase;
		}

		// Token: 0x060124F5 RID: 74997
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectionBase_SetPreserveTopology_10(HandleRef pThis, int _arg);

		/// <summary>
		/// This flag tells the extraction filter not to convert the selected
		/// output into an unstructured grid, but instead to produce a vtkInsidedness
		/// array and add it to the input dataset. Default value is false(0).
		/// </summary>
		// Token: 0x060124F6 RID: 74998 RVA: 0x0019A717 File Offset: 0x00198917
		public virtual void SetPreserveTopology(int _arg)
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_SetPreserveTopology_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060124F7 RID: 74999
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectionBase_SetSelectionConnection_11(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Convenience method to specify the selection connection (2nd input
		/// port)
		/// </summary>
		// Token: 0x060124F8 RID: 75000 RVA: 0x0019A728 File Offset: 0x00198928
		public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_SetSelectionConnection_11(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001510 RID: 5392
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectionBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001511 RID: 5393
		public new static readonly string MRClassNameKey = "class vtkExtractSelectionBase";
	}
}
