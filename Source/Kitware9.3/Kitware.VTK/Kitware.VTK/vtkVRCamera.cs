using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRCamera
	/// </summary>
	/// <remarks>
	///    VR camera
	///
	/// vtkVRCamera is a concrete implementation of the abstract class
	/// vtkCamera.  vtkVRCamera interfaces to the VR rendering library.
	/// </remarks>
	// Token: 0x020000A0 RID: 160
	public abstract class vtkVRCamera : vtkOpenGLCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060022BB RID: 8891 RVA: 0x00033FCF File Offset: 0x000321CF
		static vtkVRCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060022BC RID: 8892 RVA: 0x00033FF7 File Offset: 0x000321F7
		public vtkVRCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060022BD RID: 8893 RVA: 0x00034005 File Offset: 0x00032205
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060022BE RID: 8894
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022BF RID: 8895 RVA: 0x00034010 File Offset: 0x00032210
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRCamera.vtkVRCamera_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060022C0 RID: 8896
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRCamera_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022C1 RID: 8897 RVA: 0x00034030 File Offset: 0x00032230
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRCamera.vtkVRCamera_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060022C2 RID: 8898
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRCamera_GetPhysicalToProjectionMatrix_03(HandleRef pThis, HandleRef physicalToProjectionMatrix);

		/// <summary>
		/// Provides a matrix to go from physical coordinates to projection coordinates
		/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
		/// PhysicalToLeftEye
		/// </summary>
		// Token: 0x060022C3 RID: 8899 RVA: 0x0003404C File Offset: 0x0003224C
		public virtual void GetPhysicalToProjectionMatrix(vtkMatrix4x4 physicalToProjectionMatrix)
		{
			vtkVRCamera.vtkVRCamera_GetPhysicalToProjectionMatrix_03(base.GetCppThis(), (physicalToProjectionMatrix == null) ? default(HandleRef) : physicalToProjectionMatrix.GetCppThis());
		}

		// Token: 0x060022C4 RID: 8900
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRCamera_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022C5 RID: 8901 RVA: 0x0003407C File Offset: 0x0003227C
		public override int IsA(string type)
		{
			return vtkVRCamera.vtkVRCamera_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060022C6 RID: 8902
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRCamera_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022C7 RID: 8903 RVA: 0x0003409C File Offset: 0x0003229C
		public new static int IsTypeOf(string type)
		{
			return vtkVRCamera.vtkVRCamera_IsTypeOf_05(type);
		}

		// Token: 0x060022C8 RID: 8904
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022C9 RID: 8905 RVA: 0x000340B8 File Offset: 0x000322B8
		public new vtkVRCamera NewInstance()
		{
			vtkVRCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRCamera.vtkVRCamera_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060022CA RID: 8906
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRCamera_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022CB RID: 8907 RVA: 0x00034114 File Offset: 0x00032314
		public new static vtkVRCamera SafeDownCast(vtkObjectBase o)
		{
			vtkVRCamera vtkVRCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRCamera.vtkVRCamera_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRCamera = (vtkVRCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRCamera.Register(null);
				}
			}
			return vtkVRCamera;
		}

		// Token: 0x060022CC RID: 8908
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRCamera_SetCameraFromDeviceToWorldMatrix_08(HandleRef pThis, HandleRef mat, double distance);

		/// <summary>
		/// Provides a matrix to go from physical coordinates to projection coordinates
		/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
		/// PhysicalToLeftEye
		/// </summary>
		// Token: 0x060022CD RID: 8909 RVA: 0x00034194 File Offset: 0x00032394
		public void SetCameraFromDeviceToWorldMatrix(vtkMatrix4x4 mat, double distance)
		{
			vtkVRCamera.vtkVRCamera_SetCameraFromDeviceToWorldMatrix_08(base.GetCppThis(), (mat == null) ? default(HandleRef) : mat.GetCppThis(), distance);
		}

		// Token: 0x060022CE RID: 8910
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRCamera_SetCameraFromWorldToDeviceMatrix_09(HandleRef pThis, HandleRef mat, double distance);

		/// <summary>
		/// Provides a matrix to go from physical coordinates to projection coordinates
		/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
		/// PhysicalToLeftEye
		/// </summary>
		// Token: 0x060022CF RID: 8911 RVA: 0x000341C4 File Offset: 0x000323C4
		public void SetCameraFromWorldToDeviceMatrix(vtkMatrix4x4 mat, double distance)
		{
			vtkVRCamera.vtkVRCamera_SetCameraFromWorldToDeviceMatrix_09(base.GetCppThis(), (mat == null) ? default(HandleRef) : mat.GetCppThis(), distance);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000521 RID: 1313
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000522 RID: 1314
		public new static readonly string MRClassNameKey = "class vtkVRCamera";
	}
}
