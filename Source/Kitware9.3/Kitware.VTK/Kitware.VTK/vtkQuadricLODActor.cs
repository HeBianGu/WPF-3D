using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadricLODActor
	/// </summary>
	/// <remarks>
	///    a specific level-of-detail strategy using the
	/// quadric clustering decimation algorithm
	///
	/// vtkQuadricLODActor implements a specific strategy for level-of-detail
	/// using the vtkQuadricClustering decimation algorithm. It supports only two
	/// levels of detail: full resolution and a decimated version. The decimated
	/// LOD is generated using a tuned strategy to produce output consistent with
	/// the requested interactive frame rate (i.e., the
	/// vtkRenderWindowInteractor's DesiredUpdateRate). It also makes use of
	/// display lists for performance, and adjusts the vtkQuadricClustering
	/// algorithm to take into account the dimensionality of the data (e.g., 2D,
	/// x-y surfaces may be binned into n x n x 1 to reduce extra polygons in the
	/// z-direction). Finally, the filter may optionally be set in "Static" mode
	/// (this works with the vtkMapper::SetStatic() method). `Enabling Static results
	/// in a one time execution of the Mapper's pipeline. After that, the pipeline
	/// no longer updated (unless manually forced to do so).
	///
	/// @warning
	/// By default the algorithm is set up to pre-compute the LODs. That is, on
	/// the first render (whether a full resolution render or interactive render)
	/// the LOD is computed. This behavior can be changed so that the LOD
	/// construction is deferred until the first interactive render. Either way,
	/// when the LOD is constructed, the user may notice a short pause.
	///
	/// @warning
	/// This class can be used as a direct replacement for vtkActor. It may also be
	/// used as a replacement for vtkFollower's (the ability to track a camera is
	/// provided).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLODActor vtkQuadricClustering
	/// </seealso>
	// Token: 0x020000FA RID: 250
	public class vtkQuadricLODActor : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003349 RID: 13129 RVA: 0x0004B82F File Offset: 0x00049A2F
		static vtkQuadricLODActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadricLODActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricLODActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600334A RID: 13130 RVA: 0x0004B857 File Offset: 0x00049A57
		public vtkQuadricLODActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600334B RID: 13131
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricLODActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a vtkQuadricLODActor.
		/// </summary>
		// Token: 0x0600334C RID: 13132 RVA: 0x0004B868 File Offset: 0x00049A68
		public new static vtkQuadricLODActor New()
		{
			vtkQuadricLODActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a vtkQuadricLODActor.
		/// </summary>
		// Token: 0x0600334D RID: 13133 RVA: 0x0004B8BC File Offset: 0x00049ABC
		public vtkQuadricLODActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadricLODActor.vtkQuadricLODActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600334E RID: 13134 RVA: 0x0004B900 File Offset: 0x00049B00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600334F RID: 13135
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_DeferLODConstructionOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to build the LOD immediately (i.e., on the first render)
		/// or to wait until the LOD is requested in a subsequent render. By default,
		/// LOD construction is not deferred (DeferLODConstruction is false).
		/// </summary>
		// Token: 0x06003350 RID: 13136 RVA: 0x0004B90B File Offset: 0x00049B0B
		public virtual void DeferLODConstructionOff()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_DeferLODConstructionOff_01(base.GetCppThis());
		}

		// Token: 0x06003351 RID: 13137
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_DeferLODConstructionOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to build the LOD immediately (i.e., on the first render)
		/// or to wait until the LOD is requested in a subsequent render. By default,
		/// LOD construction is not deferred (DeferLODConstruction is false).
		/// </summary>
		// Token: 0x06003352 RID: 13138 RVA: 0x0004B91A File Offset: 0x00049B1A
		public virtual void DeferLODConstructionOn()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_DeferLODConstructionOn_02(base.GetCppThis());
		}

		// Token: 0x06003353 RID: 13139
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricLODActor_GetCamera_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera to follow. This method is only applicable when the
		/// prop type is set to a vtkFollower.
		/// </summary>
		// Token: 0x06003354 RID: 13140 RVA: 0x0004B92C File Offset: 0x00049B2C
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_GetCamera_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x06003355 RID: 13141
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatio_04(HandleRef pThis);

		/// <summary>
		/// If the data configuration is set to UNKNOWN, this class attempts to
		/// figure out the dimensionality of the data using CollapseDimensionRatio.
		/// This ivar is the ratio of short edge of the input bounding box to its
		/// long edge, which is then used to collapse the data dimension (and set the
		/// quadric bin size in that direction to one). By default, this value is 0.05.
		/// </summary>
		// Token: 0x06003356 RID: 13142 RVA: 0x0004B99C File Offset: 0x00049B9C
		public virtual double GetCollapseDimensionRatio()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetCollapseDimensionRatio_04(base.GetCppThis());
		}

		// Token: 0x06003357 RID: 13143
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatioMaxValue_05(HandleRef pThis);

		/// <summary>
		/// If the data configuration is set to UNKNOWN, this class attempts to
		/// figure out the dimensionality of the data using CollapseDimensionRatio.
		/// This ivar is the ratio of short edge of the input bounding box to its
		/// long edge, which is then used to collapse the data dimension (and set the
		/// quadric bin size in that direction to one). By default, this value is 0.05.
		/// </summary>
		// Token: 0x06003358 RID: 13144 RVA: 0x0004B9BC File Offset: 0x00049BBC
		public virtual double GetCollapseDimensionRatioMaxValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetCollapseDimensionRatioMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06003359 RID: 13145
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatioMinValue_06(HandleRef pThis);

		/// <summary>
		/// If the data configuration is set to UNKNOWN, this class attempts to
		/// figure out the dimensionality of the data using CollapseDimensionRatio.
		/// This ivar is the ratio of short edge of the input bounding box to its
		/// long edge, which is then used to collapse the data dimension (and set the
		/// quadric bin size in that direction to one). By default, this value is 0.05.
		/// </summary>
		// Token: 0x0600335A RID: 13146 RVA: 0x0004B9DC File Offset: 0x00049BDC
		public virtual double GetCollapseDimensionRatioMinValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetCollapseDimensionRatioMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600335B RID: 13147
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetDataConfiguration_07(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x0600335C RID: 13148 RVA: 0x0004B9FC File Offset: 0x00049BFC
		public virtual int GetDataConfiguration()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDataConfiguration_07(base.GetCppThis());
		}

		// Token: 0x0600335D RID: 13149
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetDataConfigurationMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x0600335E RID: 13150 RVA: 0x0004BA1C File Offset: 0x00049C1C
		public virtual int GetDataConfigurationMaxValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDataConfigurationMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600335F RID: 13151
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetDataConfigurationMinValue_09(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x06003360 RID: 13152 RVA: 0x0004BA3C File Offset: 0x00049C3C
		public virtual int GetDataConfigurationMinValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDataConfigurationMinValue_09(base.GetCppThis());
		}

		// Token: 0x06003361 RID: 13153
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetDeferLODConstruction_10(HandleRef pThis);

		/// <summary>
		/// Specify whether to build the LOD immediately (i.e., on the first render)
		/// or to wait until the LOD is requested in a subsequent render. By default,
		/// LOD construction is not deferred (DeferLODConstruction is false).
		/// </summary>
		// Token: 0x06003362 RID: 13154 RVA: 0x0004BA5C File Offset: 0x00049C5C
		public virtual int GetDeferLODConstruction()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDeferLODConstruction_10(base.GetCppThis());
		}

		// Token: 0x06003363 RID: 13155
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricLODActor_GetLODFilter_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This class will create a vtkQuadricClustering algorithm automatically.
		/// However, if you would like to specify the filter to use, or to access it
		/// and configure it, these method provide access to the filter.
		/// </summary>
		// Token: 0x06003364 RID: 13156 RVA: 0x0004BA7C File Offset: 0x00049C7C
		public virtual vtkQuadricClustering GetLODFilter()
		{
			vtkQuadricClustering vtkQuadricClustering = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_GetLODFilter_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricClustering = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricClustering.Register(null);
				}
			}
			return vtkQuadricClustering;
		}

		// Token: 0x06003365 RID: 13157
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadricLODActor_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods.
		/// </summary>
		// Token: 0x06003366 RID: 13158 RVA: 0x0004BAEC File Offset: 0x00049CEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06003367 RID: 13159
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadricLODActor_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods.
		/// </summary>
		// Token: 0x06003368 RID: 13160 RVA: 0x0004BB0C File Offset: 0x00049D0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06003369 RID: 13161
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetPropType_14(HandleRef pThis);

		/// <summary>
		/// Indicate that this actor is actually a follower.
		/// By default, the prop type is a vtkActor.
		/// </summary>
		// Token: 0x0600336A RID: 13162 RVA: 0x0004BB28 File Offset: 0x00049D28
		public virtual int GetPropType()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetPropType_14(base.GetCppThis());
		}

		// Token: 0x0600336B RID: 13163
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetPropTypeMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Indicate that this actor is actually a follower.
		/// By default, the prop type is a vtkActor.
		/// </summary>
		// Token: 0x0600336C RID: 13164 RVA: 0x0004BB48 File Offset: 0x00049D48
		public virtual int GetPropTypeMaxValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetPropTypeMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600336D RID: 13165
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetPropTypeMinValue_16(HandleRef pThis);

		/// <summary>
		/// Indicate that this actor is actually a follower.
		/// By default, the prop type is a vtkActor.
		/// </summary>
		// Token: 0x0600336E RID: 13166 RVA: 0x0004BB68 File Offset: 0x00049D68
		public virtual int GetPropTypeMinValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetPropTypeMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600336F RID: 13167
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_GetStatic_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag to control whether the underlying pipeline is static.
		/// If static, this means that the data pipeline executes once and then not
		/// again until the user manually modifies this class. By default, Static is
		/// off because trying to debug this is tricky, and you should only use it
		/// when you know what you are doing.
		/// </summary>
		// Token: 0x06003370 RID: 13168 RVA: 0x0004BB88 File Offset: 0x00049D88
		public virtual int GetStatic()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetStatic_17(base.GetCppThis());
		}

		// Token: 0x06003371 RID: 13169
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods.
		/// </summary>
		// Token: 0x06003372 RID: 13170 RVA: 0x0004BBA8 File Offset: 0x00049DA8
		public override int IsA(string type)
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06003373 RID: 13171
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricLODActor_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods.
		/// </summary>
		// Token: 0x06003374 RID: 13172 RVA: 0x0004BBC8 File Offset: 0x00049DC8
		public new static int IsTypeOf(string type)
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_IsTypeOf_19(type);
		}

		// Token: 0x06003375 RID: 13173
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricLODActor_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard class methods.
		/// </summary>
		// Token: 0x06003376 RID: 13174 RVA: 0x0004BBE4 File Offset: 0x00049DE4
		public new vtkQuadricLODActor NewInstance()
		{
			vtkQuadricLODActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003377 RID: 13175
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_ReleaseGraphicsResources_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003378 RID: 13176 RVA: 0x0004BC40 File Offset: 0x00049E40
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_ReleaseGraphicsResources_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003379 RID: 13177
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_Render_23(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This causes the actor to be rendered. Depending on the frame rate request,
		/// it will use either a full resolution render or an interactive render (i.e.,
		/// it will use the decimated geometry).
		/// </summary>
		// Token: 0x0600337A RID: 13178 RVA: 0x0004BC70 File Offset: 0x00049E70
		public override void Render(vtkRenderer arg0, vtkMapper arg1)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_Render_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600337B RID: 13179
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricLODActor_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard class methods.
		/// </summary>
		// Token: 0x0600337C RID: 13180 RVA: 0x0004BCB4 File Offset: 0x00049EB4
		public new static vtkQuadricLODActor SafeDownCast(vtkObjectBase o)
		{
			vtkQuadricLODActor vtkQuadricLODActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricLODActor = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricLODActor.Register(null);
				}
			}
			return vtkQuadricLODActor;
		}

		// Token: 0x0600337D RID: 13181
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetCamera_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the camera to follow. This method is only applicable when the
		/// prop type is set to a vtkFollower.
		/// </summary>
		// Token: 0x0600337E RID: 13182 RVA: 0x0004BD34 File Offset: 0x00049F34
		public void SetCamera(vtkCamera arg0)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetCamera_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600337F RID: 13183
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetCollapseDimensionRatio_26(HandleRef pThis, double _arg);

		/// <summary>
		/// If the data configuration is set to UNKNOWN, this class attempts to
		/// figure out the dimensionality of the data using CollapseDimensionRatio.
		/// This ivar is the ratio of short edge of the input bounding box to its
		/// long edge, which is then used to collapse the data dimension (and set the
		/// quadric bin size in that direction to one). By default, this value is 0.05.
		/// </summary>
		// Token: 0x06003380 RID: 13184 RVA: 0x0004BD63 File Offset: 0x00049F63
		public virtual void SetCollapseDimensionRatio(double _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetCollapseDimensionRatio_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06003381 RID: 13185
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfiguration_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x06003382 RID: 13186 RVA: 0x0004BD73 File Offset: 0x00049F73
		public virtual void SetDataConfiguration(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfiguration_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06003383 RID: 13187
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToUnknown_28(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x06003384 RID: 13188 RVA: 0x0004BD83 File Offset: 0x00049F83
		public void SetDataConfigurationToUnknown()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToUnknown_28(base.GetCppThis());
		}

		// Token: 0x06003385 RID: 13189
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXLine_29(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x06003386 RID: 13190 RVA: 0x0004BD92 File Offset: 0x00049F92
		public void SetDataConfigurationToXLine()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXLine_29(base.GetCppThis());
		}

		// Token: 0x06003387 RID: 13191
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXYPlane_30(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x06003388 RID: 13192 RVA: 0x0004BDA1 File Offset: 0x00049FA1
		public void SetDataConfigurationToXYPlane()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXYPlane_30(base.GetCppThis());
		}

		// Token: 0x06003389 RID: 13193
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXYZVolume_31(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x0600338A RID: 13194 RVA: 0x0004BDB0 File Offset: 0x00049FB0
		public void SetDataConfigurationToXYZVolume()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXYZVolume_31(base.GetCppThis());
		}

		// Token: 0x0600338B RID: 13195
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXZPlane_32(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x0600338C RID: 13196 RVA: 0x0004BDBF File Offset: 0x00049FBF
		public void SetDataConfigurationToXZPlane()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXZPlane_32(base.GetCppThis());
		}

		// Token: 0x0600338D RID: 13197
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToYLine_33(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x0600338E RID: 13198 RVA: 0x0004BDCE File Offset: 0x00049FCE
		public void SetDataConfigurationToYLine()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToYLine_33(base.GetCppThis());
		}

		// Token: 0x0600338F RID: 13199
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToYZPlane_34(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x06003390 RID: 13200 RVA: 0x0004BDDD File Offset: 0x00049FDD
		public void SetDataConfigurationToYZPlane()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToYZPlane_34(base.GetCppThis());
		}

		// Token: 0x06003391 RID: 13201
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToZLine_35(HandleRef pThis);

		/// <summary>
		/// Force the binning of the quadric clustering according to application
		/// knowledge relative to the dimension of the data. For example, if you
		/// know your data lies in a 2D x-y plane, the performance of the quadric
		/// clustering algorithm can be greatly improved by indicating this (i.e.,
		/// the number of resulting triangles, and the quality of the decimation
		/// version is better). Setting this parameter forces the binning to be
		/// configured consistent with the dimnesionality of the data, and the
		/// collapse dimension ratio is ignored. Specifying the value of
		/// DataConfiguration to UNKNOWN (the default value) means that the class
		/// will attempt to figure the dimension of the class automatically using
		/// the CollapseDimensionRatio ivar.
		/// </summary>
		// Token: 0x06003392 RID: 13202 RVA: 0x0004BDEC File Offset: 0x00049FEC
		public void SetDataConfigurationToZLine()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToZLine_35(base.GetCppThis());
		}

		// Token: 0x06003393 RID: 13203
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetDeferLODConstruction_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to build the LOD immediately (i.e., on the first render)
		/// or to wait until the LOD is requested in a subsequent render. By default,
		/// LOD construction is not deferred (DeferLODConstruction is false).
		/// </summary>
		// Token: 0x06003394 RID: 13204 RVA: 0x0004BDFB File Offset: 0x00049FFB
		public virtual void SetDeferLODConstruction(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDeferLODConstruction_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06003395 RID: 13205
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetLODFilter_37(HandleRef pThis, HandleRef lodFilter);

		/// <summary>
		/// This class will create a vtkQuadricClustering algorithm automatically.
		/// However, if you would like to specify the filter to use, or to access it
		/// and configure it, these method provide access to the filter.
		/// </summary>
		// Token: 0x06003396 RID: 13206 RVA: 0x0004BE0C File Offset: 0x0004A00C
		public void SetLODFilter(vtkQuadricClustering lodFilter)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetLODFilter_37(base.GetCppThis(), (lodFilter == null) ? default(HandleRef) : lodFilter.GetCppThis());
		}

		// Token: 0x06003397 RID: 13207
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetPropType_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that this actor is actually a follower.
		/// By default, the prop type is a vtkActor.
		/// </summary>
		// Token: 0x06003398 RID: 13208 RVA: 0x0004BE3B File Offset: 0x0004A03B
		public virtual void SetPropType(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetPropType_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06003399 RID: 13209
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetPropTypeToActor_39(HandleRef pThis);

		/// <summary>
		/// Indicate that this actor is actually a follower.
		/// By default, the prop type is a vtkActor.
		/// </summary>
		// Token: 0x0600339A RID: 13210 RVA: 0x0004BE4B File Offset: 0x0004A04B
		public void SetPropTypeToActor()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetPropTypeToActor_39(base.GetCppThis());
		}

		// Token: 0x0600339B RID: 13211
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetPropTypeToFollower_40(HandleRef pThis);

		/// <summary>
		/// Indicate that this actor is actually a follower.
		/// By default, the prop type is a vtkActor.
		/// </summary>
		// Token: 0x0600339C RID: 13212 RVA: 0x0004BE5A File Offset: 0x0004A05A
		public void SetPropTypeToFollower()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetPropTypeToFollower_40(base.GetCppThis());
		}

		// Token: 0x0600339D RID: 13213
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_SetStatic_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off a flag to control whether the underlying pipeline is static.
		/// If static, this means that the data pipeline executes once and then not
		/// again until the user manually modifies this class. By default, Static is
		/// off because trying to debug this is tricky, and you should only use it
		/// when you know what you are doing.
		/// </summary>
		// Token: 0x0600339E RID: 13214 RVA: 0x0004BE69 File Offset: 0x0004A069
		public virtual void SetStatic(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetStatic_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600339F RID: 13215
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_ShallowCopy_42(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an LOD actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x060033A0 RID: 13216 RVA: 0x0004BE7C File Offset: 0x0004A07C
		public override void ShallowCopy(vtkProp prop)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_ShallowCopy_42(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060033A1 RID: 13217
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_StaticOff_43(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag to control whether the underlying pipeline is static.
		/// If static, this means that the data pipeline executes once and then not
		/// again until the user manually modifies this class. By default, Static is
		/// off because trying to debug this is tricky, and you should only use it
		/// when you know what you are doing.
		/// </summary>
		// Token: 0x060033A2 RID: 13218 RVA: 0x0004BEAB File Offset: 0x0004A0AB
		public virtual void StaticOff()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_StaticOff_43(base.GetCppThis());
		}

		// Token: 0x060033A3 RID: 13219
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricLODActor_StaticOn_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag to control whether the underlying pipeline is static.
		/// If static, this means that the data pipeline executes once and then not
		/// again until the user manually modifies this class. By default, Static is
		/// off because trying to debug this is tricky, and you should only use it
		/// when you know what you are doing.
		/// </summary>
		// Token: 0x060033A4 RID: 13220 RVA: 0x0004BEBA File Offset: 0x0004A0BA
		public virtual void StaticOn()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_StaticOn_44(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000618 RID: 1560
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricLODActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000619 RID: 1561
		public new static readonly string MRClassNameKey = "class vtkQuadricLODActor";

		/// <summary>
		/// Turn on/off a flag to control whether the underlying pipeline is static.
		/// If static, this means that the data pipeline executes once and then not
		/// again until the user manually modifies this class. By default, Static is
		/// off because trying to debug this is tricky, and you should only use it
		/// when you know what you are doing.
		/// </summary>
		// Token: 0x020000FB RID: 251
		public enum DataConfigurationEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400061B RID: 1563
			UNKNOWN,
			/// <summary>enum member</summary>
			// Token: 0x0400061C RID: 1564
			XLINE,
			/// <summary>enum member</summary>
			// Token: 0x0400061D RID: 1565
			XYPLANE = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400061E RID: 1566
			XYZVOLUME = 7,
			/// <summary>enum member</summary>
			// Token: 0x0400061F RID: 1567
			XZPLANE = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000620 RID: 1568
			YLINE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000621 RID: 1569
			YZPLANE = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000622 RID: 1570
			ZLINE = 3
		}

		/// <summary>
		/// This class will create a vtkQuadricClustering algorithm automatically.
		/// However, if you would like to specify the filter to use, or to access it
		/// and configure it, these method provide access to the filter.
		/// </summary>
		// Token: 0x020000FC RID: 252
		public enum PropTypeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000624 RID: 1572
			ACTOR = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000625 RID: 1573
			FOLLOWER = 0
		}
	}
}
