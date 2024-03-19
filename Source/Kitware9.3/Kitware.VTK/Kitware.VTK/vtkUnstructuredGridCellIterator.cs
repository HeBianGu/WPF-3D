using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridCellIterator
	/// </summary>
	/// <remarks>
	///    Implementation of vtkCellIterator
	/// specialized for vtkUnstructuredGrid.
	/// </remarks>
	// Token: 0x02000ADF RID: 2783
	public class vtkUnstructuredGridCellIterator : vtkCellIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D5AA RID: 120234 RVA: 0x00297056 File Offset: 0x00295256
		static vtkUnstructuredGridCellIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridCellIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridCellIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D5AB RID: 120235 RVA: 0x0029707E File Offset: 0x0029527E
		public vtkUnstructuredGridCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D5AC RID: 120236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridCellIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5AD RID: 120237 RVA: 0x0029708C File Offset: 0x0029528C
		public new static vtkUnstructuredGridCellIterator New()
		{
			vtkUnstructuredGridCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5AE RID: 120238 RVA: 0x002970E0 File Offset: 0x002952E0
		public vtkUnstructuredGridCellIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D5AF RID: 120239 RVA: 0x00297124 File Offset: 0x00295324
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D5B0 RID: 120240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridCellIterator_GetCellId_01(HandleRef pThis);

		/// <summary>
		/// Override superclass methods.
		/// </summary>
		// Token: 0x0601D5B1 RID: 120241 RVA: 0x00297130 File Offset: 0x00295330
		public override long GetCellId()
		{
			return vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_GetCellId_01(base.GetCppThis());
		}

		// Token: 0x0601D5B2 RID: 120242
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridCellIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5B3 RID: 120243 RVA: 0x00297150 File Offset: 0x00295350
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601D5B4 RID: 120244
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridCellIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5B5 RID: 120245 RVA: 0x00297170 File Offset: 0x00295370
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601D5B6 RID: 120246
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridCellIterator_GoToCell_04(HandleRef pThis, long cellId);

		/// <summary>
		/// A method used to provide random access into cells. The iterator is
		/// initialized to a specific cell. This method can always be used to set
		/// the starting location for forward iteration, and it is also used to
		/// support random access.
		/// </summary>
		// Token: 0x0601D5B7 RID: 120247 RVA: 0x0029718A File Offset: 0x0029538A
		public void GoToCell(long cellId)
		{
			vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_GoToCell_04(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D5B8 RID: 120248
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridCellIterator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5B9 RID: 120249 RVA: 0x0029719C File Offset: 0x0029539C
		public override int IsA(string type)
		{
			return vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D5BA RID: 120250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUnstructuredGridCellIterator_IsDoneWithTraversal_06(HandleRef pThis);

		/// <summary>
		/// Override superclass methods.
		/// </summary>
		// Token: 0x0601D5BB RID: 120251 RVA: 0x002971BC File Offset: 0x002953BC
		public override bool IsDoneWithTraversal()
		{
			return vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_IsDoneWithTraversal_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D5BC RID: 120252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridCellIterator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5BD RID: 120253 RVA: 0x002971E4 File Offset: 0x002953E4
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_IsTypeOf_07(type);
		}

		// Token: 0x0601D5BE RID: 120254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridCellIterator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5BF RID: 120255 RVA: 0x00297200 File Offset: 0x00295400
		public new vtkUnstructuredGridCellIterator NewInstance()
		{
			vtkUnstructuredGridCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D5C0 RID: 120256
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridCellIterator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601D5C1 RID: 120257 RVA: 0x0029725C File Offset: 0x0029545C
		public new static vtkUnstructuredGridCellIterator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridCellIterator vtkUnstructuredGridCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridCellIterator.vtkUnstructuredGridCellIterator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridCellIterator = (vtkUnstructuredGridCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridCellIterator.Register(null);
				}
			}
			return vtkUnstructuredGridCellIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE5 RID: 7909
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridCellIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE6 RID: 7910
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridCellIterator";
	}
}
