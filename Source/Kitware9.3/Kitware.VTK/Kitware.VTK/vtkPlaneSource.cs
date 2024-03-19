using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlaneSource
	/// </summary>
	/// <remarks>
	///    create an array of quadrilaterals located in a plane
	///
	/// vtkPlaneSource creates an m x n array of quadrilaterals arranged as
	/// a regular tiling in a plane. The plane is defined by specifying an
	/// origin point, and then two other points that, together with the
	/// origin, define two axes for the plane. These axes do not have to be
	/// orthogonal - so you can create a parallelogram. (The axes must not
	/// be parallel.) The resolution of the plane (i.e., number of subdivisions) is
	/// controlled by the ivars XResolution and YResolution.
	///
	/// By default, the plane is centered at the origin and perpendicular to the
	/// z-axis, with width and height of length 1 and resolutions set to 1.
	///
	/// There are three convenience methods that allow you to easily move the
	/// plane.  The first, SetNormal(), allows you to specify the plane
	/// normal. The effect of this method is to rotate the plane around the center
	/// of the plane, aligning the plane normal with the specified normal. The
	/// rotation is about the axis defined by the cross product of the current
	/// normal with the new normal. The second, SetCenter(), translates the center
	/// of the plane to the specified center point. The third method, Push(),
	/// allows you to translate the plane along the plane normal by the distance
	/// specified. (Negative Push values translate the plane in the negative
	/// normal direction.)  Note that the SetNormal(), SetCenter() and Push()
	/// methods modify the Origin, Point1, and/or Point2 instance variables.
	///
	/// @warning
	/// The normal to the plane will point in the direction of the cross product
	/// of the first axis (Origin-&gt;Point1) with the second (Origin-&gt;Point2). This
	/// also affects the normals to the generated polygons.
	/// </remarks>
	// Token: 0x02000835 RID: 2101
	public class vtkPlaneSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015BBC RID: 89020 RVA: 0x001EABD3 File Offset: 0x001E8DD3
		static vtkPlaneSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaneSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015BBD RID: 89021 RVA: 0x001EABFB File Offset: 0x001E8DFB
		public vtkPlaneSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015BBE RID: 89022
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct plane perpendicular to z-axis, resolution 1x1, width
		/// and height 1.0, and centered at the origin.
		/// </summary>
		// Token: 0x06015BBF RID: 89023 RVA: 0x001EAC0C File Offset: 0x001E8E0C
		public new static vtkPlaneSource New()
		{
			vtkPlaneSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct plane perpendicular to z-axis, resolution 1x1, width
		/// and height 1.0, and centered at the origin.
		/// </summary>
		// Token: 0x06015BC0 RID: 89024 RVA: 0x001EAC60 File Offset: 0x001E8E60
		public vtkPlaneSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlaneSource.vtkPlaneSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015BC1 RID: 89025 RVA: 0x001EACA4 File Offset: 0x001E8EA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015BC2 RID: 89026
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetAxis1_01(HandleRef pThis, IntPtr a1);

		/// <summary>
		/// Convenience methods to retrieve the axes of the plane; that is
		/// axis a1 is the vector (Point1-Origin), and axis a2 is the vector
		/// (Point2-Origin).
		/// </summary>
		// Token: 0x06015BC3 RID: 89027 RVA: 0x001EACAF File Offset: 0x001E8EAF
		public void GetAxis1(IntPtr a1)
		{
			vtkPlaneSource.vtkPlaneSource_GetAxis1_01(base.GetCppThis(), a1);
		}

		// Token: 0x06015BC4 RID: 89028
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetAxis2_02(HandleRef pThis, IntPtr a2);

		/// <summary>
		/// Convenience methods to retrieve the axes of the plane; that is
		/// axis a1 is the vector (Point1-Origin), and axis a2 is the vector
		/// (Point2-Origin).
		/// </summary>
		// Token: 0x06015BC5 RID: 89029 RVA: 0x001EACBF File Offset: 0x001E8EBF
		public void GetAxis2(IntPtr a2)
		{
			vtkPlaneSource.vtkPlaneSource_GetAxis2_02(base.GetCppThis(), a2);
		}

		// Token: 0x06015BC6 RID: 89030
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the center of the plane. Works in conjunction with the plane
		/// normal to position the plane. Don't use this method to define the plane.
		/// Instead, use it to move the plane to a new center point.
		/// </summary>
		// Token: 0x06015BC7 RID: 89031 RVA: 0x001EACD0 File Offset: 0x001E8ED0
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015BC8 RID: 89032
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetCenter_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the center of the plane. Works in conjunction with the plane
		/// normal to position the plane. Don't use this method to define the plane.
		/// Instead, use it to move the plane to a new center point.
		/// </summary>
		// Token: 0x06015BC9 RID: 89033 RVA: 0x001EAD18 File Offset: 0x001E8F18
		public virtual void GetCenter(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetCenter_04(base.GetCppThis(), data);
		}

		// Token: 0x06015BCA RID: 89034
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_GetNormal_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the plane normal. Works in conjunction with the plane center to
		/// orient the plane. Don't use this method to define the plane. Instead, use
		/// it to rotate the plane around the current center point.
		/// </summary>
		// Token: 0x06015BCB RID: 89035 RVA: 0x001EAD28 File Offset: 0x001E8F28
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetNormal_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015BCC RID: 89036
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetNormal_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the plane normal. Works in conjunction with the plane center to
		/// orient the plane. Don't use this method to define the plane. Instead, use
		/// it to rotate the plane around the current center point.
		/// </summary>
		// Token: 0x06015BCD RID: 89037 RVA: 0x001EAD70 File Offset: 0x001E8F70
		public virtual void GetNormal(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetNormal_06(base.GetCppThis(), data);
		}

		// Token: 0x06015BCE RID: 89038
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneSource_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BCF RID: 89039 RVA: 0x001EAD80 File Offset: 0x001E8F80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlaneSource.vtkPlaneSource_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06015BD0 RID: 89040
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneSource_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BD1 RID: 89041 RVA: 0x001EADA0 File Offset: 0x001E8FA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlaneSource.vtkPlaneSource_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06015BD2 RID: 89042
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_GetOrigin_09(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the origin of the plane.
		/// </summary>
		// Token: 0x06015BD3 RID: 89043 RVA: 0x001EADBC File Offset: 0x001E8FBC
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetOrigin_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015BD4 RID: 89044
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetOrigin_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the origin of the plane.
		/// </summary>
		// Token: 0x06015BD5 RID: 89045 RVA: 0x001EAE04 File Offset: 0x001E9004
		public virtual void GetOrigin(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetOrigin_10(base.GetCppThis(), data);
		}

		// Token: 0x06015BD6 RID: 89046
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneSource_GetOutputPointsPrecision_11(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015BD7 RID: 89047 RVA: 0x001EAE14 File Offset: 0x001E9014
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPlaneSource.vtkPlaneSource_GetOutputPointsPrecision_11(base.GetCppThis());
		}

		// Token: 0x06015BD8 RID: 89048
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_GetPoint1_12(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06015BD9 RID: 89049 RVA: 0x001EAE34 File Offset: 0x001E9034
		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetPoint1_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015BDA RID: 89050
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetPoint1_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06015BDB RID: 89051 RVA: 0x001EAE7C File Offset: 0x001E907C
		public virtual void GetPoint1(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetPoint1_13(base.GetCppThis(), data);
		}

		// Token: 0x06015BDC RID: 89052
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_GetPoint2_14(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x06015BDD RID: 89053 RVA: 0x001EAE8C File Offset: 0x001E908C
		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetPoint2_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015BDE RID: 89054
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetPoint2_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x06015BDF RID: 89055 RVA: 0x001EAED4 File Offset: 0x001E90D4
		public virtual void GetPoint2(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetPoint2_15(base.GetCppThis(), data);
		}

		// Token: 0x06015BE0 RID: 89056
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_GetResolution_16(HandleRef pThis, ref int xR, ref int yR);

		/// <summary>
		/// Set the number of x-y subdivisions in the plane.
		/// </summary>
		// Token: 0x06015BE1 RID: 89057 RVA: 0x001EAEE4 File Offset: 0x001E90E4
		public void GetResolution(ref int xR, ref int yR)
		{
			vtkPlaneSource.vtkPlaneSource_GetResolution_16(base.GetCppThis(), ref xR, ref yR);
		}

		// Token: 0x06015BE2 RID: 89058
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneSource_GetXResolution_17(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the plane along the first axes.
		/// </summary>
		// Token: 0x06015BE3 RID: 89059 RVA: 0x001EAEF8 File Offset: 0x001E90F8
		public virtual int GetXResolution()
		{
			return vtkPlaneSource.vtkPlaneSource_GetXResolution_17(base.GetCppThis());
		}

		// Token: 0x06015BE4 RID: 89060
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneSource_GetYResolution_18(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the plane along the second axes.
		/// </summary>
		// Token: 0x06015BE5 RID: 89061 RVA: 0x001EAF18 File Offset: 0x001E9118
		public virtual int GetYResolution()
		{
			return vtkPlaneSource.vtkPlaneSource_GetYResolution_18(base.GetCppThis());
		}

		// Token: 0x06015BE6 RID: 89062
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneSource_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BE7 RID: 89063 RVA: 0x001EAF38 File Offset: 0x001E9138
		public override int IsA(string type)
		{
			return vtkPlaneSource.vtkPlaneSource_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06015BE8 RID: 89064
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneSource_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BE9 RID: 89065 RVA: 0x001EAF58 File Offset: 0x001E9158
		public new static int IsTypeOf(string type)
		{
			return vtkPlaneSource.vtkPlaneSource_IsTypeOf_20(type);
		}

		// Token: 0x06015BEA RID: 89066
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BEB RID: 89067 RVA: 0x001EAF74 File Offset: 0x001E9174
		public new vtkPlaneSource NewInstance()
		{
			vtkPlaneSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015BEC RID: 89068
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_Push_23(HandleRef pThis, double distance);

		/// <summary>
		/// Translate the plane in the direction of the normal by the
		/// distance specified.  Negative values move the plane in the
		/// opposite direction.
		/// </summary>
		// Token: 0x06015BED RID: 89069 RVA: 0x001EAFCE File Offset: 0x001E91CE
		public void Push(double distance)
		{
			vtkPlaneSource.vtkPlaneSource_Push_23(base.GetCppThis(), distance);
		}

		// Token: 0x06015BEE RID: 89070
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_Rotate_24(HandleRef pThis, double angle, IntPtr rotationAxis);

		/// <summary>
		/// Rotate plane at center around a given axis
		/// If the absolute value of the angle is inferior to the defined EPSILON, then don't
		/// rotate
		/// </summary>
		// Token: 0x06015BEF RID: 89071 RVA: 0x001EAFDE File Offset: 0x001E91DE
		public void Rotate(double angle, IntPtr rotationAxis)
		{
			vtkPlaneSource.vtkPlaneSource_Rotate_24(base.GetCppThis(), angle, rotationAxis);
		}

		// Token: 0x06015BF0 RID: 89072
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneSource_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BF1 RID: 89073 RVA: 0x001EAFF0 File Offset: 0x001E91F0
		public new static vtkPlaneSource SafeDownCast(vtkObjectBase o)
		{
			vtkPlaneSource vtkPlaneSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneSource = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneSource.Register(null);
				}
			}
			return vtkPlaneSource;
		}

		// Token: 0x06015BF2 RID: 89074
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetCenter_26(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the center of the plane. Works in conjunction with the plane
		/// normal to position the plane. Don't use this method to define the plane.
		/// Instead, use it to move the plane to a new center point.
		/// </summary>
		// Token: 0x06015BF3 RID: 89075 RVA: 0x001EB06F File Offset: 0x001E926F
		public void SetCenter(double x, double y, double z)
		{
			vtkPlaneSource.vtkPlaneSource_SetCenter_26(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06015BF4 RID: 89076
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetCenter_27(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Set/Get the center of the plane. Works in conjunction with the plane
		/// normal to position the plane. Don't use this method to define the plane.
		/// Instead, use it to move the plane to a new center point.
		/// </summary>
		// Token: 0x06015BF5 RID: 89077 RVA: 0x001EB081 File Offset: 0x001E9281
		public void SetCenter(IntPtr center)
		{
			vtkPlaneSource.vtkPlaneSource_SetCenter_27(base.GetCppThis(), center);
		}

		// Token: 0x06015BF6 RID: 89078
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetNormal_28(HandleRef pThis, double nx, double ny, double nz);

		/// <summary>
		/// Set/Get the plane normal. Works in conjunction with the plane center to
		/// orient the plane. Don't use this method to define the plane. Instead, use
		/// it to rotate the plane around the current center point.
		/// </summary>
		// Token: 0x06015BF7 RID: 89079 RVA: 0x001EB091 File Offset: 0x001E9291
		public void SetNormal(double nx, double ny, double nz)
		{
			vtkPlaneSource.vtkPlaneSource_SetNormal_28(base.GetCppThis(), nx, ny, nz);
		}

		// Token: 0x06015BF8 RID: 89080
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetNormal_29(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Set/Get the plane normal. Works in conjunction with the plane center to
		/// orient the plane. Don't use this method to define the plane. Instead, use
		/// it to rotate the plane around the current center point.
		/// </summary>
		// Token: 0x06015BF9 RID: 89081 RVA: 0x001EB0A3 File Offset: 0x001E92A3
		public void SetNormal(IntPtr n)
		{
			vtkPlaneSource.vtkPlaneSource_SetNormal_29(base.GetCppThis(), n);
		}

		// Token: 0x06015BFA RID: 89082
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetOrigin_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point defining the origin of the plane.
		/// </summary>
		// Token: 0x06015BFB RID: 89083 RVA: 0x001EB0B3 File Offset: 0x001E92B3
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkPlaneSource.vtkPlaneSource_SetOrigin_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015BFC RID: 89084
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetOrigin_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point defining the origin of the plane.
		/// </summary>
		// Token: 0x06015BFD RID: 89085 RVA: 0x001EB0C5 File Offset: 0x001E92C5
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkPlaneSource.vtkPlaneSource_SetOrigin_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06015BFE RID: 89086
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetOutputPointsPrecision_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015BFF RID: 89087 RVA: 0x001EB0D5 File Offset: 0x001E92D5
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPlaneSource.vtkPlaneSource_SetOutputPointsPrecision_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C00 RID: 89088
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetPoint1_33(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06015C01 RID: 89089 RVA: 0x001EB0E5 File Offset: 0x001E92E5
		public void SetPoint1(double x, double y, double z)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint1_33(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06015C02 RID: 89090
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetPoint1_34(HandleRef pThis, IntPtr pnt);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06015C03 RID: 89091 RVA: 0x001EB0F7 File Offset: 0x001E92F7
		public void SetPoint1(IntPtr pnt)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint1_34(base.GetCppThis(), pnt);
		}

		// Token: 0x06015C04 RID: 89092
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetPoint2_35(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x06015C05 RID: 89093 RVA: 0x001EB107 File Offset: 0x001E9307
		public void SetPoint2(double x, double y, double z)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint2_35(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06015C06 RID: 89094
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetPoint2_36(HandleRef pThis, IntPtr pnt);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x06015C07 RID: 89095 RVA: 0x001EB119 File Offset: 0x001E9319
		public void SetPoint2(IntPtr pnt)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint2_36(base.GetCppThis(), pnt);
		}

		// Token: 0x06015C08 RID: 89096
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetResolution_37(HandleRef pThis, int xR, int yR);

		/// <summary>
		/// Set the number of x-y subdivisions in the plane.
		/// </summary>
		// Token: 0x06015C09 RID: 89097 RVA: 0x001EB129 File Offset: 0x001E9329
		public void SetResolution(int xR, int yR)
		{
			vtkPlaneSource.vtkPlaneSource_SetResolution_37(base.GetCppThis(), xR, yR);
		}

		// Token: 0x06015C0A RID: 89098
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetXResolution_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the resolution of the plane along the first axes.
		/// </summary>
		// Token: 0x06015C0B RID: 89099 RVA: 0x001EB13A File Offset: 0x001E933A
		public virtual void SetXResolution(int _arg)
		{
			vtkPlaneSource.vtkPlaneSource_SetXResolution_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C0C RID: 89100
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneSource_SetYResolution_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the resolution of the plane along the second axes.
		/// </summary>
		// Token: 0x06015C0D RID: 89101 RVA: 0x001EB14A File Offset: 0x001E934A
		public virtual void SetYResolution(int _arg)
		{
			vtkPlaneSource.vtkPlaneSource_SetYResolution_39(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C1 RID: 6337
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C2 RID: 6338
		public new static readonly string MRClassNameKey = "class vtkPlaneSource";
	}
}
