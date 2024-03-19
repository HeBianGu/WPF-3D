using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAreaPicker
	/// </summary>
	/// <remarks>
	///    Picks props behind a selection rectangle on a viewport.
	///
	///
	/// The vtkAreaPicker picks all vtkProp3Ds that lie behind the screen space
	/// rectangle from x0,y0 and x1,y1. The selection is based upon the bounding
	/// box of the prop and is thus not exact.
	///
	/// Like vtkPicker, a pick results in a list of Prop3Ds because many props may
	/// lie within the pick frustum. You can also get an AssemblyPath, which in this
	/// case is defined to be the path to the one particular prop in the Prop3D list
	/// that lies nearest to the near plane.
	///
	/// This picker also returns the selection frustum, defined as either a
	/// vtkPlanes, or a set of eight corner vertices in world space. The vtkPlanes
	/// version is an ImplicitFunction, which is suitable for use with the
	/// vtkExtractGeometry. The six frustum planes are in order: left, right,
	/// bottom, top, near, far
	///
	/// Because this picker picks everything within a volume, the world pick point
	/// result is ill-defined. Therefore if you ask this class for the world pick
	/// position, you will get the centroid of the pick frustum. This may be outside
	/// of all props in the prop list.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleRubberBandPick, vtkExtractSelectedFrustum.
	/// </seealso>
	// Token: 0x02000810 RID: 2064
	public class vtkAreaPicker : vtkAbstractPropPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015384 RID: 86916 RVA: 0x001E0A2F File Offset: 0x001DEC2F
		static vtkAreaPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAreaPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015385 RID: 86917 RVA: 0x001E0A57 File Offset: 0x001DEC57
		public vtkAreaPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015386 RID: 86918
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015387 RID: 86919 RVA: 0x001E0A68 File Offset: 0x001DEC68
		public new static vtkAreaPicker New()
		{
			vtkAreaPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015388 RID: 86920 RVA: 0x001E0ABC File Offset: 0x001DECBC
		public vtkAreaPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAreaPicker.vtkAreaPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015389 RID: 86921 RVA: 0x001E0B00 File Offset: 0x001DED00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601538A RID: 86922
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaPicker_AreaPick_01(HandleRef pThis, double x0, double y0, double x1, double y1, HandleRef renderer);

		/// <summary>
		/// Perform pick operation in volume behind the given screen coordinates.
		/// Props intersecting the selection frustum will be accessible via GetProp3D.
		/// GetPlanes returns a vtkImplicitFunction suitable for vtkExtractGeometry.
		/// </summary>
		// Token: 0x0601538B RID: 86923 RVA: 0x001E0B0C File Offset: 0x001DED0C
		public virtual int AreaPick(double x0, double y0, double x1, double y1, vtkRenderer renderer)
		{
			return vtkAreaPicker.vtkAreaPicker_AreaPick_01(base.GetCppThis(), x0, y0, x1, y1, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0601538C RID: 86924
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_GetClipPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return eight points that define the selection frustum.
		/// </summary>
		// Token: 0x0601538D RID: 86925 RVA: 0x001E0B48 File Offset: 0x001DED48
		public virtual vtkPoints GetClipPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_GetClipPoints_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601538E RID: 86926
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the dataset that was picked (if any). If nothing
		/// was picked then NULL is returned.
		/// </summary>
		// Token: 0x0601538F RID: 86927 RVA: 0x001E0BB8 File Offset: 0x001DEDB8
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_GetDataSet_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06015390 RID: 86928
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_GetFrustum_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the six planes that define the selection frustum. The implicit
		/// function defined by the planes evaluates to negative inside and positive
		/// outside.
		/// </summary>
		// Token: 0x06015391 RID: 86929 RVA: 0x001E0C28 File Offset: 0x001DEE28
		public virtual vtkPlanes GetFrustum()
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_GetFrustum_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06015392 RID: 86930
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_GetMapper_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return mapper that was picked (if any).
		/// </summary>
		// Token: 0x06015393 RID: 86931 RVA: 0x001E0C98 File Offset: 0x001DEE98
		public virtual vtkAbstractMapper3D GetMapper()
		{
			vtkAbstractMapper3D vtkAbstractMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_GetMapper_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper3D = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper3D.Register(null);
				}
			}
			return vtkAbstractMapper3D;
		}

		// Token: 0x06015394 RID: 86932
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaPicker_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015395 RID: 86933 RVA: 0x001E0D08 File Offset: 0x001DEF08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAreaPicker.vtkAreaPicker_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06015396 RID: 86934
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaPicker_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015397 RID: 86935 RVA: 0x001E0D28 File Offset: 0x001DEF28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAreaPicker.vtkAreaPicker_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06015398 RID: 86936
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_GetProp3Ds_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a collection of all the prop 3D's that were intersected
		/// by the pick ray. This collection is not sorted.
		/// </summary>
		// Token: 0x06015399 RID: 86937 RVA: 0x001E0D44 File Offset: 0x001DEF44
		public vtkProp3DCollection GetProp3Ds()
		{
			vtkProp3DCollection vtkProp3DCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_GetProp3Ds_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DCollection = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DCollection.Register(null);
				}
			}
			return vtkProp3DCollection;
		}

		// Token: 0x0601539A RID: 86938
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaPicker_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601539B RID: 86939 RVA: 0x001E0DB4 File Offset: 0x001DEFB4
		public override int IsA(string type)
		{
			return vtkAreaPicker.vtkAreaPicker_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601539C RID: 86940
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaPicker_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601539D RID: 86941 RVA: 0x001E0DD4 File Offset: 0x001DEFD4
		public new static int IsTypeOf(string type)
		{
			return vtkAreaPicker.vtkAreaPicker_IsTypeOf_10(type);
		}

		// Token: 0x0601539E RID: 86942
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601539F RID: 86943 RVA: 0x001E0DF0 File Offset: 0x001DEFF0
		public new vtkAreaPicker NewInstance()
		{
			vtkAreaPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060153A0 RID: 86944
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaPicker_Pick_13(HandleRef pThis);

		/// <summary>
		/// Perform an AreaPick within the default screen rectangle and renderer.
		/// </summary>
		// Token: 0x060153A1 RID: 86945 RVA: 0x001E0E4C File Offset: 0x001DF04C
		public virtual int Pick()
		{
			return vtkAreaPicker.vtkAreaPicker_Pick_13(base.GetCppThis());
		}

		// Token: 0x060153A2 RID: 86946
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaPicker_Pick_14(HandleRef pThis, double x0, double y0, double arg2, HandleRef renderer);

		/// <summary>
		/// Perform pick operation in volume behind the given screen coordinate.
		/// This makes a thin frustum around the selected pixel.
		/// Note: this ignores Z in order to pick everying in a volume from z=0 to z=1.
		/// </summary>
		// Token: 0x060153A3 RID: 86947 RVA: 0x001E0E6C File Offset: 0x001DF06C
		public override int Pick(double x0, double y0, double arg2, vtkRenderer renderer)
		{
			return vtkAreaPicker.vtkAreaPicker_Pick_14(base.GetCppThis(), x0, y0, arg2, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x060153A4 RID: 86948
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaPicker_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060153A5 RID: 86949 RVA: 0x001E0EA8 File Offset: 0x001DF0A8
		public new static vtkAreaPicker SafeDownCast(vtkObjectBase o)
		{
			vtkAreaPicker vtkAreaPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaPicker.vtkAreaPicker_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaPicker = (vtkAreaPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaPicker.Register(null);
				}
			}
			return vtkAreaPicker;
		}

		// Token: 0x060153A6 RID: 86950
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaPicker_SetPickCoords_16(HandleRef pThis, double x0, double y0, double x1, double y1);

		/// <summary>
		/// Set the default screen rectangle to pick in.
		/// </summary>
		// Token: 0x060153A7 RID: 86951 RVA: 0x001E0F27 File Offset: 0x001DF127
		public void SetPickCoords(double x0, double y0, double x1, double y1)
		{
			vtkAreaPicker.vtkAreaPicker_SetPickCoords_16(base.GetCppThis(), x0, y0, x1, y1);
		}

		// Token: 0x060153A8 RID: 86952
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaPicker_SetRenderer_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the default renderer to pick on.
		/// </summary>
		// Token: 0x060153A9 RID: 86953 RVA: 0x001E0F3C File Offset: 0x001DF13C
		public void SetRenderer(vtkRenderer arg0)
		{
			vtkAreaPicker.vtkAreaPicker_SetRenderer_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001868 RID: 6248
		public new const string MRFullTypeName = "Kitware.VTK.vtkAreaPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001869 RID: 6249
		public new static readonly string MRClassNameKey = "class vtkAreaPicker";
	}
}
