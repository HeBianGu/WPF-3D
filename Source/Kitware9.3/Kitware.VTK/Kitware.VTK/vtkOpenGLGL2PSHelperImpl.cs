using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLGL2PSHelperImpl
	/// </summary>
	/// <remarks>
	///    vtkOpenGLGL2PSHelper override
	/// implementation.
	/// </remarks>
	// Token: 0x020001B3 RID: 435
	public class vtkOpenGLGL2PSHelperImpl : vtkOpenGLGL2PSHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060053D9 RID: 21465 RVA: 0x00079FD9 File Offset: 0x000781D9
		static vtkOpenGLGL2PSHelperImpl()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLGL2PSHelperImpl.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGL2PSHelperImpl"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060053DA RID: 21466 RVA: 0x0007A001 File Offset: 0x00078201
		public vtkOpenGLGL2PSHelperImpl(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060053DB RID: 21467
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelperImpl_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053DC RID: 21468 RVA: 0x0007A010 File Offset: 0x00078210
		public new static vtkOpenGLGL2PSHelperImpl New()
		{
			vtkOpenGLGL2PSHelperImpl result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGL2PSHelperImpl)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053DD RID: 21469 RVA: 0x0007A064 File Offset: 0x00078264
		public vtkOpenGLGL2PSHelperImpl() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060053DE RID: 21470 RVA: 0x0007A0A8 File Offset: 0x000782A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060053DF RID: 21471
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelperImpl_Draw3DPath_01(HandleRef pThis, HandleRef path, HandleRef actorMatrix, IntPtr rasterPos, IntPtr actorColor, HandleRef ren, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053E0 RID: 21472 RVA: 0x0007A0B4 File Offset: 0x000782B4
		public override void Draw3DPath(vtkPath path, vtkMatrix4x4 actorMatrix, IntPtr rasterPos, IntPtr actorColor, vtkRenderer ren, string label)
		{
			vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_Draw3DPath_01(base.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis(), (actorMatrix == null) ? default(HandleRef) : actorMatrix.GetCppThis(), rasterPos, actorColor, (ren == null) ? default(HandleRef) : ren.GetCppThis(), label);
		}

		// Token: 0x060053E1 RID: 21473
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelperImpl_DrawImage_02(HandleRef pThis, HandleRef input, IntPtr pos);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053E2 RID: 21474 RVA: 0x0007A114 File Offset: 0x00078314
		public override void DrawImage(vtkImageData input, IntPtr pos)
		{
			vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_DrawImage_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), pos);
		}

		// Token: 0x060053E3 RID: 21475
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelperImpl_DrawPath_03(HandleRef pThis, HandleRef path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053E4 RID: 21476 RVA: 0x0007A144 File Offset: 0x00078344
		public override void DrawPath(vtkPath path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, string label)
		{
			vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_DrawPath_03(base.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis(), rasterPos, windowPos, rgba, scale, rotateAngle, strokeWidth, label);
		}

		// Token: 0x060053E5 RID: 21477
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelperImpl_DrawString_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef tprop, IntPtr pos, double backgroundDepth, HandleRef ren);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053E6 RID: 21478 RVA: 0x0007A180 File Offset: 0x00078380
		public override void DrawString(string str, vtkTextProperty tprop, IntPtr pos, double backgroundDepth, vtkRenderer ren)
		{
			vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_DrawString_04(base.GetCppThis(), str, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), pos, backgroundDepth, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060053E7 RID: 21479
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053E8 RID: 21480 RVA: 0x0007A1CC File Offset: 0x000783CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060053E9 RID: 21481
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053EA RID: 21482 RVA: 0x0007A1EC File Offset: 0x000783EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060053EB RID: 21483
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGL2PSHelperImpl_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053EC RID: 21484 RVA: 0x0007A208 File Offset: 0x00078408
		public override int IsA(string type)
		{
			return vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060053ED RID: 21485
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGL2PSHelperImpl_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053EE RID: 21486 RVA: 0x0007A228 File Offset: 0x00078428
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_IsTypeOf_08(type);
		}

		// Token: 0x060053EF RID: 21487
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelperImpl_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053F0 RID: 21488 RVA: 0x0007A244 File Offset: 0x00078444
		public new vtkOpenGLGL2PSHelperImpl NewInstance()
		{
			vtkOpenGLGL2PSHelperImpl result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGL2PSHelperImpl)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060053F1 RID: 21489
		[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelperImpl_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053F2 RID: 21490 RVA: 0x0007A2A0 File Offset: 0x000784A0
		public new static vtkOpenGLGL2PSHelperImpl SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLGL2PSHelperImpl vtkOpenGLGL2PSHelperImpl = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelperImpl.vtkOpenGLGL2PSHelperImpl_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGL2PSHelperImpl = (vtkOpenGLGL2PSHelperImpl)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGL2PSHelperImpl.Register(null);
				}
			}
			return vtkOpenGLGL2PSHelperImpl;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007D3 RID: 2003
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGL2PSHelperImpl";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007D4 RID: 2004
		public new static readonly string MRClassNameKey = "class vtkOpenGLGL2PSHelperImpl";
	}
}
