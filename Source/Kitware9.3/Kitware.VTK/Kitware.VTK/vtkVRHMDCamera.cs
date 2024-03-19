using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRHMDCamera
	/// </summary>
	/// <remarks>
	///    A superclass for HMD style cameras
	///
	/// </remarks>
	// Token: 0x020000A1 RID: 161
	public abstract class vtkVRHMDCamera : vtkVRCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060022D0 RID: 8912 RVA: 0x000341F4 File Offset: 0x000323F4
		static vtkVRHMDCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRHMDCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRHMDCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060022D1 RID: 8913 RVA: 0x0003421C File Offset: 0x0003241C
		public vtkVRHMDCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060022D2 RID: 8914 RVA: 0x0003422A File Offset: 0x0003242A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060022D3 RID: 8915
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRHMDCamera_GetKeyMatrices_01(HandleRef pThis, HandleRef ren, HandleRef WCVCMatrix, HandleRef normalMatrix, HandleRef VCDCMatrix, HandleRef WCDCMatrix);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x060022D4 RID: 8916 RVA: 0x00034238 File Offset: 0x00032438
		public override void GetKeyMatrices(vtkRenderer ren, vtkMatrix4x4 WCVCMatrix, vtkMatrix3x3 normalMatrix, vtkMatrix4x4 VCDCMatrix, vtkMatrix4x4 WCDCMatrix)
		{
			vtkVRHMDCamera.vtkVRHMDCamera_GetKeyMatrices_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (WCVCMatrix == null) ? default(HandleRef) : WCVCMatrix.GetCppThis(), (normalMatrix == null) ? default(HandleRef) : normalMatrix.GetCppThis(), (VCDCMatrix == null) ? default(HandleRef) : VCDCMatrix.GetCppThis(), (WCDCMatrix == null) ? default(HandleRef) : WCDCMatrix.GetCppThis());
		}

		// Token: 0x060022D5 RID: 8917
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRHMDCamera_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022D6 RID: 8918 RVA: 0x000342C0 File Offset: 0x000324C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRHMDCamera.vtkVRHMDCamera_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060022D7 RID: 8919
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRHMDCamera_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022D8 RID: 8920 RVA: 0x000342E0 File Offset: 0x000324E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRHMDCamera.vtkVRHMDCamera_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060022D9 RID: 8921
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRHMDCamera_GetPhysicalToProjectionMatrix_04(HandleRef pThis, HandleRef physicalToProjectionMatrtix);

		/// <summary>
		/// Provides a matrix to go from physical coordinates to projection coordinates
		/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
		/// PhysicalToLeftEye
		/// </summary>
		// Token: 0x060022DA RID: 8922 RVA: 0x000342FC File Offset: 0x000324FC
		public override void GetPhysicalToProjectionMatrix(vtkMatrix4x4 physicalToProjectionMatrtix)
		{
			vtkVRHMDCamera.vtkVRHMDCamera_GetPhysicalToProjectionMatrix_04(base.GetCppThis(), (physicalToProjectionMatrtix == null) ? default(HandleRef) : physicalToProjectionMatrtix.GetCppThis());
		}

		// Token: 0x060022DB RID: 8923
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRHMDCamera_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022DC RID: 8924 RVA: 0x0003432C File Offset: 0x0003252C
		public override int IsA(string type)
		{
			return vtkVRHMDCamera.vtkVRHMDCamera_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060022DD RID: 8925
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRHMDCamera_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022DE RID: 8926 RVA: 0x0003434C File Offset: 0x0003254C
		public new static int IsTypeOf(string type)
		{
			return vtkVRHMDCamera.vtkVRHMDCamera_IsTypeOf_06(type);
		}

		// Token: 0x060022DF RID: 8927
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRHMDCamera_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022E0 RID: 8928 RVA: 0x00034368 File Offset: 0x00032568
		public new vtkVRHMDCamera NewInstance()
		{
			vtkVRHMDCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRHMDCamera.vtkVRHMDCamera_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRHMDCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060022E1 RID: 8929
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRHMDCamera_Render_08(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x060022E2 RID: 8930 RVA: 0x000343C4 File Offset: 0x000325C4
		public override void Render(vtkRenderer ren)
		{
			vtkVRHMDCamera.vtkVRHMDCamera_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060022E3 RID: 8931
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRHMDCamera_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022E4 RID: 8932 RVA: 0x000343F4 File Offset: 0x000325F4
		public new static vtkVRHMDCamera SafeDownCast(vtkObjectBase o)
		{
			vtkVRHMDCamera vtkVRHMDCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRHMDCamera.vtkVRHMDCamera_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRHMDCamera = (vtkVRHMDCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRHMDCamera.Register(null);
				}
			}
			return vtkVRHMDCamera;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000523 RID: 1315
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRHMDCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000524 RID: 1316
		public new static readonly string MRClassNameKey = "class vtkVRHMDCamera";
	}
}
