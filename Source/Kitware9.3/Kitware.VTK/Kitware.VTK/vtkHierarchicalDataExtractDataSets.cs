using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalDataExtractDataSets
	/// </summary>
	/// <remarks>
	///    extract a number of datasets
	///
	/// Legacy class. Use vtkExtractDataSets instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractDataSets
	/// </seealso>
	// Token: 0x020006BF RID: 1727
	public class vtkHierarchicalDataExtractDataSets : vtkExtractDataSets
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012703 RID: 75523 RVA: 0x0019D2E7 File Offset: 0x0019B4E7
		static vtkHierarchicalDataExtractDataSets()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataExtractDataSets.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataExtractDataSets"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012704 RID: 75524 RVA: 0x0019D30F File Offset: 0x0019B50F
		public vtkHierarchicalDataExtractDataSets(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012705 RID: 75525
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataExtractDataSets_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012706 RID: 75526 RVA: 0x0019D320 File Offset: 0x0019B520
		public new static vtkHierarchicalDataExtractDataSets New()
		{
			vtkHierarchicalDataExtractDataSets result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012707 RID: 75527 RVA: 0x0019D374 File Offset: 0x0019B574
		public vtkHierarchicalDataExtractDataSets() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012708 RID: 75528 RVA: 0x0019D3B8 File Offset: 0x0019B5B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012709 RID: 75529
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataExtractDataSets_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601270A RID: 75530 RVA: 0x0019D3C4 File Offset: 0x0019B5C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601270B RID: 75531
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataExtractDataSets_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601270C RID: 75532 RVA: 0x0019D3E4 File Offset: 0x0019B5E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601270D RID: 75533
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataExtractDataSets_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601270E RID: 75534 RVA: 0x0019D400 File Offset: 0x0019B600
		public override int IsA(string type)
		{
			return vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601270F RID: 75535
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataExtractDataSets_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012710 RID: 75536 RVA: 0x0019D420 File Offset: 0x0019B620
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_IsTypeOf_04(type);
		}

		// Token: 0x06012711 RID: 75537
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataExtractDataSets_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012712 RID: 75538 RVA: 0x0019D43C File Offset: 0x0019B63C
		public new vtkHierarchicalDataExtractDataSets NewInstance()
		{
			vtkHierarchicalDataExtractDataSets result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012713 RID: 75539
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataExtractDataSets_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012714 RID: 75540 RVA: 0x0019D498 File Offset: 0x0019B698
		public new static vtkHierarchicalDataExtractDataSets SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataExtractDataSets vtkHierarchicalDataExtractDataSets = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataExtractDataSets = (vtkHierarchicalDataExtractDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataExtractDataSets.Register(null);
				}
			}
			return vtkHierarchicalDataExtractDataSets;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400152E RID: 5422
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataExtractDataSets";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400152F RID: 5423
		public new static readonly string MRClassNameKey = "class vtkHierarchicalDataExtractDataSets";
	}
}
