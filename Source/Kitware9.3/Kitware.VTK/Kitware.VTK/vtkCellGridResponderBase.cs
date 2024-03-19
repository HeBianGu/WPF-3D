using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridResponderBase
	/// </summary>
	/// <remarks>
	///    Respond to a query on one particular type of cell.
	///
	/// This is pure virtual base class that all responder types must inherit.
	/// </remarks>
	// Token: 0x02000126 RID: 294
	public abstract class vtkCellGridResponderBase : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003BE5 RID: 15333 RVA: 0x000572AF File Offset: 0x000554AF
		static vtkCellGridResponderBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridResponderBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridResponderBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003BE6 RID: 15334 RVA: 0x000572D7 File Offset: 0x000554D7
		public vtkCellGridResponderBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003BE7 RID: 15335 RVA: 0x000572E5 File Offset: 0x000554E5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003BE8 RID: 15336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridResponderBase_EvaluateQuery_01(HandleRef pThis, HandleRef query, HandleRef cellType, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BE9 RID: 15337 RVA: 0x000572F0 File Offset: 0x000554F0
		public virtual bool EvaluateQuery(vtkCellGridQuery query, vtkCellMetadata cellType, vtkCellGridResponders caches)
		{
			return vtkCellGridResponderBase.vtkCellGridResponderBase_EvaluateQuery_01(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x06003BEA RID: 15338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridResponderBase_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BEB RID: 15339 RVA: 0x00057358 File Offset: 0x00055558
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridResponderBase.vtkCellGridResponderBase_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003BEC RID: 15340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridResponderBase_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BED RID: 15341 RVA: 0x00057378 File Offset: 0x00055578
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridResponderBase.vtkCellGridResponderBase_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003BEE RID: 15342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridResponderBase_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BEF RID: 15343 RVA: 0x00057394 File Offset: 0x00055594
		public override int IsA(string type)
		{
			return vtkCellGridResponderBase.vtkCellGridResponderBase_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003BF0 RID: 15344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridResponderBase_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BF1 RID: 15345 RVA: 0x000573B4 File Offset: 0x000555B4
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridResponderBase.vtkCellGridResponderBase_IsTypeOf_05(type);
		}

		// Token: 0x06003BF2 RID: 15346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridResponderBase_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BF3 RID: 15347 RVA: 0x000573D0 File Offset: 0x000555D0
		public new vtkCellGridResponderBase NewInstance()
		{
			vtkCellGridResponderBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridResponderBase.vtkCellGridResponderBase_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridResponderBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003BF4 RID: 15348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridResponderBase_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BF5 RID: 15349 RVA: 0x0005742C File Offset: 0x0005562C
		public new static vtkCellGridResponderBase SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridResponderBase vtkCellGridResponderBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridResponderBase.vtkCellGridResponderBase_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridResponderBase = (vtkCellGridResponderBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridResponderBase.Register(null);
				}
			}
			return vtkCellGridResponderBase;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000685 RID: 1669
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridResponderBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000686 RID: 1670
		public new static readonly string MRClassNameKey = "class vtkCellGridResponderBase";
	}
}
