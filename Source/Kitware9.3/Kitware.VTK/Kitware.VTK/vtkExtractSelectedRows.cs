using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedRows
	/// </summary>
	/// <remarks>
	///    return selected rows of a table
	///
	///
	/// The first input is a vtkTable to extract rows from.
	/// The second input is a vtkSelection containing the selected indices.
	/// The third input is a vtkAnnotationLayers containing selected indices.
	/// The field type of the input selection is ignored when converted to row
	/// indices.
	/// </remarks>
	// Token: 0x020006B6 RID: 1718
	public class vtkExtractSelectedRows : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012541 RID: 75073 RVA: 0x0019B017 File Offset: 0x00199217
		static vtkExtractSelectedRows()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedRows.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedRows"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012542 RID: 75074 RVA: 0x0019B03F File Offset: 0x0019923F
		public vtkExtractSelectedRows(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012543 RID: 75075
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedRows_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012544 RID: 75076 RVA: 0x0019B050 File Offset: 0x00199250
		public new static vtkExtractSelectedRows New()
		{
			vtkExtractSelectedRows result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedRows.vtkExtractSelectedRows_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedRows)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012545 RID: 75077 RVA: 0x0019B0A4 File Offset: 0x001992A4
		public vtkExtractSelectedRows() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedRows.vtkExtractSelectedRows_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012546 RID: 75078 RVA: 0x0019B0E8 File Offset: 0x001992E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012547 RID: 75079
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedRows_AddOriginalRowIdsArrayOff_01(HandleRef pThis);

		/// <summary>
		/// When set, a column named vtkOriginalRowIds will be added to the output.
		/// False by default.
		/// </summary>
		// Token: 0x06012548 RID: 75080 RVA: 0x0019B0F3 File Offset: 0x001992F3
		public virtual void AddOriginalRowIdsArrayOff()
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_AddOriginalRowIdsArrayOff_01(base.GetCppThis());
		}

		// Token: 0x06012549 RID: 75081
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedRows_AddOriginalRowIdsArrayOn_02(HandleRef pThis);

		/// <summary>
		/// When set, a column named vtkOriginalRowIds will be added to the output.
		/// False by default.
		/// </summary>
		// Token: 0x0601254A RID: 75082 RVA: 0x0019B102 File Offset: 0x00199302
		public virtual void AddOriginalRowIdsArrayOn()
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_AddOriginalRowIdsArrayOn_02(base.GetCppThis());
		}

		// Token: 0x0601254B RID: 75083
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedRows_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Specify the first vtkGraph input and the second vtkSelection input.
		/// </summary>
		// Token: 0x0601254C RID: 75084 RVA: 0x0019B114 File Offset: 0x00199314
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601254D RID: 75085
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractSelectedRows_GetAddOriginalRowIdsArray_04(HandleRef pThis);

		/// <summary>
		/// When set, a column named vtkOriginalRowIds will be added to the output.
		/// False by default.
		/// </summary>
		// Token: 0x0601254E RID: 75086 RVA: 0x0019B14C File Offset: 0x0019934C
		public virtual bool GetAddOriginalRowIdsArray()
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_GetAddOriginalRowIdsArray_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0601254F RID: 75087
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedRows_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012550 RID: 75088 RVA: 0x0019B174 File Offset: 0x00199374
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06012551 RID: 75089
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedRows_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012552 RID: 75090 RVA: 0x0019B194 File Offset: 0x00199394
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06012553 RID: 75091
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedRows_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012554 RID: 75092 RVA: 0x0019B1B0 File Offset: 0x001993B0
		public override int IsA(string type)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06012555 RID: 75093
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedRows_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012556 RID: 75094 RVA: 0x0019B1D0 File Offset: 0x001993D0
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_IsTypeOf_08(type);
		}

		// Token: 0x06012557 RID: 75095
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedRows_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012558 RID: 75096 RVA: 0x0019B1EC File Offset: 0x001993EC
		public new vtkExtractSelectedRows NewInstance()
		{
			vtkExtractSelectedRows result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedRows.vtkExtractSelectedRows_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedRows)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012559 RID: 75097
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedRows_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601255A RID: 75098 RVA: 0x0019B248 File Offset: 0x00199448
		public new static vtkExtractSelectedRows SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedRows vtkExtractSelectedRows = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedRows.vtkExtractSelectedRows_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedRows = (vtkExtractSelectedRows)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedRows.Register(null);
				}
			}
			return vtkExtractSelectedRows;
		}

		// Token: 0x0601255B RID: 75099
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedRows_SetAddOriginalRowIdsArray_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set, a column named vtkOriginalRowIds will be added to the output.
		/// False by default.
		/// </summary>
		// Token: 0x0601255C RID: 75100 RVA: 0x0019B2C7 File Offset: 0x001994C7
		public virtual void SetAddOriginalRowIdsArray(bool _arg)
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_SetAddOriginalRowIdsArray_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601255D RID: 75101
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedRows_SetAnnotationLayersConnection_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the third input (i.e. the annotation layers).
		/// </summary>
		// Token: 0x0601255E RID: 75102 RVA: 0x0019B2E0 File Offset: 0x001994E0
		public void SetAnnotationLayersConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_SetAnnotationLayersConnection_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601255F RID: 75103
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedRows_SetSelectionConnection_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the second input (i.e. the selection).
		/// </summary>
		// Token: 0x06012560 RID: 75104 RVA: 0x0019B310 File Offset: 0x00199510
		public void SetSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_SetSelectionConnection_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400151A RID: 5402
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedRows";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400151B RID: 5403
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedRows";
	}
}
