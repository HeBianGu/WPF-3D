using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransformTextureCoords
	/// </summary>
	/// <remarks>
	///    transform (scale, rotate, translate) texture coordinates
	///
	/// vtkTransformTextureCoords is a filter that operates on texture
	/// coordinates. It ingests any type of dataset, and outputs a dataset of the
	/// same type. The filter lets you scale, translate, and rotate texture
	/// coordinates. For example, by using the Scale ivar, you can shift
	/// texture coordinates that range from (0-&gt;1) to range from (0-&gt;10) (useful
	/// for repeated patterns).
	///
	/// The filter operates on texture coordinates of dimension 1-&gt;3. The texture
	/// coordinates are referred to as r-s-t. If the texture map is two dimensional,
	/// the t-coordinate (and operations on the t-coordinate) are ignored.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextureMapToPlane  vtkTextureMapToCylinder
	/// vtkTextureMapToSphere vtkThresholdTextureCoords vtkTexture
	/// </seealso>
	// Token: 0x02000544 RID: 1348
	public class vtkTransformTextureCoords : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F007 RID: 61447 RVA: 0x0014E928 File Offset: 0x0014CB28
		static vtkTransformTextureCoords()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformTextureCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformTextureCoords"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F008 RID: 61448 RVA: 0x0014E950 File Offset: 0x0014CB50
		public vtkTransformTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F009 RID: 61449
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create instance with Origin (0.5,0.5,0.5); Position (0,0,0); and Scale
		/// set to (1,1,1). Rotation of the texture coordinates is turned off.
		/// </summary>
		// Token: 0x0600F00A RID: 61450 RVA: 0x0014E960 File Offset: 0x0014CB60
		public new static vtkTransformTextureCoords New()
		{
			vtkTransformTextureCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create instance with Origin (0.5,0.5,0.5); Position (0,0,0); and Scale
		/// set to (1,1,1). Rotation of the texture coordinates is turned off.
		/// </summary>
		// Token: 0x0600F00B RID: 61451 RVA: 0x0014E9B4 File Offset: 0x0014CBB4
		public vtkTransformTextureCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransformTextureCoords.vtkTransformTextureCoords_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F00C RID: 61452 RVA: 0x0014E9F8 File Offset: 0x0014CBF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F00D RID: 61453
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_AddPosition_01(HandleRef pThis, double deltaR, double deltaS, double deltaT);

		/// <summary>
		/// Incrementally change the position of the texture map (i.e., does a
		/// translate or shift of the texture coordinates).
		/// </summary>
		// Token: 0x0600F00E RID: 61454 RVA: 0x0014EA03 File Offset: 0x0014CC03
		public void AddPosition(double deltaR, double deltaS, double deltaT)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_AddPosition_01(base.GetCppThis(), deltaR, deltaS, deltaT);
		}

		// Token: 0x0600F00F RID: 61455
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_AddPosition_02(HandleRef pThis, IntPtr deltaPosition);

		/// <summary>
		/// Incrementally change the position of the texture map (i.e., does a
		/// translate or shift of the texture coordinates).
		/// </summary>
		// Token: 0x0600F010 RID: 61456 RVA: 0x0014EA15 File Offset: 0x0014CC15
		public void AddPosition(IntPtr deltaPosition)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_AddPosition_02(base.GetCppThis(), deltaPosition);
		}

		// Token: 0x0600F011 RID: 61457
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_FlipROff_03(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F012 RID: 61458 RVA: 0x0014EA25 File Offset: 0x0014CC25
		public virtual void FlipROff()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipROff_03(base.GetCppThis());
		}

		// Token: 0x0600F013 RID: 61459
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_FlipROn_04(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F014 RID: 61460 RVA: 0x0014EA34 File Offset: 0x0014CC34
		public virtual void FlipROn()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipROn_04(base.GetCppThis());
		}

		// Token: 0x0600F015 RID: 61461
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_FlipSOff_05(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F016 RID: 61462 RVA: 0x0014EA43 File Offset: 0x0014CC43
		public virtual void FlipSOff()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipSOff_05(base.GetCppThis());
		}

		// Token: 0x0600F017 RID: 61463
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_FlipSOn_06(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F018 RID: 61464 RVA: 0x0014EA52 File Offset: 0x0014CC52
		public virtual void FlipSOn()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipSOn_06(base.GetCppThis());
		}

		// Token: 0x0600F019 RID: 61465
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_FlipTOff_07(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// t-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F01A RID: 61466 RVA: 0x0014EA61 File Offset: 0x0014CC61
		public virtual void FlipTOff()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipTOff_07(base.GetCppThis());
		}

		// Token: 0x0600F01B RID: 61467
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_FlipTOn_08(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// t-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F01C RID: 61468 RVA: 0x0014EA70 File Offset: 0x0014CC70
		public virtual void FlipTOn()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipTOn_08(base.GetCppThis());
		}

		// Token: 0x0600F01D RID: 61469
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformTextureCoords_GetFlipR_09(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F01E RID: 61470 RVA: 0x0014EA80 File Offset: 0x0014CC80
		public virtual int GetFlipR()
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetFlipR_09(base.GetCppThis());
		}

		// Token: 0x0600F01F RID: 61471
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformTextureCoords_GetFlipS_10(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F020 RID: 61472 RVA: 0x0014EAA0 File Offset: 0x0014CCA0
		public virtual int GetFlipS()
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetFlipS_10(base.GetCppThis());
		}

		// Token: 0x0600F021 RID: 61473
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformTextureCoords_GetFlipT_11(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// t-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F022 RID: 61474 RVA: 0x0014EAC0 File Offset: 0x0014CCC0
		public virtual int GetFlipT()
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetFlipT_11(base.GetCppThis());
		}

		// Token: 0x0600F023 RID: 61475
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformTextureCoords_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F024 RID: 61476 RVA: 0x0014EAE0 File Offset: 0x0014CCE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600F025 RID: 61477
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformTextureCoords_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F026 RID: 61478 RVA: 0x0014EB00 File Offset: 0x0014CD00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0600F027 RID: 61479
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformTextureCoords_GetOrigin_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the texture map. This is the point about which the
		/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
		/// from (0,1) in the r-s-t coordinates, the default origin is set at
		/// (0.5,0.5,0.5).
		/// </summary>
		// Token: 0x0600F028 RID: 61480 RVA: 0x0014EB1C File Offset: 0x0014CD1C
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_GetOrigin_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F029 RID: 61481
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_GetOrigin_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the origin of the texture map. This is the point about which the
		/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
		/// from (0,1) in the r-s-t coordinates, the default origin is set at
		/// (0.5,0.5,0.5).
		/// </summary>
		// Token: 0x0600F02A RID: 61482 RVA: 0x0014EB64 File Offset: 0x0014CD64
		public virtual void GetOrigin(IntPtr data)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_GetOrigin_15(base.GetCppThis(), data);
		}

		// Token: 0x0600F02B RID: 61483
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformTextureCoords_GetPosition_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the texture map. Setting the position translates
		/// the texture map by the amount specified.
		/// </summary>
		// Token: 0x0600F02C RID: 61484 RVA: 0x0014EB74 File Offset: 0x0014CD74
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_GetPosition_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F02D RID: 61485
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_GetPosition_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the position of the texture map. Setting the position translates
		/// the texture map by the amount specified.
		/// </summary>
		// Token: 0x0600F02E RID: 61486 RVA: 0x0014EBBC File Offset: 0x0014CDBC
		public virtual void GetPosition(IntPtr data)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_GetPosition_17(base.GetCppThis(), data);
		}

		// Token: 0x0600F02F RID: 61487
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformTextureCoords_GetScale_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale of the texture map. Scaling in performed independently
		/// on the r, s and t axes.
		/// </summary>
		// Token: 0x0600F030 RID: 61488 RVA: 0x0014EBCC File Offset: 0x0014CDCC
		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_GetScale_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F031 RID: 61489
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_GetScale_19(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the scale of the texture map. Scaling in performed independently
		/// on the r, s and t axes.
		/// </summary>
		// Token: 0x0600F032 RID: 61490 RVA: 0x0014EC14 File Offset: 0x0014CE14
		public virtual void GetScale(IntPtr data)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_GetScale_19(base.GetCppThis(), data);
		}

		// Token: 0x0600F033 RID: 61491
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformTextureCoords_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F034 RID: 61492 RVA: 0x0014EC24 File Offset: 0x0014CE24
		public override int IsA(string type)
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0600F035 RID: 61493
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformTextureCoords_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F036 RID: 61494 RVA: 0x0014EC44 File Offset: 0x0014CE44
		public new static int IsTypeOf(string type)
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_IsTypeOf_21(type);
		}

		// Token: 0x0600F037 RID: 61495
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformTextureCoords_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F038 RID: 61496 RVA: 0x0014EC60 File Offset: 0x0014CE60
		public new vtkTransformTextureCoords NewInstance()
		{
			vtkTransformTextureCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F039 RID: 61497
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformTextureCoords_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F03A RID: 61498 RVA: 0x0014ECBC File Offset: 0x0014CEBC
		public new static vtkTransformTextureCoords SafeDownCast(vtkObjectBase o)
		{
			vtkTransformTextureCoords vtkTransformTextureCoords = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformTextureCoords = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformTextureCoords.Register(null);
				}
			}
			return vtkTransformTextureCoords;
		}

		// Token: 0x0600F03B RID: 61499
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetFlipR_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F03C RID: 61500 RVA: 0x0014ED3B File Offset: 0x0014CF3B
		public virtual void SetFlipR(int _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetFlipR_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F03D RID: 61501
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetFlipS_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// s-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F03E RID: 61502 RVA: 0x0014ED4B File Offset: 0x0014CF4B
		public virtual void SetFlipS(int _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetFlipS_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F03F RID: 61503
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetFlipT_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean indicates whether the texture map should be flipped around the
		/// t-axis. Note that the flips occur around the texture origin.
		/// </summary>
		// Token: 0x0600F040 RID: 61504 RVA: 0x0014ED5B File Offset: 0x0014CF5B
		public virtual void SetFlipT(int _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetFlipT_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F041 RID: 61505
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetOrigin_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the origin of the texture map. This is the point about which the
		/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
		/// from (0,1) in the r-s-t coordinates, the default origin is set at
		/// (0.5,0.5,0.5).
		/// </summary>
		// Token: 0x0600F042 RID: 61506 RVA: 0x0014ED6B File Offset: 0x0014CF6B
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetOrigin_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F043 RID: 61507
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetOrigin_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the texture map. This is the point about which the
		/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
		/// from (0,1) in the r-s-t coordinates, the default origin is set at
		/// (0.5,0.5,0.5).
		/// </summary>
		// Token: 0x0600F044 RID: 61508 RVA: 0x0014ED7D File Offset: 0x0014CF7D
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetOrigin_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F045 RID: 61509
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetPosition_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the position of the texture map. Setting the position translates
		/// the texture map by the amount specified.
		/// </summary>
		// Token: 0x0600F046 RID: 61510 RVA: 0x0014ED8D File Offset: 0x0014CF8D
		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetPosition_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F047 RID: 61511
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetPosition_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position of the texture map. Setting the position translates
		/// the texture map by the amount specified.
		/// </summary>
		// Token: 0x0600F048 RID: 61512 RVA: 0x0014ED9F File Offset: 0x0014CF9F
		public virtual void SetPosition(IntPtr _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetPosition_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F049 RID: 61513
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetScale_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the scale of the texture map. Scaling in performed independently
		/// on the r, s and t axes.
		/// </summary>
		// Token: 0x0600F04A RID: 61514 RVA: 0x0014EDAF File Offset: 0x0014CFAF
		public virtual void SetScale(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetScale_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F04B RID: 61515
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformTextureCoords_SetScale_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the scale of the texture map. Scaling in performed independently
		/// on the r, s and t axes.
		/// </summary>
		// Token: 0x0600F04C RID: 61516 RVA: 0x0014EDC1 File Offset: 0x0014CFC1
		public virtual void SetScale(IntPtr _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetScale_33(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001180 RID: 4480
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformTextureCoords";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001181 RID: 4481
		public new static readonly string MRClassNameKey = "class vtkTransformTextureCoords";
	}
}
