using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetCellIterator
	/// </summary>
	/// <remarks>
	///    Implementation of vtkCellIterator using
	/// vtkDataSet API.
	/// </remarks>
	// Token: 0x02000A3E RID: 2622
	public class vtkDataSetCellIterator : vtkCellIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B4F8 RID: 111864 RVA: 0x00262D13 File Offset: 0x00260F13
		static vtkDataSetCellIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetCellIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetCellIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B4F9 RID: 111865 RVA: 0x00262D3B File Offset: 0x00260F3B
		public vtkDataSetCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B4FA RID: 111866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCellIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4FB RID: 111867 RVA: 0x00262D4C File Offset: 0x00260F4C
		public new static vtkDataSetCellIterator New()
		{
			vtkDataSetCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCellIterator.vtkDataSetCellIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4FC RID: 111868 RVA: 0x00262DA0 File Offset: 0x00260FA0
		public vtkDataSetCellIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetCellIterator.vtkDataSetCellIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B4FD RID: 111869 RVA: 0x00262DE4 File Offset: 0x00260FE4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B4FE RID: 111870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetCellIterator_GetCellId_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4FF RID: 111871 RVA: 0x00262DF0 File Offset: 0x00260FF0
		public override long GetCellId()
		{
			return vtkDataSetCellIterator.vtkDataSetCellIterator_GetCellId_01(base.GetCppThis());
		}

		// Token: 0x0601B500 RID: 111872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetCellIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B501 RID: 111873 RVA: 0x00262E10 File Offset: 0x00261010
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetCellIterator.vtkDataSetCellIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601B502 RID: 111874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetCellIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B503 RID: 111875 RVA: 0x00262E30 File Offset: 0x00261030
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetCellIterator.vtkDataSetCellIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601B504 RID: 111876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetCellIterator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B505 RID: 111877 RVA: 0x00262E4C File Offset: 0x0026104C
		public override int IsA(string type)
		{
			return vtkDataSetCellIterator.vtkDataSetCellIterator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B506 RID: 111878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSetCellIterator_IsDoneWithTraversal_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B507 RID: 111879 RVA: 0x00262E6C File Offset: 0x0026106C
		public override bool IsDoneWithTraversal()
		{
			return vtkDataSetCellIterator.vtkDataSetCellIterator_IsDoneWithTraversal_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B508 RID: 111880
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetCellIterator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B509 RID: 111881 RVA: 0x00262E94 File Offset: 0x00261094
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetCellIterator.vtkDataSetCellIterator_IsTypeOf_06(type);
		}

		// Token: 0x0601B50A RID: 111882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCellIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B50B RID: 111883 RVA: 0x00262EB0 File Offset: 0x002610B0
		public new vtkDataSetCellIterator NewInstance()
		{
			vtkDataSetCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCellIterator.vtkDataSetCellIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B50C RID: 111884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCellIterator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B50D RID: 111885 RVA: 0x00262F0C File Offset: 0x0026110C
		public new static vtkDataSetCellIterator SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetCellIterator vtkDataSetCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCellIterator.vtkDataSetCellIterator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCellIterator = (vtkDataSetCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCellIterator.Register(null);
				}
			}
			return vtkDataSetCellIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D70 RID: 7536
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetCellIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D71 RID: 7537
		public new static readonly string MRClassNameKey = "class vtkDataSetCellIterator";
	}
}
