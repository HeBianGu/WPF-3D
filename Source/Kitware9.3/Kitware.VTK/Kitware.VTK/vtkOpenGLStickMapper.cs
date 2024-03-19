using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLStickMapper
	/// </summary>
	/// <remarks>
	///    use imposters to draw cylinders
	///
	/// PolyDataMapper that uses imposters to draw cylinders/sticks
	/// for ball/stick style molecular rendering. Supports picking.
	/// </remarks>
	// Token: 0x020005CD RID: 1485
	public class vtkOpenGLStickMapper : vtkOpenGLPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601038B RID: 66443 RVA: 0x0016976F File Offset: 0x0016796F
		static vtkOpenGLStickMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLStickMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLStickMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601038C RID: 66444 RVA: 0x00169797 File Offset: 0x00167997
		public vtkOpenGLStickMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601038D RID: 66445
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLStickMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601038E RID: 66446 RVA: 0x001697A8 File Offset: 0x001679A8
		public new static vtkOpenGLStickMapper New()
		{
			vtkOpenGLStickMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLStickMapper.vtkOpenGLStickMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLStickMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601038F RID: 66447 RVA: 0x001697FC File Offset: 0x001679FC
		public vtkOpenGLStickMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLStickMapper.vtkOpenGLStickMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010390 RID: 66448 RVA: 0x00169840 File Offset: 0x00167A40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010391 RID: 66449
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLStickMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010392 RID: 66450 RVA: 0x0016984C File Offset: 0x00167A4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLStickMapper.vtkOpenGLStickMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010393 RID: 66451
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLStickMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010394 RID: 66452 RVA: 0x0016986C File Offset: 0x00167A6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLStickMapper.vtkOpenGLStickMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010395 RID: 66453
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLStickMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010396 RID: 66454 RVA: 0x00169888 File Offset: 0x00167A88
		public override int IsA(string type)
		{
			return vtkOpenGLStickMapper.vtkOpenGLStickMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010397 RID: 66455
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLStickMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010398 RID: 66456 RVA: 0x001698A8 File Offset: 0x00167AA8
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLStickMapper.vtkOpenGLStickMapper_IsTypeOf_04(type);
		}

		// Token: 0x06010399 RID: 66457
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLStickMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601039A RID: 66458 RVA: 0x001698C4 File Offset: 0x00167AC4
		public new vtkOpenGLStickMapper NewInstance()
		{
			vtkOpenGLStickMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLStickMapper.vtkOpenGLStickMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLStickMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601039B RID: 66459
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLStickMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601039C RID: 66460 RVA: 0x00169920 File Offset: 0x00167B20
		public new static vtkOpenGLStickMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLStickMapper vtkOpenGLStickMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLStickMapper.vtkOpenGLStickMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLStickMapper = (vtkOpenGLStickMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLStickMapper.Register(null);
				}
			}
			return vtkOpenGLStickMapper;
		}

		// Token: 0x0601039D RID: 66461
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLStickMapper_SetOrientationArray_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Convenience method to set the array to orient with
		/// </summary>
		// Token: 0x0601039E RID: 66462 RVA: 0x0016999F File Offset: 0x00167B9F
		public virtual void SetOrientationArray(string _arg)
		{
			vtkOpenGLStickMapper.vtkOpenGLStickMapper_SetOrientationArray_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0601039F RID: 66463
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLStickMapper_SetScaleArray_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Convenience method to set the array to scale with.
		/// </summary>
		// Token: 0x060103A0 RID: 66464 RVA: 0x001699AF File Offset: 0x00167BAF
		public virtual void SetScaleArray(string _arg)
		{
			vtkOpenGLStickMapper.vtkOpenGLStickMapper_SetScaleArray_09(base.GetCppThis(), _arg);
		}

		// Token: 0x060103A1 RID: 66465
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLStickMapper_SetSelectionIdArray_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Convenience method to set the array to select with
		/// </summary>
		// Token: 0x060103A2 RID: 66466 RVA: 0x001699BF File Offset: 0x00167BBF
		public virtual void SetSelectionIdArray(string _arg)
		{
			vtkOpenGLStickMapper.vtkOpenGLStickMapper_SetSelectionIdArray_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012DF RID: 4831
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLStickMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012E0 RID: 4832
		public new static readonly string MRClassNameKey = "class vtkOpenGLStickMapper";
	}
}
