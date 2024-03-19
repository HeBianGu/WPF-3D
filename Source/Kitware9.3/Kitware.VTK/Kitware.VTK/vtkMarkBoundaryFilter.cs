using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMarkBoundaryFilter
	/// </summary>
	/// <remarks>
	///    mark points and cells that lie on the boundary of a dataset
	///
	/// vtkMarkBoundaryFilter is a general-purpose filter to mark those cells and
	/// points on the boundary of a dataset. The output of the filter is identical
	/// to the input, with the exception that two, new data arrays are added to
	/// the output that indicate which input points, and input cells, are on the
	/// boundary. (Cells and points on the boundary are indicated by a value ==1,
	/// otherwise ==0, and are accessed in the appropriate data array by cell id
	/// or point id. The output data arrays are of type vtkUnsignedChar.)
	///
	/// In general, n-dimensional faces are on the boundary of a (n+1)-dataset if
	/// used by a single (n+1)-dimensional cell. So for example the boundary cells
	/// of a volumetric dataset are those with quad faces used by only one
	/// voxel. Boundary points are those points used by the boundary faces. A cell
	/// may have multiple boundary faces.
	///
	/// An optional array can be produced that encodes the boundary faces of each
	/// cell. For each cell cellId that is on the boundary, the nth bit of the
	/// value of the faces tuple at location cellId is set.
	///
	/// @warning
	/// This filter is similar to vtkGeometryFilter in that it identifies boundary
	/// cells and points. However, vtkGeometryFilter produces output boundary faces
	/// and points as output. vtkMarkBoundaryFilter simply identifies which cells
	/// and points are on the boundary. (This filter is often used in parallel
	/// computing applications to help distribute data across multiple processes.)
	///
	/// @warning
	/// The points and cells boundary arrays are of type unsigned char.  The
	/// optional boundary faces array is of type of vtkIdType (either a 32-bit or
	/// 64-but integral value depending on compilation flags). Hence if the number
	/// of cell faces exceeds the number of bits in a face array value, then the
	/// faces array cannot properly encode the boundary faces for that cell. This
	/// may be a problem for cell types with an arbitrary number of faces such as
	/// vtkPolyhedron and vtkPolygon.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeometryFilter vtkDataSetSurfaceFilter
	/// </seealso>
	// Token: 0x0200090F RID: 2319
	public class vtkMarkBoundaryFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601809E RID: 98462 RVA: 0x0021A2FB File Offset: 0x002184FB
		static vtkMarkBoundaryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMarkBoundaryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarkBoundaryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601809F RID: 98463 RVA: 0x0021A323 File Offset: 0x00218523
		public vtkMarkBoundaryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060180A0 RID: 98464
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkBoundaryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180A1 RID: 98465 RVA: 0x0021A334 File Offset: 0x00218534
		public new static vtkMarkBoundaryFilter New()
		{
			vtkMarkBoundaryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarkBoundaryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180A2 RID: 98466 RVA: 0x0021A388 File Offset: 0x00218588
		public vtkMarkBoundaryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060180A3 RID: 98467 RVA: 0x0021A3CC File Offset: 0x002185CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060180A4 RID: 98468
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarkBoundaryFilter_GenerateBoundaryFacesOff_01(HandleRef pThis);

		/// <summary>
		/// Enable the creation of the boundary faces array. This array encodes
		/// which faces are on the boundary of the ith cell. By default, this array
		/// is not created. To use this array, bit masking is required to determine
		/// if the jth face is on the boundary.
		/// </summary>
		// Token: 0x060180A5 RID: 98469 RVA: 0x0021A3D7 File Offset: 0x002185D7
		public virtual void GenerateBoundaryFacesOff()
		{
			vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GenerateBoundaryFacesOff_01(base.GetCppThis());
		}

		// Token: 0x060180A6 RID: 98470
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarkBoundaryFilter_GenerateBoundaryFacesOn_02(HandleRef pThis);

		/// <summary>
		/// Enable the creation of the boundary faces array. This array encodes
		/// which faces are on the boundary of the ith cell. By default, this array
		/// is not created. To use this array, bit masking is required to determine
		/// if the jth face is on the boundary.
		/// </summary>
		// Token: 0x060180A7 RID: 98471 RVA: 0x0021A3E6 File Offset: 0x002185E6
		public virtual void GenerateBoundaryFacesOn()
		{
			vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GenerateBoundaryFacesOn_02(base.GetCppThis());
		}

		// Token: 0x060180A8 RID: 98472
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkBoundaryFilter_GetBoundaryCellsName_03(HandleRef pThis);

		/// <summary>
		/// Specify the names of the two data arrays which indicate which cells and points
		/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
		/// "BoundaryFaces" are used.
		/// </summary>
		// Token: 0x060180A9 RID: 98473 RVA: 0x0021A3F8 File Offset: 0x002185F8
		public virtual string GetBoundaryCellsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GetBoundaryCellsName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060180AA RID: 98474
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkBoundaryFilter_GetBoundaryFacesName_04(HandleRef pThis);

		/// <summary>
		/// Specify the names of the two data arrays which indicate which cells and points
		/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
		/// "BoundaryFaces" are used.
		/// </summary>
		// Token: 0x060180AB RID: 98475 RVA: 0x0021A434 File Offset: 0x00218634
		public virtual string GetBoundaryFacesName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GetBoundaryFacesName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060180AC RID: 98476
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkBoundaryFilter_GetBoundaryPointsName_05(HandleRef pThis);

		/// <summary>
		/// Specify the names of the two data arrays which indicate which cells and points
		/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
		/// "BoundaryFaces" are used.
		/// </summary>
		// Token: 0x060180AD RID: 98477 RVA: 0x0021A470 File Offset: 0x00218670
		public virtual string GetBoundaryPointsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GetBoundaryPointsName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060180AE RID: 98478
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMarkBoundaryFilter_GetGenerateBoundaryFaces_06(HandleRef pThis);

		/// <summary>
		/// Enable the creation of the boundary faces array. This array encodes
		/// which faces are on the boundary of the ith cell. By default, this array
		/// is not created. To use this array, bit masking is required to determine
		/// if the jth face is on the boundary.
		/// </summary>
		// Token: 0x060180AF RID: 98479 RVA: 0x0021A4AC File Offset: 0x002186AC
		public virtual bool GetGenerateBoundaryFaces()
		{
			return vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GetGenerateBoundaryFaces_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060180B0 RID: 98480
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180B1 RID: 98481 RVA: 0x0021A4D4 File Offset: 0x002186D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060180B2 RID: 98482
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180B3 RID: 98483 RVA: 0x0021A4F4 File Offset: 0x002186F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060180B4 RID: 98484
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarkBoundaryFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180B5 RID: 98485 RVA: 0x0021A510 File Offset: 0x00218710
		public override int IsA(string type)
		{
			return vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060180B6 RID: 98486
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarkBoundaryFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180B7 RID: 98487 RVA: 0x0021A530 File Offset: 0x00218730
		public new static int IsTypeOf(string type)
		{
			return vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_IsTypeOf_10(type);
		}

		// Token: 0x060180B8 RID: 98488
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkBoundaryFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180B9 RID: 98489 RVA: 0x0021A54C File Offset: 0x0021874C
		public new vtkMarkBoundaryFilter NewInstance()
		{
			vtkMarkBoundaryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarkBoundaryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060180BA RID: 98490
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkBoundaryFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x060180BB RID: 98491 RVA: 0x0021A5A8 File Offset: 0x002187A8
		public new static vtkMarkBoundaryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMarkBoundaryFilter vtkMarkBoundaryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMarkBoundaryFilter = (vtkMarkBoundaryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMarkBoundaryFilter.Register(null);
				}
			}
			return vtkMarkBoundaryFilter;
		}

		// Token: 0x060180BC RID: 98492
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarkBoundaryFilter_SetBoundaryCellsName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the names of the two data arrays which indicate which cells and points
		/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
		/// "BoundaryFaces" are used.
		/// </summary>
		// Token: 0x060180BD RID: 98493 RVA: 0x0021A627 File Offset: 0x00218827
		public virtual void SetBoundaryCellsName(string _arg)
		{
			vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_SetBoundaryCellsName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060180BE RID: 98494
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarkBoundaryFilter_SetBoundaryFacesName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the names of the two data arrays which indicate which cells and points
		/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
		/// "BoundaryFaces" are used.
		/// </summary>
		// Token: 0x060180BF RID: 98495 RVA: 0x0021A637 File Offset: 0x00218837
		public virtual void SetBoundaryFacesName(string _arg)
		{
			vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_SetBoundaryFacesName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060180C0 RID: 98496
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarkBoundaryFilter_SetBoundaryPointsName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the names of the two data arrays which indicate which cells and points
		/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
		/// "BoundaryFaces" are used.
		/// </summary>
		// Token: 0x060180C1 RID: 98497 RVA: 0x0021A647 File Offset: 0x00218847
		public virtual void SetBoundaryPointsName(string _arg)
		{
			vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_SetBoundaryPointsName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060180C2 RID: 98498
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarkBoundaryFilter_SetGenerateBoundaryFaces_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable the creation of the boundary faces array. This array encodes
		/// which faces are on the boundary of the ith cell. By default, this array
		/// is not created. To use this array, bit masking is required to determine
		/// if the jth face is on the boundary.
		/// </summary>
		// Token: 0x060180C3 RID: 98499 RVA: 0x0021A657 File Offset: 0x00218857
		public virtual void SetGenerateBoundaryFaces(bool _arg)
		{
			vtkMarkBoundaryFilter.vtkMarkBoundaryFilter_SetGenerateBoundaryFaces_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC8 RID: 6856
		public new const string MRFullTypeName = "Kitware.VTK.vtkMarkBoundaryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC9 RID: 6857
		public new static readonly string MRClassNameKey = "class vtkMarkBoundaryFilter";
	}
}
