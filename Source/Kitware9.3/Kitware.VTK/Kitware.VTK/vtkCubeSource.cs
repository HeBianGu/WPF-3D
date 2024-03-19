using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCubeSource
	/// </summary>
	/// <remarks>
	///    create a polygonal representation of a cube
	///
	/// vtkCubeSource creates a cube centered at origin. The cube is represented
	/// with four-sided polygons. It is possible to specify the length, width,
	/// and height of the cube independently.
	/// </remarks>
	// Token: 0x02000823 RID: 2083
	public class vtkCubeSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060157E4 RID: 88036 RVA: 0x001E645F File Offset: 0x001E465F
		static vtkCubeSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCubeSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060157E5 RID: 88037 RVA: 0x001E6487 File Offset: 0x001E4687
		public vtkCubeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060157E6 RID: 88038
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157E7 RID: 88039 RVA: 0x001E6498 File Offset: 0x001E4698
		public new static vtkCubeSource New()
		{
			vtkCubeSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157E8 RID: 88040 RVA: 0x001E64EC File Offset: 0x001E46EC
		public vtkCubeSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCubeSource.vtkCubeSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060157E9 RID: 88041 RVA: 0x001E6530 File Offset: 0x001E4730
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060157EA RID: 88042
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_GetBounds_01(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Convenience methods allows creation of cube by specifying bounding box.
		/// </summary>
		// Token: 0x060157EB RID: 88043 RVA: 0x001E653B File Offset: 0x001E473B
		public void GetBounds(IntPtr bounds)
		{
			vtkCubeSource.vtkCubeSource_GetBounds_01(base.GetCppThis(), bounds);
		}

		// Token: 0x060157EC RID: 88044
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeSource_GetCenter_02(HandleRef pThis);

		/// <summary>
		/// Set the center of the cube.
		/// </summary>
		// Token: 0x060157ED RID: 88045 RVA: 0x001E654C File Offset: 0x001E474C
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_GetCenter_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060157EE RID: 88046
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_GetCenter_03(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the cube.
		/// </summary>
		// Token: 0x060157EF RID: 88047 RVA: 0x001E6594 File Offset: 0x001E4794
		public virtual void GetCenter(IntPtr data)
		{
			vtkCubeSource.vtkCubeSource_GetCenter_03(base.GetCppThis(), data);
		}

		// Token: 0x060157F0 RID: 88048
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubeSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157F1 RID: 88049 RVA: 0x001E65A4 File Offset: 0x001E47A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCubeSource.vtkCubeSource_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060157F2 RID: 88050
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubeSource_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060157F3 RID: 88051 RVA: 0x001E65C4 File Offset: 0x001E47C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCubeSource.vtkCubeSource_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060157F4 RID: 88052
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeSource_GetOutputPointsPrecision_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060157F5 RID: 88053 RVA: 0x001E65E0 File Offset: 0x001E47E0
		public virtual int GetOutputPointsPrecision()
		{
			return vtkCubeSource.vtkCubeSource_GetOutputPointsPrecision_06(base.GetCppThis());
		}

		// Token: 0x060157F6 RID: 88054
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetXLength_07(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the x-direction.
		/// </summary>
		// Token: 0x060157F7 RID: 88055 RVA: 0x001E6600 File Offset: 0x001E4800
		public virtual double GetXLength()
		{
			return vtkCubeSource.vtkCubeSource_GetXLength_07(base.GetCppThis());
		}

		// Token: 0x060157F8 RID: 88056
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetXLengthMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the x-direction.
		/// </summary>
		// Token: 0x060157F9 RID: 88057 RVA: 0x001E6620 File Offset: 0x001E4820
		public virtual double GetXLengthMaxValue()
		{
			return vtkCubeSource.vtkCubeSource_GetXLengthMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060157FA RID: 88058
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetXLengthMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the x-direction.
		/// </summary>
		// Token: 0x060157FB RID: 88059 RVA: 0x001E6640 File Offset: 0x001E4840
		public virtual double GetXLengthMinValue()
		{
			return vtkCubeSource.vtkCubeSource_GetXLengthMinValue_09(base.GetCppThis());
		}

		// Token: 0x060157FC RID: 88060
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetYLength_10(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the y-direction.
		/// </summary>
		// Token: 0x060157FD RID: 88061 RVA: 0x001E6660 File Offset: 0x001E4860
		public virtual double GetYLength()
		{
			return vtkCubeSource.vtkCubeSource_GetYLength_10(base.GetCppThis());
		}

		// Token: 0x060157FE RID: 88062
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetYLengthMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the y-direction.
		/// </summary>
		// Token: 0x060157FF RID: 88063 RVA: 0x001E6680 File Offset: 0x001E4880
		public virtual double GetYLengthMaxValue()
		{
			return vtkCubeSource.vtkCubeSource_GetYLengthMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06015800 RID: 88064
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetYLengthMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the y-direction.
		/// </summary>
		// Token: 0x06015801 RID: 88065 RVA: 0x001E66A0 File Offset: 0x001E48A0
		public virtual double GetYLengthMinValue()
		{
			return vtkCubeSource.vtkCubeSource_GetYLengthMinValue_12(base.GetCppThis());
		}

		// Token: 0x06015802 RID: 88066
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetZLength_13(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the z-direction.
		/// </summary>
		// Token: 0x06015803 RID: 88067 RVA: 0x001E66C0 File Offset: 0x001E48C0
		public virtual double GetZLength()
		{
			return vtkCubeSource.vtkCubeSource_GetZLength_13(base.GetCppThis());
		}

		// Token: 0x06015804 RID: 88068
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetZLengthMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the z-direction.
		/// </summary>
		// Token: 0x06015805 RID: 88069 RVA: 0x001E66E0 File Offset: 0x001E48E0
		public virtual double GetZLengthMaxValue()
		{
			return vtkCubeSource.vtkCubeSource_GetZLengthMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06015806 RID: 88070
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeSource_GetZLengthMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the length of the cube in the z-direction.
		/// </summary>
		// Token: 0x06015807 RID: 88071 RVA: 0x001E6700 File Offset: 0x001E4900
		public virtual double GetZLengthMinValue()
		{
			return vtkCubeSource.vtkCubeSource_GetZLengthMinValue_15(base.GetCppThis());
		}

		// Token: 0x06015808 RID: 88072
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeSource_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015809 RID: 88073 RVA: 0x001E6720 File Offset: 0x001E4920
		public override int IsA(string type)
		{
			return vtkCubeSource.vtkCubeSource_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601580A RID: 88074
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeSource_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601580B RID: 88075 RVA: 0x001E6740 File Offset: 0x001E4940
		public new static int IsTypeOf(string type)
		{
			return vtkCubeSource.vtkCubeSource_IsTypeOf_17(type);
		}

		// Token: 0x0601580C RID: 88076
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeSource_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601580D RID: 88077 RVA: 0x001E675C File Offset: 0x001E495C
		public new vtkCubeSource NewInstance()
		{
			vtkCubeSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601580E RID: 88078
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeSource_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601580F RID: 88079 RVA: 0x001E67B8 File Offset: 0x001E49B8
		public new static vtkCubeSource SafeDownCast(vtkObjectBase o)
		{
			vtkCubeSource vtkCubeSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCubeSource = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCubeSource.Register(null);
				}
			}
			return vtkCubeSource;
		}

		// Token: 0x06015810 RID: 88080
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetBounds_21(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Convenience methods allows creation of cube by specifying bounding box.
		/// </summary>
		// Token: 0x06015811 RID: 88081 RVA: 0x001E6837 File Offset: 0x001E4A37
		public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkCubeSource.vtkCubeSource_SetBounds_21(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x06015812 RID: 88082
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetBounds_22(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Convenience methods allows creation of cube by specifying bounding box.
		/// </summary>
		// Token: 0x06015813 RID: 88083 RVA: 0x001E684F File Offset: 0x001E4A4F
		public void SetBounds(IntPtr bounds)
		{
			vtkCubeSource.vtkCubeSource_SetBounds_22(base.GetCppThis(), bounds);
		}

		// Token: 0x06015814 RID: 88084
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetCenter_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the cube.
		/// </summary>
		// Token: 0x06015815 RID: 88085 RVA: 0x001E685F File Offset: 0x001E4A5F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkCubeSource.vtkCubeSource_SetCenter_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06015816 RID: 88086
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetCenter_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the cube.
		/// </summary>
		// Token: 0x06015817 RID: 88087 RVA: 0x001E6871 File Offset: 0x001E4A71
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkCubeSource.vtkCubeSource_SetCenter_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06015818 RID: 88088
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetOutputPointsPrecision_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015819 RID: 88089 RVA: 0x001E6881 File Offset: 0x001E4A81
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkCubeSource.vtkCubeSource_SetOutputPointsPrecision_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601581A RID: 88090
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetXLength_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the length of the cube in the x-direction.
		/// </summary>
		// Token: 0x0601581B RID: 88091 RVA: 0x001E6891 File Offset: 0x001E4A91
		public virtual void SetXLength(double _arg)
		{
			vtkCubeSource.vtkCubeSource_SetXLength_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601581C RID: 88092
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetYLength_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the length of the cube in the y-direction.
		/// </summary>
		// Token: 0x0601581D RID: 88093 RVA: 0x001E68A1 File Offset: 0x001E4AA1
		public virtual void SetYLength(double _arg)
		{
			vtkCubeSource.vtkCubeSource_SetYLength_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601581E RID: 88094
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeSource_SetZLength_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the length of the cube in the z-direction.
		/// </summary>
		// Token: 0x0601581F RID: 88095 RVA: 0x001E68B1 File Offset: 0x001E4AB1
		public virtual void SetZLength(double _arg)
		{
			vtkCubeSource.vtkCubeSource_SetZLength_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400188F RID: 6287
		public new const string MRFullTypeName = "Kitware.VTK.vtkCubeSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001890 RID: 6288
		public new static readonly string MRClassNameKey = "class vtkCubeSource";
	}
}
