using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkActor
	/// </summary>
	/// <remarks>
	///    represents an object (geometry &amp; properties) in a rendered scene
	///
	///
	/// vtkActor is used to represent an entity in a rendering scene.  It inherits
	/// functions related to the actors position, and orientation from
	/// vtkProp3D. The actor also has scaling and maintains a reference to the
	/// defining geometry (i.e., the mapper), rendering properties, and possibly a
	/// texture map. vtkActor combines these instance variables into one 4x4
	/// transformation matrix as follows: [x y z 1] = [x y z 1] Translate(-origin)
	/// Scale(scale) Rot(y) Rot(x) Rot (z) Trans(origin) Trans(position)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProperty vtkTexture vtkMapper vtkAssembly vtkFollower vtkLODActor
	/// </seealso>
	// Token: 0x020000B7 RID: 183
	public class vtkActor : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002834 RID: 10292 RVA: 0x0003B48B File Offset: 0x0003968B
		static vtkActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002835 RID: 10293 RVA: 0x0003B4B3 File Offset: 0x000396B3
		public vtkActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002836 RID: 10294
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates an actor with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0). No user defined matrix and no texture map.
		/// </summary>
		// Token: 0x06002837 RID: 10295 RVA: 0x0003B4C4 File Offset: 0x000396C4
		public new static vtkActor New()
		{
			vtkActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates an actor with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0). No user defined matrix and no texture map.
		/// </summary>
		// Token: 0x06002838 RID: 10296 RVA: 0x0003B518 File Offset: 0x00039718
		public vtkActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkActor.vtkActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002839 RID: 10297 RVA: 0x0003B55C File Offset: 0x0003975C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600283A RID: 10298
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_ApplyProperties_01(HandleRef pThis);

		/// <summary>
		/// Apply the current properties to all parts that compose this actor.
		/// This method is overloaded in vtkAssembly to apply the assemblies'
		/// properties to all its parts in a recursive manner. Typically the
		/// use of this method is to set the desired properties in the assembly,
		/// and then push the properties down to the assemblies parts with
		/// ApplyProperties().
		/// </summary>
		// Token: 0x0600283B RID: 10299 RVA: 0x0003B567 File Offset: 0x00039767
		public virtual void ApplyProperties()
		{
			vtkActor.vtkActor_ApplyProperties_01(base.GetCppThis());
		}

		// Token: 0x0600283C RID: 10300
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_ForceOpaqueOff_02(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x0600283D RID: 10301 RVA: 0x0003B576 File Offset: 0x00039776
		public virtual void ForceOpaqueOff()
		{
			vtkActor.vtkActor_ForceOpaqueOff_02(base.GetCppThis());
		}

		// Token: 0x0600283E RID: 10302
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_ForceOpaqueOn_03(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x0600283F RID: 10303 RVA: 0x0003B585 File Offset: 0x00039785
		public virtual void ForceOpaqueOn()
		{
			vtkActor.vtkActor_ForceOpaqueOn_03(base.GetCppThis());
		}

		// Token: 0x06002840 RID: 10304
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_ForceTranslucentOff_04(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x06002841 RID: 10305 RVA: 0x0003B594 File Offset: 0x00039794
		public virtual void ForceTranslucentOff()
		{
			vtkActor.vtkActor_ForceTranslucentOff_04(base.GetCppThis());
		}

		// Token: 0x06002842 RID: 10306
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_ForceTranslucentOn_05(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x06002843 RID: 10307 RVA: 0x0003B5A3 File Offset: 0x000397A3
		public virtual void ForceTranslucentOn()
		{
			vtkActor.vtkActor_ForceTranslucentOn_05(base.GetCppThis());
		}

		// Token: 0x06002844 RID: 10308
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_GetActors_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x06002845 RID: 10309 RVA: 0x0003B5B4 File Offset: 0x000397B4
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkActor.vtkActor_GetActors_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002846 RID: 10310
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_GetBackfaceProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the property object that controls this actors backface surface
		/// properties.  This should be an instance of a vtkProperty object. If one
		/// isn't specified, then the front face properties will be used.  Multiple
		/// actors can share one property object.
		/// </summary>
		// Token: 0x06002847 RID: 10311 RVA: 0x0003B5E4 File Offset: 0x000397E4
		public virtual vtkProperty GetBackfaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_GetBackfaceProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06002848 RID: 10312
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_GetBounds_08(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
		/// method GetBounds(double bounds[6]) is available from the superclass.)
		/// </summary>
		// Token: 0x06002849 RID: 10313 RVA: 0x0003B654 File Offset: 0x00039854
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkActor.vtkActor_GetBounds_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600284A RID: 10314
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkActor_GetForceOpaque_09(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x0600284B RID: 10315 RVA: 0x0003B69C File Offset: 0x0003989C
		public virtual bool GetForceOpaque()
		{
			return vtkActor.vtkActor_GetForceOpaque_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600284C RID: 10316
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkActor_GetForceTranslucent_10(HandleRef pThis);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x0600284D RID: 10317 RVA: 0x0003B6C4 File Offset: 0x000398C4
		public virtual bool GetForceTranslucent()
		{
			return vtkActor.vtkActor_GetForceTranslucent_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600284E RID: 10318
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkActor_GetMTime_11(HandleRef pThis);

		/// <summary>
		/// Get the actors mtime plus consider its properties and texture if set.
		/// </summary>
		// Token: 0x0600284F RID: 10319 RVA: 0x0003B6EC File Offset: 0x000398EC
		public override ulong GetMTime()
		{
			return vtkActor.vtkActor_GetMTime_11(base.GetCppThis());
		}

		// Token: 0x06002850 RID: 10320
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_GetMapper_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the Mapper that this actor is getting its data from.
		/// </summary>
		// Token: 0x06002851 RID: 10321 RVA: 0x0003B70C File Offset: 0x0003990C
		public virtual vtkMapper GetMapper()
		{
			vtkMapper vtkMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_GetMapper_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper = (vtkMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper.Register(null);
				}
			}
			return vtkMapper;
		}

		// Token: 0x06002852 RID: 10322
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActor_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002853 RID: 10323 RVA: 0x0003B77C File Offset: 0x0003997C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkActor.vtkActor_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06002854 RID: 10324
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActor_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002855 RID: 10325 RVA: 0x0003B79C File Offset: 0x0003999C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkActor.vtkActor_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06002856 RID: 10326
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_GetProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the property object that controls this actors surface
		/// properties.  This should be an instance of a vtkProperty object.  Every
		/// actor must have a property associated with it.  If one isn't specified,
		/// then one will be generated automatically. Multiple actors can share one
		/// property object.
		/// </summary>
		// Token: 0x06002857 RID: 10327 RVA: 0x0003B7B8 File Offset: 0x000399B8
		public vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_GetProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06002858 RID: 10328
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkActor_GetRedrawMTime_16(HandleRef pThis);

		/// <summary>
		/// Return the mtime of anything that would cause the rendered image to
		/// appear differently. Usually this involves checking the mtime of the
		/// prop plus anything else it depends on such as properties, textures,
		/// etc.
		/// </summary>
		// Token: 0x06002859 RID: 10329 RVA: 0x0003B828 File Offset: 0x00039A28
		public override ulong GetRedrawMTime()
		{
			return vtkActor.vtkActor_GetRedrawMTime_16(base.GetCppThis());
		}

		// Token: 0x0600285A RID: 10330
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkActor_GetSupportsSelection_17(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		/// </summary>
		// Token: 0x0600285B RID: 10331 RVA: 0x0003B848 File Offset: 0x00039A48
		public override bool GetSupportsSelection()
		{
			return vtkActor.vtkActor_GetSupportsSelection_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600285C RID: 10332
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_GetTexture_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the texture object to control rendering texture maps.  This will
		/// be a vtkTexture object. An actor does not need to have an associated
		/// texture map and multiple actors can share one texture.
		/// </summary>
		// Token: 0x0600285D RID: 10333 RVA: 0x0003B870 File Offset: 0x00039A70
		public virtual vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_GetTexture_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x0600285E RID: 10334
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor_HasOpaqueGeometry_19(HandleRef pThis);

		/// <summary>
		/// Does this prop have some opaque/translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600285F RID: 10335 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		public override int HasOpaqueGeometry()
		{
			return vtkActor.vtkActor_HasOpaqueGeometry_19(base.GetCppThis());
		}

		// Token: 0x06002860 RID: 10336
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

		/// <summary>
		/// Does this prop have some opaque/translucent polygonal geometry?
		/// </summary>
		// Token: 0x06002861 RID: 10337 RVA: 0x0003B900 File Offset: 0x00039B00
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkActor.vtkActor_HasTranslucentPolygonalGeometry_20(base.GetCppThis());
		}

		// Token: 0x06002862 RID: 10338
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002863 RID: 10339 RVA: 0x0003B920 File Offset: 0x00039B20
		public override int IsA(string type)
		{
			return vtkActor.vtkActor_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06002864 RID: 10340
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkActor_IsRenderingTranslucentPolygonalGeometry_22(HandleRef pThis);

		/// <summary>
		/// allows a prop to update a selections color buffers
		/// Default just forwards to the Mapper
		/// </summary>
		// Token: 0x06002865 RID: 10341 RVA: 0x0003B940 File Offset: 0x00039B40
		public override bool IsRenderingTranslucentPolygonalGeometry()
		{
			return vtkActor.vtkActor_IsRenderingTranslucentPolygonalGeometry_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06002866 RID: 10342
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002867 RID: 10343 RVA: 0x0003B968 File Offset: 0x00039B68
		public new static int IsTypeOf(string type)
		{
			return vtkActor.vtkActor_IsTypeOf_23(type);
		}

		// Token: 0x06002868 RID: 10344
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_MakeProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new property suitable for use with this type of Actor.
		/// For example, a vtkMesaActor should create a vtkMesaProperty
		/// in this function.   The default is to just call vtkProperty::New.
		/// </summary>
		// Token: 0x06002869 RID: 10345 RVA: 0x0003B984 File Offset: 0x00039B84
		public virtual vtkProperty MakeProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_MakeProperty_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600286A RID: 10346
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600286B RID: 10347 RVA: 0x0003B9F4 File Offset: 0x00039BF4
		public new vtkActor NewInstance()
		{
			vtkActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600286C RID: 10348
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600286D RID: 10349 RVA: 0x0003BA50 File Offset: 0x00039C50
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkActor.vtkActor_ReleaseGraphicsResources_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600286E RID: 10350
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_Render_28(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically. Note that a side
		/// effect of this method is that the pipeline will be updated.
		/// </summary>
		// Token: 0x0600286F RID: 10351 RVA: 0x0003BA80 File Offset: 0x00039C80
		public virtual void Render(vtkRenderer arg0, vtkMapper arg1)
		{
			vtkActor.vtkActor_Render_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002870 RID: 10352
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor_RenderOpaqueGeometry_29(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06002871 RID: 10353 RVA: 0x0003BAC4 File Offset: 0x00039CC4
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkActor.vtkActor_RenderOpaqueGeometry_29(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06002872 RID: 10354
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06002873 RID: 10355 RVA: 0x0003BAF8 File Offset: 0x00039CF8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkActor.vtkActor_RenderTranslucentPolygonalGeometry_30(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06002874 RID: 10356
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002875 RID: 10357 RVA: 0x0003BB2C File Offset: 0x00039D2C
		public new static vtkActor SafeDownCast(vtkObjectBase o)
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor.vtkActor_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06002876 RID: 10358
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_SetBackfaceProperty_32(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Set/Get the property object that controls this actors backface surface
		/// properties.  This should be an instance of a vtkProperty object. If one
		/// isn't specified, then the front face properties will be used.  Multiple
		/// actors can share one property object.
		/// </summary>
		// Token: 0x06002877 RID: 10359 RVA: 0x0003BBAC File Offset: 0x00039DAC
		public void SetBackfaceProperty(vtkProperty lut)
		{
			vtkActor.vtkActor_SetBackfaceProperty_32(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06002878 RID: 10360
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_SetForceOpaque_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x06002879 RID: 10361 RVA: 0x0003BBDB File Offset: 0x00039DDB
		public virtual void SetForceOpaque(bool _arg)
		{
			vtkActor.vtkActor_SetForceOpaque_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600287A RID: 10362
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_SetForceTranslucent_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the actor to be treated as opaque or translucent
		/// </summary>
		// Token: 0x0600287B RID: 10363 RVA: 0x0003BBF3 File Offset: 0x00039DF3
		public virtual void SetForceTranslucent(bool _arg)
		{
			vtkActor.vtkActor_SetForceTranslucent_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600287C RID: 10364
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_SetIsRenderingTranslucentPolygonalGeometry_35(HandleRef pThis, byte val);

		/// <summary>
		/// allows a prop to update a selections color buffers
		/// Default just forwards to the Mapper
		/// </summary>
		// Token: 0x0600287D RID: 10365 RVA: 0x0003BC0B File Offset: 0x00039E0B
		public void SetIsRenderingTranslucentPolygonalGeometry(bool val)
		{
			vtkActor.vtkActor_SetIsRenderingTranslucentPolygonalGeometry_35(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x0600287E RID: 10366
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_SetMapper_36(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// This is the method that is used to connect an actor to the end of a
		/// visualization pipeline, i.e. the mapper. This should be a subclass
		/// of vtkMapper. Typically vtkPolyDataMapper and vtkDataSetMapper will
		/// be used.
		/// </summary>
		// Token: 0x0600287F RID: 10367 RVA: 0x0003BC24 File Offset: 0x00039E24
		public virtual void SetMapper(vtkMapper arg0)
		{
			vtkActor.vtkActor_SetMapper_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002880 RID: 10368
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_SetProperty_37(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Set/Get the property object that controls this actors surface
		/// properties.  This should be an instance of a vtkProperty object.  Every
		/// actor must have a property associated with it.  If one isn't specified,
		/// then one will be generated automatically. Multiple actors can share one
		/// property object.
		/// </summary>
		// Token: 0x06002881 RID: 10369 RVA: 0x0003BC54 File Offset: 0x00039E54
		public void SetProperty(vtkProperty lut)
		{
			vtkActor.vtkActor_SetProperty_37(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06002882 RID: 10370
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_SetTexture_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the texture object to control rendering texture maps.  This will
		/// be a vtkTexture object. An actor does not need to have an associated
		/// texture map and multiple actors can share one texture.
		/// </summary>
		// Token: 0x06002883 RID: 10371 RVA: 0x0003BC84 File Offset: 0x00039E84
		public virtual void SetTexture(vtkTexture arg0)
		{
			vtkActor.vtkActor_SetTexture_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002884 RID: 10372
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor_ShallowCopy_39(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x06002885 RID: 10373 RVA: 0x0003BCB4 File Offset: 0x00039EB4
		public override void ShallowCopy(vtkProp prop)
		{
			vtkActor.vtkActor_ShallowCopy_39(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400055A RID: 1370
		public new const string MRFullTypeName = "Kitware.VTK.vtkActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400055B RID: 1371
		public new static readonly string MRClassNameKey = "class vtkActor";
	}
}
