using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLCamera
	/// </summary>
	/// <remarks>
	///    OpenGL camera
	///
	/// vtkOpenGLCamera is a concrete implementation of the abstract class
	/// vtkCamera.  vtkOpenGLCamera interfaces to the OpenGL rendering library.
	/// </remarks>
	// Token: 0x0200009F RID: 159
	public class vtkOpenGLCamera : vtkCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060022A3 RID: 8867 RVA: 0x00033CBA File Offset: 0x00031EBA
		static vtkOpenGLCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060022A4 RID: 8868 RVA: 0x00033CE2 File Offset: 0x00031EE2
		public vtkOpenGLCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060022A5 RID: 8869
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022A6 RID: 8870 RVA: 0x00033CF0 File Offset: 0x00031EF0
		public new static vtkOpenGLCamera New()
		{
			vtkOpenGLCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCamera.vtkOpenGLCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022A7 RID: 8871 RVA: 0x00033D44 File Offset: 0x00031F44
		public vtkOpenGLCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLCamera.vtkOpenGLCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060022A8 RID: 8872 RVA: 0x00033D88 File Offset: 0x00031F88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060022A9 RID: 8873
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCamera_GetKeyMatrices_01(HandleRef pThis, HandleRef ren, HandleRef WCVCMatrix, HandleRef normalMatrix, HandleRef VCDCMatrix, HandleRef WCDCMatrix);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x060022AA RID: 8874 RVA: 0x00033D94 File Offset: 0x00031F94
		public virtual void GetKeyMatrices(vtkRenderer ren, vtkMatrix4x4 WCVCMatrix, vtkMatrix3x3 normalMatrix, vtkMatrix4x4 VCDCMatrix, vtkMatrix4x4 WCDCMatrix)
		{
			vtkOpenGLCamera.vtkOpenGLCamera_GetKeyMatrices_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (WCVCMatrix == null) ? default(HandleRef) : WCVCMatrix.GetCppThis(), (normalMatrix == null) ? default(HandleRef) : normalMatrix.GetCppThis(), (VCDCMatrix == null) ? default(HandleRef) : VCDCMatrix.GetCppThis(), (WCDCMatrix == null) ? default(HandleRef) : WCDCMatrix.GetCppThis());
		}

		// Token: 0x060022AB RID: 8875
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCamera_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022AC RID: 8876 RVA: 0x00033E1C File Offset: 0x0003201C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLCamera.vtkOpenGLCamera_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060022AD RID: 8877
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCamera_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022AE RID: 8878 RVA: 0x00033E3C File Offset: 0x0003203C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLCamera.vtkOpenGLCamera_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060022AF RID: 8879
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCamera_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022B0 RID: 8880 RVA: 0x00033E58 File Offset: 0x00032058
		public override int IsA(string type)
		{
			return vtkOpenGLCamera.vtkOpenGLCamera_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060022B1 RID: 8881
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCamera_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022B2 RID: 8882 RVA: 0x00033E78 File Offset: 0x00032078
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLCamera.vtkOpenGLCamera_IsTypeOf_05(type);
		}

		// Token: 0x060022B3 RID: 8883
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCamera_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022B4 RID: 8884 RVA: 0x00033E94 File Offset: 0x00032094
		public new vtkOpenGLCamera NewInstance()
		{
			vtkOpenGLCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCamera.vtkOpenGLCamera_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060022B5 RID: 8885
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCamera_Render_08(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x060022B6 RID: 8886 RVA: 0x00033EF0 File Offset: 0x000320F0
		public override void Render(vtkRenderer ren)
		{
			vtkOpenGLCamera.vtkOpenGLCamera_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060022B7 RID: 8887
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCamera_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022B8 RID: 8888 RVA: 0x00033F20 File Offset: 0x00032120
		public new static vtkOpenGLCamera SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLCamera vtkOpenGLCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCamera.vtkOpenGLCamera_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLCamera = (vtkOpenGLCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLCamera.Register(null);
				}
			}
			return vtkOpenGLCamera;
		}

		// Token: 0x060022B9 RID: 8889
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCamera_UpdateViewport_10(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x060022BA RID: 8890 RVA: 0x00033FA0 File Offset: 0x000321A0
		public override void UpdateViewport(vtkRenderer ren)
		{
			vtkOpenGLCamera.vtkOpenGLCamera_UpdateViewport_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400051F RID: 1311
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000520 RID: 1312
		public new static readonly string MRClassNameKey = "class vtkOpenGLCamera";
	}
}
