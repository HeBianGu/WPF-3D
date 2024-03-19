using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSinusoidSource
	/// </summary>
	/// <remarks>
	///    Create an image with sinusoidal pixel values.
	///
	/// vtkImageSinusoidSource just produces images with pixel values determined
	/// by a sinusoid.
	/// </remarks>
	// Token: 0x0200075A RID: 1882
	public class vtkImageSinusoidSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060138BF RID: 80063 RVA: 0x001B9F13 File Offset: 0x001B8113
		static vtkImageSinusoidSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSinusoidSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSinusoidSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060138C0 RID: 80064 RVA: 0x001B9F3B File Offset: 0x001B813B
		public vtkImageSinusoidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060138C1 RID: 80065
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSinusoidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138C2 RID: 80066 RVA: 0x001B9F4C File Offset: 0x001B814C
		public new static vtkImageSinusoidSource New()
		{
			vtkImageSinusoidSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138C3 RID: 80067 RVA: 0x001B9FA0 File Offset: 0x001B81A0
		public vtkImageSinusoidSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSinusoidSource.vtkImageSinusoidSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060138C4 RID: 80068 RVA: 0x001B9FE4 File Offset: 0x001B81E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060138C5 RID: 80069
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSinusoidSource_GetAmplitude_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the magnitude of the sinusoid.
		/// </summary>
		// Token: 0x060138C6 RID: 80070 RVA: 0x001B9FF0 File Offset: 0x001B81F0
		public virtual double GetAmplitude()
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetAmplitude_01(base.GetCppThis());
		}

		// Token: 0x060138C7 RID: 80071
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSinusoidSource_GetDirection_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction vector which determines the sinusoidal
		/// orientation. The magnitude is ignored.
		/// </summary>
		// Token: 0x060138C8 RID: 80072 RVA: 0x001BA010 File Offset: 0x001B8210
		public virtual double[] GetDirection()
		{
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_GetDirection_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060138C9 RID: 80073
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_GetDirection_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the direction vector which determines the sinusoidal
		/// orientation. The magnitude is ignored.
		/// </summary>
		// Token: 0x060138CA RID: 80074 RVA: 0x001BA058 File Offset: 0x001B8258
		public virtual void GetDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_GetDirection_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060138CB RID: 80075
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_GetDirection_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the direction vector which determines the sinusoidal
		/// orientation. The magnitude is ignored.
		/// </summary>
		// Token: 0x060138CC RID: 80076 RVA: 0x001BA06A File Offset: 0x001B826A
		public virtual void GetDirection(IntPtr _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_GetDirection_04(base.GetCppThis(), _arg);
		}

		// Token: 0x060138CD RID: 80077
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSinusoidSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138CE RID: 80078 RVA: 0x001BA07C File Offset: 0x001B827C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060138CF RID: 80079
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSinusoidSource_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138D0 RID: 80080 RVA: 0x001BA09C File Offset: 0x001B829C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060138D1 RID: 80081
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSinusoidSource_GetPeriod_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the period of the sinusoid in pixels.
		/// </summary>
		// Token: 0x060138D2 RID: 80082 RVA: 0x001BA0B8 File Offset: 0x001B82B8
		public virtual double GetPeriod()
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetPeriod_07(base.GetCppThis());
		}

		// Token: 0x060138D3 RID: 80083
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSinusoidSource_GetPhase_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the phase: 0-&gt;2Pi.  0 =&gt; Cosine, pi/2 =&gt; Sine.
		/// </summary>
		// Token: 0x060138D4 RID: 80084 RVA: 0x001BA0D8 File Offset: 0x001B82D8
		public virtual double GetPhase()
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetPhase_08(base.GetCppThis());
		}

		// Token: 0x060138D5 RID: 80085
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSinusoidSource_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138D6 RID: 80086 RVA: 0x001BA0F8 File Offset: 0x001B82F8
		public override int IsA(string type)
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060138D7 RID: 80087
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSinusoidSource_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138D8 RID: 80088 RVA: 0x001BA118 File Offset: 0x001B8318
		public new static int IsTypeOf(string type)
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_IsTypeOf_10(type);
		}

		// Token: 0x060138D9 RID: 80089
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSinusoidSource_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138DA RID: 80090 RVA: 0x001BA134 File Offset: 0x001B8334
		public new vtkImageSinusoidSource NewInstance()
		{
			vtkImageSinusoidSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060138DB RID: 80091
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSinusoidSource_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138DC RID: 80092 RVA: 0x001BA190 File Offset: 0x001B8390
		public new static vtkImageSinusoidSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageSinusoidSource vtkImageSinusoidSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSinusoidSource = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSinusoidSource.Register(null);
				}
			}
			return vtkImageSinusoidSource;
		}

		// Token: 0x060138DD RID: 80093
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_SetAmplitude_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the magnitude of the sinusoid.
		/// </summary>
		// Token: 0x060138DE RID: 80094 RVA: 0x001BA20F File Offset: 0x001B840F
		public virtual void SetAmplitude(double _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetAmplitude_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060138DF RID: 80095
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_SetDirection_15(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/Get the direction vector which determines the sinusoidal
		/// orientation. The magnitude is ignored.
		/// </summary>
		// Token: 0x060138E0 RID: 80096 RVA: 0x001BA21F File Offset: 0x001B841F
		public void SetDirection(double arg0, double arg1, double arg2)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetDirection_15(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060138E1 RID: 80097
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_SetDirection_16(HandleRef pThis, IntPtr dir);

		/// <summary>
		/// Set/Get the direction vector which determines the sinusoidal
		/// orientation. The magnitude is ignored.
		/// </summary>
		// Token: 0x060138E2 RID: 80098 RVA: 0x001BA231 File Offset: 0x001B8431
		public void SetDirection(IntPtr dir)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetDirection_16(base.GetCppThis(), dir);
		}

		// Token: 0x060138E3 RID: 80099
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_SetPeriod_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the period of the sinusoid in pixels.
		/// </summary>
		// Token: 0x060138E4 RID: 80100 RVA: 0x001BA241 File Offset: 0x001B8441
		public virtual void SetPeriod(double _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetPeriod_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060138E5 RID: 80101
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_SetPhase_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the phase: 0-&gt;2Pi.  0 =&gt; Cosine, pi/2 =&gt; Sine.
		/// </summary>
		// Token: 0x060138E6 RID: 80102 RVA: 0x001BA251 File Offset: 0x001B8451
		public virtual void SetPhase(double _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetPhase_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060138E7 RID: 80103
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSinusoidSource_SetWholeExtent_19(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		/// <summary>
		/// Set/Get the extent of the whole output image.
		/// </summary>
		// Token: 0x060138E8 RID: 80104 RVA: 0x001BA261 File Offset: 0x001B8461
		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetWholeExtent_19(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001691 RID: 5777
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSinusoidSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001692 RID: 5778
		public new static readonly string MRClassNameKey = "class vtkImageSinusoidSource";
	}
}
