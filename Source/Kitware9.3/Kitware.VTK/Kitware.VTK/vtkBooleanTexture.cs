using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBooleanTexture
	/// </summary>
	/// <remarks>
	///    generate 2D texture map based on combinations of inside, outside, and on region boundary
	///
	///
	/// vtkBooleanTexture is a filter to generate a 2D texture map based on
	/// combinations of inside, outside, and on region boundary. The "region" is
	/// implicitly represented via 2D texture coordinates. These texture
	/// coordinates are normally generated using a filter like
	/// vtkImplicitTextureCoords, which generates the texture coordinates for
	/// any implicit function.
	///
	/// vtkBooleanTexture generates the map according to the s-t texture
	/// coordinates plus the notion of being in, on, or outside of a
	/// region. An in region is when the texture coordinate is between
	/// (0,0.5-thickness/2).  An out region is where the texture coordinate
	/// is (0.5+thickness/2). An on region is between
	/// (0.5-thickness/2,0.5+thickness/2). The combination in, on, and out
	/// for each of the s-t texture coordinates results in 16 possible
	/// combinations (see text). For each combination, a different value of
	/// intensity and transparency can be assigned. To assign maximum intensity
	/// and/or opacity use the value 255. A minimum value of 0 results in
	/// a black region (for intensity) and a fully transparent region (for
	/// transparency).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitTextureCoords vtkThresholdTextureCoords
	/// </seealso>
	// Token: 0x020003DD RID: 989
	public class vtkBooleanTexture : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BCF8 RID: 48376 RVA: 0x00107F4B File Offset: 0x0010614B
		static vtkBooleanTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBooleanTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBooleanTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BCF9 RID: 48377 RVA: 0x00107F73 File Offset: 0x00106173
		public vtkBooleanTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BCFA RID: 48378
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BCFB RID: 48379 RVA: 0x00107F84 File Offset: 0x00106184
		public new static vtkBooleanTexture New()
		{
			vtkBooleanTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BCFC RID: 48380 RVA: 0x00107FD8 File Offset: 0x001061D8
		public vtkBooleanTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBooleanTexture.vtkBooleanTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BCFD RID: 48381 RVA: 0x0010801C File Offset: 0x0010621C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BCFE RID: 48382
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetInIn_01(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "in/in" region.
		/// </summary>
		// Token: 0x0600BCFF RID: 48383 RVA: 0x00108028 File Offset: 0x00106228
		public virtual byte[] GetInIn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetInIn_01(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD00 RID: 48384
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetInIn_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "in/in" region.
		/// </summary>
		// Token: 0x0600BD01 RID: 48385 RVA: 0x00108070 File Offset: 0x00106270
		public virtual void GetInIn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetInIn_02(base.GetCppThis(), data);
		}

		// Token: 0x0600BD02 RID: 48386
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetInOn_03(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "in/on" region.
		/// </summary>
		// Token: 0x0600BD03 RID: 48387 RVA: 0x00108080 File Offset: 0x00106280
		public virtual byte[] GetInOn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetInOn_03(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD04 RID: 48388
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetInOn_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "in/on" region.
		/// </summary>
		// Token: 0x0600BD05 RID: 48389 RVA: 0x001080C8 File Offset: 0x001062C8
		public virtual void GetInOn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetInOn_04(base.GetCppThis(), data);
		}

		// Token: 0x0600BD06 RID: 48390
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetInOut_05(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "in/out" region.
		/// </summary>
		// Token: 0x0600BD07 RID: 48391 RVA: 0x001080D8 File Offset: 0x001062D8
		public virtual byte[] GetInOut()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetInOut_05(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD08 RID: 48392
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetInOut_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "in/out" region.
		/// </summary>
		// Token: 0x0600BD09 RID: 48393 RVA: 0x00108120 File Offset: 0x00106320
		public virtual void GetInOut(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetInOut_06(base.GetCppThis(), data);
		}

		// Token: 0x0600BD0A RID: 48394
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBooleanTexture_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD0B RID: 48395 RVA: 0x00108130 File Offset: 0x00106330
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600BD0C RID: 48396
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBooleanTexture_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD0D RID: 48397 RVA: 0x00108150 File Offset: 0x00106350
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600BD0E RID: 48398
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetOnIn_09(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "on/in" region.
		/// </summary>
		// Token: 0x0600BD0F RID: 48399 RVA: 0x0010816C File Offset: 0x0010636C
		public virtual byte[] GetOnIn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOnIn_09(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD10 RID: 48400
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetOnIn_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "on/in" region.
		/// </summary>
		// Token: 0x0600BD11 RID: 48401 RVA: 0x001081B4 File Offset: 0x001063B4
		public virtual void GetOnIn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOnIn_10(base.GetCppThis(), data);
		}

		// Token: 0x0600BD12 RID: 48402
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetOnOn_11(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "on/on" region.
		/// </summary>
		// Token: 0x0600BD13 RID: 48403 RVA: 0x001081C4 File Offset: 0x001063C4
		public virtual byte[] GetOnOn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOnOn_11(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD14 RID: 48404
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetOnOn_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "on/on" region.
		/// </summary>
		// Token: 0x0600BD15 RID: 48405 RVA: 0x0010820C File Offset: 0x0010640C
		public virtual void GetOnOn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOnOn_12(base.GetCppThis(), data);
		}

		// Token: 0x0600BD16 RID: 48406
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetOnOut_13(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "on/out" region.
		/// </summary>
		// Token: 0x0600BD17 RID: 48407 RVA: 0x0010821C File Offset: 0x0010641C
		public virtual byte[] GetOnOut()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOnOut_13(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD18 RID: 48408
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetOnOut_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "on/out" region.
		/// </summary>
		// Token: 0x0600BD19 RID: 48409 RVA: 0x00108264 File Offset: 0x00106464
		public virtual void GetOnOut(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOnOut_14(base.GetCppThis(), data);
		}

		// Token: 0x0600BD1A RID: 48410
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetOutIn_15(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "out/in" region.
		/// </summary>
		// Token: 0x0600BD1B RID: 48411 RVA: 0x00108274 File Offset: 0x00106474
		public virtual byte[] GetOutIn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOutIn_15(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD1C RID: 48412
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetOutIn_16(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "out/in" region.
		/// </summary>
		// Token: 0x0600BD1D RID: 48413 RVA: 0x001082BC File Offset: 0x001064BC
		public virtual void GetOutIn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOutIn_16(base.GetCppThis(), data);
		}

		// Token: 0x0600BD1E RID: 48414
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetOutOn_17(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "out/on" region.
		/// </summary>
		// Token: 0x0600BD1F RID: 48415 RVA: 0x001082CC File Offset: 0x001064CC
		public virtual byte[] GetOutOn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOutOn_17(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD20 RID: 48416
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetOutOn_18(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "out/on" region.
		/// </summary>
		// Token: 0x0600BD21 RID: 48417 RVA: 0x00108314 File Offset: 0x00106514
		public virtual void GetOutOn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOutOn_18(base.GetCppThis(), data);
		}

		// Token: 0x0600BD22 RID: 48418
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_GetOutOut_19(HandleRef pThis);

		/// <summary>
		/// Specify intensity/transparency for "out/out" region.
		/// </summary>
		// Token: 0x0600BD23 RID: 48419 RVA: 0x00108324 File Offset: 0x00106524
		public virtual byte[] GetOutOut()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOutOut_19(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD24 RID: 48420
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_GetOutOut_20(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify intensity/transparency for "out/out" region.
		/// </summary>
		// Token: 0x0600BD25 RID: 48421 RVA: 0x0010836C File Offset: 0x0010656C
		public virtual void GetOutOut(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOutOut_20(base.GetCppThis(), data);
		}

		// Token: 0x0600BD26 RID: 48422
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanTexture_GetThickness_21(HandleRef pThis);

		/// <summary>
		/// Set the thickness of the "on" region.
		/// </summary>
		// Token: 0x0600BD27 RID: 48423 RVA: 0x0010837C File Offset: 0x0010657C
		public virtual int GetThickness()
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetThickness_21(base.GetCppThis());
		}

		// Token: 0x0600BD28 RID: 48424
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanTexture_GetXSize_22(HandleRef pThis);

		/// <summary>
		/// Set the X texture map dimension.
		/// </summary>
		// Token: 0x0600BD29 RID: 48425 RVA: 0x0010839C File Offset: 0x0010659C
		public virtual int GetXSize()
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetXSize_22(base.GetCppThis());
		}

		// Token: 0x0600BD2A RID: 48426
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanTexture_GetYSize_23(HandleRef pThis);

		/// <summary>
		/// Set the Y texture map dimension.
		/// </summary>
		// Token: 0x0600BD2B RID: 48427 RVA: 0x001083BC File Offset: 0x001065BC
		public virtual int GetYSize()
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetYSize_23(base.GetCppThis());
		}

		// Token: 0x0600BD2C RID: 48428
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanTexture_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD2D RID: 48429 RVA: 0x001083DC File Offset: 0x001065DC
		public override int IsA(string type)
		{
			return vtkBooleanTexture.vtkBooleanTexture_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600BD2E RID: 48430
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanTexture_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD2F RID: 48431 RVA: 0x001083FC File Offset: 0x001065FC
		public new static int IsTypeOf(string type)
		{
			return vtkBooleanTexture.vtkBooleanTexture_IsTypeOf_25(type);
		}

		// Token: 0x0600BD30 RID: 48432
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD31 RID: 48433 RVA: 0x00108418 File Offset: 0x00106618
		public new vtkBooleanTexture NewInstance()
		{
			vtkBooleanTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BD32 RID: 48434
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanTexture_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD33 RID: 48435 RVA: 0x00108474 File Offset: 0x00106674
		public new static vtkBooleanTexture SafeDownCast(vtkObjectBase o)
		{
			vtkBooleanTexture vtkBooleanTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBooleanTexture = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBooleanTexture.Register(null);
				}
			}
			return vtkBooleanTexture;
		}

		// Token: 0x0600BD34 RID: 48436
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetInIn_29(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "in/in" region.
		/// </summary>
		// Token: 0x0600BD35 RID: 48437 RVA: 0x001084F3 File Offset: 0x001066F3
		public virtual void SetInIn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInIn_29(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD36 RID: 48438
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetInIn_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "in/in" region.
		/// </summary>
		// Token: 0x0600BD37 RID: 48439 RVA: 0x00108504 File Offset: 0x00106704
		public void SetInIn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInIn_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD38 RID: 48440
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetInOn_31(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "in/on" region.
		/// </summary>
		// Token: 0x0600BD39 RID: 48441 RVA: 0x00108514 File Offset: 0x00106714
		public virtual void SetInOn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOn_31(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD3A RID: 48442
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetInOn_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "in/on" region.
		/// </summary>
		// Token: 0x0600BD3B RID: 48443 RVA: 0x00108525 File Offset: 0x00106725
		public void SetInOn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOn_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD3C RID: 48444
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetInOut_33(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "in/out" region.
		/// </summary>
		// Token: 0x0600BD3D RID: 48445 RVA: 0x00108535 File Offset: 0x00106735
		public virtual void SetInOut(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOut_33(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD3E RID: 48446
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetInOut_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "in/out" region.
		/// </summary>
		// Token: 0x0600BD3F RID: 48447 RVA: 0x00108546 File Offset: 0x00106746
		public void SetInOut(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOut_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD40 RID: 48448
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOnIn_35(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "on/in" region.
		/// </summary>
		// Token: 0x0600BD41 RID: 48449 RVA: 0x00108556 File Offset: 0x00106756
		public virtual void SetOnIn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnIn_35(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD42 RID: 48450
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOnIn_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "on/in" region.
		/// </summary>
		// Token: 0x0600BD43 RID: 48451 RVA: 0x00108567 File Offset: 0x00106767
		public void SetOnIn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnIn_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD44 RID: 48452
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOnOn_37(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "on/on" region.
		/// </summary>
		// Token: 0x0600BD45 RID: 48453 RVA: 0x00108577 File Offset: 0x00106777
		public virtual void SetOnOn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOn_37(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD46 RID: 48454
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOnOn_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "on/on" region.
		/// </summary>
		// Token: 0x0600BD47 RID: 48455 RVA: 0x00108588 File Offset: 0x00106788
		public void SetOnOn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOn_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD48 RID: 48456
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOnOut_39(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "on/out" region.
		/// </summary>
		// Token: 0x0600BD49 RID: 48457 RVA: 0x00108598 File Offset: 0x00106798
		public virtual void SetOnOut(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOut_39(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD4A RID: 48458
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOnOut_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "on/out" region.
		/// </summary>
		// Token: 0x0600BD4B RID: 48459 RVA: 0x001085A9 File Offset: 0x001067A9
		public void SetOnOut(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOut_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD4C RID: 48460
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOutIn_41(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "out/in" region.
		/// </summary>
		// Token: 0x0600BD4D RID: 48461 RVA: 0x001085B9 File Offset: 0x001067B9
		public virtual void SetOutIn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutIn_41(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD4E RID: 48462
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOutIn_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "out/in" region.
		/// </summary>
		// Token: 0x0600BD4F RID: 48463 RVA: 0x001085CA File Offset: 0x001067CA
		public void SetOutIn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutIn_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD50 RID: 48464
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOutOn_43(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "out/on" region.
		/// </summary>
		// Token: 0x0600BD51 RID: 48465 RVA: 0x001085DA File Offset: 0x001067DA
		public virtual void SetOutOn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOn_43(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD52 RID: 48466
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOutOn_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "out/on" region.
		/// </summary>
		// Token: 0x0600BD53 RID: 48467 RVA: 0x001085EB File Offset: 0x001067EB
		public void SetOutOn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOn_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD54 RID: 48468
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOutOut_45(HandleRef pThis, byte _arg1, byte _arg2);

		/// <summary>
		/// Specify intensity/transparency for "out/out" region.
		/// </summary>
		// Token: 0x0600BD55 RID: 48469 RVA: 0x001085FB File Offset: 0x001067FB
		public virtual void SetOutOut(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOut_45(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BD56 RID: 48470
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetOutOut_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify intensity/transparency for "out/out" region.
		/// </summary>
		// Token: 0x0600BD57 RID: 48471 RVA: 0x0010860C File Offset: 0x0010680C
		public void SetOutOut(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOut_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD58 RID: 48472
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetThickness_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the thickness of the "on" region.
		/// </summary>
		// Token: 0x0600BD59 RID: 48473 RVA: 0x0010861C File Offset: 0x0010681C
		public virtual void SetThickness(int _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetThickness_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD5A RID: 48474
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetXSize_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the X texture map dimension.
		/// </summary>
		// Token: 0x0600BD5B RID: 48475 RVA: 0x0010862C File Offset: 0x0010682C
		public virtual void SetXSize(int _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetXSize_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BD5C RID: 48476
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanTexture_SetYSize_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the Y texture map dimension.
		/// </summary>
		// Token: 0x0600BD5D RID: 48477 RVA: 0x0010863C File Offset: 0x0010683C
		public virtual void SetYSize(int _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetYSize_49(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E24 RID: 3620
		public new const string MRFullTypeName = "Kitware.VTK.vtkBooleanTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E25 RID: 3621
		public new static readonly string MRClassNameKey = "class vtkBooleanTexture";
	}
}
