using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransformPolyDataFilter
	/// </summary>
	/// <remarks>
	///    transform points and associated normals and vectors for polygonal dataset
	///
	/// vtkTransformPolyDataFilter is a filter to transform point
	/// coordinates and associated point and cell normals and
	/// vectors. Other point and cell data is passed through the filter
	/// unchanged. This filter is specialized for polygonal data. See
	/// vtkTransformFilter for more general data.
	///
	/// An alternative method of transformation is to use vtkActor's methods
	/// to scale, rotate, and translate objects. The difference between the
	/// two methods is that vtkActor's transformation simply effects where
	/// objects are rendered (via the graphics pipeline), whereas
	/// vtkTransformPolyDataFilter actually modifies point coordinates in the
	/// visualization pipeline. This is necessary for some objects
	/// (e.g., vtkProbeFilter) that require point coordinates as input.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTransform vtkTransformFilter vtkActor
	/// </seealso>
	// Token: 0x020008F4 RID: 2292
	public class vtkTransformPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017AED RID: 97005 RVA: 0x0021343D File Offset: 0x0021163D
		static vtkTransformPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017AEE RID: 97006 RVA: 0x00213465 File Offset: 0x00211665
		public vtkTransformPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017AEF RID: 97007
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AF0 RID: 97008 RVA: 0x00213474 File Offset: 0x00211674
		public new static vtkTransformPolyDataFilter New()
		{
			vtkTransformPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AF1 RID: 97009 RVA: 0x002134C8 File Offset: 0x002116C8
		public vtkTransformPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017AF2 RID: 97010 RVA: 0x0021350C File Offset: 0x0021170C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017AF3 RID: 97011
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTransformPolyDataFilter_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the transform.
		/// </summary>
		// Token: 0x06017AF4 RID: 97012 RVA: 0x00213518 File Offset: 0x00211718
		public override ulong GetMTime()
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x06017AF5 RID: 97013
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformPolyDataFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AF6 RID: 97014 RVA: 0x00213538 File Offset: 0x00211738
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06017AF7 RID: 97015
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformPolyDataFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AF8 RID: 97016 RVA: 0x00213558 File Offset: 0x00211758
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06017AF9 RID: 97017
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformPolyDataFilter_GetOutputPointsPrecision_04(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06017AFA RID: 97018 RVA: 0x00213574 File Offset: 0x00211774
		public virtual int GetOutputPointsPrecision()
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_GetOutputPointsPrecision_04(base.GetCppThis());
		}

		// Token: 0x06017AFB RID: 97019
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformPolyDataFilter_GetTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the transform object used to transform points.
		/// </summary>
		// Token: 0x06017AFC RID: 97020 RVA: 0x00213594 File Offset: 0x00211794
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_GetTransform_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06017AFD RID: 97021
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformPolyDataFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AFE RID: 97022 RVA: 0x00213604 File Offset: 0x00211804
		public override int IsA(string type)
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06017AFF RID: 97023
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformPolyDataFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017B00 RID: 97024 RVA: 0x00213624 File Offset: 0x00211824
		public new static int IsTypeOf(string type)
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_IsTypeOf_07(type);
		}

		// Token: 0x06017B01 RID: 97025
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformPolyDataFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017B02 RID: 97026 RVA: 0x00213640 File Offset: 0x00211840
		public new vtkTransformPolyDataFilter NewInstance()
		{
			vtkTransformPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017B03 RID: 97027
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformPolyDataFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017B04 RID: 97028 RVA: 0x0021369C File Offset: 0x0021189C
		public new static vtkTransformPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTransformPolyDataFilter vtkTransformPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformPolyDataFilter = (vtkTransformPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformPolyDataFilter.Register(null);
				}
			}
			return vtkTransformPolyDataFilter;
		}

		// Token: 0x06017B05 RID: 97029
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformPolyDataFilter_SetOutputPointsPrecision_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06017B06 RID: 97030 RVA: 0x0021371B File Offset: 0x0021191B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_SetOutputPointsPrecision_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06017B07 RID: 97031
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformPolyDataFilter_SetTransform_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the transform object used to transform points.
		/// </summary>
		// Token: 0x06017B08 RID: 97032 RVA: 0x0021372C File Offset: 0x0021192C
		public virtual void SetTransform(vtkAbstractTransform arg0)
		{
			vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_SetTransform_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A67 RID: 6759
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A68 RID: 6760
		public new static readonly string MRClassNameKey = "class vtkTransformPolyDataFilter";
	}
}
