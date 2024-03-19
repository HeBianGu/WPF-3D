using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGEvaluator
	/// </summary>
	/// <remarks>
	///    Classify world points, evaluate cell parameters, and interpolate attributes.
	///
	/// Given a set of input points in world coordinates,
	/// classify these points (determine which cells they are inside);
	/// evaluate these points (determine the parametric coordinates of the point inside each cell);
	/// and interpolate an attribute (evaluate the value of an attribute at the parametric coords).
	/// </remarks>
	// Token: 0x020004D3 RID: 1235
	public class vtkDGEvaluator : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E0AC RID: 57516 RVA: 0x00137CEB File Offset: 0x00135EEB
		static vtkDGEvaluator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGEvaluator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGEvaluator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0AD RID: 57517 RVA: 0x00137D13 File Offset: 0x00135F13
		public vtkDGEvaluator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E0AE RID: 57518
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEvaluator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0AF RID: 57519 RVA: 0x00137D24 File Offset: 0x00135F24
		public new static vtkDGEvaluator New()
		{
			vtkDGEvaluator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEvaluator.vtkDGEvaluator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGEvaluator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0B0 RID: 57520 RVA: 0x00137D78 File Offset: 0x00135F78
		public vtkDGEvaluator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGEvaluator.vtkDGEvaluator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0B1 RID: 57521 RVA: 0x00137DBC File Offset: 0x00135FBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E0B2 RID: 57522
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGEvaluator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0B3 RID: 57523 RVA: 0x00137DC8 File Offset: 0x00135FC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGEvaluator.vtkDGEvaluator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E0B4 RID: 57524
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGEvaluator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0B5 RID: 57525 RVA: 0x00137DE8 File Offset: 0x00135FE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGEvaluator.vtkDGEvaluator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E0B6 RID: 57526
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGEvaluator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0B7 RID: 57527 RVA: 0x00137E04 File Offset: 0x00136004
		public override int IsA(string type)
		{
			return vtkDGEvaluator.vtkDGEvaluator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E0B8 RID: 57528
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGEvaluator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0B9 RID: 57529 RVA: 0x00137E24 File Offset: 0x00136024
		public new static int IsTypeOf(string type)
		{
			return vtkDGEvaluator.vtkDGEvaluator_IsTypeOf_04(type);
		}

		// Token: 0x0600E0BA RID: 57530
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEvaluator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0BB RID: 57531 RVA: 0x00137E40 File Offset: 0x00136040
		public new vtkDGEvaluator NewInstance()
		{
			vtkDGEvaluator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEvaluator.vtkDGEvaluator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGEvaluator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E0BC RID: 57532
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGEvaluator_Query_07(HandleRef pThis, HandleRef query, HandleRef cellType, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0BD RID: 57533 RVA: 0x00137E9C File Offset: 0x0013609C
		public virtual bool Query(vtkCellGridEvaluator query, vtkCellMetadata cellType, vtkCellGridResponders caches)
		{
			return vtkDGEvaluator.vtkDGEvaluator_Query_07(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x0600E0BE RID: 57534
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEvaluator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0BF RID: 57535 RVA: 0x00137F04 File Offset: 0x00136104
		public new static vtkDGEvaluator SafeDownCast(vtkObjectBase o)
		{
			vtkDGEvaluator vtkDGEvaluator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEvaluator.vtkDGEvaluator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGEvaluator = (vtkDGEvaluator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGEvaluator.Register(null);
				}
			}
			return vtkDGEvaluator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001081 RID: 4225
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGEvaluator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001082 RID: 4226
		public new static readonly string MRClassNameKey = "class vtkDGEvaluator";
	}
}
