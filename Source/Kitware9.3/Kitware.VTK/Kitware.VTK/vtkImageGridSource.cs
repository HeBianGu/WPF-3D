using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageGridSource
	/// </summary>
	/// <remarks>
	///    Create an image of a grid.
	///
	/// vtkImageGridSource produces an image of a grid.  The
	/// default output type is double.
	/// </remarks>
	// Token: 0x02000757 RID: 1879
	public class vtkImageGridSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060137E7 RID: 79847 RVA: 0x001B8FE9 File Offset: 0x001B71E9
		static vtkImageGridSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGridSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGridSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060137E8 RID: 79848 RVA: 0x001B9011 File Offset: 0x001B7211
		public vtkImageGridSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060137E9 RID: 79849
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137EA RID: 79850 RVA: 0x001B9020 File Offset: 0x001B7220
		public new static vtkImageGridSource New()
		{
			vtkImageGridSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060137EB RID: 79851 RVA: 0x001B9074 File Offset: 0x001B7274
		public vtkImageGridSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageGridSource.vtkImageGridSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060137EC RID: 79852 RVA: 0x001B90B8 File Offset: 0x001B72B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060137ED RID: 79853
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_GetDataExtent_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the extent of the whole output image,
		/// Default: (0,255,0,255,0,0)
		/// </summary>
		// Token: 0x060137EE RID: 79854 RVA: 0x001B90C4 File Offset: 0x001B72C4
		public virtual int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetDataExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060137EF RID: 79855
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetDataExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/Get the extent of the whole output image,
		/// Default: (0,255,0,255,0,0)
		/// </summary>
		// Token: 0x060137F0 RID: 79856 RVA: 0x001B910C File Offset: 0x001B730C
		public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataExtent_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060137F1 RID: 79857
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetDataExtent_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent of the whole output image,
		/// Default: (0,255,0,255,0,0)
		/// </summary>
		// Token: 0x060137F2 RID: 79858 RVA: 0x001B9124 File Offset: 0x001B7324
		public virtual void GetDataExtent(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataExtent_03(base.GetCppThis(), _arg);
		}

		// Token: 0x060137F3 RID: 79859
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_GetDataOrigin_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the data.
		/// </summary>
		// Token: 0x060137F4 RID: 79860 RVA: 0x001B9134 File Offset: 0x001B7334
		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetDataOrigin_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060137F5 RID: 79861
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetDataOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the origin of the data.
		/// </summary>
		// Token: 0x060137F6 RID: 79862 RVA: 0x001B917C File Offset: 0x001B737C
		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataOrigin_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060137F7 RID: 79863
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetDataOrigin_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the data.
		/// </summary>
		// Token: 0x060137F8 RID: 79864 RVA: 0x001B918E File Offset: 0x001B738E
		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataOrigin_06(base.GetCppThis(), _arg);
		}

		// Token: 0x060137F9 RID: 79865
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGridSource_GetDataScalarType_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x060137FA RID: 79866 RVA: 0x001B91A0 File Offset: 0x001B73A0
		public virtual int GetDataScalarType()
		{
			return vtkImageGridSource.vtkImageGridSource_GetDataScalarType_07(base.GetCppThis());
		}

		// Token: 0x060137FB RID: 79867
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_GetDataScalarTypeAsString_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x060137FC RID: 79868 RVA: 0x001B91C0 File Offset: 0x001B73C0
		public string GetDataScalarTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageGridSource.vtkImageGridSource_GetDataScalarTypeAsString_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060137FD RID: 79869
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_GetDataSpacing_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// </summary>
		// Token: 0x060137FE RID: 79870 RVA: 0x001B91FC File Offset: 0x001B73FC
		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetDataSpacing_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060137FF RID: 79871
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetDataSpacing_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// </summary>
		// Token: 0x06013800 RID: 79872 RVA: 0x001B9244 File Offset: 0x001B7444
		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataSpacing_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06013801 RID: 79873
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetDataSpacing_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// </summary>
		// Token: 0x06013802 RID: 79874 RVA: 0x001B9256 File Offset: 0x001B7456
		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetDataSpacing_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06013803 RID: 79875
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageGridSource_GetFillValue_12(HandleRef pThis);

		/// <summary>
		/// Set the grey level of the fill. Default 0.0.
		/// </summary>
		// Token: 0x06013804 RID: 79876 RVA: 0x001B9268 File Offset: 0x001B7468
		public virtual double GetFillValue()
		{
			return vtkImageGridSource.vtkImageGridSource_GetFillValue_12(base.GetCppThis());
		}

		// Token: 0x06013805 RID: 79877
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_GetGridOrigin_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
		/// </summary>
		// Token: 0x06013806 RID: 79878 RVA: 0x001B9288 File Offset: 0x001B7488
		public virtual int[] GetGridOrigin()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetGridOrigin_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013807 RID: 79879
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetGridOrigin_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
		/// </summary>
		// Token: 0x06013808 RID: 79880 RVA: 0x001B92D0 File Offset: 0x001B74D0
		public virtual void GetGridOrigin(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridOrigin_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06013809 RID: 79881
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetGridOrigin_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
		/// </summary>
		// Token: 0x0601380A RID: 79882 RVA: 0x001B92E2 File Offset: 0x001B74E2
		public virtual void GetGridOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridOrigin_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601380B RID: 79883
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_GetGridSpacing_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
		/// A value of zero means no grid.
		/// </summary>
		// Token: 0x0601380C RID: 79884 RVA: 0x001B92F4 File Offset: 0x001B74F4
		public virtual int[] GetGridSpacing()
		{
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_GetGridSpacing_16(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601380D RID: 79885
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetGridSpacing_17(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
		/// A value of zero means no grid.
		/// </summary>
		// Token: 0x0601380E RID: 79886 RVA: 0x001B933C File Offset: 0x001B753C
		public virtual void GetGridSpacing(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridSpacing_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601380F RID: 79887
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_GetGridSpacing_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
		/// A value of zero means no grid.
		/// </summary>
		// Token: 0x06013810 RID: 79888 RVA: 0x001B934E File Offset: 0x001B754E
		public virtual void GetGridSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_GetGridSpacing_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06013811 RID: 79889
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageGridSource_GetLineValue_19(HandleRef pThis);

		/// <summary>
		/// Set the grey level of the lines. Default 1.0.
		/// </summary>
		// Token: 0x06013812 RID: 79890 RVA: 0x001B9360 File Offset: 0x001B7560
		public virtual double GetLineValue()
		{
			return vtkImageGridSource.vtkImageGridSource_GetLineValue_19(base.GetCppThis());
		}

		// Token: 0x06013813 RID: 79891
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGridSource_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013814 RID: 79892 RVA: 0x001B9380 File Offset: 0x001B7580
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageGridSource.vtkImageGridSource_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06013815 RID: 79893
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGridSource_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013816 RID: 79894 RVA: 0x001B93A0 File Offset: 0x001B75A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageGridSource.vtkImageGridSource_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06013817 RID: 79895
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGridSource_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013818 RID: 79896 RVA: 0x001B93BC File Offset: 0x001B75BC
		public override int IsA(string type)
		{
			return vtkImageGridSource.vtkImageGridSource_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06013819 RID: 79897
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGridSource_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601381A RID: 79898 RVA: 0x001B93DC File Offset: 0x001B75DC
		public new static int IsTypeOf(string type)
		{
			return vtkImageGridSource.vtkImageGridSource_IsTypeOf_23(type);
		}

		// Token: 0x0601381B RID: 79899
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601381C RID: 79900 RVA: 0x001B93F8 File Offset: 0x001B75F8
		public new vtkImageGridSource NewInstance()
		{
			vtkImageGridSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601381D RID: 79901
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGridSource_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601381E RID: 79902 RVA: 0x001B9454 File Offset: 0x001B7654
		public new static vtkImageGridSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageGridSource vtkImageGridSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGridSource.vtkImageGridSource_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGridSource = (vtkImageGridSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGridSource.Register(null);
				}
			}
			return vtkImageGridSource;
		}

		// Token: 0x0601381F RID: 79903
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataExtent_27(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set/Get the extent of the whole output image,
		/// Default: (0,255,0,255,0,0)
		/// </summary>
		// Token: 0x06013820 RID: 79904 RVA: 0x001B94D3 File Offset: 0x001B76D3
		public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataExtent_27(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06013821 RID: 79905
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataExtent_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent of the whole output image,
		/// Default: (0,255,0,255,0,0)
		/// </summary>
		// Token: 0x06013822 RID: 79906 RVA: 0x001B94EB File Offset: 0x001B76EB
		public virtual void SetDataExtent(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataExtent_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06013823 RID: 79907
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataOrigin_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the origin of the data.
		/// </summary>
		// Token: 0x06013824 RID: 79908 RVA: 0x001B94FB File Offset: 0x001B76FB
		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataOrigin_29(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06013825 RID: 79909
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataOrigin_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the data.
		/// </summary>
		// Token: 0x06013826 RID: 79910 RVA: 0x001B950D File Offset: 0x001B770D
		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataOrigin_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06013827 RID: 79911
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataScalarType_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x06013828 RID: 79912 RVA: 0x001B951D File Offset: 0x001B771D
		public virtual void SetDataScalarType(int _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarType_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06013829 RID: 79913
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToDouble_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x0601382A RID: 79914 RVA: 0x001B952D File Offset: 0x001B772D
		public void SetDataScalarTypeToDouble()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToDouble_32(base.GetCppThis());
		}

		// Token: 0x0601382B RID: 79915
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToInt_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x0601382C RID: 79916 RVA: 0x001B953C File Offset: 0x001B773C
		public void SetDataScalarTypeToInt()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToInt_33(base.GetCppThis());
		}

		// Token: 0x0601382D RID: 79917
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToShort_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x0601382E RID: 79918 RVA: 0x001B954B File Offset: 0x001B774B
		public void SetDataScalarTypeToShort()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToShort_34(base.GetCppThis());
		}

		// Token: 0x0601382F RID: 79919
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToUnsignedChar_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x06013830 RID: 79920 RVA: 0x001B955A File Offset: 0x001B775A
		public void SetDataScalarTypeToUnsignedChar()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToUnsignedChar_35(base.GetCppThis());
		}

		// Token: 0x06013831 RID: 79921
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataScalarTypeToUnsignedShort_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.
		/// As a convenience, the OutputScalarType is set to the same value.
		/// </summary>
		// Token: 0x06013832 RID: 79922 RVA: 0x001B9569 File Offset: 0x001B7769
		public void SetDataScalarTypeToUnsignedShort()
		{
			vtkImageGridSource.vtkImageGridSource_SetDataScalarTypeToUnsignedShort_36(base.GetCppThis());
		}

		// Token: 0x06013833 RID: 79923
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataSpacing_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// </summary>
		// Token: 0x06013834 RID: 79924 RVA: 0x001B9578 File Offset: 0x001B7778
		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataSpacing_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06013835 RID: 79925
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetDataSpacing_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// </summary>
		// Token: 0x06013836 RID: 79926 RVA: 0x001B958A File Offset: 0x001B778A
		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetDataSpacing_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06013837 RID: 79927
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetFillValue_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the grey level of the fill. Default 0.0.
		/// </summary>
		// Token: 0x06013838 RID: 79928 RVA: 0x001B959A File Offset: 0x001B779A
		public virtual void SetFillValue(double _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetFillValue_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06013839 RID: 79929
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetGridOrigin_40(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
		/// </summary>
		// Token: 0x0601383A RID: 79930 RVA: 0x001B95AA File Offset: 0x001B77AA
		public virtual void SetGridOrigin(int _arg1, int _arg2, int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridOrigin_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601383B RID: 79931
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetGridOrigin_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the grid origin, in ijk integer values.  Default (0,0,0).
		/// </summary>
		// Token: 0x0601383C RID: 79932 RVA: 0x001B95BC File Offset: 0x001B77BC
		public virtual void SetGridOrigin(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridOrigin_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601383D RID: 79933
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetGridSpacing_42(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
		/// A value of zero means no grid.
		/// </summary>
		// Token: 0x0601383E RID: 79934 RVA: 0x001B95CC File Offset: 0x001B77CC
		public virtual void SetGridSpacing(int _arg1, int _arg2, int _arg3)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridSpacing_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601383F RID: 79935
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetGridSpacing_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the grid spacing in pixel units.  Default (10,10,0).
		/// A value of zero means no grid.
		/// </summary>
		// Token: 0x06013840 RID: 79936 RVA: 0x001B95DE File Offset: 0x001B77DE
		public virtual void SetGridSpacing(IntPtr _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetGridSpacing_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06013841 RID: 79937
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGridSource_SetLineValue_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the grey level of the lines. Default 1.0.
		/// </summary>
		// Token: 0x06013842 RID: 79938 RVA: 0x001B95EE File Offset: 0x001B77EE
		public virtual void SetLineValue(double _arg)
		{
			vtkImageGridSource.vtkImageGridSource_SetLineValue_44(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400168B RID: 5771
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGridSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400168C RID: 5772
		public new static readonly string MRClassNameKey = "class vtkImageGridSource";
	}
}
