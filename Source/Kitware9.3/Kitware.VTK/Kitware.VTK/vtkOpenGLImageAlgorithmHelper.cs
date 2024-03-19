using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLImageAlgorithmHelper
	/// </summary>
	/// <remarks>
	///    Help image algorithms use the GPU
	///
	/// Designed to make it easier to accelerate an image algorithm on the GPU
	/// </remarks>
	// Token: 0x020005B5 RID: 1461
	public class vtkOpenGLImageAlgorithmHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FFE1 RID: 65505 RVA: 0x001641C7 File Offset: 0x001623C7
		static vtkOpenGLImageAlgorithmHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLImageAlgorithmHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLImageAlgorithmHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFE2 RID: 65506 RVA: 0x001641EF File Offset: 0x001623EF
		public vtkOpenGLImageAlgorithmHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FFE3 RID: 65507
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageAlgorithmHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFE4 RID: 65508 RVA: 0x00164200 File Offset: 0x00162400
		public new static vtkOpenGLImageAlgorithmHelper New()
		{
			vtkOpenGLImageAlgorithmHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLImageAlgorithmHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFE5 RID: 65509 RVA: 0x00164254 File Offset: 0x00162454
		public vtkOpenGLImageAlgorithmHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFE6 RID: 65510 RVA: 0x00164298 File Offset: 0x00162498
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FFE7 RID: 65511
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLImageAlgorithmHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFE8 RID: 65512 RVA: 0x001642A4 File Offset: 0x001624A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FFE9 RID: 65513
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLImageAlgorithmHelper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFEA RID: 65514 RVA: 0x001642C4 File Offset: 0x001624C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FFEB RID: 65515
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLImageAlgorithmHelper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFEC RID: 65516 RVA: 0x001642E0 File Offset: 0x001624E0
		public override int IsA(string type)
		{
			return vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FFED RID: 65517
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLImageAlgorithmHelper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFEE RID: 65518 RVA: 0x00164300 File Offset: 0x00162500
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_IsTypeOf_04(type);
		}

		// Token: 0x0600FFEF RID: 65519
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageAlgorithmHelper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFF0 RID: 65520 RVA: 0x0016431C File Offset: 0x0016251C
		public new vtkOpenGLImageAlgorithmHelper NewInstance()
		{
			vtkOpenGLImageAlgorithmHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLImageAlgorithmHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FFF1 RID: 65521
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageAlgorithmHelper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFF2 RID: 65522 RVA: 0x00164378 File Offset: 0x00162578
		public new static vtkOpenGLImageAlgorithmHelper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLImageAlgorithmHelper vtkOpenGLImageAlgorithmHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLImageAlgorithmHelper = (vtkOpenGLImageAlgorithmHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLImageAlgorithmHelper.Register(null);
				}
			}
			return vtkOpenGLImageAlgorithmHelper;
		}

		// Token: 0x0600FFF3 RID: 65523
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLImageAlgorithmHelper_SetRenderWindow_08(HandleRef pThis, HandleRef renWin);

		/// <summary>
		/// Set the render window to get the OpenGL resources from
		/// </summary>
		// Token: 0x0600FFF4 RID: 65524 RVA: 0x001643F8 File Offset: 0x001625F8
		public void SetRenderWindow(vtkRenderWindow renWin)
		{
			vtkOpenGLImageAlgorithmHelper.vtkOpenGLImageAlgorithmHelper_SetRenderWindow_08(base.GetCppThis(), (renWin == null) ? default(HandleRef) : renWin.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012AC RID: 4780
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLImageAlgorithmHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012AD RID: 4781
		public new static readonly string MRClassNameKey = "class vtkOpenGLImageAlgorithmHelper";
	}
}
