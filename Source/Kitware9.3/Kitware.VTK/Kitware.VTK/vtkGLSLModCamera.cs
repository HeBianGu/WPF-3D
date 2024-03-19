using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLSLModCamera
	/// </summary>
	/// <remarks>
	///    Implement light kit support in the OpenGL rendereR.
	/// </remarks>
	// Token: 0x02000593 RID: 1427
	public class vtkGLSLModCamera : vtkGLSLModifierBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FB96 RID: 64406 RVA: 0x0015DFCF File Offset: 0x0015C1CF
		static vtkGLSLModCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLModCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLModCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB97 RID: 64407 RVA: 0x0015DFF7 File Offset: 0x0015C1F7
		public vtkGLSLModCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FB98 RID: 64408
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB99 RID: 64409 RVA: 0x0015E008 File Offset: 0x0015C208
		public new static vtkGLSLModCamera New()
		{
			vtkGLSLModCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModCamera.vtkGLSLModCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB9A RID: 64410 RVA: 0x0015E05C File Offset: 0x0015C25C
		public vtkGLSLModCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLSLModCamera.vtkGLSLModCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB9B RID: 64411 RVA: 0x0015E0A0 File Offset: 0x0015C2A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FB9C RID: 64412
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB9D RID: 64413 RVA: 0x0015E0AC File Offset: 0x0015C2AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLSLModCamera.vtkGLSLModCamera_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FB9E RID: 64414
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModCamera_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB9F RID: 64415 RVA: 0x0015E0CC File Offset: 0x0015C2CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLSLModCamera.vtkGLSLModCamera_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FBA0 RID: 64416
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModCamera_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBA1 RID: 64417 RVA: 0x0015E0E8 File Offset: 0x0015C2E8
		public override int IsA(string type)
		{
			return vtkGLSLModCamera.vtkGLSLModCamera_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FBA2 RID: 64418
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModCamera_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBA3 RID: 64419 RVA: 0x0015E108 File Offset: 0x0015C308
		public new static int IsTypeOf(string type)
		{
			return vtkGLSLModCamera.vtkGLSLModCamera_IsTypeOf_04(type);
		}

		// Token: 0x0600FBA4 RID: 64420
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModCamera_IsUpToDate_05(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBA5 RID: 64421 RVA: 0x0015E124 File Offset: 0x0015C324
		public override bool IsUpToDate(vtkOpenGLRenderer arg0, vtkAbstractMapper arg1, vtkActor arg2)
		{
			return vtkGLSLModCamera.vtkGLSLModCamera_IsUpToDate_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis()) != 0;
		}

		// Token: 0x0600FBA6 RID: 64422
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModCamera_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBA7 RID: 64423 RVA: 0x0015E18C File Offset: 0x0015C38C
		public new vtkGLSLModCamera NewInstance()
		{
			vtkGLSLModCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModCamera.vtkGLSLModCamera_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FBA8 RID: 64424
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModCamera_ReplaceShaderValues_08(HandleRef pThis, HandleRef arg0, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg3, HandleRef arg4, HandleRef arg5);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBA9 RID: 64425 RVA: 0x0015E1E8 File Offset: 0x0015C3E8
		public override bool ReplaceShaderValues(vtkOpenGLRenderer arg0, string arg1, string arg2, string arg3, vtkAbstractMapper arg4, vtkActor arg5)
		{
			return vtkGLSLModCamera.vtkGLSLModCamera_ReplaceShaderValues_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis(), (arg5 == null) ? default(HandleRef) : arg5.GetCppThis()) != 0;
		}

		// Token: 0x0600FBAA RID: 64426
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModCamera_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBAB RID: 64427 RVA: 0x0015E258 File Offset: 0x0015C458
		public new static vtkGLSLModCamera SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLModCamera vtkGLSLModCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModCamera.vtkGLSLModCamera_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLModCamera = (vtkGLSLModCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLModCamera.Register(null);
				}
			}
			return vtkGLSLModCamera;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400124E RID: 4686
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLModCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400124F RID: 4687
		public new static readonly string MRClassNameKey = "class vtkGLSLModCamera";
	}
}
