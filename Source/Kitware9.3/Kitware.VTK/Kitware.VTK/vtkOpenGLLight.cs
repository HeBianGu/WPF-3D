using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLLight
	/// </summary>
	/// <remarks>
	///    OpenGL light
	///
	/// vtkOpenGLLight is a concrete implementation of the abstract class vtkLight.
	/// vtkOpenGLLight interfaces to the OpenGL rendering library.
	/// </remarks>
	// Token: 0x020005BD RID: 1469
	public class vtkOpenGLLight : vtkLight
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010127 RID: 65831 RVA: 0x00166193 File Offset: 0x00164393
		static vtkOpenGLLight()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLLight"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010128 RID: 65832 RVA: 0x001661BB File Offset: 0x001643BB
		public vtkOpenGLLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010129 RID: 65833
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601012A RID: 65834 RVA: 0x001661CC File Offset: 0x001643CC
		public new static vtkOpenGLLight New()
		{
			vtkOpenGLLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLLight.vtkOpenGLLight_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601012B RID: 65835 RVA: 0x00166220 File Offset: 0x00164420
		public vtkOpenGLLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLLight.vtkOpenGLLight_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601012C RID: 65836 RVA: 0x00166264 File Offset: 0x00164464
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601012D RID: 65837
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLLight_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601012E RID: 65838 RVA: 0x00166270 File Offset: 0x00164470
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLLight.vtkOpenGLLight_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601012F RID: 65839
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLLight_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010130 RID: 65840 RVA: 0x00166290 File Offset: 0x00164490
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLLight.vtkOpenGLLight_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010131 RID: 65841
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLLight_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010132 RID: 65842 RVA: 0x001662AC File Offset: 0x001644AC
		public override int IsA(string type)
		{
			return vtkOpenGLLight.vtkOpenGLLight_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010133 RID: 65843
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLLight_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010134 RID: 65844 RVA: 0x001662CC File Offset: 0x001644CC
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLLight.vtkOpenGLLight_IsTypeOf_04(type);
		}

		// Token: 0x06010135 RID: 65845
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLLight_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010136 RID: 65846 RVA: 0x001662E8 File Offset: 0x001644E8
		public new vtkOpenGLLight NewInstance()
		{
			vtkOpenGLLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLLight.vtkOpenGLLight_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010137 RID: 65847
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLLight_Render_07(HandleRef pThis, HandleRef ren, int light_index);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x06010138 RID: 65848 RVA: 0x00166344 File Offset: 0x00164544
		public override void Render(vtkRenderer ren, int light_index)
		{
			vtkOpenGLLight.vtkOpenGLLight_Render_07(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), light_index);
		}

		// Token: 0x06010139 RID: 65849
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLLight_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601013A RID: 65850 RVA: 0x00166374 File Offset: 0x00164574
		public new static vtkOpenGLLight SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLLight vtkOpenGLLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLLight.vtkOpenGLLight_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLLight = (vtkOpenGLLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLLight.Register(null);
				}
			}
			return vtkOpenGLLight;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012BC RID: 4796
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLLight";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012BD RID: 4797
		public new static readonly string MRClassNameKey = "class vtkOpenGLLight";
	}
}
