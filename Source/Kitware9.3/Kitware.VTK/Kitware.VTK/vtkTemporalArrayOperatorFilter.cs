using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalArrayOperatorFilter
	/// </summary>
	/// <remarks>
	///    perform simple mathematical operation on a data array at different time
	///
	/// This filter computes a simple operation between two time steps of one
	/// data array.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArrayCalulator
	/// </seealso>
	// Token: 0x02000617 RID: 1559
	public class vtkTemporalArrayOperatorFilter : vtkMultiTimeStepAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010EF4 RID: 69364 RVA: 0x00179947 File Offset: 0x00177B47
		static vtkTemporalArrayOperatorFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalArrayOperatorFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalArrayOperatorFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010EF5 RID: 69365 RVA: 0x0017996F File Offset: 0x00177B6F
		public vtkTemporalArrayOperatorFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010EF6 RID: 69366
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalArrayOperatorFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EF7 RID: 69367 RVA: 0x00179980 File Offset: 0x00177B80
		public new static vtkTemporalArrayOperatorFilter New()
		{
			vtkTemporalArrayOperatorFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalArrayOperatorFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EF8 RID: 69368 RVA: 0x001799D4 File Offset: 0x00177BD4
		public vtkTemporalArrayOperatorFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010EF9 RID: 69369 RVA: 0x00179A18 File Offset: 0x00177C18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010EFA RID: 69370
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalArrayOperatorFilter_GetFirstTimeStepIndex_01(HandleRef pThis);

		/// <summary>
		/// @brief Set/Get the first time step.
		/// </summary>
		// Token: 0x06010EFB RID: 69371 RVA: 0x00179A24 File Offset: 0x00177C24
		public virtual int GetFirstTimeStepIndex()
		{
			return vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_GetFirstTimeStepIndex_01(base.GetCppThis());
		}

		// Token: 0x06010EFC RID: 69372
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EFD RID: 69373 RVA: 0x00179A44 File Offset: 0x00177C44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06010EFE RID: 69374
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010EFF RID: 69375 RVA: 0x00179A64 File Offset: 0x00177C64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06010F00 RID: 69376
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalArrayOperatorFilter_GetOperator_04(HandleRef pThis);

		/// <summary>
		/// @brief Set/Get the operator to apply. Default is ADD (0).
		/// </summary>
		// Token: 0x06010F01 RID: 69377 RVA: 0x00179A80 File Offset: 0x00177C80
		public virtual int GetOperator()
		{
			return vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_GetOperator_04(base.GetCppThis());
		}

		// Token: 0x06010F02 RID: 69378
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalArrayOperatorFilter_GetOutputArrayNameSuffix_05(HandleRef pThis);

		/// <summary>
		/// @brief Set/Get the suffix to be append to the output array name.
		/// If not specified, output will be suffixed with '_' and the operation
		/// type (eg. myarrayname_add).
		/// </summary>
		// Token: 0x06010F03 RID: 69379 RVA: 0x00179AA0 File Offset: 0x00177CA0
		public virtual string GetOutputArrayNameSuffix()
		{
			string s = Marshal.PtrToStringAnsi(vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_GetOutputArrayNameSuffix_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010F04 RID: 69380
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalArrayOperatorFilter_GetSecondTimeStepIndex_06(HandleRef pThis);

		/// <summary>
		/// @brief Set/Get the second time step.
		/// </summary>
		// Token: 0x06010F05 RID: 69381 RVA: 0x00179ADC File Offset: 0x00177CDC
		public virtual int GetSecondTimeStepIndex()
		{
			return vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_GetSecondTimeStepIndex_06(base.GetCppThis());
		}

		// Token: 0x06010F06 RID: 69382
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalArrayOperatorFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F07 RID: 69383 RVA: 0x00179AFC File Offset: 0x00177CFC
		public override int IsA(string type)
		{
			return vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06010F08 RID: 69384
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalArrayOperatorFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F09 RID: 69385 RVA: 0x00179B1C File Offset: 0x00177D1C
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_IsTypeOf_08(type);
		}

		// Token: 0x06010F0A RID: 69386
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalArrayOperatorFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F0B RID: 69387 RVA: 0x00179B38 File Offset: 0x00177D38
		public new vtkTemporalArrayOperatorFilter NewInstance()
		{
			vtkTemporalArrayOperatorFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalArrayOperatorFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010F0C RID: 69388
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalArrayOperatorFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F0D RID: 69389 RVA: 0x00179B94 File Offset: 0x00177D94
		public new static vtkTemporalArrayOperatorFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalArrayOperatorFilter vtkTemporalArrayOperatorFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalArrayOperatorFilter = (vtkTemporalArrayOperatorFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalArrayOperatorFilter.Register(null);
				}
			}
			return vtkTemporalArrayOperatorFilter;
		}

		// Token: 0x06010F0E RID: 69390
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalArrayOperatorFilter_SetFirstTimeStepIndex_12(HandleRef pThis, int _arg);

		/// <summary>
		/// @brief Set/Get the first time step.
		/// </summary>
		// Token: 0x06010F0F RID: 69391 RVA: 0x00179C13 File Offset: 0x00177E13
		public virtual void SetFirstTimeStepIndex(int _arg)
		{
			vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_SetFirstTimeStepIndex_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F10 RID: 69392
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalArrayOperatorFilter_SetOperator_13(HandleRef pThis, int _arg);

		/// <summary>
		/// @brief Set/Get the operator to apply. Default is ADD (0).
		/// </summary>
		// Token: 0x06010F11 RID: 69393 RVA: 0x00179C23 File Offset: 0x00177E23
		public virtual void SetOperator(int _arg)
		{
			vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_SetOperator_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F12 RID: 69394
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalArrayOperatorFilter_SetOutputArrayNameSuffix_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// @brief Set/Get the suffix to be append to the output array name.
		/// If not specified, output will be suffixed with '_' and the operation
		/// type (eg. myarrayname_add).
		/// </summary>
		// Token: 0x06010F13 RID: 69395 RVA: 0x00179C33 File Offset: 0x00177E33
		public virtual void SetOutputArrayNameSuffix(string _arg)
		{
			vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_SetOutputArrayNameSuffix_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F14 RID: 69396
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalArrayOperatorFilter_SetSecondTimeStepIndex_15(HandleRef pThis, int _arg);

		/// <summary>
		/// @brief Set/Get the second time step.
		/// </summary>
		// Token: 0x06010F15 RID: 69397 RVA: 0x00179C43 File Offset: 0x00177E43
		public virtual void SetSecondTimeStepIndex(int _arg)
		{
			vtkTemporalArrayOperatorFilter.vtkTemporalArrayOperatorFilter_SetSecondTimeStepIndex_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400138D RID: 5005
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalArrayOperatorFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400138E RID: 5006
		public new static readonly string MRClassNameKey = "class vtkTemporalArrayOperatorFilter";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000618 RID: 1560
		public enum OperatorType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001390 RID: 5008
			ADD,
			/// <summary>enum member</summary>
			// Token: 0x04001391 RID: 5009
			DIV = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001392 RID: 5010
			MUL = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001393 RID: 5011
			SUB = 1
		}
	}
}
