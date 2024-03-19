using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGRangeResponder
	/// </summary>
	/// <remarks>
	///    Compute the range of a cell-attribute over any vtkDGCell.
	///
	/// This simply computes the range of the underlying scalar arrays;
	/// it does not attempt to account for true minima/maximum induced
	/// by higher-order curvature.
	/// </remarks>
	// Token: 0x020004D4 RID: 1236
	public class vtkDGRangeResponder : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E0C0 RID: 57536 RVA: 0x00137F83 File Offset: 0x00136183
		static vtkDGRangeResponder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGRangeResponder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGRangeResponder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0C1 RID: 57537 RVA: 0x00137FAB File Offset: 0x001361AB
		public vtkDGRangeResponder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E0C2 RID: 57538
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGRangeResponder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0C3 RID: 57539 RVA: 0x00137FBC File Offset: 0x001361BC
		public new static vtkDGRangeResponder New()
		{
			vtkDGRangeResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGRangeResponder.vtkDGRangeResponder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGRangeResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0C4 RID: 57540 RVA: 0x00138010 File Offset: 0x00136210
		public vtkDGRangeResponder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGRangeResponder.vtkDGRangeResponder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0C5 RID: 57541 RVA: 0x00138054 File Offset: 0x00136254
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E0C6 RID: 57542
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGRangeResponder_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0C7 RID: 57543 RVA: 0x00138060 File Offset: 0x00136260
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGRangeResponder.vtkDGRangeResponder_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E0C8 RID: 57544
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGRangeResponder_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0C9 RID: 57545 RVA: 0x00138080 File Offset: 0x00136280
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGRangeResponder.vtkDGRangeResponder_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E0CA RID: 57546
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGRangeResponder_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0CB RID: 57547 RVA: 0x0013809C File Offset: 0x0013629C
		public override int IsA(string type)
		{
			return vtkDGRangeResponder.vtkDGRangeResponder_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E0CC RID: 57548
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGRangeResponder_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0CD RID: 57549 RVA: 0x001380BC File Offset: 0x001362BC
		public new static int IsTypeOf(string type)
		{
			return vtkDGRangeResponder.vtkDGRangeResponder_IsTypeOf_04(type);
		}

		// Token: 0x0600E0CE RID: 57550
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGRangeResponder_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0CF RID: 57551 RVA: 0x001380D8 File Offset: 0x001362D8
		public new vtkDGRangeResponder NewInstance()
		{
			vtkDGRangeResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGRangeResponder.vtkDGRangeResponder_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGRangeResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E0D0 RID: 57552
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGRangeResponder_Query_07(HandleRef pThis, HandleRef query, HandleRef cellType, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0D1 RID: 57553 RVA: 0x00138134 File Offset: 0x00136334
		public virtual bool Query(vtkCellGridRangeQuery query, vtkCellMetadata cellType, vtkCellGridResponders caches)
		{
			return vtkDGRangeResponder.vtkDGRangeResponder_Query_07(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x0600E0D2 RID: 57554
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGRangeResponder_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0D3 RID: 57555 RVA: 0x0013819C File Offset: 0x0013639C
		public new static vtkDGRangeResponder SafeDownCast(vtkObjectBase o)
		{
			vtkDGRangeResponder vtkDGRangeResponder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGRangeResponder.vtkDGRangeResponder_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGRangeResponder = (vtkDGRangeResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGRangeResponder.Register(null);
				}
			}
			return vtkDGRangeResponder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001083 RID: 4227
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGRangeResponder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001084 RID: 4228
		public new static readonly string MRClassNameKey = "class vtkDGRangeResponder";
	}
}
