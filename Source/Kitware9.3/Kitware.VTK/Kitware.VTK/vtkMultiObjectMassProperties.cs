using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiObjectMassProperties
	/// </summary>
	/// <remarks>
	///    compute volume and area of objects in a polygonal mesh
	///
	/// vtkMultiObjectMassProperties estimates the volume, the surface area, and
	/// the centroid of a polygonal mesh. Multiple, valid closed objects may be
	/// represented, and each object is assumed to be defined as a polyhedron
	/// defined by polygonal faces (i.e., the faces do not have to be triangles).
	/// The algorithm computes the total volume and area, as well as per object values
	/// which are placed in data arrays. Note that an object is valid only if it is
	/// manifold and closed (i.e., each edge is used exactly two times by two different
	/// polygons). Invalid objects are processed but may produce inaccurate
	/// results. Inconsistent polygon ordering is also allowed.
	///
	/// The algorithm is composed of two basic parts. First a connected traversal
	/// is performed to identify objects, detect whether the objects are valid,
	/// and ensure that the composing polygons are ordered consistently. Next, in
	/// threaded execution, a parallel process of computing areas, volumes  and
	/// centroids is performed. It is possible to skip the first part if the
	/// SkipValidityCheck is enabled, AND a vtkIdTypeArray data array named "ObjectIds"
	/// is associated with the polygon input (i.e., cell data) that enumerates which
	/// object every polygon belongs to (i.e., indicates that it is a boundary
	/// polygon of a specified object).
	///
	/// The algorithm implemented here is inspired by this paper:
	/// http://chenlab.ece.cornell.edu/Publication/Cha/icip01_Cha.pdf. Also see
	/// the stack-overflow entry: https://stackoverflow.com/questions/1406029/.
	/// The centroids are calculated as a weighted average of the centroids of the tetrahedrons
	/// which are used to compute the volume of the polygonal object, and the weight is the
	/// tetrahedron's volume contribution. If the polygonal object has 0 volume, then the resulted
	/// centroid will be (nan, nan, nan). The general assumption here is that the model
	/// is of closed surface.  Also, this approach requires triangulating the polygons so
	/// triangle meshes are processed much faster. Finally, the volume, area and centroid
	/// calculations are done in parallel (threaded) after a connectivity pass is made
	/// (used to identify objects and verify that they are manifold and closed).
	///
	/// The output contains seven additional data arrays. The arrays
	/// "ObjectValidity", "ObjectVolumes", "ObjectAreas" and "ObjectCentroids" are
	/// placed in the output field data.  These are arrays which indicate which objects are
	/// valid; the volume of each object; the surface area of each object; the centroid
	/// of each object. Three additional arrays are placed in the output cell data, and
	/// indicate, on a per polygons basis, which object the polygon bounds
	/// "ObjectIds"; the polygon area "Areas"; and the contribution of volume
	/// "Volumes".  Additionally, the TotalVolume and TotalArea is available after
	/// the filter executes (i.e., the sum of the ObjectVolumes and ObjectAreas
	/// arrays).
	///
	/// Per-object validity, as mentioned previously, is reported in the
	/// ObjectValidity array. However another variable, AllValid, is set after
	/// filter execution which indicates whether all objects are valid (!=0) or
	/// not. This information can be used as a shortcut in case you want to skip
	/// validity checking on an object-by-object basis.
	///
	/// @warning
	/// This filter operates on the polygonal data contained in the input
	/// vtkPolyData. Other types (vertices, lines, triangle strips) are ignored and
	/// not passed to the output. The input polys and points, as well as
	/// associated point and cell data, are passed through to the output.
	///
	/// @warning
	/// This filter is similar to vtkMassProperties. However vtkMassProperties
	/// operates on triangle meshes and assumes only a single, closed, properly
	/// oriented surface is represented. vtkMultiObjectMassProperties performs
	/// additional topological and connectivity operations to identify separate
	/// objects, and confirms that they are manifold. It also accommodates
	/// inconsistent ordering.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMassProperties
	/// </seealso>
	// Token: 0x02000982 RID: 2434
	public class vtkMultiObjectMassProperties : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019581 RID: 103809 RVA: 0x002351CF File Offset: 0x002333CF
		static vtkMultiObjectMassProperties()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiObjectMassProperties.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiObjectMassProperties"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019582 RID: 103810 RVA: 0x002351F7 File Offset: 0x002333F7
		public vtkMultiObjectMassProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019583 RID: 103811
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiObjectMassProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x06019584 RID: 103812 RVA: 0x00235208 File Offset: 0x00233408
		public new static vtkMultiObjectMassProperties New()
		{
			vtkMultiObjectMassProperties result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiObjectMassProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x06019585 RID: 103813 RVA: 0x0023525C File Offset: 0x0023345C
		public vtkMultiObjectMassProperties() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019586 RID: 103814 RVA: 0x002352A0 File Offset: 0x002334A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019587 RID: 103815
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiObjectMassProperties_GetAllValid_01(HandleRef pThis);

		/// <summary>
		/// Return whether all objects are valid or not. This is valid only after the
		/// filter executes.
		/// </summary>
		// Token: 0x06019588 RID: 103816 RVA: 0x002352AC File Offset: 0x002334AC
		public int GetAllValid()
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetAllValid_01(base.GetCppThis());
		}

		// Token: 0x06019589 RID: 103817
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0601958A RID: 103818 RVA: 0x002352CC File Offset: 0x002334CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601958B RID: 103819
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0601958C RID: 103820 RVA: 0x002352EC File Offset: 0x002334EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601958D RID: 103821
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiObjectMassProperties_GetNumberOfObjects_04(HandleRef pThis);

		/// <summary>
		/// Return the number of objects identified. This is valid only after the
		/// filter executes. Check the ObjectValidity array which indicates which of
		/// these identified objects are valid. Invalid objects may have incorrect
		/// volume and area values.
		/// </summary>
		// Token: 0x0601958E RID: 103822 RVA: 0x00235308 File Offset: 0x00233508
		public long GetNumberOfObjects()
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetNumberOfObjects_04(base.GetCppThis());
		}

		// Token: 0x0601958F RID: 103823
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiObjectMassProperties_GetObjectIdsArrayName_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the ObjectIds array. This array, which indicates in which object
		/// a polygon belongs to, can be either provided by the user or computed.
		/// The default name is "ObjectIds".
		/// </summary>
		// Token: 0x06019590 RID: 103824 RVA: 0x00235328 File Offset: 0x00233528
		public virtual string GetObjectIdsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetObjectIdsArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019591 RID: 103825
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiObjectMassProperties_GetSkipValidityCheck_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether to skip the validity check (the first part of the
		/// algorithm). By default this is off; however even if enabled validity
		/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
		/// provided on input to the filter.
		/// </summary>
		// Token: 0x06019592 RID: 103826 RVA: 0x00235364 File Offset: 0x00233564
		public virtual int GetSkipValidityCheck()
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetSkipValidityCheck_06(base.GetCppThis());
		}

		// Token: 0x06019593 RID: 103827
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMultiObjectMassProperties_GetTotalArea_07(HandleRef pThis);

		/// <summary>
		/// Return the summed area of all objects. This is valid only after the
		/// filter executes.
		/// </summary>
		// Token: 0x06019594 RID: 103828 RVA: 0x00235384 File Offset: 0x00233584
		public double GetTotalArea()
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetTotalArea_07(base.GetCppThis());
		}

		// Token: 0x06019595 RID: 103829
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMultiObjectMassProperties_GetTotalVolume_08(HandleRef pThis);

		/// <summary>
		/// Return the summed volume of all objects. This is valid only after the
		/// filter executes.
		/// </summary>
		// Token: 0x06019596 RID: 103830 RVA: 0x002353A4 File Offset: 0x002335A4
		public double GetTotalVolume()
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_GetTotalVolume_08(base.GetCppThis());
		}

		// Token: 0x06019597 RID: 103831
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiObjectMassProperties_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x06019598 RID: 103832 RVA: 0x002353C4 File Offset: 0x002335C4
		public override int IsA(string type)
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06019599 RID: 103833
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiObjectMassProperties_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0601959A RID: 103834 RVA: 0x002353E4 File Offset: 0x002335E4
		public new static int IsTypeOf(string type)
		{
			return vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_IsTypeOf_10(type);
		}

		// Token: 0x0601959B RID: 103835
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiObjectMassProperties_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0601959C RID: 103836 RVA: 0x00235400 File Offset: 0x00233600
		public new vtkMultiObjectMassProperties NewInstance()
		{
			vtkMultiObjectMassProperties result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiObjectMassProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601959D RID: 103837
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiObjectMassProperties_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0601959E RID: 103838 RVA: 0x0023545C File Offset: 0x0023365C
		public new static vtkMultiObjectMassProperties SafeDownCast(vtkObjectBase o)
		{
			vtkMultiObjectMassProperties vtkMultiObjectMassProperties = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiObjectMassProperties = (vtkMultiObjectMassProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiObjectMassProperties.Register(null);
				}
			}
			return vtkMultiObjectMassProperties;
		}

		// Token: 0x0601959F RID: 103839
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiObjectMassProperties_SetObjectIdsArrayName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get the name of the ObjectIds array. This array, which indicates in which object
		/// a polygon belongs to, can be either provided by the user or computed.
		/// The default name is "ObjectIds".
		/// </summary>
		// Token: 0x060195A0 RID: 103840 RVA: 0x002354DB File Offset: 0x002336DB
		public virtual void SetObjectIdsArrayName(string arg)
		{
			vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_SetObjectIdsArrayName_14(base.GetCppThis(), arg);
		}

		// Token: 0x060195A1 RID: 103841
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiObjectMassProperties_SetSkipValidityCheck_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to skip the validity check (the first part of the
		/// algorithm). By default this is off; however even if enabled validity
		/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
		/// provided on input to the filter.
		/// </summary>
		// Token: 0x060195A2 RID: 103842 RVA: 0x002354EB File Offset: 0x002336EB
		public virtual void SetSkipValidityCheck(int _arg)
		{
			vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_SetSkipValidityCheck_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060195A3 RID: 103843
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiObjectMassProperties_SkipValidityCheckOff_16(HandleRef pThis);

		/// <summary>
		/// Indicate whether to skip the validity check (the first part of the
		/// algorithm). By default this is off; however even if enabled validity
		/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
		/// provided on input to the filter.
		/// </summary>
		// Token: 0x060195A4 RID: 103844 RVA: 0x002354FB File Offset: 0x002336FB
		public virtual void SkipValidityCheckOff()
		{
			vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_SkipValidityCheckOff_16(base.GetCppThis());
		}

		// Token: 0x060195A5 RID: 103845
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiObjectMassProperties_SkipValidityCheckOn_17(HandleRef pThis);

		/// <summary>
		/// Indicate whether to skip the validity check (the first part of the
		/// algorithm). By default this is off; however even if enabled validity
		/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
		/// provided on input to the filter.
		/// </summary>
		// Token: 0x060195A6 RID: 103846 RVA: 0x0023550A File Offset: 0x0023370A
		public virtual void SkipValidityCheckOn()
		{
			vtkMultiObjectMassProperties.vtkMultiObjectMassProperties_SkipValidityCheckOn_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BC2 RID: 7106
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiObjectMassProperties";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BC3 RID: 7107
		public new static readonly string MRClassNameKey = "class vtkMultiObjectMassProperties";
	}
}
