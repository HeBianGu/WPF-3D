using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointsProjectedHull
	/// </summary>
	/// <remarks>
	///    the convex hull of the orthogonal
	///    projection of the vtkPoints in the 3 coordinate directions
	///
	///    a subclass of vtkPoints, it maintains the counter clockwise
	///    convex hull of the points (projected orthogonally in the
	///    three coordinate directions) and has a method to
	///    test for intersection of that hull with an axis aligned
	///    rectangle.  This is used for intersection tests of 3D volumes.
	/// </remarks>
	// Token: 0x02000A9E RID: 2718
	public class vtkPointsProjectedHull : vtkPoints
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C841 RID: 116801 RVA: 0x00280E0A File Offset: 0x0027F00A
		static vtkPointsProjectedHull()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointsProjectedHull.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointsProjectedHull"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C842 RID: 116802 RVA: 0x00280E32 File Offset: 0x0027F032
		public vtkPointsProjectedHull(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C843 RID: 116803
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointsProjectedHull_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C844 RID: 116804 RVA: 0x00280E40 File Offset: 0x0027F040
		public new static vtkPointsProjectedHull New()
		{
			vtkPointsProjectedHull result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointsProjectedHull.vtkPointsProjectedHull_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C845 RID: 116805 RVA: 0x00280E94 File Offset: 0x0027F094
		public vtkPointsProjectedHull() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointsProjectedHull.vtkPointsProjectedHull_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C846 RID: 116806 RVA: 0x00280ED8 File Offset: 0x0027F0D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C847 RID: 116807
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_GetCCWHullX_01(HandleRef pThis, IntPtr pts, int len);

		/// <summary>
		/// Returns the coordinates (y,z) of the points in the convex hull
		/// of the projection of the points down the positive x-axis.  pts has
		/// storage for len*2 values.
		/// </summary>
		// Token: 0x0601C848 RID: 116808 RVA: 0x00280EE4 File Offset: 0x0027F0E4
		public int GetCCWHullX(IntPtr pts, int len)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetCCWHullX_01(base.GetCppThis(), pts, len);
		}

		// Token: 0x0601C849 RID: 116809
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_GetCCWHullY_02(HandleRef pThis, IntPtr pts, int len);

		/// <summary>
		/// Returns the coordinates (z, x) of the points in the convex hull
		/// of the projection of the points down the positive y-axis.  pts has
		/// storage for len*2 values.
		/// </summary>
		// Token: 0x0601C84A RID: 116810 RVA: 0x00280F08 File Offset: 0x0027F108
		public int GetCCWHullY(IntPtr pts, int len)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetCCWHullY_02(base.GetCppThis(), pts, len);
		}

		// Token: 0x0601C84B RID: 116811
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_GetCCWHullZ_03(HandleRef pThis, IntPtr pts, int len);

		/// <summary>
		/// Returns the coordinates (x, y) of the points in the convex hull
		/// of the projection of the points down the positive z-axis.  pts has
		/// storage for len*2 values.
		/// </summary>
		// Token: 0x0601C84C RID: 116812 RVA: 0x00280F2C File Offset: 0x0027F12C
		public int GetCCWHullZ(IntPtr pts, int len)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetCCWHullZ_03(base.GetCppThis(), pts, len);
		}

		// Token: 0x0601C84D RID: 116813
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointsProjectedHull_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C84E RID: 116814 RVA: 0x00280F50 File Offset: 0x0027F150
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C84F RID: 116815
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointsProjectedHull_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C850 RID: 116816 RVA: 0x00280F70 File Offset: 0x0027F170
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C851 RID: 116817
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_GetSizeCCWHullX_06(HandleRef pThis);

		/// <summary>
		/// Returns the number of points in the convex hull of the projection
		/// of the points down the positive x-axis
		/// </summary>
		// Token: 0x0601C852 RID: 116818 RVA: 0x00280F8C File Offset: 0x0027F18C
		public int GetSizeCCWHullX()
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetSizeCCWHullX_06(base.GetCppThis());
		}

		// Token: 0x0601C853 RID: 116819
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_GetSizeCCWHullY_07(HandleRef pThis);

		/// <summary>
		/// Returns the number of points in the convex hull of the projection
		/// of the points down the positive y-axis
		/// </summary>
		// Token: 0x0601C854 RID: 116820 RVA: 0x00280FAC File Offset: 0x0027F1AC
		public int GetSizeCCWHullY()
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetSizeCCWHullY_07(base.GetCppThis());
		}

		// Token: 0x0601C855 RID: 116821
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_GetSizeCCWHullZ_08(HandleRef pThis);

		/// <summary>
		/// Returns the number of points in the convex hull of the projection
		/// of the points down the positive z-axis
		/// </summary>
		// Token: 0x0601C856 RID: 116822 RVA: 0x00280FCC File Offset: 0x0027F1CC
		public int GetSizeCCWHullZ()
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetSizeCCWHullZ_08(base.GetCppThis());
		}

		// Token: 0x0601C857 RID: 116823
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointsProjectedHull_Initialize_09(HandleRef pThis);

		/// <summary>
		/// Returns the number of points in the convex hull of the projection
		/// of the points down the positive z-axis
		/// </summary>
		// Token: 0x0601C858 RID: 116824 RVA: 0x00280FEB File Offset: 0x0027F1EB
		public override void Initialize()
		{
			vtkPointsProjectedHull.vtkPointsProjectedHull_Initialize_09(base.GetCppThis());
		}

		// Token: 0x0601C859 RID: 116825
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C85A RID: 116826 RVA: 0x00280FFC File Offset: 0x0027F1FC
		public override int IsA(string type)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601C85B RID: 116827
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C85C RID: 116828 RVA: 0x0028101C File Offset: 0x0027F21C
		public new static int IsTypeOf(string type)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_IsTypeOf_11(type);
		}

		// Token: 0x0601C85D RID: 116829
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointsProjectedHull_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C85E RID: 116830 RVA: 0x00281038 File Offset: 0x0027F238
		public new vtkPointsProjectedHull NewInstance()
		{
			vtkPointsProjectedHull result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointsProjectedHull.vtkPointsProjectedHull_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C85F RID: 116831
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_14(HandleRef pThis, HandleRef R);

		/// <summary>
		/// determine whether the resulting rectangle intersects the
		/// convex hull of the projection of the points along that axis.
		/// </summary>
		// Token: 0x0601C860 RID: 116832 RVA: 0x00281094 File Offset: 0x0027F294
		public int RectangleIntersectionX(vtkPoints R)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionX_14(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		// Token: 0x0601C861 RID: 116833
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_15(HandleRef pThis, float ymin, float ymax, float zmin, float zmax);

		/// <summary>
		/// the convex hull of the projection of the points along the
		/// positive X-axis.
		/// </summary>
		// Token: 0x0601C862 RID: 116834 RVA: 0x002810C8 File Offset: 0x0027F2C8
		public int RectangleIntersectionX(float ymin, float ymax, float zmin, float zmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionX_15(base.GetCppThis(), ymin, ymax, zmin, zmax);
		}

		// Token: 0x0601C863 RID: 116835
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_16(HandleRef pThis, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// the convex hull of the projection of the points along the
		/// positive X-axis.
		/// </summary>
		// Token: 0x0601C864 RID: 116836 RVA: 0x002810EC File Offset: 0x0027F2EC
		public int RectangleIntersectionX(double ymin, double ymax, double zmin, double zmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionX_16(base.GetCppThis(), ymin, ymax, zmin, zmax);
		}

		// Token: 0x0601C865 RID: 116837
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_17(HandleRef pThis, HandleRef R);

		/// <summary>
		/// of the parallel projection along the Y axis of the points
		/// </summary>
		// Token: 0x0601C866 RID: 116838 RVA: 0x00281110 File Offset: 0x0027F310
		public int RectangleIntersectionY(vtkPoints R)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionY_17(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		// Token: 0x0601C867 RID: 116839
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_18(HandleRef pThis, float zmin, float zmax, float xmin, float xmax);

		/// <summary>
		/// the convex hull of the projection of the points along the
		/// positive Y-axis.
		/// </summary>
		// Token: 0x0601C868 RID: 116840 RVA: 0x00281144 File Offset: 0x0027F344
		public int RectangleIntersectionY(float zmin, float zmax, float xmin, float xmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionY_18(base.GetCppThis(), zmin, zmax, xmin, xmax);
		}

		// Token: 0x0601C869 RID: 116841
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_19(HandleRef pThis, double zmin, double zmax, double xmin, double xmax);

		/// <summary>
		/// the convex hull of the projection of the points along the
		/// positive Y-axis.
		/// </summary>
		// Token: 0x0601C86A RID: 116842 RVA: 0x00281168 File Offset: 0x0027F368
		public int RectangleIntersectionY(double zmin, double zmax, double xmin, double xmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionY_19(base.GetCppThis(), zmin, zmax, xmin, xmax);
		}

		// Token: 0x0601C86B RID: 116843
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_20(HandleRef pThis, HandleRef R);

		/// <summary>
		/// of the parallel projection along the Z axis of the points
		/// </summary>
		// Token: 0x0601C86C RID: 116844 RVA: 0x0028118C File Offset: 0x0027F38C
		public int RectangleIntersectionZ(vtkPoints R)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionZ_20(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		// Token: 0x0601C86D RID: 116845
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_21(HandleRef pThis, float xmin, float xmax, float ymin, float ymax);

		/// <summary>
		/// the convex hull of the projection of the points along the
		/// positive Z-axis.
		/// </summary>
		// Token: 0x0601C86E RID: 116846 RVA: 0x002811C0 File Offset: 0x0027F3C0
		public int RectangleIntersectionZ(float xmin, float xmax, float ymin, float ymax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionZ_21(base.GetCppThis(), xmin, xmax, ymin, ymax);
		}

		// Token: 0x0601C86F RID: 116847
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_22(HandleRef pThis, double xmin, double xmax, double ymin, double ymax);

		/// <summary>
		/// the convex hull of the projection of the points along the
		/// positive Z-axis.
		/// </summary>
		// Token: 0x0601C870 RID: 116848 RVA: 0x002811E4 File Offset: 0x0027F3E4
		public int RectangleIntersectionZ(double xmin, double xmax, double ymin, double ymax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionZ_22(base.GetCppThis(), xmin, xmax, ymin, ymax);
		}

		// Token: 0x0601C871 RID: 116849
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointsProjectedHull_Reset_23(HandleRef pThis);

		/// <summary>
		/// Returns the number of points in the convex hull of the projection
		/// of the points down the positive z-axis
		/// </summary>
		// Token: 0x0601C872 RID: 116850 RVA: 0x00281208 File Offset: 0x0027F408
		public override void Reset()
		{
			vtkPointsProjectedHull.vtkPointsProjectedHull_Reset_23(base.GetCppThis());
		}

		// Token: 0x0601C873 RID: 116851
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointsProjectedHull_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C874 RID: 116852 RVA: 0x00281218 File Offset: 0x0027F418
		public new static vtkPointsProjectedHull SafeDownCast(vtkObjectBase o)
		{
			vtkPointsProjectedHull vtkPointsProjectedHull = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointsProjectedHull.vtkPointsProjectedHull_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointsProjectedHull = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointsProjectedHull.Register(null);
				}
			}
			return vtkPointsProjectedHull;
		}

		// Token: 0x0601C875 RID: 116853
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointsProjectedHull_Update_25(HandleRef pThis);

		/// <summary>
		/// Forces recalculation of convex hulls, use this if
		/// you delete/add points
		/// </summary>
		// Token: 0x0601C876 RID: 116854 RVA: 0x00281297 File Offset: 0x0027F497
		public void Update()
		{
			vtkPointsProjectedHull.vtkPointsProjectedHull_Update_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E3D RID: 7741
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointsProjectedHull";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E3E RID: 7742
		public new static readonly string MRClassNameKey = "class vtkPointsProjectedHull";
	}
}
