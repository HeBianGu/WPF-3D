using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDiskSource
	/// </summary>
	/// <remarks>
	///    create a disk with hole in center
	///
	/// vtkDiskSource creates a polygonal disk with a hole in the center. The
	/// disk has zero height. The user can specify the inner and outer radius
	/// of the disk, the radial and circumferential resolution of the
	/// polygonal representation, and the center and plane normal of the disk
	/// (i.e., the center and disk normal control the position and orientation
	/// of the disk).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearExtrusionFilter
	/// </seealso>
	// Token: 0x02000827 RID: 2087
	public class vtkDiskSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601589C RID: 88220 RVA: 0x001E7187 File Offset: 0x001E5387
		static vtkDiskSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiskSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiskSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601589D RID: 88221 RVA: 0x001E71AF File Offset: 0x001E53AF
		public vtkDiskSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601589E RID: 88222
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiskSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x0601589F RID: 88223 RVA: 0x001E71C0 File Offset: 0x001E53C0
		public new static vtkDiskSource New()
		{
			vtkDiskSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x060158A0 RID: 88224 RVA: 0x001E7214 File Offset: 0x001E5414
		public vtkDiskSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDiskSource.vtkDiskSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060158A1 RID: 88225 RVA: 0x001E7258 File Offset: 0x001E5458
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060158A2 RID: 88226
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiskSource_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set the center of the disk. The default is (0, 0, 0).
		/// </summary>
		// Token: 0x060158A3 RID: 88227 RVA: 0x001E7264 File Offset: 0x001E5464
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060158A4 RID: 88228
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_GetCenter_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the disk. The default is (0, 0, 0).
		/// </summary>
		// Token: 0x060158A5 RID: 88229 RVA: 0x001E72AC File Offset: 0x001E54AC
		public virtual void GetCenter(IntPtr data)
		{
			vtkDiskSource.vtkDiskSource_GetCenter_02(base.GetCppThis(), data);
		}

		// Token: 0x060158A6 RID: 88230
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_GetCircumferentialResolution_03(HandleRef pThis);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x060158A7 RID: 88231 RVA: 0x001E72BC File Offset: 0x001E54BC
		public virtual int GetCircumferentialResolution()
		{
			return vtkDiskSource.vtkDiskSource_GetCircumferentialResolution_03(base.GetCppThis());
		}

		// Token: 0x060158A8 RID: 88232
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_GetCircumferentialResolutionMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x060158A9 RID: 88233 RVA: 0x001E72DC File Offset: 0x001E54DC
		public virtual int GetCircumferentialResolutionMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetCircumferentialResolutionMaxValue_04(base.GetCppThis());
		}

		// Token: 0x060158AA RID: 88234
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_GetCircumferentialResolutionMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x060158AB RID: 88235 RVA: 0x001E72FC File Offset: 0x001E54FC
		public virtual int GetCircumferentialResolutionMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetCircumferentialResolutionMinValue_05(base.GetCppThis());
		}

		// Token: 0x060158AC RID: 88236
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiskSource_GetInnerRadius_06(HandleRef pThis);

		/// <summary>
		/// Specify inner radius of hole in disk.
		/// </summary>
		// Token: 0x060158AD RID: 88237 RVA: 0x001E731C File Offset: 0x001E551C
		public virtual double GetInnerRadius()
		{
			return vtkDiskSource.vtkDiskSource_GetInnerRadius_06(base.GetCppThis());
		}

		// Token: 0x060158AE RID: 88238
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiskSource_GetInnerRadiusMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Specify inner radius of hole in disk.
		/// </summary>
		// Token: 0x060158AF RID: 88239 RVA: 0x001E733C File Offset: 0x001E553C
		public virtual double GetInnerRadiusMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetInnerRadiusMaxValue_07(base.GetCppThis());
		}

		// Token: 0x060158B0 RID: 88240
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiskSource_GetInnerRadiusMinValue_08(HandleRef pThis);

		/// <summary>
		/// Specify inner radius of hole in disk.
		/// </summary>
		// Token: 0x060158B1 RID: 88241 RVA: 0x001E735C File Offset: 0x001E555C
		public virtual double GetInnerRadiusMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetInnerRadiusMinValue_08(base.GetCppThis());
		}

		// Token: 0x060158B2 RID: 88242
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiskSource_GetNormal_09(HandleRef pThis);

		/// <summary>
		/// Set/get plane normal. The default is (0, 0, 1).
		/// </summary>
		// Token: 0x060158B3 RID: 88243 RVA: 0x001E737C File Offset: 0x001E557C
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_GetNormal_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060158B4 RID: 88244
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_GetNormal_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get plane normal. The default is (0, 0, 1).
		/// </summary>
		// Token: 0x060158B5 RID: 88245 RVA: 0x001E73C4 File Offset: 0x001E55C4
		public virtual void GetNormal(IntPtr data)
		{
			vtkDiskSource.vtkDiskSource_GetNormal_10(base.GetCppThis(), data);
		}

		// Token: 0x060158B6 RID: 88246
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiskSource_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x060158B7 RID: 88247 RVA: 0x001E73D4 File Offset: 0x001E55D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDiskSource.vtkDiskSource_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060158B8 RID: 88248
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiskSource_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x060158B9 RID: 88249 RVA: 0x001E73F4 File Offset: 0x001E55F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDiskSource.vtkDiskSource_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060158BA RID: 88250
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiskSource_GetOuterRadius_13(HandleRef pThis);

		/// <summary>
		/// Specify outer radius of disk.
		/// </summary>
		// Token: 0x060158BB RID: 88251 RVA: 0x001E7410 File Offset: 0x001E5610
		public virtual double GetOuterRadius()
		{
			return vtkDiskSource.vtkDiskSource_GetOuterRadius_13(base.GetCppThis());
		}

		// Token: 0x060158BC RID: 88252
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiskSource_GetOuterRadiusMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify outer radius of disk.
		/// </summary>
		// Token: 0x060158BD RID: 88253 RVA: 0x001E7430 File Offset: 0x001E5630
		public virtual double GetOuterRadiusMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetOuterRadiusMaxValue_14(base.GetCppThis());
		}

		// Token: 0x060158BE RID: 88254
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiskSource_GetOuterRadiusMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify outer radius of disk.
		/// </summary>
		// Token: 0x060158BF RID: 88255 RVA: 0x001E7450 File Offset: 0x001E5650
		public virtual double GetOuterRadiusMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetOuterRadiusMinValue_15(base.GetCppThis());
		}

		// Token: 0x060158C0 RID: 88256
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_GetOutputPointsPrecision_16(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060158C1 RID: 88257 RVA: 0x001E7470 File Offset: 0x001E5670
		public virtual int GetOutputPointsPrecision()
		{
			return vtkDiskSource.vtkDiskSource_GetOutputPointsPrecision_16(base.GetCppThis());
		}

		// Token: 0x060158C2 RID: 88258
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_GetRadialResolution_17(HandleRef pThis);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x060158C3 RID: 88259 RVA: 0x001E7490 File Offset: 0x001E5690
		public virtual int GetRadialResolution()
		{
			return vtkDiskSource.vtkDiskSource_GetRadialResolution_17(base.GetCppThis());
		}

		// Token: 0x060158C4 RID: 88260
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_GetRadialResolutionMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x060158C5 RID: 88261 RVA: 0x001E74B0 File Offset: 0x001E56B0
		public virtual int GetRadialResolutionMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetRadialResolutionMaxValue_18(base.GetCppThis());
		}

		// Token: 0x060158C6 RID: 88262
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_GetRadialResolutionMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x060158C7 RID: 88263 RVA: 0x001E74D0 File Offset: 0x001E56D0
		public virtual int GetRadialResolutionMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetRadialResolutionMinValue_19(base.GetCppThis());
		}

		// Token: 0x060158C8 RID: 88264
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x060158C9 RID: 88265 RVA: 0x001E74F0 File Offset: 0x001E56F0
		public override int IsA(string type)
		{
			return vtkDiskSource.vtkDiskSource_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x060158CA RID: 88266
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiskSource_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x060158CB RID: 88267 RVA: 0x001E7510 File Offset: 0x001E5710
		public new static int IsTypeOf(string type)
		{
			return vtkDiskSource.vtkDiskSource_IsTypeOf_21(type);
		}

		// Token: 0x060158CC RID: 88268
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiskSource_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x060158CD RID: 88269 RVA: 0x001E752C File Offset: 0x001E572C
		public new vtkDiskSource NewInstance()
		{
			vtkDiskSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060158CE RID: 88270
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiskSource_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to  instantiate the class, obtain type information,
		/// and print the state of the object.
		/// </summary>
		// Token: 0x060158CF RID: 88271 RVA: 0x001E7588 File Offset: 0x001E5788
		public new static vtkDiskSource SafeDownCast(vtkObjectBase o)
		{
			vtkDiskSource vtkDiskSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiskSource = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiskSource.Register(null);
				}
			}
			return vtkDiskSource;
		}

		// Token: 0x060158D0 RID: 88272
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetCenter_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the disk. The default is (0, 0, 0).
		/// </summary>
		// Token: 0x060158D1 RID: 88273 RVA: 0x001E7607 File Offset: 0x001E5807
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkDiskSource.vtkDiskSource_SetCenter_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060158D2 RID: 88274
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetCenter_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the disk. The default is (0, 0, 0).
		/// </summary>
		// Token: 0x060158D3 RID: 88275 RVA: 0x001E7619 File Offset: 0x001E5819
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkDiskSource.vtkDiskSource_SetCenter_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060158D4 RID: 88276
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetCircumferentialResolution_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x060158D5 RID: 88277 RVA: 0x001E7629 File Offset: 0x001E5829
		public virtual void SetCircumferentialResolution(int _arg)
		{
			vtkDiskSource.vtkDiskSource_SetCircumferentialResolution_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060158D6 RID: 88278
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetInnerRadius_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify inner radius of hole in disk.
		/// </summary>
		// Token: 0x060158D7 RID: 88279 RVA: 0x001E7639 File Offset: 0x001E5839
		public virtual void SetInnerRadius(double _arg)
		{
			vtkDiskSource.vtkDiskSource_SetInnerRadius_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060158D8 RID: 88280
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetNormal_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get plane normal. The default is (0, 0, 1).
		/// </summary>
		// Token: 0x060158D9 RID: 88281 RVA: 0x001E7649 File Offset: 0x001E5849
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkDiskSource.vtkDiskSource_SetNormal_29(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060158DA RID: 88282
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetNormal_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get plane normal. The default is (0, 0, 1).
		/// </summary>
		// Token: 0x060158DB RID: 88283 RVA: 0x001E765B File Offset: 0x001E585B
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkDiskSource.vtkDiskSource_SetNormal_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060158DC RID: 88284
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetOuterRadius_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify outer radius of disk.
		/// </summary>
		// Token: 0x060158DD RID: 88285 RVA: 0x001E766B File Offset: 0x001E586B
		public virtual void SetOuterRadius(double _arg)
		{
			vtkDiskSource.vtkDiskSource_SetOuterRadius_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060158DE RID: 88286
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetOutputPointsPrecision_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x060158DF RID: 88287 RVA: 0x001E767B File Offset: 0x001E587B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkDiskSource.vtkDiskSource_SetOutputPointsPrecision_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060158E0 RID: 88288
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiskSource_SetRadialResolution_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x060158E1 RID: 88289 RVA: 0x001E768B File Offset: 0x001E588B
		public virtual void SetRadialResolution(int _arg)
		{
			vtkDiskSource.vtkDiskSource_SetRadialResolution_33(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001898 RID: 6296
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiskSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001899 RID: 6297
		public new static readonly string MRClassNameKey = "class vtkDiskSource";
	}
}
