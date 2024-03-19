using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAttributeDataToFieldDataFilter
	/// </summary>
	/// <remarks>
	///    map attribute data to field data
	///
	/// vtkAttributeDataToFieldDataFilter is a class that maps attribute data into
	/// field data. Since this filter is a subclass of vtkDataSetAlgorithm,
	/// the output dataset (whose structure is the same as the input dataset),
	/// will contain the field data that is generated. The filter will convert
	/// point and cell attribute data to field data and assign it as point and
	/// cell field data, replacing any point or field data that was there
	/// previously. By default, the original non-field point and cell attribute
	/// data will be passed to the output of the filter, although you can shut
	/// this behavior down.
	///
	/// @warning
	/// Reference counting the underlying data arrays is used to create the field
	/// data.  Therefore, no extra memory is utilized.
	///
	/// @warning
	/// The original field data (if any) associated with the point and cell
	/// attribute data is placed into the generated fields along with the scalars,
	/// vectors, etc.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataObject vtkDataSet vtkFieldDataToAttributeDataFilter
	/// </seealso>
	// Token: 0x02000941 RID: 2369
	public class vtkAttributeDataToFieldDataFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060188DA RID: 100570 RVA: 0x0022529B File Offset: 0x0022349B
		static vtkAttributeDataToFieldDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributeDataToFieldDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeDataToFieldDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060188DB RID: 100571 RVA: 0x002252C3 File Offset: 0x002234C3
		public vtkAttributeDataToFieldDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060188DC RID: 100572
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeDataToFieldDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct this object.
		/// </summary>
		// Token: 0x060188DD RID: 100573 RVA: 0x002252D4 File Offset: 0x002234D4
		public new static vtkAttributeDataToFieldDataFilter New()
		{
			vtkAttributeDataToFieldDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct this object.
		/// </summary>
		// Token: 0x060188DE RID: 100574 RVA: 0x00225328 File Offset: 0x00223528
		public vtkAttributeDataToFieldDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060188DF RID: 100575 RVA: 0x0022536C File Offset: 0x0022356C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060188E0 RID: 100576
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188E1 RID: 100577 RVA: 0x00225378 File Offset: 0x00223578
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060188E2 RID: 100578
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188E3 RID: 100579 RVA: 0x00225398 File Offset: 0x00223598
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060188E4 RID: 100580
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeDataToFieldDataFilter_GetPassAttributeData_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the passing of point and cell non-field attribute data to the
		/// output of the filter.
		/// </summary>
		// Token: 0x060188E5 RID: 100581 RVA: 0x002253B4 File Offset: 0x002235B4
		public virtual int GetPassAttributeData()
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_GetPassAttributeData_03(base.GetCppThis());
		}

		// Token: 0x060188E6 RID: 100582
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeDataToFieldDataFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188E7 RID: 100583 RVA: 0x002253D4 File Offset: 0x002235D4
		public override int IsA(string type)
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060188E8 RID: 100584
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeDataToFieldDataFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188E9 RID: 100585 RVA: 0x002253F4 File Offset: 0x002235F4
		public new static int IsTypeOf(string type)
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_IsTypeOf_05(type);
		}

		// Token: 0x060188EA RID: 100586
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeDataToFieldDataFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188EB RID: 100587 RVA: 0x00225410 File Offset: 0x00223610
		public new vtkAttributeDataToFieldDataFilter NewInstance()
		{
			vtkAttributeDataToFieldDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060188EC RID: 100588
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToFieldDataFilter_PassAttributeDataOff_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the passing of point and cell non-field attribute data to the
		/// output of the filter.
		/// </summary>
		// Token: 0x060188ED RID: 100589 RVA: 0x0022546A File Offset: 0x0022366A
		public virtual void PassAttributeDataOff()
		{
			vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_PassAttributeDataOff_08(base.GetCppThis());
		}

		// Token: 0x060188EE RID: 100590
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToFieldDataFilter_PassAttributeDataOn_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the passing of point and cell non-field attribute data to the
		/// output of the filter.
		/// </summary>
		// Token: 0x060188EF RID: 100591 RVA: 0x00225479 File Offset: 0x00223679
		public virtual void PassAttributeDataOn()
		{
			vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_PassAttributeDataOn_09(base.GetCppThis());
		}

		// Token: 0x060188F0 RID: 100592
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeDataToFieldDataFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188F1 RID: 100593 RVA: 0x00225488 File Offset: 0x00223688
		public new static vtkAttributeDataToFieldDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAttributeDataToFieldDataFilter vtkAttributeDataToFieldDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributeDataToFieldDataFilter = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributeDataToFieldDataFilter.Register(null);
				}
			}
			return vtkAttributeDataToFieldDataFilter;
		}

		// Token: 0x060188F2 RID: 100594
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeDataToFieldDataFilter_SetPassAttributeData_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the passing of point and cell non-field attribute data to the
		/// output of the filter.
		/// </summary>
		// Token: 0x060188F3 RID: 100595 RVA: 0x00225507 File Offset: 0x00223707
		public virtual void SetPassAttributeData(int _arg)
		{
			vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_SetPassAttributeData_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B32 RID: 6962
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeDataToFieldDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B33 RID: 6963
		public new static readonly string MRClassNameKey = "class vtkAttributeDataToFieldDataFilter";
	}
}
