using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLSphereMapper
	/// </summary>
	/// <remarks>
	///    draw spheres using imposters
	///
	/// An OpenGL mapper that uses imposters to draw spheres. Supports
	/// transparency and picking as well.
	/// </remarks>
	// Token: 0x020005CC RID: 1484
	public class vtkOpenGLSphereMapper : vtkOpenGLPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010371 RID: 66417 RVA: 0x001694BB File Offset: 0x001676BB
		static vtkOpenGLSphereMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLSphereMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLSphereMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010372 RID: 66418 RVA: 0x001694E3 File Offset: 0x001676E3
		public vtkOpenGLSphereMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010373 RID: 66419
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLSphereMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010374 RID: 66420 RVA: 0x001694F4 File Offset: 0x001676F4
		public new static vtkOpenGLSphereMapper New()
		{
			vtkOpenGLSphereMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLSphereMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010375 RID: 66421 RVA: 0x00169548 File Offset: 0x00167748
		public vtkOpenGLSphereMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010376 RID: 66422 RVA: 0x0016958C File Offset: 0x0016778C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010377 RID: 66423
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLSphereMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010378 RID: 66424 RVA: 0x00169598 File Offset: 0x00167798
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010379 RID: 66425
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLSphereMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601037A RID: 66426 RVA: 0x001695B8 File Offset: 0x001677B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601037B RID: 66427
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLSphereMapper_GetRadius_03(HandleRef pThis);

		/// <summary>
		/// This value will be used for the radius is the scale
		/// array is not provided.
		/// </summary>
		// Token: 0x0601037C RID: 66428 RVA: 0x001695D4 File Offset: 0x001677D4
		public virtual float GetRadius()
		{
			return vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_GetRadius_03(base.GetCppThis());
		}

		// Token: 0x0601037D RID: 66429
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLSphereMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601037E RID: 66430 RVA: 0x001695F4 File Offset: 0x001677F4
		public override int IsA(string type)
		{
			return vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601037F RID: 66431
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLSphereMapper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010380 RID: 66432 RVA: 0x00169614 File Offset: 0x00167814
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_IsTypeOf_05(type);
		}

		// Token: 0x06010381 RID: 66433
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLSphereMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010382 RID: 66434 RVA: 0x00169630 File Offset: 0x00167830
		public new vtkOpenGLSphereMapper NewInstance()
		{
			vtkOpenGLSphereMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLSphereMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010383 RID: 66435
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLSphereMapper_Render_08(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// This calls RenderPiece (twice when transparent)
		/// </summary>
		// Token: 0x06010384 RID: 66436 RVA: 0x0016968C File Offset: 0x0016788C
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x06010385 RID: 66437
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLSphereMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010386 RID: 66438 RVA: 0x001696D0 File Offset: 0x001678D0
		public new static vtkOpenGLSphereMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLSphereMapper vtkOpenGLSphereMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLSphereMapper = (vtkOpenGLSphereMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLSphereMapper.Register(null);
				}
			}
			return vtkOpenGLSphereMapper;
		}

		// Token: 0x06010387 RID: 66439
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLSphereMapper_SetRadius_10(HandleRef pThis, float _arg);

		/// <summary>
		/// This value will be used for the radius is the scale
		/// array is not provided.
		/// </summary>
		// Token: 0x06010388 RID: 66440 RVA: 0x0016974F File Offset: 0x0016794F
		public virtual void SetRadius(float _arg)
		{
			vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_SetRadius_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06010389 RID: 66441
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLSphereMapper_SetScaleArray_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Convenience method to set the array to scale with.
		/// </summary>
		// Token: 0x0601038A RID: 66442 RVA: 0x0016975F File Offset: 0x0016795F
		public virtual void SetScaleArray(string _arg)
		{
			vtkOpenGLSphereMapper.vtkOpenGLSphereMapper_SetScaleArray_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012DD RID: 4829
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLSphereMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012DE RID: 4830
		public new static readonly string MRClassNameKey = "class vtkOpenGLSphereMapper";
	}
}
