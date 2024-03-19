using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalDataExtractLevel
	/// </summary>
	/// <remarks>
	///    extract levels between min and max
	///
	/// Legacy class. Use vtkExtractLevel instead.
	/// </remarks>
	// Token: 0x020006C0 RID: 1728
	public class vtkHierarchicalDataExtractLevel : vtkExtractLevel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012715 RID: 75541 RVA: 0x0019D517 File Offset: 0x0019B717
		static vtkHierarchicalDataExtractLevel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataExtractLevel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataExtractLevel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012716 RID: 75542 RVA: 0x0019D53F File Offset: 0x0019B73F
		public vtkHierarchicalDataExtractLevel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012717 RID: 75543
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataExtractLevel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012718 RID: 75544 RVA: 0x0019D550 File Offset: 0x0019B750
		public new static vtkHierarchicalDataExtractLevel New()
		{
			vtkHierarchicalDataExtractLevel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractLevel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012719 RID: 75545 RVA: 0x0019D5A4 File Offset: 0x0019B7A4
		public vtkHierarchicalDataExtractLevel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601271A RID: 75546 RVA: 0x0019D5E8 File Offset: 0x0019B7E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601271B RID: 75547
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataExtractLevel_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601271C RID: 75548 RVA: 0x0019D5F4 File Offset: 0x0019B7F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601271D RID: 75549
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataExtractLevel_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601271E RID: 75550 RVA: 0x0019D614 File Offset: 0x0019B814
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601271F RID: 75551
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataExtractLevel_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012720 RID: 75552 RVA: 0x0019D630 File Offset: 0x0019B830
		public override int IsA(string type)
		{
			return vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012721 RID: 75553
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataExtractLevel_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012722 RID: 75554 RVA: 0x0019D650 File Offset: 0x0019B850
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_IsTypeOf_04(type);
		}

		// Token: 0x06012723 RID: 75555
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataExtractLevel_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012724 RID: 75556 RVA: 0x0019D66C File Offset: 0x0019B86C
		public new vtkHierarchicalDataExtractLevel NewInstance()
		{
			vtkHierarchicalDataExtractLevel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractLevel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012725 RID: 75557
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataExtractLevel_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012726 RID: 75558 RVA: 0x0019D6C8 File Offset: 0x0019B8C8
		public new static vtkHierarchicalDataExtractLevel SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataExtractLevel vtkHierarchicalDataExtractLevel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataExtractLevel = (vtkHierarchicalDataExtractLevel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataExtractLevel.Register(null);
				}
			}
			return vtkHierarchicalDataExtractLevel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001530 RID: 5424
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataExtractLevel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001531 RID: 5425
		public new static readonly string MRClassNameKey = "class vtkHierarchicalDataExtractLevel";
	}
}
