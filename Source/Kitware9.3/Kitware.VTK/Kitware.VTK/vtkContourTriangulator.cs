using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourTriangulator
	/// </summary>
	/// <remarks>
	///    Fill all 2D contours to create polygons
	///
	/// vtkContourTriangulator will generate triangles to fill all of the 2D
	/// contours in its input. The input to the filter is a set of lines (not
	/// polylines) which when joined form loops. The contours may be concave, and
	/// may even contain holes i.e. a contour may contain an internal contour that
	/// is wound in the opposite direction (as compared to the outer polygon
	/// normal) to indicate that it is a hole.
	///
	/// @warning
	/// The triangulation of is done in O(n) time for simple convex
	/// inputs, but for non-convex inputs the worst-case time is O(n^2*m^2)
	/// where n is the number of points and m is the number of holes.
	/// The best triangulation algorithms, in contrast, are O(n log n).
	/// The resulting triangles may be quite narrow, the algorithm does
	/// not attempt to produce high-quality triangles.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkClipClosedSurface vtkPolygon
	///
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </seealso>
	// Token: 0x02000886 RID: 2182
	public class vtkContourTriangulator : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016AA2 RID: 92834 RVA: 0x001FE0DA File Offset: 0x001FC2DA
		static vtkContourTriangulator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourTriangulator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourTriangulator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016AA3 RID: 92835 RVA: 0x001FE102 File Offset: 0x001FC302
		public vtkContourTriangulator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016AA4 RID: 92836
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourTriangulator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AA5 RID: 92837 RVA: 0x001FE110 File Offset: 0x001FC310
		public new static vtkContourTriangulator New()
		{
			vtkContourTriangulator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourTriangulator.vtkContourTriangulator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourTriangulator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AA6 RID: 92838 RVA: 0x001FE164 File Offset: 0x001FC364
		public vtkContourTriangulator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContourTriangulator.vtkContourTriangulator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016AA7 RID: 92839 RVA: 0x001FE1A8 File Offset: 0x001FC3A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016AA8 RID: 92840
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourTriangulator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AA9 RID: 92841 RVA: 0x001FE1B4 File Offset: 0x001FC3B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourTriangulator.vtkContourTriangulator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016AAA RID: 92842
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourTriangulator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AAB RID: 92843 RVA: 0x001FE1D4 File Offset: 0x001FC3D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourTriangulator.vtkContourTriangulator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016AAC RID: 92844
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourTriangulator_GetTriangulationError_03(HandleRef pThis);

		/// <summary>
		/// Check if there was a triangulation failure in the last update.
		/// </summary>
		// Token: 0x06016AAD RID: 92845 RVA: 0x001FE1F0 File Offset: 0x001FC3F0
		public virtual int GetTriangulationError()
		{
			return vtkContourTriangulator.vtkContourTriangulator_GetTriangulationError_03(base.GetCppThis());
		}

		// Token: 0x06016AAE RID: 92846
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourTriangulator_GetTriangulationErrorDisplay_04(HandleRef pThis);

		/// <summary>
		/// Generate errors when the triangulation fails.  Note that triangulation
		/// failures are often minor, because they involve tiny triangles that are
		/// too small to see.
		/// </summary>
		// Token: 0x06016AAF RID: 92847 RVA: 0x001FE210 File Offset: 0x001FC410
		public virtual int GetTriangulationErrorDisplay()
		{
			return vtkContourTriangulator.vtkContourTriangulator_GetTriangulationErrorDisplay_04(base.GetCppThis());
		}

		// Token: 0x06016AB0 RID: 92848
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourTriangulator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AB1 RID: 92849 RVA: 0x001FE230 File Offset: 0x001FC430
		public override int IsA(string type)
		{
			return vtkContourTriangulator.vtkContourTriangulator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06016AB2 RID: 92850
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourTriangulator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AB3 RID: 92851 RVA: 0x001FE250 File Offset: 0x001FC450
		public new static int IsTypeOf(string type)
		{
			return vtkContourTriangulator.vtkContourTriangulator_IsTypeOf_06(type);
		}

		// Token: 0x06016AB4 RID: 92852
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourTriangulator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AB5 RID: 92853 RVA: 0x001FE26C File Offset: 0x001FC46C
		public new vtkContourTriangulator NewInstance()
		{
			vtkContourTriangulator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourTriangulator.vtkContourTriangulator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourTriangulator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016AB6 RID: 92854
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourTriangulator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016AB7 RID: 92855 RVA: 0x001FE2C8 File Offset: 0x001FC4C8
		public new static vtkContourTriangulator SafeDownCast(vtkObjectBase o)
		{
			vtkContourTriangulator vtkContourTriangulator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourTriangulator.vtkContourTriangulator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourTriangulator = (vtkContourTriangulator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourTriangulator.Register(null);
				}
			}
			return vtkContourTriangulator;
		}

		// Token: 0x06016AB8 RID: 92856
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourTriangulator_SetTriangulationErrorDisplay_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Generate errors when the triangulation fails.  Note that triangulation
		/// failures are often minor, because they involve tiny triangles that are
		/// too small to see.
		/// </summary>
		// Token: 0x06016AB9 RID: 92857 RVA: 0x001FE347 File Offset: 0x001FC547
		public virtual void SetTriangulationErrorDisplay(int _arg)
		{
			vtkContourTriangulator.vtkContourTriangulator_SetTriangulationErrorDisplay_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06016ABA RID: 92858
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourTriangulator_TriangulateContours_11(HandleRef data, long firstLine, long numLines, HandleRef outputPolys, IntPtr normal, HandleRef self);

		/// <summary>
		/// Given some closed contour lines, create a triangle mesh that fills
		/// those lines.  The input lines do not have to be in tail-to-tip order.
		/// Only numLines starting from firstLine will be used.  Note that holes
		/// can be indicated by contour loops whose normals are in the opposite
		/// direction to the provided normal.
		/// </summary>
		// Token: 0x06016ABB RID: 92859 RVA: 0x001FE358 File Offset: 0x001FC558
		public static int TriangulateContours(vtkPolyData data, long firstLine, long numLines, vtkCellArray outputPolys, IntPtr normal, vtkPolyDataAlgorithm self)
		{
			return vtkContourTriangulator.vtkContourTriangulator_TriangulateContours_11((data == null) ? default(HandleRef) : data.GetCppThis(), firstLine, numLines, (outputPolys == null) ? default(HandleRef) : outputPolys.GetCppThis(), normal, (self == null) ? default(HandleRef) : self.GetCppThis());
		}

		// Token: 0x06016ABC RID: 92860
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourTriangulator_TriangulatePolygon_12(HandleRef polygon, HandleRef points, HandleRef triangles);

		/// <summary>
		/// A robust method for triangulating a polygon.  It cleans up the polygon
		/// and then applies the ear-cut triangulation.  A zero return value
		/// indicates that triangulation failed.
		/// </summary>
		// Token: 0x06016ABD RID: 92861 RVA: 0x001FE3B8 File Offset: 0x001FC5B8
		public static int TriangulatePolygon(vtkIdList polygon, vtkPoints points, vtkCellArray triangles)
		{
			return vtkContourTriangulator.vtkContourTriangulator_TriangulatePolygon_12((polygon == null) ? default(HandleRef) : polygon.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (triangles == null) ? default(HandleRef) : triangles.GetCppThis());
		}

		// Token: 0x06016ABE RID: 92862
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourTriangulator_TriangulationErrorDisplayOff_13(HandleRef pThis);

		/// <summary>
		/// Generate errors when the triangulation fails.  Note that triangulation
		/// failures are often minor, because they involve tiny triangles that are
		/// too small to see.
		/// </summary>
		// Token: 0x06016ABF RID: 92863 RVA: 0x001FE410 File Offset: 0x001FC610
		public virtual void TriangulationErrorDisplayOff()
		{
			vtkContourTriangulator.vtkContourTriangulator_TriangulationErrorDisplayOff_13(base.GetCppThis());
		}

		// Token: 0x06016AC0 RID: 92864
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourTriangulator_TriangulationErrorDisplayOn_14(HandleRef pThis);

		/// <summary>
		/// Generate errors when the triangulation fails.  Note that triangulation
		/// failures are often minor, because they involve tiny triangles that are
		/// too small to see.
		/// </summary>
		// Token: 0x06016AC1 RID: 92865 RVA: 0x001FE41F File Offset: 0x001FC61F
		public virtual void TriangulationErrorDisplayOn()
		{
			vtkContourTriangulator.vtkContourTriangulator_TriangulationErrorDisplayOn_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400196D RID: 6509
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourTriangulator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400196E RID: 6510
		public new static readonly string MRClassNameKey = "class vtkContourTriangulator";
	}
}
