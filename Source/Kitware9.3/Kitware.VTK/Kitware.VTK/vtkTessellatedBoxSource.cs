using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTessellatedBoxSource
	/// </summary>
	/// <remarks>
	///    Create a polygonal representation of a box
	/// with a given level of subdivision.
	///
	/// vtkTessellatedBoxSource creates a axis-aligned box defined by its bounds
	/// and a level of subdivision. Connectivity is strong: points of the vertices
	/// and inside the edges are shared between faces. In other words, faces are
	/// connected. Each face looks like a grid of quads, each quad is composed of
	/// 2 triangles.
	/// Given a level of subdivision `l', each edge has `l'+2 points, `l' of them
	/// are internal edge points, the 2 other ones are the vertices.
	/// Each face has a total of (`l'+2)*(`l'+2) points, 4 of them are vertices,
	/// 4*`l' are internal edge points, it remains `l'^2 internal face points.
	///
	/// This source only generate geometry, no DataArrays like normals or texture
	/// coordinates.
	/// </remarks>
	// Token: 0x02000845 RID: 2117
	public class vtkTessellatedBoxSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015F10 RID: 89872 RVA: 0x001EE9CE File Offset: 0x001ECBCE
		static vtkTessellatedBoxSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTessellatedBoxSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTessellatedBoxSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015F11 RID: 89873 RVA: 0x001EE9F6 File Offset: 0x001ECBF6
		public vtkTessellatedBoxSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015F12 RID: 89874
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatedBoxSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F13 RID: 89875 RVA: 0x001EEA04 File Offset: 0x001ECC04
		public new static vtkTessellatedBoxSource New()
		{
			vtkTessellatedBoxSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F14 RID: 89876 RVA: 0x001EEA58 File Offset: 0x001ECC58
		public vtkTessellatedBoxSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTessellatedBoxSource.vtkTessellatedBoxSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015F15 RID: 89877 RVA: 0x001EEA9C File Offset: 0x001ECC9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015F16 RID: 89878
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_DuplicateSharedPointsOff_01(HandleRef pThis);

		/// <summary>
		/// Flag to tell the source to duplicate points shared between faces
		/// (vertices of the box and internal edge points). Initial value is false.
		/// Implementation note: duplicating points is an easier method to implement
		/// than a minimal number of points.
		/// </summary>
		// Token: 0x06015F17 RID: 89879 RVA: 0x001EEAA7 File Offset: 0x001ECCA7
		public virtual void DuplicateSharedPointsOff()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_DuplicateSharedPointsOff_01(base.GetCppThis());
		}

		// Token: 0x06015F18 RID: 89880
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_DuplicateSharedPointsOn_02(HandleRef pThis);

		/// <summary>
		/// Flag to tell the source to duplicate points shared between faces
		/// (vertices of the box and internal edge points). Initial value is false.
		/// Implementation note: duplicating points is an easier method to implement
		/// than a minimal number of points.
		/// </summary>
		// Token: 0x06015F19 RID: 89881 RVA: 0x001EEAB6 File Offset: 0x001ECCB6
		public virtual void DuplicateSharedPointsOn()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_DuplicateSharedPointsOn_02(base.GetCppThis());
		}

		// Token: 0x06015F1A RID: 89882
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatedBoxSource_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Bounds of the box in world coordinates. This a 6-uple of xmin,xmax,ymin,
		/// ymax,zmin and zmax. Initial value is (-0.5,0.5,-0.5,0.5,-0.5,0.5), bounds
		/// of a cube of length 1 centered at (0,0,0). Bounds are defined such that
		/// xmin&lt;=xmax, ymin&lt;=ymax and zmin&lt;zmax.
		/// \post xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
		/// </summary>
		// Token: 0x06015F1B RID: 89883 RVA: 0x001EEAC8 File Offset: 0x001ECCC8
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015F1C RID: 89884
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_GetBounds_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Bounds of the box in world coordinates. This a 6-uple of xmin,xmax,ymin,
		/// ymax,zmin and zmax. Initial value is (-0.5,0.5,-0.5,0.5,-0.5,0.5), bounds
		/// of a cube of length 1 centered at (0,0,0). Bounds are defined such that
		/// xmin&lt;=xmax, ymin&lt;=ymax and zmin&lt;zmax.
		/// \post xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
		/// </summary>
		// Token: 0x06015F1D RID: 89885 RVA: 0x001EEB10 File Offset: 0x001ECD10
		public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetBounds_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06015F1E RID: 89886
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_GetBounds_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Bounds of the box in world coordinates. This a 6-uple of xmin,xmax,ymin,
		/// ymax,zmin and zmax. Initial value is (-0.5,0.5,-0.5,0.5,-0.5,0.5), bounds
		/// of a cube of length 1 centered at (0,0,0). Bounds are defined such that
		/// xmin&lt;=xmax, ymin&lt;=ymax and zmin&lt;zmax.
		/// \post xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
		/// </summary>
		// Token: 0x06015F1F RID: 89887 RVA: 0x001EEB28 File Offset: 0x001ECD28
		public virtual void GetBounds(IntPtr _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetBounds_05(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F20 RID: 89888
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatedBoxSource_GetDuplicateSharedPoints_06(HandleRef pThis);

		/// <summary>
		/// Flag to tell the source to duplicate points shared between faces
		/// (vertices of the box and internal edge points). Initial value is false.
		/// Implementation note: duplicating points is an easier method to implement
		/// than a minimal number of points.
		/// </summary>
		// Token: 0x06015F21 RID: 89889 RVA: 0x001EEB38 File Offset: 0x001ECD38
		public virtual int GetDuplicateSharedPoints()
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetDuplicateSharedPoints_06(base.GetCppThis());
		}

		// Token: 0x06015F22 RID: 89890
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatedBoxSource_GetLevel_07(HandleRef pThis);

		/// <summary>
		/// Level of subdivision of the faces. Initial value is 0.
		/// \post positive_level: level&gt;=0
		/// </summary>
		// Token: 0x06015F23 RID: 89891 RVA: 0x001EEB58 File Offset: 0x001ECD58
		public virtual int GetLevel()
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetLevel_07(base.GetCppThis());
		}

		// Token: 0x06015F24 RID: 89892
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTessellatedBoxSource_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F25 RID: 89893 RVA: 0x001EEB78 File Offset: 0x001ECD78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06015F26 RID: 89894
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTessellatedBoxSource_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F27 RID: 89895 RVA: 0x001EEB98 File Offset: 0x001ECD98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06015F28 RID: 89896
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatedBoxSource_GetOutputPointsPrecision_10(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015F29 RID: 89897 RVA: 0x001EEBB4 File Offset: 0x001ECDB4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetOutputPointsPrecision_10(base.GetCppThis());
		}

		// Token: 0x06015F2A RID: 89898
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatedBoxSource_GetQuads_11(HandleRef pThis);

		/// <summary>
		/// Flag to tell the source to generate either a quad or two triangle for a
		/// set of four points. Initial value is false (generate triangles).
		/// </summary>
		// Token: 0x06015F2B RID: 89899 RVA: 0x001EEBD4 File Offset: 0x001ECDD4
		public virtual int GetQuads()
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetQuads_11(base.GetCppThis());
		}

		// Token: 0x06015F2C RID: 89900
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatedBoxSource_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F2D RID: 89901 RVA: 0x001EEBF4 File Offset: 0x001ECDF4
		public override int IsA(string type)
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06015F2E RID: 89902
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatedBoxSource_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F2F RID: 89903 RVA: 0x001EEC14 File Offset: 0x001ECE14
		public new static int IsTypeOf(string type)
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_IsTypeOf_13(type);
		}

		// Token: 0x06015F30 RID: 89904
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatedBoxSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F31 RID: 89905 RVA: 0x001EEC30 File Offset: 0x001ECE30
		public new vtkTessellatedBoxSource NewInstance()
		{
			vtkTessellatedBoxSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015F32 RID: 89906
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_QuadsOff_16(HandleRef pThis);

		/// <summary>
		/// Flag to tell the source to generate either a quad or two triangle for a
		/// set of four points. Initial value is false (generate triangles).
		/// </summary>
		// Token: 0x06015F33 RID: 89907 RVA: 0x001EEC8A File Offset: 0x001ECE8A
		public virtual void QuadsOff()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_QuadsOff_16(base.GetCppThis());
		}

		// Token: 0x06015F34 RID: 89908
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_QuadsOn_17(HandleRef pThis);

		/// <summary>
		/// Flag to tell the source to generate either a quad or two triangle for a
		/// set of four points. Initial value is false (generate triangles).
		/// </summary>
		// Token: 0x06015F35 RID: 89909 RVA: 0x001EEC99 File Offset: 0x001ECE99
		public virtual void QuadsOn()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_QuadsOn_17(base.GetCppThis());
		}

		// Token: 0x06015F36 RID: 89910
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatedBoxSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015F37 RID: 89911 RVA: 0x001EECA8 File Offset: 0x001ECEA8
		public new static vtkTessellatedBoxSource SafeDownCast(vtkObjectBase o)
		{
			vtkTessellatedBoxSource vtkTessellatedBoxSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTessellatedBoxSource = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTessellatedBoxSource.Register(null);
				}
			}
			return vtkTessellatedBoxSource;
		}

		// Token: 0x06015F38 RID: 89912
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_SetBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set the bounds of the box. See GetBounds() for a detail description.
		/// \pre xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
		/// </summary>
		// Token: 0x06015F39 RID: 89913 RVA: 0x001EED27 File Offset: 0x001ECF27
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetBounds_19(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06015F3A RID: 89914
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_SetBounds_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the bounds of the box. See GetBounds() for a detail description.
		/// \pre xmin&lt;=xmax &amp;&amp; ymin&lt;=ymax &amp;&amp; zmin&lt;zmax
		/// </summary>
		// Token: 0x06015F3B RID: 89915 RVA: 0x001EED3F File Offset: 0x001ECF3F
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetBounds_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F3C RID: 89916
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_SetDuplicateSharedPoints_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Flag to tell the source to duplicate points shared between faces
		/// (vertices of the box and internal edge points). Initial value is false.
		/// Implementation note: duplicating points is an easier method to implement
		/// than a minimal number of points.
		/// </summary>
		// Token: 0x06015F3D RID: 89917 RVA: 0x001EED4F File Offset: 0x001ECF4F
		public virtual void SetDuplicateSharedPoints(int _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetDuplicateSharedPoints_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F3E RID: 89918
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_SetLevel_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the level of subdivision of the faces.
		/// \pre positive_level: level&gt;=0
		/// </summary>
		// Token: 0x06015F3F RID: 89919 RVA: 0x001EED5F File Offset: 0x001ECF5F
		public virtual void SetLevel(int _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetLevel_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F40 RID: 89920
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_SetOutputPointsPrecision_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015F41 RID: 89921 RVA: 0x001EED6F File Offset: 0x001ECF6F
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetOutputPointsPrecision_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06015F42 RID: 89922
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatedBoxSource_SetQuads_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Flag to tell the source to generate either a quad or two triangle for a
		/// set of four points. Initial value is false (generate triangles).
		/// </summary>
		// Token: 0x06015F43 RID: 89923 RVA: 0x001EED7F File Offset: 0x001ECF7F
		public virtual void SetQuads(int _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetQuads_24(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018DE RID: 6366
		public new const string MRFullTypeName = "Kitware.VTK.vtkTessellatedBoxSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018DF RID: 6367
		public new static readonly string MRClassNameKey = "class vtkTessellatedBoxSource";
	}
}
