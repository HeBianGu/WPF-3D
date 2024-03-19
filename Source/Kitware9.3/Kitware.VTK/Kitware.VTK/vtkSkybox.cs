using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkSkybox
	/// </summary>
	/// <remarks>
	///  Renders a skybox environment
	///
	/// You must provide a texture cube map using the SetTexture method.
	/// </remarks>
	// Token: 0x020005C9 RID: 1481
	public class vtkSkybox : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010321 RID: 66337 RVA: 0x00168DE7 File Offset: 0x00166FE7
		static vtkSkybox()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSkybox.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSkybox"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010322 RID: 66338 RVA: 0x00168E0F File Offset: 0x0016700F
		public vtkSkybox(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010323 RID: 66339
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSkybox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010324 RID: 66340 RVA: 0x00168E20 File Offset: 0x00167020
		public new static vtkSkybox New()
		{
			vtkSkybox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSkybox.vtkSkybox_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSkybox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010325 RID: 66341 RVA: 0x00168E74 File Offset: 0x00167074
		public vtkSkybox() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSkybox.vtkSkybox_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010326 RID: 66342 RVA: 0x00168EB8 File Offset: 0x001670B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010327 RID: 66343
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_GammaCorrectOff_01(HandleRef pThis);

		/// <summary>
		/// Define if the colors should be gamma corrected.
		/// This is generally required if the input texture is in linear color space.
		/// Default is off.
		/// </summary>
		// Token: 0x06010328 RID: 66344 RVA: 0x00168EC3 File Offset: 0x001670C3
		public virtual void GammaCorrectOff()
		{
			vtkSkybox.vtkSkybox_GammaCorrectOff_01(base.GetCppThis());
		}

		// Token: 0x06010329 RID: 66345
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_GammaCorrectOn_02(HandleRef pThis);

		/// <summary>
		/// Define if the colors should be gamma corrected.
		/// This is generally required if the input texture is in linear color space.
		/// Default is off.
		/// </summary>
		// Token: 0x0601032A RID: 66346 RVA: 0x00168ED2 File Offset: 0x001670D2
		public virtual void GammaCorrectOn()
		{
			vtkSkybox.vtkSkybox_GammaCorrectOn_02(base.GetCppThis());
		}

		// Token: 0x0601032B RID: 66347
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSkybox_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
		/// method GetBounds(double bounds[6]) is available from the superclass.)
		/// </summary>
		// Token: 0x0601032C RID: 66348 RVA: 0x00168EE4 File Offset: 0x001670E4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSkybox.vtkSkybox_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601032D RID: 66349
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSkybox_GetFloorPlane_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x0601032E RID: 66350 RVA: 0x00168F2C File Offset: 0x0016712C
		public virtual float[] GetFloorPlane()
		{
			IntPtr intPtr = vtkSkybox.vtkSkybox_GetFloorPlane_04(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601032F RID: 66351
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_GetFloorPlane_05(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x06010330 RID: 66352 RVA: 0x00168F74 File Offset: 0x00167174
		public virtual void GetFloorPlane(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkSkybox.vtkSkybox_GetFloorPlane_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06010331 RID: 66353
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_GetFloorPlane_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x06010332 RID: 66354 RVA: 0x00168F88 File Offset: 0x00167188
		public virtual void GetFloorPlane(IntPtr _arg)
		{
			vtkSkybox.vtkSkybox_GetFloorPlane_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06010333 RID: 66355
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSkybox_GetFloorRight_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x06010334 RID: 66356 RVA: 0x00168F98 File Offset: 0x00167198
		public virtual float[] GetFloorRight()
		{
			IntPtr intPtr = vtkSkybox.vtkSkybox_GetFloorRight_07(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010335 RID: 66357
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_GetFloorRight_08(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x06010336 RID: 66358 RVA: 0x00168FE0 File Offset: 0x001671E0
		public virtual void GetFloorRight(ref float _arg1, ref float _arg2, ref float _arg3)
		{
			vtkSkybox.vtkSkybox_GetFloorRight_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06010337 RID: 66359
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_GetFloorRight_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x06010338 RID: 66360 RVA: 0x00168FF2 File Offset: 0x001671F2
		public virtual void GetFloorRight(IntPtr _arg)
		{
			vtkSkybox.vtkSkybox_GetFloorRight_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06010339 RID: 66361
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSkybox_GetGammaCorrect_10(HandleRef pThis);

		/// <summary>
		/// Define if the colors should be gamma corrected.
		/// This is generally required if the input texture is in linear color space.
		/// Default is off.
		/// </summary>
		// Token: 0x0601033A RID: 66362 RVA: 0x00169004 File Offset: 0x00167204
		public virtual bool GetGammaCorrect()
		{
			return vtkSkybox.vtkSkybox_GetGammaCorrect_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601033B RID: 66363
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSkybox_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601033C RID: 66364 RVA: 0x0016902C File Offset: 0x0016722C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSkybox.vtkSkybox_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601033D RID: 66365
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSkybox_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601033E RID: 66366 RVA: 0x0016904C File Offset: 0x0016724C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSkybox.vtkSkybox_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601033F RID: 66367
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSkybox_GetProjection_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the projection to be used
		/// </summary>
		// Token: 0x06010340 RID: 66368 RVA: 0x00169068 File Offset: 0x00167268
		public virtual int GetProjection()
		{
			return vtkSkybox.vtkSkybox_GetProjection_13(base.GetCppThis());
		}

		// Token: 0x06010341 RID: 66369
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSkybox_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010342 RID: 66370 RVA: 0x00169088 File Offset: 0x00167288
		public override int IsA(string type)
		{
			return vtkSkybox.vtkSkybox_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06010343 RID: 66371
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSkybox_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010344 RID: 66372 RVA: 0x001690A8 File Offset: 0x001672A8
		public new static int IsTypeOf(string type)
		{
			return vtkSkybox.vtkSkybox_IsTypeOf_15(type);
		}

		// Token: 0x06010345 RID: 66373
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSkybox_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010346 RID: 66374 RVA: 0x001690C4 File Offset: 0x001672C4
		public new vtkSkybox NewInstance()
		{
			vtkSkybox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSkybox.vtkSkybox_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSkybox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010347 RID: 66375
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSkybox_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010348 RID: 66376 RVA: 0x00169120 File Offset: 0x00167320
		public new static vtkSkybox SafeDownCast(vtkObjectBase o)
		{
			vtkSkybox vtkSkybox = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSkybox.vtkSkybox_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSkybox = (vtkSkybox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSkybox.Register(null);
				}
			}
			return vtkSkybox;
		}

		// Token: 0x06010349 RID: 66377
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetFloorPlane_19(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x0601034A RID: 66378 RVA: 0x0016919F File Offset: 0x0016739F
		public virtual void SetFloorPlane(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkSkybox.vtkSkybox_SetFloorPlane_19(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0601034B RID: 66379
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetFloorPlane_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x0601034C RID: 66380 RVA: 0x001691B3 File Offset: 0x001673B3
		public virtual void SetFloorPlane(IntPtr _arg)
		{
			vtkSkybox.vtkSkybox_SetFloorPlane_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601034D RID: 66381
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetFloorRight_21(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x0601034E RID: 66382 RVA: 0x001691C3 File Offset: 0x001673C3
		public virtual void SetFloorRight(float _arg1, float _arg2, float _arg3)
		{
			vtkSkybox.vtkSkybox_SetFloorRight_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601034F RID: 66383
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetFloorRight_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the plane equation for the floor.
		/// </summary>
		// Token: 0x06010350 RID: 66384 RVA: 0x001691D5 File Offset: 0x001673D5
		public virtual void SetFloorRight(IntPtr _arg)
		{
			vtkSkybox.vtkSkybox_SetFloorRight_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06010351 RID: 66385
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetGammaCorrect_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Define if the colors should be gamma corrected.
		/// This is generally required if the input texture is in linear color space.
		/// Default is off.
		/// </summary>
		// Token: 0x06010352 RID: 66386 RVA: 0x001691E5 File Offset: 0x001673E5
		public virtual void SetGammaCorrect(bool _arg)
		{
			vtkSkybox.vtkSkybox_SetGammaCorrect_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010353 RID: 66387
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetProjection_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the projection to be used
		/// </summary>
		// Token: 0x06010354 RID: 66388 RVA: 0x001691FD File Offset: 0x001673FD
		public virtual void SetProjection(int _arg)
		{
			vtkSkybox.vtkSkybox_SetProjection_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06010355 RID: 66389
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetProjectionToCube_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the projection to be used
		/// </summary>
		// Token: 0x06010356 RID: 66390 RVA: 0x0016920D File Offset: 0x0016740D
		public void SetProjectionToCube()
		{
			vtkSkybox.vtkSkybox_SetProjectionToCube_25(base.GetCppThis());
		}

		// Token: 0x06010357 RID: 66391
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetProjectionToFloor_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the projection to be used
		/// </summary>
		// Token: 0x06010358 RID: 66392 RVA: 0x0016921C File Offset: 0x0016741C
		public void SetProjectionToFloor()
		{
			vtkSkybox.vtkSkybox_SetProjectionToFloor_26(base.GetCppThis());
		}

		// Token: 0x06010359 RID: 66393
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetProjectionToSphere_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the projection to be used
		/// </summary>
		// Token: 0x0601035A RID: 66394 RVA: 0x0016922B File Offset: 0x0016742B
		public void SetProjectionToSphere()
		{
			vtkSkybox.vtkSkybox_SetProjectionToSphere_27(base.GetCppThis());
		}

		// Token: 0x0601035B RID: 66395
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSkybox_SetProjectionToStereoSphere_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the projection to be used
		/// </summary>
		// Token: 0x0601035C RID: 66396 RVA: 0x0016923A File Offset: 0x0016743A
		public void SetProjectionToStereoSphere()
		{
			vtkSkybox.vtkSkybox_SetProjectionToStereoSphere_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012D4 RID: 4820
		public new const string MRFullTypeName = "Kitware.VTK.vtkSkybox";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012D5 RID: 4821
		public new static readonly string MRClassNameKey = "class vtkSkybox";

		/// <summary>
		/// Set/Get the projection to be used
		/// </summary>
		// Token: 0x020005CA RID: 1482
		public enum Projection
		{
			/// <summary>enum member</summary>
			// Token: 0x040012D7 RID: 4823
			Cube,
			/// <summary>enum member</summary>
			// Token: 0x040012D8 RID: 4824
			Floor = 2,
			/// <summary>enum member</summary>
			// Token: 0x040012D9 RID: 4825
			Sphere = 1,
			/// <summary>enum member</summary>
			// Token: 0x040012DA RID: 4826
			StereoSphere = 3
		}
	}
}
