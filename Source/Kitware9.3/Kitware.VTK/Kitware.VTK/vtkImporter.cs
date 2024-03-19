using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImporter
	/// </summary>
	/// <remarks>
	///    importer abstract class
	///
	/// vtkImporter is an abstract class that specifies the protocol for
	/// importing actors, cameras, lights and properties into a
	/// vtkRenderWindow. The following takes place:
	/// 1) Create a RenderWindow and Renderer if none is provided.
	/// 2) Call ImportBegin, if ImportBegin returns False, return
	/// 3) Call ReadData, which calls:
	///  a) Import the Actors
	///  b) Import the cameras
	///  c) Import the lights
	///  d) Import the Properties
	/// 7) Call ImportEnd
	///
	/// Subclasses optionally implement the ImportActors, ImportCameras,
	/// ImportLights and ImportProperties or ReadData methods. An ImportBegin and
	/// ImportEnd can optionally be provided to perform Importer-specific
	/// initialization and termination.  The Read method initiates the import
	/// process. If a RenderWindow is provided, its Renderer will contained
	/// the imported objects. If the RenderWindow has no Renderer, one is
	/// created. If no RenderWindow is provided, both a RenderWindow and
	/// Renderer will be created. Both the RenderWindow and Renderer can be
	/// accessed using Get methods.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DSImporter vtkExporter
	/// </seealso>
	// Token: 0x02000184 RID: 388
	public class vtkImporter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004A9E RID: 19102 RVA: 0x0006CA4B File Offset: 0x0006AC4B
		static vtkImporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004A9F RID: 19103 RVA: 0x0006CA73 File Offset: 0x0006AC73
		public vtkImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004AA0 RID: 19104 RVA: 0x0006CA81 File Offset: 0x0006AC81
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004AA1 RID: 19105
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImporter_DisableAnimation_01(HandleRef pThis, long arg0);

		/// <summary>
		/// Enable/Disable/Get the status of specific animations
		/// </summary>
		// Token: 0x06004AA2 RID: 19106 RVA: 0x0006CA8C File Offset: 0x0006AC8C
		public virtual void DisableAnimation(long arg0)
		{
			vtkImporter.vtkImporter_DisableAnimation_01(base.GetCppThis(), arg0);
		}

		// Token: 0x06004AA3 RID: 19107
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImporter_EnableAnimation_02(HandleRef pThis, long arg0);

		/// <summary>
		/// Enable/Disable/Get the status of specific animations
		/// </summary>
		// Token: 0x06004AA4 RID: 19108 RVA: 0x0006CA9C File Offset: 0x0006AC9C
		public virtual void EnableAnimation(long arg0)
		{
			vtkImporter.vtkImporter_EnableAnimation_02(base.GetCppThis(), arg0);
		}

		// Token: 0x06004AA5 RID: 19109
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkImporter_GetAnimationName_03(HandleRef pThis, long arg0);

		/// <summary>
		/// Get the name of an animation.
		/// Return an empty if not provided by implementation.
		/// </summary>
		// Token: 0x06004AA6 RID: 19110 RVA: 0x0006CAAC File Offset: 0x0006ACAC
		public virtual string GetAnimationName(long arg0)
		{
			return vtkImporter.vtkImporter_GetAnimationName_03(base.GetCppThis(), arg0);
		}

		// Token: 0x06004AA7 RID: 19111
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkImporter_GetCameraName_04(HandleRef pThis, long arg0);

		/// <summary>
		/// Get the name of a camera.
		/// Return an empty string if not provided by implementation.
		/// </summary>
		// Token: 0x06004AA8 RID: 19112 RVA: 0x0006CACC File Offset: 0x0006ACCC
		public virtual string GetCameraName(long arg0)
		{
			return vtkImporter.vtkImporter_GetCameraName_04(base.GetCppThis(), arg0);
		}

		// Token: 0x06004AA9 RID: 19113
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImporter_GetNumberOfAnimations_05(HandleRef pThis);

		/// <summary>
		/// Get the number of available animations.
		/// Return -1 if not provided by implementation.
		/// </summary>
		// Token: 0x06004AAA RID: 19114 RVA: 0x0006CAEC File Offset: 0x0006ACEC
		public virtual long GetNumberOfAnimations()
		{
			return vtkImporter.vtkImporter_GetNumberOfAnimations_05(base.GetCppThis());
		}

		// Token: 0x06004AAB RID: 19115
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImporter_GetNumberOfCameras_06(HandleRef pThis);

		/// <summary>
		/// Get the number of available cameras.
		/// Return 0 if not provided by implementation.
		/// </summary>
		// Token: 0x06004AAC RID: 19116 RVA: 0x0006CB0C File Offset: 0x0006AD0C
		public virtual long GetNumberOfCameras()
		{
			return vtkImporter.vtkImporter_GetNumberOfCameras_06(base.GetCppThis());
		}

		// Token: 0x06004AAD RID: 19117
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImporter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AAE RID: 19118 RVA: 0x0006CB2C File Offset: 0x0006AD2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImporter.vtkImporter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06004AAF RID: 19119
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImporter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AB0 RID: 19120 RVA: 0x0006CB4C File Offset: 0x0006AD4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImporter.vtkImporter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06004AB1 RID: 19121
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkImporter_GetOutputsDescription_09(HandleRef pThis);

		/// <summary>
		/// Recover a printable string that let importer implementation
		/// Describe their outputs.
		/// </summary>
		// Token: 0x06004AB2 RID: 19122 RVA: 0x0006CB68 File Offset: 0x0006AD68
		public virtual string GetOutputsDescription()
		{
			return vtkImporter.vtkImporter_GetOutputsDescription_09(base.GetCppThis());
		}

		// Token: 0x06004AB3 RID: 19123
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImporter_GetRenderWindow_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the vtkRenderWindow to contain the imported actors, cameras and
		/// lights, If no vtkRenderWindow is set, one will be created and can be
		/// obtained with the GetRenderWindow method. If the vtkRenderWindow has been
		/// specified, the first vtkRenderer it has will be used to import the
		/// objects. If the vtkRenderWindow has no Renderer, one will be created and
		/// can be accessed using GetRenderer.
		/// </summary>
		// Token: 0x06004AB4 RID: 19124 RVA: 0x0006CB88 File Offset: 0x0006AD88
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImporter.vtkImporter_GetRenderWindow_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06004AB5 RID: 19125
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImporter_GetRenderer_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the renderer that contains the imported actors, cameras and
		/// lights.
		/// </summary>
		// Token: 0x06004AB6 RID: 19126 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImporter.vtkImporter_GetRenderer_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06004AB7 RID: 19127
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImporter_GetTemporalInformation_12(HandleRef pThis, long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, HandleRef timeSteps);

		/// <summary>
		/// Get temporal information for the provided animationIndex and frameRate.
		/// This implementation return false, but concrete class implementation
		/// behavior is as follows.
		/// frameRate is used to define the number of frames for one second of simulation,
		/// set to zero if timeSteps are not needed.
		/// If animation is present in the dataset, timeRange should be set by this method, return true.
		/// If animation is present and frameRate &gt; 0, nbTimeSteps and timeSteps should also be set, return
		/// true. If animation is not present, return false.
		/// </summary>
		// Token: 0x06004AB8 RID: 19128 RVA: 0x0006CC68 File Offset: 0x0006AE68
		public virtual bool GetTemporalInformation(long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, vtkDoubleArray timeSteps)
		{
			return vtkImporter.vtkImporter_GetTemporalInformation_12(base.GetCppThis(), animationIndex, frameRate, ref nbTimeSteps, timeRange, (timeSteps == null) ? default(HandleRef) : timeSteps.GetCppThis()) != 0;
		}

		// Token: 0x06004AB9 RID: 19129
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImporter_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004ABA RID: 19130 RVA: 0x0006CCAC File Offset: 0x0006AEAC
		public override int IsA(string type)
		{
			return vtkImporter.vtkImporter_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06004ABB RID: 19131
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImporter_IsAnimationEnabled_14(HandleRef pThis, long arg0);

		/// <summary>
		/// Enable/Disable/Get the status of specific animations
		/// </summary>
		// Token: 0x06004ABC RID: 19132 RVA: 0x0006CCCC File Offset: 0x0006AECC
		public virtual bool IsAnimationEnabled(long arg0)
		{
			return vtkImporter.vtkImporter_IsAnimationEnabled_14(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x06004ABD RID: 19133
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImporter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004ABE RID: 19134 RVA: 0x0006CCF4 File Offset: 0x0006AEF4
		public new static int IsTypeOf(string type)
		{
			return vtkImporter.vtkImporter_IsTypeOf_15(type);
		}

		// Token: 0x06004ABF RID: 19135
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImporter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AC0 RID: 19136 RVA: 0x0006CD10 File Offset: 0x0006AF10
		public new vtkImporter NewInstance()
		{
			vtkImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImporter.vtkImporter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004AC1 RID: 19137
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImporter_Read_17(HandleRef pThis);

		/// <summary>
		/// Import the actors, cameras, lights and properties into a vtkRenderWindow.
		/// </summary>
		// Token: 0x06004AC2 RID: 19138 RVA: 0x0006CD6A File Offset: 0x0006AF6A
		public void Read()
		{
			vtkImporter.vtkImporter_Read_17(base.GetCppThis());
		}

		// Token: 0x06004AC3 RID: 19139
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImporter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004AC4 RID: 19140 RVA: 0x0006CD7C File Offset: 0x0006AF7C
		public new static vtkImporter SafeDownCast(vtkObjectBase o)
		{
			vtkImporter vtkImporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImporter.vtkImporter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImporter = (vtkImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImporter.Register(null);
				}
			}
			return vtkImporter;
		}

		// Token: 0x06004AC5 RID: 19141
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImporter_SetCamera_19(HandleRef pThis, long arg0);

		/// <summary>
		/// Enable a specific camera.
		/// If a negative index is provided, no camera from the importer is used.
		/// Does nothing if not provided by implementation.
		/// </summary>
		// Token: 0x06004AC6 RID: 19142 RVA: 0x0006CDFB File Offset: 0x0006AFFB
		public virtual void SetCamera(long arg0)
		{
			vtkImporter.vtkImporter_SetCamera_19(base.GetCppThis(), arg0);
		}

		// Token: 0x06004AC7 RID: 19143
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImporter_SetRenderWindow_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the vtkRenderWindow to contain the imported actors, cameras and
		/// lights, If no vtkRenderWindow is set, one will be created and can be
		/// obtained with the GetRenderWindow method. If the vtkRenderWindow has been
		/// specified, the first vtkRenderer it has will be used to import the
		/// objects. If the vtkRenderWindow has no Renderer, one will be created and
		/// can be accessed using GetRenderer.
		/// </summary>
		// Token: 0x06004AC8 RID: 19144 RVA: 0x0006CE0C File Offset: 0x0006B00C
		public virtual void SetRenderWindow(vtkRenderWindow arg0)
		{
			vtkImporter.vtkImporter_SetRenderWindow_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06004AC9 RID: 19145
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImporter_Update_21(HandleRef pThis);

		/// <summary>
		/// Import the actors, cameras, lights and properties into a vtkRenderWindow.
		/// </summary>
		// Token: 0x06004ACA RID: 19146 RVA: 0x0006CE3B File Offset: 0x0006B03B
		public void Update()
		{
			vtkImporter.vtkImporter_Update_21(base.GetCppThis());
		}

		// Token: 0x06004ACB RID: 19147
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImporter_UpdateTimeStep_22(HandleRef pThis, double timeValue);

		/// <summary>
		/// Import the actors, camera, lights and properties at a specific time value.
		/// If not reimplemented, only call Update().
		/// </summary>
		// Token: 0x06004ACC RID: 19148 RVA: 0x0006CE4A File Offset: 0x0006B04A
		public virtual void UpdateTimeStep(double timeValue)
		{
			vtkImporter.vtkImporter_UpdateTimeStep_22(base.GetCppThis(), timeValue);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000759 RID: 1881
		public new const string MRFullTypeName = "Kitware.VTK.vtkImporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400075A RID: 1882
		public new static readonly string MRClassNameKey = "class vtkImporter";
	}
}
