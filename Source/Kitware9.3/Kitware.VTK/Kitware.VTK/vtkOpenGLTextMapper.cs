using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLTextMapper
	/// </summary>
	/// <remarks>
	///    vtkTextMapper override for OpenGL2.
	/// </remarks>
	// Token: 0x020005D5 RID: 1493
	public class vtkOpenGLTextMapper : vtkTextMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060104BF RID: 66751 RVA: 0x0016B5AF File Offset: 0x001697AF
		static vtkOpenGLTextMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLTextMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLTextMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060104C0 RID: 66752 RVA: 0x0016B5D7 File Offset: 0x001697D7
		public vtkOpenGLTextMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060104C1 RID: 66753
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104C2 RID: 66754 RVA: 0x0016B5E8 File Offset: 0x001697E8
		public new static vtkOpenGLTextMapper New()
		{
			vtkOpenGLTextMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextMapper.vtkOpenGLTextMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTextMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104C3 RID: 66755 RVA: 0x0016B63C File Offset: 0x0016983C
		public vtkOpenGLTextMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLTextMapper.vtkOpenGLTextMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060104C4 RID: 66756 RVA: 0x0016B680 File Offset: 0x00169880
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060104C5 RID: 66757
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTextMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104C6 RID: 66758 RVA: 0x0016B68C File Offset: 0x0016988C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLTextMapper.vtkOpenGLTextMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060104C7 RID: 66759
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTextMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104C8 RID: 66760 RVA: 0x0016B6AC File Offset: 0x001698AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLTextMapper.vtkOpenGLTextMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060104C9 RID: 66761
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104CA RID: 66762 RVA: 0x0016B6C8 File Offset: 0x001698C8
		public override int IsA(string type)
		{
			return vtkOpenGLTextMapper.vtkOpenGLTextMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060104CB RID: 66763
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTextMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104CC RID: 66764 RVA: 0x0016B6E8 File Offset: 0x001698E8
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLTextMapper.vtkOpenGLTextMapper_IsTypeOf_04(type);
		}

		// Token: 0x060104CD RID: 66765
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104CE RID: 66766 RVA: 0x0016B704 File Offset: 0x00169904
		public new vtkOpenGLTextMapper NewInstance()
		{
			vtkOpenGLTextMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextMapper.vtkOpenGLTextMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTextMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060104CF RID: 66767
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTextMapper_RenderOverlay_07(HandleRef pThis, HandleRef vp, HandleRef act);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104D0 RID: 66768 RVA: 0x0016B760 File Offset: 0x00169960
		public override void RenderOverlay(vtkViewport vp, vtkActor2D act)
		{
			vtkOpenGLTextMapper.vtkOpenGLTextMapper_RenderOverlay_07(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x060104D1 RID: 66769
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTextMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104D2 RID: 66770 RVA: 0x0016B7A4 File Offset: 0x001699A4
		public new static vtkOpenGLTextMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLTextMapper vtkOpenGLTextMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTextMapper.vtkOpenGLTextMapper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLTextMapper = (vtkOpenGLTextMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLTextMapper.Register(null);
				}
			}
			return vtkOpenGLTextMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012F1 RID: 4849
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLTextMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012F2 RID: 4850
		public new static readonly string MRClassNameKey = "class vtkOpenGLTextMapper";
	}
}
