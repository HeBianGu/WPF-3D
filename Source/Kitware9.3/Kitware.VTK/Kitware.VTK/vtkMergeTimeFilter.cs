using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeTimeFilter
	/// </summary>
	/// <remarks>
	///    Create a multiblock containing one block per input, with unified timestep list.
	///
	/// vtkMergeTimeFilter takes multiple temporal datasets as input and synchronize them.
	///
	/// The output data is a multiblock dataset containing one block per input dataset.
	/// The output timesteps is the union (or the intersection) of each input timestep lists.
	/// Duplicates time values are removed, dependending on a tolerance, either absolute or relative.
	///
	/// When source time is exactly 0., absolute tolerance is used even in relative mode.
	///
	/// Note that the actual merge of timesteps is done during the RequestInformation pass.
	/// In the 'Relative' mode, inputs are processed in order and compararison is done with
	/// previously processed inputs.
	/// </remarks>
	// Token: 0x020008BB RID: 2235
	public class vtkMergeTimeFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060172A6 RID: 94886 RVA: 0x002083FF File Offset: 0x002065FF
		static vtkMergeTimeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeTimeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeTimeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060172A7 RID: 94887 RVA: 0x00208427 File Offset: 0x00206627
		public vtkMergeTimeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060172A8 RID: 94888
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTimeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172A9 RID: 94889 RVA: 0x00208438 File Offset: 0x00206638
		public new static vtkMergeTimeFilter New()
		{
			vtkMergeTimeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeTimeFilter.vtkMergeTimeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeTimeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172AA RID: 94890 RVA: 0x0020848C File Offset: 0x0020668C
		public vtkMergeTimeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeTimeFilter.vtkMergeTimeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060172AB RID: 94891 RVA: 0x002084D0 File Offset: 0x002066D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060172AC RID: 94892
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeTimeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172AD RID: 94893 RVA: 0x002084DC File Offset: 0x002066DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060172AE RID: 94894
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeTimeFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172AF RID: 94895 RVA: 0x002084FC File Offset: 0x002066FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060172B0 RID: 94896
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMergeTimeFilter_GetTolerance_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical. Default is 0.00001
		/// </summary>
		// Token: 0x060172B1 RID: 94897 RVA: 0x00208518 File Offset: 0x00206718
		public virtual double GetTolerance()
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_GetTolerance_03(base.GetCppThis());
		}

		// Token: 0x060172B2 RID: 94898
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMergeTimeFilter_GetToleranceMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical. Default is 0.00001
		/// </summary>
		// Token: 0x060172B3 RID: 94899 RVA: 0x00208538 File Offset: 0x00206738
		public virtual double GetToleranceMaxValue()
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_GetToleranceMaxValue_04(base.GetCppThis());
		}

		// Token: 0x060172B4 RID: 94900
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMergeTimeFilter_GetToleranceMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical. Default is 0.00001
		/// </summary>
		// Token: 0x060172B5 RID: 94901 RVA: 0x00208558 File Offset: 0x00206758
		public virtual double GetToleranceMinValue()
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_GetToleranceMinValue_05(base.GetCppThis());
		}

		// Token: 0x060172B6 RID: 94902
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMergeTimeFilter_GetUseIntersection_06(HandleRef pThis);

		/// <summary>
		/// Set/Get if the merge use intersection instead of union.
		/// Default is false (union is used).
		/// </summary>
		// Token: 0x060172B7 RID: 94903 RVA: 0x00208578 File Offset: 0x00206778
		public virtual bool GetUseIntersection()
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_GetUseIntersection_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060172B8 RID: 94904
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMergeTimeFilter_GetUseRelativeTolerance_07(HandleRef pThis);

		/// <summary>
		/// Set/Get if the tolerance is relative to previous input or absolute.
		///
		/// Default is false (absolute tolerance).
		/// </summary>
		// Token: 0x060172B9 RID: 94905 RVA: 0x002085A0 File Offset: 0x002067A0
		public virtual bool GetUseRelativeTolerance()
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_GetUseRelativeTolerance_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060172BA RID: 94906
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeTimeFilter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172BB RID: 94907 RVA: 0x002085C8 File Offset: 0x002067C8
		public override int IsA(string type)
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060172BC RID: 94908
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeTimeFilter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172BD RID: 94909 RVA: 0x002085E8 File Offset: 0x002067E8
		public new static int IsTypeOf(string type)
		{
			return vtkMergeTimeFilter.vtkMergeTimeFilter_IsTypeOf_09(type);
		}

		// Token: 0x060172BE RID: 94910
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTimeFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172BF RID: 94911 RVA: 0x00208604 File Offset: 0x00206804
		public new vtkMergeTimeFilter NewInstance()
		{
			vtkMergeTimeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeTimeFilter.vtkMergeTimeFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeTimeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060172C0 RID: 94912
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTimeFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172C1 RID: 94913 RVA: 0x00208660 File Offset: 0x00206860
		public new static vtkMergeTimeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMergeTimeFilter vtkMergeTimeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeTimeFilter.vtkMergeTimeFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeTimeFilter = (vtkMergeTimeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeTimeFilter.Register(null);
				}
			}
			return vtkMergeTimeFilter;
		}

		// Token: 0x060172C2 RID: 94914
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTimeFilter_SetTolerance_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the tolerance for comparing time step
		/// values to see if they are close enough to be considered
		/// identical. Default is 0.00001
		/// </summary>
		// Token: 0x060172C3 RID: 94915 RVA: 0x002086DF File Offset: 0x002068DF
		public virtual void SetTolerance(double _arg)
		{
			vtkMergeTimeFilter.vtkMergeTimeFilter_SetTolerance_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060172C4 RID: 94916
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTimeFilter_SetUseIntersection_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the merge use intersection instead of union.
		/// Default is false (union is used).
		/// </summary>
		// Token: 0x060172C5 RID: 94917 RVA: 0x002086EF File Offset: 0x002068EF
		public virtual void SetUseIntersection(bool _arg)
		{
			vtkMergeTimeFilter.vtkMergeTimeFilter_SetUseIntersection_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060172C6 RID: 94918
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTimeFilter_SetUseRelativeTolerance_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the tolerance is relative to previous input or absolute.
		///
		/// Default is false (absolute tolerance).
		/// </summary>
		// Token: 0x060172C7 RID: 94919 RVA: 0x00208707 File Offset: 0x00206907
		public virtual void SetUseRelativeTolerance(bool _arg)
		{
			vtkMergeTimeFilter.vtkMergeTimeFilter_SetUseRelativeTolerance_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060172C8 RID: 94920
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTimeFilter_UseIntersectionOff_16(HandleRef pThis);

		/// <summary>
		/// Set/Get if the merge use intersection instead of union.
		/// Default is false (union is used).
		/// </summary>
		// Token: 0x060172C9 RID: 94921 RVA: 0x0020871F File Offset: 0x0020691F
		public virtual void UseIntersectionOff()
		{
			vtkMergeTimeFilter.vtkMergeTimeFilter_UseIntersectionOff_16(base.GetCppThis());
		}

		// Token: 0x060172CA RID: 94922
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTimeFilter_UseIntersectionOn_17(HandleRef pThis);

		/// <summary>
		/// Set/Get if the merge use intersection instead of union.
		/// Default is false (union is used).
		/// </summary>
		// Token: 0x060172CB RID: 94923 RVA: 0x0020872E File Offset: 0x0020692E
		public virtual void UseIntersectionOn()
		{
			vtkMergeTimeFilter.vtkMergeTimeFilter_UseIntersectionOn_17(base.GetCppThis());
		}

		// Token: 0x060172CC RID: 94924
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTimeFilter_UseRelativeToleranceOff_18(HandleRef pThis);

		/// <summary>
		/// Set/Get if the tolerance is relative to previous input or absolute.
		///
		/// Default is false (absolute tolerance).
		/// </summary>
		// Token: 0x060172CD RID: 94925 RVA: 0x0020873D File Offset: 0x0020693D
		public virtual void UseRelativeToleranceOff()
		{
			vtkMergeTimeFilter.vtkMergeTimeFilter_UseRelativeToleranceOff_18(base.GetCppThis());
		}

		// Token: 0x060172CE RID: 94926
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTimeFilter_UseRelativeToleranceOn_19(HandleRef pThis);

		/// <summary>
		/// Set/Get if the tolerance is relative to previous input or absolute.
		///
		/// Default is false (absolute tolerance).
		/// </summary>
		// Token: 0x060172CF RID: 94927 RVA: 0x0020874C File Offset: 0x0020694C
		public virtual void UseRelativeToleranceOn()
		{
			vtkMergeTimeFilter.vtkMergeTimeFilter_UseRelativeToleranceOn_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E4 RID: 6628
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeTimeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E5 RID: 6629
		public new static readonly string MRClassNameKey = "class vtkMergeTimeFilter";
	}
}
