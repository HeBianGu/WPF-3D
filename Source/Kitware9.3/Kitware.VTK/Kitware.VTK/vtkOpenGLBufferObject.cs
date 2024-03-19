using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///  OpenGL buffer object
	///
	/// OpenGL buffer object to store index, geometry and/or attribute data on the
	/// GPU.
	/// </remarks>
	// Token: 0x020005A0 RID: 1440
	public class vtkOpenGLBufferObject : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FCB9 RID: 64697 RVA: 0x00160227 File Offset: 0x0015E427
		static vtkOpenGLBufferObject()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLBufferObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLBufferObject"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FCBA RID: 64698 RVA: 0x0016024F File Offset: 0x0015E44F
		public vtkOpenGLBufferObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FCBB RID: 64699
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBufferObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCBC RID: 64700 RVA: 0x00160260 File Offset: 0x0015E460
		public new static vtkOpenGLBufferObject New()
		{
			vtkOpenGLBufferObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBufferObject.vtkOpenGLBufferObject_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCBD RID: 64701 RVA: 0x001602B4 File Offset: 0x0015E4B4
		public vtkOpenGLBufferObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLBufferObject.vtkOpenGLBufferObject_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FCBE RID: 64702 RVA: 0x001602F8 File Offset: 0x0015E4F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FCBF RID: 64703
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLBufferObject_Bind_01(HandleRef pThis);

		/// <summary>
		/// Bind the buffer object ready for rendering.
		/// @note Only one ARRAY_BUFFER and one ELEMENT_ARRAY_BUFFER may be bound at
		/// any time.
		/// </summary>
		// Token: 0x0600FCC0 RID: 64704 RVA: 0x00160304 File Offset: 0x0015E504
		public bool Bind()
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_Bind_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FCC1 RID: 64705
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLBufferObject_GenerateBuffer_02(HandleRef pThis, vtkOpenGLBufferObject.ObjectType type);

		/// <summary>
		/// Generate the opengl buffer for this Handle 
		/// </summary>
		// Token: 0x0600FCC2 RID: 64706 RVA: 0x0016032C File Offset: 0x0015E52C
		public bool GenerateBuffer(vtkOpenGLBufferObject.ObjectType type)
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_GenerateBuffer_02(base.GetCppThis(), type) != 0;
		}

		// Token: 0x0600FCC3 RID: 64707
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOpenGLBufferObject_GetError_03(HandleRef pThis);

		/// <summary>
		/// Return a string describing errors.
		/// </summary>
		// Token: 0x0600FCC4 RID: 64708 RVA: 0x00160354 File Offset: 0x0015E554
		public string GetError()
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_GetError_03(base.GetCppThis());
		}

		// Token: 0x0600FCC5 RID: 64709
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBufferObject_GetHandle_04(HandleRef pThis);

		/// <summary>
		/// Get the handle of the buffer object. 
		/// </summary>
		// Token: 0x0600FCC6 RID: 64710 RVA: 0x00160374 File Offset: 0x0015E574
		public int GetHandle()
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_GetHandle_04(base.GetCppThis());
		}

		// Token: 0x0600FCC7 RID: 64711
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLBufferObject_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCC8 RID: 64712 RVA: 0x00160394 File Offset: 0x0015E594
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600FCC9 RID: 64713
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLBufferObject_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCCA RID: 64714 RVA: 0x001603B4 File Offset: 0x0015E5B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600FCCB RID: 64715
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkOpenGLBufferObject.ObjectType vtkOpenGLBufferObject_GetType_07(HandleRef pThis);

		/// <summary>
		/// Get the type of the buffer object. 
		/// </summary>
		// Token: 0x0600FCCC RID: 64716 RVA: 0x001603D0 File Offset: 0x0015E5D0
		public vtkOpenGLBufferObject.ObjectType GetTypeWrapper()
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_GetType_07(base.GetCppThis());
		}

		// Token: 0x0600FCCD RID: 64717
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBufferObject_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCCE RID: 64718 RVA: 0x001603F0 File Offset: 0x0015E5F0
		public override int IsA(string type)
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600FCCF RID: 64719
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLBufferObject_IsReady_09(HandleRef pThis);

		/// <summary>
		/// Determine if the buffer object is ready to be used. 
		/// </summary>
		// Token: 0x0600FCD0 RID: 64720 RVA: 0x00160410 File Offset: 0x0015E610
		public bool IsReady()
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_IsReady_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FCD1 RID: 64721
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBufferObject_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCD2 RID: 64722 RVA: 0x00160438 File Offset: 0x0015E638
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_IsTypeOf_10(type);
		}

		// Token: 0x0600FCD3 RID: 64723
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBufferObject_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCD4 RID: 64724 RVA: 0x00160454 File Offset: 0x0015E654
		public new vtkOpenGLBufferObject NewInstance()
		{
			vtkOpenGLBufferObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBufferObject.vtkOpenGLBufferObject_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FCD5 RID: 64725
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLBufferObject_Release_13(HandleRef pThis);

		/// <summary>
		/// Release the buffer. This should be done after rendering is complete.
		/// </summary>
		// Token: 0x0600FCD6 RID: 64726 RVA: 0x001604B0 File Offset: 0x0015E6B0
		public bool Release()
		{
			return vtkOpenGLBufferObject.vtkOpenGLBufferObject_Release_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FCD7 RID: 64727
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLBufferObject_ReleaseGraphicsResources_14(HandleRef pThis);

		/// <summary>
		/// Release the buffer. This should be done after rendering is complete.
		/// </summary>
		// Token: 0x0600FCD8 RID: 64728 RVA: 0x001604D6 File Offset: 0x0015E6D6
		public void ReleaseGraphicsResources()
		{
			vtkOpenGLBufferObject.vtkOpenGLBufferObject_ReleaseGraphicsResources_14(base.GetCppThis());
		}

		// Token: 0x0600FCD9 RID: 64729
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBufferObject_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCDA RID: 64730 RVA: 0x001604E8 File Offset: 0x0015E6E8
		public new static vtkOpenGLBufferObject SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLBufferObject vtkOpenGLBufferObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBufferObject.vtkOpenGLBufferObject_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLBufferObject = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLBufferObject.Register(null);
				}
			}
			return vtkOpenGLBufferObject;
		}

		// Token: 0x0600FCDB RID: 64731
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLBufferObject_SetType_16(HandleRef pThis, vtkOpenGLBufferObject.ObjectType value);

		/// <summary>
		/// Set the type of the buffer object. 
		/// </summary>
		// Token: 0x0600FCDC RID: 64732 RVA: 0x00160567 File Offset: 0x0015E767
		public void SetType(vtkOpenGLBufferObject.ObjectType value)
		{
			vtkOpenGLBufferObject.vtkOpenGLBufferObject_SetType_16(base.GetCppThis(), value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001269 RID: 4713
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLBufferObject";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400126A RID: 4714
		public new static readonly string MRClassNameKey = "class vtkOpenGLBufferObject";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020005A1 RID: 1441
		public enum ObjectType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400126C RID: 4716
			ArrayBuffer,
			/// <summary>enum member</summary>
			// Token: 0x0400126D RID: 4717
			ElementArrayBuffer,
			/// <summary>enum member</summary>
			// Token: 0x0400126E RID: 4718
			TextureBuffer
		}
	}
}
