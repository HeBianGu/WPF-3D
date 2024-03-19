using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLLabeledContourMapper
	///
	/// vtkOpenGLLabeledContourMapper is an override for vtkLabeledContourMapper
	/// that implements stenciling using the OpenGL2 API.
	/// </summary>
	// Token: 0x020005BC RID: 1468
	public class vtkOpenGLLabeledContourMapper : vtkLabeledContourMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010113 RID: 65811 RVA: 0x00165F33 File Offset: 0x00164133
		static vtkOpenGLLabeledContourMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLLabeledContourMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLLabeledContourMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010114 RID: 65812 RVA: 0x00165F5B File Offset: 0x0016415B
		public vtkOpenGLLabeledContourMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010115 RID: 65813
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLLabeledContourMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010116 RID: 65814 RVA: 0x00165F6C File Offset: 0x0016416C
		public new static vtkOpenGLLabeledContourMapper New()
		{
			vtkOpenGLLabeledContourMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010117 RID: 65815 RVA: 0x00165FC0 File Offset: 0x001641C0
		public vtkOpenGLLabeledContourMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010118 RID: 65816 RVA: 0x00166004 File Offset: 0x00164204
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010119 RID: 65817
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLLabeledContourMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601011A RID: 65818 RVA: 0x00166010 File Offset: 0x00164210
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601011B RID: 65819
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLLabeledContourMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601011C RID: 65820 RVA: 0x00166030 File Offset: 0x00164230
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601011D RID: 65821
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLLabeledContourMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601011E RID: 65822 RVA: 0x0016604C File Offset: 0x0016424C
		public override int IsA(string type)
		{
			return vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601011F RID: 65823
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLLabeledContourMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010120 RID: 65824 RVA: 0x0016606C File Offset: 0x0016426C
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_IsTypeOf_04(type);
		}

		// Token: 0x06010121 RID: 65825
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLLabeledContourMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010122 RID: 65826 RVA: 0x00166088 File Offset: 0x00164288
		public new vtkOpenGLLabeledContourMapper NewInstance()
		{
			vtkOpenGLLabeledContourMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010123 RID: 65827
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLLabeledContourMapper_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Release graphics resources
		/// </summary>
		// Token: 0x06010124 RID: 65828 RVA: 0x001660E4 File Offset: 0x001642E4
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_ReleaseGraphicsResources_07(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06010125 RID: 65829
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLLabeledContourMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010126 RID: 65830 RVA: 0x00166114 File Offset: 0x00164314
		public new static vtkOpenGLLabeledContourMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLLabeledContourMapper vtkOpenGLLabeledContourMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLLabeledContourMapper.vtkOpenGLLabeledContourMapper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLLabeledContourMapper = (vtkOpenGLLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLLabeledContourMapper.Register(null);
				}
			}
			return vtkOpenGLLabeledContourMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012BA RID: 4794
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLLabeledContourMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012BB RID: 4795
		public new static readonly string MRClassNameKey = "class vtkOpenGLLabeledContourMapper";
	}
}
