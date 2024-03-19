using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellDistanceSelector
	/// </summary>
	/// <remarks>
	///    select neighbor cells up to a distance
	///
	///
	/// This filter grows an input selection by iteratively selecting neighbor
	/// cells (a neighbor cell is a cell that shares a vertex/edge/face), up to
	/// a given topological distance to the selected neighborhood (number of times
	/// we add neighbor cells).
	/// This filter takes a vtkSelection and a vtkCompositeDataSet as inputs.
	/// It outputs a vtkSelection identifying all the selected cells.
	///
	/// @par Thanks:
	/// This file has been initially developed in the frame of CEA's Love visualization software
	/// development &lt;br&gt; CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt; BP12,
	/// F-91297 Arpajon, France. &lt;br&gt; Modified and integrated into VTK, Kitware SAS 2012 Implementation
	/// by Thierry Carrard and Philippe Pebay
	/// </remarks>
	// Token: 0x02000419 RID: 1049
	public class vtkCellDistanceSelector : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C5CC RID: 50636 RVA: 0x00113420 File Offset: 0x00111620
		static vtkCellDistanceSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellDistanceSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDistanceSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C5CD RID: 50637 RVA: 0x00113448 File Offset: 0x00111648
		public vtkCellDistanceSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C5CE RID: 50638
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDistanceSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5CF RID: 50639 RVA: 0x00113458 File Offset: 0x00111658
		public new static vtkCellDistanceSelector New()
		{
			vtkCellDistanceSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDistanceSelector.vtkCellDistanceSelector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDistanceSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5D0 RID: 50640 RVA: 0x001134AC File Offset: 0x001116AC
		public vtkCellDistanceSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellDistanceSelector.vtkCellDistanceSelector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C5D1 RID: 50641 RVA: 0x001134F0 File Offset: 0x001116F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C5D2 RID: 50642
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_AddIntermediateOff_01(HandleRef pThis);

		/// <summary>
		/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
		/// the final selection
		/// </summary>
		// Token: 0x0600C5D3 RID: 50643 RVA: 0x001134FB File Offset: 0x001116FB
		public virtual void AddIntermediateOff()
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_AddIntermediateOff_01(base.GetCppThis());
		}

		// Token: 0x0600C5D4 RID: 50644
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_AddIntermediateOn_02(HandleRef pThis);

		/// <summary>
		/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
		/// the final selection
		/// </summary>
		// Token: 0x0600C5D5 RID: 50645 RVA: 0x0011350A File Offset: 0x0011170A
		public virtual void AddIntermediateOn()
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_AddIntermediateOn_02(base.GetCppThis());
		}

		// Token: 0x0600C5D6 RID: 50646
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDistanceSelector_GetAddIntermediate_03(HandleRef pThis);

		/// <summary>
		/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
		/// the final selection
		/// </summary>
		// Token: 0x0600C5D7 RID: 50647 RVA: 0x0011351C File Offset: 0x0011171C
		public virtual int GetAddIntermediate()
		{
			return vtkCellDistanceSelector.vtkCellDistanceSelector_GetAddIntermediate_03(base.GetCppThis());
		}

		// Token: 0x0600C5D8 RID: 50648
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDistanceSelector_GetDistance_04(HandleRef pThis);

		/// <summary>
		/// Tells how far (in term of topological distance) away from seed cells to expand the selection
		/// </summary>
		// Token: 0x0600C5D9 RID: 50649 RVA: 0x0011353C File Offset: 0x0011173C
		public virtual int GetDistance()
		{
			return vtkCellDistanceSelector.vtkCellDistanceSelector_GetDistance_04(base.GetCppThis());
		}

		// Token: 0x0600C5DA RID: 50650
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDistanceSelector_GetIncludeSeed_05(HandleRef pThis);

		/// <summary>
		/// If set, seed cells passed with SetSeedCells will be included in the final selection
		/// </summary>
		// Token: 0x0600C5DB RID: 50651 RVA: 0x0011355C File Offset: 0x0011175C
		public virtual int GetIncludeSeed()
		{
			return vtkCellDistanceSelector.vtkCellDistanceSelector_GetIncludeSeed_05(base.GetCppThis());
		}

		// Token: 0x0600C5DC RID: 50652
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellDistanceSelector_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5DD RID: 50653 RVA: 0x0011357C File Offset: 0x0011177C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellDistanceSelector.vtkCellDistanceSelector_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600C5DE RID: 50654
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellDistanceSelector_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5DF RID: 50655 RVA: 0x0011359C File Offset: 0x0011179C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellDistanceSelector.vtkCellDistanceSelector_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600C5E0 RID: 50656
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_IncludeSeedOff_08(HandleRef pThis);

		/// <summary>
		/// If set, seed cells passed with SetSeedCells will be included in the final selection
		/// </summary>
		// Token: 0x0600C5E1 RID: 50657 RVA: 0x001135B6 File Offset: 0x001117B6
		public virtual void IncludeSeedOff()
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_IncludeSeedOff_08(base.GetCppThis());
		}

		// Token: 0x0600C5E2 RID: 50658
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_IncludeSeedOn_09(HandleRef pThis);

		/// <summary>
		/// If set, seed cells passed with SetSeedCells will be included in the final selection
		/// </summary>
		// Token: 0x0600C5E3 RID: 50659 RVA: 0x001135C5 File Offset: 0x001117C5
		public virtual void IncludeSeedOn()
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_IncludeSeedOn_09(base.GetCppThis());
		}

		// Token: 0x0600C5E4 RID: 50660
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDistanceSelector_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5E5 RID: 50661 RVA: 0x001135D4 File Offset: 0x001117D4
		public override int IsA(string type)
		{
			return vtkCellDistanceSelector.vtkCellDistanceSelector_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600C5E6 RID: 50662
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDistanceSelector_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5E7 RID: 50663 RVA: 0x001135F4 File Offset: 0x001117F4
		public new static int IsTypeOf(string type)
		{
			return vtkCellDistanceSelector.vtkCellDistanceSelector_IsTypeOf_11(type);
		}

		// Token: 0x0600C5E8 RID: 50664
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDistanceSelector_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5E9 RID: 50665 RVA: 0x00113610 File Offset: 0x00111810
		public new vtkCellDistanceSelector NewInstance()
		{
			vtkCellDistanceSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDistanceSelector.vtkCellDistanceSelector_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDistanceSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C5EA RID: 50666
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDistanceSelector_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5EB RID: 50667 RVA: 0x0011366C File Offset: 0x0011186C
		public new static vtkCellDistanceSelector SafeDownCast(vtkObjectBase o)
		{
			vtkCellDistanceSelector vtkCellDistanceSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDistanceSelector.vtkCellDistanceSelector_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellDistanceSelector = (vtkCellDistanceSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellDistanceSelector.Register(null);
				}
			}
			return vtkCellDistanceSelector;
		}

		// Token: 0x0600C5EC RID: 50668
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_SetAddIntermediate_15(HandleRef pThis, int _arg);

		/// <summary>
		/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
		/// the final selection
		/// </summary>
		// Token: 0x0600C5ED RID: 50669 RVA: 0x001136EB File Offset: 0x001118EB
		public virtual void SetAddIntermediate(int _arg)
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_SetAddIntermediate_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C5EE RID: 50670
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_SetDistance_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Tells how far (in term of topological distance) away from seed cells to expand the selection
		/// </summary>
		// Token: 0x0600C5EF RID: 50671 RVA: 0x001136FB File Offset: 0x001118FB
		public virtual void SetDistance(int _arg)
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_SetDistance_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C5F0 RID: 50672
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_SetIncludeSeed_17(HandleRef pThis, int _arg);

		/// <summary>
		/// If set, seed cells passed with SetSeedCells will be included in the final selection
		/// </summary>
		// Token: 0x0600C5F1 RID: 50673 RVA: 0x0011370B File Offset: 0x0011190B
		public virtual void SetIncludeSeed(int _arg)
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_SetIncludeSeed_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C5F2 RID: 50674
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_SetInputMesh_18(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// A convenience method to set the input data object
		/// </summary>
		// Token: 0x0600C5F3 RID: 50675 RVA: 0x0011371C File Offset: 0x0011191C
		public void SetInputMesh(vtkDataObject obj)
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_SetInputMesh_18(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x0600C5F4 RID: 50676
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_SetInputMeshConnection_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method to set the data object input connection to the producer output
		/// </summary>
		// Token: 0x0600C5F5 RID: 50677 RVA: 0x0011374C File Offset: 0x0011194C
		public void SetInputMeshConnection(vtkAlgorithmOutput arg0)
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_SetInputMeshConnection_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C5F6 RID: 50678
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_SetInputSelection_20(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// A convenience method to set the input selection
		/// </summary>
		// Token: 0x0600C5F7 RID: 50679 RVA: 0x0011377C File Offset: 0x0011197C
		public void SetInputSelection(vtkSelection obj)
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_SetInputSelection_20(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x0600C5F8 RID: 50680
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDistanceSelector_SetInputSelectionConnection_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method to set the selection input connection to the producer output
		/// </summary>
		// Token: 0x0600C5F9 RID: 50681 RVA: 0x001137AC File Offset: 0x001119AC
		public void SetInputSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkCellDistanceSelector.vtkCellDistanceSelector_SetInputSelectionConnection_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EC2 RID: 3778
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellDistanceSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EC3 RID: 3779
		public new static readonly string MRClassNameKey = "class vtkCellDistanceSelector";

		/// <summary>
		/// enumeration values to specify input port types
		/// </summary>
		// Token: 0x0200041A RID: 1050
		public enum InputPorts
		{
			/// <summary>enum member</summary>
			// Token: 0x04000EC5 RID: 3781
			INPUT_MESH,
			/// <summary>enum member</summary>
			// Token: 0x04000EC6 RID: 3782
			INPUT_SELECTION
		}
	}
}
