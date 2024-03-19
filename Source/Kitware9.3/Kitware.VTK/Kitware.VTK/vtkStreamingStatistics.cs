using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStreamingStatistics
	/// </summary>
	/// <remarks>
	///    A class for using the statistics filters
	/// in a streaming mode.
	///
	///
	/// A class for using the statistics filters in a streaming mode or perhaps
	/// an "online, incremental, push" mode.
	///
	/// @par Thanks:
	/// Thanks to the Universe for unfolding in a way that allowed this class
	/// to be implemented, also Godzilla for not crushing my computer.
	/// </remarks>
	// Token: 0x02000751 RID: 1873
	public class vtkStreamingStatistics : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060136F7 RID: 79607 RVA: 0x001B7F43 File Offset: 0x001B6143
		static vtkStreamingStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamingStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamingStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060136F8 RID: 79608 RVA: 0x001B7F6B File Offset: 0x001B616B
		public vtkStreamingStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060136F9 RID: 79609
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136FA RID: 79610 RVA: 0x001B7F7C File Offset: 0x001B617C
		public new static vtkStreamingStatistics New()
		{
			vtkStreamingStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingStatistics.vtkStreamingStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136FB RID: 79611 RVA: 0x001B7FD0 File Offset: 0x001B61D0
		public vtkStreamingStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStreamingStatistics.vtkStreamingStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060136FC RID: 79612 RVA: 0x001B8014 File Offset: 0x001B6214
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060136FD RID: 79613
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamingStatistics_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136FE RID: 79614 RVA: 0x001B8020 File Offset: 0x001B6220
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStreamingStatistics.vtkStreamingStatistics_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060136FF RID: 79615
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamingStatistics_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013700 RID: 79616 RVA: 0x001B8040 File Offset: 0x001B6240
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStreamingStatistics.vtkStreamingStatistics_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06013701 RID: 79617
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingStatistics_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013702 RID: 79618 RVA: 0x001B805C File Offset: 0x001B625C
		public override int IsA(string type)
		{
			return vtkStreamingStatistics.vtkStreamingStatistics_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06013703 RID: 79619
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingStatistics_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013704 RID: 79620 RVA: 0x001B807C File Offset: 0x001B627C
		public new static int IsTypeOf(string type)
		{
			return vtkStreamingStatistics.vtkStreamingStatistics_IsTypeOf_04(type);
		}

		// Token: 0x06013705 RID: 79621
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingStatistics_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013706 RID: 79622 RVA: 0x001B8098 File Offset: 0x001B6298
		public new vtkStreamingStatistics NewInstance()
		{
			vtkStreamingStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingStatistics.vtkStreamingStatistics_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013707 RID: 79623
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingStatistics_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013708 RID: 79624 RVA: 0x001B80F4 File Offset: 0x001B62F4
		public new static vtkStreamingStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkStreamingStatistics vtkStreamingStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingStatistics.vtkStreamingStatistics_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamingStatistics = (vtkStreamingStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamingStatistics.Register(null);
				}
			}
			return vtkStreamingStatistics;
		}

		// Token: 0x06013709 RID: 79625
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamingStatistics_SetStatisticsAlgorithm_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// enumeration values to specify output port types
		/// </summary>
		// Token: 0x0601370A RID: 79626 RVA: 0x001B8174 File Offset: 0x001B6374
		public virtual void SetStatisticsAlgorithm(vtkStatisticsAlgorithm arg0)
		{
			vtkStreamingStatistics.vtkStreamingStatistics_SetStatisticsAlgorithm_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400167B RID: 5755
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamingStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400167C RID: 5756
		public new static readonly string MRClassNameKey = "class vtkStreamingStatistics";

		/// <summary>
		/// enumeration values to specify input port types
		/// </summary>
		// Token: 0x02000752 RID: 1874
		public enum InputPorts
		{
			/// <summary>enum member</summary>
			// Token: 0x0400167E RID: 5758
			INPUT_DATA,
			/// <summary>enum member</summary>
			// Token: 0x0400167F RID: 5759
			INPUT_MODEL = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001680 RID: 5760
			LEARN_PARAMETERS = 1
		}

		/// <summary>
		/// enumeration values to specify output port types
		/// </summary>
		// Token: 0x02000753 RID: 1875
		public enum OutputIndices
		{
			/// <summary>enum member</summary>
			// Token: 0x04001682 RID: 5762
			OUTPUT_DATA,
			/// <summary>enum member</summary>
			// Token: 0x04001683 RID: 5763
			OUTPUT_MODEL,
			/// <summary>enum member</summary>
			// Token: 0x04001684 RID: 5764
			OUTPUT_TEST
		}
	}
}
