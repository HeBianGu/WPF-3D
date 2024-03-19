using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInterpolateDataSetAttributes
	/// </summary>
	/// <remarks>
	///    interpolate scalars, vectors, etc. and other dataset attributes
	///
	/// vtkInterpolateDataSetAttributes is a filter that interpolates data set
	/// attribute values between input data sets. The input to the filter
	/// must be datasets of the same type, same number of cells, and same
	/// number of points. The output of the filter is a data set of the same
	/// type as the input dataset and whose attribute values have been
	/// interpolated at the parametric value specified.
	///
	/// The filter is used by specifying two or more input data sets (total of N),
	/// and a parametric value t (0 &lt;= t &lt;= N-1). The output will contain
	/// interpolated data set attributes common to all input data sets. (For
	/// example, if one input has scalars and vectors, and another has just
	/// scalars, then only scalars will be interpolated and output.)
	/// </remarks>
	// Token: 0x020008B0 RID: 2224
	public class vtkInterpolateDataSetAttributes : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017116 RID: 94486 RVA: 0x0020652C File Offset: 0x0020472C
		static vtkInterpolateDataSetAttributes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolateDataSetAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolateDataSetAttributes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017117 RID: 94487 RVA: 0x00206554 File Offset: 0x00204754
		public vtkInterpolateDataSetAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017118 RID: 94488
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017119 RID: 94489 RVA: 0x00206564 File Offset: 0x00204764
		public new static vtkInterpolateDataSetAttributes New()
		{
			vtkInterpolateDataSetAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601711A RID: 94490 RVA: 0x002065B8 File Offset: 0x002047B8
		public vtkInterpolateDataSetAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601711B RID: 94491 RVA: 0x002065FC File Offset: 0x002047FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601711C RID: 94492
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_GetInputList_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the list of inputs to this filter.
		/// </summary>
		// Token: 0x0601711D RID: 94493 RVA: 0x00206608 File Offset: 0x00204808
		public vtkDataSetCollection GetInputList()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetInputList_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		// Token: 0x0601711E RID: 94494
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601711F RID: 94495 RVA: 0x00206678 File Offset: 0x00204878
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06017120 RID: 94496
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017121 RID: 94497 RVA: 0x00206698 File Offset: 0x00204898
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06017122 RID: 94498
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInterpolateDataSetAttributes_GetT_04(HandleRef pThis);

		/// <summary>
		/// Specify interpolation parameter t.
		/// </summary>
		// Token: 0x06017123 RID: 94499 RVA: 0x002066B4 File Offset: 0x002048B4
		public virtual double GetT()
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetT_04(base.GetCppThis());
		}

		// Token: 0x06017124 RID: 94500
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInterpolateDataSetAttributes_GetTMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify interpolation parameter t.
		/// </summary>
		// Token: 0x06017125 RID: 94501 RVA: 0x002066D4 File Offset: 0x002048D4
		public virtual double GetTMaxValue()
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetTMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06017126 RID: 94502
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInterpolateDataSetAttributes_GetTMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify interpolation parameter t.
		/// </summary>
		// Token: 0x06017127 RID: 94503 RVA: 0x002066F4 File Offset: 0x002048F4
		public virtual double GetTMinValue()
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetTMinValue_06(base.GetCppThis());
		}

		// Token: 0x06017128 RID: 94504
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolateDataSetAttributes_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017129 RID: 94505 RVA: 0x00206714 File Offset: 0x00204914
		public override int IsA(string type)
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601712A RID: 94506
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolateDataSetAttributes_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601712B RID: 94507 RVA: 0x00206734 File Offset: 0x00204934
		public new static int IsTypeOf(string type)
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_IsTypeOf_08(type);
		}

		// Token: 0x0601712C RID: 94508
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601712D RID: 94509 RVA: 0x00206750 File Offset: 0x00204950
		public new vtkInterpolateDataSetAttributes NewInstance()
		{
			vtkInterpolateDataSetAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601712E RID: 94510
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601712F RID: 94511 RVA: 0x002067AC File Offset: 0x002049AC
		public new static vtkInterpolateDataSetAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolateDataSetAttributes vtkInterpolateDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolateDataSetAttributes = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolateDataSetAttributes.Register(null);
				}
			}
			return vtkInterpolateDataSetAttributes;
		}

		// Token: 0x06017130 RID: 94512
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInterpolateDataSetAttributes_SetT_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify interpolation parameter t.
		/// </summary>
		// Token: 0x06017131 RID: 94513 RVA: 0x0020682B File Offset: 0x00204A2B
		public virtual void SetT(double _arg)
		{
			vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_SetT_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C6 RID: 6598
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolateDataSetAttributes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C7 RID: 6599
		public new static readonly string MRClassNameKey = "class vtkInterpolateDataSetAttributes";
	}
}
