using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShrinkFilter
	/// </summary>
	/// <remarks>
	///    shrink cells composing an arbitrary data set
	///
	/// vtkShrinkFilter shrinks cells composing an arbitrary data set
	/// towards their centroid. The centroid of a cell is computed as the
	/// average position of the cell points. Shrinking results in
	/// disconnecting the cells from one another. The output of this filter
	/// is of general dataset type vtkUnstructuredGrid.
	///
	/// @warning
	/// It is possible to turn cells inside out or cause self intersection
	/// in special cases.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkShrinkPolyData
	/// </seealso>
	// Token: 0x020008DC RID: 2268
	public class vtkShrinkFilter : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017713 RID: 96019 RVA: 0x0020E357 File Offset: 0x0020C557
		static vtkShrinkFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShrinkFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShrinkFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017714 RID: 96020 RVA: 0x0020E37F File Offset: 0x0020C57F
		public vtkShrinkFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017715 RID: 96021
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShrinkFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017716 RID: 96022 RVA: 0x0020E390 File Offset: 0x0020C590
		public new static vtkShrinkFilter New()
		{
			vtkShrinkFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShrinkFilter.vtkShrinkFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017717 RID: 96023 RVA: 0x0020E3E4 File Offset: 0x0020C5E4
		public vtkShrinkFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShrinkFilter.vtkShrinkFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017718 RID: 96024 RVA: 0x0020E428 File Offset: 0x0020C628
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017719 RID: 96025
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShrinkFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601771A RID: 96026 RVA: 0x0020E434 File Offset: 0x0020C634
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601771B RID: 96027
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShrinkFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601771C RID: 96028 RVA: 0x0020E454 File Offset: 0x0020C654
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601771D RID: 96029
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShrinkFilter_GetShrinkFactor_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the fraction of shrink for each cell. The default is 0.5.
		/// </summary>
		// Token: 0x0601771E RID: 96030 RVA: 0x0020E470 File Offset: 0x0020C670
		public virtual double GetShrinkFactor()
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetShrinkFactor_03(base.GetCppThis());
		}

		// Token: 0x0601771F RID: 96031
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShrinkFilter_GetShrinkFactorMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the fraction of shrink for each cell. The default is 0.5.
		/// </summary>
		// Token: 0x06017720 RID: 96032 RVA: 0x0020E490 File Offset: 0x0020C690
		public virtual double GetShrinkFactorMaxValue()
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetShrinkFactorMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06017721 RID: 96033
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShrinkFilter_GetShrinkFactorMinValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the fraction of shrink for each cell. The default is 0.5.
		/// </summary>
		// Token: 0x06017722 RID: 96034 RVA: 0x0020E4B0 File Offset: 0x0020C6B0
		public virtual double GetShrinkFactorMinValue()
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetShrinkFactorMinValue_05(base.GetCppThis());
		}

		// Token: 0x06017723 RID: 96035
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShrinkFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017724 RID: 96036 RVA: 0x0020E4D0 File Offset: 0x0020C6D0
		public override int IsA(string type)
		{
			return vtkShrinkFilter.vtkShrinkFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06017725 RID: 96037
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShrinkFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017726 RID: 96038 RVA: 0x0020E4F0 File Offset: 0x0020C6F0
		public new static int IsTypeOf(string type)
		{
			return vtkShrinkFilter.vtkShrinkFilter_IsTypeOf_07(type);
		}

		// Token: 0x06017727 RID: 96039
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShrinkFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017728 RID: 96040 RVA: 0x0020E50C File Offset: 0x0020C70C
		public new vtkShrinkFilter NewInstance()
		{
			vtkShrinkFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShrinkFilter.vtkShrinkFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017729 RID: 96041
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShrinkFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601772A RID: 96042 RVA: 0x0020E568 File Offset: 0x0020C768
		public new static vtkShrinkFilter SafeDownCast(vtkObjectBase o)
		{
			vtkShrinkFilter vtkShrinkFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShrinkFilter.vtkShrinkFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShrinkFilter = (vtkShrinkFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShrinkFilter.Register(null);
				}
			}
			return vtkShrinkFilter;
		}

		// Token: 0x0601772B RID: 96043
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShrinkFilter_SetShrinkFactor_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the fraction of shrink for each cell. The default is 0.5.
		/// </summary>
		// Token: 0x0601772C RID: 96044 RVA: 0x0020E5E7 File Offset: 0x0020C7E7
		public virtual void SetShrinkFactor(double _arg)
		{
			vtkShrinkFilter.vtkShrinkFilter_SetShrinkFactor_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A2D RID: 6701
		public new const string MRFullTypeName = "Kitware.VTK.vtkShrinkFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A2E RID: 6702
		public new static readonly string MRClassNameKey = "class vtkShrinkFilter";
	}
}
