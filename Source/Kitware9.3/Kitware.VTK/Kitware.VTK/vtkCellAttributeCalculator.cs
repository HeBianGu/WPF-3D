using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellAttributeCalculator
	/// </summary>
	/// <remarks>
	///    Perform a per-cell calculation on a vtkCellAttribute.
	///
	/// This empty class serves as a common base class for calculators that
	/// compute quantities based on cell-attribute data.
	///
	/// Examples of calculators include
	/// + computing interpolated values;
	/// + computing spatial derivatives (such as the Jacobian or Hessian matrices); or
	/// + computing integrals over an entire cell.
	///
	/// Each type of calculator provides its own abstract subclass with virtual methods
	/// and then per-cell-type, per-attribute-type concrete implementations.
	///
	/// </remarks>
	/// <seealso>
	///  vtkCellGridAttribute
	/// </seealso>
	// Token: 0x020004D7 RID: 1239
	public class vtkCellAttributeCalculator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E0FA RID: 57594 RVA: 0x001386E3 File Offset: 0x001368E3
		static vtkCellAttributeCalculator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellAttributeCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellAttributeCalculator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0FB RID: 57595 RVA: 0x0013870B File Offset: 0x0013690B
		public vtkCellAttributeCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E0FC RID: 57596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttributeCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0FD RID: 57597 RVA: 0x0013871C File Offset: 0x0013691C
		public new static vtkCellAttributeCalculator New()
		{
			vtkCellAttributeCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttributeCalculator.vtkCellAttributeCalculator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellAttributeCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0FE RID: 57598 RVA: 0x00138770 File Offset: 0x00136970
		public vtkCellAttributeCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellAttributeCalculator.vtkCellAttributeCalculator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0FF RID: 57599 RVA: 0x001387B4 File Offset: 0x001369B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E100 RID: 57600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellAttributeCalculator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E101 RID: 57601 RVA: 0x001387C0 File Offset: 0x001369C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellAttributeCalculator.vtkCellAttributeCalculator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E102 RID: 57602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellAttributeCalculator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E103 RID: 57603 RVA: 0x001387E0 File Offset: 0x001369E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellAttributeCalculator.vtkCellAttributeCalculator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E104 RID: 57604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeCalculator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E105 RID: 57605 RVA: 0x001387FC File Offset: 0x001369FC
		public override int IsA(string type)
		{
			return vtkCellAttributeCalculator.vtkCellAttributeCalculator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E106 RID: 57606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeCalculator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E107 RID: 57607 RVA: 0x0013881C File Offset: 0x00136A1C
		public new static int IsTypeOf(string type)
		{
			return vtkCellAttributeCalculator.vtkCellAttributeCalculator_IsTypeOf_04(type);
		}

		// Token: 0x0600E108 RID: 57608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttributeCalculator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E109 RID: 57609 RVA: 0x00138838 File Offset: 0x00136A38
		public new vtkCellAttributeCalculator NewInstance()
		{
			vtkCellAttributeCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttributeCalculator.vtkCellAttributeCalculator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellAttributeCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E10A RID: 57610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttributeCalculator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E10B RID: 57611 RVA: 0x00138894 File Offset: 0x00136A94
		public new static vtkCellAttributeCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkCellAttributeCalculator vtkCellAttributeCalculator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttributeCalculator.vtkCellAttributeCalculator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttributeCalculator = (vtkCellAttributeCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttributeCalculator.Register(null);
				}
			}
			return vtkCellAttributeCalculator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001089 RID: 4233
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellAttributeCalculator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400108A RID: 4234
		public new static readonly string MRClassNameKey = "class vtkCellAttributeCalculator";
	}
}
