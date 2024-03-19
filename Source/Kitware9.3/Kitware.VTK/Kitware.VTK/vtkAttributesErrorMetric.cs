using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAttributesErrorMetric
	/// </summary>
	/// <remarks>
	///     Objects that compute
	/// attribute-based error during cell tessellation.
	///
	///
	/// It is a concrete error metric, based on an attribute criterium:
	/// the variation of the active attribute/component value from a linear ramp
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
	/// </seealso>
	// Token: 0x020009FA RID: 2554
	public class vtkAttributesErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A7EA RID: 108522 RVA: 0x0024D087 File Offset: 0x0024B287
		static vtkAttributesErrorMetric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributesErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributesErrorMetric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A7EB RID: 108523 RVA: 0x0024D0AF File Offset: 0x0024B2AF
		public vtkAttributesErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A7EC RID: 108524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributesErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the error metric with a default relative attribute accuracy
		/// equal to 0.1.
		/// </summary>
		// Token: 0x0601A7ED RID: 108525 RVA: 0x0024D0C0 File Offset: 0x0024B2C0
		public new static vtkAttributesErrorMetric New()
		{
			vtkAttributesErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributesErrorMetric.vtkAttributesErrorMetric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the error metric with a default relative attribute accuracy
		/// equal to 0.1.
		/// </summary>
		// Token: 0x0601A7EE RID: 108526 RVA: 0x0024D114 File Offset: 0x0024B314
		public vtkAttributesErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAttributesErrorMetric.vtkAttributesErrorMetric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A7EF RID: 108527 RVA: 0x0024D158 File Offset: 0x0024B358
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A7F0 RID: 108528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributesErrorMetric_GetAbsoluteAttributeTolerance_01(HandleRef pThis);

		/// <summary>
		/// Absolute tolerance of the active scalar (attribute+component).
		/// Subdivision is required if the square distance between the real attribute
		/// at the mid point on the edge and the interpolated attribute is greater
		/// than AbsoluteAttributeTolerance.
		/// This is the attribute accuracy.
		/// 0.01 will give better result than 0.1.
		/// </summary>
		// Token: 0x0601A7F1 RID: 108529 RVA: 0x0024D164 File Offset: 0x0024B364
		public virtual double GetAbsoluteAttributeTolerance()
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetAbsoluteAttributeTolerance_01(base.GetCppThis());
		}

		// Token: 0x0601A7F2 RID: 108530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributesErrorMetric_GetAttributeTolerance_02(HandleRef pThis);

		/// <summary>
		/// Relative tolerance of the active scalar (attribute+component).
		/// Subdivision is required if the square distance between the real attribute
		/// at the mid point on the edge and the interpolated attribute is greater
		/// than AttributeTolerance.
		/// This is the attribute accuracy.
		/// 0.01 will give better result than 0.1.
		/// </summary>
		// Token: 0x0601A7F3 RID: 108531 RVA: 0x0024D184 File Offset: 0x0024B384
		public virtual double GetAttributeTolerance()
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetAttributeTolerance_02(base.GetCppThis());
		}

		// Token: 0x0601A7F4 RID: 108532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributesErrorMetric_GetError_03(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Return the error at the mid-point. The type of error depends on the state
		/// of the concrete error metric. For instance, it can return an absolute
		/// or relative error metric.
		/// See RequiresEdgeSubdivision() for a description of the arguments.
		/// \pre leftPoint_exists: leftPoint!=0
		/// \pre midPoint_exists: midPoint!=0
		/// \pre rightPoint_exists: rightPoint!=0
		/// \pre clamped_alpha: alpha&gt;0 &amp;&amp; alpha&lt;1
		/// \pre valid_size: sizeof(leftPoint)=sizeof(midPoint)=sizeof(rightPoint)
		/// =GetAttributeCollection()-&gt;GetNumberOfPointCenteredComponents()+6
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601A7F5 RID: 108533 RVA: 0x0024D1A4 File Offset: 0x0024B3A4
		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetError_03(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x0601A7F6 RID: 108534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributesErrorMetric_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601A7F7 RID: 108535 RVA: 0x0024D1C8 File Offset: 0x0024B3C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A7F8 RID: 108536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributesErrorMetric_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601A7F9 RID: 108537 RVA: 0x0024D1E8 File Offset: 0x0024B3E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601A7FA RID: 108538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributesErrorMetric_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601A7FB RID: 108539 RVA: 0x0024D204 File Offset: 0x0024B404
		public override int IsA(string type)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A7FC RID: 108540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributesErrorMetric_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601A7FD RID: 108541 RVA: 0x0024D224 File Offset: 0x0024B424
		public new static int IsTypeOf(string type)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_IsTypeOf_07(type);
		}

		// Token: 0x0601A7FE RID: 108542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributesErrorMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601A7FF RID: 108543 RVA: 0x0024D240 File Offset: 0x0024B440
		public new vtkAttributesErrorMetric NewInstance()
		{
			vtkAttributesErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributesErrorMetric.vtkAttributesErrorMetric_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A800 RID: 108544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributesErrorMetric_RequiresEdgeSubdivision_10(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Does the edge need to be subdivided according to the distance between
		/// the value of the active attribute/component at the midpoint and the mean
		/// value between the endpoints?
		/// The edge is defined by its `leftPoint' and its `rightPoint'.
		/// `leftPoint', `midPoint' and `rightPoint' have to be initialized before
		/// calling RequiresEdgeSubdivision().
		/// Their format is global coordinates, parametric coordinates and
		/// point centered attributes: xyx rst abc de...
		/// `alpha' is the normalized abscissa of the midpoint along the edge.
		/// (close to 0 means close to the left point, close to 1 means close to the
		/// right point)
		/// \pre leftPoint_exists: leftPoint!=0
		/// \pre midPoint_exists: midPoint!=0
		/// \pre rightPoint_exists: rightPoint!=0
		/// \pre clamped_alpha: alpha&gt;0 &amp;&amp; alpha&lt;1
		/// \pre valid_size: sizeof(leftPoint)=sizeof(midPoint)=sizeof(rightPoint)
		/// =GetAttributeCollection()-&gt;GetNumberOfPointCenteredComponents()+6
		/// </summary>
		// Token: 0x0601A801 RID: 108545 RVA: 0x0024D29C File Offset: 0x0024B49C
		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_RequiresEdgeSubdivision_10(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x0601A802 RID: 108546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributesErrorMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601A803 RID: 108547 RVA: 0x0024D2C0 File Offset: 0x0024B4C0
		public new static vtkAttributesErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkAttributesErrorMetric vtkAttributesErrorMetric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributesErrorMetric.vtkAttributesErrorMetric_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributesErrorMetric = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributesErrorMetric.Register(null);
				}
			}
			return vtkAttributesErrorMetric;
		}

		// Token: 0x0601A804 RID: 108548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributesErrorMetric_SetAbsoluteAttributeTolerance_12(HandleRef pThis, double value);

		/// <summary>
		/// Set the absolute attribute accuracy to `value'. See
		/// GetAbsoluteAttributeTolerance() for details.
		/// It is particularly useful when some concrete implementation of
		/// vtkGenericAttribute does not support GetRange() request, called
		/// internally in SetAttributeTolerance(). It may happen when the
		/// implementation support higher order attributes but
		/// cannot compute the range.
		/// \pre valid_range_value: value&gt;0
		/// </summary>
		// Token: 0x0601A805 RID: 108549 RVA: 0x0024D33F File Offset: 0x0024B53F
		public void SetAbsoluteAttributeTolerance(double value)
		{
			vtkAttributesErrorMetric.vtkAttributesErrorMetric_SetAbsoluteAttributeTolerance_12(base.GetCppThis(), value);
		}

		// Token: 0x0601A806 RID: 108550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributesErrorMetric_SetAttributeTolerance_13(HandleRef pThis, double value);

		/// <summary>
		/// Set the relative attribute accuracy to `value'. See
		/// GetAttributeTolerance() for details.
		/// \pre valid_range_value: value&gt;0 &amp;&amp; value&lt;1
		/// </summary>
		// Token: 0x0601A807 RID: 108551 RVA: 0x0024D34F File Offset: 0x0024B54F
		public void SetAttributeTolerance(double value)
		{
			vtkAttributesErrorMetric.vtkAttributesErrorMetric_SetAttributeTolerance_13(base.GetCppThis(), value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CCC RID: 7372
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributesErrorMetric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CCD RID: 7373
		public new static readonly string MRClassNameKey = "class vtkAttributesErrorMetric";
	}
}
