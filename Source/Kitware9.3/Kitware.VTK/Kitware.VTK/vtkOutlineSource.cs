using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutlineSource
	/// </summary>
	/// <remarks>
	///    create wireframe outline around bounding box
	///
	/// vtkOutlineSource creates a wireframe outline around a
	/// user-specified bounding box.  The outline may be created aligned
	/// with the {x,y,z} axis - in which case it is defined by the 6 bounds
	/// {xmin,xmax,ymin,ymax,zmin,zmax} via SetBounds(). Alternatively, the
	/// box may be arbitrarily aligned, in which case it should be set via
	/// the SetCorners() member.
	/// </remarks>
	// Token: 0x0200082F RID: 2095
	public class vtkOutlineSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015ABC RID: 88764 RVA: 0x001E983B File Offset: 0x001E7A3B
		static vtkOutlineSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015ABD RID: 88765 RVA: 0x001E9863 File Offset: 0x001E7A63
		public vtkOutlineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015ABE RID: 88766
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015ABF RID: 88767 RVA: 0x001E9874 File Offset: 0x001E7A74
		public new static vtkOutlineSource New()
		{
			vtkOutlineSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015AC0 RID: 88768 RVA: 0x001E98C8 File Offset: 0x001E7AC8
		public vtkOutlineSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutlineSource.vtkOutlineSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015AC1 RID: 88769 RVA: 0x001E990C File Offset: 0x001E7B0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015AC2 RID: 88770
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_GenerateFacesOff_01(HandleRef pThis);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x06015AC3 RID: 88771 RVA: 0x001E9917 File Offset: 0x001E7B17
		public virtual void GenerateFacesOff()
		{
			vtkOutlineSource.vtkOutlineSource_GenerateFacesOff_01(base.GetCppThis());
		}

		// Token: 0x06015AC4 RID: 88772
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_GenerateFacesOn_02(HandleRef pThis);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x06015AC5 RID: 88773 RVA: 0x001E9926 File Offset: 0x001E7B26
		public virtual void GenerateFacesOn()
		{
			vtkOutlineSource.vtkOutlineSource_GenerateFacesOn_02(base.GetCppThis());
		}

		// Token: 0x06015AC6 RID: 88774
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineSource_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Specify the bounds of the box to be used in Axis Aligned mode.
		/// </summary>
		// Token: 0x06015AC7 RID: 88775 RVA: 0x001E9938 File Offset: 0x001E7B38
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015AC8 RID: 88776
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_GetBounds_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the bounds of the box to be used in Axis Aligned mode.
		/// </summary>
		// Token: 0x06015AC9 RID: 88777 RVA: 0x001E9980 File Offset: 0x001E7B80
		public virtual void GetBounds(IntPtr data)
		{
			vtkOutlineSource.vtkOutlineSource_GetBounds_04(base.GetCppThis(), data);
		}

		// Token: 0x06015ACA RID: 88778
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineSource_GetBoxType_05(HandleRef pThis);

		/// <summary>
		/// Set box type to AxisAligned (default) or Oriented.
		/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
		/// with Oriented mode.
		/// </summary>
		// Token: 0x06015ACB RID: 88779 RVA: 0x001E9990 File Offset: 0x001E7B90
		public virtual int GetBoxType()
		{
			return vtkOutlineSource.vtkOutlineSource_GetBoxType_05(base.GetCppThis());
		}

		// Token: 0x06015ACC RID: 88780
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineSource_GetCorners_06(HandleRef pThis);

		/// <summary>
		/// Specify the corners of the outline when in Oriented mode, the
		/// values are supplied as 8*3 double values The correct corner
		/// ordering is using {x,y,z} convention for the unit cube as follows:
		/// {0,0,0},{1,0,0},{0,1,0},{1,1,0},{0,0,1},{1,0,1},{0,1,1},{1,1,1}.
		/// </summary>
		// Token: 0x06015ACD RID: 88781 RVA: 0x001E99B0 File Offset: 0x001E7BB0
		public virtual double[] GetCorners()
		{
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_GetCorners_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015ACE RID: 88782
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_GetCorners_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the corners of the outline when in Oriented mode, the
		/// values are supplied as 8*3 double values The correct corner
		/// ordering is using {x,y,z} convention for the unit cube as follows:
		/// {0,0,0},{1,0,0},{0,1,0},{1,1,0},{0,0,1},{1,0,1},{0,1,1},{1,1,1}.
		/// </summary>
		// Token: 0x06015ACF RID: 88783 RVA: 0x001E99F8 File Offset: 0x001E7BF8
		public virtual void GetCorners(IntPtr data)
		{
			vtkOutlineSource.vtkOutlineSource_GetCorners_07(base.GetCppThis(), data);
		}

		// Token: 0x06015AD0 RID: 88784
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineSource_GetGenerateFaces_08(HandleRef pThis);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x06015AD1 RID: 88785 RVA: 0x001E9A08 File Offset: 0x001E7C08
		public virtual int GetGenerateFaces()
		{
			return vtkOutlineSource.vtkOutlineSource_GetGenerateFaces_08(base.GetCppThis());
		}

		// Token: 0x06015AD2 RID: 88786
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineSource_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015AD3 RID: 88787 RVA: 0x001E9A28 File Offset: 0x001E7C28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutlineSource.vtkOutlineSource_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06015AD4 RID: 88788
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineSource_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015AD5 RID: 88789 RVA: 0x001E9A48 File Offset: 0x001E7C48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutlineSource.vtkOutlineSource_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06015AD6 RID: 88790
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineSource_GetOutputPointsPrecision_11(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015AD7 RID: 88791 RVA: 0x001E9A64 File Offset: 0x001E7C64
		public virtual int GetOutputPointsPrecision()
		{
			return vtkOutlineSource.vtkOutlineSource_GetOutputPointsPrecision_11(base.GetCppThis());
		}

		// Token: 0x06015AD8 RID: 88792
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineSource_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015AD9 RID: 88793 RVA: 0x001E9A84 File Offset: 0x001E7C84
		public override int IsA(string type)
		{
			return vtkOutlineSource.vtkOutlineSource_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06015ADA RID: 88794
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineSource_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015ADB RID: 88795 RVA: 0x001E9AA4 File Offset: 0x001E7CA4
		public new static int IsTypeOf(string type)
		{
			return vtkOutlineSource.vtkOutlineSource_IsTypeOf_13(type);
		}

		// Token: 0x06015ADC RID: 88796
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015ADD RID: 88797 RVA: 0x001E9AC0 File Offset: 0x001E7CC0
		public new vtkOutlineSource NewInstance()
		{
			vtkOutlineSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015ADE RID: 88798
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x06015ADF RID: 88799 RVA: 0x001E9B1C File Offset: 0x001E7D1C
		public new static vtkOutlineSource SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineSource vtkOutlineSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineSource = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineSource.Register(null);
				}
			}
			return vtkOutlineSource;
		}

		// Token: 0x06015AE0 RID: 88800
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Specify the bounds of the box to be used in Axis Aligned mode.
		/// </summary>
		// Token: 0x06015AE1 RID: 88801 RVA: 0x001E9B9B File Offset: 0x001E7D9B
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkOutlineSource.vtkOutlineSource_SetBounds_17(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06015AE2 RID: 88802
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetBounds_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the bounds of the box to be used in Axis Aligned mode.
		/// </summary>
		// Token: 0x06015AE3 RID: 88803 RVA: 0x001E9BB3 File Offset: 0x001E7DB3
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkOutlineSource.vtkOutlineSource_SetBounds_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06015AE4 RID: 88804
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetBoxType_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set box type to AxisAligned (default) or Oriented.
		/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
		/// with Oriented mode.
		/// </summary>
		// Token: 0x06015AE5 RID: 88805 RVA: 0x001E9BC3 File Offset: 0x001E7DC3
		public virtual void SetBoxType(int _arg)
		{
			vtkOutlineSource.vtkOutlineSource_SetBoxType_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06015AE6 RID: 88806
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetBoxTypeToAxisAligned_20(HandleRef pThis);

		/// <summary>
		/// Set box type to AxisAligned (default) or Oriented.
		/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
		/// with Oriented mode.
		/// </summary>
		// Token: 0x06015AE7 RID: 88807 RVA: 0x001E9BD3 File Offset: 0x001E7DD3
		public void SetBoxTypeToAxisAligned()
		{
			vtkOutlineSource.vtkOutlineSource_SetBoxTypeToAxisAligned_20(base.GetCppThis());
		}

		// Token: 0x06015AE8 RID: 88808
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetBoxTypeToOriented_21(HandleRef pThis);

		/// <summary>
		/// Set box type to AxisAligned (default) or Oriented.
		/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
		/// with Oriented mode.
		/// </summary>
		// Token: 0x06015AE9 RID: 88809 RVA: 0x001E9BE2 File Offset: 0x001E7DE2
		public void SetBoxTypeToOriented()
		{
			vtkOutlineSource.vtkOutlineSource_SetBoxTypeToOriented_21(base.GetCppThis());
		}

		// Token: 0x06015AEA RID: 88810
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetCorners_22(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the corners of the outline when in Oriented mode, the
		/// values are supplied as 8*3 double values The correct corner
		/// ordering is using {x,y,z} convention for the unit cube as follows:
		/// {0,0,0},{1,0,0},{0,1,0},{1,1,0},{0,0,1},{1,0,1},{0,1,1},{1,1,1}.
		/// </summary>
		// Token: 0x06015AEB RID: 88811 RVA: 0x001E9BF1 File Offset: 0x001E7DF1
		public virtual void SetCorners(IntPtr data)
		{
			vtkOutlineSource.vtkOutlineSource_SetCorners_22(base.GetCppThis(), data);
		}

		// Token: 0x06015AEC RID: 88812
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetGenerateFaces_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x06015AED RID: 88813 RVA: 0x001E9C01 File Offset: 0x001E7E01
		public virtual void SetGenerateFaces(int _arg)
		{
			vtkOutlineSource.vtkOutlineSource_SetGenerateFaces_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06015AEE RID: 88814
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineSource_SetOutputPointsPrecision_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015AEF RID: 88815 RVA: 0x001E9C11 File Offset: 0x001E7E11
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkOutlineSource.vtkOutlineSource_SetOutputPointsPrecision_24(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A8 RID: 6312
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A9 RID: 6313
		public new static readonly string MRClassNameKey = "class vtkOutlineSource";
	}
}
