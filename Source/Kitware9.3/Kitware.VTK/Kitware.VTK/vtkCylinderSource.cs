using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCylinderSource
	/// </summary>
	/// <remarks>
	///    generate a polygonal cylinder centered at the origin
	///
	/// vtkCylinderSource creates a polygonal cylinder centered at Center; The axis of the cylinder is
	/// aligned along the global y-axis.  The height and radius of the cylinder can be specified, as well
	/// as the number of sides. It is also possible to control whether the cylinder is open-ended or
	/// capped. The cylinder can be given a capsular shape by enabling hemispherical end caps. If you
	/// have the end points of the cylinder, you should use a vtkLineSource followed by a vtkTubeFilter
	/// instead of the vtkCylinderSource.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCylinder
	/// </seealso>
	// Token: 0x02000824 RID: 2084
	public class vtkCylinderSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015820 RID: 88096 RVA: 0x001E68C1 File Offset: 0x001E4AC1
		static vtkCylinderSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCylinderSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCylinderSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015821 RID: 88097 RVA: 0x001E68E9 File Offset: 0x001E4AE9
		public vtkCylinderSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015822 RID: 88098
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinderSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015823 RID: 88099 RVA: 0x001E68F8 File Offset: 0x001E4AF8
		public new static vtkCylinderSource New()
		{
			vtkCylinderSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015824 RID: 88100 RVA: 0x001E694C File Offset: 0x001E4B4C
		public vtkCylinderSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCylinderSource.vtkCylinderSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015825 RID: 88101 RVA: 0x001E6990 File Offset: 0x001E4B90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015826 RID: 88102
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_CappingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
		/// </summary>
		// Token: 0x06015827 RID: 88103 RVA: 0x001E699B File Offset: 0x001E4B9B
		public virtual void CappingOff()
		{
			vtkCylinderSource.vtkCylinderSource_CappingOff_01(base.GetCppThis());
		}

		// Token: 0x06015828 RID: 88104
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_CappingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
		/// </summary>
		// Token: 0x06015829 RID: 88105 RVA: 0x001E69AA File Offset: 0x001E4BAA
		public virtual void CappingOn()
		{
			vtkCylinderSource.vtkCylinderSource_CappingOn_02(base.GetCppThis());
		}

		// Token: 0x0601582A RID: 88106
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_CapsuleCapOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the capping should make the cylinder a capsule. This adds hemispherical caps at
		/// the ends of the cylinder.
		///
		/// \sa SetCapping()
		/// </summary>
		// Token: 0x0601582B RID: 88107 RVA: 0x001E69B9 File Offset: 0x001E4BB9
		public virtual void CapsuleCapOff()
		{
			vtkCylinderSource.vtkCylinderSource_CapsuleCapOff_03(base.GetCppThis());
		}

		// Token: 0x0601582C RID: 88108
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_CapsuleCapOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the capping should make the cylinder a capsule. This adds hemispherical caps at
		/// the ends of the cylinder.
		///
		/// \sa SetCapping()
		/// </summary>
		// Token: 0x0601582D RID: 88109 RVA: 0x001E69C8 File Offset: 0x001E4BC8
		public virtual void CapsuleCapOn()
		{
			vtkCylinderSource.vtkCylinderSource_CapsuleCapOn_04(base.GetCppThis());
		}

		// Token: 0x0601582E RID: 88110
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_GetCapping_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
		/// </summary>
		// Token: 0x0601582F RID: 88111 RVA: 0x001E69D8 File Offset: 0x001E4BD8
		public virtual int GetCapping()
		{
			return vtkCylinderSource.vtkCylinderSource_GetCapping_05(base.GetCppThis());
		}

		// Token: 0x06015830 RID: 88112
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_GetCapsuleCap_06(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the capping should make the cylinder a capsule. This adds hemispherical caps at
		/// the ends of the cylinder.
		///
		/// \sa SetCapping()
		/// </summary>
		// Token: 0x06015831 RID: 88113 RVA: 0x001E69F8 File Offset: 0x001E4BF8
		public virtual int GetCapsuleCap()
		{
			return vtkCylinderSource.vtkCylinderSource_GetCapsuleCap_06(base.GetCppThis());
		}

		// Token: 0x06015832 RID: 88114
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinderSource_GetCenter_07(HandleRef pThis);

		/// <summary>
		/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06015833 RID: 88115 RVA: 0x001E6A18 File Offset: 0x001E4C18
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_GetCenter_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015834 RID: 88116
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_GetCenter_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06015835 RID: 88117 RVA: 0x001E6A60 File Offset: 0x001E4C60
		public virtual void GetCenter(IntPtr data)
		{
			vtkCylinderSource.vtkCylinderSource_GetCenter_08(base.GetCppThis(), data);
		}

		// Token: 0x06015836 RID: 88118
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinderSource_GetHeight_09(HandleRef pThis);

		/// <summary>
		/// Set the height of the cylinder. Initial value is 1.
		/// </summary>
		// Token: 0x06015837 RID: 88119 RVA: 0x001E6A70 File Offset: 0x001E4C70
		public virtual double GetHeight()
		{
			return vtkCylinderSource.vtkCylinderSource_GetHeight_09(base.GetCppThis());
		}

		// Token: 0x06015838 RID: 88120
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinderSource_GetHeightMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the height of the cylinder. Initial value is 1.
		/// </summary>
		// Token: 0x06015839 RID: 88121 RVA: 0x001E6A90 File Offset: 0x001E4C90
		public virtual double GetHeightMaxValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetHeightMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0601583A RID: 88122
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinderSource_GetHeightMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the height of the cylinder. Initial value is 1.
		/// </summary>
		// Token: 0x0601583B RID: 88123 RVA: 0x001E6AB0 File Offset: 0x001E4CB0
		public virtual double GetHeightMinValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetHeightMinValue_11(base.GetCppThis());
		}

		// Token: 0x0601583C RID: 88124
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_GetLatLongTessellation_12(HandleRef pThis);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x0601583D RID: 88125 RVA: 0x001E6AD0 File Offset: 0x001E4CD0
		public virtual int GetLatLongTessellation()
		{
			return vtkCylinderSource.vtkCylinderSource_GetLatLongTessellation_12(base.GetCppThis());
		}

		// Token: 0x0601583E RID: 88126
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCylinderSource_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601583F RID: 88127 RVA: 0x001E6AF0 File Offset: 0x001E4CF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCylinderSource.vtkCylinderSource_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06015840 RID: 88128
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCylinderSource_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015841 RID: 88129 RVA: 0x001E6B10 File Offset: 0x001E4D10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCylinderSource.vtkCylinderSource_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06015842 RID: 88130
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_GetOutputPointsPrecision_15(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015843 RID: 88131 RVA: 0x001E6B2C File Offset: 0x001E4D2C
		public virtual int GetOutputPointsPrecision()
		{
			return vtkCylinderSource.vtkCylinderSource_GetOutputPointsPrecision_15(base.GetCppThis());
		}

		// Token: 0x06015844 RID: 88132
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinderSource_GetRadius_16(HandleRef pThis);

		/// <summary>
		/// Set the radius of the cylinder. Initial value is 0.5
		/// </summary>
		// Token: 0x06015845 RID: 88133 RVA: 0x001E6B4C File Offset: 0x001E4D4C
		public virtual double GetRadius()
		{
			return vtkCylinderSource.vtkCylinderSource_GetRadius_16(base.GetCppThis());
		}

		// Token: 0x06015846 RID: 88134
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinderSource_GetRadiusMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set the radius of the cylinder. Initial value is 0.5
		/// </summary>
		// Token: 0x06015847 RID: 88135 RVA: 0x001E6B6C File Offset: 0x001E4D6C
		public virtual double GetRadiusMaxValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetRadiusMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06015848 RID: 88136
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinderSource_GetRadiusMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set the radius of the cylinder. Initial value is 0.5
		/// </summary>
		// Token: 0x06015849 RID: 88137 RVA: 0x001E6B8C File Offset: 0x001E4D8C
		public virtual double GetRadiusMinValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetRadiusMinValue_18(base.GetCppThis());
		}

		// Token: 0x0601584A RID: 88138
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_GetResolution_19(HandleRef pThis);

		/// <summary>
		/// Set the number of facets used to define cylinder. Initial value is 6.
		/// </summary>
		// Token: 0x0601584B RID: 88139 RVA: 0x001E6BAC File Offset: 0x001E4DAC
		public virtual int GetResolution()
		{
			return vtkCylinderSource.vtkCylinderSource_GetResolution_19(base.GetCppThis());
		}

		// Token: 0x0601584C RID: 88140
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_GetResolutionMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set the number of facets used to define cylinder. Initial value is 6.
		/// </summary>
		// Token: 0x0601584D RID: 88141 RVA: 0x001E6BCC File Offset: 0x001E4DCC
		public virtual int GetResolutionMaxValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetResolutionMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0601584E RID: 88142
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_GetResolutionMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set the number of facets used to define cylinder. Initial value is 6.
		/// </summary>
		// Token: 0x0601584F RID: 88143 RVA: 0x001E6BEC File Offset: 0x001E4DEC
		public virtual int GetResolutionMinValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetResolutionMinValue_21(base.GetCppThis());
		}

		// Token: 0x06015850 RID: 88144
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015851 RID: 88145 RVA: 0x001E6C0C File Offset: 0x001E4E0C
		public override int IsA(string type)
		{
			return vtkCylinderSource.vtkCylinderSource_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06015852 RID: 88146
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinderSource_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015853 RID: 88147 RVA: 0x001E6C2C File Offset: 0x001E4E2C
		public new static int IsTypeOf(string type)
		{
			return vtkCylinderSource.vtkCylinderSource_IsTypeOf_23(type);
		}

		// Token: 0x06015854 RID: 88148
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_LatLongTessellationOff_24(HandleRef pThis);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x06015855 RID: 88149 RVA: 0x001E6C46 File Offset: 0x001E4E46
		public virtual void LatLongTessellationOff()
		{
			vtkCylinderSource.vtkCylinderSource_LatLongTessellationOff_24(base.GetCppThis());
		}

		// Token: 0x06015856 RID: 88150
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_LatLongTessellationOn_25(HandleRef pThis);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x06015857 RID: 88151 RVA: 0x001E6C55 File Offset: 0x001E4E55
		public virtual void LatLongTessellationOn()
		{
			vtkCylinderSource.vtkCylinderSource_LatLongTessellationOn_25(base.GetCppThis());
		}

		// Token: 0x06015858 RID: 88152
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinderSource_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015859 RID: 88153 RVA: 0x001E6C64 File Offset: 0x001E4E64
		public new vtkCylinderSource NewInstance()
		{
			vtkCylinderSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601585A RID: 88154
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinderSource_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601585B RID: 88155 RVA: 0x001E6CC0 File Offset: 0x001E4EC0
		public new static vtkCylinderSource SafeDownCast(vtkObjectBase o)
		{
			vtkCylinderSource vtkCylinderSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCylinderSource = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCylinderSource.Register(null);
				}
			}
			return vtkCylinderSource;
		}

		// Token: 0x0601585C RID: 88156
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetCapping_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether to cap cylinder with polygons. Initial value is true.
		/// </summary>
		// Token: 0x0601585D RID: 88157 RVA: 0x001E6D3F File Offset: 0x001E4F3F
		public virtual void SetCapping(int _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetCapping_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601585E RID: 88158
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetCapsuleCap_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the capping should make the cylinder a capsule. This adds hemispherical caps at
		/// the ends of the cylinder.
		///
		/// \sa SetCapping()
		/// </summary>
		// Token: 0x0601585F RID: 88159 RVA: 0x001E6D4F File Offset: 0x001E4F4F
		public virtual void SetCapsuleCap(int _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetCapsuleCap_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06015860 RID: 88160
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetCenter_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06015861 RID: 88161 RVA: 0x001E6D5F File Offset: 0x001E4F5F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkCylinderSource.vtkCylinderSource_SetCenter_31(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015862 RID: 88162
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetCenter_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get cylinder center. Initial value is (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06015863 RID: 88163 RVA: 0x001E6D71 File Offset: 0x001E4F71
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetCenter_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06015864 RID: 88164
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetHeight_33(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the height of the cylinder. Initial value is 1.
		/// </summary>
		// Token: 0x06015865 RID: 88165 RVA: 0x001E6D81 File Offset: 0x001E4F81
		public virtual void SetHeight(double _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetHeight_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06015866 RID: 88166
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetLatLongTessellation_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Cause the spheres to be tessellated with edges along the latitude and longitude lines. If off,
		/// triangles are generated at non-polar regions, which results in edges that are not parallel to
		/// latitude and longitude lines. If on, quadrilaterals are generated everywhere except at the
		/// poles. This can be useful for generating wireframe spheres with natural latitude and longitude
		/// lines.
		/// </summary>
		// Token: 0x06015867 RID: 88167 RVA: 0x001E6D91 File Offset: 0x001E4F91
		public virtual void SetLatLongTessellation(int _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetLatLongTessellation_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06015868 RID: 88168
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetOutputPointsPrecision_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015869 RID: 88169 RVA: 0x001E6DA1 File Offset: 0x001E4FA1
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetOutputPointsPrecision_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0601586A RID: 88170
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetRadius_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the radius of the cylinder. Initial value is 0.5
		/// </summary>
		// Token: 0x0601586B RID: 88171 RVA: 0x001E6DB1 File Offset: 0x001E4FB1
		public virtual void SetRadius(double _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetRadius_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601586C RID: 88172
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinderSource_SetResolution_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of facets used to define cylinder. Initial value is 6.
		/// </summary>
		// Token: 0x0601586D RID: 88173 RVA: 0x001E6DC1 File Offset: 0x001E4FC1
		public virtual void SetResolution(int _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetResolution_37(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001891 RID: 6289
		public new const string MRFullTypeName = "Kitware.VTK.vtkCylinderSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001892 RID: 6290
		public new static readonly string MRClassNameKey = "class vtkCylinderSource";
	}
}
