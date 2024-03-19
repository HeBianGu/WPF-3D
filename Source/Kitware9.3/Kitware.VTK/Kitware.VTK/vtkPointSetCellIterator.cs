using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSetCellIterator
	/// </summary>
	/// <remarks>
	///    Implementation of vtkCellIterator using
	/// vtkPointSet API.
	/// </remarks>
	// Token: 0x02000A9C RID: 2716
	public class vtkPointSetCellIterator : vtkCellIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C7C3 RID: 116675 RVA: 0x002803FF File Offset: 0x0027E5FF
		static vtkPointSetCellIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSetCellIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetCellIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C7C4 RID: 116676 RVA: 0x00280427 File Offset: 0x0027E627
		public vtkPointSetCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C7C5 RID: 116677
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetCellIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7C6 RID: 116678 RVA: 0x00280438 File Offset: 0x0027E638
		public new static vtkPointSetCellIterator New()
		{
			vtkPointSetCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetCellIterator.vtkPointSetCellIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7C7 RID: 116679 RVA: 0x0028048C File Offset: 0x0027E68C
		public vtkPointSetCellIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSetCellIterator.vtkPointSetCellIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C7C8 RID: 116680 RVA: 0x002804D0 File Offset: 0x0027E6D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C7C9 RID: 116681
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetCellIterator_GetCellId_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7CA RID: 116682 RVA: 0x002804DC File Offset: 0x0027E6DC
		public override long GetCellId()
		{
			return vtkPointSetCellIterator.vtkPointSetCellIterator_GetCellId_01(base.GetCppThis());
		}

		// Token: 0x0601C7CB RID: 116683
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetCellIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7CC RID: 116684 RVA: 0x002804FC File Offset: 0x0027E6FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSetCellIterator.vtkPointSetCellIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601C7CD RID: 116685
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetCellIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7CE RID: 116686 RVA: 0x0028051C File Offset: 0x0027E71C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSetCellIterator.vtkPointSetCellIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601C7CF RID: 116687
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetCellIterator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7D0 RID: 116688 RVA: 0x00280538 File Offset: 0x0027E738
		public override int IsA(string type)
		{
			return vtkPointSetCellIterator.vtkPointSetCellIterator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C7D1 RID: 116689
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetCellIterator_IsDoneWithTraversal_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7D2 RID: 116690 RVA: 0x00280558 File Offset: 0x0027E758
		public override bool IsDoneWithTraversal()
		{
			return vtkPointSetCellIterator.vtkPointSetCellIterator_IsDoneWithTraversal_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601C7D3 RID: 116691
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetCellIterator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7D4 RID: 116692 RVA: 0x00280580 File Offset: 0x0027E780
		public new static int IsTypeOf(string type)
		{
			return vtkPointSetCellIterator.vtkPointSetCellIterator_IsTypeOf_06(type);
		}

		// Token: 0x0601C7D5 RID: 116693
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetCellIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7D6 RID: 116694 RVA: 0x0028059C File Offset: 0x0027E79C
		public new vtkPointSetCellIterator NewInstance()
		{
			vtkPointSetCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetCellIterator.vtkPointSetCellIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C7D7 RID: 116695
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetCellIterator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7D8 RID: 116696 RVA: 0x002805F8 File Offset: 0x0027E7F8
		public new static vtkPointSetCellIterator SafeDownCast(vtkObjectBase o)
		{
			vtkPointSetCellIterator vtkPointSetCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetCellIterator.vtkPointSetCellIterator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSetCellIterator = (vtkPointSetCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSetCellIterator.Register(null);
				}
			}
			return vtkPointSetCellIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E39 RID: 7737
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetCellIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E3A RID: 7738
		public new static readonly string MRClassNameKey = "class vtkPointSetCellIterator";
	}
}
