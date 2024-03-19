using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLODActor
	/// </summary>
	/// <remarks>
	///    an actor that supports multiple levels of detail
	///
	/// vtkLODActor is an actor that stores multiple levels of detail (LOD) and
	/// can automatically switch between them. It selects which level of detail to
	/// use based on how much time it has been allocated to render. Currently a
	/// very simple method of TotalTime/NumberOfActors is used. (In the future
	/// this should be modified to dynamically allocate the rendering time between
	/// different actors based on their needs.)
	///
	/// There are three levels of detail by default. The top level is just the
	/// normal data. The lowest level of detail is a simple bounding box outline
	/// of the actor. The middle level of detail is a point cloud of a fixed
	/// number of points that have been randomly sampled from the mapper's input
	/// data. Point attributes are copied over to the point cloud. These two
	/// lower levels of detail are accomplished by creating instances of a
	/// vtkOutlineFilter (low-res) and vtkMaskPoints (medium-res). Additional
	/// levels of detail can be add using the AddLODMapper() method.
	///
	/// To control the frame rate, you typically set the vtkRenderWindowInteractor
	/// DesiredUpdateRate and StillUpdateRate. This then will cause vtkLODActor
	/// to adjust its LOD to fulfill the requested update rate.
	///
	/// For greater control on levels of detail, see also vtkLODProp3D. That
	/// class allows arbitrary definition of each LOD.
	///
	/// @warning
	/// If you provide your own mappers, you are responsible for setting its
	/// ivars correctly, such as ScalarRange, LookupTable, and so on.
	///
	/// @warning
	/// On some systems the point cloud rendering (the default, medium level of
	/// detail) can result in points so small that they can hardly be seen. In
	/// this case, use the GetProperty()-&gt;SetPointSize() method to increase the
	/// rendered size of the points.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkRenderer vtkLODProp3D
	/// </seealso>
	// Token: 0x020000F9 RID: 249
	public class vtkLODActor : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600331F RID: 13087 RVA: 0x0004B33B File Offset: 0x0004953B
		static vtkLODActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLODActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLODActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003320 RID: 13088 RVA: 0x0004B363 File Offset: 0x00049563
		public vtkLODActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003321 RID: 13089
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a vtkLODActor with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0). NumberOfCloudPoints is set to 150.
		/// </summary>
		// Token: 0x06003322 RID: 13090 RVA: 0x0004B374 File Offset: 0x00049574
		public new static vtkLODActor New()
		{
			vtkLODActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODActor.vtkLODActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLODActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a vtkLODActor with the following defaults: origin(0,0,0)
		/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
		/// orientation=(0,0,0). NumberOfCloudPoints is set to 150.
		/// </summary>
		// Token: 0x06003323 RID: 13091 RVA: 0x0004B3C8 File Offset: 0x000495C8
		public vtkLODActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLODActor.vtkLODActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003324 RID: 13092 RVA: 0x0004B40C File Offset: 0x0004960C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003325 RID: 13093
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_AddLODMapper_01(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Add another level of detail.
		/// They do not have to be in any order of complexity.
		/// </summary>
		// Token: 0x06003326 RID: 13094 RVA: 0x0004B418 File Offset: 0x00049618
		public void AddLODMapper(vtkMapper mapper)
		{
			vtkLODActor.vtkLODActor_AddLODMapper_01(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x06003327 RID: 13095
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODActor_GetLODMappers_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// All the mappers for different LODs are stored here.
		/// The order is not important.
		/// </summary>
		// Token: 0x06003328 RID: 13096 RVA: 0x0004B448 File Offset: 0x00049648
		public virtual vtkMapperCollection GetLODMappers()
		{
			vtkMapperCollection vtkMapperCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODActor.vtkLODActor_GetLODMappers_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapperCollection = (vtkMapperCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapperCollection.Register(null);
				}
			}
			return vtkMapperCollection;
		}

		// Token: 0x06003329 RID: 13097
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODActor_GetLowResFilter_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// You may plug in your own filters to decimate/subsample the input.
		/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
		/// (medium-res).
		/// </summary>
		// Token: 0x0600332A RID: 13098 RVA: 0x0004B4B8 File Offset: 0x000496B8
		public virtual vtkPolyDataAlgorithm GetLowResFilter()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODActor.vtkLODActor_GetLowResFilter_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x0600332B RID: 13099
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODActor_GetMediumResFilter_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// You may plug in your own filters to decimate/subsample the input.
		/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
		/// (medium-res).
		/// </summary>
		// Token: 0x0600332C RID: 13100 RVA: 0x0004B528 File Offset: 0x00049728
		public virtual vtkPolyDataAlgorithm GetMediumResFilter()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODActor.vtkLODActor_GetMediumResFilter_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x0600332D RID: 13101
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODActor_GetNumberOfCloudPoints_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of random points for the point cloud.
		/// </summary>
		// Token: 0x0600332E RID: 13102 RVA: 0x0004B598 File Offset: 0x00049798
		public virtual int GetNumberOfCloudPoints()
		{
			return vtkLODActor.vtkLODActor_GetNumberOfCloudPoints_05(base.GetCppThis());
		}

		// Token: 0x0600332F RID: 13103
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLODActor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003330 RID: 13104 RVA: 0x0004B5B8 File Offset: 0x000497B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLODActor.vtkLODActor_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06003331 RID: 13105
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLODActor_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003332 RID: 13106 RVA: 0x0004B5D8 File Offset: 0x000497D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLODActor.vtkLODActor_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06003333 RID: 13107
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODActor_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003334 RID: 13108 RVA: 0x0004B5F4 File Offset: 0x000497F4
		public override int IsA(string type)
		{
			return vtkLODActor.vtkLODActor_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06003335 RID: 13109
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODActor_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003336 RID: 13110 RVA: 0x0004B614 File Offset: 0x00049814
		public new static int IsTypeOf(string type)
		{
			return vtkLODActor.vtkLODActor_IsTypeOf_09(type);
		}

		// Token: 0x06003337 RID: 13111
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_Modified_10(HandleRef pThis);

		/// <summary>
		/// When this objects gets modified, this method also modifies the object.
		/// </summary>
		// Token: 0x06003338 RID: 13112 RVA: 0x0004B62E File Offset: 0x0004982E
		public override void Modified()
		{
			vtkLODActor.vtkLODActor_Modified_10(base.GetCppThis());
		}

		// Token: 0x06003339 RID: 13113
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODActor_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600333A RID: 13114 RVA: 0x0004B640 File Offset: 0x00049840
		public new vtkLODActor NewInstance()
		{
			vtkLODActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODActor.vtkLODActor_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLODActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600333B RID: 13115
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600333C RID: 13116 RVA: 0x0004B69C File Offset: 0x0004989C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLODActor.vtkLODActor_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600333D RID: 13117
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_Render_14(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This causes the actor to be rendered.
		/// It, in turn, will render the actor's property and then mapper.
		/// </summary>
		// Token: 0x0600333E RID: 13118 RVA: 0x0004B6CC File Offset: 0x000498CC
		public override void Render(vtkRenderer arg0, vtkMapper arg1)
		{
			vtkLODActor.vtkLODActor_Render_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600333F RID: 13119
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODActor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003340 RID: 13120 RVA: 0x0004B710 File Offset: 0x00049910
		public new static vtkLODActor SafeDownCast(vtkObjectBase o)
		{
			vtkLODActor vtkLODActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODActor.vtkLODActor_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLODActor = (vtkLODActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLODActor.Register(null);
				}
			}
			return vtkLODActor;
		}

		// Token: 0x06003341 RID: 13121
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_SetLowResFilter_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// You may plug in your own filters to decimate/subsample the input.
		/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
		/// (medium-res).
		/// </summary>
		// Token: 0x06003342 RID: 13122 RVA: 0x0004B790 File Offset: 0x00049990
		public virtual void SetLowResFilter(vtkPolyDataAlgorithm arg0)
		{
			vtkLODActor.vtkLODActor_SetLowResFilter_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003343 RID: 13123
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_SetMediumResFilter_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// You may plug in your own filters to decimate/subsample the input.
		/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
		/// (medium-res).
		/// </summary>
		// Token: 0x06003344 RID: 13124 RVA: 0x0004B7C0 File Offset: 0x000499C0
		public virtual void SetMediumResFilter(vtkPolyDataAlgorithm arg0)
		{
			vtkLODActor.vtkLODActor_SetMediumResFilter_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003345 RID: 13125
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_SetNumberOfCloudPoints_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of random points for the point cloud.
		/// </summary>
		// Token: 0x06003346 RID: 13126 RVA: 0x0004B7EF File Offset: 0x000499EF
		public virtual void SetNumberOfCloudPoints(int _arg)
		{
			vtkLODActor.vtkLODActor_SetNumberOfCloudPoints_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06003347 RID: 13127
		[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODActor_ShallowCopy_19(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an LOD actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x06003348 RID: 13128 RVA: 0x0004B800 File Offset: 0x00049A00
		public override void ShallowCopy(vtkProp prop)
		{
			vtkLODActor.vtkLODActor_ShallowCopy_19(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000616 RID: 1558
		public new const string MRFullTypeName = "Kitware.VTK.vtkLODActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000617 RID: 1559
		public new static readonly string MRClassNameKey = "class vtkLODActor";
	}
}
