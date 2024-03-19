using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBox
	/// </summary>
	/// <remarks>
	///    implicit function for a bounding box
	///
	/// vtkBox computes the implicit function and/or gradient for a axis-aligned
	/// bounding box. (The superclasses transform can be used to modify this
	/// orientation.) Each side of the box is orthogonal to all other sides
	/// meeting along shared edges and all faces are orthogonal to the x-y-z
	/// coordinate axes.  (If you wish to orient this box differently, recall that
	/// the superclass vtkImplicitFunction supports a transformation matrix.)
	/// vtkBox is a concrete implementation of vtkImplicitFunction.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCubeSource vtkImplicitFunction vtkBoundingBox
	/// </seealso>
	// Token: 0x02000A11 RID: 2577
	public class vtkBox : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AD01 RID: 109825 RVA: 0x00255C71 File Offset: 0x00253E71
		static vtkBox()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBox.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBox"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AD02 RID: 109826 RVA: 0x00255C99 File Offset: 0x00253E99
		public vtkBox(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AD03 RID: 109827
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct box with center at (0,0,0) and each side of length 1.0.
		/// </summary>
		// Token: 0x0601AD04 RID: 109828 RVA: 0x00255CA8 File Offset: 0x00253EA8
		public new static vtkBox New()
		{
			vtkBox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBox.vtkBox_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct box with center at (0,0,0) and each side of length 1.0.
		/// </summary>
		// Token: 0x0601AD05 RID: 109829 RVA: 0x00255CFC File Offset: 0x00253EFC
		public vtkBox() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBox.vtkBox_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AD06 RID: 109830 RVA: 0x00255D40 File Offset: 0x00253F40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AD07 RID: 109831
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_AddBounds_01(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// A special method that allows union set operation on bounding boxes.
		/// Start with a SetBounds(). Subsequent AddBounds() methods are union set
		/// operations on the original bounds. Retrieve the final bounds with a
		/// GetBounds() method.
		/// </summary>
		// Token: 0x0601AD08 RID: 109832 RVA: 0x00255D4B File Offset: 0x00253F4B
		public void AddBounds(IntPtr bounds)
		{
			vtkBox.vtkBox_AddBounds_01(base.GetCppThis(), bounds);
		}

		// Token: 0x0601AD09 RID: 109833
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBox_EvaluateFunction_02(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate box defined by the two points (pMin,pMax).
		/// </summary>
		// Token: 0x0601AD0A RID: 109834 RVA: 0x00255D5C File Offset: 0x00253F5C
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkBox.vtkBox_EvaluateFunction_02(base.GetCppThis(), x);
		}

		// Token: 0x0601AD0B RID: 109835
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate the gradient of the box.
		/// </summary>
		// Token: 0x0601AD0C RID: 109836 RVA: 0x00255D7C File Offset: 0x00253F7C
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkBox.vtkBox_EvaluateGradient_03(base.GetCppThis(), x, n);
		}

		// Token: 0x0601AD0D RID: 109837
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_GetBounds_04(HandleRef pThis, ref double xMin, ref double xMax, ref double yMin, ref double yMax, ref double zMin, ref double zMax);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD0E RID: 109838 RVA: 0x00255D8D File Offset: 0x00253F8D
		public void GetBounds(ref double xMin, ref double xMax, ref double yMin, ref double yMax, ref double zMin, ref double zMax)
		{
			vtkBox.vtkBox_GetBounds_04(base.GetCppThis(), ref xMin, ref xMax, ref yMin, ref yMax, ref zMin, ref zMax);
		}

		// Token: 0x0601AD0F RID: 109839
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_GetBounds_05(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD10 RID: 109840 RVA: 0x00255DA5 File Offset: 0x00253FA5
		public void GetBounds(IntPtr bounds)
		{
			vtkBox.vtkBox_GetBounds_05(base.GetCppThis(), bounds);
		}

		// Token: 0x0601AD11 RID: 109841
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBox_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD12 RID: 109842 RVA: 0x00255DB8 File Offset: 0x00253FB8
		public double[] GetBounds()
		{
			IntPtr intPtr = vtkBox.vtkBox_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601AD13 RID: 109843
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBox_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD14 RID: 109844 RVA: 0x00255E00 File Offset: 0x00254000
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBox.vtkBox_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601AD15 RID: 109845
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBox_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD16 RID: 109846 RVA: 0x00255E20 File Offset: 0x00254020
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBox.vtkBox_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601AD17 RID: 109847
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_GetXMax_09(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD18 RID: 109848 RVA: 0x00255E3A File Offset: 0x0025403A
		public void GetXMax(IntPtr p)
		{
			vtkBox.vtkBox_GetXMax_09(base.GetCppThis(), p);
		}

		// Token: 0x0601AD19 RID: 109849
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_GetXMax_10(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD1A RID: 109850 RVA: 0x00255E4A File Offset: 0x0025404A
		public void GetXMax(ref double x, ref double y, ref double z)
		{
			vtkBox.vtkBox_GetXMax_10(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x0601AD1B RID: 109851
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_GetXMin_11(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD1C RID: 109852 RVA: 0x00255E5C File Offset: 0x0025405C
		public void GetXMin(IntPtr p)
		{
			vtkBox.vtkBox_GetXMin_11(base.GetCppThis(), p);
		}

		// Token: 0x0601AD1D RID: 109853
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_GetXMin_12(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD1E RID: 109854 RVA: 0x00255E6C File Offset: 0x0025406C
		public void GetXMin(ref double x, ref double y, ref double z)
		{
			vtkBox.vtkBox_GetXMin_12(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x0601AD1F RID: 109855
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkBox_IntersectBox_13(IntPtr bounds, IntPtr origin, IntPtr dir, IntPtr coord, ref double t, double tolerance);

		/// <summary>
		/// Bounding box intersection with line modified from Graphics Gems Vol
		/// I. The method returns a non-zero value if the bounding box is
		/// hit. Origin[3] starts the ray, dir[3] is the vector components of the
		/// ray in the x-y-z directions, coord[3] is the location of hit, and t is
		/// the parametric coordinate along line. (Notes: the intersection ray
		/// dir[3] is NOT normalized.  Valid intersections will only occur between
		/// 0&lt;=t&lt;=1.)
		/// </summary>
		// Token: 0x0601AD20 RID: 109856 RVA: 0x00255E80 File Offset: 0x00254080
		public static sbyte IntersectBox(IntPtr bounds, IntPtr origin, IntPtr dir, IntPtr coord, ref double t, double tolerance)
		{
			return vtkBox.vtkBox_IntersectBox_13(bounds, origin, dir, coord, ref t, tolerance);
		}

		// Token: 0x0601AD21 RID: 109857
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBox_IntersectWithInfiniteLine_14(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2);

		/// <summary>
		/// Same method as vtkBox::IntersectWithLine, except that t1 and t2 can be outside of [0,1].
		/// t1 is the distance of x1 to p1 in parametric coordinates, and t2 is the distance of x2 to p1
		/// in parametric coordinates as well.
		/// In vtkBox::IntersectWithInLine, it is assumed that [p1,p2] is a segment, here, it is
		/// assumed that it is a line with no ends.
		/// t1 &lt;= t2, which means that x1 is always "before" x2 on the line parameterized by [p1,p2].
		/// x1 and x2 can be set to nullptr without crash.
		/// </summary>
		// Token: 0x0601AD22 RID: 109858 RVA: 0x00255EA4 File Offset: 0x002540A4
		public static bool IntersectWithInfiniteLine(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2)
		{
			return vtkBox.vtkBox_IntersectWithInfiniteLine_14(bounds, p1, p2, ref t1, ref t2, x1, x2, ref plane1, ref plane2) != 0;
		}

		// Token: 0x0601AD23 RID: 109859
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBox_IntersectWithLine_15(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2);

		/// <summary>
		/// Intersect a line with the box.  Give the endpoints of the line in
		/// p1 and p2.  The parameteric distances from p1 to the entry and exit
		/// points are returned in t1 and t2, where t1 and t2 are clamped to the
		/// range [0,1].  The entry and exit planes are returned in plane1 and
		/// plane2 where integers (0, 1, 2, 3, 4, 5) stand for the
		/// (xmin, xmax, ymin, ymax, zmin, zmax) planes respectively, and a value
		/// of -1 means that no intersection occurred.  The actual intersection
		/// coordinates are stored in x1 and x2, which can be set to nullptr of you
		/// do not need them to be returned.  The function return value will be
		/// zero if the line is wholly outside of the box.
		/// </summary>
		// Token: 0x0601AD24 RID: 109860 RVA: 0x00255ED4 File Offset: 0x002540D4
		public static int IntersectWithLine(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2)
		{
			return vtkBox.vtkBox_IntersectWithLine_15(bounds, p1, p2, ref t1, ref t2, x1, x2, ref plane1, ref plane2);
		}

		// Token: 0x0601AD25 RID: 109861
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBox_IntersectWithPlane_16(IntPtr bounds, IntPtr origin, IntPtr normal);

		/// <summary>
		/// Plane intersection with the box. The plane is infinite in extent and
		/// defined by an origin and normal. The function indicates whether the
		/// plane intersects, not the particulars of intersection points and such.
		/// The function returns non-zero if the plane and box intersect; zero
		/// otherwise.
		/// </summary>
		// Token: 0x0601AD26 RID: 109862 RVA: 0x00255EFC File Offset: 0x002540FC
		public static int IntersectWithPlane(IntPtr bounds, IntPtr origin, IntPtr normal)
		{
			return vtkBox.vtkBox_IntersectWithPlane_16(bounds, origin, normal);
		}

		// Token: 0x0601AD27 RID: 109863
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBox_IntersectWithPlane_17(IntPtr bounds, IntPtr origin, IntPtr normal, IntPtr xout);

		/// <summary>
		/// Plane intersection with the box. The plane is infinite in extent and
		/// defined by an origin and normal. The function returns the number of
		/// intersection points, and if does, up to six ordered intersection points
		/// are provided (i.e., the points are ordered and form a valid polygon).
		/// Thus the function returns non-zero if the plane and box intersect; zero
		/// otherwise. Note that if there is an intersection, the number of
		/// intersections ranges from [3,6]. xout memory layout is consistent with
		/// vtkPoints array layout and is organized as (xyz, xyz, xyz, xyz, xyz,
		/// xyz).
		/// </summary>
		// Token: 0x0601AD28 RID: 109864 RVA: 0x00255F18 File Offset: 0x00254118
		public static int IntersectWithPlane(IntPtr bounds, IntPtr origin, IntPtr normal, IntPtr xout)
		{
			return vtkBox.vtkBox_IntersectWithPlane_17(bounds, origin, normal, xout);
		}

		// Token: 0x0601AD29 RID: 109865
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBox_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD2A RID: 109866 RVA: 0x00255F38 File Offset: 0x00254138
		public override int IsA(string type)
		{
			return vtkBox.vtkBox_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601AD2B RID: 109867
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBox_IsBoxInFrustum_19(IntPtr planes, IntPtr bounds);

		/// <summary>
		/// Is a box in a frustum. Returns true if the box is in the frustum
		/// even partially. The frustum is defined as 6 planes. This method
		/// is not exact may and return true for cases where there is no
		/// intersection. It should never return false when there is an
		/// intersection though.
		/// </summary>
		// Token: 0x0601AD2C RID: 109868 RVA: 0x00255F58 File Offset: 0x00254158
		public static int IsBoxInFrustum(IntPtr planes, IntPtr bounds)
		{
			return vtkBox.vtkBox_IsBoxInFrustum_19(planes, bounds);
		}

		// Token: 0x0601AD2D RID: 109869
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBox_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD2E RID: 109870 RVA: 0x00255F74 File Offset: 0x00254174
		public new static int IsTypeOf(string type)
		{
			return vtkBox.vtkBox_IsTypeOf_20(type);
		}

		// Token: 0x0601AD2F RID: 109871
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBox_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD30 RID: 109872 RVA: 0x00255F90 File Offset: 0x00254190
		public new vtkBox NewInstance()
		{
			vtkBox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBox.vtkBox_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AD31 RID: 109873
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBox_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AD32 RID: 109874 RVA: 0x00255FEC File Offset: 0x002541EC
		public new static vtkBox SafeDownCast(vtkObjectBase o)
		{
			vtkBox vtkBox = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBox.vtkBox_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBox = (vtkBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBox.Register(null);
				}
			}
			return vtkBox;
		}

		// Token: 0x0601AD33 RID: 109875
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_SetBounds_24(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD34 RID: 109876 RVA: 0x0025606B File Offset: 0x0025426B
		public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkBox.vtkBox_SetBounds_24(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0601AD35 RID: 109877
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_SetBounds_25(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD36 RID: 109878 RVA: 0x00256083 File Offset: 0x00254283
		public void SetBounds(IntPtr bounds)
		{
			vtkBox.vtkBox_SetBounds_25(base.GetCppThis(), bounds);
		}

		// Token: 0x0601AD37 RID: 109879
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_SetXMax_26(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD38 RID: 109880 RVA: 0x00256093 File Offset: 0x00254293
		public void SetXMax(IntPtr p)
		{
			vtkBox.vtkBox_SetXMax_26(base.GetCppThis(), p);
		}

		// Token: 0x0601AD39 RID: 109881
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_SetXMax_27(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD3A RID: 109882 RVA: 0x002560A3 File Offset: 0x002542A3
		public void SetXMax(double x, double y, double z)
		{
			vtkBox.vtkBox_SetXMax_27(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601AD3B RID: 109883
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_SetXMin_28(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD3C RID: 109884 RVA: 0x002560B5 File Offset: 0x002542B5
		public void SetXMin(IntPtr p)
		{
			vtkBox.vtkBox_SetXMin_28(base.GetCppThis(), p);
		}

		// Token: 0x0601AD3D RID: 109885
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBox_SetXMin_29(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set / get the bounding box using various methods.
		/// </summary>
		// Token: 0x0601AD3E RID: 109886 RVA: 0x002560C5 File Offset: 0x002542C5
		public void SetXMin(double x, double y, double z)
		{
			vtkBox.vtkBox_SetXMin_29(base.GetCppThis(), x, y, z);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CFA RID: 7418
		public new const string MRFullTypeName = "Kitware.VTK.vtkBox";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CFB RID: 7419
		public new static readonly string MRClassNameKey = "class vtkBox";
	}
}
