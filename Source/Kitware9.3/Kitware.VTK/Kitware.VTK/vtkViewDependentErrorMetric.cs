using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkViewDependentErrorMetric
	/// </summary>
	/// <remarks>
	///    Objects that compute a
	/// screen-based error during cell tessellation.
	///
	///
	/// It is a concrete error metric, based on a geometric criterium in
	/// the screen space: the variation of the projected edge from a projected
	/// straight line
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
	/// </seealso>
	// Token: 0x02000807 RID: 2055
	public class vtkViewDependentErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601518A RID: 86410 RVA: 0x001DDB63 File Offset: 0x001DBD63
		static vtkViewDependentErrorMetric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewDependentErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewDependentErrorMetric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601518B RID: 86411 RVA: 0x001DDB8B File Offset: 0x001DBD8B
		public vtkViewDependentErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601518C RID: 86412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewDependentErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the error metric with a default squared screen-based geometric
		/// accuracy measured in pixels equal to 0.25 (0.5^2).
		/// </summary>
		// Token: 0x0601518D RID: 86413 RVA: 0x001DDB9C File Offset: 0x001DBD9C
		public new static vtkViewDependentErrorMetric New()
		{
			vtkViewDependentErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the error metric with a default squared screen-based geometric
		/// accuracy measured in pixels equal to 0.25 (0.5^2).
		/// </summary>
		// Token: 0x0601518E RID: 86414 RVA: 0x001DDBF0 File Offset: 0x001DBDF0
		public vtkViewDependentErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601518F RID: 86415 RVA: 0x001DDC34 File Offset: 0x001DBE34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015190 RID: 86416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewDependentErrorMetric_GetError_01(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

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
		// Token: 0x06015191 RID: 86417 RVA: 0x001DDC40 File Offset: 0x001DBE40
		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetError_01(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x06015192 RID: 86418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x06015193 RID: 86419 RVA: 0x001DDC64 File Offset: 0x001DBE64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06015194 RID: 86420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x06015195 RID: 86421 RVA: 0x001DDC84 File Offset: 0x001DBE84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06015196 RID: 86422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewDependentErrorMetric_GetPixelTolerance_04(HandleRef pThis);

		/// <summary>
		/// Return the squared screen-based geometric accuracy measured in pixels.
		/// An accuracy less or equal to 0.25 (0.5^2) ensures that the screen-space
		/// interpolation of a mid-point matches exactly with the projection of the
		/// mid-point (a value less than 1 but greater than 0.25 is not enough,
		/// because of 8-neighbors). Maybe it is useful for lower accuracy in case of
		/// anti-aliasing?
		/// \post positive_result: result&gt;0
		/// </summary>
		// Token: 0x06015197 RID: 86423 RVA: 0x001DDCA0 File Offset: 0x001DBEA0
		public virtual double GetPixelTolerance()
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetPixelTolerance_04(base.GetCppThis());
		}

		// Token: 0x06015198 RID: 86424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewDependentErrorMetric_GetViewport_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the renderer with `renderer' on which the error metric
		/// is based. The error metric use the active camera of the renderer.
		/// </summary>
		// Token: 0x06015199 RID: 86425 RVA: 0x001DDCC0 File Offset: 0x001DBEC0
		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetViewport_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		// Token: 0x0601519A RID: 86426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewDependentErrorMetric_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601519B RID: 86427 RVA: 0x001DDD30 File Offset: 0x001DBF30
		public override int IsA(string type)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601519C RID: 86428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewDependentErrorMetric_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601519D RID: 86429 RVA: 0x001DDD50 File Offset: 0x001DBF50
		public new static int IsTypeOf(string type)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_IsTypeOf_07(type);
		}

		// Token: 0x0601519E RID: 86430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewDependentErrorMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601519F RID: 86431 RVA: 0x001DDD6C File Offset: 0x001DBF6C
		public new vtkViewDependentErrorMetric NewInstance()
		{
			vtkViewDependentErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060151A0 RID: 86432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewDependentErrorMetric_RequiresEdgeSubdivision_10(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Does the edge need to be subdivided according to the distance between
		/// the line passing through its endpoints in screen space and the projection
		/// of its mid point?
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
		// Token: 0x060151A1 RID: 86433 RVA: 0x001DDDC8 File Offset: 0x001DBFC8
		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_RequiresEdgeSubdivision_10(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x060151A2 RID: 86434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewDependentErrorMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x060151A3 RID: 86435 RVA: 0x001DDDEC File Offset: 0x001DBFEC
		public new static vtkViewDependentErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkViewDependentErrorMetric vtkViewDependentErrorMetric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewDependentErrorMetric = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewDependentErrorMetric.Register(null);
				}
			}
			return vtkViewDependentErrorMetric;
		}

		// Token: 0x060151A4 RID: 86436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewDependentErrorMetric_SetPixelTolerance_12(HandleRef pThis, double value);

		/// <summary>
		/// Set the squared screen-based geometric accuracy measured in pixels.
		/// Subdivision will be required if the square distance between the projection
		/// of the real point and the straight line passing through the projection
		/// of the vertices of the edge is greater than `value'.
		/// For instance, 0.25 will give better result than 1.
		/// \pre positive_value: value&gt;0
		/// </summary>
		// Token: 0x060151A5 RID: 86437 RVA: 0x001DDE6B File Offset: 0x001DC06B
		public void SetPixelTolerance(double value)
		{
			vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_SetPixelTolerance_12(base.GetCppThis(), value);
		}

		// Token: 0x060151A6 RID: 86438
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewDependentErrorMetric_SetViewport_13(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Set/Get the renderer with `renderer' on which the error metric
		/// is based. The error metric use the active camera of the renderer.
		/// </summary>
		// Token: 0x060151A7 RID: 86439 RVA: 0x001DDE7C File Offset: 0x001DC07C
		public void SetViewport(vtkViewport viewport)
		{
			vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_SetViewport_13(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001855 RID: 6229
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewDependentErrorMetric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001856 RID: 6230
		public new static readonly string MRClassNameKey = "class vtkViewDependentErrorMetric";
	}
}
