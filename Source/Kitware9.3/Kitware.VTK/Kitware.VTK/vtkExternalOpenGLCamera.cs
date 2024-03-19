using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExternalOpenGLCamera
	/// </summary>
	/// <remarks>
	///    OpenGL camera
	///
	/// vtkExternalOpenGLCamera is a concrete implementation of the abstract class
	/// vtkCamera.  vtkExternalOpenGLCamera interfaces to the OpenGL rendering library.
	/// This class extends vtkOpenGLCamera by introducing API wherein the camera
	/// matrices can be set explicitly by the application.
	/// </remarks>
	// Token: 0x0200011A RID: 282
	public class vtkExternalOpenGLCamera : vtkOpenGLCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060039B3 RID: 14771 RVA: 0x000541CF File Offset: 0x000523CF
		static vtkExternalOpenGLCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExternalOpenGLCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalOpenGLCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060039B4 RID: 14772 RVA: 0x000541F7 File Offset: 0x000523F7
		public vtkExternalOpenGLCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060039B5 RID: 14773
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039B6 RID: 14774 RVA: 0x00054208 File Offset: 0x00052408
		public new static vtkExternalOpenGLCamera New()
		{
			vtkExternalOpenGLCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalOpenGLCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039B7 RID: 14775 RVA: 0x0005425C File Offset: 0x0005245C
		public vtkExternalOpenGLCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060039B8 RID: 14776 RVA: 0x000542A0 File Offset: 0x000524A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060039B9 RID: 14777
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039BA RID: 14778 RVA: 0x000542AC File Offset: 0x000524AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060039BB RID: 14779
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039BC RID: 14780 RVA: 0x000542CC File Offset: 0x000524CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060039BD RID: 14781
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLCamera_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039BE RID: 14782 RVA: 0x000542E8 File Offset: 0x000524E8
		public override int IsA(string type)
		{
			return vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060039BF RID: 14783
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLCamera_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039C0 RID: 14784 RVA: 0x00054308 File Offset: 0x00052508
		public new static int IsTypeOf(string type)
		{
			return vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_IsTypeOf_04(type);
		}

		// Token: 0x060039C1 RID: 14785
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039C2 RID: 14786 RVA: 0x00054324 File Offset: 0x00052524
		public new vtkExternalOpenGLCamera NewInstance()
		{
			vtkExternalOpenGLCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalOpenGLCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060039C3 RID: 14787
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLCamera_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039C4 RID: 14788 RVA: 0x00054380 File Offset: 0x00052580
		public new static vtkExternalOpenGLCamera SafeDownCast(vtkObjectBase o)
		{
			vtkExternalOpenGLCamera vtkExternalOpenGLCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExternalOpenGLCamera = (vtkExternalOpenGLCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExternalOpenGLCamera.Register(null);
				}
			}
			return vtkExternalOpenGLCamera;
		}

		// Token: 0x060039C5 RID: 14789
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLCamera_SetProjectionTransformMatrix_08(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set the projection matrix
		/// </summary>
		// Token: 0x060039C6 RID: 14790 RVA: 0x000543FF File Offset: 0x000525FF
		public void SetProjectionTransformMatrix(IntPtr elements)
		{
			vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_SetProjectionTransformMatrix_08(base.GetCppThis(), elements);
		}

		// Token: 0x060039C7 RID: 14791
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLCamera_SetViewTransformMatrix_09(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set the view transform matrix
		/// </summary>
		// Token: 0x060039C8 RID: 14792 RVA: 0x0005440F File Offset: 0x0005260F
		public void SetViewTransformMatrix(IntPtr elements)
		{
			vtkExternalOpenGLCamera.vtkExternalOpenGLCamera_SetViewTransformMatrix_09(base.GetCppThis(), elements);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400066D RID: 1645
		public new const string MRFullTypeName = "Kitware.VTK.vtkExternalOpenGLCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400066E RID: 1646
		public new static readonly string MRClassNameKey = "class vtkExternalOpenGLCamera";
	}
}
