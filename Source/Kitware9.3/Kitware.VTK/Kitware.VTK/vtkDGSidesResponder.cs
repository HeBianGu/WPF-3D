using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGSidesResponder
	/// </summary>
	/// <remarks>
	///    Compute the sides on the outside surface of a collection of DG cells.
	///
	/// </remarks>
	// Token: 0x020004D5 RID: 1237
	public class vtkDGSidesResponder : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E0D4 RID: 57556 RVA: 0x0013821B File Offset: 0x0013641B
		static vtkDGSidesResponder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGSidesResponder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGSidesResponder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0D5 RID: 57557 RVA: 0x00138243 File Offset: 0x00136443
		public vtkDGSidesResponder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E0D6 RID: 57558
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGSidesResponder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0D7 RID: 57559 RVA: 0x00138254 File Offset: 0x00136454
		public new static vtkDGSidesResponder New()
		{
			vtkDGSidesResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGSidesResponder.vtkDGSidesResponder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGSidesResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0D8 RID: 57560 RVA: 0x001382A8 File Offset: 0x001364A8
		public vtkDGSidesResponder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGSidesResponder.vtkDGSidesResponder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0D9 RID: 57561 RVA: 0x001382EC File Offset: 0x001364EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E0DA RID: 57562
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGSidesResponder_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0DB RID: 57563 RVA: 0x001382F8 File Offset: 0x001364F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGSidesResponder.vtkDGSidesResponder_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E0DC RID: 57564
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGSidesResponder_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0DD RID: 57565 RVA: 0x00138318 File Offset: 0x00136518
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGSidesResponder.vtkDGSidesResponder_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E0DE RID: 57566
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGSidesResponder_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0DF RID: 57567 RVA: 0x00138334 File Offset: 0x00136534
		public override int IsA(string type)
		{
			return vtkDGSidesResponder.vtkDGSidesResponder_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E0E0 RID: 57568
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGSidesResponder_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0E1 RID: 57569 RVA: 0x00138354 File Offset: 0x00136554
		public new static int IsTypeOf(string type)
		{
			return vtkDGSidesResponder.vtkDGSidesResponder_IsTypeOf_04(type);
		}

		// Token: 0x0600E0E2 RID: 57570
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGSidesResponder_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0E3 RID: 57571 RVA: 0x00138370 File Offset: 0x00136570
		public new vtkDGSidesResponder NewInstance()
		{
			vtkDGSidesResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGSidesResponder.vtkDGSidesResponder_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGSidesResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E0E4 RID: 57572
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGSidesResponder_Query_07(HandleRef pThis, HandleRef query, HandleRef cellType, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0E5 RID: 57573 RVA: 0x001383CC File Offset: 0x001365CC
		public virtual bool Query(vtkCellGridSidesQuery query, vtkCellMetadata cellType, vtkCellGridResponders caches)
		{
			return vtkDGSidesResponder.vtkDGSidesResponder_Query_07(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x0600E0E6 RID: 57574
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGSidesResponder_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0E7 RID: 57575 RVA: 0x00138434 File Offset: 0x00136634
		public new static vtkDGSidesResponder SafeDownCast(vtkObjectBase o)
		{
			vtkDGSidesResponder vtkDGSidesResponder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGSidesResponder.vtkDGSidesResponder_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGSidesResponder = (vtkDGSidesResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGSidesResponder.Register(null);
				}
			}
			return vtkDGSidesResponder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001085 RID: 4229
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGSidesResponder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001086 RID: 4230
		public new static readonly string MRClassNameKey = "class vtkDGSidesResponder";
	}
}
