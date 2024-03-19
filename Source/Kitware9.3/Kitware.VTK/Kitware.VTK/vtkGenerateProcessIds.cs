using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenerateProcessIds
	/// </summary>
	/// <remarks>
	///    Sets ProcessIds attribute for PointData and/or CellData.
	///
	///
	/// vtkGenerateProcessIds is meant to fill in the ProcessIds attribute array,
	/// to know which processor owns which cells and points. It can generate it
	/// for both PointData and CellData. The ProcessIds array's name will be
	/// "PointProcessIds" for PointData, and "CellProcessIds" for CellData.
	/// </remarks>
	// Token: 0x02000505 RID: 1285
	public class vtkGenerateProcessIds : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E6F0 RID: 59120 RVA: 0x00141A58 File Offset: 0x0013FC58
		static vtkGenerateProcessIds()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenerateProcessIds.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenerateProcessIds"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6F1 RID: 59121 RVA: 0x00141A80 File Offset: 0x0013FC80
		public vtkGenerateProcessIds(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E6F2 RID: 59122
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateProcessIds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6F3 RID: 59123 RVA: 0x00141A90 File Offset: 0x0013FC90
		public new static vtkGenerateProcessIds New()
		{
			vtkGenerateProcessIds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateProcessIds.vtkGenerateProcessIds_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateProcessIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E6F4 RID: 59124 RVA: 0x00141AE4 File Offset: 0x0013FCE4
		public vtkGenerateProcessIds() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenerateProcessIds.vtkGenerateProcessIds_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E6F5 RID: 59125 RVA: 0x00141B28 File Offset: 0x0013FD28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E6F6 RID: 59126
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateProcessIds_GenerateCellDataOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to generate process ids for CellData.
		/// Default is false.
		/// </summary>
		// Token: 0x0600E6F7 RID: 59127 RVA: 0x00141B33 File Offset: 0x0013FD33
		public virtual void GenerateCellDataOff()
		{
			vtkGenerateProcessIds.vtkGenerateProcessIds_GenerateCellDataOff_01(base.GetCppThis());
		}

		// Token: 0x0600E6F8 RID: 59128
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateProcessIds_GenerateCellDataOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to generate process ids for CellData.
		/// Default is false.
		/// </summary>
		// Token: 0x0600E6F9 RID: 59129 RVA: 0x00141B42 File Offset: 0x0013FD42
		public virtual void GenerateCellDataOn()
		{
			vtkGenerateProcessIds.vtkGenerateProcessIds_GenerateCellDataOn_02(base.GetCppThis());
		}

		// Token: 0x0600E6FA RID: 59130
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateProcessIds_GeneratePointDataOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to generate process ids for PointData.
		/// Default is true.
		/// </summary>
		// Token: 0x0600E6FB RID: 59131 RVA: 0x00141B51 File Offset: 0x0013FD51
		public virtual void GeneratePointDataOff()
		{
			vtkGenerateProcessIds.vtkGenerateProcessIds_GeneratePointDataOff_03(base.GetCppThis());
		}

		// Token: 0x0600E6FC RID: 59132
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateProcessIds_GeneratePointDataOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to generate process ids for PointData.
		/// Default is true.
		/// </summary>
		// Token: 0x0600E6FD RID: 59133 RVA: 0x00141B60 File Offset: 0x0013FD60
		public virtual void GeneratePointDataOn()
		{
			vtkGenerateProcessIds.vtkGenerateProcessIds_GeneratePointDataOn_04(base.GetCppThis());
		}

		// Token: 0x0600E6FE RID: 59134
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateProcessIds_GetController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E6FF RID: 59135 RVA: 0x00141B70 File Offset: 0x0013FD70
		public vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateProcessIds.vtkGenerateProcessIds_GetController_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600E700 RID: 59136
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGenerateProcessIds_GetGenerateCellData_06(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to generate process ids for CellData.
		/// Default is false.
		/// </summary>
		// Token: 0x0600E701 RID: 59137 RVA: 0x00141BE0 File Offset: 0x0013FDE0
		public virtual bool GetGenerateCellData()
		{
			return vtkGenerateProcessIds.vtkGenerateProcessIds_GetGenerateCellData_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E702 RID: 59138
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGenerateProcessIds_GetGeneratePointData_07(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to generate process ids for PointData.
		/// Default is true.
		/// </summary>
		// Token: 0x0600E703 RID: 59139 RVA: 0x00141C08 File Offset: 0x0013FE08
		public virtual bool GetGeneratePointData()
		{
			return vtkGenerateProcessIds.vtkGenerateProcessIds_GetGeneratePointData_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E704 RID: 59140
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenerateProcessIds_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E705 RID: 59141 RVA: 0x00141C30 File Offset: 0x0013FE30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenerateProcessIds.vtkGenerateProcessIds_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600E706 RID: 59142
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenerateProcessIds_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E707 RID: 59143 RVA: 0x00141C50 File Offset: 0x0013FE50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenerateProcessIds.vtkGenerateProcessIds_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600E708 RID: 59144
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateProcessIds_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E709 RID: 59145 RVA: 0x00141C6C File Offset: 0x0013FE6C
		public override int IsA(string type)
		{
			return vtkGenerateProcessIds.vtkGenerateProcessIds_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600E70A RID: 59146
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateProcessIds_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E70B RID: 59147 RVA: 0x00141C8C File Offset: 0x0013FE8C
		public new static int IsTypeOf(string type)
		{
			return vtkGenerateProcessIds.vtkGenerateProcessIds_IsTypeOf_11(type);
		}

		// Token: 0x0600E70C RID: 59148
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateProcessIds_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E70D RID: 59149 RVA: 0x00141CA8 File Offset: 0x0013FEA8
		public new vtkGenerateProcessIds NewInstance()
		{
			vtkGenerateProcessIds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateProcessIds.vtkGenerateProcessIds_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateProcessIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E70E RID: 59150
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateProcessIds_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E70F RID: 59151 RVA: 0x00141D04 File Offset: 0x0013FF04
		public new static vtkGenerateProcessIds SafeDownCast(vtkObjectBase o)
		{
			vtkGenerateProcessIds vtkGenerateProcessIds = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateProcessIds.vtkGenerateProcessIds_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenerateProcessIds = (vtkGenerateProcessIds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenerateProcessIds.Register(null);
				}
			}
			return vtkGenerateProcessIds;
		}

		// Token: 0x0600E710 RID: 59152
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateProcessIds_SetController_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E711 RID: 59153 RVA: 0x00141D84 File Offset: 0x0013FF84
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkGenerateProcessIds.vtkGenerateProcessIds_SetController_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E712 RID: 59154
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateProcessIds_SetGenerateCellData_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether to generate process ids for CellData.
		/// Default is false.
		/// </summary>
		// Token: 0x0600E713 RID: 59155 RVA: 0x00141DB3 File Offset: 0x0013FFB3
		public virtual void SetGenerateCellData(bool _arg)
		{
			vtkGenerateProcessIds.vtkGenerateProcessIds_SetGenerateCellData_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E714 RID: 59156
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateProcessIds_SetGeneratePointData_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether to generate process ids for PointData.
		/// Default is true.
		/// </summary>
		// Token: 0x0600E715 RID: 59157 RVA: 0x00141DCB File Offset: 0x0013FFCB
		public virtual void SetGeneratePointData(bool _arg)
		{
			vtkGenerateProcessIds.vtkGenerateProcessIds_SetGeneratePointData_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F1 RID: 4337
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenerateProcessIds";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F2 RID: 4338
		public new static readonly string MRClassNameKey = "class vtkGenerateProcessIds";
	}
}
