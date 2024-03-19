using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeometricErrorMetric
	/// </summary>
	/// <remarks>
	///    Objects that compute
	/// geometry-based error during cell tessellation.
	///
	///
	/// It is a concrete error metric, based on a geometric criterium:
	/// the variation of the edge from a straight line.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
	/// </seealso>
	// Token: 0x02000A53 RID: 2643
	public class vtkGeometricErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B9B0 RID: 113072 RVA: 0x0026A28B File Offset: 0x0026848B
		static vtkGeometricErrorMetric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeometricErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeometricErrorMetric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B9B1 RID: 113073 RVA: 0x0026A2B3 File Offset: 0x002684B3
		public vtkGeometricErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B9B2 RID: 113074
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometricErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the error metric with a default squared absolute geometric
		/// accuracy equal to 1.
		/// </summary>
		// Token: 0x0601B9B3 RID: 113075 RVA: 0x0026A2C4 File Offset: 0x002684C4
		public new static vtkGeometricErrorMetric New()
		{
			vtkGeometricErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeometricErrorMetric.vtkGeometricErrorMetric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the error metric with a default squared absolute geometric
		/// accuracy equal to 1.
		/// </summary>
		// Token: 0x0601B9B4 RID: 113076 RVA: 0x0026A318 File Offset: 0x00268518
		public vtkGeometricErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGeometricErrorMetric.vtkGeometricErrorMetric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B9B5 RID: 113077 RVA: 0x0026A35C File Offset: 0x0026855C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B9B6 RID: 113078
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeometricErrorMetric_GetAbsoluteGeometricTolerance_01(HandleRef pThis);

		/// <summary>
		/// Return the squared absolute geometric accuracy. See
		/// SetAbsoluteGeometricTolerance() for details.
		/// \post positive_result: result&gt;0
		/// </summary>
		// Token: 0x0601B9B7 RID: 113079 RVA: 0x0026A368 File Offset: 0x00268568
		public virtual double GetAbsoluteGeometricTolerance()
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetAbsoluteGeometricTolerance_01(base.GetCppThis());
		}

		// Token: 0x0601B9B8 RID: 113080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeometricErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Return the error at the mid-point. It will return an error relative to
		/// the bounding box size if GetRelative() is true, a square absolute error
		/// otherwise.
		/// See RequiresEdgeSubdivision() for a description of the arguments.
		/// \pre leftPoint_exists: leftPoint!=0
		/// \pre midPoint_exists: midPoint!=0
		/// \pre rightPoint_exists: rightPoint!=0
		/// \pre clamped_alpha: alpha&gt;0 &amp;&amp; alpha&lt;1
		/// \pre valid_size: sizeof(leftPoint)=sizeof(midPoint)=sizeof(rightPoint)
		/// =GetAttributeCollection()-&gt;GetNumberOfPointCenteredComponents()+6
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B9B9 RID: 113081 RVA: 0x0026A388 File Offset: 0x00268588
		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetError_02(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x0601B9BA RID: 113082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometricErrorMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601B9BB RID: 113083 RVA: 0x0026A3AC File Offset: 0x002685AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601B9BC RID: 113084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometricErrorMetric_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601B9BD RID: 113085 RVA: 0x0026A3CC File Offset: 0x002685CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601B9BE RID: 113086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometricErrorMetric_GetRelative_05(HandleRef pThis);

		/// <summary>
		/// Return the type of output of GetError()
		/// </summary>
		// Token: 0x0601B9BF RID: 113087 RVA: 0x0026A3E8 File Offset: 0x002685E8
		public int GetRelative()
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetRelative_05(base.GetCppThis());
		}

		// Token: 0x0601B9C0 RID: 113088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometricErrorMetric_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601B9C1 RID: 113089 RVA: 0x0026A408 File Offset: 0x00268608
		public override int IsA(string type)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B9C2 RID: 113090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometricErrorMetric_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601B9C3 RID: 113091 RVA: 0x0026A428 File Offset: 0x00268628
		public new static int IsTypeOf(string type)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_IsTypeOf_07(type);
		}

		// Token: 0x0601B9C4 RID: 113092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometricErrorMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601B9C5 RID: 113093 RVA: 0x0026A444 File Offset: 0x00268644
		public new vtkGeometricErrorMetric NewInstance()
		{
			vtkGeometricErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeometricErrorMetric.vtkGeometricErrorMetric_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B9C6 RID: 113094
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometricErrorMetric_RequiresEdgeSubdivision_10(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Does the edge need to be subdivided according to the distance between
		/// the line passing through its endpoints and the mid point?
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
		// Token: 0x0601B9C7 RID: 113095 RVA: 0x0026A4A0 File Offset: 0x002686A0
		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_RequiresEdgeSubdivision_10(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x0601B9C8 RID: 113096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometricErrorMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601B9C9 RID: 113097 RVA: 0x0026A4C4 File Offset: 0x002686C4
		public new static vtkGeometricErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkGeometricErrorMetric vtkGeometricErrorMetric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeometricErrorMetric.vtkGeometricErrorMetric_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeometricErrorMetric = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeometricErrorMetric.Register(null);
				}
			}
			return vtkGeometricErrorMetric;
		}

		// Token: 0x0601B9CA RID: 113098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometricErrorMetric_SetAbsoluteGeometricTolerance_12(HandleRef pThis, double value);

		/// <summary>
		/// Set the geometric accuracy with a squared absolute value.
		/// This is the geometric object-based accuracy.
		/// Subdivision will be required if the square distance between the real
		/// point and the straight line passing through the vertices of the edge is
		/// greater than `value'. For instance 0.01 will give better result than 0.1.
		/// \pre positive_value: value&gt;0
		/// </summary>
		// Token: 0x0601B9CB RID: 113099 RVA: 0x0026A543 File Offset: 0x00268743
		public void SetAbsoluteGeometricTolerance(double value)
		{
			vtkGeometricErrorMetric.vtkGeometricErrorMetric_SetAbsoluteGeometricTolerance_12(base.GetCppThis(), value);
		}

		// Token: 0x0601B9CC RID: 113100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometricErrorMetric_SetRelativeGeometricTolerance_13(HandleRef pThis, double value, HandleRef ds);

		/// <summary>
		/// Set the geometric accuracy with a value relative to the length of the
		/// bounding box of the dataset. Internally compute the absolute tolerance.
		/// For instance 0.01 will give better result than 0.1.
		/// \pre valid_range_value: value&gt;0 &amp;&amp; value&lt;1
		/// \pre ds_exists: ds!=0
		/// </summary>
		// Token: 0x0601B9CD RID: 113101 RVA: 0x0026A554 File Offset: 0x00268754
		public void SetRelativeGeometricTolerance(double value, vtkGenericDataSet ds)
		{
			vtkGeometricErrorMetric.vtkGeometricErrorMetric_SetRelativeGeometricTolerance_13(base.GetCppThis(), value, (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D9A RID: 7578
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeometricErrorMetric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D9B RID: 7579
		public new static readonly string MRClassNameKey = "class vtkGeometricErrorMetric";
	}
}
