using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRCamera
	/// </summary>
	/// <remarks>
	///    OpenXR camera
	///
	/// vtkOpenXRCamera is a concrete implementation of the abstract class
	/// vtkCamera.
	///
	/// vtkOpenXRCamera interfaces to the OpenXR rendering library.
	///
	/// It sets a custom view transform and projection matrix from the view pose and projection
	/// fov given by vtkOpenXRManager
	/// </remarks>
	// Token: 0x020000A2 RID: 162
	public class vtkOpenXRCamera : vtkVRHMDCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060022E5 RID: 8933 RVA: 0x00034473 File Offset: 0x00032673
		static vtkOpenXRCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060022E6 RID: 8934 RVA: 0x0003449B File Offset: 0x0003269B
		public vtkOpenXRCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060022E7 RID: 8935
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022E8 RID: 8936 RVA: 0x000344AC File Offset: 0x000326AC
		public new static vtkOpenXRCamera New()
		{
			vtkOpenXRCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRCamera.vtkOpenXRCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022E9 RID: 8937 RVA: 0x00034500 File Offset: 0x00032700
		public vtkOpenXRCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRCamera.vtkOpenXRCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060022EA RID: 8938 RVA: 0x00034544 File Offset: 0x00032744
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060022EB RID: 8939
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022EC RID: 8940 RVA: 0x00034550 File Offset: 0x00032750
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRCamera.vtkOpenXRCamera_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060022ED RID: 8941
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRCamera_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022EE RID: 8942 RVA: 0x00034570 File Offset: 0x00032770
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRCamera.vtkOpenXRCamera_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060022EF RID: 8943
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRCamera_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022F0 RID: 8944 RVA: 0x0003458C File Offset: 0x0003278C
		public override int IsA(string type)
		{
			return vtkOpenXRCamera.vtkOpenXRCamera_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060022F1 RID: 8945
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRCamera_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022F2 RID: 8946 RVA: 0x000345AC File Offset: 0x000327AC
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRCamera.vtkOpenXRCamera_IsTypeOf_04(type);
		}

		// Token: 0x060022F3 RID: 8947
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022F4 RID: 8948 RVA: 0x000345C8 File Offset: 0x000327C8
		public new vtkOpenXRCamera NewInstance()
		{
			vtkOpenXRCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRCamera.vtkOpenXRCamera_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060022F5 RID: 8949
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRCamera_Render_07(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x060022F6 RID: 8950 RVA: 0x00034624 File Offset: 0x00032824
		public override void Render(vtkRenderer ren)
		{
			vtkOpenXRCamera.vtkOpenXRCamera_Render_07(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060022F7 RID: 8951
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRCamera_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060022F8 RID: 8952 RVA: 0x00034654 File Offset: 0x00032854
		public new static vtkOpenXRCamera SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRCamera vtkOpenXRCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRCamera.vtkOpenXRCamera_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRCamera = (vtkOpenXRCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRCamera.Register(null);
				}
			}
			return vtkOpenXRCamera;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000525 RID: 1317
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000526 RID: 1318
		public new static readonly string MRClassNameKey = "class vtkOpenXRCamera";
	}
}
