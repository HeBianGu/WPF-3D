using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkOpenGLBillboardTextActor3D
	/// </summary>
	/// <remarks>
	///  Handles GL2PS capture of billboard text.
	/// </remarks>
	// Token: 0x0200059F RID: 1439
	public class vtkOpenGLBillboardTextActor3D : vtkBillboardTextActor3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FCA5 RID: 64677 RVA: 0x0015FFC3 File Offset: 0x0015E1C3
		static vtkOpenGLBillboardTextActor3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLBillboardTextActor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLBillboardTextActor3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FCA6 RID: 64678 RVA: 0x0015FFEB File Offset: 0x0015E1EB
		public vtkOpenGLBillboardTextActor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FCA7 RID: 64679
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBillboardTextActor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCA8 RID: 64680 RVA: 0x0015FFFC File Offset: 0x0015E1FC
		public new static vtkOpenGLBillboardTextActor3D New()
		{
			vtkOpenGLBillboardTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCA9 RID: 64681 RVA: 0x00160050 File Offset: 0x0015E250
		public vtkOpenGLBillboardTextActor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FCAA RID: 64682 RVA: 0x00160094 File Offset: 0x0015E294
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FCAB RID: 64683
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLBillboardTextActor3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCAC RID: 64684 RVA: 0x001600A0 File Offset: 0x0015E2A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FCAD RID: 64685
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLBillboardTextActor3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCAE RID: 64686 RVA: 0x001600C0 File Offset: 0x0015E2C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FCAF RID: 64687
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBillboardTextActor3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCB0 RID: 64688 RVA: 0x001600DC File Offset: 0x0015E2DC
		public override int IsA(string type)
		{
			return vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FCB1 RID: 64689
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBillboardTextActor3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCB2 RID: 64690 RVA: 0x001600FC File Offset: 0x0015E2FC
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_IsTypeOf_04(type);
		}

		// Token: 0x0600FCB3 RID: 64691
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBillboardTextActor3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCB4 RID: 64692 RVA: 0x00160118 File Offset: 0x0015E318
		public new vtkOpenGLBillboardTextActor3D NewInstance()
		{
			vtkOpenGLBillboardTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FCB5 RID: 64693
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLBillboardTextActor3D_RenderTranslucentPolygonalGeometry_07(HandleRef pThis, HandleRef vp);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCB6 RID: 64694 RVA: 0x00160174 File Offset: 0x0015E374
		public override int RenderTranslucentPolygonalGeometry(vtkViewport vp)
		{
			return vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_RenderTranslucentPolygonalGeometry_07(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x0600FCB7 RID: 64695
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLBillboardTextActor3D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCB8 RID: 64696 RVA: 0x001601A8 File Offset: 0x0015E3A8
		public new static vtkOpenGLBillboardTextActor3D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLBillboardTextActor3D vtkOpenGLBillboardTextActor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLBillboardTextActor3D.vtkOpenGLBillboardTextActor3D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLBillboardTextActor3D = (vtkOpenGLBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLBillboardTextActor3D.Register(null);
				}
			}
			return vtkOpenGLBillboardTextActor3D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001267 RID: 4711
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLBillboardTextActor3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001268 RID: 4712
		public new static readonly string MRClassNameKey = "class vtkOpenGLBillboardTextActor3D";
	}
}
