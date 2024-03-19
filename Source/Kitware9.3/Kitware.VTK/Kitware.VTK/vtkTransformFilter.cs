using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransformFilter
	/// </summary>
	/// <remarks>
	///    transform points and associated normals and vectors
	///
	/// vtkTransformFilter is a filter to transform point coordinates, and
	/// associated point normals and vectors, as well as cell normals and vectors.
	/// Transformed data array will be stored in a float array or a double array.
	/// Other point and cell data are passed through the filter, unless
	/// TransformAllInputVectors is set to true, in this case all other 3
	/// components arrays from point and cell data will be transformed as well.
	///
	/// An alternative method of transformation is to use vtkActor's methods
	/// to scale, rotate, and translate objects. The difference between the
	/// two methods is that vtkActor's transformation simply effects where
	/// objects are rendered (via the graphics pipeline), whereas
	/// vtkTransformFilter actually modifies point coordinates in the
	/// visualization pipeline. This is necessary for some objects
	/// (e.g., vtkProbeFilter) that require point coordinates as input.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractTransform vtkTransformPolyDataFilter vtkActor
	/// </seealso>
	// Token: 0x020008F3 RID: 2291
	public class vtkTransformFilter : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017AC9 RID: 96969 RVA: 0x002130BF File Offset: 0x002112BF
		static vtkTransformFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017ACA RID: 96970 RVA: 0x002130E7 File Offset: 0x002112E7
		public vtkTransformFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017ACB RID: 96971
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017ACC RID: 96972 RVA: 0x002130F8 File Offset: 0x002112F8
		public new static vtkTransformFilter New()
		{
			vtkTransformFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformFilter.vtkTransformFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017ACD RID: 96973 RVA: 0x0021314C File Offset: 0x0021134C
		public vtkTransformFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransformFilter.vtkTransformFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017ACE RID: 96974 RVA: 0x00213190 File Offset: 0x00211390
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017ACF RID: 96975
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTransformFilter_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the transform.
		/// </summary>
		// Token: 0x06017AD0 RID: 96976 RVA: 0x0021319C File Offset: 0x0021139C
		public override ulong GetMTime()
		{
			return vtkTransformFilter.vtkTransformFilter_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x06017AD1 RID: 96977
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AD2 RID: 96978 RVA: 0x002131BC File Offset: 0x002113BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransformFilter.vtkTransformFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06017AD3 RID: 96979
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AD4 RID: 96980 RVA: 0x002131DC File Offset: 0x002113DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransformFilter.vtkTransformFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06017AD5 RID: 96981
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformFilter_GetOutputPointsPrecision_04(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06017AD6 RID: 96982 RVA: 0x002131F8 File Offset: 0x002113F8
		public virtual int GetOutputPointsPrecision()
		{
			return vtkTransformFilter.vtkTransformFilter_GetOutputPointsPrecision_04(base.GetCppThis());
		}

		// Token: 0x06017AD7 RID: 96983
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformFilter_GetTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the transform object used to transform points.
		/// </summary>
		// Token: 0x06017AD8 RID: 96984 RVA: 0x00213218 File Offset: 0x00211418
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformFilter.vtkTransformFilter_GetTransform_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06017AD9 RID: 96985
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTransformFilter_GetTransformAllInputVectors_06(HandleRef pThis);

		/// <summary>
		/// If off (the default), only Vectors and Normals will be transformed.  If
		/// on, all 3-component data arrays (treated as 3D vectors) will be
		/// transformed, while other non-3-component data arrays will be passed
		/// through to the output unchanged.
		/// </summary>
		// Token: 0x06017ADA RID: 96986 RVA: 0x00213288 File Offset: 0x00211488
		public virtual bool GetTransformAllInputVectors()
		{
			return vtkTransformFilter.vtkTransformFilter_GetTransformAllInputVectors_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06017ADB RID: 96987
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017ADC RID: 96988 RVA: 0x002132B0 File Offset: 0x002114B0
		public override int IsA(string type)
		{
			return vtkTransformFilter.vtkTransformFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06017ADD RID: 96989
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017ADE RID: 96990 RVA: 0x002132D0 File Offset: 0x002114D0
		public new static int IsTypeOf(string type)
		{
			return vtkTransformFilter.vtkTransformFilter_IsTypeOf_08(type);
		}

		// Token: 0x06017ADF RID: 96991
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AE0 RID: 96992 RVA: 0x002132EC File Offset: 0x002114EC
		public new vtkTransformFilter NewInstance()
		{
			vtkTransformFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformFilter.vtkTransformFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017AE1 RID: 96993
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x06017AE2 RID: 96994 RVA: 0x00213348 File Offset: 0x00211548
		public new static vtkTransformFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTransformFilter vtkTransformFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformFilter.vtkTransformFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformFilter = (vtkTransformFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformFilter.Register(null);
				}
			}
			return vtkTransformFilter;
		}

		// Token: 0x06017AE3 RID: 96995
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformFilter_SetOutputPointsPrecision_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06017AE4 RID: 96996 RVA: 0x002133C7 File Offset: 0x002115C7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkTransformFilter.vtkTransformFilter_SetOutputPointsPrecision_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06017AE5 RID: 96997
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformFilter_SetTransform_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the transform object used to transform points.
		/// </summary>
		// Token: 0x06017AE6 RID: 96998 RVA: 0x002133D8 File Offset: 0x002115D8
		public virtual void SetTransform(vtkAbstractTransform arg0)
		{
			vtkTransformFilter.vtkTransformFilter_SetTransform_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06017AE7 RID: 96999
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformFilter_SetTransformAllInputVectors_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// If off (the default), only Vectors and Normals will be transformed.  If
		/// on, all 3-component data arrays (treated as 3D vectors) will be
		/// transformed, while other non-3-component data arrays will be passed
		/// through to the output unchanged.
		/// </summary>
		// Token: 0x06017AE8 RID: 97000 RVA: 0x00213407 File Offset: 0x00211607
		public virtual void SetTransformAllInputVectors(bool _arg)
		{
			vtkTransformFilter.vtkTransformFilter_SetTransformAllInputVectors_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017AE9 RID: 97001
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformFilter_TransformAllInputVectorsOff_15(HandleRef pThis);

		/// <summary>
		/// If off (the default), only Vectors and Normals will be transformed.  If
		/// on, all 3-component data arrays (treated as 3D vectors) will be
		/// transformed, while other non-3-component data arrays will be passed
		/// through to the output unchanged.
		/// </summary>
		// Token: 0x06017AEA RID: 97002 RVA: 0x0021341F File Offset: 0x0021161F
		public virtual void TransformAllInputVectorsOff()
		{
			vtkTransformFilter.vtkTransformFilter_TransformAllInputVectorsOff_15(base.GetCppThis());
		}

		// Token: 0x06017AEB RID: 97003
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformFilter_TransformAllInputVectorsOn_16(HandleRef pThis);

		/// <summary>
		/// If off (the default), only Vectors and Normals will be transformed.  If
		/// on, all 3-component data arrays (treated as 3D vectors) will be
		/// transformed, while other non-3-component data arrays will be passed
		/// through to the output unchanged.
		/// </summary>
		// Token: 0x06017AEC RID: 97004 RVA: 0x0021342E File Offset: 0x0021162E
		public virtual void TransformAllInputVectorsOn()
		{
			vtkTransformFilter.vtkTransformFilter_TransformAllInputVectorsOn_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A65 RID: 6757
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A66 RID: 6758
		public new static readonly string MRClassNameKey = "class vtkTransformFilter";
	}
}
