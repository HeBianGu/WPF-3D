using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkToImplicitArrayFilter
	///
	/// A VTK filter for compressing explicit memory arrays into implicit arrays. The filter operates on
	/// arrays using strategies that inherit from `vtkToImplicitStrategy`. Arrays that are not compressed
	/// are shallow copied.
	///
	/// Here is a code snippet using the filter considering that there is a `previousFilter` with an
	/// output data set that has a data array called "Constant" defined on its points:
	/// ```
	/// vtkNew&lt;vtkToImplicitArrayFilter&gt; toImpArr;
	/// vtkNew&lt;vtkToConstantArrayStrategy&gt; strat;
	/// toImpArr-&gt;SetStrategy(strat);
	/// toImpArr-&gt;SetInputConnection(previousFilter-&gt;GetOutputPort());
	/// auto select = toImpArr-&gt;GetPointDataArraySelection();
	/// select-&gt;EnableArray("Constant");
	/// toImpArr-&gt;Update();
	/// ```
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkToImplicitStrategy, vtkImplicitArray
	/// </seealso>
	// Token: 0x02000429 RID: 1065
	public class vtkToImplicitArrayFilter : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C81D RID: 51229 RVA: 0x001166EB File Offset: 0x001148EB
		static vtkToImplicitArrayFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkToImplicitArrayFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkToImplicitArrayFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C81E RID: 51230 RVA: 0x00116713 File Offset: 0x00114913
		public vtkToImplicitArrayFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C81F RID: 51231
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C820 RID: 51232 RVA: 0x00116724 File Offset: 0x00114924
		public new static vtkToImplicitArrayFilter New()
		{
			vtkToImplicitArrayFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToImplicitArrayFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C821 RID: 51233 RVA: 0x00116778 File Offset: 0x00114978
		public vtkToImplicitArrayFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C822 RID: 51234 RVA: 0x001167BC File Offset: 0x001149BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C823 RID: 51235
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetArraySelection_01(HandleRef pThis, int association, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C824 RID: 51236 RVA: 0x001167C8 File Offset: 0x001149C8
		public vtkDataArraySelection GetArraySelection(int association)
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetArraySelection_01(base.GetCppThis(), association, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C825 RID: 51237
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetCellDataArraySelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C826 RID: 51238 RVA: 0x00116838 File Offset: 0x00114A38
		public vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetCellDataArraySelection_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C827 RID: 51239
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetEdgeDataArraySelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C828 RID: 51240 RVA: 0x001168A8 File Offset: 0x00114AA8
		public vtkDataArraySelection GetEdgeDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetEdgeDataArraySelection_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C829 RID: 51241
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetFieldDataArraySelection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C82A RID: 51242 RVA: 0x00116918 File Offset: 0x00114B18
		public vtkDataArraySelection GetFieldDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetFieldDataArraySelection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C82B RID: 51243
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkToImplicitArrayFilter_GetMaxNumberOfDegreesOfFreedom_05(HandleRef pThis);

		/// <summary>
		/// Setters/Getters for MaxNumberOfDegreesOfFreedom
		///
		/// The max number of degrees of freedom to accept in an implicit array for reduction (100 by
		/// default).
		///
		/// @see SetUseMaxNumberOfDegreesOfFreedom for use case
		/// </summary>
		// Token: 0x0600C82C RID: 51244 RVA: 0x00116988 File Offset: 0x00114B88
		public virtual ulong GetMaxNumberOfDegreesOfFreedom()
		{
			return vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetMaxNumberOfDegreesOfFreedom_05(base.GetCppThis());
		}

		// Token: 0x0600C82D RID: 51245
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitArrayFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C82E RID: 51246 RVA: 0x001169A8 File Offset: 0x00114BA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600C82F RID: 51247
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitArrayFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C830 RID: 51248 RVA: 0x001169C8 File Offset: 0x00114BC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600C831 RID: 51249
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetPointDataArraySelection_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C832 RID: 51250 RVA: 0x001169E4 File Offset: 0x00114BE4
		public vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetPointDataArraySelection_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C833 RID: 51251
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetPointsThenCellsDataArraySelection_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C834 RID: 51252 RVA: 0x00116A54 File Offset: 0x00114C54
		public vtkDataArraySelection GetPointsThenCellsDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetPointsThenCellsDataArraySelection_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C835 RID: 51253
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetRowDataArraySelection_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C836 RID: 51254 RVA: 0x00116AC4 File Offset: 0x00114CC4
		public vtkDataArraySelection GetRowDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetRowDataArraySelection_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C837 RID: 51255
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetStrategy_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Setter/Getter for strategy
		/// </summary>
		// Token: 0x0600C838 RID: 51256 RVA: 0x00116B34 File Offset: 0x00114D34
		public vtkToImplicitStrategy GetStrategy()
		{
			vtkToImplicitStrategy vtkToImplicitStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetStrategy_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToImplicitStrategy = (vtkToImplicitStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToImplicitStrategy.Register(null);
				}
			}
			return vtkToImplicitStrategy;
		}

		// Token: 0x0600C839 RID: 51257
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkToImplicitArrayFilter_GetTargetReduction_12(HandleRef pThis);

		/// <summary>
		/// Setter/Getter for target reduction
		/// Value usually in between 0 and 1 which sets the acceptable reduction in size of an array for
		/// passing it to its implicit form (0.1 by default).
		/// </summary>
		// Token: 0x0600C83A RID: 51258 RVA: 0x00116BA4 File Offset: 0x00114DA4
		public virtual double GetTargetReduction()
		{
			return vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetTargetReduction_12(base.GetCppThis());
		}

		// Token: 0x0600C83B RID: 51259
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkToImplicitArrayFilter_GetUseMaxNumberOfDegreesOfFreedom_13(HandleRef pThis);

		/// <summary>
		/// Setters/Getters for UseMaxNumberOfDegreesOfFreedom
		///
		/// Determines whether to use the MaxNumberOfDegreesOfFreedom (true) to accept a reduction or the
		/// TargetReduction (false) property (false by default).
		/// </summary>
		// Token: 0x0600C83C RID: 51260 RVA: 0x00116BC4 File Offset: 0x00114DC4
		public virtual bool GetUseMaxNumberOfDegreesOfFreedom()
		{
			return vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetUseMaxNumberOfDegreesOfFreedom_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C83D RID: 51261
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_GetVertexDataArraySelection_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for managing array selections
		/// </summary>
		// Token: 0x0600C83E RID: 51262 RVA: 0x00116BEC File Offset: 0x00114DEC
		public vtkDataArraySelection GetVertexDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_GetVertexDataArraySelection_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C83F RID: 51263
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitArrayFilter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C840 RID: 51264 RVA: 0x00116C5C File Offset: 0x00114E5C
		public override int IsA(string type)
		{
			return vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600C841 RID: 51265
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitArrayFilter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C842 RID: 51266 RVA: 0x00116C7C File Offset: 0x00114E7C
		public new static int IsTypeOf(string type)
		{
			return vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_IsTypeOf_16(type);
		}

		// Token: 0x0600C843 RID: 51267
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C844 RID: 51268 RVA: 0x00116C98 File Offset: 0x00114E98
		public new vtkToImplicitArrayFilter NewInstance()
		{
			vtkToImplicitArrayFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToImplicitArrayFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C845 RID: 51269
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitArrayFilter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C846 RID: 51270 RVA: 0x00116CF4 File Offset: 0x00114EF4
		public new static vtkToImplicitArrayFilter SafeDownCast(vtkObjectBase o)
		{
			vtkToImplicitArrayFilter vtkToImplicitArrayFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToImplicitArrayFilter = (vtkToImplicitArrayFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToImplicitArrayFilter.Register(null);
				}
			}
			return vtkToImplicitArrayFilter;
		}

		// Token: 0x0600C847 RID: 51271
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitArrayFilter_SetMaxNumberOfDegreesOfFreedom_20(HandleRef pThis, ulong _arg);

		/// <summary>
		/// Setters/Getters for MaxNumberOfDegreesOfFreedom
		///
		/// The max number of degrees of freedom to accept in an implicit array for reduction (100 by
		/// default).
		///
		/// @see SetUseMaxNumberOfDegreesOfFreedom for use case
		/// </summary>
		// Token: 0x0600C848 RID: 51272 RVA: 0x00116D73 File Offset: 0x00114F73
		public virtual void SetMaxNumberOfDegreesOfFreedom(ulong _arg)
		{
			vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_SetMaxNumberOfDegreesOfFreedom_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C849 RID: 51273
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitArrayFilter_SetStrategy_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Setter/Getter for strategy
		/// </summary>
		// Token: 0x0600C84A RID: 51274 RVA: 0x00116D84 File Offset: 0x00114F84
		public void SetStrategy(vtkToImplicitStrategy arg0)
		{
			vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_SetStrategy_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C84B RID: 51275
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitArrayFilter_SetTargetReduction_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Setter/Getter for target reduction
		/// Value usually in between 0 and 1 which sets the acceptable reduction in size of an array for
		/// passing it to its implicit form (0.1 by default).
		/// </summary>
		// Token: 0x0600C84C RID: 51276 RVA: 0x00116DB3 File Offset: 0x00114FB3
		public virtual void SetTargetReduction(double _arg)
		{
			vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_SetTargetReduction_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C84D RID: 51277
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitArrayFilter_SetUseMaxNumberOfDegreesOfFreedom_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Setters/Getters for UseMaxNumberOfDegreesOfFreedom
		///
		/// Determines whether to use the MaxNumberOfDegreesOfFreedom (true) to accept a reduction or the
		/// TargetReduction (false) property (false by default).
		/// </summary>
		// Token: 0x0600C84E RID: 51278 RVA: 0x00116DC3 File Offset: 0x00114FC3
		public virtual void SetUseMaxNumberOfDegreesOfFreedom(bool _arg)
		{
			vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_SetUseMaxNumberOfDegreesOfFreedom_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C84F RID: 51279
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitArrayFilter_UseMaxNumberOfDegreesOfFreedomOff_24(HandleRef pThis);

		/// <summary>
		/// Setters/Getters for UseMaxNumberOfDegreesOfFreedom
		///
		/// Determines whether to use the MaxNumberOfDegreesOfFreedom (true) to accept a reduction or the
		/// TargetReduction (false) property (false by default).
		/// </summary>
		// Token: 0x0600C850 RID: 51280 RVA: 0x00116DDB File Offset: 0x00114FDB
		public virtual void UseMaxNumberOfDegreesOfFreedomOff()
		{
			vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_UseMaxNumberOfDegreesOfFreedomOff_24(base.GetCppThis());
		}

		// Token: 0x0600C851 RID: 51281
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitArrayFilter_UseMaxNumberOfDegreesOfFreedomOn_25(HandleRef pThis);

		/// <summary>
		/// Setters/Getters for UseMaxNumberOfDegreesOfFreedom
		///
		/// Determines whether to use the MaxNumberOfDegreesOfFreedom (true) to accept a reduction or the
		/// TargetReduction (false) property (false by default).
		/// </summary>
		// Token: 0x0600C852 RID: 51282 RVA: 0x00116DEA File Offset: 0x00114FEA
		public virtual void UseMaxNumberOfDegreesOfFreedomOn()
		{
			vtkToImplicitArrayFilter.vtkToImplicitArrayFilter_UseMaxNumberOfDegreesOfFreedomOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE3 RID: 3811
		public new const string MRFullTypeName = "Kitware.VTK.vtkToImplicitArrayFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE4 RID: 3812
		public new static readonly string MRClassNameKey = "class vtkToImplicitArrayFilter";
	}
}
