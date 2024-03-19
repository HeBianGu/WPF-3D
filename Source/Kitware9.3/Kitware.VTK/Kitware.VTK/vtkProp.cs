using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProp
	/// </summary>
	/// <remarks>
	///    abstract superclass for all actors, volumes and annotations
	///
	/// vtkProp is an abstract superclass for any objects that can exist in a
	/// rendered scene (either 2D or 3D). Instances of vtkProp may respond to
	/// various render methods (e.g., RenderOpaqueGeometry()). vtkProp also
	/// defines the API for picking, LOD manipulation, and common instance
	/// variables that control visibility, picking, and dragging.
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkActor vtkVolume vtkProp3D
	/// </seealso>
	// Token: 0x020000A3 RID: 163
	public class vtkProp : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060022F9 RID: 8953 RVA: 0x000346D3 File Offset: 0x000328D3
		static vtkProp()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060022FA RID: 8954 RVA: 0x000346FB File Offset: 0x000328FB
		public vtkProp(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060022FB RID: 8955 RVA: 0x00034709 File Offset: 0x00032909
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060022FC RID: 8956
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_AddConsumer_01(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Add or remove or get or check a consumer,
		/// </summary>
		// Token: 0x060022FD RID: 8957 RVA: 0x00034714 File Offset: 0x00032914
		public void AddConsumer(vtkObject c)
		{
			vtkProp.vtkProp_AddConsumer_01(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x060022FE RID: 8958
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_AddEstimatedRenderTime_02(HandleRef pThis, double t, HandleRef arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// This method is intended to allow the renderer to add to the
		/// EstimatedRenderTime in props that require information that
		/// the renderer has in order to do this. For example, props
		/// that are rendered with a ray casting method do not know
		/// themselves how long it took for them to render. We don't want to
		/// cause a this-&gt;Modified() when we set this value since it is not
		/// really a modification to the object. (For example, we don't want
		/// to rebuild matrices at every render because the estimated render time
		/// is changing)
		/// </summary>
		// Token: 0x060022FF RID: 8959 RVA: 0x00034744 File Offset: 0x00032944
		public virtual void AddEstimatedRenderTime(double t, vtkViewport arg1)
		{
			vtkProp.vtkProp_AddEstimatedRenderTime_02(base.GetCppThis(), t, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002300 RID: 8960
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_BuildPaths_03(HandleRef pThis, HandleRef paths, HandleRef path);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used to construct assembly paths and perform part traversal.
		/// </summary>
		// Token: 0x06002301 RID: 8961 RVA: 0x00034774 File Offset: 0x00032974
		public virtual void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
		{
			vtkProp.vtkProp_BuildPaths_03(base.GetCppThis(), (paths == null) ? default(HandleRef) : paths.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		// Token: 0x06002302 RID: 8962
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_DragableOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the dragable instance variable. This determines if
		/// an Prop, once picked, can be dragged (translated) through space.
		/// This is typically done through an interactive mouse interface.
		/// This does not affect methods such as SetPosition, which will continue
		/// to work.  It is just intended to prevent some vtkProp'ss from being
		/// dragged from within a user interface.
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002303 RID: 8963 RVA: 0x000347B8 File Offset: 0x000329B8
		public virtual void DragableOff()
		{
			vtkProp.vtkProp_DragableOff_04(base.GetCppThis());
		}

		// Token: 0x06002304 RID: 8964
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_DragableOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the dragable instance variable. This determines if
		/// an Prop, once picked, can be dragged (translated) through space.
		/// This is typically done through an interactive mouse interface.
		/// This does not affect methods such as SetPosition, which will continue
		/// to work.  It is just intended to prevent some vtkProp'ss from being
		/// dragged from within a user interface.
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002305 RID: 8965 RVA: 0x000347C7 File Offset: 0x000329C7
		public virtual void DragableOn()
		{
			vtkProp.vtkProp_DragableOn_05(base.GetCppThis());
		}

		// Token: 0x06002306 RID: 8966
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GeneralTextureTransform_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Optional Key Indicating the texture transform for general texture mapping
		/// Old OpenGL was a state machine where you would push or pop
		/// items. The new OpenGL design is more mapper centric. Some
		/// classes push a texture and then assume a mapper will use it.
		/// The new design wants explicit communication of when a texture
		/// is being used.  This key can be used to pass that information
		/// down to a mapper.
		/// </summary>
		// Token: 0x06002307 RID: 8967 RVA: 0x000347D8 File Offset: 0x000329D8
		public static vtkInformationDoubleVectorKey GeneralTextureTransform()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_GeneralTextureTransform_06(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x06002308 RID: 8968
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GeneralTextureUnit_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Optional Key Indicating the texture unit for general texture mapping
		/// Old OpenGL was a state machine where you would push or pop
		/// items. The new OpenGL design is more mapper centric. Some
		/// classes push a texture and then assume a mapper will use it.
		/// The new design wants explicit communication of when a texture
		/// is being used.  This key can be used to pass that information
		/// down to a mapper.
		/// </summary>
		// Token: 0x06002309 RID: 8969 RVA: 0x00034844 File Offset: 0x00032A44
		public static vtkInformationIntegerKey GeneralTextureUnit()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_GeneralTextureUnit_07(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0600230A RID: 8970
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_GetActors_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x0600230B RID: 8971 RVA: 0x000348B0 File Offset: 0x00032AB0
		public virtual void GetActors(vtkPropCollection arg0)
		{
			vtkProp.vtkProp_GetActors_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600230C RID: 8972
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_GetActors2D_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x0600230D RID: 8973 RVA: 0x000348E0 File Offset: 0x00032AE0
		public virtual void GetActors2D(vtkPropCollection arg0)
		{
			vtkProp.vtkProp_GetActors2D_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600230E RID: 8974
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp_GetAllocatedRenderTime_10(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// </summary>
		// Token: 0x0600230F RID: 8975 RVA: 0x00034910 File Offset: 0x00032B10
		public virtual double GetAllocatedRenderTime()
		{
			return vtkProp.vtkProp_GetAllocatedRenderTime_10(base.GetCppThis());
		}

		// Token: 0x06002310 RID: 8976
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GetBounds_11(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Prop as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// in world coordinates. NULL means that the bounds are not defined.
		/// </summary>
		// Token: 0x06002311 RID: 8977 RVA: 0x00034930 File Offset: 0x00032B30
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkProp.vtkProp_GetBounds_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002312 RID: 8978
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GetConsumer_12(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add or remove or get or check a consumer,
		/// </summary>
		// Token: 0x06002313 RID: 8979 RVA: 0x00034978 File Offset: 0x00032B78
		public vtkObject GetConsumer(int i)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_GetConsumer_12(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		// Token: 0x06002314 RID: 8980
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_GetDragable_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the dragable instance variable. This determines if
		/// an Prop, once picked, can be dragged (translated) through space.
		/// This is typically done through an interactive mouse interface.
		/// This does not affect methods such as SetPosition, which will continue
		/// to work.  It is just intended to prevent some vtkProp'ss from being
		/// dragged from within a user interface.
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002315 RID: 8981 RVA: 0x000349E8 File Offset: 0x00032BE8
		public virtual int GetDragable()
		{
			return vtkProp.vtkProp_GetDragable_13(base.GetCppThis());
		}

		// Token: 0x06002316 RID: 8982
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp_GetEstimatedRenderTime_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// The EstimatedRenderTime may be used to select between different props,
		/// for example in LODProp it is used to select the level-of-detail.
		/// The value is returned in seconds. For simple geometry the accuracy may
		/// not be great due to buffering. For ray casting, which is already
		/// multi-resolution, the current resolution of the image is factored into
		/// the time. We need the viewport for viewing parameters that affect timing.
		/// The no-arguments version simply returns the value of the variable with
		/// no estimation.
		/// </summary>
		// Token: 0x06002317 RID: 8983 RVA: 0x00034A08 File Offset: 0x00032C08
		public virtual double GetEstimatedRenderTime(vtkViewport arg0)
		{
			return vtkProp.vtkProp_GetEstimatedRenderTime_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002318 RID: 8984
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp_GetEstimatedRenderTime_15(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// The EstimatedRenderTime may be used to select between different props,
		/// for example in LODProp it is used to select the level-of-detail.
		/// The value is returned in seconds. For simple geometry the accuracy may
		/// not be great due to buffering. For ray casting, which is already
		/// multi-resolution, the current resolution of the image is factored into
		/// the time. We need the viewport for viewing parameters that affect timing.
		/// The no-arguments version simply returns the value of the variable with
		/// no estimation.
		/// </summary>
		// Token: 0x06002319 RID: 8985 RVA: 0x00034A3C File Offset: 0x00032C3C
		public virtual double GetEstimatedRenderTime()
		{
			return vtkProp.vtkProp_GetEstimatedRenderTime_15(base.GetCppThis());
		}

		// Token: 0x0600231A RID: 8986
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GetMatrix_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These methods are used by subclasses to place a matrix (if any) in the
		/// prop prior to rendering. Generally used only for picking. See vtkProp3D
		/// for more information.
		/// </summary>
		// Token: 0x0600231B RID: 8987 RVA: 0x00034A5C File Offset: 0x00032C5C
		public virtual vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_GetMatrix_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600231C RID: 8988
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GetNextPath_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// vtkProp and its subclasses can be picked by subclasses of
		/// vtkAbstractPicker (e.g., vtkPropPicker). The following methods interface
		/// with the picking classes and return "pick paths". A pick path is a
		/// hierarchical, ordered list of props that form an assembly.  Most often,
		/// when a vtkProp is picked, its path consists of a single node (i.e., the
		/// prop). However, classes like vtkAssembly and vtkPropAssembly can return
		/// more than one path, each path being several layers deep. (See
		/// vtkAssemblyPath for more information.)  To use these methods - first
		/// invoke InitPathTraversal() followed by repeated calls to GetNextPath().
		/// GetNextPath() returns a NULL pointer when the list is exhausted.
		/// </summary>
		// Token: 0x0600231D RID: 8989 RVA: 0x00034ACC File Offset: 0x00032CCC
		public virtual vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_GetNextPath_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x0600231E RID: 8990
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_GetNumberOfConsumers_18(HandleRef pThis);

		/// <summary>
		/// Get the number of consumers
		/// </summary>
		// Token: 0x0600231F RID: 8991 RVA: 0x00034B3C File Offset: 0x00032D3C
		public virtual int GetNumberOfConsumers()
		{
			return vtkProp.vtkProp_GetNumberOfConsumers_18(base.GetCppThis());
		}

		// Token: 0x06002320 RID: 8992
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002321 RID: 8993 RVA: 0x00034B5C File Offset: 0x00032D5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProp.vtkProp_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x06002322 RID: 8994
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002323 RID: 8995 RVA: 0x00034B7C File Offset: 0x00032D7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProp.vtkProp_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x06002324 RID: 8996
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_GetNumberOfPaths_21(HandleRef pThis);

		/// <summary>
		/// vtkProp and its subclasses can be picked by subclasses of
		/// vtkAbstractPicker (e.g., vtkPropPicker). The following methods interface
		/// with the picking classes and return "pick paths". A pick path is a
		/// hierarchical, ordered list of props that form an assembly.  Most often,
		/// when a vtkProp is picked, its path consists of a single node (i.e., the
		/// prop). However, classes like vtkAssembly and vtkPropAssembly can return
		/// more than one path, each path being several layers deep. (See
		/// vtkAssemblyPath for more information.)  To use these methods - first
		/// invoke InitPathTraversal() followed by repeated calls to GetNextPath().
		/// GetNextPath() returns a NULL pointer when the list is exhausted.
		/// </summary>
		// Token: 0x06002325 RID: 8997 RVA: 0x00034B98 File Offset: 0x00032D98
		public virtual int GetNumberOfPaths()
		{
			return vtkProp.vtkProp_GetNumberOfPaths_21(base.GetCppThis());
		}

		// Token: 0x06002326 RID: 8998
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_GetPickable_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the pickable instance variable.  This determines if the vtkProp
		/// can be picked (typically using the mouse). Also see dragable.
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002327 RID: 8999 RVA: 0x00034BB8 File Offset: 0x00032DB8
		public virtual int GetPickable()
		{
			return vtkProp.vtkProp_GetPickable_22(base.GetCppThis());
		}

		// Token: 0x06002328 RID: 9000
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GetPropertyKeys_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get property keys. Property keys can be digest by some rendering
		/// passes.
		/// For instance, the user may mark a prop as a shadow caster for a
		/// shadow mapping render pass. Keys are documented in render pass classes.
		/// Initial value is NULL.
		/// </summary>
		// Token: 0x06002329 RID: 9001 RVA: 0x00034BD8 File Offset: 0x00032DD8
		public virtual vtkInformation GetPropertyKeys()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_GetPropertyKeys_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0600232A RID: 9002
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkProp_GetRedrawMTime_24(HandleRef pThis);

		/// <summary>
		/// Return the mtime of anything that would cause the rendered image to
		/// appear differently. Usually this involves checking the mtime of the
		/// prop plus anything else it depends on such as properties, textures
		/// etc.
		/// </summary>
		// Token: 0x0600232B RID: 9003 RVA: 0x00034C48 File Offset: 0x00032E48
		public virtual ulong GetRedrawMTime()
		{
			return vtkProp.vtkProp_GetRedrawMTime_24(base.GetCppThis());
		}

		// Token: 0x0600232C RID: 9004
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp_GetRenderTimeMultiplier_25(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Get/Set the multiplier for the render time. This is used
		/// for culling and is a number between 0 and 1. It is used
		/// to create the allocated render time value.
		/// </summary>
		// Token: 0x0600232D RID: 9005 RVA: 0x00034C68 File Offset: 0x00032E68
		public virtual double GetRenderTimeMultiplier()
		{
			return vtkProp.vtkProp_GetRenderTimeMultiplier_25(base.GetCppThis());
		}

		// Token: 0x0600232E RID: 9006
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_GetShaderProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the shader property.
		/// </summary>
		// Token: 0x0600232F RID: 9007 RVA: 0x00034C88 File Offset: 0x00032E88
		public virtual vtkShaderProperty GetShaderProperty()
		{
			vtkShaderProperty vtkShaderProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_GetShaderProperty_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProperty = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProperty.Register(null);
				}
			}
			return vtkShaderProperty;
		}

		// Token: 0x06002330 RID: 9008
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_GetSupportsSelection_27(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		/// </summary>
		// Token: 0x06002331 RID: 9009 RVA: 0x00034CF8 File Offset: 0x00032EF8
		public virtual bool GetSupportsSelection()
		{
			return vtkProp.vtkProp_GetSupportsSelection_27(base.GetCppThis()) != 0;
		}

		// Token: 0x06002332 RID: 9010
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_GetUseBounds_28(HandleRef pThis);

		/// <summary>
		/// In case the Visibility flag is true, tell if the bounds of this prop
		/// should be taken into account or ignored during the computation of other
		/// bounding boxes, like in vtkRenderer::ResetCamera().
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002333 RID: 9011 RVA: 0x00034D20 File Offset: 0x00032F20
		public virtual bool GetUseBounds()
		{
			return vtkProp.vtkProp_GetUseBounds_28(base.GetCppThis()) != 0;
		}

		// Token: 0x06002334 RID: 9012
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_GetVisibility_29(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of this vtkProp. Initial value is true.
		/// </summary>
		// Token: 0x06002335 RID: 9013 RVA: 0x00034D48 File Offset: 0x00032F48
		public virtual int GetVisibility()
		{
			return vtkProp.vtkProp_GetVisibility_29(base.GetCppThis());
		}

		// Token: 0x06002336 RID: 9014
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_GetVolumes_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x06002337 RID: 9015 RVA: 0x00034D68 File Offset: 0x00032F68
		public virtual void GetVolumes(vtkPropCollection arg0)
		{
			vtkProp.vtkProp_GetVolumes_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002338 RID: 9016
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_HasKeys_31(HandleRef pThis, HandleRef requiredKeys);

		/// <summary>
		/// Tells if the prop has all the required keys.
		/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
		/// </summary>
		// Token: 0x06002339 RID: 9017 RVA: 0x00034D98 File Offset: 0x00032F98
		public virtual bool HasKeys(vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_HasKeys_31(base.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		// Token: 0x0600233A RID: 9018
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_HasOpaqueGeometry_32(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// Does this prop have some opaque geometry?
		/// This method is called during the rendering process to know if there is
		/// some opaque geometry. A simple prop that has some
		/// opaque geometry will return true. A composite prop (like
		/// vtkAssembly) that has at least one sub-prop that has some opaque
		/// polygonal geometry will return true.
		/// Default implementation return true.
		/// </summary>
		// Token: 0x0600233B RID: 9019 RVA: 0x00034DD4 File Offset: 0x00032FD4
		public virtual int HasOpaqueGeometry()
		{
			return vtkProp.vtkProp_HasOpaqueGeometry_32(base.GetCppThis());
		}

		// Token: 0x0600233C RID: 9020
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_HasTranslucentPolygonalGeometry_33(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// Does this prop have some translucent polygonal geometry?
		/// This method is called during the rendering process to know if there is
		/// some translucent polygonal geometry. A simple prop that has some
		/// translucent polygonal geometry will return true. A composite prop (like
		/// vtkAssembly) that has at least one sub-prop that has some translucent
		/// polygonal geometry will return true.
		/// Default implementation return false.
		/// </summary>
		// Token: 0x0600233D RID: 9021 RVA: 0x00034DF4 File Offset: 0x00032FF4
		public virtual int HasTranslucentPolygonalGeometry()
		{
			return vtkProp.vtkProp_HasTranslucentPolygonalGeometry_33(base.GetCppThis());
		}

		// Token: 0x0600233E RID: 9022
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_InitPathTraversal_34(HandleRef pThis);

		/// <summary>
		/// vtkProp and its subclasses can be picked by subclasses of
		/// vtkAbstractPicker (e.g., vtkPropPicker). The following methods interface
		/// with the picking classes and return "pick paths". A pick path is a
		/// hierarchical, ordered list of props that form an assembly.  Most often,
		/// when a vtkProp is picked, its path consists of a single node (i.e., the
		/// prop). However, classes like vtkAssembly and vtkPropAssembly can return
		/// more than one path, each path being several layers deep. (See
		/// vtkAssemblyPath for more information.)  To use these methods - first
		/// invoke InitPathTraversal() followed by repeated calls to GetNextPath().
		/// GetNextPath() returns a NULL pointer when the list is exhausted.
		/// </summary>
		// Token: 0x0600233F RID: 9023 RVA: 0x00034E13 File Offset: 0x00033013
		public virtual void InitPathTraversal()
		{
			vtkProp.vtkProp_InitPathTraversal_34(base.GetCppThis());
		}

		// Token: 0x06002340 RID: 9024
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002341 RID: 9025 RVA: 0x00034E24 File Offset: 0x00033024
		public override int IsA(string type)
		{
			return vtkProp.vtkProp_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x06002342 RID: 9026
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_IsConsumer_36(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Add or remove or get or check a consumer,
		/// </summary>
		// Token: 0x06002343 RID: 9027 RVA: 0x00034E44 File Offset: 0x00033044
		public int IsConsumer(vtkObject c)
		{
			return vtkProp.vtkProp_IsConsumer_36(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x06002344 RID: 9028
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_IsRenderingTranslucentPolygonalGeometry_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the shader property.
		/// </summary>
		// Token: 0x06002345 RID: 9029 RVA: 0x00034E78 File Offset: 0x00033078
		public virtual bool IsRenderingTranslucentPolygonalGeometry()
		{
			return vtkProp.vtkProp_IsRenderingTranslucentPolygonalGeometry_37(base.GetCppThis()) != 0;
		}

		// Token: 0x06002346 RID: 9030
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002347 RID: 9031 RVA: 0x00034EA0 File Offset: 0x000330A0
		public new static int IsTypeOf(string type)
		{
			return vtkProp.vtkProp_IsTypeOf_38(type);
		}

		// Token: 0x06002348 RID: 9032
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002349 RID: 9033 RVA: 0x00034EBC File Offset: 0x000330BC
		public new vtkProp NewInstance()
		{
			vtkProp result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600234A RID: 9034
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_Pick_40(HandleRef pThis);

		/// <summary>
		/// Method fires PickEvent if the prop is picked.
		/// </summary>
		// Token: 0x0600234B RID: 9035 RVA: 0x00034F16 File Offset: 0x00033116
		public virtual void Pick()
		{
			vtkProp.vtkProp_Pick_40(base.GetCppThis());
		}

		// Token: 0x0600234C RID: 9036
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_PickableOff_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the pickable instance variable.  This determines if the vtkProp
		/// can be picked (typically using the mouse). Also see dragable.
		/// Initial value is true.
		/// </summary>
		// Token: 0x0600234D RID: 9037 RVA: 0x00034F25 File Offset: 0x00033125
		public virtual void PickableOff()
		{
			vtkProp.vtkProp_PickableOff_41(base.GetCppThis());
		}

		// Token: 0x0600234E RID: 9038
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_PickableOn_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the pickable instance variable.  This determines if the vtkProp
		/// can be picked (typically using the mouse). Also see dragable.
		/// Initial value is true.
		/// </summary>
		// Token: 0x0600234F RID: 9039 RVA: 0x00034F34 File Offset: 0x00033134
		public virtual void PickableOn()
		{
			vtkProp.vtkProp_PickableOn_42(base.GetCppThis());
		}

		// Token: 0x06002350 RID: 9040
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_PokeMatrix_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are used by subclasses to place a matrix (if any) in the
		/// prop prior to rendering. Generally used only for picking. See vtkProp3D
		/// for more information.
		/// </summary>
		// Token: 0x06002351 RID: 9041 RVA: 0x00034F44 File Offset: 0x00033144
		public virtual void PokeMatrix(vtkMatrix4x4 arg0)
		{
			vtkProp.vtkProp_PokeMatrix_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002352 RID: 9042
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002353 RID: 9043 RVA: 0x00034F74 File Offset: 0x00033174
		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkProp.vtkProp_ReleaseGraphicsResources_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002354 RID: 9044
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_RemoveConsumer_45(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Add or remove or get or check a consumer,
		/// </summary>
		// Token: 0x06002355 RID: 9045 RVA: 0x00034FA4 File Offset: 0x000331A4
		public void RemoveConsumer(vtkObject c)
		{
			vtkProp.vtkProp_RemoveConsumer_45(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x06002356 RID: 9046
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_RenderFilteredOpaqueGeometry_46(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		/// <summary>
		/// Render the opaque geometry only if the prop has all the requiredKeys.
		/// This is recursive for composite props like vtkAssembly.
		/// An implementation is provided in vtkProp but each composite prop
		/// must override it.
		/// It returns if the rendering was performed.
		/// \pre v_exists: v!=0
		/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
		/// </summary>
		// Token: 0x06002357 RID: 9047 RVA: 0x00034FD4 File Offset: 0x000331D4
		public virtual bool RenderFilteredOpaqueGeometry(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredOpaqueGeometry_46(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		// Token: 0x06002358 RID: 9048
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_RenderFilteredOverlay_47(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		/// <summary>
		/// Render in the overlay of the viewport only if the prop has all the
		/// requiredKeys.
		/// This is recursive for composite props like vtkAssembly.
		/// An implementation is provided in vtkProp but each composite prop
		/// must override it.
		/// It returns if the rendering was performed.
		/// \pre v_exists: v!=0
		/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
		/// </summary>
		// Token: 0x06002359 RID: 9049 RVA: 0x00035024 File Offset: 0x00033224
		public virtual bool RenderFilteredOverlay(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredOverlay_47(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		// Token: 0x0600235A RID: 9050
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_RenderFilteredTranslucentPolygonalGeometry_48(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		/// <summary>
		/// Render the translucent polygonal geometry only if the prop has all the
		/// requiredKeys.
		/// This is recursive for composite props like vtkAssembly.
		/// An implementation is provided in vtkProp but each composite prop
		/// must override it.
		/// It returns if the rendering was performed.
		/// \pre v_exists: v!=0
		/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
		/// </summary>
		// Token: 0x0600235B RID: 9051 RVA: 0x00035074 File Offset: 0x00033274
		public virtual bool RenderFilteredTranslucentPolygonalGeometry(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredTranslucentPolygonalGeometry_48(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		// Token: 0x0600235C RID: 9052
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProp_RenderFilteredVolumetricGeometry_49(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		/// <summary>
		/// Render the volumetric geometry only if the prop has all the
		/// requiredKeys.
		/// This is recursive for composite props like vtkAssembly.
		/// An implementation is provided in vtkProp but each composite prop
		/// must override it.
		/// It returns if the rendering was performed.
		/// \pre v_exists: v!=0
		/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
		/// </summary>
		// Token: 0x0600235D RID: 9053 RVA: 0x000350C4 File Offset: 0x000332C4
		public virtual bool RenderFilteredVolumetricGeometry(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredVolumetricGeometry_49(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		// Token: 0x0600235E RID: 9054
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_RenderOpaqueGeometry_50(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// All concrete subclasses must be able to render themselves.
		/// There are four key render methods in vtk and they correspond
		/// to four different points in the rendering cycle. Any given
		/// prop may implement one or more of these methods.
		/// The first method is intended for rendering all opaque geometry. The
		/// second method is intended for rendering all translucent polygonal
		/// geometry. The third one is intended for rendering all translucent
		/// volumetric geometry. Most of the volume rendering mappers draw their
		/// results during this third method.
		/// The last method is to render any 2D annotation or overlays.
		/// Each of these methods return an integer value indicating
		/// whether or not this render method was applied to this data.
		/// </summary>
		// Token: 0x0600235F RID: 9055 RVA: 0x00035114 File Offset: 0x00033314
		public virtual int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderOpaqueGeometry_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002360 RID: 9056
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_RenderOverlay_51(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// All concrete subclasses must be able to render themselves.
		/// There are four key render methods in vtk and they correspond
		/// to four different points in the rendering cycle. Any given
		/// prop may implement one or more of these methods.
		/// The first method is intended for rendering all opaque geometry. The
		/// second method is intended for rendering all translucent polygonal
		/// geometry. The third one is intended for rendering all translucent
		/// volumetric geometry. Most of the volume rendering mappers draw their
		/// results during this third method.
		/// The last method is to render any 2D annotation or overlays.
		/// Each of these methods return an integer value indicating
		/// whether or not this render method was applied to this data.
		/// </summary>
		// Token: 0x06002361 RID: 9057 RVA: 0x00035148 File Offset: 0x00033348
		public virtual int RenderOverlay(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderOverlay_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002362 RID: 9058
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_RenderTranslucentPolygonalGeometry_52(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// All concrete subclasses must be able to render themselves.
		/// There are four key render methods in vtk and they correspond
		/// to four different points in the rendering cycle. Any given
		/// prop may implement one or more of these methods.
		/// The first method is intended for rendering all opaque geometry. The
		/// second method is intended for rendering all translucent polygonal
		/// geometry. The third one is intended for rendering all translucent
		/// volumetric geometry. Most of the volume rendering mappers draw their
		/// results during this third method.
		/// The last method is to render any 2D annotation or overlays.
		/// Each of these methods return an integer value indicating
		/// whether or not this render method was applied to this data.
		/// </summary>
		// Token: 0x06002363 RID: 9059 RVA: 0x0003517C File Offset: 0x0003337C
		public virtual int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderTranslucentPolygonalGeometry_52(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002364 RID: 9060
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp_RenderVolumetricGeometry_53(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// All concrete subclasses must be able to render themselves.
		/// There are four key render methods in vtk and they correspond
		/// to four different points in the rendering cycle. Any given
		/// prop may implement one or more of these methods.
		/// The first method is intended for rendering all opaque geometry. The
		/// second method is intended for rendering all translucent polygonal
		/// geometry. The third one is intended for rendering all translucent
		/// volumetric geometry. Most of the volume rendering mappers draw their
		/// results during this third method.
		/// The last method is to render any 2D annotation or overlays.
		/// Each of these methods return an integer value indicating
		/// whether or not this render method was applied to this data.
		/// </summary>
		// Token: 0x06002365 RID: 9061 RVA: 0x000351B0 File Offset: 0x000333B0
		public virtual int RenderVolumetricGeometry(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderVolumetricGeometry_53(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002366 RID: 9062
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_RestoreEstimatedRenderTime_54(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// When the EstimatedRenderTime is first set to 0.0 (in the
		/// SetAllocatedRenderTime method) the old value is saved. This
		/// method is used to restore that old value should the render be
		/// aborted.
		/// </summary>
		// Token: 0x06002367 RID: 9063 RVA: 0x000351E4 File Offset: 0x000333E4
		public virtual void RestoreEstimatedRenderTime()
		{
			vtkProp.vtkProp_RestoreEstimatedRenderTime_54(base.GetCppThis());
		}

		// Token: 0x06002368 RID: 9064
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002369 RID: 9065 RVA: 0x000351F4 File Offset: 0x000333F4
		public new static vtkProp SafeDownCast(vtkObjectBase o)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp.vtkProp_SafeDownCast_55((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x0600236A RID: 9066
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetAllocatedRenderTime_56(HandleRef pThis, double t, HandleRef arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// The renderer may use the allocated rendering time to determine
		/// how to render this actor. Therefore it might need the information
		/// provided in the viewport.
		/// A side effect of this method is to reset the EstimatedRenderTime to
		/// 0.0. This way, each of the ways that this prop may be rendered can
		/// be timed and added together into this value.
		/// </summary>
		// Token: 0x0600236B RID: 9067 RVA: 0x00035274 File Offset: 0x00033474
		public virtual void SetAllocatedRenderTime(double t, vtkViewport arg1)
		{
			vtkProp.vtkProp_SetAllocatedRenderTime_56(base.GetCppThis(), t, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600236C RID: 9068
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetDragable_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the value of the dragable instance variable. This determines if
		/// an Prop, once picked, can be dragged (translated) through space.
		/// This is typically done through an interactive mouse interface.
		/// This does not affect methods such as SetPosition, which will continue
		/// to work.  It is just intended to prevent some vtkProp'ss from being
		/// dragged from within a user interface.
		/// Initial value is true.
		/// </summary>
		// Token: 0x0600236D RID: 9069 RVA: 0x000352A4 File Offset: 0x000334A4
		public virtual void SetDragable(int _arg)
		{
			vtkProp.vtkProp_SetDragable_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600236E RID: 9070
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetEstimatedRenderTime_58(HandleRef pThis, double t);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
		/// This method is used by, for example, the vtkLODProp3D in order to
		/// initialize the estimated render time at start-up to some user defined
		/// value.
		/// </summary>
		// Token: 0x0600236F RID: 9071 RVA: 0x000352B4 File Offset: 0x000334B4
		public virtual void SetEstimatedRenderTime(double t)
		{
			vtkProp.vtkProp_SetEstimatedRenderTime_58(base.GetCppThis(), t);
		}

		// Token: 0x06002370 RID: 9072
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetPickable_59(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the pickable instance variable.  This determines if the vtkProp
		/// can be picked (typically using the mouse). Also see dragable.
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002371 RID: 9073 RVA: 0x000352C4 File Offset: 0x000334C4
		public virtual void SetPickable(int _arg)
		{
			vtkProp.vtkProp_SetPickable_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06002372 RID: 9074
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetPropertyKeys_60(HandleRef pThis, HandleRef keys);

		/// <summary>
		/// Set/Get property keys. Property keys can be digest by some rendering
		/// passes.
		/// For instance, the user may mark a prop as a shadow caster for a
		/// shadow mapping render pass. Keys are documented in render pass classes.
		/// Initial value is NULL.
		/// </summary>
		// Token: 0x06002373 RID: 9075 RVA: 0x000352D4 File Offset: 0x000334D4
		public virtual void SetPropertyKeys(vtkInformation keys)
		{
			vtkProp.vtkProp_SetPropertyKeys_60(base.GetCppThis(), (keys == null) ? default(HandleRef) : keys.GetCppThis());
		}

		// Token: 0x06002374 RID: 9076
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetRenderTimeMultiplier_61(HandleRef pThis, double t);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Get/Set the multiplier for the render time. This is used
		/// for culling and is a number between 0 and 1. It is used
		/// to create the allocated render time value.
		/// </summary>
		// Token: 0x06002375 RID: 9077 RVA: 0x00035303 File Offset: 0x00033503
		public void SetRenderTimeMultiplier(double t)
		{
			vtkProp.vtkProp_SetRenderTimeMultiplier_61(base.GetCppThis(), t);
		}

		// Token: 0x06002376 RID: 9078
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetShaderProperty_62(HandleRef pThis, HandleRef property);

		/// <summary>
		/// Set/Get the shader property.
		/// </summary>
		// Token: 0x06002377 RID: 9079 RVA: 0x00035314 File Offset: 0x00033514
		public virtual void SetShaderProperty(vtkShaderProperty property)
		{
			vtkProp.vtkProp_SetShaderProperty_62(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x06002378 RID: 9080
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetUseBounds_63(HandleRef pThis, byte _arg);

		/// <summary>
		/// In case the Visibility flag is true, tell if the bounds of this prop
		/// should be taken into account or ignored during the computation of other
		/// bounding boxes, like in vtkRenderer::ResetCamera().
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002379 RID: 9081 RVA: 0x00035343 File Offset: 0x00033543
		public virtual void SetUseBounds(bool _arg)
		{
			vtkProp.vtkProp_SetUseBounds_63(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600237A RID: 9082
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_SetVisibility_64(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get visibility of this vtkProp. Initial value is true.
		/// </summary>
		// Token: 0x0600237B RID: 9083 RVA: 0x0003535B File Offset: 0x0003355B
		public virtual void SetVisibility(int _arg)
		{
			vtkProp.vtkProp_SetVisibility_64(base.GetCppThis(), _arg);
		}

		// Token: 0x0600237C RID: 9084
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_ShallowCopy_65(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this vtkProp.
		/// </summary>
		// Token: 0x0600237D RID: 9085 RVA: 0x0003536C File Offset: 0x0003356C
		public virtual void ShallowCopy(vtkProp prop)
		{
			vtkProp.vtkProp_ShallowCopy_65(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600237E RID: 9086
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_UseBoundsOff_66(HandleRef pThis);

		/// <summary>
		/// In case the Visibility flag is true, tell if the bounds of this prop
		/// should be taken into account or ignored during the computation of other
		/// bounding boxes, like in vtkRenderer::ResetCamera().
		/// Initial value is true.
		/// </summary>
		// Token: 0x0600237F RID: 9087 RVA: 0x0003539B File Offset: 0x0003359B
		public virtual void UseBoundsOff()
		{
			vtkProp.vtkProp_UseBoundsOff_66(base.GetCppThis());
		}

		// Token: 0x06002380 RID: 9088
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_UseBoundsOn_67(HandleRef pThis);

		/// <summary>
		/// In case the Visibility flag is true, tell if the bounds of this prop
		/// should be taken into account or ignored during the computation of other
		/// bounding boxes, like in vtkRenderer::ResetCamera().
		/// Initial value is true.
		/// </summary>
		// Token: 0x06002381 RID: 9089 RVA: 0x000353AA File Offset: 0x000335AA
		public virtual void UseBoundsOn()
		{
			vtkProp.vtkProp_UseBoundsOn_67(base.GetCppThis());
		}

		// Token: 0x06002382 RID: 9090
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_VisibilityOff_68(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of this vtkProp. Initial value is true.
		/// </summary>
		// Token: 0x06002383 RID: 9091 RVA: 0x000353B9 File Offset: 0x000335B9
		public virtual void VisibilityOff()
		{
			vtkProp.vtkProp_VisibilityOff_68(base.GetCppThis());
		}

		// Token: 0x06002384 RID: 9092
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp_VisibilityOn_69(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of this vtkProp. Initial value is true.
		/// </summary>
		// Token: 0x06002385 RID: 9093 RVA: 0x000353C8 File Offset: 0x000335C8
		public virtual void VisibilityOn()
		{
			vtkProp.vtkProp_VisibilityOn_69(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000527 RID: 1319
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000528 RID: 1320
		public new static readonly string MRClassNameKey = "class vtkProp";
	}
}
