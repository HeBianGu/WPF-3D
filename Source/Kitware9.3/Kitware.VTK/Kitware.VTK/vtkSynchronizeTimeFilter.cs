using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSynchronizeTimeFilter
	/// </summary>
	/// <remarks>
	///    Set "close" time step values from the second input to the first
	///
	/// Synchronize time step values in the first input to time step
	/// values in the second input that are considered close enough.
	/// The outputted data set is from the first input and the number of
	/// output time steps is also equal to the number of time steps in
	/// the first input. Time step values in the first input that are
	/// "close" to time step values in the second input are replaced
	/// with the value from the second input. Close is determined to
	/// be if the difference is less than RelativeTolerance multiplied
	/// by the time range of the first input.
	/// </remarks>
	// Token: 0x020008E9 RID: 2281
	public class vtkSynchronizeTimeFilter : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017895 RID: 96405 RVA: 0x00210685 File Offset: 0x0020E885
		static vtkSynchronizeTimeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizeTimeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizeTimeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017896 RID: 96406 RVA: 0x002106AD File Offset: 0x0020E8AD
		public vtkSynchronizeTimeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017897 RID: 96407
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizeTimeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017898 RID: 96408 RVA: 0x002106BC File Offset: 0x0020E8BC
		public new static vtkSynchronizeTimeFilter New()
		{
			vtkSynchronizeTimeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizeTimeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017899 RID: 96409 RVA: 0x00210710 File Offset: 0x0020E910
		public vtkSynchronizeTimeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601789A RID: 96410 RVA: 0x00210754 File Offset: 0x0020E954
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601789B RID: 96411
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601789C RID: 96412 RVA: 0x00210760 File Offset: 0x0020E960
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601789D RID: 96413
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601789E RID: 96414 RVA: 0x00210780 File Offset: 0x0020E980
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601789F RID: 96415
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSynchronizeTimeFilter_GetRelativeTolerance_03(HandleRef pThis);

		/// <summary>
		/// Set/get the relative tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical.
		/// </summary>
		// Token: 0x060178A0 RID: 96416 RVA: 0x0021079C File Offset: 0x0020E99C
		public virtual double GetRelativeTolerance()
		{
			return vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_GetRelativeTolerance_03(base.GetCppThis());
		}

		// Token: 0x060178A1 RID: 96417
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSynchronizeTimeFilter_GetRelativeToleranceMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/get the relative tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical.
		/// </summary>
		// Token: 0x060178A2 RID: 96418 RVA: 0x002107BC File Offset: 0x0020E9BC
		public virtual double GetRelativeToleranceMaxValue()
		{
			return vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_GetRelativeToleranceMaxValue_04(base.GetCppThis());
		}

		// Token: 0x060178A3 RID: 96419
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSynchronizeTimeFilter_GetRelativeToleranceMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/get the relative tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical.
		/// </summary>
		// Token: 0x060178A4 RID: 96420 RVA: 0x002107DC File Offset: 0x0020E9DC
		public virtual double GetRelativeToleranceMinValue()
		{
			return vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_GetRelativeToleranceMinValue_05(base.GetCppThis());
		}

		// Token: 0x060178A5 RID: 96421
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizeTimeFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178A6 RID: 96422 RVA: 0x002107FC File Offset: 0x0020E9FC
		public override int IsA(string type)
		{
			return vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060178A7 RID: 96423
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizeTimeFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178A8 RID: 96424 RVA: 0x0021081C File Offset: 0x0020EA1C
		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_IsTypeOf_07(type);
		}

		// Token: 0x060178A9 RID: 96425
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizeTimeFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178AA RID: 96426 RVA: 0x00210838 File Offset: 0x0020EA38
		public new vtkSynchronizeTimeFilter NewInstance()
		{
			vtkSynchronizeTimeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizeTimeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060178AB RID: 96427
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizeTimeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178AC RID: 96428 RVA: 0x00210894 File Offset: 0x0020EA94
		public new static vtkSynchronizeTimeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizeTimeFilter vtkSynchronizeTimeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizeTimeFilter = (vtkSynchronizeTimeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizeTimeFilter.Register(null);
				}
			}
			return vtkSynchronizeTimeFilter;
		}

		// Token: 0x060178AD RID: 96429
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizeTimeFilter_SetRelativeTolerance_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the relative tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical.
		/// </summary>
		// Token: 0x060178AE RID: 96430 RVA: 0x00210913 File Offset: 0x0020EB13
		public virtual void SetRelativeTolerance(double _arg)
		{
			vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_SetRelativeTolerance_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060178AF RID: 96431
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizeTimeFilter_SetSourceConnection_12(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the input that we may potentially replace time
		/// steps with. SetInputConnection() should be used for providing the data
		/// set that will actually be output from this filter.
		/// </summary>
		// Token: 0x060178B0 RID: 96432 RVA: 0x00210924 File Offset: 0x0020EB24
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkSynchronizeTimeFilter.vtkSynchronizeTimeFilter_SetSourceConnection_12(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A4C RID: 6732
		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizeTimeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A4D RID: 6733
		public new static readonly string MRClassNameKey = "class vtkSynchronizeTimeFilter";
	}
}
