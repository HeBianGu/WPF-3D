using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSmoothErrorMetric
	/// </summary>
	/// <remarks>
	///    Objects that compute
	/// geometry-based error during cell tessellation according to
	/// some max angle.
	///
	///
	/// It is a concrete error metric, based on a geometric criterium:
	/// a max angle between the chord passing through the midpoint and one of the
	/// endpoints and the other chord passing through the midpoint and the other
	/// endpoint of the edge. It is related to the flatness of an edge.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
	/// </seealso>
	// Token: 0x02000AC0 RID: 2752
	public class vtkSmoothErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CF82 RID: 118658 RVA: 0x0028D7FF File Offset: 0x0028B9FF
		static vtkSmoothErrorMetric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSmoothErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmoothErrorMetric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CF83 RID: 118659 RVA: 0x0028D827 File Offset: 0x0028BA27
		public vtkSmoothErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CF84 RID: 118660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmoothErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the error metric with a default flatness threshold of 90.1
		/// degrees.
		/// </summary>
		// Token: 0x0601CF85 RID: 118661 RVA: 0x0028D838 File Offset: 0x0028BA38
		public new static vtkSmoothErrorMetric New()
		{
			vtkSmoothErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmoothErrorMetric.vtkSmoothErrorMetric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the error metric with a default flatness threshold of 90.1
		/// degrees.
		/// </summary>
		// Token: 0x0601CF86 RID: 118662 RVA: 0x0028D88C File Offset: 0x0028BA8C
		public vtkSmoothErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSmoothErrorMetric.vtkSmoothErrorMetric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CF87 RID: 118663 RVA: 0x0028D8D0 File Offset: 0x0028BAD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CF88 RID: 118664
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothErrorMetric_GetAngleTolerance_01(HandleRef pThis);

		/// <summary>
		/// Return the flatness threshold.
		/// \post positive_result: result&gt;90 &amp;&amp; result&lt;180
		/// </summary>
		// Token: 0x0601CF89 RID: 118665 RVA: 0x0028D8DC File Offset: 0x0028BADC
		public double GetAngleTolerance()
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_GetAngleTolerance_01(base.GetCppThis());
		}

		// Token: 0x0601CF8A RID: 118666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

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
		// Token: 0x0601CF8B RID: 118667 RVA: 0x0028D8FC File Offset: 0x0028BAFC
		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_GetError_02(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x0601CF8C RID: 118668
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSmoothErrorMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601CF8D RID: 118669 RVA: 0x0028D920 File Offset: 0x0028BB20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601CF8E RID: 118670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSmoothErrorMetric_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601CF8F RID: 118671 RVA: 0x0028D940 File Offset: 0x0028BB40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601CF90 RID: 118672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothErrorMetric_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601CF91 RID: 118673 RVA: 0x0028D95C File Offset: 0x0028BB5C
		public override int IsA(string type)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601CF92 RID: 118674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothErrorMetric_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601CF93 RID: 118675 RVA: 0x0028D97C File Offset: 0x0028BB7C
		public new static int IsTypeOf(string type)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_IsTypeOf_06(type);
		}

		// Token: 0x0601CF94 RID: 118676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmoothErrorMetric_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601CF95 RID: 118677 RVA: 0x0028D998 File Offset: 0x0028BB98
		public new vtkSmoothErrorMetric NewInstance()
		{
			vtkSmoothErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmoothErrorMetric.vtkSmoothErrorMetric_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CF96 RID: 118678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothErrorMetric_RequiresEdgeSubdivision_09(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Does the edge need to be subdivided according to the cosine between
		/// the two chords passing through the mid-point and the endpoints?
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
		// Token: 0x0601CF97 RID: 118679 RVA: 0x0028D9F4 File Offset: 0x0028BBF4
		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_RequiresEdgeSubdivision_09(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x0601CF98 RID: 118680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmoothErrorMetric_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601CF99 RID: 118681 RVA: 0x0028DA18 File Offset: 0x0028BC18
		public new static vtkSmoothErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkSmoothErrorMetric vtkSmoothErrorMetric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmoothErrorMetric.vtkSmoothErrorMetric_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSmoothErrorMetric = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSmoothErrorMetric.Register(null);
				}
			}
			return vtkSmoothErrorMetric;
		}

		// Token: 0x0601CF9A RID: 118682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothErrorMetric_SetAngleTolerance_11(HandleRef pThis, double value);

		/// <summary>
		/// Set the flatness threshold with an angle in degrees. Internally
		/// compute the cosine. value is supposed to be in ]90,180[, if not
		/// it is clamped in [90.1,179.9].
		/// For instance 178 will give better result than 150.
		/// </summary>
		// Token: 0x0601CF9B RID: 118683 RVA: 0x0028DA97 File Offset: 0x0028BC97
		public void SetAngleTolerance(double value)
		{
			vtkSmoothErrorMetric.vtkSmoothErrorMetric_SetAngleTolerance_11(base.GetCppThis(), value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E9C RID: 7836
		public new const string MRFullTypeName = "Kitware.VTK.vtkSmoothErrorMetric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E9D RID: 7837
		public new static readonly string MRClassNameKey = "class vtkSmoothErrorMetric";
	}
}
