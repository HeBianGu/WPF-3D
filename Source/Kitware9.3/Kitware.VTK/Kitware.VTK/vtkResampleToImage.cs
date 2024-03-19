using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResampleToImage
	/// </summary>
	/// <remarks>
	///    sample dataset on a uniform grid
	///
	/// vtkPResampleToImage is a filter that resamples the input dataset on
	/// a uniform grid. It internally uses vtkProbeFilter to do the probing.
	/// </remarks>
	/// <seealso>
	///
	/// vtkProbeFilter
	/// </seealso>
	// Token: 0x02000998 RID: 2456
	public class vtkResampleToImage : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060199DB RID: 104923 RVA: 0x00239F27 File Offset: 0x00238127
		static vtkResampleToImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResampleToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResampleToImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060199DC RID: 104924 RVA: 0x00239F4F File Offset: 0x0023814F
		public vtkResampleToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060199DD RID: 104925
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199DE RID: 104926 RVA: 0x00239F60 File Offset: 0x00238160
		public new static vtkResampleToImage New()
		{
			vtkResampleToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleToImage.vtkResampleToImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResampleToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199DF RID: 104927 RVA: 0x00239FB4 File Offset: 0x002381B4
		public vtkResampleToImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResampleToImage.vtkResampleToImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060199E0 RID: 104928 RVA: 0x00239FF8 File Offset: 0x002381F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060199E1 RID: 104929
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleToImage_GetMaskArrayName_01(HandleRef pThis);

		/// <summary>
		/// Get the name of the valid-points mask array.
		/// </summary>
		// Token: 0x060199E2 RID: 104930 RVA: 0x0023A004 File Offset: 0x00238204
		public string GetMaskArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkResampleToImage.vtkResampleToImage_GetMaskArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060199E3 RID: 104931
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResampleToImage_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199E4 RID: 104932 RVA: 0x0023A040 File Offset: 0x00238240
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResampleToImage.vtkResampleToImage_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060199E5 RID: 104933
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResampleToImage_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199E6 RID: 104934 RVA: 0x0023A060 File Offset: 0x00238260
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResampleToImage.vtkResampleToImage_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060199E7 RID: 104935
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleToImage_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data for this algorithm.
		/// </summary>
		// Token: 0x060199E8 RID: 104936 RVA: 0x0023A07C File Offset: 0x0023827C
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleToImage.vtkResampleToImage_GetOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x060199E9 RID: 104937
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleToImage_GetSamplingBounds_05(HandleRef pThis);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x060199EA RID: 104938 RVA: 0x0023A0EC File Offset: 0x002382EC
		public virtual double[] GetSamplingBounds()
		{
			IntPtr intPtr = vtkResampleToImage.vtkResampleToImage_GetSamplingBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060199EB RID: 104939
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_GetSamplingBounds_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x060199EC RID: 104940 RVA: 0x0023A134 File Offset: 0x00238334
		public virtual void GetSamplingBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkResampleToImage.vtkResampleToImage_GetSamplingBounds_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060199ED RID: 104941
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_GetSamplingBounds_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x060199EE RID: 104942 RVA: 0x0023A14C File Offset: 0x0023834C
		public virtual void GetSamplingBounds(IntPtr _arg)
		{
			vtkResampleToImage.vtkResampleToImage_GetSamplingBounds_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060199EF RID: 104943
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleToImage_GetSamplingDimensions_08(HandleRef pThis);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x060199F0 RID: 104944 RVA: 0x0023A15C File Offset: 0x0023835C
		public virtual int[] GetSamplingDimensions()
		{
			IntPtr intPtr = vtkResampleToImage.vtkResampleToImage_GetSamplingDimensions_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060199F1 RID: 104945
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_GetSamplingDimensions_09(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x060199F2 RID: 104946 RVA: 0x0023A1A4 File Offset: 0x002383A4
		public virtual void GetSamplingDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkResampleToImage.vtkResampleToImage_GetSamplingDimensions_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060199F3 RID: 104947
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_GetSamplingDimensions_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x060199F4 RID: 104948 RVA: 0x0023A1B6 File Offset: 0x002383B6
		public virtual void GetSamplingDimensions(IntPtr _arg)
		{
			vtkResampleToImage.vtkResampleToImage_GetSamplingDimensions_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060199F5 RID: 104949
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleToImage_GetUseInputBounds_11(HandleRef pThis);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x060199F6 RID: 104950 RVA: 0x0023A1C8 File Offset: 0x002383C8
		public virtual bool GetUseInputBounds()
		{
			return vtkResampleToImage.vtkResampleToImage_GetUseInputBounds_11(base.GetCppThis()) != 0;
		}

		// Token: 0x060199F7 RID: 104951
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResampleToImage_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199F8 RID: 104952 RVA: 0x0023A1F0 File Offset: 0x002383F0
		public override int IsA(string type)
		{
			return vtkResampleToImage.vtkResampleToImage_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060199F9 RID: 104953
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResampleToImage_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199FA RID: 104954 RVA: 0x0023A210 File Offset: 0x00238410
		public new static int IsTypeOf(string type)
		{
			return vtkResampleToImage.vtkResampleToImage_IsTypeOf_13(type);
		}

		// Token: 0x060199FB RID: 104955
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleToImage_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199FC RID: 104956 RVA: 0x0023A22C File Offset: 0x0023842C
		public new vtkResampleToImage NewInstance()
		{
			vtkResampleToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleToImage.vtkResampleToImage_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResampleToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060199FD RID: 104957
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleToImage_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199FE RID: 104958 RVA: 0x0023A288 File Offset: 0x00238488
		public new static vtkResampleToImage SafeDownCast(vtkObjectBase o)
		{
			vtkResampleToImage vtkResampleToImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleToImage.vtkResampleToImage_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResampleToImage = (vtkResampleToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResampleToImage.Register(null);
				}
			}
			return vtkResampleToImage;
		}

		// Token: 0x060199FF RID: 104959
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_SetSamplingBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x06019A00 RID: 104960 RVA: 0x0023A307 File Offset: 0x00238507
		public virtual void SetSamplingBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkResampleToImage.vtkResampleToImage_SetSamplingBounds_17(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06019A01 RID: 104961
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_SetSamplingBounds_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x06019A02 RID: 104962 RVA: 0x0023A31F File Offset: 0x0023851F
		public virtual void SetSamplingBounds(IntPtr _arg)
		{
			vtkResampleToImage.vtkResampleToImage_SetSamplingBounds_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06019A03 RID: 104963
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_SetSamplingDimensions_19(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x06019A04 RID: 104964 RVA: 0x0023A32F File Offset: 0x0023852F
		public virtual void SetSamplingDimensions(int _arg1, int _arg2, int _arg3)
		{
			vtkResampleToImage.vtkResampleToImage_SetSamplingDimensions_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06019A05 RID: 104965
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_SetSamplingDimensions_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x06019A06 RID: 104966 RVA: 0x0023A341 File Offset: 0x00238541
		public virtual void SetSamplingDimensions(IntPtr _arg)
		{
			vtkResampleToImage.vtkResampleToImage_SetSamplingDimensions_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06019A07 RID: 104967
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_SetUseInputBounds_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x06019A08 RID: 104968 RVA: 0x0023A351 File Offset: 0x00238551
		public virtual void SetUseInputBounds(bool _arg)
		{
			vtkResampleToImage.vtkResampleToImage_SetUseInputBounds_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A09 RID: 104969
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_UseInputBoundsOff_22(HandleRef pThis);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x06019A0A RID: 104970 RVA: 0x0023A369 File Offset: 0x00238569
		public virtual void UseInputBoundsOff()
		{
			vtkResampleToImage.vtkResampleToImage_UseInputBoundsOff_22(base.GetCppThis());
		}

		// Token: 0x06019A0B RID: 104971
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleToImage_UseInputBoundsOn_23(HandleRef pThis);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x06019A0C RID: 104972 RVA: 0x0023A378 File Offset: 0x00238578
		public virtual void UseInputBoundsOn()
		{
			vtkResampleToImage.vtkResampleToImage_UseInputBoundsOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF5 RID: 7157
		public new const string MRFullTypeName = "Kitware.VTK.vtkResampleToImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF6 RID: 7158
		public new static readonly string MRClassNameKey = "class vtkResampleToImage";
	}
}
