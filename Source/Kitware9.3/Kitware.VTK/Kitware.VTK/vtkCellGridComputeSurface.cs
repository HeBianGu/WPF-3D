using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridComputeSurface
	/// </summary>
	/// <remarks>
	///    Adds arrays holding tuples of sides that are shared an odd number of times.
	///
	/// This filter simply adds or replaces a 2-component array for each type of
	/// side, for each cell type which identifies the set sides which are "un-shared."
	/// Internally, it uses a vtkCellGridSidesQuery to obtain sides, so
	/// the cells in your vtkCellGrid must provide a responder for this query type.
	///
	/// </remarks>
	/// <seealso>
	///  vtkCellGridSidesQuery
	/// </seealso>
	// Token: 0x020004CC RID: 1228
	public class vtkCellGridComputeSurface : vtkCellGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DFF0 RID: 57328 RVA: 0x001369BB File Offset: 0x00134BBB
		static vtkCellGridComputeSurface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridComputeSurface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridComputeSurface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DFF1 RID: 57329 RVA: 0x001369E3 File Offset: 0x00134BE3
		public vtkCellGridComputeSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DFF2 RID: 57330
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridComputeSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFF3 RID: 57331 RVA: 0x001369F4 File Offset: 0x00134BF4
		public new static vtkCellGridComputeSurface New()
		{
			vtkCellGridComputeSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridComputeSurface.vtkCellGridComputeSurface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridComputeSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFF4 RID: 57332 RVA: 0x00136A48 File Offset: 0x00134C48
		public vtkCellGridComputeSurface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridComputeSurface.vtkCellGridComputeSurface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DFF5 RID: 57333 RVA: 0x00136A8C File Offset: 0x00134C8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DFF6 RID: 57334
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridComputeSurface_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFF7 RID: 57335 RVA: 0x00136A98 File Offset: 0x00134C98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridComputeSurface.vtkCellGridComputeSurface_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DFF8 RID: 57336
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridComputeSurface_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFF9 RID: 57337 RVA: 0x00136AB8 File Offset: 0x00134CB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridComputeSurface.vtkCellGridComputeSurface_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DFFA RID: 57338
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridComputeSurface_GetPreserveRenderableCells_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFFB RID: 57339 RVA: 0x00136AD4 File Offset: 0x00134CD4
		public bool GetPreserveRenderableCells()
		{
			return vtkCellGridComputeSurface.vtkCellGridComputeSurface_GetPreserveRenderableCells_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DFFC RID: 57340
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCellGridComputeSurface_GetSideAttribute_04();

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFFD RID: 57341 RVA: 0x00136AFC File Offset: 0x00134CFC
		public static vtkStringToken GetSideAttribute()
		{
			return vtkCellGridComputeSurface.vtkCellGridComputeSurface_GetSideAttribute_04();
		}

		// Token: 0x0600DFFE RID: 57342
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridComputeSurface_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFFF RID: 57343 RVA: 0x00136B18 File Offset: 0x00134D18
		public override int IsA(string type)
		{
			return vtkCellGridComputeSurface.vtkCellGridComputeSurface_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E000 RID: 57344
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridComputeSurface_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E001 RID: 57345 RVA: 0x00136B38 File Offset: 0x00134D38
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridComputeSurface.vtkCellGridComputeSurface_IsTypeOf_06(type);
		}

		// Token: 0x0600E002 RID: 57346
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridComputeSurface_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E003 RID: 57347 RVA: 0x00136B54 File Offset: 0x00134D54
		public new vtkCellGridComputeSurface NewInstance()
		{
			vtkCellGridComputeSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridComputeSurface.vtkCellGridComputeSurface_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridComputeSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E004 RID: 57348
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridComputeSurface_PreserveRenderableCellsOff_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E005 RID: 57349 RVA: 0x00136BAE File Offset: 0x00134DAE
		public virtual void PreserveRenderableCellsOff()
		{
			vtkCellGridComputeSurface.vtkCellGridComputeSurface_PreserveRenderableCellsOff_09(base.GetCppThis());
		}

		// Token: 0x0600E006 RID: 57350
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridComputeSurface_PreserveRenderableCellsOn_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E007 RID: 57351 RVA: 0x00136BBD File Offset: 0x00134DBD
		public virtual void PreserveRenderableCellsOn()
		{
			vtkCellGridComputeSurface.vtkCellGridComputeSurface_PreserveRenderableCellsOn_10(base.GetCppThis());
		}

		// Token: 0x0600E008 RID: 57352
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridComputeSurface_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E009 RID: 57353 RVA: 0x00136BCC File Offset: 0x00134DCC
		public new static vtkCellGridComputeSurface SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridComputeSurface vtkCellGridComputeSurface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridComputeSurface.vtkCellGridComputeSurface_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridComputeSurface = (vtkCellGridComputeSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridComputeSurface.Register(null);
				}
			}
			return vtkCellGridComputeSurface;
		}

		// Token: 0x0600E00A RID: 57354
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridComputeSurface_SetPreserveRenderableCells_12(HandleRef pThis, byte preserve);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E00B RID: 57355 RVA: 0x00136C4B File Offset: 0x00134E4B
		public virtual void SetPreserveRenderableCells(bool preserve)
		{
			vtkCellGridComputeSurface.vtkCellGridComputeSurface_SetPreserveRenderableCells_12(base.GetCppThis(), preserve ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001073 RID: 4211
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridComputeSurface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001074 RID: 4212
		public new static readonly string MRClassNameKey = "class vtkCellGridComputeSurface";
	}
}
