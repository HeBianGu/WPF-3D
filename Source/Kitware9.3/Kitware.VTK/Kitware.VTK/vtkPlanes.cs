using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlanes
	/// </summary>
	/// <remarks>
	///    implicit function for convex set of planes
	///
	/// vtkPlanes computes the implicit function and function gradient for a set
	/// of planes. The planes must define a convex space.
	///
	/// The function value is the intersection (i.e., maximum value) obtained by
	/// evaluating the each of the supplied planes. Hence the value is the maximum
	/// distance of a point to the convex region defined by the planes. The
	/// function gradient is the plane normal at the function value.  Note that
	/// the normals must point outside of the convex region. Thus, a negative
	/// function value means that a point is inside the convex region.
	///
	/// There are several methods to define the set of planes. The most general is
	/// to supply an instance of vtkPoints and an instance of vtkDataArray. (The
	/// points define a point on the plane, and the normals corresponding plane
	/// normals.) Two other specialized ways are to 1) supply six planes defining
	/// the view frustrum of a camera, and 2) provide a bounding box.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitBoolean vtkSpheres vtkFrustrumSource vtkCamera
	/// </seealso>
	// Token: 0x02000A99 RID: 2713
	public class vtkPlanes : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C763 RID: 116579 RVA: 0x0027F90F File Offset: 0x0027DB0F
		static vtkPlanes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlanes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlanes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C764 RID: 116580 RVA: 0x0027F937 File Offset: 0x0027DB37
		public vtkPlanes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C765 RID: 116581
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C766 RID: 116582 RVA: 0x0027F948 File Offset: 0x0027DB48
		public new static vtkPlanes New()
		{
			vtkPlanes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanes.vtkPlanes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C767 RID: 116583 RVA: 0x0027F99C File Offset: 0x0027DB9C
		public vtkPlanes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlanes.vtkPlanes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C768 RID: 116584 RVA: 0x0027F9E0 File Offset: 0x0027DBE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C769 RID: 116585
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPlanes_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate plane equations. Return largest value (i.e., an intersection
		/// operation between all planes).
		/// </summary>
		// Token: 0x0601C76A RID: 116586 RVA: 0x0027F9EC File Offset: 0x0027DBEC
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkPlanes.vtkPlanes_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601C76B RID: 116587
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanes_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate planes gradient.
		/// </summary>
		// Token: 0x0601C76C RID: 116588 RVA: 0x0027FA0C File Offset: 0x0027DC0C
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkPlanes.vtkPlanes_EvaluateGradient_02(base.GetCppThis(), x, n);
		}

		// Token: 0x0601C76D RID: 116589
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanes_GetNormals_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a list of normal vectors for the planes. There is a one-to-one
		/// correspondence between plane points and plane normals.
		/// </summary>
		// Token: 0x0601C76E RID: 116590 RVA: 0x0027FA20 File Offset: 0x0027DC20
		public virtual vtkDataArray GetNormals()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanes.vtkPlanes_GetNormals_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601C76F RID: 116591
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlanes_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C770 RID: 116592 RVA: 0x0027FA90 File Offset: 0x0027DC90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlanes.vtkPlanes_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C771 RID: 116593
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlanes_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C772 RID: 116594 RVA: 0x0027FAB0 File Offset: 0x0027DCB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlanes.vtkPlanes_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C773 RID: 116595
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanes_GetNumberOfPlanes_06(HandleRef pThis);

		/// <summary>
		/// Return the number of planes in the set of planes.
		/// </summary>
		// Token: 0x0601C774 RID: 116596 RVA: 0x0027FACC File Offset: 0x0027DCCC
		public int GetNumberOfPlanes()
		{
			return vtkPlanes.vtkPlanes_GetNumberOfPlanes_06(base.GetCppThis());
		}

		// Token: 0x0601C775 RID: 116597
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanes_GetPlane_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create and return a pointer to a vtkPlane object at the ith
		/// position. Asking for a plane outside the allowable range returns nullptr.
		/// This method always returns the same object.
		/// Use GetPlane(int i, vtkPlane *plane) instead.
		/// </summary>
		// Token: 0x0601C776 RID: 116598 RVA: 0x0027FAEC File Offset: 0x0027DCEC
		public vtkPlane GetPlane(int i)
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanes.vtkPlanes_GetPlane_07(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x0601C777 RID: 116599
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanes_GetPlane_08(HandleRef pThis, int i, HandleRef plane);

		/// <summary>
		/// If i is within the allowable range, mutates the given plane's
		/// Normal and Origin to match the vtkPlane object at the ith
		/// position. Does nothing if i is outside the allowable range.
		/// </summary>
		// Token: 0x0601C778 RID: 116600 RVA: 0x0027FB5C File Offset: 0x0027DD5C
		public void GetPlane(int i, vtkPlane plane)
		{
			vtkPlanes.vtkPlanes_GetPlane_08(base.GetCppThis(), i, (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x0601C779 RID: 116601
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanes_GetPoints_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a list of points defining points through which the planes pass.
		/// </summary>
		// Token: 0x0601C77A RID: 116602 RVA: 0x0027FB8C File Offset: 0x0027DD8C
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanes.vtkPlanes_GetPoints_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601C77B RID: 116603
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanes_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C77C RID: 116604 RVA: 0x0027FBFC File Offset: 0x0027DDFC
		public override int IsA(string type)
		{
			return vtkPlanes.vtkPlanes_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601C77D RID: 116605
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanes_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C77E RID: 116606 RVA: 0x0027FC1C File Offset: 0x0027DE1C
		public new static int IsTypeOf(string type)
		{
			return vtkPlanes.vtkPlanes_IsTypeOf_11(type);
		}

		// Token: 0x0601C77F RID: 116607
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanes_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C780 RID: 116608 RVA: 0x0027FC38 File Offset: 0x0027DE38
		public new vtkPlanes NewInstance()
		{
			vtkPlanes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanes.vtkPlanes_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C781 RID: 116609
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanes_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601C782 RID: 116610 RVA: 0x0027FC94 File Offset: 0x0027DE94
		public new static vtkPlanes SafeDownCast(vtkObjectBase o)
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanes.vtkPlanes_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanes = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanes.Register(null);
				}
			}
			return vtkPlanes;
		}

		// Token: 0x0601C783 RID: 116611
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanes_SetBounds_15(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// An alternative method to specify six planes defined by a bounding box.
		/// The bounding box is a six-vector defined as (xmin,xmax,ymin,ymax,zmin,zmax).
		/// It defines six planes orthogonal to the x-y-z coordinate axes.
		/// </summary>
		// Token: 0x0601C784 RID: 116612 RVA: 0x0027FD13 File Offset: 0x0027DF13
		public void SetBounds(IntPtr bounds)
		{
			vtkPlanes.vtkPlanes_SetBounds_15(base.GetCppThis(), bounds);
		}

		// Token: 0x0601C785 RID: 116613
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanes_SetBounds_16(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// An alternative method to specify six planes defined by a bounding box.
		/// The bounding box is a six-vector defined as (xmin,xmax,ymin,ymax,zmin,zmax).
		/// It defines six planes orthogonal to the x-y-z coordinate axes.
		/// </summary>
		// Token: 0x0601C786 RID: 116614 RVA: 0x0027FD23 File Offset: 0x0027DF23
		public void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPlanes.vtkPlanes_SetBounds_16(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0601C787 RID: 116615
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanes_SetFrustumPlanes_17(HandleRef pThis, IntPtr planes);

		/// <summary>
		/// An alternative method to specify six planes defined by the camera view
		/// frustrum. See vtkCamera::GetFrustumPlanes() documentation.
		/// </summary>
		// Token: 0x0601C788 RID: 116616 RVA: 0x0027FD3B File Offset: 0x0027DF3B
		public void SetFrustumPlanes(IntPtr planes)
		{
			vtkPlanes.vtkPlanes_SetFrustumPlanes_17(base.GetCppThis(), planes);
		}

		// Token: 0x0601C789 RID: 116617
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanes_SetNormals_18(HandleRef pThis, HandleRef normals);

		/// <summary>
		/// Specify a list of normal vectors for the planes. There is a one-to-one
		/// correspondence between plane points and plane normals.
		/// </summary>
		// Token: 0x0601C78A RID: 116618 RVA: 0x0027FD4C File Offset: 0x0027DF4C
		public void SetNormals(vtkDataArray normals)
		{
			vtkPlanes.vtkPlanes_SetNormals_18(base.GetCppThis(), (normals == null) ? default(HandleRef) : normals.GetCppThis());
		}

		// Token: 0x0601C78B RID: 116619
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanes_SetPoints_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a list of points defining points through which the planes pass.
		/// </summary>
		// Token: 0x0601C78C RID: 116620 RVA: 0x0027FD7C File Offset: 0x0027DF7C
		public virtual void SetPoints(vtkPoints arg0)
		{
			vtkPlanes.vtkPlanes_SetPoints_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E33 RID: 7731
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlanes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E34 RID: 7732
		public new static readonly string MRClassNameKey = "class vtkPlanes";
	}
}
