using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedThresholds
	/// </summary>
	/// <remarks>
	///    extract a cells or points from a
	/// dataset that have values within a set of thresholds.
	///
	///
	/// vtkExtractSelectedThresholds extracts all cells and points with attribute
	/// values that lie within a vtkSelection's THRESHOLD contents. The selecion
	/// can specify to threshold a particular array within either the point or cell
	/// attribute data of the input. This is similar to vtkThreshold
	/// but allows multiple thresholds ranges.
	/// This filter adds a scalar array called vtkOriginalCellIds that says what
	/// input cell produced each output cell. This is an example of a Pedigree ID
	/// which helps to trace back results.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelection vtkExtractSelection vtkThreshold
	///
	/// @deprecated vtkExtractSelectedThresholds is deprecated in VTK 9.2 and will be removed.
	/// Use `vtkExtractSelection` instead of `vtkExtractSelectedThresholds`.
	///
	/// Example using vtkExtractSelectedThresholds:
	///
	/// vtkNew&lt;vtkExtractSelectedThresholds&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	///
	/// Example using vtkExtractSelection:
	///
	/// vtkNew&lt;vtkExtractSelection&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	/// </seealso>
	// Token: 0x020006B7 RID: 1719
	public class vtkExtractSelectedThresholds : vtkExtractSelectionBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012561 RID: 75105 RVA: 0x0019B33F File Offset: 0x0019953F
		static vtkExtractSelectedThresholds()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedThresholds.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedThresholds"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012562 RID: 75106 RVA: 0x0019B367 File Offset: 0x00199567
		public vtkExtractSelectedThresholds(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012563 RID: 75107
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedThresholds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructor
		/// </summary>
		// Token: 0x06012564 RID: 75108 RVA: 0x0019B378 File Offset: 0x00199578
		public new static vtkExtractSelectedThresholds New()
		{
			vtkExtractSelectedThresholds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		// Token: 0x06012565 RID: 75109 RVA: 0x0019B3CC File Offset: 0x001995CC
		public vtkExtractSelectedThresholds() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012566 RID: 75110 RVA: 0x0019B410 File Offset: 0x00199610
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012567 RID: 75111
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_01(HandleRef scalars, long id, HandleRef lims);

		/// <summary>
		/// Function for determining whether a value in a data array passes
		/// the threshold test(s) provided in lims.  Returns 1 if the value
		/// passes at least one of the threshold tests.
		/// If \c scalars is nullptr, then the id itself is used as the scalar value.
		/// </summary>
		// Token: 0x06012568 RID: 75112 RVA: 0x0019B41C File Offset: 0x0019961C
		public static int EvaluateValue(vtkDataArray scalars, long id, vtkDataArray lims)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_01((scalars == null) ? default(HandleRef) : scalars.GetCppThis(), id, (lims == null) ? default(HandleRef) : lims.GetCppThis());
		}

		// Token: 0x06012569 RID: 75113
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_02(HandleRef array, int array_component_no, long id, HandleRef lims);

		/// <summary>
		/// Same as the other EvaluateValue except that the component to be compared
		/// can be picked using array_component_no (use -1 for magnitude).
		/// If \c scalars is nullptr, then the id itself is used as the scalar value.
		/// </summary>
		// Token: 0x0601256A RID: 75114 RVA: 0x0019B460 File Offset: 0x00199660
		public static int EvaluateValue(vtkDataArray array, int array_component_no, long id, vtkDataArray lims)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_02((array == null) ? default(HandleRef) : array.GetCppThis(), array_component_no, id, (lims == null) ? default(HandleRef) : lims.GetCppThis());
		}

		// Token: 0x0601256B RID: 75115
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_03(HandleRef scalars, long id, HandleRef lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount);

		/// <summary>
		/// Function for determining whether a value in a data array passes
		/// the threshold test(s) provided in lims.  Returns 1 if the value
		/// passes at least one of the threshold tests.  Also returns in
		/// AboveCount, BelowCount and InsideCount the number of tests where
		/// the value was above, below or inside the interval.
		/// If \c scalars is nullptr, then the id itself is used as the scalar value.
		/// </summary>
		// Token: 0x0601256C RID: 75116 RVA: 0x0019B4A8 File Offset: 0x001996A8
		public static int EvaluateValue(vtkDataArray scalars, long id, vtkDataArray lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_03((scalars == null) ? default(HandleRef) : scalars.GetCppThis(), id, (lims == null) ? default(HandleRef) : lims.GetCppThis(), AboveCount, BelowCount, InsideCount);
		}

		// Token: 0x0601256D RID: 75117
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedThresholds_EvaluateValue_04(HandleRef scalars, int array_component_no, long id, HandleRef lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount);

		/// <summary>
		/// Same as the other EvaluateValue except that the component to be compared
		/// can be picked using array_component_no (use -1 for magnitude).
		/// If \c scalars is nullptr, then the id itself is used as the scalar value.
		/// </summary>
		// Token: 0x0601256E RID: 75118 RVA: 0x0019B4F4 File Offset: 0x001996F4
		public static int EvaluateValue(vtkDataArray scalars, int array_component_no, long id, vtkDataArray lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_EvaluateValue_04((scalars == null) ? default(HandleRef) : scalars.GetCppThis(), array_component_no, id, (lims == null) ? default(HandleRef) : lims.GetCppThis(), AboveCount, BelowCount, InsideCount);
		}

		// Token: 0x0601256F RID: 75119
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012570 RID: 75120 RVA: 0x0019B540 File Offset: 0x00199740
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06012571 RID: 75121
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012572 RID: 75122 RVA: 0x0019B560 File Offset: 0x00199760
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06012573 RID: 75123
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedThresholds_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012574 RID: 75124 RVA: 0x0019B57C File Offset: 0x0019977C
		public override int IsA(string type)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06012575 RID: 75125
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedThresholds_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012576 RID: 75126 RVA: 0x0019B59C File Offset: 0x0019979C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_IsTypeOf_08(type);
		}

		// Token: 0x06012577 RID: 75127
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedThresholds_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012578 RID: 75128 RVA: 0x0019B5B8 File Offset: 0x001997B8
		public new vtkExtractSelectedThresholds NewInstance()
		{
			vtkExtractSelectedThresholds result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012579 RID: 75129
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedThresholds_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601257A RID: 75130 RVA: 0x0019B614 File Offset: 0x00199814
		public new static vtkExtractSelectedThresholds SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedThresholds vtkExtractSelectedThresholds = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedThresholds.vtkExtractSelectedThresholds_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedThresholds = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedThresholds.Register(null);
				}
			}
			return vtkExtractSelectedThresholds;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400151C RID: 5404
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedThresholds";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400151D RID: 5405
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedThresholds";
	}
}
