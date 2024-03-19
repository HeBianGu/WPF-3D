using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkComputeQuartiles
	/// </summary>
	/// <remarks>
	///    Extract quartiles and extremum values
	/// of all columns of a table or all fields of a dataset.
	///
	///
	/// vtkComputeQuartiles accepts any vtkDataObject as input and produces a
	/// vtkTable data as output.
	/// This filter can be used to generate a table to create box plots
	/// using a vtkPlotBox instance.
	/// The filter internally uses vtkOrderStatistics to compute quartiles.
	///
	/// Note: This class is being kept for backwards compatibility. Please use vtkComputeQuantiles
	/// instead which is the generalized version of this filter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTableAlgorithm vtkOrderStatistics vtkPlotBox vtkChartBox
	///
	/// @par Thanks:
	/// This class was written by Kitware SAS and supported by EDF - www.edf.fr
	/// </seealso>
	// Token: 0x0200073F RID: 1855
	public class vtkComputeQuartiles : vtkComputeQuantiles
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060134BF RID: 79039 RVA: 0x001B49FF File Offset: 0x001B2BFF
		static vtkComputeQuartiles()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkComputeQuartiles.MRClassNameKey, Type.GetType("Kitware.VTK.vtkComputeQuartiles"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060134C0 RID: 79040 RVA: 0x001B4A27 File Offset: 0x001B2C27
		public vtkComputeQuartiles(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060134C1 RID: 79041
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeQuartiles_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134C2 RID: 79042 RVA: 0x001B4A38 File Offset: 0x001B2C38
		public new static vtkComputeQuartiles New()
		{
			vtkComputeQuartiles result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeQuartiles.vtkComputeQuartiles_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeQuartiles)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134C3 RID: 79043 RVA: 0x001B4A8C File Offset: 0x001B2C8C
		public vtkComputeQuartiles() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkComputeQuartiles.vtkComputeQuartiles_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060134C4 RID: 79044 RVA: 0x001B4AD0 File Offset: 0x001B2CD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060134C5 RID: 79045
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkComputeQuartiles_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134C6 RID: 79046 RVA: 0x001B4ADC File Offset: 0x001B2CDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkComputeQuartiles.vtkComputeQuartiles_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060134C7 RID: 79047
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkComputeQuartiles_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134C8 RID: 79048 RVA: 0x001B4AFC File Offset: 0x001B2CFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkComputeQuartiles.vtkComputeQuartiles_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060134C9 RID: 79049
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeQuartiles_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134CA RID: 79050 RVA: 0x001B4B18 File Offset: 0x001B2D18
		public override int IsA(string type)
		{
			return vtkComputeQuartiles.vtkComputeQuartiles_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060134CB RID: 79051
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeQuartiles_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134CC RID: 79052 RVA: 0x001B4B38 File Offset: 0x001B2D38
		public new static int IsTypeOf(string type)
		{
			return vtkComputeQuartiles.vtkComputeQuartiles_IsTypeOf_04(type);
		}

		// Token: 0x060134CD RID: 79053
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeQuartiles_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134CE RID: 79054 RVA: 0x001B4B54 File Offset: 0x001B2D54
		public new vtkComputeQuartiles NewInstance()
		{
			vtkComputeQuartiles result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeQuartiles.vtkComputeQuartiles_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeQuartiles)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060134CF RID: 79055
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeQuartiles_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134D0 RID: 79056 RVA: 0x001B4BB0 File Offset: 0x001B2DB0
		public new static vtkComputeQuartiles SafeDownCast(vtkObjectBase o)
		{
			vtkComputeQuartiles vtkComputeQuartiles = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeQuartiles.vtkComputeQuartiles_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkComputeQuartiles = (vtkComputeQuartiles)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkComputeQuartiles.Register(null);
				}
			}
			return vtkComputeQuartiles;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400164E RID: 5710
		public new const string MRFullTypeName = "Kitware.VTK.vtkComputeQuartiles";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400164F RID: 5711
		public new static readonly string MRClassNameKey = "class vtkComputeQuartiles";
	}
}
