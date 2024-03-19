using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextureMapToPlane
	/// </summary>
	/// <remarks>
	///    generate texture coordinates by mapping points to plane
	///
	/// vtkTextureMapToPlane is a filter that generates 2D texture coordinates
	/// by mapping input dataset points onto a plane. The plane can either be
	/// user specified or generated automatically. (A least squares method is
	/// used to generate the plane automatically.)
	///
	/// There are two ways you can specify the plane. The first is to provide a
	/// plane normal. In this case the points are projected to a plane, and the
	/// points are then mapped into the user specified s-t coordinate range. For
	/// more control, you can specify a plane with three points: an origin and two
	/// points defining the two axes of the plane. (This is compatible with the
	/// vtkPlaneSource.) Using the second method, the SRange and TRange vectors
	/// are ignored, since the presumption is that the user does not want to scale
	/// the texture coordinates; and you can adjust the origin and axes points to
	/// achieve the texture coordinate scaling you need. Note also that using the
	/// three point method the axes do not have to be orthogonal.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkPlaneSource vtkTextureMapToCylinder
	/// vtkTextureMapToSphere vtkThresholdTextureCoords
	/// </seealso>
	// Token: 0x02000542 RID: 1346
	public class vtkTextureMapToPlane : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EF89 RID: 61321 RVA: 0x0014DFCB File Offset: 0x0014C1CB
		static vtkTextureMapToPlane()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureMapToPlane.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToPlane"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF8A RID: 61322 RVA: 0x0014DFF3 File Offset: 0x0014C1F3
		public vtkTextureMapToPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EF8B RID: 61323
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with s,t range=(0,1) and automatic plane generation turned on.
		/// </summary>
		// Token: 0x0600EF8C RID: 61324 RVA: 0x0014E004 File Offset: 0x0014C204
		public new static vtkTextureMapToPlane New()
		{
			vtkTextureMapToPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with s,t range=(0,1) and automatic plane generation turned on.
		/// </summary>
		// Token: 0x0600EF8D RID: 61325 RVA: 0x0014E058 File Offset: 0x0014C258
		public vtkTextureMapToPlane() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextureMapToPlane.vtkTextureMapToPlane_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF8E RID: 61326 RVA: 0x0014E09C File Offset: 0x0014C29C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EF8F RID: 61327
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_AutomaticPlaneGenerationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic plane generation.
		/// </summary>
		// Token: 0x0600EF90 RID: 61328 RVA: 0x0014E0A7 File Offset: 0x0014C2A7
		public virtual void AutomaticPlaneGenerationOff()
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_AutomaticPlaneGenerationOff_01(base.GetCppThis());
		}

		// Token: 0x0600EF91 RID: 61329
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_AutomaticPlaneGenerationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic plane generation.
		/// </summary>
		// Token: 0x0600EF92 RID: 61330 RVA: 0x0014E0B6 File Offset: 0x0014C2B6
		public virtual void AutomaticPlaneGenerationOn()
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_AutomaticPlaneGenerationOn_02(base.GetCppThis());
		}

		// Token: 0x0600EF93 RID: 61331
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToPlane_GetAutomaticPlaneGeneration_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic plane generation.
		/// </summary>
		// Token: 0x0600EF94 RID: 61332 RVA: 0x0014E0C8 File Offset: 0x0014C2C8
		public virtual int GetAutomaticPlaneGeneration()
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_GetAutomaticPlaneGeneration_03(base.GetCppThis());
		}

		// Token: 0x0600EF95 RID: 61333
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_GetNormal_04(HandleRef pThis);

		/// <summary>
		/// Specify plane normal. An alternative way to specify a map plane. Using
		/// this method, the object will scale the resulting texture coordinate
		/// between the SRange and TRange specified.
		/// </summary>
		// Token: 0x0600EF96 RID: 61334 RVA: 0x0014E0E8 File Offset: 0x0014C2E8
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EF97 RID: 61335
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_GetNormal_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify plane normal. An alternative way to specify a map plane. Using
		/// this method, the object will scale the resulting texture coordinate
		/// between the SRange and TRange specified.
		/// </summary>
		// Token: 0x0600EF98 RID: 61336 RVA: 0x0014E130 File Offset: 0x0014C330
		public virtual void GetNormal(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetNormal_05(base.GetCppThis(), data);
		}

		// Token: 0x0600EF99 RID: 61337
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextureMapToPlane_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF9A RID: 61338 RVA: 0x0014E140 File Offset: 0x0014C340
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600EF9B RID: 61339
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextureMapToPlane_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF9C RID: 61340 RVA: 0x0014E160 File Offset: 0x0014C360
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600EF9D RID: 61341
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_GetOrigin_08(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the origin of the plane. Used in conjunction with
		/// the Point1 and Point2 ivars to specify a map plane.
		/// </summary>
		// Token: 0x0600EF9E RID: 61342 RVA: 0x0014E17C File Offset: 0x0014C37C
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetOrigin_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EF9F RID: 61343
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_GetOrigin_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the origin of the plane. Used in conjunction with
		/// the Point1 and Point2 ivars to specify a map plane.
		/// </summary>
		// Token: 0x0600EFA0 RID: 61344 RVA: 0x0014E1C4 File Offset: 0x0014C3C4
		public virtual void GetOrigin(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetOrigin_09(base.GetCppThis(), data);
		}

		// Token: 0x0600EFA1 RID: 61345
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_GetPoint1_10(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x0600EFA2 RID: 61346 RVA: 0x0014E1D4 File Offset: 0x0014C3D4
		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint1_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EFA3 RID: 61347
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_GetPoint1_11(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x0600EFA4 RID: 61348 RVA: 0x0014E21C File Offset: 0x0014C41C
		public virtual void GetPoint1(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint1_11(base.GetCppThis(), data);
		}

		// Token: 0x0600EFA5 RID: 61349
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_GetPoint2_12(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x0600EFA6 RID: 61350 RVA: 0x0014E22C File Offset: 0x0014C42C
		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint2_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EFA7 RID: 61351
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_GetPoint2_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x0600EFA8 RID: 61352 RVA: 0x0014E274 File Offset: 0x0014C474
		public virtual void GetPoint2(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint2_13(base.GetCppThis(), data);
		}

		// Token: 0x0600EFA9 RID: 61353
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_GetSRange_14(HandleRef pThis);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFAA RID: 61354 RVA: 0x0014E284 File Offset: 0x0014C484
		public virtual double[] GetSRange()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetSRange_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EFAB RID: 61355
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_GetSRange_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFAC RID: 61356 RVA: 0x0014E2CC File Offset: 0x0014C4CC
		public virtual void GetSRange(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetSRange_15(base.GetCppThis(), data);
		}

		// Token: 0x0600EFAD RID: 61357
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_GetTRange_16(HandleRef pThis);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFAE RID: 61358 RVA: 0x0014E2DC File Offset: 0x0014C4DC
		public virtual double[] GetTRange()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetTRange_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EFAF RID: 61359
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_GetTRange_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFB0 RID: 61360 RVA: 0x0014E324 File Offset: 0x0014C524
		public virtual void GetTRange(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetTRange_17(base.GetCppThis(), data);
		}

		// Token: 0x0600EFB1 RID: 61361
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToPlane_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFB2 RID: 61362 RVA: 0x0014E334 File Offset: 0x0014C534
		public override int IsA(string type)
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600EFB3 RID: 61363
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToPlane_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFB4 RID: 61364 RVA: 0x0014E354 File Offset: 0x0014C554
		public new static int IsTypeOf(string type)
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_IsTypeOf_19(type);
		}

		// Token: 0x0600EFB5 RID: 61365
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFB6 RID: 61366 RVA: 0x0014E370 File Offset: 0x0014C570
		public new vtkTextureMapToPlane NewInstance()
		{
			vtkTextureMapToPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EFB7 RID: 61367
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToPlane_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EFB8 RID: 61368 RVA: 0x0014E3CC File Offset: 0x0014C5CC
		public new static vtkTextureMapToPlane SafeDownCast(vtkObjectBase o)
		{
			vtkTextureMapToPlane vtkTextureMapToPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureMapToPlane = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureMapToPlane.Register(null);
				}
			}
			return vtkTextureMapToPlane;
		}

		// Token: 0x0600EFB9 RID: 61369
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetAutomaticPlaneGeneration_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off automatic plane generation.
		/// </summary>
		// Token: 0x0600EFBA RID: 61370 RVA: 0x0014E44B File Offset: 0x0014C64B
		public virtual void SetAutomaticPlaneGeneration(int _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetAutomaticPlaneGeneration_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFBB RID: 61371
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetNormal_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify plane normal. An alternative way to specify a map plane. Using
		/// this method, the object will scale the resulting texture coordinate
		/// between the SRange and TRange specified.
		/// </summary>
		// Token: 0x0600EFBC RID: 61372 RVA: 0x0014E45B File Offset: 0x0014C65B
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetNormal_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EFBD RID: 61373
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetNormal_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify plane normal. An alternative way to specify a map plane. Using
		/// this method, the object will scale the resulting texture coordinate
		/// between the SRange and TRange specified.
		/// </summary>
		// Token: 0x0600EFBE RID: 61374 RVA: 0x0014E46D File Offset: 0x0014C66D
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetNormal_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFBF RID: 61375
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetOrigin_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point defining the origin of the plane. Used in conjunction with
		/// the Point1 and Point2 ivars to specify a map plane.
		/// </summary>
		// Token: 0x0600EFC0 RID: 61376 RVA: 0x0014E47D File Offset: 0x0014C67D
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetOrigin_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EFC1 RID: 61377
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetOrigin_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point defining the origin of the plane. Used in conjunction with
		/// the Point1 and Point2 ivars to specify a map plane.
		/// </summary>
		// Token: 0x0600EFC2 RID: 61378 RVA: 0x0014E48F File Offset: 0x0014C68F
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetOrigin_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFC3 RID: 61379
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetPoint1_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x0600EFC4 RID: 61380 RVA: 0x0014E49F File Offset: 0x0014C69F
		public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint1_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EFC5 RID: 61381
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetPoint1_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point defining the first axis of the plane.
		/// </summary>
		// Token: 0x0600EFC6 RID: 61382 RVA: 0x0014E4B1 File Offset: 0x0014C6B1
		public virtual void SetPoint1(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint1_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFC7 RID: 61383
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetPoint2_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x0600EFC8 RID: 61384 RVA: 0x0014E4C1 File Offset: 0x0014C6C1
		public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint2_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EFC9 RID: 61385
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetPoint2_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point defining the second axis of the plane.
		/// </summary>
		// Token: 0x0600EFCA RID: 61386 RVA: 0x0014E4D3 File Offset: 0x0014C6D3
		public virtual void SetPoint2(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint2_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFCB RID: 61387
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetSRange_32(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFCC RID: 61388 RVA: 0x0014E4E3 File Offset: 0x0014C6E3
		public virtual void SetSRange(double _arg1, double _arg2)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetSRange_32(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600EFCD RID: 61389
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetSRange_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify s-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFCE RID: 61390 RVA: 0x0014E4F4 File Offset: 0x0014C6F4
		public void SetSRange(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetSRange_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EFCF RID: 61391
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetTRange_34(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFD0 RID: 61392 RVA: 0x0014E504 File Offset: 0x0014C704
		public virtual void SetTRange(double _arg1, double _arg2)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetTRange_34(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600EFD1 RID: 61393
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToPlane_SetTRange_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify t-coordinate range for texture s-t coordinate pair.
		/// </summary>
		// Token: 0x0600EFD2 RID: 61394 RVA: 0x0014E515 File Offset: 0x0014C715
		public void SetTRange(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetTRange_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400117C RID: 4476
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToPlane";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400117D RID: 4477
		public new static readonly string MRClassNameKey = "class vtkTextureMapToPlane";
	}
}
