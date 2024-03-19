using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataSilhouette
	/// </summary>
	/// <remarks>
	///    sort polydata along camera view direction
	///
	///
	/// vtkPolyDataSilhouette extracts a subset of a polygonal mesh edges to
	/// generate an outline (silhouette) of the corresponding 3D object. In
	/// addition, this filter can also extracts sharp edges (aka feature angles).
	/// In order to use this filter you must specify the a point of view (origin) or
	/// a direction (vector).  given this direction or origin, a silhouette is
	/// generated wherever the surface's normal is orthogonal to the view direction.
	///
	/// @warning
	/// when the active camera is used, almost everything is recomputed for each
	/// frame, keep this in mind when dealing with extremely large surface data
	/// sets.
	///
	/// @par Thanks:
	/// Contribution by Thierry Carrard &lt;br&gt;
	/// CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt;
	/// BP12, F-91297 Arpajon, France. &lt;br&gt;
	/// </remarks>
	// Token: 0x02000611 RID: 1553
	public class vtkPolyDataSilhouette : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010E2C RID: 69164 RVA: 0x001787A3 File Offset: 0x001769A3
		static vtkPolyDataSilhouette()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataSilhouette.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataSilhouette"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010E2D RID: 69165 RVA: 0x001787CB File Offset: 0x001769CB
		public vtkPolyDataSilhouette(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010E2E RID: 69166
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSilhouette_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E2F RID: 69167 RVA: 0x001787DC File Offset: 0x001769DC
		public new static vtkPolyDataSilhouette New()
		{
			vtkPolyDataSilhouette result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E30 RID: 69168 RVA: 0x00178830 File Offset: 0x00176A30
		public vtkPolyDataSilhouette() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataSilhouette.vtkPolyDataSilhouette_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010E31 RID: 69169 RVA: 0x00178874 File Offset: 0x00176A74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010E32 RID: 69170
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_BorderEdgesOff_01(HandleRef pThis);

		/// <summary>
		/// Enables or Disables generation of border edges. Note: borders exist only
		/// in case of non closed surface
		/// </summary>
		// Token: 0x06010E33 RID: 69171 RVA: 0x0017887F File Offset: 0x00176A7F
		public virtual void BorderEdgesOff()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_BorderEdgesOff_01(base.GetCppThis());
		}

		// Token: 0x06010E34 RID: 69172
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_BorderEdgesOn_02(HandleRef pThis);

		/// <summary>
		/// Enables or Disables generation of border edges. Note: borders exist only
		/// in case of non closed surface
		/// </summary>
		// Token: 0x06010E35 RID: 69173 RVA: 0x0017888E File Offset: 0x00176A8E
		public virtual void BorderEdgesOn()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_BorderEdgesOn_02(base.GetCppThis());
		}

		// Token: 0x06010E36 RID: 69174
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSilhouette_GetBorderEdges_03(HandleRef pThis);

		/// <summary>
		/// Enables or Disables generation of border edges. Note: borders exist only
		/// in case of non closed surface
		/// </summary>
		// Token: 0x06010E37 RID: 69175 RVA: 0x001788A0 File Offset: 0x00176AA0
		public virtual int GetBorderEdges()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetBorderEdges_03(base.GetCppThis());
		}

		// Token: 0x06010E38 RID: 69176
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSilhouette_GetCamera_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a camera that is used to define the view direction.  This ivar
		/// only has effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
		/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified.
		/// </summary>
		// Token: 0x06010E39 RID: 69177 RVA: 0x001788C0 File Offset: 0x00176AC0
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetCamera_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x06010E3A RID: 69178
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSilhouette_GetDirection_05(HandleRef pThis);

		/// <summary>
		/// Specify how view direction is computed. By default, the
		/// camera origin (eye) is used.
		/// </summary>
		// Token: 0x06010E3B RID: 69179 RVA: 0x00178930 File Offset: 0x00176B30
		public virtual int GetDirection()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetDirection_05(base.GetCppThis());
		}

		// Token: 0x06010E3C RID: 69180
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSilhouette_GetEnableFeatureAngle_06(HandleRef pThis);

		/// <summary>
		/// Enables or Disables generation of silhouette edges along sharp edges
		/// </summary>
		// Token: 0x06010E3D RID: 69181 RVA: 0x00178950 File Offset: 0x00176B50
		public virtual int GetEnableFeatureAngle()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetEnableFeatureAngle_06(base.GetCppThis());
		}

		// Token: 0x06010E3E RID: 69182
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataSilhouette_GetFeatureAngle_07(HandleRef pThis);

		/// <summary>
		/// Sets/Gets minimal angle for sharp edges detection. Default is 60
		/// </summary>
		// Token: 0x06010E3F RID: 69183 RVA: 0x00178970 File Offset: 0x00176B70
		public virtual double GetFeatureAngle()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetFeatureAngle_07(base.GetCppThis());
		}

		// Token: 0x06010E40 RID: 69184
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyDataSilhouette_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Return MTime also considering the dependent objects: the camera
		/// and/or the prop3D.
		/// </summary>
		// Token: 0x06010E41 RID: 69185 RVA: 0x00178990 File Offset: 0x00176B90
		public override ulong GetMTime()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x06010E42 RID: 69186
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataSilhouette_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E43 RID: 69187 RVA: 0x001789B0 File Offset: 0x00176BB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06010E44 RID: 69188
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataSilhouette_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E45 RID: 69189 RVA: 0x001789D0 File Offset: 0x00176BD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06010E46 RID: 69190
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSilhouette_GetOrigin_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort direction
		/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
		/// the direction of the origin to each edge's center.
		/// </summary>
		// Token: 0x06010E47 RID: 69191 RVA: 0x001789EC File Offset: 0x00176BEC
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetOrigin_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010E48 RID: 69192
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_GetOrigin_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort direction
		/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
		/// the direction of the origin to each edge's center.
		/// </summary>
		// Token: 0x06010E49 RID: 69193 RVA: 0x00178A34 File Offset: 0x00176C34
		public virtual void GetOrigin(IntPtr data)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetOrigin_12(base.GetCppThis(), data);
		}

		// Token: 0x06010E4A RID: 69194
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSilhouette_GetPieceInvariant_13(HandleRef pThis);

		/// <summary>
		/// Enables or Disables piece invariance. This is useful when dealing with
		/// multi-block data sets. Note: requires one level of ghost cells
		/// </summary>
		// Token: 0x06010E4B RID: 69195 RVA: 0x00178A44 File Offset: 0x00176C44
		public virtual int GetPieceInvariant()
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetPieceInvariant_13(base.GetCppThis());
		}

		// Token: 0x06010E4C RID: 69196
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSilhouette_GetProp3D_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
		/// that is used to include the effects of transformation. This ivar only has
		/// effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
		/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified. Specifying the
		/// vtkProp3D is optional.
		/// </summary>
		// Token: 0x06010E4D RID: 69197 RVA: 0x00178A64 File Offset: 0x00176C64
		public vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetProp3D_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x06010E4E RID: 69198
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSilhouette_GetVector_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
		/// occurs in the direction of the vector.
		/// </summary>
		// Token: 0x06010E4F RID: 69199 RVA: 0x00178AD4 File Offset: 0x00176CD4
		public virtual double[] GetVector()
		{
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetVector_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010E50 RID: 69200
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_GetVector_16(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
		/// occurs in the direction of the vector.
		/// </summary>
		// Token: 0x06010E51 RID: 69201 RVA: 0x00178B1C File Offset: 0x00176D1C
		public virtual void GetVector(IntPtr data)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_GetVector_16(base.GetCppThis(), data);
		}

		// Token: 0x06010E52 RID: 69202
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSilhouette_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E53 RID: 69203 RVA: 0x00178B2C File Offset: 0x00176D2C
		public override int IsA(string type)
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06010E54 RID: 69204
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataSilhouette_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E55 RID: 69205 RVA: 0x00178B4C File Offset: 0x00176D4C
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataSilhouette.vtkPolyDataSilhouette_IsTypeOf_18(type);
		}

		// Token: 0x06010E56 RID: 69206
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSilhouette_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E57 RID: 69207 RVA: 0x00178B68 File Offset: 0x00176D68
		public new vtkPolyDataSilhouette NewInstance()
		{
			vtkPolyDataSilhouette result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010E58 RID: 69208
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_PieceInvariantOff_21(HandleRef pThis);

		/// <summary>
		/// Enables or Disables piece invariance. This is useful when dealing with
		/// multi-block data sets. Note: requires one level of ghost cells
		/// </summary>
		// Token: 0x06010E59 RID: 69209 RVA: 0x00178BC2 File Offset: 0x00176DC2
		public virtual void PieceInvariantOff()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_PieceInvariantOff_21(base.GetCppThis());
		}

		// Token: 0x06010E5A RID: 69210
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_PieceInvariantOn_22(HandleRef pThis);

		/// <summary>
		/// Enables or Disables piece invariance. This is useful when dealing with
		/// multi-block data sets. Note: requires one level of ghost cells
		/// </summary>
		// Token: 0x06010E5B RID: 69211 RVA: 0x00178BD1 File Offset: 0x00176DD1
		public virtual void PieceInvariantOn()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_PieceInvariantOn_22(base.GetCppThis());
		}

		// Token: 0x06010E5C RID: 69212
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataSilhouette_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010E5D RID: 69213 RVA: 0x00178BE0 File Offset: 0x00176DE0
		public new static vtkPolyDataSilhouette SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataSilhouette vtkPolyDataSilhouette = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataSilhouette.vtkPolyDataSilhouette_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataSilhouette = (vtkPolyDataSilhouette)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataSilhouette.Register(null);
				}
			}
			return vtkPolyDataSilhouette;
		}

		// Token: 0x06010E5E RID: 69214
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetBorderEdges_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Enables or Disables generation of border edges. Note: borders exist only
		/// in case of non closed surface
		/// </summary>
		// Token: 0x06010E5F RID: 69215 RVA: 0x00178C5F File Offset: 0x00176E5F
		public virtual void SetBorderEdges(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetBorderEdges_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E60 RID: 69216
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetCamera_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a camera that is used to define the view direction.  This ivar
		/// only has effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
		/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified.
		/// </summary>
		// Token: 0x06010E61 RID: 69217 RVA: 0x00178C70 File Offset: 0x00176E70
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetCamera_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010E62 RID: 69218
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetDirection_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how view direction is computed. By default, the
		/// camera origin (eye) is used.
		/// </summary>
		// Token: 0x06010E63 RID: 69219 RVA: 0x00178C9F File Offset: 0x00176E9F
		public virtual void SetDirection(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirection_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E64 RID: 69220
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToCameraOrigin_27(HandleRef pThis);

		/// <summary>
		/// Specify how view direction is computed. By default, the
		/// camera origin (eye) is used.
		/// </summary>
		// Token: 0x06010E65 RID: 69221 RVA: 0x00178CAF File Offset: 0x00176EAF
		public void SetDirectionToCameraOrigin()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToCameraOrigin_27(base.GetCppThis());
		}

		// Token: 0x06010E66 RID: 69222
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToCameraVector_28(HandleRef pThis);

		/// <summary>
		/// Specify how view direction is computed. By default, the
		/// camera origin (eye) is used.
		/// </summary>
		// Token: 0x06010E67 RID: 69223 RVA: 0x00178CBE File Offset: 0x00176EBE
		public void SetDirectionToCameraVector()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToCameraVector_28(base.GetCppThis());
		}

		// Token: 0x06010E68 RID: 69224
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToSpecifiedOrigin_29(HandleRef pThis);

		/// <summary>
		/// Specify how view direction is computed. By default, the
		/// camera origin (eye) is used.
		/// </summary>
		// Token: 0x06010E69 RID: 69225 RVA: 0x00178CCD File Offset: 0x00176ECD
		public void SetDirectionToSpecifiedOrigin()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToSpecifiedOrigin_29(base.GetCppThis());
		}

		// Token: 0x06010E6A RID: 69226
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetDirectionToSpecifiedVector_30(HandleRef pThis);

		/// <summary>
		/// Specify how view direction is computed. By default, the
		/// camera origin (eye) is used.
		/// </summary>
		// Token: 0x06010E6B RID: 69227 RVA: 0x00178CDC File Offset: 0x00176EDC
		public void SetDirectionToSpecifiedVector()
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetDirectionToSpecifiedVector_30(base.GetCppThis());
		}

		// Token: 0x06010E6C RID: 69228
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetEnableFeatureAngle_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Enables or Disables generation of silhouette edges along sharp edges
		/// </summary>
		// Token: 0x06010E6D RID: 69229 RVA: 0x00178CEB File Offset: 0x00176EEB
		public virtual void SetEnableFeatureAngle(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetEnableFeatureAngle_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E6E RID: 69230
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetFeatureAngle_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Sets/Gets minimal angle for sharp edges detection. Default is 60
		/// </summary>
		// Token: 0x06010E6F RID: 69231 RVA: 0x00178CFB File Offset: 0x00176EFB
		public virtual void SetFeatureAngle(double _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetFeatureAngle_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E70 RID: 69232
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetOrigin_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort direction
		/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
		/// the direction of the origin to each edge's center.
		/// </summary>
		// Token: 0x06010E71 RID: 69233 RVA: 0x00178D0B File Offset: 0x00176F0B
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetOrigin_33(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06010E72 RID: 69234
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetOrigin_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort direction
		/// is set to SetDirectionToSpecifiedOrigin(). The edge detection occurs in
		/// the direction of the origin to each edge's center.
		/// </summary>
		// Token: 0x06010E73 RID: 69235 RVA: 0x00178D1D File Offset: 0x00176F1D
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetOrigin_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E74 RID: 69236
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetPieceInvariant_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Enables or Disables piece invariance. This is useful when dealing with
		/// multi-block data sets. Note: requires one level of ghost cells
		/// </summary>
		// Token: 0x06010E75 RID: 69237 RVA: 0x00178D2D File Offset: 0x00176F2D
		public virtual void SetPieceInvariant(int _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetPieceInvariant_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E76 RID: 69238
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetProp3D_36(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
		/// that is used to include the effects of transformation. This ivar only has
		/// effect if the direction is set to VTK_DIRECTION_CAMERA_ORIGIN or
		/// VTK_DIRECTION_CAMERA_VECTOR, and a camera is specified. Specifying the
		/// vtkProp3D is optional.
		/// </summary>
		// Token: 0x06010E77 RID: 69239 RVA: 0x00178D40 File Offset: 0x00176F40
		public void SetProp3D(vtkProp3D arg0)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetProp3D_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010E78 RID: 69240
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetVector_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
		/// occurs in the direction of the vector.
		/// </summary>
		// Token: 0x06010E79 RID: 69241 RVA: 0x00178D6F File Offset: 0x00176F6F
		public virtual void SetVector(double _arg1, double _arg2, double _arg3)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetVector_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06010E7A RID: 69242
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataSilhouette_SetVector_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The edge detection
		/// occurs in the direction of the vector.
		/// </summary>
		// Token: 0x06010E7B RID: 69243 RVA: 0x00178D81 File Offset: 0x00176F81
		public virtual void SetVector(IntPtr _arg)
		{
			vtkPolyDataSilhouette.vtkPolyDataSilhouette_SetVector_38(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400137C RID: 4988
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataSilhouette";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400137D RID: 4989
		public new static readonly string MRClassNameKey = "class vtkPolyDataSilhouette";

		/// <summary>
		/// Enables or Disables piece invariance. This is useful when dealing with
		/// multi-block data sets. Note: requires one level of ghost cells
		/// </summary>
		// Token: 0x02000612 RID: 1554
		public enum Directions
		{
			/// <summary>enum member</summary>
			// Token: 0x0400137F RID: 4991
			VTK_DIRECTION_CAMERA_ORIGIN = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001380 RID: 4992
			VTK_DIRECTION_CAMERA_VECTOR,
			/// <summary>enum member</summary>
			// Token: 0x04001381 RID: 4993
			VTK_DIRECTION_SPECIFIED_ORIGIN = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001382 RID: 4994
			VTK_DIRECTION_SPECIFIED_VECTOR = 0
		}
	}
}
