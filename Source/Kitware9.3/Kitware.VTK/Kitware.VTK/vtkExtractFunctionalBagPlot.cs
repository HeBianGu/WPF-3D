using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractFunctionalBagPlot
	///
	///
	/// From an input table containing series on port 0 and another table
	/// describing densities on port 1 (for instance obtained by applying
	/// filter  vtkHighestDensityRegionsStatistics, this filter generates
	/// a table containing all the columns of the input port 0 plus two 2
	/// components columns containing the bag series to be used by
	/// vtkFunctionalBagPlot.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkFunctionalBagPlot vtkHighestDensityRegionsStatistics
	/// </seealso>
	// Token: 0x02000743 RID: 1859
	public class vtkExtractFunctionalBagPlot : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013521 RID: 79137 RVA: 0x001B5467 File Offset: 0x001B3667
		static vtkExtractFunctionalBagPlot()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractFunctionalBagPlot.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractFunctionalBagPlot"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013522 RID: 79138 RVA: 0x001B548F File Offset: 0x001B368F
		public vtkExtractFunctionalBagPlot(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013523 RID: 79139
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractFunctionalBagPlot_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013524 RID: 79140 RVA: 0x001B54A0 File Offset: 0x001B36A0
		public new static vtkExtractFunctionalBagPlot New()
		{
			vtkExtractFunctionalBagPlot result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractFunctionalBagPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013525 RID: 79141 RVA: 0x001B54F4 File Offset: 0x001B36F4
		public vtkExtractFunctionalBagPlot() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013526 RID: 79142 RVA: 0x001B5538 File Offset: 0x001B3738
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013527 RID: 79143
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractFunctionalBagPlot_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013528 RID: 79144 RVA: 0x001B5544 File Offset: 0x001B3744
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013529 RID: 79145
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractFunctionalBagPlot_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601352A RID: 79146 RVA: 0x001B5564 File Offset: 0x001B3764
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601352B RID: 79147
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractFunctionalBagPlot_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601352C RID: 79148 RVA: 0x001B5580 File Offset: 0x001B3780
		public override int IsA(string type)
		{
			return vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601352D RID: 79149
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractFunctionalBagPlot_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601352E RID: 79150 RVA: 0x001B55A0 File Offset: 0x001B37A0
		public new static int IsTypeOf(string type)
		{
			return vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_IsTypeOf_04(type);
		}

		// Token: 0x0601352F RID: 79151
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractFunctionalBagPlot_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013530 RID: 79152 RVA: 0x001B55BC File Offset: 0x001B37BC
		public new vtkExtractFunctionalBagPlot NewInstance()
		{
			vtkExtractFunctionalBagPlot result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractFunctionalBagPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013531 RID: 79153
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractFunctionalBagPlot_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013532 RID: 79154 RVA: 0x001B5618 File Offset: 0x001B3818
		public new static vtkExtractFunctionalBagPlot SafeDownCast(vtkObjectBase o)
		{
			vtkExtractFunctionalBagPlot vtkExtractFunctionalBagPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractFunctionalBagPlot = (vtkExtractFunctionalBagPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractFunctionalBagPlot.Register(null);
				}
			}
			return vtkExtractFunctionalBagPlot;
		}

		// Token: 0x06013533 RID: 79155
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractFunctionalBagPlot_SetDensityForP50_08(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013534 RID: 79156 RVA: 0x001B5697 File Offset: 0x001B3897
		public virtual void SetDensityForP50(double _arg)
		{
			vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_SetDensityForP50_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06013535 RID: 79157
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractFunctionalBagPlot_SetDensityForPUser_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Density value for the user defined quartile.
		/// </summary>
		// Token: 0x06013536 RID: 79158 RVA: 0x001B56A7 File Offset: 0x001B38A7
		public virtual void SetDensityForPUser(double _arg)
		{
			vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_SetDensityForPUser_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06013537 RID: 79159
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractFunctionalBagPlot_SetPUser_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Density value for the user defined quartile.
		/// </summary>
		// Token: 0x06013538 RID: 79160 RVA: 0x001B56B7 File Offset: 0x001B38B7
		public virtual void SetPUser(int _arg)
		{
			vtkExtractFunctionalBagPlot.vtkExtractFunctionalBagPlot_SetPUser_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001656 RID: 5718
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractFunctionalBagPlot";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001657 RID: 5719
		public new static readonly string MRClassNameKey = "class vtkExtractFunctionalBagPlot";
	}
}
